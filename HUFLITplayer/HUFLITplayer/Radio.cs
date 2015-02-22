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
    public partial class Radio : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd,
                         int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        private static extern bool ReleaseCapture();

        public Radio()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            axVLCPlugin21.playlist.add(@"rtmp://210.245.60.242/vov3/vov3", null, null);
            axVLCPlugin21.playlist.playItem(0);
        }

        private void Radio_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            axVLCPlugin21.playlist.add(@"rtmp://210.245.60.242/vov1/vov1", null, null);
            axVLCPlugin21.playlist.playItem(0);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            axVLCPlugin21.playlist.add(@"rtmp://210.245.60.242/vov2/vov2", null, null);
            axVLCPlugin21.playlist.playItem(0);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            axVLCPlugin21.playlist.add(@"rtmp://210.245.60.242/vov5/vov5", null, null);
            axVLCPlugin21.playlist.playItem(0);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            axVLCPlugin21.playlist.add(@"rtmp://210.245.60.242/vovgt/vovgt", null, null);
            axVLCPlugin21.playlist.playItem(0);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            axVLCPlugin21.playlist.add(@"rtmp://210.245.60.242/vovgtsg/vovgtsg", null, null);
            axVLCPlugin21.playlist.playItem(0);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            axVLCPlugin21.playlist.add(@"rtmp://vov.radiovietnam.vn/live/binhduong.stream", null, null);
            axVLCPlugin21.playlist.playItem(0);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            axVLCPlugin21.playlist.add(@"rtmp://vov.radiovietnam.vn/live/backan.stream", null, null);
            axVLCPlugin21.playlist.playItem(0);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            axVLCPlugin21.playlist.add(@"rtmp://vov.radiovietnam.vn/live/baclieu.stream", null, null);
            axVLCPlugin21.playlist.playItem(0);
            
        }

        private void button10_Click(object sender, EventArgs e)
        {
            axVLCPlugin21.playlist.add(@"rtmp://vov.radiovietnam.vn/live/quangninh.stream", null, null);
            axVLCPlugin21.playlist.playItem(0);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            axVLCPlugin21.playlist.add(@"rtmp://vov.radiovietnam.vn/live/quangtri.stream", null, null);
            axVLCPlugin21.playlist.playItem(0);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            axVLCPlugin21.playlist.add(@"rtmp://vov.radiovietnam.vn/live/khanhhoa.stream", null, null);
            axVLCPlugin21.playlist.playItem(0);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            axVLCPlugin21.playlist.add(@"rtmp://vov.radiovietnam.vn/live/lamdong.stream", null, null);
            axVLCPlugin21.playlist.playItem(0);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            axVLCPlugin21.playlist.add(@"rtmp://vov.radiovietnam.vn/live/vinhlong.stream", null, null);
            axVLCPlugin21.playlist.playItem(0);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            axVLCPlugin21.playlist.add(@"rtmp://vov.radiovietnam.vn/live/yenbai.stream", null, null);
            axVLCPlugin21.playlist.playItem(0);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            axVLCPlugin21.playlist.add(@"rtmp://vov.radiovietnam.vn/live/haiduong.stream", null, null);
            axVLCPlugin21.playlist.playItem(0);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            axVLCPlugin21.playlist.add(@"rtmp://vov.radiovietnam.vn/live/langson.stream", null, null);
            axVLCPlugin21.playlist.playItem(0);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            axVLCPlugin21.playlist.add(@"rtmp://vov.radiovietnam.vn/live/ninhbinh.stream", null, null);
            axVLCPlugin21.playlist.playItem(0);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            axVLCPlugin21.playlist.add(@"rtmp://vov.radiovietnam.vn/live/thainguyen.stream", null, null);
            axVLCPlugin21.playlist.playItem(0);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutCalculator frm = new AboutCalculator();
            frm.TopMost = true;
            frm.Show();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            Radio.ActiveForm.Close();
        }

        private void menuStrip1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            axVLCPlugin21.playlist.add(@"rtmp://155.obj.netromedia.net/capitalfmflash/capitalfmflash", null, null);
            axVLCPlugin21.playlist.playItem(0);
        }

        private void button22_Click(object sender, EventArgs e)
        {
            axVLCPlugin21.playlist.add(@"http://72.13.86.3:8000/;stream.nsv", null, null);
            axVLCPlugin21.playlist.playItem(0);
        }

        private void button23_Click(object sender, EventArgs e)
        {
            axVLCPlugin21.playlist.add(@"http://193.34.51.31:80/;stream.nsv", null, null);
            axVLCPlugin21.playlist.playItem(0);
        }

        private void button24_Click(object sender, EventArgs e)
        {
            axVLCPlugin21.playlist.add(@"http://80.237.159.96:80/angelsfox.mp3", null, null);
            axVLCPlugin21.playlist.playItem(0);
        }

        private void button25_Click(object sender, EventArgs e)
        {
            axVLCPlugin21.playlist.add(@"http://mp3.stream.tb-group.fm/tb.mp3", null, null);
            axVLCPlugin21.playlist.playItem(0);
        }

        private void button26_Click(object sender, EventArgs e)
        {
            axVLCPlugin21.playlist.add(@"http://178.77.123.78/dt-deejay-320.mp3", null, null);
            axVLCPlugin21.playlist.playItem(0);
        }

        private void button27_Click(object sender, EventArgs e)
        {
            axVLCPlugin21.playlist.add(@"http://79.141.174.214:19000/;stream.nsv", null, null);
            axVLCPlugin21.playlist.playItem(0);
        }

        private void button28_Click(object sender, EventArgs e)
        {
            axVLCPlugin21.playlist.add(@"http://pub5.di.fm/di_classictrance", null, null);
            axVLCPlugin21.playlist.playItem(0);
        }

        private void button29_Click(object sender, EventArgs e)
        {
            axVLCPlugin21.playlist.add(@"http://pub5.di.fm/di_djmixes", null, null);
            axVLCPlugin21.playlist.playItem(0);
        }

        private void button30_Click(object sender, EventArgs e)
        {
            axVLCPlugin21.playlist.add(@"http://pub5.di.fm/di_clubsounds", null, null);
            axVLCPlugin21.playlist.playItem(0);
        }

        private void button31_Click(object sender, EventArgs e)
        {
            axVLCPlugin21.playlist.add(@"http://pub5.di.fm/di_eurodance", null, null);
            axVLCPlugin21.playlist.playItem(0);
        }

        private void button32_Click(object sender, EventArgs e)
        {
            axVLCPlugin21.playlist.add(@"http://pub5.di.fm/di_harddance", null, null);
            axVLCPlugin21.playlist.playItem(0);
        }

        private void button33_Click(object sender, EventArgs e)
        {
            axVLCPlugin21.playlist.add(@"http://pub5.di.fm/di_progressive", null, null);
            axVLCPlugin21.playlist.playItem(0);
        }

        private void button34_Click(object sender, EventArgs e)
        {
            axVLCPlugin21.playlist.add(@"http://streaming.radionomy.com/ABCD-Eurodance", null, null);
            axVLCPlugin21.playlist.playItem(0);
        }

        private void button35_Click(object sender, EventArgs e)
        {
            axVLCPlugin21.playlist.add(@"http://traxx003.ice.infomaniak.ch/traxx003-high.mp3", null, null);
            axVLCPlugin21.playlist.playItem(0);
        }

        private void button36_Click(object sender, EventArgs e)
        {
            axVLCPlugin21.playlist.add(@"http://87.230.59.20/iloveradio2.mp3", null, null);
            axVLCPlugin21.playlist.playItem(0);
        }

        private void button37_Click(object sender, EventArgs e)
        {
            axVLCPlugin21.playlist.add(@"rtmp://drt.danang.vn/live/radio", null, null);
            axVLCPlugin21.playlist.playItem(0);
        }

        private void button38_Click(object sender, EventArgs e)
        {
            axVLCPlugin21.playlist.add(@"rtmp://vov.radiovietnam.vn/live/hanoi.stream", null, null);
            axVLCPlugin21.playlist.playItem(0);
        }

        private void button39_Click(object sender, EventArgs e)
        {
            axVLCPlugin21.playlist.add(@"rtmp://vov.radiovietnam.vn/live/dongthap.stream", null, null);
            axVLCPlugin21.playlist.playItem(0);
        }
    }
}
