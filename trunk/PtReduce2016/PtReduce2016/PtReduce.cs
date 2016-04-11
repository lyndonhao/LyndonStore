﻿using System;
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
                   int l_ReduceLength=new int();
                   bool l_bok = l_ProcessData.PtReduce(l_s, out GlobalData.sOutString, l_nlinePrecision, l_nCirclePrecision, "LaserON", "LaserOFF",ref l_ReduceLength);
                   label_OldPoint.Text = Convert.ToString(l_s.Length);
                   label_NewPoint.Text = Convert.ToString(l_s.Length-l_ReduceLength);
                   label_ReducePoint.Text = Convert.ToString(l_ReduceLength);
                      // .Text = Convert.ToString(l_s.Length);
               }
           }
           else
           {
               MessageBox.Show("11");
              // GlobalData.sError[0] = "12";
               //MessageBox.Show(GlobalData.sError[0]);
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
    }
}