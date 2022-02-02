using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace ArkQ
{
    public partial class Pallas : Form
    {
        private AppConfig config = new AppConfig();
        private ToolStripMenuItem OpacityItem = null;
        public Random rand = new Random();
        public Courier courier = new Courier();

        private Point mouseOffset;
        private bool isMouseDown = false;
        public bool isMouseEnter = false;
        public string pic_path;//对应图片路径

        public string BASIC_PATH = "D:\\Git\\repository\\ArkQ\\Properties\\Resources\\";
        //需要解决成相对路径，但我还不知道怎么解决【爬
        public string character = "Pallas"; //角色
        public string act = ""; //动作
        public string skin = "original"; //皮肤
        public int[] interact_time = { 6000, 3000 };
        public int special_time = 20000;
        private int direction = 1;  //d = 1向右,d = -1向左
        private int screen_width;
        private int screen_height;
        

        public Pallas()
        {
            InitializeComponent();
            Rectangle ScreenArea = System.Windows.Forms.Screen.GetWorkingArea(this);
            screen_width = ScreenArea.Width;
            screen_height = ScreenArea.Height;
            OpacityItem = Opacity100;
            setOpacity(Opacity100, 100);
            change_act("Rela");
            timer2.Interval = 5000;          //固定5s之后开始改变动作
            timer4.Interval = 100;          //步行速度，每0.1s移动一步
            timer2.Start();
        }

        #region  动作变化
        private void change_act(string new_act)
        {
            if (act == new_act)              //如果动作没有变化
                return;
            else if (act == "Move")          //上一动作是 移动
            {
                timer2.Start();
                timer4.Stop();
            }
            if (new_act == "Move")          //下一动作是 移动
            {
                timer3.Interval = rand.Next() % 6 * 1000 + 15000; //15~20秒Move                 
                timer2.Stop();
                timer3.Start();
                timer4.Start();
            }
            else if (new_act == "Interact") //下一动作是 戳一戳
            {
                if (skin == "original")
                    timer1.Interval = interact_time[0];
                else if (skin == "epoque")
                    timer1.Interval = interact_time[1];
                timer1.Start();
            }
            else if(new_act == "Special")   //下一动作是 特殊动作
            {
                timer3.Interval = special_time;
                timer2.Stop();
                timer3.Start();
            }
            else
            {
                timer2.Interval = rand.Next() % 6 * 1000 + 5000;  //5~10秒后变成下一个动作
            }
            act = new_act;
            
            if(direction > 0)
                pic_path = BASIC_PATH + character + "\\" + skin + "\\" + act + ".gif";
            else
                pic_path = BASIC_PATH + character + "\\" + skin + "\\" + act + "R.gif";
            this.pictureBox1.Image = Image.FromFile(pic_path);
        }
        #endregion


        //显示方式
        #region 显示方式
        private void 始终保持最前ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            始终保持最前.Image= new Bitmap(Properties.Resources.dot);
            不需要保持最前.Image = null;
            this.TopMost = true;
        }

        private void 不需要保持最前ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            始终保持最前.Image = null;
            不需要保持最前.Image = new Bitmap(Properties.Resources.dot);
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

        private void 隐藏干员ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            setOpacity(Opacity0, 0);
        }
        #endregion

        //退出
        #region 退出
        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            config.saveInfos(this.Location.X, this.Location.Y, (int)(this.Opacity * 100), this.TopMost);
            MyNotifyIcon.Dispose();
            Application.Exit();
        }
        #endregion

        //鼠标拖动
        #region 鼠标拖动
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
        #endregion

        //鼠标点击
        #region 鼠标点击
        private void Original_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isMouseDown = true;
                mouseOffset = new Point(MousePosition.X - this.Location.X, MousePosition.Y - this.Location.Y);
                this.Cursor = Cursors.SizeAll;
                if (act != "Interact")
                {
                    change_act("Interact");
                }
            }
        }
        

        private void timer1_Tick(object sender, EventArgs e)
        {
            change_act("Rela");
            timer1.Stop();
        }
        #endregion

        //动作切换
        #region 动作切换
        private void timer2_Tick(object sender, EventArgs e)
        {
            if(act != "Interact" && act != "Special")  //避免打断戳一戳和特殊动作
            {
                switch (rand.Next() % 5) //五种动作转换
                {
                    case 0:
                        change_act("Move");
                        break;
                    case 1:
                        change_act("Sit");
                        break;
                    case 2:
                        change_act("Sleep");
                        break;
                    case 3:
                        change_act("Rela");
                        break;
                    case 4:
                        if (skin != "original")
                            change_act("Special");
                        else change_act("Rela"); 
                        break;
                }
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            change_act("Rela");
            timer3.Stop();
            timer2.Start();
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            //此处添加Move移动函数
            if (this.Location.X + 1 * direction > screen_width - 200 || this.Location.X + 1 * direction < 200)
            {
                Image new_image = Image.FromFile(pic_path);
                new_image.RotateFlip(RotateFlipType.Rotate180FlipY);
                direction = -1 * direction;
                if (direction > 0)
                    pic_path = BASIC_PATH + character + "\\" + skin + "\\" + act + ".gif";
                else
                    pic_path = BASIC_PATH + character + "\\" + skin + "\\" + act + "R.gif";
                this.pictureBox1.Image = Image.FromFile(pic_path);
            }  
            else
                this.Location = new Point(this.Location.X + 1 * direction, this.Location.Y);
        }
        #endregion

        //换人换衣服
        #region 换人换衣服
        private void 帕拉斯ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            帕拉斯.Image = new Bitmap(Properties.Resources.dot);
            讯使.Image = null;
            character = "Pallas";
        }

        private void 讯使ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            帕拉斯.Image = null;
            讯使.Image = new Bitmap(Properties.Resources.dot);
            courier.Show();
        }

        private void originalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Original.Image = new Bitmap(Properties.Resources.dot);
            传承.Image = null;
            skin = "original";
            pic_path = BASIC_PATH + character + "\\" + skin + "\\" + act + ".gif";
            this.pictureBox1.Image = Image.FromFile(pic_path);
        }

        private void 传承ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Original.Image = null;
            传承.Image = new Bitmap(Properties.Resources.dot);
            skin = "epoque";
            pic_path = BASIC_PATH + character + "\\" + skin + "\\" + act + ".gif";
            this.pictureBox1.Image = Image.FromFile(pic_path);
        }
        #endregion

        //罚站吗？
        #region 罚站吗？
        private void 罚站ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            change_act("Rela");
            timer2.Stop();
        }

        private void 不要罚站了ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            change_act("Move");
            timer2.Start();
        }
        #endregion
    }
}
