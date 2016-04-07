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
        public bool PtReduce(double x_nLinePrecision, double x_nCirclePrecision,ref List<DataType.StaubliRobotData.St_PointRx> x_ListPoint,ref List<DataType.StaubliRobotData.St_JointRx> x_ListJoint, out List<int> x_ListIndex)
        {
            x_ListIndex = null;
            ParseData ParseTool =new ParseData();
            bool l_bResult = false;
            List<int> l_ListIndex = new List<int>();
            List<DataType.StaubliRobotData.St_PointRx> l_ListPoint = new List<DataType.StaubliRobotData.St_PointRx>();
            List<DataType.StaubliRobotData.St_JointRx> l_ListJoint = new List<DataType.StaubliRobotData.St_JointRx>();
            int i = 0, j = 0, k = 0, l = 0, m = 0;

            if (x_ListPoint == null || x_ListJoint == null || x_ListPoint.Count != x_ListJoint.Count)
            {
                l_bResult = false;
            }
            else
            {
                do
                {
                    l_bResult = true;
                    do
                    {
                        i = m; j = m + 1; k = m + 2; l = m + 3;
                        if (m <= x_ListPoint.Count - 4)
                        {
                            l_bResult = PointTool.ThreeColline(x_ListPoint[i], x_ListPoint[j], x_ListPoint[k], x_nLinePrecision);
                            if (l_bResult == true) { m = m + 1; l_ListIndex.Add(j); }
                        }
                        else
                        {
                            l_bResult = false;
                        }
                    }
                    while (l_bResult == true);
                    l_bResult = true;
                    do
                    {
                        i = m; j = m + 1; k = m + 2; l = m + 3;
                        if (m <= x_ListPoint.Count - 4)
                        {
                            l_bResult = PointTool.IsOnCircle(x_ListPoint[i], x_ListPoint[j], x_ListPoint[k], x_ListPoint[l], x_nLinePrecision, x_nCirclePrecision);
                            if (l_bResult == true) { m = m + 1; l_ListIndex.Add(j); } else { m = m + 2; }
                        }
                        else
                        {
                            l_bResult = false;
                        }
                    }
                    while (l_bResult == true);
                }
                while (m <= x_ListPoint.Count - 4);


                for (int x = 0; x <= x_ListPoint.Count - 1; x++)
                {
                    bool l_bSame = false;
                    l_bSame = ParseTool.FindInt(x, l_ListIndex);
                    if (l_bSame == false)
                    {
                        l_ListPoint.Add(x_ListPoint[x]);
                        l_ListJoint.Add(x_ListJoint[x]);
                    }
                }
                x_ListIndex = l_ListIndex;
                x_ListPoint = l_ListPoint;
                x_ListJoint = l_ListJoint;
                l_bResult = true;
            }
            
            return l_bResult;
        }
    }
}
