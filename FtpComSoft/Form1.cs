using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;

namespace FtpComSoft
{
    public partial class Form1 : Form
    {

        FtpInfo m_ftpInfo;          //定义一个FTP信息交互的结构体对象
        ComFtpCS m_comFtpCS;         //定义交互的信息
        List<FileInfo> m_FileList;         //定义上传文件的列表信息
        
        //保存界面信息到INI文件
        FtpInfoClass ftpInfoIni = new FtpInfoClass(AppDomain.CurrentDomain.BaseDirectory +  "/config.ini");


        public Form1()
        {
            InitializeComponent();
            groupBox2.Enabled = false;

            //读取FTP基础参数信息
            m_ftpInfo.IPADDRESS     = ftpInfoIni.Read("BASIC", "IP_ADDRESS", "127.0.0.1");
            m_ftpInfo.PORT          = ftpInfoIni.Read("BASIC", "PORT", "21");
            m_ftpInfo.USER          = ftpInfoIni.Read("BASIC", "USER", "11111");
            m_ftpInfo.PASSWORD      = ftpInfoIni.Read("BASIC", "PASSWORD", "00000");

            m_comFtpCS.localPath    = ftpInfoIni.Read("COM_INFO", "LOCAL_PATH","");
            m_comFtpCS.uploadPath   = ftpInfoIni.Read("COM_INFO", "UPLOADPATH", "");

            IpAddress.Text          = m_ftpInfo.IPADDRESS;
            Port.Text               = m_ftpInfo.PORT;
            User.Text               = m_ftpInfo.USER;
            PassWord.Text           = m_ftpInfo.PASSWORD;

            LocalFilePath.Text      = m_comFtpCS.localPath;
            FtpFilePath.Text        = m_comFtpCS.uploadPath;
            FileType.Text           = ftpInfoIni.Read("COM_INFO", "FILE_TYPE", "");

        }
          
        private void Connect_Click(object sender, EventArgs e)
        {

            if(Connect.Text == "连接")
            {
                Connect.Text = "断开连接";
                //获取界面上的信息
                m_ftpInfo.IPADDRESS = IpAddress.Text;
                m_ftpInfo.PORT = Port.Text;
                m_ftpInfo.USER = User.Text;
                m_ftpInfo.PASSWORD = PassWord.Text;

                //创建一个FTP对象
                FtpWebRequest m_ftp = (FtpWebRequest)WebRequest.Create("ftp://" + m_ftpInfo.IPADDRESS + ":" + m_ftpInfo.PORT);
                //提供FTP登录信息
                m_ftp.Credentials = new NetworkCredential(m_ftpInfo.USER, m_ftpInfo.PASSWORD);
                m_ftp.Method = WebRequestMethods.Ftp.ListDirectory;
                m_ftp.UsePassive = true;
                m_ftp.EnableSsl = false;
                m_ftp.KeepAlive = false;


                try
                {
                    using (FtpWebResponse response = (FtpWebResponse)m_ftp.GetResponse())
                    {
                        logShow.AppendText(DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss  ") +
                            "连接成功,状态:\r\n\t{ \r\n\t\t" + response.StatusDescription + "\t}\r\n");
                        logShow.ScrollToCaret();
                        groupBox2.Enabled = true;
                        Connect.BackColor = Color.Green;
                    }
                }
                catch (WebException ex)
                {
                    Connect.BackColor = Color.Red;
                    FtpWebResponse response = (FtpWebResponse)ex.Response;
                    if (response != null)
                    {
                        string errLog = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss  ") +
                            "连接失败,状态11111:\r\n\t{ \r\n\t\t" + response.StatusDescription + "\t}\r\n";
                        logShow.AppendText(errLog);
                        logShow.ScrollToCaret();
                    }
                    else
                    {
                        string errLog = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss  ") +
                            "连接失败,状态22222:\r\n\t{ \r\n\t\t" + ex.Message + "\t}\r\n";
                        logShow.AppendText(errLog);
                        logShow.ScrollToCaret();
                    }
                }
            }
            else if(Connect.Text == "断开连接")
            {
                Connect.Text        = "连接";
                Connect.BackColor   = Color.White;
                groupBox2.Enabled   = false;
            }
            
        }

