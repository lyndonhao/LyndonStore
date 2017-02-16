using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Collections;
using MathMatics;
using FileTools;


namespace DataProcessTools
{
    public class ProcessData
    {
        //public bool PtReduce(double x_nLinePrecision, double x_nCirclePrecision, ref List<DataType.StaubliRobotData.St_JointRx> x_ListJoint, ref List<DataType.StaubliRobotData.St_PointRx> x_ListPoint, out List<int> x_ListIndex)
        //{
        //    x_ListIndex = null;
        //    ParseData ParseTool =new ParseData();
        //    bool l_bResult = false;
        //    List<int> l_ListIndex = new List<int>();
        //    List<DataType.StaubliRobotData.St_PointRx> l_ListPoint = new List<DataType.StaubliRobotData.St_PointRx>();
        //    List<DataType.StaubliRobotData.St_JointRx> l_ListJoint = new List<DataType.StaubliRobotData.St_JointRx>();
        //    int i = 0, j = 0, k = 0, l = 0, m = 0;

        //    if (x_ListPoint == null || x_ListJoint == null || x_ListPoint.Count != x_ListJoint.Count)
        //    {
        //        l_bResult = false;
        //    }
        //    else
        //    {
        //        do
        //        {
        //            l_bResult = true;
        //            do
        //            {
        //                i = m; j = m + 1; k = m + 2; l = m + 3;
        //                if (m <= x_ListPoint.Count - 4)
        //                {
        //                    l_bResult = PointTool.ThreeColline(x_ListPoint[i], x_ListPoint[j], x_ListPoint[k], x_nLinePrecision);
        //                    if (l_bResult == true) { m = m + 1; l_ListIndex.Add(j); }
        //                }
        //                else
        //                {
        //                    l_bResult = false;
        //                }
        //            }
        //            while (l_bResult == true);
        //            l_bResult = true;
        //            do
        //            {
        //                i = m; j = m + 1; k = m + 2; l = m + 3;
        //                if (m <= x_ListPoint.Count - 4)
        //                {
        //                    l_bResult = PointTool.IsOnCircle(x_ListPoint[i], x_ListPoint[j], x_ListPoint[k], x_ListPoint[l], x_nLinePrecision, x_nCirclePrecision);
        //                    if (l_bResult == true) { m = m + 1; l_ListIndex.Add(j); } else { m = m + 2; }
        //                }
        //                else
        //                {
        //                    l_bResult = false;
        //                }
        //            }
        //            while (l_bResult == true);
        //        }
        //        while (m <= x_ListPoint.Count - 4);


        //        for (int x = 0; x <= x_ListPoint.Count - 1; x++)
        //        {
        //            bool l_bSame = false;
        //            l_bSame = ParseTool.FindInt(x, l_ListIndex);
        //            if (l_bSame == false)
        //            {
        //                l_ListPoint.Add(x_ListPoint[x]);
        //                l_ListJoint.Add(x_ListJoint[x]);
        //            }
        //        }
        //        x_ListIndex = l_ListIndex;
        //        x_ListPoint = l_ListPoint;
        //        x_ListJoint = l_ListJoint;
        //        l_bResult = true;
        //    }

        //    return l_bResult;
        //}


