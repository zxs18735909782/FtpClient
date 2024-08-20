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
        public Form1()
        {
            InitializeComponent();
            groupBox2.Enabled = false;
        }

        FtpInfo         m_ftpInfo;          //定义一个FTP信息交互的结构体对象
        ComFtpCS        m_comFtpCS;         //定义交互的信息
        List<FileInfo>  m_FileList;         //定义上传文件的列表信息



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
                        logShow.AppendText(DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss  ") +
                            "连接失败,状态11111:\r\n\t{ \r\n\t\t" + response.StatusDescription + "\t}\r\n");
                    }
                    else
                    {
                        logShow.AppendText(DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss  ") +
                            "连接失败,状态22222:\r\n\t{ \r\n\t\t" + ex.Message + "\t}\r\n");
                    }
                }
            }
            else if(Connect.Text == "断开连接")
            {
                Connect.Text = "连接";
                Connect.BackColor = Color.White;
                groupBox2.Enabled = false;
            }
            
        }

        private void LocalPath_Click(object sender, EventArgs e)
        {
            m_comFtpCS.localPath = ToGetFolderPath();
            LocalFilePath.Text = m_comFtpCS.localPath;
            if (LocalFilePath.Text == null)
            {
                return;
            }

            
            string[] fileType = FileType.Text.Split(';');

            DirectoryInfo directory = new DirectoryInfo(m_comFtpCS.localPath);

            m_FileList = directory.GetFiles().Where(file => fileType.Contains(file.Extension.ToLowerInvariant())).ToList();

        }


        public string ToGetFolderPath()
        {

            FolderBrowserDialog dialog = new FolderBrowserDialog();
            //设定根目录
            dialog.RootFolder = Environment.SpecialFolder.Desktop;
            DialogResult result = dialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                //用户点击了确认按钮,获取选中的路径
                return dialog.SelectedPath;
            }

            return null;
        }

        private void RemotePath_Click(object sender, EventArgs e)
        {
            m_comFtpCS.uploadPath = ToGetFolderPath();
            FtpFilePath.Text = m_comFtpCS.uploadPath;
        }

        private void upLoad_Click(object sender, EventArgs e)
        {
 
            if(m_comFtpCS.uploadPath == null)
            {
                if(FtpFilePath.Text == null)
                {
                    return;
                }
                m_comFtpCS.uploadPath = FtpFilePath.Text;
            }

            try
            {
                for (int i = 0; i < m_FileList.Count; i++)
                {

                    string fileName = Path.GetFileName(m_FileList[i].FullName);
                    string uri = Path.Combine(m_comFtpCS.uploadPath, fileName).Replace("\\", "/");

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
                        logShow.AppendText(DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss  ") +
                        "上传完成,状态:\r\n\t{ \r\n\t\t" + m_FileList[i].FullName + "\t\t"  
                        + response.StatusDescription + "\t}\r\n");
                    }
                }
            }
            catch(WebException ex)
            {
                if(ex.Response is FtpWebResponse response)
                {
                    logShow.AppendText(DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss  ") +
                        "上传有误,状态11111:\r\n\t{ \r\n\t\t" + response.StatusCode + "\t\t" 
                        + response.StatusDescription + "\n\t}\r\n");
                }
            }
            catch(Exception ex)
            {
                logShow.AppendText(DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss  ") +
                        "上传有误,状态22222:\r\n\t{ \r\n\t\t" + ex.Message + "\n\t}\r\n");
            }
        }
    }
}
