﻿namespace PtReduce2016
{
    partial class PtReuce
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PtReuce));
            this.PtReduce = new System.Windows.Forms.Button();
            this.OutTxt = new System.Windows.Forms.Button();
            this.txB_LinePrecison = new System.Windows.Forms.TextBox();
            this.lable_LinePrecision = new System.Windows.Forms.Label();
            this.lable_CirclePrecision = new System.Windows.Forms.Label();
            this.txBCirclePrecision = new System.Windows.Forms.TextBox();
            this.Group_Precision = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_OutHistory = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage_PointInfor = new System.Windows.Forms.TabPage();
            this.label_ReducePoint = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label_NewPoint = new System.Windows.Forms.Label();
            this.label_OldPoint = new System.Windows.Forms.Label();
            this.tabPage_Version = new System.Windows.Forms.TabPage();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tabPage_OperatorInfor = new System.Windows.Forms.TabPage();
            this.listBox_OperationInfor = new System.Windows.Forms.ListBox();
            this.Group_Precision.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage_PointInfor.SuspendLayout();
            this.tabPage_Version.SuspendLayout();
            this.tabPage_OperatorInfor.SuspendLayout();
            this.SuspendLayout();
            // 
            // PtReduce
            // 
            this.PtReduce.Location = new System.Drawing.Point(18, 27);
            this.PtReduce.Name = "PtReduce";
            this.PtReduce.Size = new System.Drawing.Size(75, 23);
            this.PtReduce.TabIndex = 3;
            this.PtReduce.Text = "PtReduce";
            this.PtReduce.UseVisualStyleBackColor = true;
            this.PtReduce.Click += new System.EventHandler(this.PtReduce_Click);
            // 
            // OutTxt
            // 
            this.OutTxt.Location = new System.Drawing.Point(18, 62);
            this.OutTxt.Name = "OutTxt";
            this.OutTxt.Size = new System.Drawing.Size(75, 23);
            this.OutTxt.TabIndex = 4;
            this.OutTxt.Text = "输出文件";
            this.OutTxt.UseVisualStyleBackColor = true;
            this.OutTxt.Click += new System.EventHandler(this.OutTxt_Click);
            // 
            // txB_LinePrecison
            // 
            this.txB_LinePrecison.Location = new System.Drawing.Point(94, 35);
            this.txB_LinePrecison.Name = "txB_LinePrecison";
            this.txB_LinePrecison.Size = new System.Drawing.Size(81, 21);
            this.txB_LinePrecison.TabIndex = 5;
            // 
            // lable_LinePrecision
            // 
            this.lable_LinePrecision.AutoSize = true;
            this.lable_LinePrecision.Location = new System.Drawing.Point(30, 38);
            this.lable_LinePrecision.Name = "lable_LinePrecision";
            this.lable_LinePrecision.Size = new System.Drawing.Size(65, 12);
            this.lable_LinePrecision.TabIndex = 6;
            this.lable_LinePrecision.Text = "直线精度：";
            // 
            // lable_CirclePrecision
            // 
            this.lable_CirclePrecision.AutoSize = true;
            this.lable_CirclePrecision.Location = new System.Drawing.Point(32, 81);
            this.lable_CirclePrecision.Name = "lable_CirclePrecision";
            this.lable_CirclePrecision.Size = new System.Drawing.Size(65, 12);
            this.lable_CirclePrecision.TabIndex = 7;
            this.lable_CirclePrecision.Text = "圆弧精度：";
            // 
            // txBCirclePrecision
            // 
            this.txBCirclePrecision.Location = new System.Drawing.Point(94, 77);
            this.txBCirclePrecision.Name = "txBCirclePrecision";
            this.txBCirclePrecision.Size = new System.Drawing.Size(81, 21);
            this.txBCirclePrecision.TabIndex = 8;
            // 
            // Group_Precision
            // 
            this.Group_Precision.Controls.Add(this.lable_LinePrecision);
            this.Group_Precision.Controls.Add(this.txBCirclePrecision);
            this.Group_Precision.Controls.Add(this.txB_LinePrecison);
            this.Group_Precision.Controls.Add(this.lable_CirclePrecision);
            this.Group_Precision.Location = new System.Drawing.Point(12, 25);
            this.Group_Precision.Name = "Group_Precision";
            this.Group_Precision.Size = new System.Drawing.Size(199, 124);
            this.Group_Precision.TabIndex = 9;
            this.Group_Precision.TabStop = false;
            this.Group_Precision.Text = "精度设置";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_OutHistory);
            this.groupBox2.Controls.Add(this.PtReduce);
            this.groupBox2.Controls.Add(this.OutTxt);
            this.groupBox2.Location = new System.Drawing.Point(307, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(134, 124);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "文件操作";
            // 
            // btn_OutHistory
            // 
            this.btn_OutHistory.Location = new System.Drawing.Point(18, 95);
            this.btn_OutHistory.Name = "btn_OutHistory";
            this.btn_OutHistory.Size = new System.Drawing.Size(75, 23);
            this.btn_OutHistory.TabIndex = 5;
            this.btn_OutHistory.Text = "历史记录";
            this.btn_OutHistory.UseVisualStyleBackColor = true;
            this.btn_OutHistory.Click += new System.EventHandler(this.btn_OutHistory_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage_PointInfor);
            this.tabControl1.Controls.Add(this.tabPage_Version);
            this.tabControl1.Controls.Add(this.tabPage_OperatorInfor);
            this.tabControl1.Location = new System.Drawing.Point(12, 175);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(433, 185);
            this.tabControl1.TabIndex = 12;
            // 
            // tabPage_PointInfor
            // 
            this.tabPage_PointInfor.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage_PointInfor.Controls.Add(this.label_ReducePoint);
            this.tabPage_PointInfor.Controls.Add(this.label3);
            this.tabPage_PointInfor.Controls.Add(this.label7);
            this.tabPage_PointInfor.Controls.Add(this.label4);
            this.tabPage_PointInfor.Controls.Add(this.label_NewPoint);
            this.tabPage_PointInfor.Controls.Add(this.label_OldPoint);
            this.tabPage_PointInfor.Location = new System.Drawing.Point(4, 22);
            this.tabPage_PointInfor.Name = "tabPage_PointInfor";
            this.tabPage_PointInfor.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_PointInfor.Size = new System.Drawing.Size(425, 159);
            this.tabPage_PointInfor.TabIndex = 0;
            this.tabPage_PointInfor.Text = "点数信息";
            // 
            // label_ReducePoint
            // 
            this.label_ReducePoint.AutoSize = true;
            this.label_ReducePoint.Location = new System.Drawing.Point(131, 70);
            this.label_ReducePoint.Name = "label_ReducePoint";
            this.label_ReducePoint.Size = new System.Drawing.Size(11, 12);
            this.label_ReducePoint.TabIndex = 5;
            this.label_ReducePoint.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "原点数：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 4;
            this.label7.Text = "减少点数：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "操作后点数：";
            // 
            // label_NewPoint
            // 
            this.label_NewPoint.AutoSize = true;
            this.label_NewPoint.Location = new System.Drawing.Point(131, 44);
            this.label_NewPoint.Name = "label_NewPoint";
            this.label_NewPoint.Size = new System.Drawing.Size(11, 12);
            this.label_NewPoint.TabIndex = 3;
            this.label_NewPoint.Text = "0";
            // 
            // label_OldPoint
            // 
            this.label_OldPoint.AutoSize = true;
            this.label_OldPoint.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label_OldPoint.Location = new System.Drawing.Point(132, 15);
            this.label_OldPoint.Name = "label_OldPoint";
            this.label_OldPoint.Size = new System.Drawing.Size(11, 12);
            this.label_OldPoint.TabIndex = 2;
            this.label_OldPoint.Text = "0";
            // 
            // tabPage_Version
            // 
            this.tabPage_Version.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage_Version.Controls.Add(this.label12);
            this.tabPage_Version.Controls.Add(this.label11);
            this.tabPage_Version.Controls.Add(this.label10);
            this.tabPage_Version.Controls.Add(this.label9);
            this.tabPage_Version.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Version.Name = "tabPage_Version";
            this.tabPage_Version.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Version.Size = new System.Drawing.Size(425, 159);
            this.tabPage_Version.TabIndex = 1;
            this.tabPage_Version.Text = "版本信息";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(114, 53);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 12);
            this.label12.TabIndex = 3;
            this.label12.Text = "2016-4-12";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(40, 53);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 12);
            this.label11.TabIndex = 2;
            this.label11.Text = "修改时间：";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(112, 21);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(125, 12);
            this.label10.TabIndex = 1;
            this.label10.Text = "PtReduce.V1.Trunk.28";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(40, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 12);
            this.label9.TabIndex = 0;
            this.label9.Text = "版本信息：";
            // 
            // tabPage_OperatorInfor
            // 
            this.tabPage_OperatorInfor.Controls.Add(this.listBox_OperationInfor);
            this.tabPage_OperatorInfor.Location = new System.Drawing.Point(4, 22);
            this.tabPage_OperatorInfor.Name = "tabPage_OperatorInfor";
            this.tabPage_OperatorInfor.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_OperatorInfor.Size = new System.Drawing.Size(425, 159);
            this.tabPage_OperatorInfor.TabIndex = 2;
            this.tabPage_OperatorInfor.Text = "操作历史";
            this.tabPage_OperatorInfor.UseVisualStyleBackColor = true;
            // 
            // listBox_OperationInfor
            // 
            this.listBox_OperationInfor.FormattingEnabled = true;
            this.listBox_OperationInfor.ItemHeight = 12;
            this.listBox_OperationInfor.Location = new System.Drawing.Point(-4, 0);
            this.listBox_OperationInfor.Name = "listBox_OperationInfor";
            this.listBox_OperationInfor.Size = new System.Drawing.Size(429, 160);
            this.listBox_OperationInfor.TabIndex = 13;
            // 
            // PtReuce
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 360);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Group_Precision);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PtReuce";
            this.Text = "PtReduce2016";
            this.Load += new System.EventHandler(this.PtReuce_Load);
            this.Group_Precision.ResumeLayout(false);
            this.Group_Precision.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage_PointInfor.ResumeLayout(false);
            this.tabPage_PointInfor.PerformLayout();
            this.tabPage_Version.ResumeLayout(false);
            this.tabPage_Version.PerformLayout();
            this.tabPage_OperatorInfor.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button PtReduce;
        private System.Windows.Forms.Button OutTxt;
        private System.Windows.Forms.TextBox txB_LinePrecison;
        private System.Windows.Forms.Label lable_LinePrecision;
        private System.Windows.Forms.Label lable_CirclePrecision;
        private System.Windows.Forms.TextBox txBCirclePrecision;
        private System.Windows.Forms.GroupBox Group_Precision;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage_PointInfor;
        private System.Windows.Forms.Label label_ReducePoint;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label_NewPoint;
        private System.Windows.Forms.Label label_OldPoint;
        private System.Windows.Forms.TabPage tabPage_Version;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListBox listBox_OperationInfor;
        private System.Windows.Forms.TabPage tabPage_OperatorInfor;
        private System.Windows.Forms.Button btn_OutHistory;
    }
}

