
namespace FtpComSoft
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Connect = new System.Windows.Forms.Button();
            this.Port = new System.Windows.Forms.TextBox();
            this.PassWord = new System.Windows.Forms.TextBox();
            this.User = new System.Windows.Forms.TextBox();
            this.IpAddress = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.upLoad = new System.Windows.Forms.Button();
            this.FileType = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.FtpFilePath = new System.Windows.Forms.TextBox();
            this.RemotePath = new System.Windows.Forms.Button();
            this.LocalPath = new System.Windows.Forms.Button();
            this.LocalFilePath = new System.Windows.Forms.TextBox();
            this.logShow = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel3);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1322, 141);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "FTP连接参数";
            // 
            // Connect
            // 
            this.Connect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Connect.Location = new System.Drawing.Point(1055, 68);
            this.Connect.Name = "Connect";
            this.Connect.Size = new System.Drawing.Size(258, 43);
            this.Connect.TabIndex = 2;
            this.Connect.Text = "连接";
            this.Connect.UseVisualStyleBackColor = true;
            this.Connect.Click += new System.EventHandler(this.Connect_Click);
            // 
            // Port
            // 
            this.Port.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Port.Location = new System.Drawing.Point(792, 3);
            this.Port.Name = "Port";
            this.Port.Size = new System.Drawing.Size(257, 28);
            this.Port.TabIndex = 1;
            this.Port.Text = "21";
            // 
            // PassWord
            // 
            this.PassWord.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PassWord.Location = new System.Drawing.Point(792, 68);
            this.PassWord.Name = "PassWord";
            this.PassWord.Size = new System.Drawing.Size(257, 28);
            this.PassWord.TabIndex = 1;
            this.PassWord.Text = "ytvision";
            // 
            // User
            // 
            this.User.Dock = System.Windows.Forms.DockStyle.Fill;
            this.User.Location = new System.Drawing.Point(266, 68);
            this.User.Name = "User";
            this.User.Size = new System.Drawing.Size(257, 28);
            this.User.TabIndex = 1;
            this.User.Text = "YtVision";
            // 
            // IpAddress
            // 
            this.IpAddress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.IpAddress.Location = new System.Drawing.Point(266, 3);
            this.IpAddress.Name = "IpAddress";
            this.IpAddress.Size = new System.Drawing.Size(257, 28);
            this.IpAddress.TabIndex = 1;
            this.IpAddress.Text = "192.168.0.13";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(529, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(257, 65);
            this.label2.TabIndex = 0;
            this.label2.Text = "Port";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(529, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(257, 49);
            this.label4.TabIndex = 0;
            this.label4.Text = "密码";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(257, 49);
            this.label3.TabIndex = 0;
            this.label3.Text = "用户名";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 65);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tableLayoutPanel2);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 150);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1322, 234);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "上传信息";
            // 
            // upLoad
            // 
            this.upLoad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.upLoad.Location = new System.Drawing.Point(1085, 145);
            this.upLoad.Name = "upLoad";
            this.upLoad.Size = new System.Drawing.Size(228, 59);
            this.upLoad.TabIndex = 5;
            this.upLoad.Text = "测试上传";
            this.upLoad.UseVisualStyleBackColor = true;
            this.upLoad.Click += new System.EventHandler(this.upLoad_Click);
            // 
            // FileType
            // 
            this.FileType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FileType.Location = new System.Drawing.Point(932, 3);
            this.FileType.Name = "FileType";
            this.FileType.Size = new System.Drawing.Size(147, 28);
            this.FileType.TabIndex = 4;
            this.FileType.Text = ".csv;";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Location = new System.Drawing.Point(826, 0);
            this.label7.MinimumSize = new System.Drawing.Size(80, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 71);
            this.label7.TabIndex = 3;
            this.label7.Text = "文件类型";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(3, 71);
            this.label6.MinimumSize = new System.Drawing.Size(150, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(196, 71);
            this.label6.TabIndex = 2;
            this.label6.Text = "FTP路径";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(3, 0);
            this.label5.MinimumSize = new System.Drawing.Size(150, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(196, 71);
            this.label5.TabIndex = 2;
            this.label5.Text = "本地路径";
            // 
            // FtpFilePath
            // 
            this.FtpFilePath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FtpFilePath.Location = new System.Drawing.Point(205, 74);
            this.FtpFilePath.Name = "FtpFilePath";
            this.FtpFilePath.Size = new System.Drawing.Size(615, 28);
            this.FtpFilePath.TabIndex = 0;
            this.FtpFilePath.Text = "ftp://192.168.0.13/ttttt/";
            // 
            // RemotePath
            // 
            this.RemotePath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RemotePath.Location = new System.Drawing.Point(1085, 74);
            this.RemotePath.Name = "RemotePath";
            this.RemotePath.Size = new System.Drawing.Size(228, 65);
            this.RemotePath.TabIndex = 1;
            this.RemotePath.Text = "远程路径";
            this.RemotePath.UseVisualStyleBackColor = true;
            this.RemotePath.Click += new System.EventHandler(this.RemotePath_Click);
            // 
            // LocalPath
            // 
            this.LocalPath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LocalPath.Location = new System.Drawing.Point(1085, 3);
            this.LocalPath.Name = "LocalPath";
            this.LocalPath.Size = new System.Drawing.Size(228, 65);
            this.LocalPath.TabIndex = 1;
            this.LocalPath.Text = "本地路径";
            this.LocalPath.UseVisualStyleBackColor = true;
            this.LocalPath.Click += new System.EventHandler(this.LocalPath_Click);
            // 
            // LocalFilePath
            // 
            this.LocalFilePath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LocalFilePath.Location = new System.Drawing.Point(205, 3);
            this.LocalFilePath.Name = "LocalFilePath";
            this.LocalFilePath.Size = new System.Drawing.Size(615, 28);
            this.LocalFilePath.TabIndex = 0;
            this.LocalFilePath.Text = "D:/FTPTest/A2CUT01/A2CUT010A/20240219/Data";
            // 
            // logShow
            // 
            this.logShow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logShow.Location = new System.Drawing.Point(3, 390);
            this.logShow.Multiline = true;
            this.logShow.Name = "logShow";
            this.logShow.Size = new System.Drawing.Size(1322, 601);
            this.logShow.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.logShow, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 38.09524F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 61.90476F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 606F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1328, 994);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.53488F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.46512F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 106F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 153F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 233F));
            this.tableLayoutPanel2.Controls.Add(this.upLoad, 4, 2);
            this.tableLayoutPanel2.Controls.Add(this.LocalFilePath, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.RemotePath, 4, 1);
            this.tableLayoutPanel2.Controls.Add(this.FtpFilePath, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label6, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label7, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.FileType, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.LocalPath, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.label5, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 24);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1316, 207);
            this.tableLayoutPanel2.TabIndex = 6;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 5;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.Connect, 4, 1);
            this.tableLayoutPanel3.Controls.Add(this.IpAddress, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.PassWord, 3, 1);
            this.tableLayoutPanel3.Controls.Add(this.Port, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.label4, 2, 1);
            this.tableLayoutPanel3.Controls.Add(this.label2, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.User, 1, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 24);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1316, 114);
            this.tableLayoutPanel3.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1328, 994);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximumSize = new System.Drawing.Size(1350, 1050);
            this.MinimumSize = new System.Drawing.Size(1350, 1050);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Connect;
        private System.Windows.Forms.TextBox Port;
        private System.Windows.Forms.TextBox User;
        private System.Windows.Forms.TextBox IpAddress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PassWord;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button LocalPath;
        private System.Windows.Forms.TextBox LocalFilePath;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox FtpFilePath;
        private System.Windows.Forms.Button RemotePath;
        private System.Windows.Forms.TextBox logShow;
        private System.Windows.Forms.TextBox FileType;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button upLoad;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
    }
}

