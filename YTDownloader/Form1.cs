using VideoLibrary;
using MediaToolkit;
using System.Windows.Forms;
using System.IO;

namespace YTDownloader
{
    public partial class YTDForm : Form
    {
        public YTDForm()
        {
            InitializeComponent();
            MP3RadioButton.Checked = true;
            MP4RadioButton.Checked = false;
        }

        private void BrowseButton_Click(object sender, System.EventArgs e)
        {
            using (FolderBrowserDialog fdb = new FolderBrowserDialog() { Description = "Select your path" })
            {
                if (fdb.ShowDialog() == DialogResult.OK)
                {
                    PathBox.Text = fdb.SelectedPath;
                }
            }
        }
        private async void DownloadButton_Click(object sender, System.EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(UrlBox.Text) || string.IsNullOrWhiteSpace(PathBox.Text))
                return;

            DownloadButton.Enabled = false;

            ProgressBar.Minimum = 0;
            ProgressBar.Maximum = 100;

            ProgressBar.Value = 0;

            YouTubeVideo video = null;
            try
            {
                var youtube = YouTube.Default;
                video = await youtube.GetVideoAsync(UrlBox.Text);
            }
            catch
            {
                DownloadButton.Enabled = true;
                return;
            }

            string fileName = video.FullName;
            if (!string.IsNullOrWhiteSpace(NameBox.Text))
            {
                fileName = NameBox.Text;
            }

            ProgressBar.Value = 30;

            try
            {
                File.WriteAllBytes($@"{PathBox.Text}\{fileName}.mp4", await video.GetBytesAsync());
            }
            catch
            {
                DownloadButton.Enabled = true;
                return;
            }
            if (MP3RadioButton.Checked)
            {
                ProgressBar.Value = 60;

                var inputFile = new MediaToolkit.Model.MediaFile { Filename = $@"{PathBox.Text}\{fileName}.mp4" };
                var outputFile = new MediaToolkit.Model.MediaFile { Filename = $@"{PathBox.Text}\{fileName}.mp3" };
                using (var engine = new Engine())
                {
                    engine.GetMetadata(inputFile);
                    engine.Convert(inputFile, outputFile);
                }

                ProgressBar.Value = 80;

                File.Delete($@"{PathBox.Text}\{fileName}.mp4");
            }

            ProgressBar.Value = 100;
            DownloadButton.Enabled = true;
        }
    }
}