﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace ArkQ
{
    public partial class Pallas : Form
    {
        private ToolStripMenuItem OpacityItem = null;
        public Random rand = new Random();

        private Point mouseOffset;
        private bool isMouseDown = false;
        public bool isMouseEnter = false;
        public string pic_path;//对应图片路径

        public string BASIC_PATH = System.IO.Directory.GetCurrentDirectory()+ "\\..\\..\\Properties\\Resources\\";
        public string character = "Pallas"; //角色
        public string act = ""; //动作
        public string skin = "original"; //皮肤
        public int[] interact_time = { 6000, 3000 };
        public int special_time = 20000;
        enum direction { Left, Right, Up, Down};
        private int screen_width;
        private int screen_height;
        private int r1;//控制左右
        private int r2;//控制上下
        private int v1;//控制左右速度(1~2pixel)
        private int v2;//控制上下速度(1~2pixel)

        public Pallas()
        {
            InitializeComponent();
            Rectangle ScreenArea = System.Windows.Forms.Screen.GetWorkingArea(this);
            screen_width = ScreenArea.Width;
            screen_height = ScreenArea.Height;
            OpacityItem = Opacity100;
            setOpacity(Opacity100, 100);
            r1 = rand.Next() % 2;
            r2 = rand.Next() % 2 + 2;
            v1 = rand.Next() % 3+1;
            v2 = rand.Next() % 3+1;
            change_act("Rela");
            timer2.Interval = 5000;          //固定5s之后开始改变动作
            timer4.Interval = 100;          //步行速度，每0.1s移动一步
            timer2.Start();
        }

        //动作变化
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
            
            if(r1 == (int)direction.Right)
                pic_path = BASIC_PATH + character + "\\" + skin + "\\" + act + ".gif";
            else if(r1 == (int)direction.Left)
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
                        else change_act("Move"); //多走走！！！不准养老！！！
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
            if(r1==(int)direction.Left && r2== (int)direction.Up)//左上
            {
                if(this.Location.X - v1 < 200 || this.Location.Y - v2 < 200)//换方向
                {
                    pic_path = BASIC_PATH + character + "\\" + skin + "\\" + act + ".gif";
                    this.pictureBox1.Image = Image.FromFile(pic_path);
                    r1 = (int)direction.Right;
                    r2 = (int)direction.Down;
                    v1 = rand.Next() % 3 + 1;
                    v2 = rand.Next() % 3 + 1;
                    this.Location = new Point(this.Location.X + v1, this.Location.Y + v2);
                }
                else//走路
                {
                    this.Location = new Point(this.Location.X - v1, this.Location.Y-v2);
                }
            }
            else if(r1 == (int)direction.Left && r2 == (int)direction.Down)//左下
            {
                if (this.Location.X - v1 < 200 || this.Location.Y + v2 > screen_height-200)
                {
                    pic_path = BASIC_PATH + character + "\\" + skin + "\\" + act + ".gif";
                    this.pictureBox1.Image = Image.FromFile(pic_path);
                    r1 = (int)direction.Right;
                    r2 = (int)direction.Up;
                    v1 = rand.Next() % 3 + 1;
                    v2 = rand.Next() % 3 + 1;
                    this.Location = new Point(this.Location.X + v1, this.Location.Y - v2);
                }
                else
                {
                    this.Location = new Point(this.Location.X - v1, this.Location.Y + v2);
                }
            }
            else if(r1 == (int)direction.Right && r2 == (int)direction.Up)//右上
            {
                if (this.Location.X + v1 > screen_width-200 || this.Location.Y - v2 < 200)
                {
                    pic_path = BASIC_PATH + character + "\\" + skin + "\\" + act + "R.gif";
                    this.pictureBox1.Image = Image.FromFile(pic_path);
                    r1 = (int)direction.Left;
                    r2 = (int)direction.Down;
                    v1 = rand.Next() % 3 + 1;
                    v2 = rand.Next() % 3 + 1;
                    this.Location = new Point(this.Location.X - v1, this.Location.Y + v2);
                }
                else
                {
                    this.Location = new Point(this.Location.X + v1, this.Location.Y - v2);
                }
            }
            else if(r1 == (int)direction.Right && r2 == (int)direction.Down)//右下
            {
                if (this.Location.X + v1 > screen_width - 200 || this.Location.Y + v2 > screen_height - 200)
                {
                    pic_path = BASIC_PATH + character + "\\" + skin + "\\" + act + "R.gif";
                    this.pictureBox1.Image = Image.FromFile(pic_path);
                    r1 = (int)direction.Left;
                    r2 = (int)direction.Up;
                    v1 = rand.Next() % 3 + 1;
                    v2 = rand.Next() % 3 + 1;
                    this.Location = new Point(this.Location.X - v1, this.Location.Y - v2);
                }
                else
                {
                    this.Location = new Point(this.Location.X + v1, this.Location.Y + v2);
                }
            }
        }
        #endregion

        //换衣服
        #region 换衣服
        private void originalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Original.Image = new Bitmap(Properties.Resources.dot);
            传承.Image = null;
            skin = "original";
            if (r1 == (int)direction.Right)
                pic_path = BASIC_PATH + character + "\\" + skin + "\\" + act + ".gif";
            else if (r1 == (int)direction.Left)
                pic_path = BASIC_PATH + character + "\\" + skin + "\\" + act + "R.gif";
            this.pictureBox1.Image = Image.FromFile(pic_path);
        }

        private void 传承ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Original.Image = null;
            传承.Image = new Bitmap(Properties.Resources.dot);
            skin = "epoque";
            if (r1 == (int)direction.Right)
                pic_path = BASIC_PATH + character + "\\" + skin + "\\" + act + ".gif";
            else if (r1 == (int)direction.Left)
                pic_path = BASIC_PATH + character + "\\" + skin + "\\" + act + "R.gif";
            this.pictureBox1.Image = Image.FromFile(pic_path);
        }
        #endregion

        //罚站吗？
        #region 罚站吗？
        private void 不要罚站了ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            change_act("Sit");
            timer2.Start();
        }

        private void 罚站ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            change_act("Rela");
            timer2.Stop();
        }
        #endregion
    }
}
