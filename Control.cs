using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArkQ
{
    public partial class Control : Form
    {
        private AppConfig config = new AppConfig();
        private Point mouseOffset;
        private bool isMouseDown = false;
        public bool isMouseEnter = false;
        public Control()
        {
            InitializeComponent();
            //int x = SystemInformation.WorkingArea.Width - 200;
            //int y = SystemInformation.WorkingArea.Height - 100;
            //this.StartPosition = FormStartPosition.Manual;
            //this.Location = (Point)new Size(x, y);  
        }

        //鼠标拖动
        #region  鼠标拖动
        private void Control_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isMouseDown = true;
                mouseOffset = new Point(MousePosition.X - this.Location.X, MousePosition.Y - this.Location.Y);
                this.Cursor = Cursors.SizeAll;
            }
        }

        private void Control_MouseEnter(object sender, EventArgs e)
        {
            isMouseEnter = true;
        }

        private void Control_MouseLeave(object sender, EventArgs e)
        {
            isMouseEnter = false;
        }

        private void Control_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown && isMouseEnter)
            {
                int dx = MousePosition.X - mouseOffset.X, dy = MousePosition.Y - mouseOffset.Y;
                this.Location = new Point(dx, dy);
            }
        }

        private void Control_MouseUp(object sender, MouseEventArgs e)
        {
            isMouseDown = false;
            this.Cursor = Cursors.Default;
        }
        #endregion

        //基本功能菜单
        #region 基本功能菜单
        private void 隐藏_Click(object sender, EventArgs e)
        {
            this.Opacity = 0;
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            config.saveInfos(this.Location.X, this.Location.Y, (int)(this.Opacity * 100), this.TopMost);
            notifyIcon1.Dispose();
            Application.Exit();
        }

        private void 显示_Click_1(object sender, EventArgs e)
        {
            this.Opacity = 100;
        }

        private void 退出2_Click(object sender, EventArgs e)
        {
            config.saveInfos(this.Location.X, this.Location.Y, (int)(this.Opacity * 100), this.TopMost);
            notifyIcon1.Dispose();
            Application.Exit();
        }
        #endregion

        //创建角色菜单
        #region 创建角色菜单
        private void originalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Character pallas_original = new Character("Pallas", "original",6000,0);
            pallas_original.Show();
        }
        #endregion

        private void 传承ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Character pallas_epoque = new Character("Pallas", "epoque", 3000, 20000);
            pallas_epoque.Show();
        }

        private void originalToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Character courier_original = new Character("Courier", "original", 3000, 0);
            courier_original.Show();
        }

        private void 新航线ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Character courier_winter = new Character("Courier", "winter", 3000, 18000);
            courier_winter.Show();
        }

        private void 无言狂想ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Character courier_as = new Character("Courier", "as", 3000, 18000);
            courier_as.Show();
        }
    }
}
