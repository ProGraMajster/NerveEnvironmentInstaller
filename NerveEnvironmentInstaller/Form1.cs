using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Globalization;
using System.IO.Compression;
using System.Net;

namespace NerveEnvironmentInstaller
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            web = new WebClient();
            web.DownloadFileCompleted += Web_DownloadFileCompleted;
            web.DownloadProgressChanged += Web_DownloadProgressChanged;
        }

        private void Web_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
            labelProgress.Text = "Pobieranie: " + e.BytesReceived + " z " + e.TotalBytesToReceive + "bajtów";
        }

        private void Web_DownloadFileCompleted(object? sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {
            if(e.Error != null)
            {
                MessageBox.Show("Wyst¹pi³ b³¹d podczas pobierania zasobów.\n" + e.Error.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(e.Cancelled)
            {
                return;
            }
            try
            {
                web.Dispose();
                labelProgress.Text = "Instalacjia";
                progressBar1.Style = ProgressBarStyle.Marquee;
                progressBar1.MarqueeAnimationSpeed = 10;
                ZipFile.ExtractToDirectory("nerve_res.zip", Environment.CurrentDirectory, true);
                string path = Environment.CurrentDirectory + @"\NerveEnvironmentRepoInstaller-master\NerveEnvironmentRepoInstaller";
                DirectoryInfo directoryInfo = new DirectoryInfo(path);
                foreach(DirectoryInfo dir in directoryInfo.GetDirectories())
                {
                    if(Directory.Exists("C:\\NerveEnvironment\\" + dir.Name))
                    {
                        Directory.Delete("C:\\NerveEnvironment\\" + dir.Name, true);
                    }
                    dir.MoveTo("C:\\NerveEnvironment\\"+dir.Name);
                }
                labelProgress.Text = "Instalacjia zakoñczona";
            }
            catch(Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                Console.Error.WriteLine(ex.ToString());
                labelProgress.Text = "Wyst¹pi³ b³¹d";
            }
        }

        WebClient web;
        private void buttonStartInstall_Click(object sender, EventArgs e)
        {
            try
            {
                progressBar1.Style = ProgressBarStyle.Marquee;
                progressBar1.MarqueeAnimationSpeed = 10;
                labelProgress.Text = "Przygotowywanie...";
                buttonStartInstall.Hide();
                buttonCanel.Show();
                if(web == null)
                {
                    web = new WebClient();
                    web.DownloadFileCompleted += Web_DownloadFileCompleted;
                    web.DownloadProgressChanged += Web_DownloadProgressChanged;
                }
                if(File.Exists("nerve_res.zip"))
                {
                    File.Delete("nerve_res.zip");
                }
                if(Directory.Exists("NerveEnvironmentRepoInstaller-master"))
                {
                    Directory.Delete("NerveEnvironmentRepoInstaller-master",true);
                }
                if(Directory.Exists(@"C:\NerveEnvironment")==false)
                {
                    Directory.CreateDirectory(@"C:\NerveEnvironment");
                }
                progressBar1.Style = ProgressBarStyle.Blocks;
                web.DownloadFileAsync(
                    new Uri(@"https://codeload.github.com/ProGraMajster/NerveEnvironmentRepoInstaller/zip/refs/heads/master"),
                    "nerve_res.zip");
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                Console.Error.WriteLine(ex.ToString());
                labelProgress.Text = "Wyst¹pi³ b³¹d";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach(string arg in Environment.GetCommandLineArgs())
            {
                if(arg == "-autoinstall")
                {
                    try
                    {
                        progressBar1.Style = ProgressBarStyle.Marquee;
                        progressBar1.MarqueeAnimationSpeed = 10;
                        labelProgress.Text = "Przygotowywanie...";
                        buttonStartInstall.Hide();
                        buttonCanel.Show();
                        if (web == null)
                        {
                            web = new WebClient();
                            web.DownloadFileCompleted += Web_DownloadFileCompleted;
                            web.DownloadProgressChanged += Web_DownloadProgressChanged;
                        }
                        if (File.Exists("nerve_res.zip"))
                        {
                            File.Delete("nerve_res.zip");
                        }
                        if (Directory.Exists("NerveEnvironmentRepoInstaller-master"))
                        {
                            Directory.Delete("NerveEnvironmentRepoInstaller-master", true);
                        }
                        if (Directory.Exists(@"C:\NerveEnvironment") == false)
                        {
                            Directory.CreateDirectory(@"C:\NerveEnvironment");
                        }
                        progressBar1.Style = ProgressBarStyle.Blocks;
                        web.DownloadFileAsync(
                            new Uri(@"https://codeload.github.com/ProGraMajster/NerveEnvironmentRepoInstaller/zip/refs/heads/master"),
                            "nerve_res.zip");
                    }
                    catch (Exception ex)
                    {
                        Debug.WriteLine(ex.ToString());
                        Console.Error.WriteLine(ex.ToString());
                        labelProgress.Text = "Wyst¹pi³ b³¹d";
                    }
                }
            }
        }

        private void buttonCanel_Click(object sender, EventArgs e)
        {
            if(web != null)
            {
                if(web.IsBusy)
                {
                    web.CancelAsync();
                }
                web.DownloadFileCompleted -= Web_DownloadFileCompleted;
                web.Dispose();
                web = null;
                Application.DoEvents();
            }
        }
    }
}