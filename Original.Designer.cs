using System;
using System.Drawing;

namespace ArkQ
{
    partial class Original
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Original));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.显示方式ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.始终保持最前ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.不需要保持最前ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.透明度ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Opacity100 = new System.Windows.Forms.ToolStripMenuItem();
            this.Opacity90 = new System.Windows.Forms.ToolStripMenuItem();
            this.Opacity75 = new System.Windows.Forms.ToolStripMenuItem();
            this.Opacity60 = new System.Windows.Forms.ToolStripMenuItem();
            this.Opacity45 = new System.Windows.Forms.ToolStripMenuItem();
            this.Opacity30 = new System.Windows.Forms.ToolStripMenuItem();
            this.Opacity15 = new System.Windows.Forms.ToolStripMenuItem();
            this.换装ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.originalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.增加干员ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.讯使ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帕拉斯ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.隐藏干员ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.罚站ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MyNotifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.显示方式ToolStripMenuItem,
            this.透明度ToolStripMenuItem,
            this.换装ToolStripMenuItem,
            this.增加干员ToolStripMenuItem,
            this.隐藏干员ToolStripMenuItem,
            this.罚站ToolStripMenuItem,
            this.退出ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(139, 172);
            // 
            // 显示方式ToolStripMenuItem
            // 
            this.显示方式ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.始终保持最前ToolStripMenuItem,
            this.不需要保持最前ToolStripMenuItem});
            this.显示方式ToolStripMenuItem.Name = "显示方式ToolStripMenuItem";
            this.显示方式ToolStripMenuItem.Size = new System.Drawing.Size(138, 24);
            this.显示方式ToolStripMenuItem.Text = "显示方式";
            // 
            // 始终保持最前ToolStripMenuItem
            // 
            this.始终保持最前ToolStripMenuItem.Image = global::ArkQ.Properties.Resources.dot;
            this.始终保持最前ToolStripMenuItem.Name = "始终保持最前ToolStripMenuItem";
            this.始终保持最前ToolStripMenuItem.Size = new System.Drawing.Size(197, 26);
            this.始终保持最前ToolStripMenuItem.Text = "始终保持最前";
            this.始终保持最前ToolStripMenuItem.Click += new System.EventHandler(this.始终保持最前ToolStripMenuItem_Click);
            // 
            // 不需要保持最前ToolStripMenuItem
            // 
            this.不需要保持最前ToolStripMenuItem.Name = "不需要保持最前ToolStripMenuItem";
            this.不需要保持最前ToolStripMenuItem.Size = new System.Drawing.Size(197, 26);
            this.不需要保持最前ToolStripMenuItem.Text = "不需要保持最前";
            this.不需要保持最前ToolStripMenuItem.Click += new System.EventHandler(this.不需要保持最前ToolStripMenuItem_Click);
            // 
            // 透明度ToolStripMenuItem
            // 
            this.透明度ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Opacity100,
            this.Opacity90,
            this.Opacity75,
            this.Opacity60,
            this.Opacity45,
            this.Opacity30,
            this.Opacity15});
            this.透明度ToolStripMenuItem.Name = "透明度ToolStripMenuItem";
            this.透明度ToolStripMenuItem.Size = new System.Drawing.Size(138, 24);
            this.透明度ToolStripMenuItem.Text = "透明度";
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
            // 换装ToolStripMenuItem
            // 
            this.换装ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.originalToolStripMenuItem});
            this.换装ToolStripMenuItem.Name = "换装ToolStripMenuItem";
            this.换装ToolStripMenuItem.Size = new System.Drawing.Size(138, 24);
            this.换装ToolStripMenuItem.Text = "换装";
            // 
            // originalToolStripMenuItem
            // 
            this.originalToolStripMenuItem.Name = "originalToolStripMenuItem";
            this.originalToolStripMenuItem.Size = new System.Drawing.Size(149, 26);
            this.originalToolStripMenuItem.Text = "Original";
            // 
            // 增加干员ToolStripMenuItem
            // 
            this.增加干员ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.讯使ToolStripMenuItem,
            this.帕拉斯ToolStripMenuItem});
            this.增加干员ToolStripMenuItem.Name = "增加干员ToolStripMenuItem";
            this.增加干员ToolStripMenuItem.Size = new System.Drawing.Size(138, 24);
            this.增加干员ToolStripMenuItem.Text = "增加干员";
            // 
            // 讯使ToolStripMenuItem
            // 
            this.讯使ToolStripMenuItem.Name = "讯使ToolStripMenuItem";
            this.讯使ToolStripMenuItem.Size = new System.Drawing.Size(137, 26);
            this.讯使ToolStripMenuItem.Text = "讯使";
            // 
            // 帕拉斯ToolStripMenuItem
            // 
            this.帕拉斯ToolStripMenuItem.Name = "帕拉斯ToolStripMenuItem";
            this.帕拉斯ToolStripMenuItem.Size = new System.Drawing.Size(137, 26);
            this.帕拉斯ToolStripMenuItem.Text = "帕拉斯";
            this.帕拉斯ToolStripMenuItem.Click += new System.EventHandler(this.帕拉斯ToolStripMenuItem_Click);
            // 
            // 隐藏干员ToolStripMenuItem
            // 
            this.隐藏干员ToolStripMenuItem.Name = "隐藏干员ToolStripMenuItem";
            this.隐藏干员ToolStripMenuItem.Size = new System.Drawing.Size(138, 24);
            this.隐藏干员ToolStripMenuItem.Text = "隐藏干员";
            // 
            // 罚站ToolStripMenuItem
            // 
            this.罚站ToolStripMenuItem.Name = "罚站ToolStripMenuItem";
            this.罚站ToolStripMenuItem.Size = new System.Drawing.Size(138, 24);
            this.罚站ToolStripMenuItem.Text = "罚站";
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(138, 24);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
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
            // Original
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
            this.Name = "Original";
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
        private System.Windows.Forms.ToolStripMenuItem 显示方式ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 透明度ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 换装ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 增加干员ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 隐藏干员ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 罚站ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 始终保持最前ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 不需要保持最前ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Opacity100;
        private System.Windows.Forms.ToolStripMenuItem Opacity90;
        private System.Windows.Forms.ToolStripMenuItem Opacity75;
        private System.Windows.Forms.ToolStripMenuItem Opacity60;
        private System.Windows.Forms.ToolStripMenuItem Opacity45;
        private System.Windows.Forms.ToolStripMenuItem Opacity30;
        private System.Windows.Forms.ToolStripMenuItem Opacity15;
        private System.Windows.Forms.ToolStripMenuItem originalToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon MyNotifyIcon;
        private System.Windows.Forms.ToolStripMenuItem 讯使ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帕拉斯ToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
    }
}

