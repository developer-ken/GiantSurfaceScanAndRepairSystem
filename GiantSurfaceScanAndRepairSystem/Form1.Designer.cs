﻿namespace GiantSurfaceScanAndRepairSystem
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            splitContainer1 = new SplitContainer();
            splitContainer2 = new SplitContainer();
            pictureBox1 = new PictureBox();
            move_sander = new RadioButton();
            move_scanner = new RadioButton();
            button16 = new Button();
            button15 = new Button();
            button13 = new Button();
            button14 = new Button();
            button12 = new Button();
            button11 = new Button();
            BtnZPlus = new Button();
            BtnZReduce = new Button();
            label1 = new Label();
            moveamount = new NumericUpDown();
            BtnXReduce = new Button();
            BtnXPlus = new Button();
            BtnYReduce = new Button();
            BtnYPlus = new Button();
            button2 = new Button();
            richTextBox1 = new RichTextBox();
            groupBox3 = new GroupBox();
            listBox1 = new ListBox();
            button10 = new Button();
            button9 = new Button();
            button7 = new Button();
            button6 = new Button();
            label9 = new Label();
            groupBox2 = new GroupBox();
            button8 = new Button();
            label8 = new Label();
            button5 = new Button();
            groupBox1 = new GroupBox();
            button18 = new Button();
            button17 = new Button();
            button4 = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)moveamount).BeginInit();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.BackColor = SystemColors.ControlDark;
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.BackColor = SystemColors.Control;
            splitContainer1.Panel1.Controls.Add(splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.BackColor = SystemColors.Control;
            splitContainer1.Panel2.Controls.Add(richTextBox1);
            splitContainer1.Panel2.Controls.Add(groupBox3);
            splitContainer1.Panel2.Controls.Add(groupBox2);
            splitContainer1.Panel2.Controls.Add(groupBox1);
            splitContainer1.Size = new Size(913, 630);
            splitContainer1.SplitterDistance = 707;
            splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            splitContainer2.BackColor = SystemColors.ControlDark;
            splitContainer2.Dock = DockStyle.Fill;
            splitContainer2.Location = new Point(0, 0);
            splitContainer2.Name = "splitContainer2";
            splitContainer2.Orientation = Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.BackColor = SystemColors.Control;
            splitContainer2.Panel1.Controls.Add(pictureBox1);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.BackColor = SystemColors.Control;
            splitContainer2.Panel2.Controls.Add(move_sander);
            splitContainer2.Panel2.Controls.Add(move_scanner);
            splitContainer2.Panel2.Controls.Add(button16);
            splitContainer2.Panel2.Controls.Add(button15);
            splitContainer2.Panel2.Controls.Add(button13);
            splitContainer2.Panel2.Controls.Add(button14);
            splitContainer2.Panel2.Controls.Add(button12);
            splitContainer2.Panel2.Controls.Add(button11);
            splitContainer2.Panel2.Controls.Add(BtnZPlus);
            splitContainer2.Panel2.Controls.Add(BtnZReduce);
            splitContainer2.Panel2.Controls.Add(label1);
            splitContainer2.Panel2.Controls.Add(moveamount);
            splitContainer2.Panel2.Controls.Add(BtnXReduce);
            splitContainer2.Panel2.Controls.Add(BtnXPlus);
            splitContainer2.Panel2.Controls.Add(BtnYReduce);
            splitContainer2.Panel2.Controls.Add(BtnYPlus);
            splitContainer2.Panel2.Controls.Add(button2);
            splitContainer2.Size = new Size(707, 630);
            splitContainer2.SplitterDistance = 505;
            splitContainer2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Black;
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(707, 505);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // move_sander
            // 
            move_sander.AutoSize = true;
            move_sander.Location = new Point(240, 32);
            move_sander.Name = "move_sander";
            move_sander.Size = new Size(105, 21);
            move_sander.TabIndex = 20;
            move_sander.TabStop = true;
            move_sander.Text = "操作打磨头 X2";
            move_sander.UseVisualStyleBackColor = true;
            // 
            // move_scanner
            // 
            move_scanner.AutoSize = true;
            move_scanner.Location = new Point(240, 5);
            move_scanner.Name = "move_scanner";
            move_scanner.Size = new Size(105, 21);
            move_scanner.TabIndex = 19;
            move_scanner.TabStop = true;
            move_scanner.Text = "操作扫描头 X1";
            move_scanner.UseVisualStyleBackColor = true;
            // 
            // button16
            // 
            button16.BackColor = Color.Green;
            button16.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button16.ForeColor = Color.White;
            button16.Location = new Point(92, 72);
            button16.Name = "button16";
            button16.Size = new Size(251, 46);
            button16.TabIndex = 4;
            button16.Text = "全流程执行";
            button16.UseVisualStyleBackColor = false;
            button16.Click += button16_Click;
            // 
            // button15
            // 
            button15.Location = new Point(11, 66);
            button15.Name = "button15";
            button15.Size = new Size(75, 23);
            button15.TabIndex = 18;
            button15.Text = "Z归零";
            button15.UseVisualStyleBackColor = true;
            button15.Click += button15_Click;
            // 
            // button13
            // 
            button13.Location = new Point(92, 39);
            button13.Name = "button13";
            button13.Size = new Size(75, 23);
            button13.TabIndex = 17;
            button13.Text = "Y2归零";
            button13.UseVisualStyleBackColor = true;
            button13.Click += button13_Click;
            // 
            // button14
            // 
            button14.Location = new Point(92, 12);
            button14.Name = "button14";
            button14.Size = new Size(75, 23);
            button14.TabIndex = 16;
            button14.Text = "Y1归零";
            button14.UseVisualStyleBackColor = true;
            button14.Click += button14_Click;
            // 
            // button12
            // 
            button12.Location = new Point(11, 39);
            button12.Name = "button12";
            button12.Size = new Size(75, 23);
            button12.TabIndex = 15;
            button12.Text = "X2归零";
            button12.UseVisualStyleBackColor = true;
            button12.Click += button12_Click;
            // 
            // button11
            // 
            button11.Location = new Point(11, 12);
            button11.Name = "button11";
            button11.Size = new Size(75, 23);
            button11.TabIndex = 14;
            button11.Text = "X1归零";
            button11.UseVisualStyleBackColor = true;
            button11.Click += button11_Click;
            // 
            // BtnZPlus
            // 
            BtnZPlus.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            BtnZPlus.Location = new Point(349, 3);
            BtnZPlus.Name = "BtnZPlus";
            BtnZPlus.Size = new Size(47, 23);
            BtnZPlus.TabIndex = 11;
            BtnZPlus.Text = "Z+";
            BtnZPlus.UseVisualStyleBackColor = true;
            BtnZPlus.Click += BtnZPlus_Click;
            // 
            // BtnZReduce
            // 
            BtnZReduce.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            BtnZReduce.Location = new Point(349, 95);
            BtnZReduce.Name = "BtnZReduce";
            BtnZReduce.Size = new Size(47, 23);
            BtnZReduce.TabIndex = 10;
            BtnZReduce.Text = "Z-";
            BtnZReduce.UseVisualStyleBackColor = true;
            BtnZReduce.Click += BtnZReduce_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(476, 72);
            label1.Name = "label1";
            label1.Size = new Size(30, 17);
            label1.TabIndex = 6;
            label1.Text = "mm";
            // 
            // moveamount
            // 
            moveamount.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            moveamount.Location = new Point(453, 41);
            moveamount.Name = "moveamount";
            moveamount.Size = new Size(53, 23);
            moveamount.TabIndex = 5;
            moveamount.Value = new decimal(new int[] { 100, 0, 0, 0 });
            // 
            // BtnXReduce
            // 
            BtnXReduce.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            BtnXReduce.Location = new Point(512, 32);
            BtnXReduce.Name = "BtnXReduce";
            BtnXReduce.Size = new Size(47, 57);
            BtnXReduce.TabIndex = 4;
            BtnXReduce.Text = "X- ↓";
            BtnXReduce.UseVisualStyleBackColor = true;
            BtnXReduce.Click += BtnXReduce_Click;
            // 
            // BtnXPlus
            // 
            BtnXPlus.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            BtnXPlus.Location = new Point(400, 32);
            BtnXPlus.Name = "BtnXPlus";
            BtnXPlus.Size = new Size(47, 57);
            BtnXPlus.TabIndex = 3;
            BtnXPlus.Text = "X+ ↑";
            BtnXPlus.UseVisualStyleBackColor = true;
            BtnXPlus.Click += BtnXPlus_Click;
            // 
            // BtnYReduce
            // 
            BtnYReduce.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            BtnYReduce.Location = new Point(400, 95);
            BtnYReduce.Name = "BtnYReduce";
            BtnYReduce.Size = new Size(159, 23);
            BtnYReduce.TabIndex = 2;
            BtnYReduce.Text = "Y-  ←";
            BtnYReduce.UseVisualStyleBackColor = true;
            BtnYReduce.Click += BtnYReduce_Click;
            // 
            // BtnYPlus
            // 
            BtnYPlus.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnYPlus.Location = new Point(400, 3);
            BtnYPlus.Name = "BtnYPlus";
            BtnYPlus.Size = new Size(159, 23);
            BtnYPlus.TabIndex = 1;
            BtnYPlus.Text = "Y+  →";
            BtnYPlus.UseVisualStyleBackColor = true;
            BtnYPlus.Click += BtnYPlus_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            button2.BackColor = Color.FromArgb(192, 0, 0);
            button2.Font = new Font("Microsoft YaHei UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(565, 3);
            button2.Name = "button2";
            button2.Size = new Size(139, 115);
            button2.TabIndex = 0;
            button2.Text = "电机停止\r\nStop";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            richTextBox1.Location = new Point(3, 492);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(195, 135);
            richTextBox1.TabIndex = 3;
            richTextBox1.Text = "";
            // 
            // groupBox3
            // 
            groupBox3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox3.Controls.Add(listBox1);
            groupBox3.Controls.Add(button10);
            groupBox3.Controls.Add(button9);
            groupBox3.Controls.Add(button7);
            groupBox3.Controls.Add(button6);
            groupBox3.Controls.Add(label9);
            groupBox3.Location = new Point(3, 178);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(196, 308);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "3. 打磨修复";
            // 
            // listBox1
            // 
            listBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 17;
            listBox1.Location = new Point(9, 39);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(179, 208);
            listBox1.TabIndex = 24;
            // 
            // button10
            // 
            button10.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button10.Location = new Point(138, 278);
            button10.Name = "button10";
            button10.Size = new Size(49, 23);
            button10.TabIndex = 23;
            button10.Text = "停止";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click;
            // 
            // button9
            // 
            button9.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button9.Location = new Point(87, 278);
            button9.Name = "button9";
            button9.Size = new Size(45, 23);
            button9.TabIndex = 22;
            button9.Text = "暂停";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // button7
            // 
            button7.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button7.Location = new Point(8, 278);
            button7.Name = "button7";
            button7.Size = new Size(73, 23);
            button7.TabIndex = 21;
            button7.Text = "跳过当前";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button6
            // 
            button6.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button6.Location = new Point(8, 254);
            button6.Name = "button6";
            button6.Size = new Size(179, 23);
            button6.TabIndex = 20;
            button6.Text = "开始打磨";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = Color.FromArgb(192, 0, 0);
            label9.Location = new Point(9, 19);
            label9.Name = "label9";
            label9.Size = new Size(104, 17);
            label9.TabIndex = 19;
            label9.Text = "没有加载检测结果";
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.Controls.Add(button8);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(button5);
            groupBox2.Location = new Point(3, 98);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(196, 74);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "2. 缺陷检测";
            // 
            // button8
            // 
            button8.Location = new Point(87, 39);
            button8.Name = "button8";
            button8.Size = new Size(100, 23);
            button8.TabIndex = 3;
            button8.Text = "导出检测结果";
            button8.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.FromArgb(192, 0, 0);
            label8.Location = new Point(8, 19);
            label8.Name = "label8";
            label8.Size = new Size(104, 17);
            label8.TabIndex = 2;
            label8.Text = "没有加载扫描结果";
            // 
            // button5
            // 
            button5.Location = new Point(6, 39);
            button5.Name = "button5";
            button5.Size = new Size(75, 23);
            button5.TabIndex = 1;
            button5.Text = "开始检测";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(button18);
            groupBox1.Controls.Add(button17);
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(button1);
            groupBox1.Location = new Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(196, 89);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "1. 表面扫描";
            // 
            // button18
            // 
            button18.Location = new Point(87, 51);
            button18.Name = "button18";
            button18.Size = new Size(75, 23);
            button18.TabIndex = 3;
            button18.Text = "停止";
            button18.UseVisualStyleBackColor = true;
            button18.Click += button18_Click;
            // 
            // button17
            // 
            button17.Location = new Point(6, 51);
            button17.Name = "button17";
            button17.Size = new Size(75, 23);
            button17.TabIndex = 2;
            button17.Text = "暂停";
            button17.UseVisualStyleBackColor = true;
            button17.Click += button17_Click;
            // 
            // button4
            // 
            button4.Location = new Point(87, 22);
            button4.Name = "button4";
            button4.Size = new Size(100, 23);
            button4.TabIndex = 1;
            button4.Text = "导出扫描结果";
            button4.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(6, 22);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "开始扫描";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(913, 630);
            Controls.Add(splitContainer1);
            Name = "Form1";
            Text = "GSSARS - 操作面板";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel2.ResumeLayout(false);
            splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)moveamount).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private SplitContainer splitContainer2;
        private PictureBox pictureBox1;
        private GroupBox groupBox3;
        private GroupBox groupBox2;
        private GroupBox groupBox1;
        private RichTextBox richTextBox1;
        private Button button2;
        private Button button1;
        private Button BtnYReduce;
        private Button BtnYPlus;
        private Button BtnXReduce;
        private Button BtnXPlus;
        private Label label1;
        private NumericUpDown moveamount;
        private Button BtnZReduce;
        private Button BtnZPlus;
        private Button button4;
        private Button button5;
        private Label label8;
        private Label label9;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button10;
        private Button button9;
        private ListBox listBox1;
        private Button button12;
        private Button button11;
        private Button button13;
        private Button button14;
        private Button button15;
        private Button button16;
        private Button button18;
        private Button button17;
        private RadioButton move_sander;
        private RadioButton move_scanner;
    }
}