        public bool PtReduce(double x_nLinePrecision, double x_nCirclePrecision, ref List<DataType.StaubliRobotData.St_JointRx> x_ListJoint, ref List<DataType.StaubliRobotData.St_PointRx> x_ListPoint, out List<int> x_ListIndex, out List<string> x_ListIdentifier)
        {
            x_ListIndex = null;
            x_ListIdentifier = null;
            ParseData ParseTool = new ParseData();
            bool l_bResult = false;
            bool l_bLine = false;
            bool l_bCircle = false;
            List<int> l_ListIndex = new List<int>();
            List<string> l_ListIdentifier = new List<string>();

            List<DataType.StaubliRobotData.St_PointRx> l_ListPoint = new List<DataType.StaubliRobotData.St_PointRx>();
            List<DataType.StaubliRobotData.St_JointRx> l_ListJoint = new List<DataType.StaubliRobotData.St_JointRx>();
            int n = 0, i = 1,z=1;
            int l_nCount = x_ListPoint.Count;
            double l_nAngle = new double();
            double l_nLineDeviation = new double();
            double l_nCircleDeviation = new double();
            //double l_nRadius1 = new double();
            //double l_nRadius2 = new double();
            DataType.BasicDataType.vector l_InitCenter = new DataType.BasicDataType.vector();
            l_InitCenter.x = 0;
            l_InitCenter.y = 0;
            l_InitCenter.z = 0;
            if (x_ListPoint == null || x_ListJoint == null || x_ListPoint.Count != x_ListJoint.Count)
            {
                l_bResult = false;
            }
            else
            {
                l_ListIndex.Add(n);
                l_ListIdentifier.Add("MOVEJ");
                i = 1;
                do
                {
                    i = 1;
                    z = 1;
                    PointTool.CenterPoint=l_InitCenter;
                    PointTool.Radius = 0;
                    PointTool.UseSpecifyPara = false;
                    l_bLine = false;
                    l_bCircle = false;
                    l_bLine = PointTool.CKYThreeColline(x_ListPoint[n], x_ListPoint[n + 1], x_ListPoint[n + 2], x_nLinePrecision,ref l_nLineDeviation);
                    if (n+2+i<=l_nCount-1)
                    {
                        l_bCircle = PointTool.CKYIsOnCircle(x_ListPoint[n], x_ListPoint[n + 1], x_ListPoint[n + 2], x_ListPoint[n + 2 + i], x_nLinePrecision, x_nCirclePrecision,ref l_nCircleDeviation);
                    }           
                    if (l_bLine == true && l_bCircle == true)
                    {
                        int x=0, y = 0;
                        bool l_PointOnLine,l_PointOnCircle=false;
                        do
                        {
                            l_PointOnLine = PointTool.CKYThreeColline(x_ListPoint[n], x_ListPoint[n + 1], x_ListPoint[n + 2+x], x_nLinePrecision, ref l_nLineDeviation);
                            if (l_PointOnLine == true)
                            {
                                x = x + 1;
                            }
                        }
                        while (l_PointOnLine == true && n + 2 + x <= l_nCount - 1);
                        do
                        {
                            l_PointOnCircle = PointTool.CKYIsOnCircle(x_ListPoint[n], x_ListPoint[n + 1], x_ListPoint[n + 2], x_ListPoint[n + 2 + y+1], x_nLinePrecision, x_nCirclePrecision, ref l_nCircleDeviation);
                            if (l_PointOnCircle == true)
                            {
                                y = y + 1;
                            }
                        }
                        while (l_PointOnCircle == true && n + 2 + y <= l_nCount - 1);
                        //if (l_nLineDeviation<l_nCircleDeviation)
                        x = x + 2;
                        y = y + 3;
                        if(x>y)
                        {
                            l_bResult = true;
                        }
                        if (x == y)
                        {
                            if (l_nLineDeviation < l_nCircleDeviation)
                            {
                                l_bResult = true;
                            }
                            else
                            {
                                l_bResult = false;
                            }
                        }
                        if(x<y)
                        {
                            l_bResult = false;
                        }
                    }
                    else
                    {
                        l_bResult = PointTool.CKYThreeColline(x_ListPoint[n], x_ListPoint[n + 1], x_ListPoint[n + 2], x_nLinePrecision, ref l_nLineDeviation);
                    }
                    if (l_bResult == true)
                    {
                        if (n + 2 == l_nCount - 1)
                        {
                            l_ListIndex.Add(n + 2);
                            l_ListIdentifier.Add("MOVEJ");
                        }
                        else
                        {
                            do
                            {
                                l_bResult = PointTool.CKYThreeColline(x_ListPoint[n], x_ListPoint[n + 1], x_ListPoint[n + 2 + i], x_nLinePrecision,ref l_nLineDeviation);
                                if (l_bResult == true)
                                {
                                    if (n + 2 + i == l_nCount - 1)
                                    {
                                        l_ListIndex.Add(n + 2 + i);
                                        l_ListIdentifier.Add("MOVEJ");
                                        break;
                                    }
                                    else
                                    {
                                        i = i + 1;
                                    }
                                }
                                else
                                {
                                    l_ListIndex.Add(n + 2 + i - 1);
                                    l_ListIdentifier.Add("MOVEJ");
                                    break;
                                }
                            }
                            while (l_bResult == true && n + 2 + i <= l_nCount - 1);
                        }
                    }
                    else
                    {
                        if (n + 2 == l_nCount - 1)
                        {
                            l_bResult = BasicMathTool.VectAngle(x_ListPoint[n], x_ListPoint[n + 1], x_ListPoint[n + 2], ref l_nAngle);
                            if (l_nAngle<=180&&l_bResult==true)
                            {
                                l_ListIndex.Add(n + 1);
                                l_ListIndex.Add(n + 2);
                                l_ListIdentifier.Add("MOVEC");
                                l_ListIdentifier.Add("MOVEC");
                                break;
                            }
                            else
                            {
                                l_ListIndex.Add(n + 1);
                                l_ListIndex.Add(n + 2);
                                l_ListIdentifier.Add("MOVEJ");
                                l_ListIdentifier.Add("MOVEJ");
                                break;
                            }
                        }
                        else
                        {
                            l_bResult = BasicMathTool.VectAngle(x_ListPoint[n], x_ListPoint[n + 1], x_ListPoint[n + 2], ref l_nAngle);
                            if (l_nAngle<=180&&l_bResult==true)
                            {
                                do
                                {
                                    
                                    if (i == 1)
                                    {
                                        l_bResult = PointTool.CKYIsOnCircle(x_ListPoint[n], x_ListPoint[n + 1], x_ListPoint[n + 2], x_ListPoint[n + 2 + i], x_nLinePrecision, x_nCirclePrecision, ref l_nCircleDeviation);
                                    }
                                    else
                                    {
                                        //l_bResult = PointTool.CKYIsOnCircle(x_ListPoint[n + 1], x_ListPoint[n + 2], x_ListPoint[n + 3], x_ListPoint[n + 2 + i], x_nLinePrecision, x_nCirclePrecision, ref l_nCircleDeviation);
                                        //l_bResult = PointTool.CKYIsOnCircle(x_ListPoint[n+2], x_ListPoint[n + 3], x_ListPoint[n + 4], x_ListPoint[n + 2 + i], x_nLinePrecision, x_nCirclePrecision, ref l_nCircleDeviation);
                                        l_bResult = PointTool.CKYIsOnCircle(x_ListPoint[n], x_ListPoint[n + 1], x_ListPoint[n + 2], x_ListPoint[n + 2 + i], x_nLinePrecision, x_nCirclePrecision, ref l_nCircleDeviation);

                                    }
                                   
                                    if (l_bResult == true)
                                    {
                                        if (n + 2 + i == l_nCount - 1)
                                        {
                                            l_bResult = BasicMathTool.VectAngle(x_ListPoint[n], x_ListPoint[n + 1], x_ListPoint[n + 2], ref l_nAngle);
                                            if (l_nAngle<=180&&l_bResult==true)
                                            {
                                                l_ListIndex.Add(n + 1 + i / 2);
                                                l_ListIndex.Add(n + 2 + i);
                                                l_ListIdentifier.Add("MOVEC");
                                                l_ListIdentifier.Add("MOVEC");
                                                break;
                                            }
                                            else
                                            {
                                                l_ListIndex.Add(n + 1);
                                                l_ListIndex.Add(n + 2);
                                                l_ListIndex.Add(n + 2 + i);
                                                l_ListIdentifier.Add("MOVEC");
                                                l_ListIdentifier.Add("MOVEC");
                                                l_ListIdentifier.Add("MOVEJ");
                                                break;
                                            }
                                            
                                        }
                                        else
                                        {
                                            l_bResult = BasicMathTool.VectAngle(x_ListPoint[n], x_ListPoint[n + 1], x_ListPoint[n + 2], ref l_nAngle);
                                            if (l_nAngle<=180&&l_bResult==true)
                                            {
                                                i = i + 1;
                                            }
                                            else
                                            {
                                                l_ListIndex.Add(n + 1 + i / 2);
                                                l_ListIndex.Add(n + 2 + i);
                                                l_ListIdentifier.Add("MOVEC");
                                                l_ListIdentifier.Add("MOVEC");
                                                break;
                                            }
                                        }
                                    }
                                    else
                                    {
                                        if (z == 1)
                                        {
                                            List<DataType.BasicDataType.vector> l_CenterPoint=new List<DataType.BasicDataType.vector>();
                                            List<double> l_ListRadius = new List<double>();
                                            DataType.BasicDataType.vector l_Center=new DataType.BasicDataType.vector();
                                            DataType.BasicDataType.vector l_AverageCener = new DataType.BasicDataType.vector();
                                            double l_Radius=0,l_AverageRadius=0;
                                            
                                            DataType.BasicDataType.vector l_v1, l_v2, l_v3;
                                            for (int k = 1; k <= i; k++)
                                            {
                                                l_v1 = PointTool.Point2Vector(x_ListPoint[n]);
                                                l_v2 = PointTool.Point2Vector(x_ListPoint[n+1+k/2]);
                                                l_v3 = PointTool.Point2Vector(x_ListPoint[n+2+k-1]);
                                                PointTool.CreatCircle(l_v1, l_v2, l_v3, out l_Center, out l_Radius);
                                                l_CenterPoint.Add(l_Center);
                                                l_ListRadius.Add(l_Radius);
                                            }
                                            for (int k = 0; k < l_CenterPoint.Count; k++)
                                            {
                                                l_AverageCener.x = l_AverageCener.x + l_CenterPoint[k].x;
                                                l_AverageCener.y = l_AverageCener.y + l_CenterPoint[k].y;
                                                l_AverageCener.z = l_AverageCener.z + l_CenterPoint[k].z;
                                                l_AverageRadius = l_AverageRadius + l_ListRadius[k];
                                            }
                                            l_AverageCener.x = l_AverageCener.x / l_CenterPoint.Count;
                                            l_AverageCener.y = l_AverageCener.y / l_CenterPoint.Count;
                                            l_AverageCener.z = l_AverageCener.z / l_CenterPoint.Count;
                                            l_AverageRadius = l_AverageRadius / l_ListRadius.Count;
                                            PointTool.CenterPoint = l_AverageCener;
                                            PointTool.Radius = l_AverageRadius;
                                            PointTool.UseSpecifyPara = true;
                                            z = z + 1;
                                            l_bResult = true;
                                            i = 1;
                                        }
                                        else
                                        {
                                            l_ListIndex.Add(n + 1 + i / 2);
                                            l_ListIndex.Add(n + 2 + i - 1);
                                            l_ListIdentifier.Add("MOVEC");
                                            l_ListIdentifier.Add("MOVEC");
                                            z = 1;
                                            break;

                                        }
                                    }
                                }
                                while (l_bResult == true && n + 2 + i <= l_nCount - 1);
                            }
                            else
                            {
                                l_ListIndex.Add(n + 1);
                                l_ListIndex.Add(n + 2);
                                l_ListIdentifier.Add("MOVEJ");
                                l_ListIdentifier.Add("MOVEJ");
                            }
                            
                        }
                    }
                    if (n + 2 + i == l_nCount - 1)
                    {
                        l_ListIndex.Add(n + 2 + i);
                        l_ListIdentifier.Add("MOVEJ");
                        break;
                    }
                    else
                    {
                        n = n + 2 + i - 1;

                    }
                }
                while (n + 2 <= l_nCount - 1);

                for (int j = 0; j <= l_ListIndex.Count - 1; j++)
                {
                    l_ListPoint.Add(x_ListPoint[l_ListIndex[j]]);
                    l_ListJoint.Add(x_ListJoint[l_ListIndex[j]]);
                }
                x_ListIndex = l_ListIndex;
                x_ListIdentifier = l_ListIdentifier;
                x_ListJoint = l_ListJoint;
                x_ListPoint = l_ListPoint;
                l_bResult = true;
            }
            return l_bResult;
        }
        public bool PtReduce(string[] x_sTargetString, out string[] x_sOutString, double x_nLinePrecision, double x_nCirclePrecision, string x_sStartIdentifier, string x_sEndIdentifier, ref int x_nOldPoint, ref int x_nRemainPoint)
        {
            ///实例化相关对象
            bool l_bResult = false;
            ParseData ParseTool = new ParseData();
            string[] l_sTargetString = x_sTargetString;
            List<int> l_ListInt = new List<int>();

            List<int> l_ListStartIndex = new List<int>();
            List<int> l_ListEndIndex = new List<int>();
            List<string> l_ListIdentifier = new List<string>();
            List<string[]> l_ListOutString = new List<string[]>();

            //流程
            x_sOutString = null;

            bool l_bResult1 = ParseTool.FindString(x_sStartIdentifier, x_sTargetString, ref l_ListStartIndex);
            bool l_bResult2 = ParseTool.FindString(x_sEndIdentifier, x_sTargetString, ref l_ListEndIndex);
            List<DataType.StaubliRobotData.St_JointRx>[] l_ListJoint = new List<DataType.StaubliRobotData.St_JointRx>[l_ListStartIndex.Count];
            List<DataType.StaubliRobotData.St_PointRx>[] l_ListPoint = new List<DataType.StaubliRobotData.St_PointRx>[l_ListStartIndex.Count];

            if (l_bResult1 == true & l_bResult2 == true)
            {
                if (l_ListStartIndex.Count == l_ListEndIndex.Count)
                {
                    for (int i = 0; i <= l_ListStartIndex.Count - 1; i++)
                    {
                        l_bResult1 = ParseTool.getJoint("/", ',', x_sTargetString, l_ListStartIndex[i], l_ListEndIndex[i], out l_ListJoint[i]);
                        l_bResult2 = ParseTool.getPoint("/", ',', x_sTargetString, l_ListStartIndex[i], l_ListEndIndex[i], out l_ListPoint[i]);
                        x_nOldPoint = x_nOldPoint + l_ListPoint[i].Count;

                        if (l_bResult1 == true & l_bResult2 == true)
                        {
                            l_bResult = PtReduce(x_nLinePrecision, x_nCirclePrecision, ref l_ListJoint[i], ref l_ListPoint[i], out l_ListInt, out l_ListIdentifier);
                            x_nRemainPoint = x_nRemainPoint + l_ListPoint[i].Count;
                            if (l_bResult == true)
                            {

                                if (l_bResult1 == true & l_bResult2 == true)
                                {
                                    l_sTargetString = ParseTool.Trans2Standard(l_ListJoint[i], l_ListPoint[i], "/", ",", l_sTargetString, l_ListStartIndex[i] + 1, l_ListEndIndex[i] - 1, l_ListIdentifier);
                                }
                            }
                            else
                            {
                                l_bResult = false;
                                break;
                            }
                        }
                    }
                    if (l_bResult == true) { x_sOutString = l_sTargetString; }
                }
            }


            return l_bResult;
        }
    }
}
