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

       

       
    }
}
