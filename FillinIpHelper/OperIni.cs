using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace shcoolnetchange
{
    class OperIni
    {
        [DllImport("kernel32", CharSet = CharSet.Unicode, SetLastError = true)]
        private static extern long WritePrivateProfileString(
            string lpAppName, string lpKeyName, string lpString, string lpFileName);
        [DllImport("kernel32", CharSet = CharSet.Unicode, SetLastError = true)]
        private static extern int GetPrivateProfileString(
            string lpAppName, string lpKeyName, string lpDefault, StringBuilder lpReturnedString,
            int nSize, string lpFileName);

        public static string  ReadIni(string section,string key,string defValue,string filepath)//读取ini文件
        {
            StringBuilder temp = new StringBuilder();
            GetPrivateProfileString(section, key, defValue, temp, 256,@filepath);
            return temp.ToString();
        }

        public static long WriteIni(string section,string key,string value,string filePath)//写入ini文件
        {
            return WritePrivateProfileString(section, key, value, filePath);
        }
        public static long DeleteSection(string section,string filePath)//删除节
        {
            return WritePrivateProfileString(section, null, null, filePath);
        }
        public static long DeleteKey(string section,string key,string value,string filePath)//删除键
        {
            return WritePrivateProfileString(section, key, null, filePath);
        }
    }
}
