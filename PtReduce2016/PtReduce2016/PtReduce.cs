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
                   string l_sHistory = DateTime.Now.ToString() + ":" + l_filename + " 直线精度：" + txB_LinePrecison.Text + "圆弧精度：" + txBCirclePrecision.Text + "/" + label_OldPoint.Text + "/" + label_NewPoint.Text + "/" + label_ReducePoint.Text;
                   listBox_OperationInfor.Items.Add(l_sHistory);
                   GlobalData.ListHistory.Add(l_sHistory);
               }
           }
           else
           {
               MessageBox.Show(GlobalData.sError[0]);
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
                         MessageBox.Show(GlobalData.sError[1]);
                     }
                 }
             }
             catch (Exception ex)
             {
                 throw ex;
             }
        }
        private void btn_OutHistory_Click(object sender, EventArgs e)
        {
            
            if (GlobalData.ListHistory.Count!=0)
            {
                try
                {
                    string l_sPath = string.Empty;  //文件路径
                    SaveFileDialog l_save = new SaveFileDialog();
                    bool l_bResult = false;
                    l_save.Filter = "(*.txt)|*.txt";
                    if (l_save.ShowDialog() == DialogResult.OK) { l_sPath = l_save.FileName; }
                    if (l_sPath != string.Empty)
                    {
                        FileTools.fileWrite fw = new FileTools.fileWrite();
                        string[] l_sHistory = GlobalData.ListHistory.ToArray();
                        l_bResult = fw.WriteTxt(l_sHistory, l_sPath);
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
            else
            {
                MessageBox.Show(GlobalData.sError[2]);
            }
        }
    }
}
