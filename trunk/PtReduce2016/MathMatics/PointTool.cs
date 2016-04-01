using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathMatics
{
    public class PointTool
    {
        /// <summary>
        /// 判断三点共线
        /// </summary>
        /// <returns>true：共线</returns>false：不共线
        public static bool ThreeColline(DataType.BasicDataType.vector x_vVector1, DataType.BasicDataType.vector x_vVector2, DataType.BasicDataType.vector x_vVector3)
        {
            bool l_bOk = false;
            DataType.BasicDataType.vector l_V1, l_V2;
            l_V1 =BasicMathTool.SubVector(x_vVector1, x_vVector2);
            l_V2 =BasicMathTool.SubVector(x_vVector2, x_vVector3);
            if (l_V2.x * l_V1.y == l_V1.x * l_V2.y & l_V2.x * l_V1.z == l_V2.z * l_V1.x)
            {
                l_bOk = true;
            }
            else
            {
                l_bOk = false;
            }
            return l_bOk;
        }

        public static bool CreatCircle(DataType.BasicDataType.vector x_vVector1, DataType.BasicDataType.vector x_vVector2, DataType.BasicDataType.vector x_vVector3, out DataType.BasicDataType.vector x_vCenterPoint, out double x_nRadius)
        {
            x_vCenterPoint.x = 0;
            x_vCenterPoint.y = 0;
            x_vCenterPoint.z = 0;
            x_nRadius = 0;

            bool l_bOk = false;
            l_bOk = ThreeColline(x_vVector1, x_vVector2, x_vVector3);      
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
    }
}
