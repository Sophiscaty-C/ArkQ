
namespace ArkQ
{
    partial class Control
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Control));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.增加干员 = new System.Windows.Forms.ToolStripMenuItem();
            this.帕拉斯 = new System.Windows.Forms.ToolStripMenuItem();
            this.讯使 = new System.Windows.Forms.ToolStripMenuItem();
            this.Opacity0 = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Opacity100 = new System.Windows.Forms.ToolStripMenuItem();
            this.退出2 = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.增加干员,
            this.Opacity0,
            this.退出ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(139, 76);
            // 
            // 增加干员
            // 
            this.增加干员.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.帕拉斯,
            this.讯使});
            this.增加干员.Name = "增加干员";
            this.增加干员.Size = new System.Drawing.Size(138, 24);
            this.增加干员.Text = "增加干员";
            // 
            // 帕拉斯
            // 
            this.帕拉斯.Name = "帕拉斯";
            this.帕拉斯.Size = new System.Drawing.Size(137, 26);
            this.帕拉斯.Text = "帕拉斯";
            this.帕拉斯.Click += new System.EventHandler(this.帕拉斯_Click);
            // 
            // 讯使
            // 
            this.讯使.Name = "讯使";
            this.讯使.Size = new System.Drawing.Size(137, 26);
            this.讯使.Text = "讯使";
            this.讯使.Click += new System.EventHandler(this.讯使_Click);
            // 
            // Opacity0
            // 
            this.Opacity0.Name = "Opacity0";
            this.Opacity0.Size = new System.Drawing.Size(138, 24);
            this.Opacity0.Text = "隐藏";
            this.Opacity0.Click += new System.EventHandler(this.隐藏_Click);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(138, 24);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip2;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "ArkQ";
            this.notifyIcon1.Visible = true;
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Opacity100,
            this.退出2});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(109, 52);
            // 
            // Opacity100
            // 
            this.Opacity100.Name = "Opacity100";
            this.Opacity100.Size = new System.Drawing.Size(108, 24);
            this.Opacity100.Text = "显示";
            this.Opacity100.Click += new System.EventHandler(this.显示_Click_1);
            // 
            // 退出2
            // 
            this.退出2.Name = "退出2";
            this.退出2.Size = new System.Drawing.Size(108, 24);
            this.退出2.Text = "退出";
            this.退出2.Click += new System.EventHandler(this.退出2_Click);
            // 
            // Control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::ArkQ.Properties.Resources.logo_1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(250, 125);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Control";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Control";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.White;
            this.contextMenuStrip1.ResumeLayout(false);
            this.contextMenuStrip2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 增加干员;
        private System.Windows.Forms.ToolStripMenuItem 帕拉斯;
        private System.Windows.Forms.ToolStripMenuItem 讯使;
        private System.Windows.Forms.ToolStripMenuItem Opacity0;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem Opacity100;
        private System.Windows.Forms.ToolStripMenuItem 退出2;
    }
}