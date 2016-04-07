using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

namespace FileTools
{
   public class fileWrite
    {
        //public void WriteTxt()
        //{
        //    string str = "你的字符串";
        //    string filePath = "d:\\infor.txt";//这里是你的已知文件
        //    FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.ReadWrite);
        //    StreamWriter sw = new StreamWriter(fs);
        //    fs.SetLength(0);//首先把文件清空了。
        //    sw.Write(str);//写你的字符串。
        //    sw.Close();
        //}

        public void WriteTxt(string x_sOutString,string x_sPath)
        {
            try 
            {
                System.IO.FileStream l_file = new System.IO.FileStream(x_sPath, System.IO.FileMode.Create, System.IO.FileAccess.Write);
                System.IO.TextWriter l_text = new System.IO.StreamWriter(l_file, System.Text.Encoding.Default);
                l_text.Write(x_sOutString);
            }
            catch (Exception ex)
            {
                throw new Exception("Error:WriteTxt exception: " + ex.Message);
            }
            
        }
        public void WriteTxt(string[] x_sOutString, string x_sPath)
        {
            for(int i=0;i<=x_sOutString.Length;i++){ WriteTxt(x_sOutString[i], x_sPath); }
        }
    }
}
