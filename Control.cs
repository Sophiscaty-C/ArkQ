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
        public Control()
        {
            InitializeComponent();
            //int x = SystemInformation.WorkingArea.Width - 200;
            //int y = SystemInformation.WorkingArea.Height - 100;
            //this.StartPosition = FormStartPosition.Manual;
            //this.Location = (Point)new Size(x, y);  
        }

        private void 帕拉斯_Click(object sender, EventArgs e)
        {
            Pallas pallas = new Pallas();
            pallas.Show();
        }

        private void 讯使_Click(object sender, EventArgs e)
        {
            Courier courier = new Courier();
            courier.Show();
        }

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
    }
}
