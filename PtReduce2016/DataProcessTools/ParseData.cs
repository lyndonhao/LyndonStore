using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DataType;

namespace DataProcessTools
{
    public class ParseData
    {
        /// <summary>
        /// 查找字符串
        /// </summary>
        /// <param name="x_sIdentification"></param>
        /// <param name="x_sTargetString"></param>
        /// <param name="x_nPosition"></param>字符串所在位置
        /// <returns>true:包含字符串
        /// </returns>false：不包含字符串
        public bool FindString(string x_sIdentification,string x_sTargetString,ref int x_nPosition,int x_nStartIndex)
        {
            bool l_bResult = false;
            int i = x_sTargetString.IndexOf(x_sIdentification,x_nStartIndex);
            if (i < 0) { l_bResult = false; } else { l_bResult = true;  }
            x_nPosition = i;
            return l_bResult;
        }

        public bool FindString(string x_sIdentification, string x_sTargetString, ref int[] x_nPosition)
        {
            bool l_bResult = true;
            int i = x_sTargetString.IndexOf(x_sIdentification, 0);
            if (i < 0)
            {
                l_bResult = false;
                return l_bResult;
            }
            else
            {
                int j = 0;
                int k = new int();
                x_nPosition[j] = i;
                do
                {
                    k = 0;
                    l_bResult = FindString(x_sIdentification, x_sTargetString, ref k,x_nPosition[j]);
                    if (l_bResult ==true) {x_nPosition[j+1]=k;j=j+1; }
                }
                while (l_bResult == false);
                l_bResult = true;
                return l_bResult;
            }
        }
        /// <summary>
        /// 查找字符串
        /// </summary>
        /// <param name="x_sIdentification"></param>
        /// <param name="x_sTargetString"></param>
        /// <returns></returns>
        //public bool FindString(string x_sIdentification, string x_sTargetString)
        //{
        //    bool l_bResult = false;
        //    int i=0;
        //    l_bResult = FindString(x_sIdentification, x_sTargetString, ref i);
        //    return l_bResult;
        //}
        //public void getPoint(ref DataType.StaubliRobotData.St_PointRx x_pPoint,ref DataType.StaubliRobotData.St_JointRx x_jJoint,string x_sTargetString,char x_sIdentifer1,char x_sIdentifer2)
        //{
        //    string[] l_sString = x_sTargetString.Split(new char[2] { x_sIdentifer1, x_sIdentifer2 });
        //    x_jJoint.J1 = int.Parse(l_sString[1]);
        //    x_jJoint.J1 = int.Parse(l_sString[1]);
        //    x_jJoint.J1 = int.Parse(l_sString[1]);
        //    x_jJoint.J1 = int.Parse(l_sString[1]);
        //    x_jJoint.J1 = int.Parse(l_sString[1]);
        //    x_jJoint.J1 = int.Parse(l_sString[1]);
        //}
    }
}
