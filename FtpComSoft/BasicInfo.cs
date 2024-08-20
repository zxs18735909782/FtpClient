using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FtpComSoft
{
    //FTP结构体信息
    struct FtpInfo
    {
        public string IPADDRESS;
        public string PORT;
        public string USER;
        public string PASSWORD;
    };

    //交互的结构体信息
    struct ComFtpCS
    {
        public string uploadPath;
        public string localPath;
    };


}
