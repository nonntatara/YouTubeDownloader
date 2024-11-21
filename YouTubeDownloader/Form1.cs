//namespace YouTubeDownloader
//{
//    public partial class Form1 : Form
//    {
//        public Form1()
//        {
//            InitializeComponent();
//        }
//    }
//}

//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Linq;
//using System.Threading;
//using System.Threading.Tasks;
//using System.Windows.Forms;

//namespace YouTubeDownloader
//{
//    public partial class Form1 : Form
//    {
//        private List<string> videoUrls = new List<string>();
//        private int downloadCount = 0;
//        private CancellationTokenSource cancellationTokenSource;

//        public Form1()
//        {
//            InitializeComponent();
//        }

//        // Browse file to load URLs
//        private void btnBrowseFile_Click(object sender, EventArgs e)
//        {
//            using (OpenFileDialog openFileDialog = new OpenFileDialog())
//            {
//                openFileDialog.Filter = "Text Files|*.txt";
//                if (openFileDialog.ShowDialog() == DialogResult.OK)
//                {
//                    string[] urls = File.ReadAllLines(openFileDialog.FileName);
//                    videoUrls.Clear();
//                    videoUrls.AddRange(urls);
//                    lblStatus.Text = "URLs loaded.";
//                }
//            }
//        }

//        // Browse yt-dlp.exe file
//        private void btnBrowseYtdlp_Click(object sender, EventArgs e)
//        {
//            using (OpenFileDialog openFileDialog = new OpenFileDialog())
//            {
//                openFileDialog.Filter = "Executable Files|*.exe";
//                if (openFileDialog.ShowDialog() == DialogResult.OK)
//                {
//                    txtYtdlpExe.Text = openFileDialog.FileName;
//                }
//            }
//        }

//        // Browse ffmpeg.exe file
//        private void btnBrowseFfmpeg_Click(object sender, EventArgs e)
//        {
//            using (OpenFileDialog openFileDialog = new OpenFileDialog())
//            {
//                openFileDialog.Filter = "Executable Files|*.exe";
//                if (openFileDialog.ShowDialog() == DialogResult.OK)
//                {
//                    txtFfmpegExe.Text = openFileDialog.FileName;
//                }
//            }
//        }

//        // Browse directory to save videos
//        private void btnSaveTo_Click(object sender, EventArgs e)
//        {
//            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
//            {
//                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
//                {
//                    txtSaveTo.Text = folderBrowserDialog.SelectedPath;
//                }
//            }
//        }

//        // Start video download
//        private async void btnStartDownload_Click(object sender, EventArgs e)
//        {
//            if (videoUrls.Count == 0 || string.IsNullOrEmpty(txtYtdlpExe.Text) || string.IsNullOrEmpty(txtFfmpegExe.Text) || string.IsNullOrEmpty(txtSaveTo.Text))
//            {
//                MessageBox.Show("Please ensure all fields are filled in properly.");
//                return;
//            }

//            lblStatus.Text = "Downloading...";
//            downloadCount = 0;
//            lblCount.Text = $"Downloaded: {downloadCount}/{videoUrls.Count}";

//            cancellationTokenSource = new CancellationTokenSource();
//            var cancellationToken = cancellationTokenSource.Token;

//            try
//            {
//                // Use parallel task to download videos
//                var tasks = new List<Task>();
//                foreach (var url in videoUrls)
//                {
//                    tasks.Add(Task.Run(() => DownloadVideo(url, cancellationToken)));
//                }

//                await Task.WhenAll(tasks);

//                lblStatus.Text = "Download completed.";
//            }
//            catch (OperationCanceledException)
//            {
//                lblStatus.Text = "Download cancelled.";
//            }
//        }

//        // Cancel the download
//        private void btnCancel_Click(object sender, EventArgs e)
//        {
//            cancellationTokenSource?.Cancel();
//        }

