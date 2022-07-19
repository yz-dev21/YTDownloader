using VideoLibrary;

namespace YTDownloader2
{
    public enum Formats
    {
        MP3,
        MP4
    }
    public enum Results
    {
        Good,
        InvalidUrl,
        InvalidName,
        InvalidPath,
        InvalidVideo,
        Unknown
    }
    public class Video
    {
        public string Url { get; set; }
        public string Name { get; set; }
        public Formats Format { get; set; }
        public string FormatString
        {
            get
            {
                if (Format == Formats.MP3)
                    return ".mp3";
                else
                    return ".mp4";
            }
        }
        public string Path { get; set; }
        public bool Visible { get; set; }
        public bool BlockSave { get; set; }
        private List<byte> _data;
        public Video()
        {
            Url = string.Empty;
            Name = string.Empty;
            Format = Formats.MP3;
            Path = string.Empty;
            Visible = true;
            BlockSave = false;
            _data = new List<byte>();
        }
        public async Task<Results> Save()
        {
            BlockSave = true;
            try
            {
                var youtube = YouTube.Default;
                var video = await youtube.GetVideoAsync(Url);

                if (string.IsNullOrEmpty(Name)) Name = video.FullName;

                _data = (await video.GetBytesAsync()).ToList();
            }
            catch (ArgumentException ex)
            {
                return Results.InvalidUrl;
            }
            catch
            {
                return Results.InvalidVideo;
            }
            try
            {
                await File.WriteAllBytesAsync($@"{Path}\{Name}{FormatString}", _data.ToArray());
            }
            catch
            {
                return Results.InvalidPath;
            }
            BlockSave = false;
            return Results.Good;
        }
    }
}