        private void LocalPath_Click(object sender, EventArgs e)
        {

            if(Directory.Exists(LocalFilePath.Text))
            {
                logShow.AppendText(DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss  ") +
                            "路径已存在:\r\n\t{ \r\n\t\t" + LocalFilePath.Text + "\n\t}\r\n");
                logShow.ScrollToCaret();

                DialogResult result = MessageBox.Show("是否需要重新选择文件夹?", "选择文件夹", 
                    MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);

                switch (result)
                {
                    case DialogResult.Yes:
                        LocalFilePath.Text = ToGetFolderPath();
                        LocalFilePath.Text = LocalFilePath.Text.Replace("\\", "/");
                        break;
                    case DialogResult.No:
                        break;
                    case DialogResult.Cancel:
                        break;
                }
            }

            m_comFtpCS.localPath = LocalFilePath.Text;
            if (LocalFilePath.Text == "null")
            {
                return;
            }
            
            string[] fileType = FileType.Text.Split(';');

            DirectoryInfo directory = new DirectoryInfo(m_comFtpCS.localPath);

            m_FileList = directory.GetFiles().Where(file => fileType.Contains(file.Extension.ToLowerInvariant())).ToList();

        }


        public string ToGetFolderPath()
        {

            FolderBrowserDialog dialog  = new FolderBrowserDialog();
            //设定根目录
            dialog.RootFolder           = Environment.SpecialFolder.Desktop;
            DialogResult result         = dialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                //用户点击了确认按钮,获取选中的路径
                return dialog.SelectedPath;
            }
            else
            {
                return "null";
            }
        }

        private void RemotePath_Click(object sender, EventArgs e)
        {
            m_comFtpCS.uploadPath = ToGetFolderPath();
            FtpFilePath.Text = m_comFtpCS.uploadPath;
        }

