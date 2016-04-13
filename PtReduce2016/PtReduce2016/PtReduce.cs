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
using System.IO;

namespace PtReduce2016
{
    public partial class PtReuce : Form
    {
        public int a = new int();
        public PtReuce()
        {
            InitializeComponent();
        }

        private void PtReuce_Load(object sender, EventArgs e)
        {
            txB_LinePrecison.Text = "0.5";
            txBCirclePrecision.Text = "0.5";
            
            
           // label_NewPoint.Text=conv

            //this.reportViewer1.RefreshReport();
        }


        private void PtReduce_Click(object sender, EventArgs e)
        {
            ProcessData l_ProcessData=new ProcessData();
            string l_sPath = string.Empty;
            FileTools.fileRead fr = new FileTools.fileRead();
            
           OpenFileDialog ofd = new OpenFileDialog();
           double l_nlinePrecision = new double();
           double l_nCirclePrecision = new double();

           if (txB_LinePrecison.Text != "" & txBCirclePrecision.Text != "")
           {
               l_nlinePrecision = double.Parse(txB_LinePrecison.Text);
               l_nCirclePrecision = double.Parse(txBCirclePrecision.Text);

               //获取点    
               if (ofd.ShowDialog() == DialogResult.OK) { l_sPath = ofd.FileName; }
               if (l_sPath != string.Empty)
               {
                   //读取文件
                   string[] l_s = fr.ReadTxt(l_sPath);
                   //GlobalData.sOldStringLength = l_s.Length;
                   int l_nRemainLength=new int();
                   int l_nOldLength = new int();
                   bool l_bok = l_ProcessData.PtReduce(l_s, out GlobalData.sOutString, l_nlinePrecision, l_nCirclePrecision, "LaserON", "LaserOFF",ref l_nOldLength, ref l_nRemainLength);
                   label_OldPoint.Text = Convert.ToString(l_nOldLength);
                   label_NewPoint.Text = Convert.ToString(l_nRemainLength);
                   label_ReducePoint.Text = Convert.ToString(l_nOldLength-l_nRemainLength);
                      // .Text = Convert.ToString(l_s.Length);
                   string l_filename = Path.GetFileName(l_sPath);
                   listBox_OperationInfor.Items.Add(DateTime.Now.ToString() + ":" + l_filename + " 直线精度：" + txB_LinePrecison.Text + "圆弧精度：" + txBCirclePrecision.Text + "/" + label_OldPoint.Text + "/" + label_NewPoint.Text + "/" + label_ReducePoint.Text);
               }
           }
           else
           {
               MessageBox.Show("11");
           }
           
              
            
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
                         MessageBox.Show("22");
                     }
                 }
             }
             catch (Exception ex)
             {
                 throw ex;
             }
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataType.BasicDataType.vector l_v1 = new DataType.BasicDataType.vector();
            DataType.BasicDataType.vector l_v2 = new DataType.BasicDataType.vector();
            DataType.BasicDataType.vector l_v3 = new DataType.BasicDataType.vector();
            l_v1.x = -1;
            l_v1.y = 0;
            l_v1.z = 2;
            l_v2.x = 1;
            l_v2.y = 2;
            l_v2.z = -1;
            l_v3.x = 2;
            l_v3.y = 4;
            l_v3.z = 1;
            double l_nDistance = PointTool.PointToLineDistance(l_v1, l_v2, l_v3);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DataType.BasicDataType.vector v1, v2,v3;
            v1.x = 1;
            v1.y = 0;
            v1.z = 0;
            v2.x = -1;
            v2.y = 0;
            v2.z = 0;
            v3.x = 0;
            v3.y = -1;
            v3.z = 0;
            double a=new double();
            bool l_bok= BasicMathTool.VectAngle(v1, v2,ref a);
             l_bok = BasicMathTool.VectAngle(v2, v3, ref a);
             l_bok = BasicMathTool.VectAngle(v1, v2,v3, ref a);
        }
    }
}
