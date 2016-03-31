using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Collections;
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
        public static bool FindString(string x_sIdentification,string x_sTargetString,ref List<int> x_nPosition,int x_nStartIndex)
        {
            bool l_bResult = false;
            int i = x_sTargetString.IndexOf(x_sIdentification,x_nStartIndex);
            if (i < 0) { l_bResult = false; } else { l_bResult = true; x_nPosition.Add(i); }
            return l_bResult;
        }

        public static bool FindString(string x_sIdentification, string x_sTargetString, ref List<int> x_nPosition)
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
                //int k = new int();
                x_nPosition.Add(i);
                do
                {
                   // k = 0;
                    l_bResult = FindString(x_sIdentification, x_sTargetString, ref x_nPosition, x_nPosition[j]+1);
                    if (l_bResult ==true) {j=j+1;}
                }
                while (l_bResult == true);
                l_bResult = true;
                return l_bResult;
            }
        }
        public static bool String2Point(string[] x_sPoint,ref DataType.StaubliRobotData.St_PointRx x_pPoint)
        {
            bool l_bOk = false;
            if (x_sPoint.Length != 6)
            {
                l_bOk = false;
            }
            else
            {
                x_pPoint.x= double.Parse(x_sPoint[0]);
                x_pPoint.y = double.Parse(x_sPoint[1]);
                x_pPoint.z = double.Parse(x_sPoint[2]);
                x_pPoint.Rx = double.Parse(x_sPoint[3]);
                x_pPoint.Ry = double.Parse(x_sPoint[4]);
                x_pPoint.Rz = double.Parse(x_sPoint[5]);
                l_bOk = true;
            }
            return l_bOk;
 
        }
        public static bool getPoint(string x_sIdentifier1,char x_sIdentifier2,string x_sTargetString,DataType.StaubliRobotData.St_PointRx x_pPoint)
        {
            bool l_bOk = false;
            List<int> l_nPosition=new List<int>();
            l_bOk=FindString(x_sIdentifier1,x_sTargetString,ref l_nPosition);
            if (l_bOk == true)
            {
                try
                {
                    string l_sString = x_sTargetString.Substring(l_nPosition[1] + 1, l_nPosition[2] - l_nPosition[1]-1);
                    string[] l_sPoint = l_sString.Split(x_sIdentifier2);
                    l_bOk = String2Point(l_sPoint,ref x_pPoint);

                }
                catch (Exception ex)
                {
                    throw new Exception("Error:getPoint exception: " + ex.Message);
                }
            }
            return l_bOk;
        }
        //public static
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
