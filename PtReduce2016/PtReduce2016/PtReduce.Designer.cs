namespace PtReduce2016
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.PtReduce = new System.Windows.Forms.Button();
            this.OutTxt = new System.Windows.Forms.Button();
            this.txB_LinePrecison = new System.Windows.Forms.TextBox();
            this.lable_LinePrecision = new System.Windows.Forms.Label();
            this.lable_CirclePrecision = new System.Windows.Forms.Label();
            this.txBCirclePrecision = new System.Windows.Forms.TextBox();
            this.Group_Precision = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage_PointInfor = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPage_Version = new System.Windows.Forms.TabPage();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Group_Precision.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage_PointInfor.SuspendLayout();
            this.tabPage_Version.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(30, 337);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
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
            this.OutTxt.Location = new System.Drawing.Point(18, 75);
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
            this.groupBox2.Controls.Add(this.PtReduce);
            this.groupBox2.Controls.Add(this.OutTxt);
            this.groupBox2.Location = new System.Drawing.Point(256, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(134, 124);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "文件操作";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage_PointInfor);
            this.tabControl1.Controls.Add(this.tabPage_Version);
            this.tabControl1.Location = new System.Drawing.Point(12, 171);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(378, 122);
            this.tabControl1.TabIndex = 12;
            // 
            // tabPage_PointInfor
            // 
            this.tabPage_PointInfor.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage_PointInfor.Controls.Add(this.label8);
            this.tabPage_PointInfor.Controls.Add(this.label3);
            this.tabPage_PointInfor.Controls.Add(this.label7);
            this.tabPage_PointInfor.Controls.Add(this.label4);
            this.tabPage_PointInfor.Controls.Add(this.label6);
            this.tabPage_PointInfor.Controls.Add(this.label5);
            this.tabPage_PointInfor.Location = new System.Drawing.Point(4, 22);
            this.tabPage_PointInfor.Name = "tabPage_PointInfor";
            this.tabPage_PointInfor.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_PointInfor.Size = new System.Drawing.Size(370, 96);
            this.tabPage_PointInfor.TabIndex = 0;
            this.tabPage_PointInfor.Text = "点数信息";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.Location = new System.Drawing.Point(131, 70);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(13, 14);
            this.label8.TabIndex = 5;
            this.label8.Text = "0";
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Location = new System.Drawing.Point(131, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 14);
            this.label6.TabIndex = 3;
            this.label6.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Location = new System.Drawing.Point(132, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 14);
            this.label5.TabIndex = 2;
            this.label5.Text = "0";
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
            this.tabPage_Version.Size = new System.Drawing.Size(370, 96);
            this.tabPage_Version.TabIndex = 1;
            this.tabPage_Version.Text = "版本信息";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(114, 53);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 12);
            this.label12.TabIndex = 3;
            this.label12.Text = "2016-4-8";
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
            this.label10.Text = "PtReduce.V1.Trunk.23";
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
            // PtReuce
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 337);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Group_Precision);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
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
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabPage tabPage_Version;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
    }
}

