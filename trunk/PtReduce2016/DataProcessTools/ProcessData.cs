using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Collections;
using MathMatics;


namespace DataProcessTools
{
    public class ProcessData
    {
        public bool PtReduce(ref List<DataType.StaubliRobotData.St_PointRx> x_ListPoint)
        {
            //x_ListPoint = null;
            //ParseData ParseTool =new ParseData();
            //List<DataType.StaubliRobotData.St_PointRx> l_ListPoint = new List<DataType.StaubliRobotData.St_PointRx>();
            //List<int> l_ListIndex1=new List<int>();
            //List<int> l_ListIndex2 = new List<int>();
            //bool l_bResult = false;
            //bool l_bResult1 = ParseTool.FindString(x_sStartString, x_sTargetString, ref l_ListIndex1);       
            //bool l_bResult2 = ParseTool.FindString(x_sEndString, x_sTargetString, ref l_ListIndex2);
            //if (l_bResult1 == true & l_bResult2 == true)
            //{
            //    int l_nStartIndex = l_ListIndex1[0];
            //    int l_nEndIndex = l_ListIndex2[0];
            //    l_bResult = ParseTool.getPoint(x_sIdentifier1, x_sIdentifier2, x_sTargetString, l_nStartIndex,l_nEndIndex,out l_ListPoint);
            //    if (l_bResult == true)
            //    {
 
            //    }
            //}

            //return l_bResult;
            ParseData ParseTool =new ParseData();
            bool l_bResult = false;
            int i = 0, j = 0, k = 0, l = 0, m = 0;
            do
            {
                i = m; j = m + 1; k = m + 2; l = m + 3;
                l_bResult = PointTool.ThreeColline(x_ListPoint[i], x_ListPoint[j], x_ListPoint[k]);
                if (l_bResult == true)
                {
                    m = m + 1;
                }
                else
                {
                    l_bResult=PointTool.IsOnCircle()
                }
            }
            while (m<=x_ListPoint.Count-4);
            return l_bResult;
        }
    }
}
