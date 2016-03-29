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
            //int[] n=new 
            //ArrayList dsd =  new ArrayList();
            //dsd.Count
           // List<string> ddd= new List<string>;
            List<int> n = new List<int>();
            bool c=a.FindString("/",b,ref n);
        }
    }
}
