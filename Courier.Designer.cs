
namespace ArkQ
{
    partial class Courier
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.显示方式 = new System.Windows.Forms.ToolStripMenuItem();
            this.始终保持最前 = new System.Windows.Forms.ToolStripMenuItem();
            this.不需要保持最前 = new System.Windows.Forms.ToolStripMenuItem();
            this.透明度 = new System.Windows.Forms.ToolStripMenuItem();
            this.Opacity100 = new System.Windows.Forms.ToolStripMenuItem();
            this.Opacity90 = new System.Windows.Forms.ToolStripMenuItem();
            this.Opacity75 = new System.Windows.Forms.ToolStripMenuItem();
            this.Opacity60 = new System.Windows.Forms.ToolStripMenuItem();
            this.Opacity45 = new System.Windows.Forms.ToolStripMenuItem();
            this.Opacity30 = new System.Windows.Forms.ToolStripMenuItem();
            this.Opacity15 = new System.Windows.Forms.ToolStripMenuItem();
            this.换装 = new System.Windows.Forms.ToolStripMenuItem();
            this.Original = new System.Windows.Forms.ToolStripMenuItem();
            this.新航线 = new System.Windows.Forms.ToolStripMenuItem();
            this.无言狂响 = new System.Windows.Forms.ToolStripMenuItem();
            this.Opacity0 = new System.Windows.Forms.ToolStripMenuItem();
            this.罚站吗 = new System.Windows.Forms.ToolStripMenuItem();
            this.罚站 = new System.Windows.Forms.ToolStripMenuItem();
            this.不要罚站了 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(399, 287);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // timer4
            // 
            this.timer4.Tick += new System.EventHandler(this.timer4_Tick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.显示方式,
            this.透明度,
            this.换装,
            this.Opacity0,
            this.罚站吗});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(139, 124);
            // 
            // 显示方式
            // 
            this.显示方式.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.始终保持最前,
            this.不需要保持最前});
            this.显示方式.Name = "显示方式";
            this.显示方式.Size = new System.Drawing.Size(138, 24);
            this.显示方式.Text = "显示方式";
            // 
            // 始终保持最前
            // 
            this.始终保持最前.Image = global::ArkQ.Properties.Resources.dot;
            this.始终保持最前.Name = "始终保持最前";
            this.始终保持最前.Size = new System.Drawing.Size(197, 26);
            this.始终保持最前.Text = "始终保持最前";
            this.始终保持最前.Click += new System.EventHandler(this.始终保持最前_Click);
            // 
            // 不需要保持最前
            // 
            this.不需要保持最前.Name = "不需要保持最前";
            this.不需要保持最前.Size = new System.Drawing.Size(197, 26);
            this.不需要保持最前.Text = "不需要保持最前";
            this.不需要保持最前.Click += new System.EventHandler(this.不需要保持最前_Click);
            // 
            // 透明度
            // 
            this.透明度.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Opacity100,
            this.Opacity90,
            this.Opacity75,
            this.Opacity60,
            this.Opacity45,
            this.Opacity30,
            this.Opacity15});
            this.透明度.Name = "透明度";
            this.透明度.Size = new System.Drawing.Size(138, 24);
            this.透明度.Text = "透明度";
            // 
            // Opacity100
            // 
            this.Opacity100.Image = global::ArkQ.Properties.Resources.dot;
            this.Opacity100.Name = "Opacity100";
            this.Opacity100.Size = new System.Drawing.Size(137, 26);
            this.Opacity100.Text = "不透明";
            this.Opacity100.Click += new System.EventHandler(this.Opacity100_Click);
            // 
            // Opacity90
            // 
            this.Opacity90.Name = "Opacity90";
            this.Opacity90.Size = new System.Drawing.Size(137, 26);
            this.Opacity90.Text = "90%";
            this.Opacity90.Click += new System.EventHandler(this.Opacity90_Click);
            // 
            // Opacity75
            // 
            this.Opacity75.Name = "Opacity75";
            this.Opacity75.Size = new System.Drawing.Size(137, 26);
            this.Opacity75.Text = "75%";
            this.Opacity75.Click += new System.EventHandler(this.Opacity75_Click);
            // 
            // Opacity60
            // 
            this.Opacity60.Name = "Opacity60";
            this.Opacity60.Size = new System.Drawing.Size(137, 26);
            this.Opacity60.Text = "60%";
            this.Opacity60.Click += new System.EventHandler(this.Opacity60_Click);
            // 
            // Opacity45
            // 
            this.Opacity45.Name = "Opacity45";
            this.Opacity45.Size = new System.Drawing.Size(137, 26);
            this.Opacity45.Text = "45%";
            this.Opacity45.Click += new System.EventHandler(this.Opacity45_Click);
            // 
            // Opacity30
            // 
            this.Opacity30.Name = "Opacity30";
            this.Opacity30.Size = new System.Drawing.Size(137, 26);
            this.Opacity30.Text = "30%";
            this.Opacity30.Click += new System.EventHandler(this.Opacity30_Click);
            // 
            // Opacity15
            // 
            this.Opacity15.Name = "Opacity15";
            this.Opacity15.Size = new System.Drawing.Size(137, 26);
            this.Opacity15.Text = "15%";
            this.Opacity15.Click += new System.EventHandler(this.Opacity15_Click);
            // 
            // 换装
            // 
            this.换装.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Original,
            this.新航线,
            this.无言狂响});
            this.换装.Name = "换装";
            this.换装.Size = new System.Drawing.Size(138, 24);
            this.换装.Text = "换装";
            // 
            // Original
            // 
            this.Original.Image = global::ArkQ.Properties.Resources.dot;
            this.Original.Name = "Original";
            this.Original.Size = new System.Drawing.Size(152, 26);
            this.Original.Text = "Original";
            this.Original.Click += new System.EventHandler(this.Original_Click);
            // 
            // 新航线
            // 
            this.新航线.Name = "新航线";
            this.新航线.Size = new System.Drawing.Size(152, 26);
            this.新航线.Text = "新航线";
            this.新航线.Click += new System.EventHandler(this.新航线_Click);
            // 
            // 无言狂响
            // 
            this.无言狂响.Name = "无言狂响";
            this.无言狂响.Size = new System.Drawing.Size(152, 26);
            this.无言狂响.Text = "无言狂响";
            this.无言狂响.Click += new System.EventHandler(this.无言狂响_Click);
            // 
            // Opacity0
            // 
            this.Opacity0.Name = "Opacity0";
            this.Opacity0.Size = new System.Drawing.Size(138, 24);
            this.Opacity0.Text = "隐藏干员";
            this.Opacity0.Click += new System.EventHandler(this.Opacity0_Click);
            // 
            // 罚站吗
            // 
            this.罚站吗.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.罚站,
            this.不要罚站了});
            this.罚站吗.Name = "罚站吗";
            this.罚站吗.Size = new System.Drawing.Size(138, 24);
            this.罚站吗.Text = "罚站吗？";
            // 
            // 罚站
            // 
            this.罚站.Name = "罚站";
            this.罚站.Size = new System.Drawing.Size(167, 26);
            this.罚站.Text = "罚站！";
            this.罚站.Click += new System.EventHandler(this.罚站_Click);
            // 
            // 不要罚站了
            // 
            this.不要罚站了.Name = "不要罚站了";
            this.不要罚站了.Size = new System.Drawing.Size(167, 26);
            this.不要罚站了.Text = "不要罚站了";
            this.不要罚站了.Click += new System.EventHandler(this.不要罚站了_Click);
            // 
            // Courier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(405, 300);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Courier";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Courier";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.White;
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Courier_MouseDown);
            this.MouseEnter += new System.EventHandler(this.Courier_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.Courier_MouseLeave);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Courier_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Courier_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Timer timer4;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 显示方式;
        private System.Windows.Forms.ToolStripMenuItem 始终保持最前;
        private System.Windows.Forms.ToolStripMenuItem 不需要保持最前;
        private System.Windows.Forms.ToolStripMenuItem 透明度;
        private System.Windows.Forms.ToolStripMenuItem Opacity100;
        private System.Windows.Forms.ToolStripMenuItem Opacity90;
        private System.Windows.Forms.ToolStripMenuItem Opacity75;
        private System.Windows.Forms.ToolStripMenuItem Opacity60;
        private System.Windows.Forms.ToolStripMenuItem Opacity45;
        private System.Windows.Forms.ToolStripMenuItem Opacity30;
        private System.Windows.Forms.ToolStripMenuItem Opacity15;
        private System.Windows.Forms.ToolStripMenuItem 换装;
        private System.Windows.Forms.ToolStripMenuItem Original;
        private System.Windows.Forms.ToolStripMenuItem 新航线;
        private System.Windows.Forms.ToolStripMenuItem 无言狂响;
        private System.Windows.Forms.ToolStripMenuItem Opacity0;
        private System.Windows.Forms.ToolStripMenuItem 罚站吗;
        private System.Windows.Forms.ToolStripMenuItem 罚站;
        private System.Windows.Forms.ToolStripMenuItem 不要罚站了;
    }
}