using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DataType;

namespace MathMatics
{
    public static class BasicMathTool
    {
        /// <summary>
        /// 向量差
        /// </summary>
        /// <param name="x_vVector1"></param>
        /// <param name="x_vVector2"></param>
        /// <returns></returns>
        public static DataType.BasicDataType.vector SubVector(DataType.BasicDataType.vector x_vVector1,DataType.BasicDataType.vector x_vVector2)
        {
            DataType.BasicDataType.vector l_vV1;
            l_vV1.x = x_vVector2.x - x_vVector1.x;
            l_vV1.y = x_vVector2.y - x_vVector1.y;
            l_vV1.z = x_vVector2.z - x_vVector1.z;
            return l_vV1;
        }

        /// <summary>
        /// 判断三点共线
        /// </summary>
        /// <returns>true：共线</returns>false：不共线
        public static bool ThreeColline(DataType.BasicDataType.vector x_vVector1, DataType.BasicDataType.vector x_vVector2, DataType.BasicDataType.vector x_vVector3)
        {
            bool l_bOk = false;
            DataType.BasicDataType.vector l_V1, l_V2;
            l_V1 = SubVector(x_vVector1, x_vVector2);
            l_V2 = SubVector(x_vVector2, x_vVector3);
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
    }
}
