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
            int x = SystemInformation.WorkingArea.Width - 200;
            int y = SystemInformation.WorkingArea.Height - 100;
            this.StartPosition = FormStartPosition.Manual;
            this.Location = (Point)new Size(x, y);
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

        private void 退出_Click(object sender, EventArgs e)
        {
            config.saveInfos(this.Location.X, this.Location.Y, (int)(this.Opacity * 100), this.TopMost);
            notifyIcon1.Dispose();
            Application.Exit();
        }

        private void 显示_Click(object sender, EventArgs e)
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
        //帕拉斯
        private void original_Click(object sender, EventArgs e)
        {
            Character pallas_original = new Character("Pallas", "original", 6000,  0);
            pallas_original.Show();
        }

        private void 传承_Click(object sender, EventArgs e)
        {
            Character pallas_epoque = new Character("Pallas", "epoque", 3000, 21100);
            pallas_epoque.Show();
        }
        //讯使
        private void original2_Click(object sender, EventArgs e)
        {
            Character courier_original = new Character("Courier", "original", 3000, 0);
            courier_original.Show();
        }

        private void 新航线_Click(object sender, EventArgs e)
        {
            Character courier_winter = new Character("Courier", "winter", 3000, 0);
            courier_winter.Show();
        }

        private void 无言狂响_Click(object sender, EventArgs e)
        {
            Character courier_as = new Character("Courier", "as", 3000, 22000);
            courier_as.Show();
        }
        //银灰
        private void original3_Click(object sender, EventArgs e)
        {
            Character silverash_original = new Character("SilverAsh", "original", 3000, 0);
            silverash_original.Show();
        }

        private void 约克的寒风_Click(object sender, EventArgs e)
        {
            Character silverash_snow = new Character("SilverAsh", "snow", 3000, 35000);
            silverash_snow.Show();
        }

        private void 探寻者SKm01_Click(object sender, EventArgs e)
        {
            Character silverash_summer = new Character("SilverAsh", "summer", 3000, 18000);
            silverash_summer.Show();
        }
        //阿
        private void original4_Click(object sender, EventArgs e)
        {
            Character aak_original = new Character("Aak", "original", 3000, 0);
            aak_original.Show();
        }

        private void 百面郎中_Click(object sender, EventArgs e)
        {
            Character aak_nian4 = new Character("Aak", "nian4", 3000, 50000);
            aak_nian4.Show();
        }

        private void 妙手玄心_Click(object sender, EventArgs e)
        {
            Character aak_nian5 = new Character("Aak", "nian5", 6000, 47000);
            aak_nian5.Show();
        }
        //能天使
        private void original5_Click(object sender, EventArgs e)
        {
            Character exusiai_original = new Character("Exusiai", "original", 3000, 0);
            exusiai_original.Show();
        }

        private void 野地秘行_Click(object sender, EventArgs e)
        {
            Character exusiai_wild = new Character("Exusiai", "wild", 3000, 24100);
            exusiai_wild.Show();
        }

        private void 城市骑手_Click(object sender, EventArgs e)
        {
            Character exusiai_kfc = new Character("Exusiai", "kfc", 3000, 32000);
            exusiai_kfc.Show();
        }
        //赫拉格
        private void original6_Click(object sender, EventArgs e)
        {
            Character hellagur_original = new Character("Hellagur", "original", 3000, 0);
            hellagur_original.Show();
        }

        private void 歧路幻影_Click(object sender, EventArgs e)
        {
            Character hellagur_boc = new Character("Hellagur", "boc", 6000, 26000);
            hellagur_boc.Show();
        }
        //吽
        private void original7_Click(object sender, EventArgs e)
        {
            Character hung_original = new Character("Hung", "original", 3100, 0);
            hung_original.Show();
        }

        private void 一介车夫_Click(object sender, EventArgs e)
        {
            Character hung_nian4 = new Character("Hung", "nian4", 3000, 18000);
            hung_nian4.Show();
        }
        //老鲤
        private void original8_Click(object sender, EventArgs e)
        {
            Character lee_original = new Character("Lee", "original", 3100, 0);
            lee_original.Show();
        }
        //水月
        private void original9_Click(object sender, EventArgs e)
        {
            Character muziki_original = new Character("Mizuki", "original", 6000, 0);
            muziki_original.Show();
        }
        //临光
        private void original10_Click(object sender, EventArgs e)
        {
            Character nearl_original = new Character("Nearl", "original", 3000, 0);
            nearl_original.Show();
        }

        private void 耀骑士_Click(object sender, EventArgs e)
        {
            Character nearl_knight = new Character("Nearl", "knight", 3100, 0);
            nearl_knight.Show();
        }
        //嵯峨
        private void original11_Click(object sender, EventArgs e)
        {
            Character saga_original = new Character("Saga", "original", 3000, 0);
            saga_original.Show();
        }
        //W
        private void original12_Click(object sender, EventArgs e)
        {
            Character w_original = new Character("W", "original", 3100, 0);
            w_original.Show();
        }

        private void 恍惚_Click(object sender, EventArgs e)
        {
            Character w_epoque = new Character("W", "epoque", 3000, 0);
            w_epoque.Show();
        }
        #endregion
    }
}
