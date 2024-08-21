using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.InteropServices;

namespace FtpComSoft
{
    class FtpInfoClass
    {

        public string Path;

        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern bool WritePrivateProfileString(string section, string key, string value, string filePath);

        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern int GetPrivateProfileString(string section, string key, string defaultValue, StringBuilder returnValue, int size, string filePath);

        public FtpInfoClass(string path)
        {
            Path = path;
        }

        public void Write(string section ,string key, string value)
        {
            WritePrivateProfileString(section, key, value, Path);
        }

        public string Read(string section, string key, string defaultValue = "")
        {
            StringBuilder returnValue =new StringBuilder(255);
            GetPrivateProfileString(section, key, defaultValue, returnValue, returnValue.Capacity , Path);
            return returnValue.ToString();

        }


    }
}
