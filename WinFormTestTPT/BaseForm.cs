using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormTestTPT.Util;

namespace WinFormTestTPT
{
    public partial class BaseForm : Form
    {
        public BaseForm()
        {
            InitializeComponent();
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_reduce_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void panel_gradient(object sender, PaintEventArgs e)
        {
            //Tool.PaintGradientBackground(panel_mid, e, Color.FromArgb(0, 17, 26), Color.FromArgb(0, 35, 51), 0);
        }
    }
}