//        // Method to download a single video
//        private void DownloadVideo(string url, CancellationToken cancellationToken)
//        {
//            string savePath = Path.Combine(txtSaveTo.Text, $"{Path.GetFileName(url)}.mp4");

//            // Prepare the command to run yt-dlp
//            string ytDlpCommand = $"\"{txtYtdlpExe.Text}\" -o \"{savePath}\" {url}";

//            // Set up the process for yt-dlp
//            var startInfo = new System.Diagnostics.ProcessStartInfo
//            {
//                FileName = "cmd.exe",
//                Arguments = $"/c {ytDlpCommand}",
//                CreateNoWindow = true,
//                UseShellExecute = false,
//                RedirectStandardOutput = true,
//                RedirectStandardError = true
//            };

//            using (var process = System.Diagnostics.Process.Start(startInfo))
//            {
//                process.OutputDataReceived += (s, e) =>
//                {
//                    txtCmd.AppendText(e.Data + Environment.NewLine);
//                };

//                process.ErrorDataReceived += (s, e) =>
//                {
//                    txtCmd.AppendText(e.Data + Environment.NewLine);
//                };

//                process.BeginOutputReadLine();
//                process.BeginErrorReadLine();

//                process.WaitForExit();
//            }

//            // Update the count
//            Invoke((Action)(() =>
//            {
//                downloadCount++;
//                lblCount.Text = $"Downloaded: {downloadCount}/{videoUrls.Count}";
//            }));
//        }
//    }
//}


