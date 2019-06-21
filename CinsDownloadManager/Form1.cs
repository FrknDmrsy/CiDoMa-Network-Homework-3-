using System;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;

namespace CinsDownloadManager
{
    public partial class Form1 : Form
    {
        public class file
        {
            public string filename { get; set; }
            public string path { get; set; }

            public override string ToString() {
                return filename;
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void BtnDownload_Click(object sender, EventArgs e) 
        {
            if (lstMusics.SelectedItem != null) 
            {
                btnDownload.Enabled = false;
                btnVideoDownload.Enabled = false;
                backgroundWorker.RunWorkerAsync(@"C:\CiDoMa\Music\" + lstMusics.SelectedItem.ToString()); //
            }
                
        }
        private void BtnVideoDownload_Click(object sender, EventArgs e)
        {
            if (lstVideos.SelectedItem != null)
            {
                btnDownload.Enabled = false;
                btnVideoDownload.Enabled = false;
                backgroundWorker.RunWorkerAsync(@"C:\CiDoMa\Movie\" + lstVideos.SelectedItem.ToString()); //
            }
          
        }
        private void BackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            DownloadHelper server0 = new DownloadHelper(9050);
            DownloadHelper server1 = new DownloadHelper(9051);
            DownloadHelper server2 = new DownloadHelper(9052);

            string filename = (string)e.Argument;

            string fileshortname = Path.GetFileName(filename);

            var file = new file()
            {
                filename = fileshortname,
                path = filename
            };


            // The size of the file we want to download fetched from the server0
            int sizeOfFile = server0.GetSize(filename);

            int dataleft = sizeOfFile;
            int buffersize = 1000;      //chunk size
            int downloadedData = 0;

            int thousands = 0;  // Which chunk

            //The file we want to download will be saved on the desktop
            // Creating a file on the desktop and writes into the file

            using (FileStream fileStream = new FileStream(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "/"+ fileshortname, FileMode.OpenOrCreate, FileAccess.Write))
            {
                while (dataleft > 0)
                {
                    if (buffersize >= dataleft)
                    {
                        buffersize = dataleft;
                        dataleft = 0;
                    }
                    else
                    {
                        dataleft -= buffersize;
                    }

                    byte[] data;

                    switch (thousands % 3)
                    /// <summary>
                    /// Gets mod to determine which server to download.
                    /// According to the size of the file we are going to request the id# of 
                    /// chunk from the related Server(x).For example, bytes(17.000 - 17.999)
                    /// <summary>

                    {
                        case 0:
                            data = server0.GetChunk(filename, downloadedData, buffersize);
                            break;
                        case 1:
                            data = server1.GetChunk(filename, downloadedData, buffersize);
                            break;
                        default:
                            data = server2.GetChunk(filename, downloadedData, buffersize); 
                            break;
                    }

                    foreach (byte item in data)
                    {
                        fileStream.WriteByte(item);
                    }

                    downloadedData = sizeOfFile - dataleft;

                    backgroundWorker.ReportProgress((int)(100*((downloadedData * 1.0) / (sizeOfFile * 1.0))));
                    thousands++;  // Counter for the Chunk
                }
                fileStream.Close();     //Save the file
                backgroundWorker.ReportProgress(101, file);
            }
        }

        
        /// <summary>
        ///  Tracking Progress Bar
        /// </summary>
        private void BackgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
           
            if (e.ProgressPercentage == 101) // GUI - When Progress percentage equals 101 ,Download progress is completed.
            {
                btnDownload.Enabled = true;
                btnVideoDownload.Enabled = true;
                lstIndirilmisler.Items.Add(e.UserState);

                file myfile = (file)e.UserState;

                System.Diagnostics.Process.Start(myfile.path);
            }
            else
            {
                prgsDownloading.Value = e.ProgressPercentage;
            }
        }

        private void LstMusics_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
