﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathMatics
{
    public static class PointTool
    {
        public static DataType.BasicDataType.vector Point2Vector(DataType.StaubliRobotData.St_PointRx x_pPoint)
        {
            DataType.BasicDataType.vector l_v;
            l_v.x = x_pPoint.x;
            l_v.y = x_pPoint.y;
            l_v.z = x_pPoint.z;
            return l_v;
        }
        /// <summary>
        /// 判断三点共线
        /// </summary>
        /// <returns>true：共线</returns>false：不共线
        public static bool ThreeColline(DataType.BasicDataType.vector x_vVector1, DataType.BasicDataType.vector x_vVector2, DataType.BasicDataType.vector x_vVector3,double x_nPrecision)
        {
            bool l_bOk = false;
            DataType.BasicDataType.vector l_V1, l_V2;
            l_V1 =BasicMathTool.SubVector(x_vVector1, x_vVector2);
            l_V2 =BasicMathTool.SubVector(x_vVector2, x_vVector3);
            if (Math.Abs( l_V2.x * l_V1.y - l_V1.x * l_V2.y)<=x_nPrecision &Math.Abs( l_V2.x * l_V1.z - l_V2.z * l_V1.x)<=x_nPrecision)
            {
                l_bOk = true;
            }
            else
            {
                l_bOk = false;
            }
            return l_bOk;
        }
        public static bool ThreeColline(DataType.StaubliRobotData.St_PointRx x_pPoint1, DataType.StaubliRobotData.St_PointRx x_pPoint2, DataType.StaubliRobotData.St_PointRx x_pPoint3,double x_nPrecision)
        {
            bool l_bResult = false;
            DataType.BasicDataType.vector l_V1, l_V2, l_V3;
            l_V1 = Point2Vector(x_pPoint1);
            l_V2 = Point2Vector(x_pPoint2);
            l_V3 = Point2Vector(x_pPoint3);
            l_bResult = ThreeColline(l_V1, l_V2, l_V3,x_nPrecision);
            return l_bResult;
        }
        /// <summary>
        /// 三点建圆
        /// </summary>
        /// <param name="x_vVector1"></param>
        /// <param name="x_vVector2"></param>
        /// <param name="x_vVector3"></param>
        /// <param name="x_vCenterPoint"></param>圆心
        /// <param name="x_nRadius"></param>半径
        /// <returns></returns>
        public static bool CreatCircle(DataType.BasicDataType.vector x_vVector1, DataType.BasicDataType.vector x_vVector2, DataType.BasicDataType.vector x_vVector3, out DataType.BasicDataType.vector x_vCenterPoint, out double x_nRadius)
        {
            x_vCenterPoint.x = 0;
            x_vCenterPoint.y = 0;
            x_vCenterPoint.z = 0;
            x_nRadius = 0;

            bool l_bOk = false;
            l_bOk = ThreeColline(x_vVector1, x_vVector2, x_vVector3,0.01);      
            if (l_bOk == false)
            {
                double[,] l_nMatrix = new double[3, 3];
                l_nMatrix[0, 0] = (x_vVector1.y - x_vVector3.y) * (x_vVector2.z - x_vVector3.z) - (x_vVector2.y - x_vVector3.y) * (x_vVector1.z - x_vVector3.z);
                l_nMatrix[0, 1] = (x_vVector2.x - x_vVector3.x) * (x_vVector1.z - x_vVector3.z) - (x_vVector1.x - x_vVector3.x) * (x_vVector2.z - x_vVector3.z);
                l_nMatrix[0, 2] = (x_vVector1.x - x_vVector3.x) * (x_vVector2.y - x_vVector3.y) - (x_vVector2.x - x_vVector3.x) * (x_vVector1.y - x_vVector3.y);
                l_nMatrix[1, 0] = x_vVector2.x - x_vVector1.x;
                l_nMatrix[1, 1] = x_vVector2.y - x_vVector1.y;
                l_nMatrix[1, 2] = x_vVector2.z - x_vVector1.z;
                l_nMatrix[2, 0] = x_vVector3.x - x_vVector2.x;
                l_nMatrix[2, 1] = x_vVector3.y - x_vVector2.y;
                l_nMatrix[2, 2] = x_vVector3.z - x_vVector2.z;
                double[] l_Matrix_b = new double[3];
                l_Matrix_b[0] = l_nMatrix[0, 0] * x_vVector3.x + l_nMatrix[0, 1] * x_vVector3.y + l_nMatrix[0, 2] * x_vVector3.z;
                l_Matrix_b[1] = (l_nMatrix[1, 0] * (x_vVector2.x + x_vVector1.x) + l_nMatrix[1, 1] * (x_vVector2.y + x_vVector1.y) + l_nMatrix[1, 2] * (x_vVector2.z + x_vVector1.z)) / 2;
                l_Matrix_b[2] = (l_nMatrix[2, 0] * (x_vVector3.x + x_vVector2.x) + l_nMatrix[2, 1] * (x_vVector3.y + x_vVector2.y) + l_nMatrix[2, 2] * (x_vVector3.z + x_vVector2.z)) / 2;
                double[,] l_inverse = new double[3, 3];
                l_bOk = MatrixTool.MatrixInverse(l_nMatrix, ref l_inverse);
                if (l_bOk == true)
                {
                    double[] l_CenterPoint = new double[3];
                    l_bOk = MatrixTool.MatrixDotMultiply(l_inverse, l_Matrix_b, out l_CenterPoint);
                    if (l_bOk == true)
                    {
                        x_vCenterPoint.x = l_CenterPoint[0];
                        x_vCenterPoint.y = l_CenterPoint[1];
                        x_vCenterPoint.z = l_CenterPoint[2];
                        x_nRadius = Math.Sqrt(Math.Pow(x_vVector1.x - x_vCenterPoint.x, 2) + Math.Pow(x_vVector1.y - x_vCenterPoint.y, 2) + Math.Pow(x_vVector1.z - x_vCenterPoint.z, 2));
                        
                    }
                }
            }
            return l_bOk;
        }
        /// <summary>
        ///  判断点是否在圆上
        /// </summary>
        /// <returns></returns>
        public static bool IsOnCircle(DataType.StaubliRobotData.St_PointRx x_pPoint1, DataType.StaubliRobotData.St_PointRx x_pPoint2, DataType.StaubliRobotData.St_PointRx x_pPoint3, DataType.StaubliRobotData.St_PointRx x_pPoint4, double x_nLinePrecision, double x_nPrecision)
        {
            bool l_bResult = false;
            DataType.BasicDataType.vector l_v1, l_v2, l_v3,l_v4;
            l_v1 = Point2Vector(x_pPoint1);
            l_v2 = Point2Vector(x_pPoint2);
            l_v3 = Point2Vector(x_pPoint3);
            l_v4 = Point2Vector(x_pPoint4);
            l_bResult = IsOnCircle(l_v1, l_v2, l_v3, l_v4,x_nLinePrecision ,x_nPrecision);
            return l_bResult;
        }
        /// <summary>
        ///  判断点是否在圆上
        /// </summary>
        /// <returns></returns>
        public static bool IsOnCircle(DataType.BasicDataType.vector x_vVector1, DataType.BasicDataType.vector x_vVector2, DataType.BasicDataType.vector x_vVector3,DataType.BasicDataType.vector x_vVector4,double x_nLinePrecision,double x_nPrecision)
        {
            bool l_bResult = false;
            DataType.BasicDataType.vector l_vCenterPoint;
            DataType.BasicDataType.PlaneCoefficient l_pCoefficient;
            double l_nRadius;
            l_bResult = CreatPlane(x_vVector1, x_vVector2, x_vVector3,x_nLinePrecision, out l_pCoefficient);
            if (l_bResult == true)
            {
                l_bResult = IsOnPlane(x_vVector4, l_pCoefficient, x_nPrecision);
                if (l_bResult == true)
                {
                    l_bResult = CreatCircle(x_vVector1, x_vVector2, x_vVector3, out l_vCenterPoint, out l_nRadius);
                    double l_nDistance = BasicMathTool.VectorDistance(l_vCenterPoint, x_vVector4);
                    if (Math.Abs(l_nDistance - l_nRadius) <= x_nPrecision)
                    {
                        l_bResult = true;
                    }
                    else
                    {
                        l_bResult = false;
                    }
                }
            } 
            return l_bResult;
        }
        /// <summary>
        /// 三点建立平面 test success
        /// </summary>
        /// <param name="x_vVector1"></param>
        /// <param name="x_vVector2"></param>
        /// <param name="x_vVector3"></param>
        /// <param name="x_pPlaneCoefficient"></param>
        /// <returns>false 三点共线
        /// </returns>true 成功
        public static bool CreatPlane(DataType.BasicDataType.vector x_vVector1, DataType.BasicDataType.vector x_vVector2, DataType.BasicDataType.vector x_vVector3,double x_nLinePrecision,out DataType.BasicDataType.PlaneCoefficient x_pPlaneCoefficient)
        {
            x_pPlaneCoefficient.a = 0;
            x_pPlaneCoefficient.b = 0;
            x_pPlaneCoefficient.c = 0;
            x_pPlaneCoefficient.d = 0;
            bool l_bResule = false;
            l_bResule = ThreeColline(x_vVector1, x_vVector2, x_vVector3,x_nLinePrecision);
            if (l_bResule == false)
            {
                DataType.BasicDataType.vector l_vVector1 = BasicMathTool.SubVector(x_vVector1, x_vVector2);
                DataType.BasicDataType.vector l_vVector2 = BasicMathTool.SubVector(x_vVector1, x_vVector3);
                DataType.BasicDataType.vector l_vVector3 = BasicMathTool.Vect3CrossPord(l_vVector1, l_vVector2);
                x_pPlaneCoefficient.a = l_vVector3.x;
                x_pPlaneCoefficient.b = l_vVector3.y;
                x_pPlaneCoefficient.c = l_vVector3.z;
                x_pPlaneCoefficient.d = -x_pPlaneCoefficient.a * x_vVector1.x - x_pPlaneCoefficient.b * x_vVector1.y - x_pPlaneCoefficient.c * x_vVector1.z;
                l_bResule = true;
            }
            return l_bResule;
        }
        /// <summary>
        /// 判断点是否在平面上 test success
        /// </summary>
        /// <param name="x_vVector"></param>
        /// <param name="x_pPlaneCoefficient"></param>
        /// <param name="x_nPrecision"></param>
        /// <returns></returns>
        public static bool IsOnPlane(DataType.BasicDataType.vector x_vVector,DataType.BasicDataType.PlaneCoefficient x_pPlaneCoefficient,double x_nPrecision)
        {
            bool l_bResult = false;
            double l_nValue = x_pPlaneCoefficient.a * x_vVector.x + x_pPlaneCoefficient.b * x_vVector.y + x_pPlaneCoefficient.c * x_vVector.z + x_pPlaneCoefficient.d;
            if (l_nValue <= x_nPrecision)
            {
                l_bResult = true;
            }
            else
            {
                l_bResult = false;
            }
            return l_bResult;
        }
    }
}
