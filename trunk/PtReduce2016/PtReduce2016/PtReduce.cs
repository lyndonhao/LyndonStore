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
           // DataProcessTools.ParseData a = new DataProcessTools.ParseData();
           // string b="MOVEJ/-102.709,82.550,-54.028,140.990,112.893,-17.491/-60.284,-10.000,1.000,180.000,0.000,-50.501/";
           // DataType.StaubliRobotData.St_PointRx pPoint=new DataType.StaubliRobotData.St_PointRx();
           //// bool l_bOk=DataProcessTools.ParseData.getPoint("/",',',b,ref pPoint);


           // double[,] matrix_a = new double[3, 3];
           // matrix_a[0, 0] = 1;
           // matrix_a[0, 1] = 2;
           // matrix_a[0, 2] = 3;
           // matrix_a[1, 0] = 5;
           // matrix_a[1, 1] = 6;
           // matrix_a[1, 2] = 7;
           // matrix_a[2, 0] = 9;
           // matrix_a[2, 1] = 8;
           // matrix_a[2, 2] = 3;
           // DataType.BasicDataType.vector l_v1,l_v2,l_v3,l_v4;
           // DataType.BasicDataType.PlaneCoefficient abc;
           // l_v1.x=1;
           // l_v1.y=2;
           // l_v1.z=3;
           // l_v2.x=5;
           // l_v2.y=6;
           // l_v2.z=7;
           // l_v3.x=9;
           // l_v3.y=8;
           // l_v3.z=3;
           // l_v4.x = 3;
           // l_v4.y = 8;
           // l_v4.z = 9;
           // bool l_bResult = PointTool.CreatPlane(l_v1, l_v2, l_v3, out abc);
           // l_bResult = PointTool.IsOnCircle(l_v1, l_v2, l_v3, l_v3, 0.01);
           // l_bResult = PointTool.IsOnCircle(l_v1, l_v2, l_v3, l_v4, 0.01);
           // l_bResult = PointTool.IsOnPlane(l_v1, abc,0);
           // l_bResult = PointTool.IsOnPlane(l_v2, abc, 0);
           // l_bResult = PointTool.IsOnPlane(l_v3, abc, 0);
           // l_bResult = PointTool.IsOnPlane(l_v4, abc, 0);


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

        private void button2_Click(object sender, EventArgs e)
        {
            ProcessData b=new ProcessData();
           // bool l_bResult=a.PtReduce("/",',',)
            string l_logPath = string.Empty;
            FileTools.fileRead a = new FileTools.fileRead();
            FileTools.fileWrite d = new FileTools.fileWrite();
            ParseData c=new ParseData();
            OpenFileDialog ofd = new OpenFileDialog();
            List<int> l_ListIndex=new List<int>();
            List<DataType.StaubliRobotData.St_PointRx> l_ListPoint=new List<StaubliRobotData.St_PointRx>();
            List<DataType.StaubliRobotData.St_JointRx> l_ListJoint = new List<StaubliRobotData.St_JointRx>();
            List<DataType.StaubliRobotData.St_PointRx> l_ListPoint1 = new List<StaubliRobotData.St_PointRx>();

            DataType.StaubliRobotData.St_JointRx l_jJoint = new StaubliRobotData.St_JointRx();
            DataType.StaubliRobotData.St_PointRx l_pPoint = new DataType.StaubliRobotData.St_PointRx();

            l_jJoint.J1 = 90;
            l_jJoint.J2 = 30;
            l_jJoint.J3 = 30;
            l_jJoint.J4 = 30;
            l_jJoint.J5 = 30;
            l_jJoint.J6 = 30;

            l_pPoint.x = 10;
            l_pPoint.y = 10;
            l_pPoint.z = 10;
            l_pPoint.Rx = 10;
            l_pPoint.Ry = 10;
            l_pPoint.Rz = 10;

            if (ofd.ShowDialog() == DialogResult.OK || ofd.ShowDialog() == DialogResult.Yes)
            {
               l_logPath = ofd.FileName;
                //读取文件
               string[] l_s = a.ReadTxt(l_logPath);
                //获取点
                string[] l_s2=new string[l_s.Length];
                bool l_bok = b.PtReduce(l_s,out GlobalData.sOutString, 0.05, 0.05, "LaserON", "LaserOFF");
               //string[] l_s1 = c.StringEmpty(l_s, 44, 88);
               //bool l_bResult = c.getPoint("/", ',', l_s, "LaserON", "LaserOFF", out l_ListPoint);
                //缩减点
               //l_ListPoint1 = b.PtReduce(0.008,0.008, l_ListPoint,out l_ListIndex);
               //string l_sString = c.Trans2Standard(l_jJoint, l_pPoint, "/",",");
                //输出txt文件
            //   try
            //{
            //    string name = "aa";  //文件名
            //    string content = "bb";  //文件内容
            //    string path = string.Empty;  //文件路径
            //    SaveFileDialog save = new SaveFileDialog();
            //    if (save.ShowDialog() == DialogResult.OK)
            //        path = save.FileName;
            //    if (path != string.Empty)
            //    {
            //        using (System.IO.FileStream file = new System.IO.FileStream(path, System.IO.FileMode.Create, System.IO.FileAccess.Write))
            //        {
            //            using (System.IO.TextWriter text = new System.IO.StreamWriter(file, System.Text.Encoding.Default))
            //            {
            //                text.Write(content);
            //            }
            //        }
            //    }
            //}
            //catch (Exception ex)
            //{
            //    throw ex;
            //}
        
                //bool l_bResult = ParseData.FindString("LaserON", l_s, ref l_ListIndex);
                //int l_nstart = l_ListIndex[0];
                //l_bResult = ParseData.FindString("LaserOFF", l_s, ref l_ListIndex);
                //int l_nend = l_ListIndex[0];
                //List<DataType.StaubliRobotData.St_PointRx> l_arrayList = new List<DataType.StaubliRobotData.St_PointRx>();
                //l_bResult = ParseData.getPoint("/", ',', l_s, l_nstart, l_nend, out l_arrayList);
                //l_logPath = ofd.;
                //string[] l_s = a.ReadTxt(l_logPath);
                //this.richTextBox1.Text = LogPath + "\n";//在textBox1控件中显示选择的路径
            }
            //string l_logPath=string.Empty;
            //FileTools.fileRead a=new FileTools.fileRead();
            //ProcessData b=new ProcessData();
            //FolderBrowserDialog dilog = new FolderBrowserDialog();
            //dilog.Description = "请选择文件夹";
            //if (dilog.ShowDialog() == DialogResult.OK || dilog.ShowDialog() == DialogResult.Yes)
            //{
            //     l_logPath = dilog.SelectedPath;
            //     string[] l_s = a.ReadTxt(l_logPath);
            //     List<DataType.StaubliRobotData.St_PointRx> l_ListPoint = b.PtReduce("/", ',', l_s);
            //    //this.richTextBox1.Text = LogPath + "\n";//在textBox1控件中显示选择的路径
            //}
            


        }

        private void OutTxt_Click(object sender, EventArgs e)
        {
             try
             {
                 string l_sPath = string.Empty;  //文件路径
                 SaveFileDialog l_save = new SaveFileDialog();
                 bool l_bResult = false;
                 l_save.Filter = "(*.txt)|*.txt"; 
                 if (l_save.ShowDialog() == DialogResult.OK){ l_sPath = l_save.FileName; }
                 if (l_sPath != string.Empty)
                 {
                     FileTools.fileWrite fw = new FileTools.fileWrite();
                     l_bResult=fw.WriteTxt(GlobalData.sOutString, l_sPath);
                     if (l_bResult == false)
                     {
                         MessageBox.Show("未进行缩减点操作，输出文件失败。");
                     }
                 }
             }
             catch (Exception ex)
             {
                 throw ex;
             }
        }
    }
}
