
//Process
using System.Diagnostics;
using System.Net;

//Thread
using System.Threading;

namespace Bills_Manager
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();


        }

        public void thread_download()
        {
            string ftp_path = this.ftp_path.Text;
            string file_name = this.package_name.Text;

            string full_string = ftp_path + "/" + file_name;

            long n = Get_File_Size("this.block");

            //FtpWebRequest request = (FtpWebRequest)WebRequest.Create("ftp://192.168.0.107/this.block");
            FtpWebRequest request = (FtpWebRequest)WebRequest.Create(full_string);
            request.Method = WebRequestMethods.Ftp.DownloadFile;

            request.Credentials = new NetworkCredential("", "");

            FtpWebResponse response = (FtpWebResponse)request.GetResponse();

            Stream responseStream = response.GetResponseStream();

            StreamReader reader = new StreamReader(responseStream);

            byte[] data_buffer = new byte[4 * 1024 * 1024];
            Int64 sum = 0;
            int ret = 0;


            FileStream target_file = new FileStream(file_name, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            target_file.Position = 0;

            ret = responseStream.Read(data_buffer, 0, 4 * 1024 * 1024);
            while (ret != -1 && ret != 0)
            {
                sum += ret;
                this.textBox1.Clear();
                double ps = sum * 100 / n;


                this.textBox1.AppendText(Convert.ToString(ret));
                this.textBox1.AppendText(Convert.ToString("\r\n"));
                this.textBox1.AppendText(Convert.ToString(n));
                this.textBox1.AppendText(Convert.ToString("\r\n"));
                this.textBox1.AppendText(Convert.ToString(ps));
                this.progressBar1.Value = (int)ps;

                target_file.Write(data_buffer, 0, data_buffer.Length);

                ret = responseStream.Read(data_buffer, 0, 4 * 1024 * 1024);
                Thread.Sleep(1);
            }

            target_file.Close();

            reader.Close();
            response.Close();
        }

        string ftpURI = "ftp://192.168.0.107/";
        string ftpUserID = "";
        string ftpPassword = "";

        public Int64 Get_File_Size(string ftpfileName)
        {
            Int64 size = 0;

            try
            {
                FtpWebRequest reqFTP;
                reqFTP = (FtpWebRequest)FtpWebRequest.Create(new Uri(ftpURI + ftpfileName));
                reqFTP.Credentials = new NetworkCredential(ftpUserID, ftpPassword);
                reqFTP.Method = WebRequestMethods.Ftp.GetFileSize;
                reqFTP.UseBinary = true;
                FtpWebResponse response = (FtpWebResponse)reqFTP.GetResponse();
                Stream ftpStream = response.GetResponseStream();
                size = response.ContentLength;
                ftpStream.Close();
                response.Close();
            }
            catch (Exception e)
            {
                this.textBox1.AppendText(e.Message + "\r\n");
                return -1;
            }
            return size;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thread download = new Thread(thread_download);
            download.Start();
        }
    }
}