        private void upLoad_Click(object sender, EventArgs e)
        {
            if (m_comFtpCS.uploadPath == null || m_comFtpCS.uploadPath == "null")
            {
                if (FtpFilePath.Text == null)
                {
                    return;
                }
                m_comFtpCS.uploadPath = FtpFilePath.Text;
            }
            
            try
            {

                ////写入信息
                ftpInfoIni.Write("BASIC", "IP_ADDRESS", m_ftpInfo.IPADDRESS);
                ftpInfoIni.Write("BASIC", "PORT", m_ftpInfo.PORT);
                ftpInfoIni.Write("BASIC", "USER", m_ftpInfo.USER);
                ftpInfoIni.Write("BASIC", "PASSWORD", m_ftpInfo.PASSWORD + "\r\n");

                //ftp交互的基本参数
                ftpInfoIni.Write("COM_INFO", "LOCAL_PATH", m_comFtpCS.localPath);
                ftpInfoIni.Write("COM_INFO", "UPLOADPATH", m_comFtpCS.uploadPath);
                ftpInfoIni.Write("COM_INFO", "FILE_TYPE", FileType.Text);

                //判断列表是否为空
                if(m_FileList.Count == 0)
                {
                    MessageBox.Show("文件列表长度为0,请更新列表后上传!!!","文件列表错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                //获取上传的多个路径
                string[] upLoadPathList = m_comFtpCS.uploadPath.Split(';');
              
                for (int i = 0; i < m_FileList.Count; i++)
                {
                    for(int j = 0; j < upLoadPathList.Length;j++)
                    {
                        string fileName = Path.GetFileName(m_FileList[i].FullName);

                        if(!DirectroyIsExist(upLoadPathList[j], m_ftpInfo.USER, m_ftpInfo.PASSWORD))
                        {
                            CreateFtpDirectory(upLoadPathList[j], m_ftpInfo.USER, m_ftpInfo.PASSWORD);
                        }
                        
                        string uri = Path.Combine(upLoadPathList[j], fileName).Replace("\\", "/");

                        //logShow.AppendText(DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss  ") +
                        //    "上传路径:\r\n\t{ \r\n\t\t" + upLoadPathList[j] + "\t" + uri + "\n\t}\r\n");

                        FtpWebRequest m_ftp = (FtpWebRequest)WebRequest.Create(uri);
                        m_ftp.Method = WebRequestMethods.Ftp.UploadFile;
                        m_ftp.Credentials = new NetworkCredential(m_ftpInfo.USER, m_ftpInfo.PASSWORD);
                        m_ftp.UsePassive = true;
                        m_ftp.EnableSsl = false;
                        m_ftp.KeepAlive = false;


                        //读取本地文件到字节组
                        byte[] fileContents = File.ReadAllBytes(m_FileList[i].FullName);

                        //设置上传内容
                        m_ftp.ContentLength = fileContents.Length;
                        //将文件内容写入请求流
                        using (Stream request = m_ftp.GetRequestStream())
                        {
                            request.Write(fileContents, 0, fileContents.Length);
                        }

                        using (FtpWebResponse response = (FtpWebResponse)m_ftp.GetResponse())
                        {
                            string errLog = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss  ") +
                            "上传完成,状态:\r\n\t{ \r\n\t\t" + uri + "\r\n\t\t" + m_FileList[i].FullName + "\t\t"
                            + response.StatusDescription + "\n\t}\r\n";

                            logShow.AppendText(errLog);
                            logShow.ScrollToCaret();
                        }
                    }
                }
            }
            catch(WebException ex)
            {
                if(ex.Response is FtpWebResponse response)
                {
                    string errLog = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss  ") +
                        "上传有误,状态11111:\r\n\t{ \r\n\t\t" + response.StatusCode + "\t\t"
                        + response.StatusDescription + "\n\t}\r\n";
                    logShow.AppendText(errLog);
                    logShow.ScrollToCaret();
                }
            }
            catch(Exception ex)
            {
                string errLog = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss  ") +
                        "上传有误,状态22222:\r\n\t{ \r\n\t\t" + ex.Message + "\n\t}\r\n";
                logShow.AppendText(errLog);
                //滚动条移动到最新的
                logShow.ScrollToCaret();
            }
        }



        //判断路径是否存在
        public bool DirectroyIsExist(string directoryPath, string username, string password)
        {
            try
            {
                FtpWebRequest request = (FtpWebRequest)WebRequest.Create(directoryPath);
                request.Method = WebRequestMethods.Ftp.ListDirectory;
                request.Credentials = new NetworkCredential(username, password);

                using (FtpWebResponse response = (FtpWebResponse)request.GetResponse())
                {
                    return true;
                }
            }
            catch(WebException ex)
            {
                FtpWebResponse response = (FtpWebResponse)ex.Response;
                if (response != null && response.StatusCode == FtpStatusCode.ActionNotTakenFileUnavailable)
                {

                    CreateFtpDirectory(directoryPath, username, password);
                    return false; // 目录不存在
                }
                else
                {
                    throw; // 其他错误
                }
            }

        }

        //创建目录
        public void CreateFtpDirectory(string directoryPath, string username, string password)
        {
            FtpWebRequest request = (FtpWebRequest)WebRequest.Create(directoryPath);
            request.Method = WebRequestMethods.Ftp.MakeDirectory;
            request.Credentials = new NetworkCredential(username, password);

            using (FtpWebResponse response = (FtpWebResponse)request.GetResponse())
            {
                Console.WriteLine($"Directory created: {response.StatusDescription}");
            }
        }

    }
}
