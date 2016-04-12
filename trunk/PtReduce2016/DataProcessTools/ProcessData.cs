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


        public bool PtReduce(double x_nLinePrecision, double x_nCirclePrecision, ref List<DataType.StaubliRobotData.St_JointRx> x_ListJoint, ref List<DataType.StaubliRobotData.St_PointRx> x_ListPoint, out List<int> x_ListIndex,out List<string> x_ListIdentifier)
        {
            x_ListIndex = null;
            x_ListIdentifier = null;
            ParseData ParseTool = new ParseData();
            bool l_bResult = false;
            List<int> l_ListIndex = new List<int>();
            List<string> l_ListIdentifier = new List<string>();

            List<DataType.StaubliRobotData.St_PointRx> l_ListPoint = new List<DataType.StaubliRobotData.St_PointRx>();
            List<DataType.StaubliRobotData.St_JointRx> l_ListJoint = new List<DataType.StaubliRobotData.St_JointRx>();
            int n = 0, k = 1,i=1;
            int l_nCount=x_ListPoint.Count;

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
                    l_bResult = PointTool.CKYThreeColline(x_ListPoint[n], x_ListPoint[n + 1], x_ListPoint[n + 2], x_nLinePrecision);
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
                                l_bResult = PointTool.CKYThreeColline(x_ListPoint[n], x_ListPoint[n + 1], x_ListPoint[n + 2 + i], x_nLinePrecision);
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
                            l_ListIndex.Add(n + 1 );
                            l_ListIndex.Add(n + 2 );
                            l_ListIdentifier.Add("MOVEC");
                            l_ListIdentifier.Add("MOVEC");
                            break;
                        }
                        else
                        {
                            do
                            {
                                l_bResult = PointTool.CKYIsOnCircle(x_ListPoint[n], x_ListPoint[n + 1], x_ListPoint[n + 2], x_ListPoint[n + 2 + i], x_nLinePrecision, x_nCirclePrecision);
                                if (l_bResult == true)
                                {
                                    if (n + 2 + i == l_nCount - 1)
                                    {
                                        l_ListIndex.Add(n + 1 + i / 2);
                                        l_ListIndex.Add(n + 2 + i);
                                        l_ListIdentifier.Add("MOVEC");
                                        l_ListIdentifier.Add("MOVEC");
                                        break;
                                    }
                                    else
                                    {
                                        i = i + 1;
                                    }
                                }
                                else
                                {
                                    l_ListIndex.Add(n + 1 + i / 2);
                                    l_ListIndex.Add(n + 2 + i - 1);
                                    l_ListIdentifier.Add("MOVEC");
                                    l_ListIdentifier.Add("MOVEC");
                                    break;
                                    
                                }
                            }
                            while (l_bResult == true && n + 2 + i <= l_nCount - 1);
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
                while (n + 2 <= l_nCount-1);
                
                for (int j = 0; j <= l_ListIndex.Count-1; j++)
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
        public bool PtReduce(string[] x_sString,out string[] x_sOutString, double x_nLinePrecision, double x_nCirclePrecision,string x_sStartIdentifier,string x_sEndIdentifier,ref int x_nOldPoint,ref int x_nRemainPoint)
        {
            bool l_bResult = false;
            //fileRead fr = new fileRead();
            ParseData ParseTool=new ParseData();
            List<DataType.StaubliRobotData.St_JointRx> l_ListJoint=new List<DataType.StaubliRobotData.St_JointRx>();
            List<DataType.StaubliRobotData.St_PointRx> l_ListPoint=new List<DataType.StaubliRobotData.St_PointRx>();
            List<int> l_ListInt=new List<int>();

            List<int> l_ListStart=new List<int>();
            List<int> l_ListEnd=new List<int>();
            List<string> l_ListIdentifier=new List<string>();

            x_sOutString = null;
            //for (int i = 0; i < x_sString.Length; i++) { x_sOutString[i] = x_sString[i]; }
            bool l_bResult1 = ParseTool.getJoint("/", ',', x_sString, x_sStartIdentifier, x_sEndIdentifier, out l_ListJoint);
            bool l_bResult2 = ParseTool.getPoint("/", ',', x_sString, x_sStartIdentifier, x_sEndIdentifier, out l_ListPoint);
            if (l_bResult1 == true & l_bResult2 == true)
            {
                x_nOldPoint = l_ListPoint.Count;
                l_bResult = PtReduce(x_nLinePrecision, x_nCirclePrecision, ref l_ListJoint, ref l_ListPoint, out l_ListInt,out l_ListIdentifier);
                x_nRemainPoint = l_ListPoint.Count;
                if (l_bResult==true)
                {
                    l_bResult1 = ParseTool.FindString(x_sStartIdentifier, x_sString, ref l_ListStart);
                    l_bResult2 = ParseTool.FindString(x_sEndIdentifier, x_sString, ref l_ListEnd);
                    if (l_bResult1 == true & l_bResult2 == true)
                    {
                        x_sOutString = ParseTool.Trans2Standard(l_ListJoint, l_ListPoint, "/", ",", x_sString, l_ListStart[0]+1, l_ListEnd[0]-1);
                    }
                }       
            }
            return l_bResult;
        }
    }
}
