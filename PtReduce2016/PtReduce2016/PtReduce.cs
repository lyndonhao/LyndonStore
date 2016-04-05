using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using System.Collections;
using DataProcessTools;
using DataType;
using MathMatics;

namespace PtReduce2016
{
    public partial class PtReuce : Form
    {
        public PtReuce()
        {
            InitializeComponent();
        }

        private void PtReuce_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataProcessTools.ParseData a = new DataProcessTools.ParseData();
            string b="MOVEJ/-102.709,82.550,-54.028,140.990,112.893,-17.491/-60.284,-10.000,1.000,180.000,0.000,-50.501/";
            DataType.StaubliRobotData.St_PointRx pPoint=new DataType.StaubliRobotData.St_PointRx();
            bool l_bOk=DataProcessTools.ParseData.getPoint("/",',',b,pPoint);


            double[,] matrix_a = new double[3, 3];
            matrix_a[0, 0] = 1;
            matrix_a[0, 1] = 2;
            matrix_a[0, 2] = 3;
            matrix_a[1, 0] = 5;
            matrix_a[1, 1] = 6;
            matrix_a[1, 2] = 7;
            matrix_a[2, 0] = 9;
            matrix_a[2, 1] = 8;
            matrix_a[2, 2] = 3;
            DataType.BasicDataType.vector l_v1,l_v2,l_v3,l_v4;
            DataType.BasicDataType.PlaneCoefficient abc;
            l_v1.x=1;
            l_v1.y=2;
            l_v1.z=3;
            l_v2.x=5;
            l_v2.y=6;
            l_v2.z=7;
            l_v3.x=9;
            l_v3.y=8;
            l_v3.z=3;
            l_v4.x = 3;
            l_v4.y = 8;
            l_v4.z = 9;
            bool l_bResult = PointTool.CreatPlane(l_v1, l_v2, l_v3, out abc);
            l_bResult = PointTool.IsOnCircle(l_v1, l_v2, l_v3, l_v3, 0.01);
            l_bResult = PointTool.IsOnCircle(l_v1, l_v2, l_v3, l_v4, 0.01);
            l_bResult = PointTool.IsOnPlane(l_v1, abc,0);
            l_bResult = PointTool.IsOnPlane(l_v2, abc, 0);
            l_bResult = PointTool.IsOnPlane(l_v3, abc, 0);
            l_bResult = PointTool.IsOnPlane(l_v4, abc, 0);
            //DataType.BasicDataType.vector[] abc=new DataType.BasicDataType.vector[4];
            //double r=new double();
            //abc[0].x=1;
            //abc[0].y=2;
            //abc[0].z=3;

            //abc[1].x=5;
            //abc[1].y=6;
            //abc[1].z=7;

            //abc[2].x=9;
            //abc[2].y=8;
            //abc[2].z=3;


            //l_bOk = PointTool.CreatCircle(abc[0], abc[1], abc[2],out abc[3],out r);

            //double[,] matrix_b=new double[3,3];
            //double c=MatrixTool.MatrixSurplus(matrix_a);
            //l_bOk = MatrixTool.MatrixInverse(matrix_a,ref matrix_b);
            //matrix_b = MatrixTool.MatrixTranspose(matrix_a);
            
            //int[] n=new 
            //ArrayList dsd =  new ArrayList();
            //dsd.Count
           // List<string> ddd= new List<string>;
            //List<int> n = new List<int>();
           // bool c=a.FindString("/",b,ref n);
        }
    }
}
