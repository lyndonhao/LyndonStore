using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Collections;
using DataType;

namespace DataProcessTools
{
    public  class ParseData
    {
        /// <summary>
        /// 查找标识符在单个字符串中起始位置后首次出现的位置 test success
        /// </summary>
        /// <param name="x_sIdentification"></param>
        /// <param name="x_sTargetString"></param>
        /// <param name="x_nPosition"></param>字符串所在位置
        /// <returns>true:包含字符串
        /// </returns>false：不包含字符串
        public  bool FindString(string x_sIdentification,string x_sTargetString,ref List<int> x_nPosition,int x_nStartIndex)
        {
            bool l_bResult = false;
            int i = x_sTargetString.IndexOf(x_sIdentification,x_nStartIndex);
            if (i < 0) { l_bResult = false; } else { l_bResult = true; x_nPosition.Add(i); }
            return l_bResult;
        }
        /// <summary>
        /// 查找标识符在字符串数组中的所有位置。
        /// </summary>
        /// <param name="x_sIdentification"></param>
        /// <param name="x_sTargetString"></param>
        /// <param name="x_nPosition"></param>
        /// <param name="x_nStartIndex"></param>
        /// <returns></returns>
        public  bool FindString(string x_sIdentification, string[] x_sTargetString, ref List<int> x_nIndex)
        {
            bool l_bResult = false;
            //int l_nPosition = new int();
            List<int> l_nPosition=new List<int>();
            List<int> l_ListIndex = new List<int>();
            for (int i=0;i<=x_sTargetString.Length-1;i++)
            {
                l_bResult = FindString(x_sIdentification, x_sTargetString[i], ref l_nPosition, 0);
                if (l_bResult == true) { l_ListIndex.Add(i); }
            }
            if (l_ListIndex.Count == 0) { l_bResult = false; } else { x_nIndex=l_ListIndex; l_bResult = true; }
            return l_bResult;   
        }
        /// <summary>
        /// 查找标识符在字符串中的所有位置 test success
        /// </summary>
        /// <param name="x_sIdentification"></param>
        /// <param name="x_sTargetString"></param>
        /// <param name="x_nPosition"></param>
        /// <returns></returns>
        public  bool FindString(string x_sIdentification, string x_sTargetString, ref List<int> x_nPosition)
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
        /// <summary>
        /// 字符串数组转换为点类型 test success
        /// </summary>
        /// <param name="x_sPoint"></param>
        /// <param name="x_pPoint"></param>
        /// <returns></returns>
        public  bool String2Point(string[] x_sPoint,ref DataType.StaubliRobotData.St_PointRx x_pPoint)
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
        /// <summary>
        /// 获取点信息 test success
        /// </summary>
        /// <param name="x_sIdentifier1"></param>
        /// <param name="x_sIdentifier2"></param>
        /// <param name="x_sTargetString"></param>
        /// <param name="x_pPoint"></param>
        /// <returns></returns>
        public  bool getPoint(string x_sIdentifier1,char x_sIdentifier2,string x_sTargetString,ref DataType.StaubliRobotData.St_PointRx x_pPoint)
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
        /// <summary>
        /// 给定起始和结束数组索引,获取字符串数组中从开始索引到结束索引下的所有点。test success
        /// </summary>
        /// <param name="x_sIdentifier1"></param>
        /// <param name="x_sIdentifier2"></param>
        /// <param name="x_sTargetString"></param>
        /// <param name="x_nStartIndex"></param>
        /// <param name="x_nEndIndex"></param>
        /// <param name="x_ListPoint"></param>
        /// <returns></returns>
        public  bool getPoint(string x_sIdentifier1,char x_sIdentifier2,string[] x_sTargetString,int x_nStartIndex,int x_nEndIndex,out List<DataType.StaubliRobotData.St_PointRx> x_ListPoint)
        {
            bool l_bResult = false;
            x_ListPoint=null;
            List<DataType.StaubliRobotData.St_PointRx> l_arrayList = new List<DataType.StaubliRobotData.St_PointRx>();
            DataType.StaubliRobotData.St_PointRx l_pPoint=new DataType.StaubliRobotData.St_PointRx();
            for (int i = x_nStartIndex + 1; i <= x_nEndIndex - 1; i++)
            {
                l_bResult = getPoint(x_sIdentifier1, x_sIdentifier2, x_sTargetString[i],ref l_pPoint);
                if (l_bResult == true) { l_arrayList.Add(l_pPoint); }
            }
            if (l_arrayList.Count == 0) { l_bResult = false; } else { x_ListPoint = l_arrayList; l_bResult = true; }
            return l_bResult;
        }
        /// <summary>
        /// 获取从开始字符串到结束字符串下所有的点。
        /// </summary>
        /// <param name="x_sIdentifier1"></param>标识符
        /// <param name="x_sIdentifier2"></param>
        /// <param name="x_sTargetString"></param>目标字符串
        /// <param name="x_sStartString"></param>开始字符串
        /// <param name="x_sEndString"></param>结束字符串
        /// <param name="x_ListPoint"></param>
        /// <returns></returns>
        public bool getPoint(string x_sIdentifier1, char x_sIdentifier2, string[] x_sTargetString, string x_sStartString, string x_sEndString, out List<DataType.StaubliRobotData.St_PointRx> x_ListPoint)
        {
            x_ListPoint = null;
            //ParseData ParseTool = new ParseData();
            //List<DataType.StaubliRobotData.St_PointRx> l_ListPoint = new List<DataType.StaubliRobotData.St_PointRx>();
            List<int> l_ListIndex1 = new List<int>();
            List<int> l_ListIndex2 = new List<int>();
            bool l_bResult = false;
            bool l_bResult1 = FindString(x_sStartString, x_sTargetString, ref l_ListIndex1);
            bool l_bResult2 = FindString(x_sEndString, x_sTargetString, ref l_ListIndex2);
            if (l_bResult1 == true & l_bResult2 == true)
            {
                int l_nStartIndex = l_ListIndex1[0];
                int l_nEndIndex = l_ListIndex2[0];
                l_bResult = getPoint(x_sIdentifier1, x_sIdentifier2, x_sTargetString, l_nStartIndex, l_nEndIndex, out x_ListPoint);      
            }

            return l_bResult;
        }
    }
}