using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YouTubeDownloader
{
    public partial class Form1 : Form
    {
        private int downloadCount = 0;
        private CancellationTokenSource cancellationTokenSource;
        private CancellationToken cancellationToken;
        private List<string> videoUrls = new List<string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnBrowseFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Text Files (*.txt)|*.txt";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    txtFilePath.Text = openFileDialog.FileName;
                    videoUrls = File.ReadLines(txtFilePath.Text).ToList();
                }
            }
        }

        private void btnBrowseYtdlp_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Executable Files (*.exe)|*.exe";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    txtYtdlpExe.Text = openFileDialog.FileName;
                }
            }
        }

        private void btnBrowseFfmpeg_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Executable Files (*.exe)|*.exe";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    txtFfmpegExe.Text = openFileDialog.FileName;
                }
            }
        }

        private void btnSaveTo_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
            {
                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    txtSaveTo.Text = folderDialog.SelectedPath;
                }
            }
        }

        private async void btnStartDownload_Click(object sender, EventArgs e)
        {
            // Initialize cancellation token for cancelling download
            cancellationTokenSource = new CancellationTokenSource();
            cancellationToken = cancellationTokenSource.Token;

            lblStatus.Text = "Downloading...";
            downloadCount = 0;
            lblCount.Text = "Downloaded: 0";
            txtCmd.Clear();

            // Fetch video URLs from file
            var videoUrls = File.ReadLines(txtFilePath.Text).ToList();

            // Create tasks for concurrent downloading
            var tasks = videoUrls.Select(url => Task.Run(() => DownloadVideo(url, cancellationToken))).ToArray();

            await Task.WhenAll(tasks);
            lblStatus.Text = "Download Complete!";
        }

        //private void DownloadVideo(string url, CancellationToken cancellationToken)
        //{
        //    try
        //    {
        //        string savePath = Path.Combine(txtSaveTo.Text, $"{Path.GetFileName(url)}.mp4");

        //        // Quote paths properly
        //        string ytDlpCommand = $"\"{txtYtdlpExe.Text}\" -o \"{savePath}\" \"{url}\"";

        //        // Start yt-dlp using cmd.exe
        //        var startInfo = new ProcessStartInfo
        //        {
        //            FileName = "cmd.exe",
        //            Arguments = $"/c {ytDlpCommand}",
        //            CreateNoWindow = true,
        //            UseShellExecute = false,
        //            RedirectStandardOutput = true,
        //            RedirectStandardError = true
        //        };

        //        using (var process = Process.Start(startInfo))
        //        {
        //            process.OutputDataReceived += (s, e) =>
        //            {
        //                if (e.Data != null)
        //                {
        //                    Invoke(new Action(() => txtCmd.AppendText(e.Data + Environment.NewLine)));
        //                }
        //            };

        //            process.ErrorDataReceived += (s, e) =>
        //            {
        //                if (e.Data != null)
        //                {
        //                    Invoke(new Action(() => txtCmd.AppendText(e.Data + Environment.NewLine)));
        //                }
        //            };

        //            process.BeginOutputReadLine();
        //            process.BeginErrorReadLine();

        //            process.WaitForExit();
        //        }

        //        // Update the download count on the UI thread
        //        Invoke((Action)(() =>
        //        {
        //            downloadCount++;
        //            lblCount.Text = $"Downloaded: {downloadCount}/{videoUrls.Count}";
        //        }));
        //    }
        //    catch (Exception ex)
        //    {
        //        Invoke(new Action(() => txtCmd.AppendText($"Error: {ex.Message}\n")));
        //    }
        //}




        //private void DownloadVideo(string url, CancellationToken cancellationToken)
        //{
        //    try
        //    {
        //        // Get the save path for the video
        //        string savePath = Path.Combine(txtSaveTo.Text, $"{Path.GetFileName(url)}.mp4");

        //        // Ensure yt-dlp path is quoted properly
        //        string ytDlpCommand = $"\"{txtYtdlpExe.Text}\" -o \"{savePath}\" \"{url}\"";

        //        // Ensure that the yt-dlp path is correct
        //        if (string.IsNullOrEmpty(txtYtdlpExe.Text) || !File.Exists(txtYtdlpExe.Text))
        //        {
        //            Invoke(new Action(() => txtCmd.AppendText("Error: yt-dlp.exe not found!\n")));
        //            return;
        //        }

        //        // Create process to run yt-dlp
        //        var startInfo = new ProcessStartInfo
        //        {
        //            FileName = "cmd.exe",
        //            Arguments = $"/c {ytDlpCommand}",
        //            CreateNoWindow = true,
        //            UseShellExecute = false,
        //            RedirectStandardOutput = true,
        //            RedirectStandardError = true
        //        };

        //        using (var process = Process.Start(startInfo))
        //        {
        //            process.OutputDataReceived += (s, e) =>
        //            {
        //                if (e.Data != null)
        //                {
        //                    Invoke(new Action(() => txtCmd.AppendText(e.Data + Environment.NewLine)));
        //                }
        //            };

        //            process.ErrorDataReceived += (s, e) =>
        //            {
        //                if (e.Data != null)
        //                {
        //                    Invoke(new Action(() => txtCmd.AppendText(e.Data + Environment.NewLine)));
        //                }
        //            };

        //            process.BeginOutputReadLine();
        //            process.BeginErrorReadLine();

        //            process.WaitForExit();
        //        }

        //        // Update the download count on the UI thread
        //        Invoke((Action)(() =>
        //        {
        //            downloadCount++;
        //            lblCount.Text = $"Downloaded: {downloadCount}/{videoUrls.Count}";
        //        }));
        //    }
        //    catch (Exception ex)
        //    {
        //        Invoke(new Action(() => txtCmd.AppendText($"Error: {ex.Message}\n")));
        //    }
        //}



        //private void DownloadVideo(string url, CancellationToken cancellationToken)
        //{
        //    try
        //    {
        //        // Get the save path for the video
        //        string savePath = Path.Combine(txtSaveTo.Text, $"{Path.GetFileName(url)}.%(ext)s");

        //        // Ensure yt-dlp path is quoted properly
        //        string ytDlpCommand = $"\"{txtYtdlpExe.Text}\" -o \"{savePath}\" \"{url}\"";

        //        // Check if yt-dlp exists
        //        if (string.IsNullOrEmpty(txtYtdlpExe.Text) || !File.Exists(txtYtdlpExe.Text))
        //        {
        //            Invoke(new Action(() => txtCmd.AppendText("Error: yt-dlp.exe not found!\n")));
        //            return;
        //        }

        //        // Ensure cmd.exe can execute it properly
        //        var startInfo = new ProcessStartInfo
        //        {
        //            FileName = "cmd.exe",
        //            Arguments = $"/c \"{ytDlpCommand}\"",  // Ensure proper quoting for the entire command
        //            CreateNoWindow = true,
        //            UseShellExecute = false,
        //            RedirectStandardOutput = true,
        //            RedirectStandardError = true
        //        };

        //        using (var process = Process.Start(startInfo))
        //        {
        //            process.OutputDataReceived += (s, e) =>
        //            {
        //                if (e.Data != null)
        //                {
        //                    Invoke(new Action(() => txtCmd.AppendText(e.Data + Environment.NewLine)));
        //                }
        //            };

        //            process.ErrorDataReceived += (s, e) =>
        //            {
        //                if (e.Data != null)
        //                {
        //                    Invoke(new Action(() => txtCmd.AppendText(e.Data + Environment.NewLine)));
        //                }
        //            };

        //            process.BeginOutputReadLine();
        //            process.BeginErrorReadLine();

        //            process.WaitForExit();
        //        }

        //        // Update the download count on the UI thread
        //        Invoke((Action)(() =>
        //        {
        //            downloadCount++;
        //            lblCount.Text = $"Downloaded: {downloadCount}/{videoUrls.Count}";
        //        }));
        //    }
        //    catch (Exception ex)
        //    {
        //        Invoke(new Action(() => txtCmd.AppendText($"Error: {ex.Message}\n")));
        //    }
        //}

        private void DownloadVideo(string url, CancellationToken cancellationToken)
        {
            try
            {
                // Create the output path where the video will be saved using the video title
                // The '%(title)s' placeholder will be replaced with the video's title, and '%(ext)s' will get the correct file extension.
                string savePath = Path.Combine(txtSaveTo.Text, "%(title)s.%(ext)s");

                // Ensure yt-dlp path is quoted properly
                string ytDlpCommand = $"\"{txtYtdlpExe.Text}\" -o \"{savePath}\" \"{url}\"";

                // Check if yt-dlp exists
                if (string.IsNullOrEmpty(txtYtdlpExe.Text) || !File.Exists(txtYtdlpExe.Text))
                {
                    Invoke(new Action(() => txtCmd.AppendText("Error: yt-dlp.exe not found!\n")));
                    return;
                }

                // Ensure cmd.exe can execute it properly
                var startInfo = new ProcessStartInfo
                {
                    FileName = "cmd.exe",
                    Arguments = $"/c \"{ytDlpCommand}\"",  // Ensure proper quoting for the entire command
                    CreateNoWindow = true,
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true
                };

                using (var process = Process.Start(startInfo))
                {
                    process.OutputDataReceived += (s, e) =>
                    {
                        if (e.Data != null)
                        {
                            Invoke(new Action(() => txtCmd.AppendText(e.Data + Environment.NewLine)));
                        }
                    };

                    process.ErrorDataReceived += (s, e) =>
                    {
                        if (e.Data != null)
                        {
                            Invoke(new Action(() => txtCmd.AppendText(e.Data + Environment.NewLine)));
                        }
                    };

                    process.BeginOutputReadLine();
                    process.BeginErrorReadLine();

                    process.WaitForExit();
                }

                // Update the download count on the UI thread
                Invoke((Action)(() =>
                {
                    downloadCount++;
                    lblCount.Text = $"Downloaded: {downloadCount}/{videoUrls.Count}";
                }));
            }
            catch (Exception ex)
            {
                Invoke(new Action(() => txtCmd.AppendText($"Error: {ex.Message}\n")));
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            cancellationTokenSource?.Cancel();
            lblStatus.Text = "Cancelled!";
        }
    }
}
