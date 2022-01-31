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
    public partial class Original : Form
    {
        private ToolStripMenuItem OpacityItem = null;
        public Original()
        {
            InitializeComponent();
            OpacityItem = Opacity100;
            setOpacity(Opacity100, 100);
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
    }
}
