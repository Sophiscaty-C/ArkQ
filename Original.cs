using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace ArkQ
{
    public partial class Original : Form
    {
        private AppConfig config = new AppConfig();
        private ToolStripMenuItem OpacityItem = null;

        private Point mouseOffset;
        private bool isMouseDown = false;
        public bool isMouseEnter = false;
        public string BASIC_PATH = "D:\\Git\\repository\\ArkQ\\Properties\\Resources\\";
        public string character = "Pallas";   //角色
        public string act = "Rela";           //动作
        public string skin = "Original";      //皮肤
        public string pic_path;               //对应图片路径
        public Random rand = new Random();

        public Original()
        {
            InitializeComponent();
            OpacityItem = Opacity100;
            setOpacity(Opacity100, 100);
            pic_path = BASIC_PATH + character + "\\"+skin+"\\"+ act + ".gif";
            this.pictureBox1.Image = Image.FromFile(pic_path);
            timer2.Interval = rand.Next() % 5 * 1000 + 11000;  // 11~15秒一个动作
            timer2.Start();
        }

        //显示方式
        #region 显示方式
        private void 始终保持最前ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            始终保持最前ToolStripMenuItem.Image= new Bitmap(Properties.Resources.dot);
            不需要保持最前ToolStripMenuItem.Image = null;
            this.TopMost = true;
        }

        private void 不需要保持最前ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            始终保持最前ToolStripMenuItem.Image = null;
            不需要保持最前ToolStripMenuItem.Image = new Bitmap(Properties.Resources.dot);
            this.TopMost = false;
        }
        #endregion

        //窗体透明度
        #region 窗体透明度
        private void setOpacity(ToolStripMenuItem opacityItem, int opacity)
        {
            OpacityItem.Image = null;
            opacityItem.Image = new Bitmap(Properties.Resources.dot);
            this.Opacity = opacity * 0.01;
            OpacityItem = opacityItem;
        }

        private void Opacity100_Click(object sender, EventArgs e)
        {
            setOpacity(Opacity100, 100);
        }

        private void Opacity90_Click(object sender, EventArgs e)
        {
            setOpacity(Opacity90, 90);
        }

        private void Opacity75_Click(object sender, EventArgs e)
        {
            setOpacity(Opacity75, 75);
        }

        private void Opacity60_Click(object sender, EventArgs e)
        {
            setOpacity(Opacity60, 60);
        }

        private void Opacity45_Click(object sender, EventArgs e)
        {
            setOpacity(Opacity45, 45);
        }

        private void Opacity30_Click(object sender, EventArgs e)
        {
            setOpacity(Opacity30, 30);
        }

        private void Opacity15_Click(object sender, EventArgs e)
        {
            setOpacity(Opacity15, 15);
        }
        #endregion

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            config.saveInfos(this.Location.X, this.Location.Y, (int)(this.Opacity * 100), this.TopMost);
            MyNotifyIcon.Dispose();
            Application.Exit();
        }

        private void Original_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isMouseDown = true;
                mouseOffset = new Point(MousePosition.X - this.Location.X, MousePosition.Y - this.Location.Y);
                this.Cursor = Cursors.SizeAll;
                if(act != "Interact")
                {
                    act = "Interact";
                    pic_path = BASIC_PATH + character + "\\" + skin + "\\" + act + ".gif";
                    this.pictureBox1.Image = Image.FromFile(pic_path);
                    timer1.Interval = 5950;
                    timer1.Start();
                }
            }
        }

        private void Original_MouseUp(object sender, MouseEventArgs e)
        {
            isMouseDown = false;
            this.Cursor = Cursors.Default;
        }

        private void Original_MouseEnter(object sender, EventArgs e)
        {
            isMouseEnter = true;
        }

        private void Original_MouseLeave(object sender, EventArgs e)
        {
            isMouseEnter = false;
        }

        private void Original_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown && isMouseEnter)
            {
                int dx = MousePosition.X - mouseOffset.X, dy = MousePosition.Y - mouseOffset.Y;
                this.Location = new Point(dx,dy);
            }
        }

        private void 帕拉斯ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            character = "Pallas";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            act = "Rela";
            pic_path = BASIC_PATH + character + "\\" + skin + "\\" + act + ".gif";
            this.pictureBox1.Image = Image.FromFile(pic_path);
            timer1.Stop();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if(act != "Interact")
            {
                switch (rand.Next() % 8)
                {
                    case 0:
                        act = "Move";
                        break;
                    case 1:
                        act = "Sit";
                        break;
                    case 2:
                        act = "Sleep";
                        break;
                    case 3:
                    case 4:
                        act = "Rela";
                        break;
                }
                timer2.Interval = rand.Next() % 5 * 1000 + 11000;  // 11~15秒一个动作
                pic_path = BASIC_PATH + character + "\\" + skin + "\\" + act + ".gif";
                timer2.Stop();
                this.pictureBox1.Image = Image.FromFile(pic_path);
                timer2.Start();
            }
        }
    }
}
