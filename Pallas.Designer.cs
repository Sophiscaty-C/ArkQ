using System;
using System.Drawing;

namespace ArkQ
{
    partial class Pallas
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pallas));
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
            this.传承 = new System.Windows.Forms.ToolStripMenuItem();
            this.增加干员 = new System.Windows.Forms.ToolStripMenuItem();
            this.讯使 = new System.Windows.Forms.ToolStripMenuItem();
            this.帕拉斯 = new System.Windows.Forms.ToolStripMenuItem();
            this.Opacity0 = new System.Windows.Forms.ToolStripMenuItem();
            this.罚站 = new System.Windows.Forms.ToolStripMenuItem();
            this.退出 = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MyNotifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.不要罚站了 = new System.Windows.Forms.ToolStripMenuItem();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.显示方式,
            this.透明度,
            this.换装,
            this.增加干员,
            this.Opacity0,
            this.罚站,
            this.退出});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(139, 172);
            // 
            // 显示方式
            // 
            this.显示方式.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.始终保持最前,
            this.不需要保持最前});
            this.显示方式.Name = "显示方式";
            this.显示方式.Size = new System.Drawing.Size(210, 24);
            this.显示方式.Text = "显示方式";
            // 
            // 始终保持最前
            // 
            this.始终保持最前.Image = global::ArkQ.Properties.Resources.dot;
            this.始终保持最前.Name = "始终保持最前";
            this.始终保持最前.Size = new System.Drawing.Size(224, 26);
            this.始终保持最前.Text = "始终保持最前";
            this.始终保持最前.Click += new System.EventHandler(this.始终保持最前ToolStripMenuItem_Click);
            // 
            // 不需要保持最前
            // 
            this.不需要保持最前.Name = "不需要保持最前";
            this.不需要保持最前.Size = new System.Drawing.Size(224, 26);
            this.不需要保持最前.Text = "不需要保持最前";
            this.不需要保持最前.Click += new System.EventHandler(this.不需要保持最前ToolStripMenuItem_Click);
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
            this.透明度.Size = new System.Drawing.Size(210, 24);
            this.透明度.Text = "透明度";
            // 
            // Opacity100
            // 
            this.Opacity100.Image = global::ArkQ.Properties.Resources.dot;
            this.Opacity100.Name = "Opacity100";
            this.Opacity100.Size = new System.Drawing.Size(224, 26);
            this.Opacity100.Text = "不透明";
            this.Opacity100.Click += new System.EventHandler(this.Opacity100_Click);
            // 
            // Opacity90
            // 
            this.Opacity90.Name = "Opacity90";
            this.Opacity90.Size = new System.Drawing.Size(224, 26);
            this.Opacity90.Text = "90%";
            this.Opacity90.Click += new System.EventHandler(this.Opacity90_Click);
            // 
            // Opacity75
            // 
            this.Opacity75.Name = "Opacity75";
            this.Opacity75.Size = new System.Drawing.Size(224, 26);
            this.Opacity75.Text = "75%";
            this.Opacity75.Click += new System.EventHandler(this.Opacity75_Click);
            // 
            // Opacity60
            // 
            this.Opacity60.Name = "Opacity60";
            this.Opacity60.Size = new System.Drawing.Size(224, 26);
            this.Opacity60.Text = "60%";
            this.Opacity60.Click += new System.EventHandler(this.Opacity60_Click);
            // 
            // Opacity45
            // 
            this.Opacity45.Name = "Opacity45";
            this.Opacity45.Size = new System.Drawing.Size(224, 26);
            this.Opacity45.Text = "45%";
            this.Opacity45.Click += new System.EventHandler(this.Opacity45_Click);
            // 
            // Opacity30
            // 
            this.Opacity30.Name = "Opacity30";
            this.Opacity30.Size = new System.Drawing.Size(224, 26);
            this.Opacity30.Text = "30%";
            this.Opacity30.Click += new System.EventHandler(this.Opacity30_Click);
            // 
            // Opacity15
            // 
            this.Opacity15.Name = "Opacity15";
            this.Opacity15.Size = new System.Drawing.Size(224, 26);
            this.Opacity15.Text = "15%";
            this.Opacity15.Click += new System.EventHandler(this.Opacity15_Click);
            // 
            // 换装
            // 
            this.换装.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Original,
            this.传承});
            this.换装.Name = "换装";
            this.换装.Size = new System.Drawing.Size(210, 24);
            this.换装.Text = "换装";
            // 
            // Original
            // 
            this.Original.Image = global::ArkQ.Properties.Resources.dot;
            this.Original.Name = "Original";
            this.Original.Size = new System.Drawing.Size(224, 26);
            this.Original.Text = "Original";
            this.Original.Click += new System.EventHandler(this.originalToolStripMenuItem_Click);
            // 
            // 传承
            // 
            this.传承.Name = "传承";
            this.传承.Size = new System.Drawing.Size(224, 26);
            this.传承.Text = "传承";
            this.传承.Click += new System.EventHandler(this.传承ToolStripMenuItem_Click);
            // 
            // 增加干员
            // 
            this.增加干员.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.帕拉斯,
            this.讯使});
            this.增加干员.Name = "增加干员";
            this.增加干员.Size = new System.Drawing.Size(210, 24);
            this.增加干员.Text = "增加干员";
            // 
            // 讯使
            // 
            this.讯使.Name = "讯使";
            this.讯使.Size = new System.Drawing.Size(224, 26);
            this.讯使.Text = "讯使";
            this.讯使.Click += new System.EventHandler(this.讯使ToolStripMenuItem_Click);
            // 
            // 帕拉斯
            // 
            this.帕拉斯.Image = global::ArkQ.Properties.Resources.dot;
            this.帕拉斯.Name = "帕拉斯";
            this.帕拉斯.Size = new System.Drawing.Size(224, 26);
            this.帕拉斯.Text = "帕拉斯";
            this.帕拉斯.Click += new System.EventHandler(this.帕拉斯ToolStripMenuItem_Click);
            // 
            // Opacity0
            // 
            this.Opacity0.Name = "Opacity0";
            this.Opacity0.Size = new System.Drawing.Size(210, 24);
            this.Opacity0.Text = "隐藏干员";
            this.Opacity0.Click += new System.EventHandler(this.隐藏干员ToolStripMenuItem_Click);
            // 
            // 罚站
            // 
            this.罚站.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.不要罚站了});
            this.罚站.Name = "罚站";
            this.罚站.Size = new System.Drawing.Size(210, 24);
            this.罚站.Text = "罚站";
            this.罚站.Click += new System.EventHandler(this.罚站ToolStripMenuItem_Click);
            // 
            // 退出
            // 
            this.退出.Name = "退出";
            this.退出.Size = new System.Drawing.Size(210, 24);
            this.退出.Text = "退出";
            this.退出.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.ImageLocation = "";
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(399, 287);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Original_MouseDown);
            this.pictureBox1.MouseEnter += new System.EventHandler(this.Original_MouseEnter);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Original_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Original_MouseUp);
            // 
            // MyNotifyIcon
            // 
            this.MyNotifyIcon.ContextMenuStrip = this.contextMenuStrip1;
            this.MyNotifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("MyNotifyIcon.Icon")));
            this.MyNotifyIcon.Text = "notifyIcon1";
            this.MyNotifyIcon.Visible = true;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // 不要罚站了
            // 
            this.不要罚站了.Name = "不要罚站了";
            this.不要罚站了.Size = new System.Drawing.Size(224, 26);
            this.不要罚站了.Text = "不要罚站了";
            this.不要罚站了.Click += new System.EventHandler(this.不要罚站了ToolStripMenuItem_Click);
            // 
            // timer3
            // 
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // timer4
            // 
            this.timer4.Tick += new System.EventHandler(this.timer4_Tick);
            // 
            // Pallas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(423, 303);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Pallas";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.White;
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Original_MouseDown);
            this.MouseEnter += new System.EventHandler(this.Original_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.Original_MouseLeave);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Original_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Original_MouseUp);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 显示方式;
        private System.Windows.Forms.ToolStripMenuItem 透明度;
        private System.Windows.Forms.ToolStripMenuItem 换装;
        private System.Windows.Forms.ToolStripMenuItem 增加干员;
        private System.Windows.Forms.ToolStripMenuItem Opacity0;
        private System.Windows.Forms.ToolStripMenuItem 罚站;
        private System.Windows.Forms.ToolStripMenuItem 始终保持最前;
        private System.Windows.Forms.ToolStripMenuItem 不需要保持最前;
        private System.Windows.Forms.ToolStripMenuItem Opacity100;
        private System.Windows.Forms.ToolStripMenuItem Opacity90;
        private System.Windows.Forms.ToolStripMenuItem Opacity75;
        private System.Windows.Forms.ToolStripMenuItem Opacity60;
        private System.Windows.Forms.ToolStripMenuItem Opacity45;
        private System.Windows.Forms.ToolStripMenuItem Opacity30;
        private System.Windows.Forms.ToolStripMenuItem Opacity15;
        private System.Windows.Forms.ToolStripMenuItem Original;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem 退出;
        private System.Windows.Forms.NotifyIcon MyNotifyIcon;
        private System.Windows.Forms.ToolStripMenuItem 讯使;
        private System.Windows.Forms.ToolStripMenuItem 帕拉斯;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.ToolStripMenuItem 传承;
        private System.Windows.Forms.ToolStripMenuItem 不要罚站了;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Timer timer4;
    }
}

