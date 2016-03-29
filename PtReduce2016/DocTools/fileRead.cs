using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileTools
{
    class fileRead
    {
        /// <summary>
        /// 读取txt文件，将txt中的每行保存到string数组中。
        /// </summary>
        /// <param name="x_sPath"></param>
        /// <returns></returns>
        public string[] ReadTxt(string x_sPath)
        {
            string l_sLine=string.Empty;
            StreamReader SR = new StreamReader(x_sPath,Encoding.Default);
            string[] l_sFileInfor = new string[5000];

            int i = 0;


            while ((l_sLine = SR.ReadLine()) != null)
            {
                l_sFileInfor[i] = l_sLine.ToString();
                i++;
            }
            return l_sFileInfor;

        }
    }
}
