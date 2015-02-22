using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace HUFLITplayer
{
    public partial class SopcastTV : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd,
                         int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        private static extern bool ReleaseCapture();
        public SopcastTV()
        {
            InitializeComponent();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutCalculator frm = new AboutCalculator();
            frm.TopMost = true;
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            axsopocx1.SopAddress = "sop://178.175.143.195:3912/148257";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SopcastTV.ActiveForm.Close();
        }

        private void menuStrip1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            axsopocx1.SopAddress = "sop://178.175.143.195:3912/148970";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            axsopocx1.SopAddress = "sop://178.175.143.195:3912/110152";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            axsopocx1.SopAddress = "sop://178.175.143.195:3912/253716";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            axsopocx1.SopAddress = "sop://178.175.143.195:3912/253717";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            axsopocx1.SopAddress = "sop://178.175.143.195:3912/148252";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            axsopocx1.SopAddress = "sop://178.175.143.195:3912/148254";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            axsopocx1.SopAddress = "sop://178.175.143.195:3912/149264";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            axsopocx1.SopAddress = "sop://178.175.143.195:3912/148248";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            axsopocx1.SopAddress = "sop://178.175.143.195:3912/148248";
        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            axsopocx1.SopAddress = "sop://178.175.143.195:3912/148975";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            axsopocx1.SopAddress = "sop://178.175.143.195:3912/148974";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            axsopocx1.SopAddress = "sop://178.175.143.195:3912/148973";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            axsopocx1.SopAddress = "sop://178.175.143.195:3912/148259";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            axsopocx1.SopAddress = "sop://178.175.143.195:3912/148972";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            axsopocx1.SopAddress = "sop://178.175.143.195:3912/148977";
        }
    }
}
