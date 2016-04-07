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
        public List<DataType.StaubliRobotData.St_PointRx> PtReduce(double x_nPrecision, List<DataType.StaubliRobotData.St_PointRx> x_ListPoint,out List<int> x_ListIndex)
        {
            x_ListIndex = null;
            ParseData ParseTool =new ParseData();
            bool l_bResult = false;
            List<int> l_ListIndex = new List<int>();
            List<DataType.StaubliRobotData.St_PointRx> l_ListPoint = new List<DataType.StaubliRobotData.St_PointRx>();
            int i = 0, j = 0, k = 0, l = 0, m = 0;
            do
            {
                l_bResult=true;
                do
                {
                    i = m; j = m + 1; k = m + 2; l = m + 3;
                    if (m <= x_ListPoint.Count - 4)
                    {
                        l_bResult = PointTool.ThreeColline(x_ListPoint[i], x_ListPoint[j], x_ListPoint[k], x_nPrecision);
                        if (l_bResult == true) { m = m + 1; l_ListIndex.Add(j); }
                    }
                    else
                    {
                        l_bResult = false;
                    }
                }
                while (l_bResult == true);
                l_bResult=true;
                do
                {
                    i = m; j = m + 1; k = m + 2; l = m + 3;
                    if (m <=x_ListPoint.Count - 4)
                    {              
                        l_bResult = PointTool.IsOnCircle(x_ListPoint[i], x_ListPoint[j], x_ListPoint[k], x_ListPoint[l], x_nPrecision);
                        if (l_bResult == true) { m = m + 1; l_ListIndex.Add(j); } else { m = m + 2; }
                    }
                    else
                    {
                        l_bResult = false;
                    }
                }
                while (l_bResult == true);
            }
            while (m<=x_ListPoint.Count-4);

            
            for (int x = 0; x <= x_ListPoint.Count - 1;x++ )
            {
                bool l_bSame = false;
                
                for (int y = 0; y <= l_ListIndex.Count - 1; y++)
                {
                    if (x == l_ListIndex[y])
                    {
                        l_bSame = true;
                        break;
                    }    
                }
                if (l_bSame == false)
                {
                    l_ListPoint.Add(x_ListPoint[x]);
                }
            }
            x_ListIndex = l_ListIndex;
            return l_ListPoint;
        }
    }
}
