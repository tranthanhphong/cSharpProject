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
    public partial class LiveTV : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd,
                         int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        private static extern bool ReleaseCapture();
        public LiveTV()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            axVLCPlugin21.playlist.add(@"rtmp://m17.megafun.vn/hctv/vstv004", null, null);
            axVLCPlugin21.playlist.playItem(0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            axVLCPlugin21.playlist.add(@"rtmp://119.18.186.116/live/vtv31_h", null, null);
            axVLCPlugin21.playlist.playItem(0);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            axVLCPlugin21.playlist.add(@"rtmp://m18.mytvnet.vn/hctv/vstv004", null, null);
            axVLCPlugin21.playlist.playItem(0);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            axVLCPlugin21.playlist.add(@"rtmp://m17.megafun.vn/hctv/vstv002", null, null);
            axVLCPlugin21.playlist.playItem(0);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            axVLCPlugin21.playlist.add(@"rtmp://119.18.186.116/live/vtv11_h", null, null);
            axVLCPlugin21.playlist.playItem(0);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            axVLCPlugin21.playlist.add(@"rtmp://m18.megafun.vn/hctv/vstv002", null, null);
            axVLCPlugin21.playlist.playItem(0);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            axVLCPlugin21.playlist.add(@"rtmp://m17.megafun.vn/hctv/vstv017", null, null);
            axVLCPlugin21.playlist.playItem(0);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            axVLCPlugin21.playlist.add(@"rtmp://119.18.186.116/live/vtv2", null, null);
            axVLCPlugin21.playlist.playItem(0);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            axVLCPlugin21.playlist.add(@"http://live.accessasia.tv:1935/vnptg_channels/mp4:vtv4.480p/playlist.m3u8?wowzasessionid=1513612735
", null, null);
            axVLCPlugin21.playlist.playItem(0);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            axVLCPlugin21.playlist.add(@"rtmp://m18.megafun.vn/hctv/vstv014", null, null);
            axVLCPlugin21.playlist.playItem(0);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            axVLCPlugin21.playlist.add(@"rtmp://m18.megafun.vn/hctv/vstv014", null, null);
            axVLCPlugin21.playlist.playItem(0);
        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            axVLCPlugin21.playlist.add(@"rtmp://119.18.186.116/live/vtc11_h", null, null);
            axVLCPlugin21.playlist.playItem(0);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            axVLCPlugin21.playlist.add(@"rtmp://m22.megafun.vn/hctv/vstv005", null, null);
            axVLCPlugin21.playlist.playItem(0);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            axVLCPlugin21.playlist.add(@"rtmp://119.18.186.116/live/vtc21_h", null, null);
            axVLCPlugin21.playlist.playItem(0);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            axVLCPlugin21.playlist.add(@"rtmp://m22.megafun.vn/hctv/vstv006", null, null);
            axVLCPlugin21.playlist.playItem(0);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            axVLCPlugin21.playlist.add(@"rtmp://m15.mytvnet.vn/hctv/vstv054", null, null);
            axVLCPlugin21.playlist.playItem(0);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            axVLCPlugin21.playlist.add(@"http://live.kenhitv.vn:1935/liveweb/itv_web_500k.stream/playlist.m3u8?wowzasessionid=318769477
", null, null);
            axVLCPlugin21.playlist.playItem(0);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            axVLCPlugin21.playlist.add(@"rtmp://m17.megafun.vn/hctv/vstv015", null, null);
            axVLCPlugin21.playlist.playItem(0);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            axVLCPlugin21.playlist.add(@"rtmp://m35.megafun.vn/hctv/vstv015", null, null);
            axVLCPlugin21.playlist.playItem(0);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            axVLCPlugin21.playlist.add(@"rtmp://m17.megafun.vn/hctv/vstv009", null, null);
            axVLCPlugin21.playlist.playItem(0);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            axVLCPlugin21.playlist.add(@"rtmp://m35.megafun.vn/hctv/vstv009", null, null);
            axVLCPlugin21.playlist.playItem(0);
        }

        private void button21_Click(object sender, EventArgs e)
        {
            axVLCPlugin21.playlist.add(@"rtmp://m17.megafun.vn/hctv/vstv047", null, null);
            axVLCPlugin21.playlist.playItem(0);
        }

        private void button22_Click(object sender, EventArgs e)
        {
            axVLCPlugin21.playlist.add(@"rtmp://m18.megafun.vn/hctv/vstv047", null, null);
            axVLCPlugin21.playlist.playItem(0);
        }

        private void button23_Click(object sender, EventArgs e)
        {
            axVLCPlugin21.playlist.add(@"rtmp://123.29.69.69/live//VTVCab16_600k", null, null);
            axVLCPlugin21.playlist.playItem(0);
        }

        private void button24_Click(object sender, EventArgs e)
        {
            axVLCPlugin21.playlist.add(@"rtmp://123.29.69.69/live/VTVCab3_600k", null, null);
            axVLCPlugin21.playlist.playItem(0);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LiveTV.ActiveForm.Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutCalculator frm = new AboutCalculator();
            frm.TopMost = true;
            frm.Show();
        }

        private void button25_Click(object sender, EventArgs e)
        {
            LiveTV.ActiveForm.Close();
        }

        private void menuStrip1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                TopMost = true;
            }
            else { TopMost = false; }
        }

        private void button26_Click(object sender, EventArgs e)
        {
            
        }

        private void button26_Click_1(object sender, EventArgs e)
        {
            axVLCPlugin21.playlist.add(@"rtmp://210.245.60.242/vovtv/vovtv", null, null);
            axVLCPlugin21.playlist.playItem(0);
        }

        private void button27_Click(object sender, EventArgs e)
        {
            axVLCPlugin21.playlist.add(@"rtmp://123.30.108.72/live//thvl2", null, null);
            axVLCPlugin21.playlist.playItem(0);
        }

        private void button28_Click(object sender, EventArgs e)
        {
            axVLCPlugin21.playlist.add(@"rtmp://123.30.108.72/live//thvl1", null, null);
            axVLCPlugin21.playlist.playItem(0);
        }

        private void button29_Click(object sender, EventArgs e)
        {
            axVLCPlugin21.playlist.add(@"rtmp://117.103.224.31/live//livestream", null, null);
            axVLCPlugin21.playlist.playItem(0);
        }

        private void button30_Click(object sender, EventArgs e)
        {
            axVLCPlugin21.playlist.add(@"rtmp://222.255.169.132/live//livestream", null, null);
            axVLCPlugin21.playlist.playItem(0);
        }

        private void button31_Click(object sender, EventArgs e)
        {
            axVLCPlugin21.playlist.add(@"mms://live1.wm.skynews.servecast.net/skynews_wmlz_live300k", null, null);
            axVLCPlugin21.playlist.playItem(0);
        }

        private void button32_Click(object sender, EventArgs e)
        {
            axVLCPlugin21.playlist.add(@"rtmp://web.3ch.net.cn/live/cctv1", null, null);
            axVLCPlugin21.playlist.playItem(0);
        }

        private void button33_Click(object sender, EventArgs e)
        {
            axVLCPlugin21.playlist.add(@"mms://123.30.108.114/BTVTruyenhinh", null, null);
            axVLCPlugin21.playlist.playItem(0);
        }

        private void button34_Click(object sender, EventArgs e)
        {
            axVLCPlugin21.playlist.add(@"rtmp://m28.megafun.vn/hctv?bts=vs.k25e/vstv010", null, null);
            axVLCPlugin21.playlist.playItem(0);
        }

        private void button35_Click(object sender, EventArgs e)
        {
            axVLCPlugin21.playlist.add(@"rtmp://m35.megafun.vn/hctv/vstv010", null, null);
            axVLCPlugin21.playlist.playItem(0);
        }

        private void button36_Click(object sender, EventArgs e)
        {
            axVLCPlugin21.playlist.add(@"rtmp://m35.megafun.vn/hctv/vstv011", null, null);
            axVLCPlugin21.playlist.playItem(0);
        }

        private void button37_Click(object sender, EventArgs e)
        {
            axVLCPlugin21.playlist.add(@"rtmp://m35.megafun.vn/hctv/vstv001", null, null);
            axVLCPlugin21.playlist.playItem(0);
        }

        private void button38_Click(object sender, EventArgs e)
        {
            axVLCPlugin21.playlist.add(@"mmsh://live1.cbn.org/iptv1", null, null);
            axVLCPlugin21.playlist.playItem(0);
        }

        private void button39_Click(object sender, EventArgs e)
        {
            axVLCPlugin21.playlist.add(@"rtmp://113.161.212.25/live//atv1", null, null);
            axVLCPlugin21.playlist.playItem(0);
        }

        private void button40_Click(object sender, EventArgs e)
        {
            axVLCPlugin21.playlist.add(@"rtmp://115.78.160.29/live//thhg", null, null);
            axVLCPlugin21.playlist.playItem(0);
        }

        private void button41_Click(object sender, EventArgs e)
        {
            axVLCPlugin21.playlist.add(@"rtmp://123.30.134.108/live/nctlive", null, null);
            axVLCPlugin21.playlist.playItem(0);
        }

        private void button42_Click(object sender, EventArgs e)
        {
            axVLCPlugin21.playlist.add(@"rtmp://222.255.167.149/live/livestream", null, null);
            axVLCPlugin21.playlist.playItem(0);
        }

        private void button43_Click(object sender, EventArgs e)
        {
            axVLCPlugin21.playlist.add(@"rtmp://113.161.4.102/live//vtvphuyen.tv", null, null);
            axVLCPlugin21.playlist.playItem(0);
        }

        private void button44_Click(object sender, EventArgs e)
        {
            axVLCPlugin21.playlist.add(@"rtmp://149.11.34.6/live/partytv.stream", null, null);
            axVLCPlugin21.playlist.playItem(0);

   
        }

        private void button45_Click(object sender, EventArgs e)
        {
            axVLCPlugin21.playlist.add(@"rtmp://stream.smcloud.net/live2/vox/vox_360p", null, null);
            axVLCPlugin21.playlist.playItem(0);
        }

        private void LiveTV_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void button46_Click(object sender, EventArgs e)
        {
            axVLCPlugin21.playlist.add(@"http://wpc.c1a9.edgecastcdn.net/hls-live/20C1A9/bbc_world/ls_satlink/b_828.m3u8", null, null);
            axVLCPlugin21.playlist.playItem(0);
        }

        private void button47_Click(object sender, EventArgs e)
        {
            axVLCPlugin21.playlist.add(@"rtmp://85.10.208.218/live/d1discovery", null, null);
            axVLCPlugin21.playlist.playItem(0);
        }

        private void button48_Click(object sender, EventArgs e)
        {
            axVLCPlugin21.playlist.add(@"rtmp://85.10.208.218/live/1hbo1234567", null, null);
            axVLCPlugin21.playlist.playItem(0); 
        }

        private void button49_Click(object sender, EventArgs e)
        {
            axVLCPlugin21.playlist.add(@"rtmp://85.10.208.218/live/2hboo", null, null);
            axVLCPlugin21.playlist.playItem(0);  
        }

        private void button50_Click(object sender, EventArgs e)
        {
            axVLCPlugin21.playlist.add(@"rtmp://85.10.208.218/live/hbocom", null, null);
            axVLCPlugin21.playlist.playItem(0); 
        }

        private void button51_Click(object sender, EventArgs e)
        {
            axVLCPlugin21.playlist.add(@"rtmp://85.10.208.218/live/a1xn", null, null);
            axVLCPlugin21.playlist.playItem(0); 
        }

        private void button52_Click(object sender, EventArgs e)
        {
            axVLCPlugin21.playlist.add(@"rtmp://85.10.208.218/live/nageo", null, null);
            axVLCPlugin21.playlist.playItem(0); 
        }

        private void button53_Click(object sender, EventArgs e)
        {
            axVLCPlugin21.playlist.add(@"rtmp://85.10.208.218/live/cinemax2", null, null);
            axVLCPlugin21.playlist.playItem(0);
        }

        private void button54_Click(object sender, EventArgs e)
        {
            axVLCPlugin21.playlist.add(@"rtmp://85.10.208.218/live/disneyxd", null, null);
            axVLCPlugin21.playlist.playItem(0);
        }

        private void button55_Click(object sender, EventArgs e)
        {
            axVLCPlugin21.playlist.add(@"rtmp://85.10.208.218/live/tllc", null, null);
            axVLCPlugin21.playlist.playItem(0);
        }

        private void button56_Click(object sender, EventArgs e)
        {
            axVLCPlugin21.playlist.add(@"rtmp://fms.105.net:1935/live/105Test1#gfgyut9991.ch?token=0.861700,1.03854", null, null);
            axVLCPlugin21.playlist.playItem(0);
        }

        private void button57_Click(object sender, EventArgs e)
        {
            axVLCPlugin21.playlist.add(@"rtmp://fms.gazeta.pl/aglive/tuba_tv", null, null);
            axVLCPlugin21.playlist.playItem(0);
        }

        private void button58_Click(object sender, EventArgs e)
        {
            axVLCPlugin21.playlist.add(@"rtmp://stream.smcloud.net/live/polotv", null, null);
            axVLCPlugin21.playlist.playItem(0);
        }

        private void button59_Click(object sender, EventArgs e)
        {
            axVLCPlugin21.playlist.add(@"rtmp://www.planeta-online.tv:1936/live/channel_4", null, null);
            axVLCPlugin21.playlist.playItem(0);
        }

        private void button60_Click(object sender, EventArgs e)
        {
            axVLCPlugin21.playlist.add(@"rtmp://musicbox.cdnvideo.ru/musicbox-live//musicbox.sdp", null, null);
            axVLCPlugin21.playlist.playItem(0);
        }

        private void button61_Click(object sender, EventArgs e)
        {
            axVLCPlugin21.playlist.add(@"rtmp://stream.smcloud.net/live2/best/best_360p", null, null);
            axVLCPlugin21.playlist.playItem(0); 
        }

        private void button62_Click(object sender, EventArgs e)
        {
            axVLCPlugin21.playlist.add(@"rtmp://yqyydhnc.cdnviet.com/mnrrnlm/drt1", null, null);
            axVLCPlugin21.playlist.playItem(0);       
        }

        private void button63_Click(object sender, EventArgs e)
        {
            axVLCPlugin21.playlist.add(@"rtmp://drt.danang.vn/live/livestream", null, null);
            axVLCPlugin21.playlist.playItem(0);
        }

        private void button64_Click(object sender, EventArgs e)
        {
            axVLCPlugin21.playlist.add(@"rtmp://202.43.109.147/rtplive//btv2.stream", null, null);
            axVLCPlugin21.playlist.playItem(0);
        }

        private void button65_Click(object sender, EventArgs e)
        {
            axVLCPlugin21.playlist.add(@"rtmp://202.43.109.147/live//btv1.stream", null, null);
            axVLCPlugin21.playlist.playItem(0);
        }

        private void button66_Click(object sender, EventArgs e)
        {
            axVLCPlugin21.playlist.add(@"rtmp://113.161.220.254/livepkgr//livestream1?adbe-live-event=liveevent", null, null);
            axVLCPlugin21.playlist.playItem(0);
        }

        private void button67_Click(object sender, EventArgs e)
        {
            axVLCPlugin21.playlist.add(@"rtmp://123.29.75.131/thdn/dn1.stream", null, null);
            axVLCPlugin21.playlist.playItem(0);
        }

        private void button68_Click(object sender, EventArgs e)
        {
            axVLCPlugin21.playlist.add(@"rtmp://123.29.75.131/thdn/dn2.stream", null, null);
            axVLCPlugin21.playlist.playItem(0);
        }

        private void button69_Click(object sender, EventArgs e)
        {
            axVLCPlugin21.playlist.add(@"rtmp://93.174.95.125:1935/edge/_definst_/dp2g1w4ip6v0zoc", null, null);
            axVLCPlugin21.playlist.playItem(0);
        }

        private void button70_Click(object sender, EventArgs e)
        {
            axVLCPlugin21.playlist.add(@"rtmp://93.174.95.125:1935/edge/_definst_/p78zj79dhlxx3ws", null, null);
            axVLCPlugin21.playlist.playItem(0);
        }

        private void button71_Click(object sender, EventArgs e)
        {
            axVLCPlugin21.playlist.add(@"rtmp://93.174.95.125:1935/edge/_definst_/9mfz7jkikuatfqz", null, null);
            axVLCPlugin21.playlist.playItem(0);
        }

        private void button72_Click(object sender, EventArgs e)
        {
            axVLCPlugin21.playlist.add(@"rtmp://123.30.191.207/hanoi2//live?e=1422072003&st=vntpHfWMiRt6q8xb0lh0cw", null, null);
            axVLCPlugin21.playlist.playItem(0);
        }

        private void button73_Click(object sender, EventArgs e)
        {
            axVLCPlugin21.playlist.add(@"http://htqjrpsv.cdnviet.com/htjzzsg/_definst_/dongthap.360p.stream/chunklist_w861299369.m3u8?t=07bbb41494abf3899a18093bfc6e4203&e=1422086244", null, null);
            axVLCPlugin21.playlist.playItem(0);
        }

        private void button74_Click(object sender, EventArgs e)
        {
            
        }

        private void button74_Click_1(object sender, EventArgs e)
        {
            axVLCPlugin21.playlist.add(@"http://live.accessasia.tv:1935/vnptg_channels/vctv10.480p/playlist.m3u8", null, null);
            axVLCPlugin21.playlist.playItem(0);
        }

        private void button75_Click(object sender, EventArgs e)
        {
            axVLCPlugin21.playlist.add(@"http://live.accessasia.tv:1935/vnptg_channels/vctv4.480p/playlist.m3u8", null, null);
            axVLCPlugin21.playlist.playItem(0);
        }

        private void button76_Click(object sender, EventArgs e)
        {
            axVLCPlugin21.playlist.add(@"http://wpc.c1a9.edgecastcdn.net/hls-live/20C1A9/cnn/ls_satlink/b_828.m3u8", null, null);
            axVLCPlugin21.playlist.playItem(0);
        }

        private void button77_Click(object sender, EventArgs e)
        {
            axVLCPlugin21.playlist.add(@"http://worldlive-ios.arirang.co.kr/arirang/arirangtvworldios.mp4.m3u8", null, null);
            axVLCPlugin21.playlist.playItem(0);
        }
        
    }
}
