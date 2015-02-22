using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace HUFLITplayer
{
    public partial class MainForm : Form
    {
        //
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd,
                         int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        // code above for Drag windows form free

        public MainForm()
        {

            Application.Run(new SplashScreen()); // show splash screen first
            
            InitializeComponent();
            timer1.Start(); // timer at the top of the window
        }
        

        string[] files, paths; // declare string array (show song name in playlist)
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutCalculator frm = new AboutCalculator();
            frm.TopMost = true;
           
            frm.Show();
        }

        private void axVLCPlugin21_Enter(object sender, EventArgs e)
        {

        }

        private void youtubeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void youtubeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            YoutubeForm frm = new YoutubeForm();
            frm.Show();
        }

        private void mp3ZingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mp3ZingForm frm = new Mp3ZingForm();
            frm.Show();
        }

        private void nhaccuatuiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Nhaccuatui frm = new Nhaccuatui();
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Format|*.mp3;*.wav;*.mp4;*.avi;*.wmv;*.mpg;*.mpeg;*.m4a;*.3gp;*.3gp2|All Files (*.*)|*.*";//"(Video *.mp4, *.avi) | *.mp4, *.avi";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // axWindowsMediaPlayer1.URL = textbox_path.Text;
            axWindowsMediaPlayer1.URL = paths[listBox1.SelectedIndex];
        }

        private void button3_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.pause();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        private void simpleCalculatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog opd1 = new OpenFileDialog();
            opd1.Filter = "Format|*.mp3;*.wav;*.mp4;*.avi;*.wmv;*.mpg;*.mpeg;*.m4a;*.3gp;*.3gp2|All Files (*.*)|*.*";//"(Video *.mp4, *.avi) | *.mp4, *.avi";
            opd1.Multiselect = true; // choose multiple files
            if (opd1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                files = opd1.SafeFileNames; // save only the name
                paths = opd1.FileNames; // save the full path
                for (int i = 0; i < files.Length; i++)
                {
                    listBox1.Items.Add(files[i]);  // add song to the list box
                }
            }
        }
        
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // axWindowsMediaPlayer1.settings.autoStart = false;
            // axWindowsMediaPlayer1.URL = paths[listBox1.SelectedIndex];
            
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            //Library frm = new Library();
            //frm.Show();
        }

        private void listBox1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.All;
            else
                e.Effect = DragDropEffects.None;
        }

        private void listBox1_DragDrop(object sender, DragEventArgs e)
        {
            string[] s = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            int i;
            for (i = 0; i < s.Length; i++)
                listBox1.Items.Add(files[i]);
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MainForm.ActiveForm.Close();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog opd1 = new OpenFileDialog();
            opd1.Filter = "Format|*.mp3;*.wav;*.mp4;*.avi;*.wmv;*.mpg;*.mpeg;*.m4a;*.3gp;*.3gp2|All Files (*.*)|*.*";//"(Video *.mp4, *.avi) | *.mp4, *.avi";
            opd1.Multiselect = true; // choose multiple files
            if (opd1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                files = opd1.SafeFileNames; // save only the name
                paths = opd1.FileNames; // save the full path
                for (int i = 0; i < files.Length; i++)
                {
                    listBox1.Items.Add(files[i]);  // add song to the list box
                }
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            LiveTV frm = new LiveTV();
            
            frm.Show();

        }

        private void button9_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "http://m44.mytvnet.vn/pkg1/channels/vstv014/high/high-1385563526.ts";
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            MainForm.ActiveForm.Close();
        }

        private void button9_Click_2(object sender, EventArgs e)
        {
            MainForm.ActiveForm.Close();
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {


        }

        private void MainForm_MouseMove(object sender, MouseEventArgs e)
        {


        }

        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void menuStrip1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            
        }

        private void alwaysOnTopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TopMost = true;
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            TopMost = true;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            this.time_lbl.Text = dateTime.ToString();

        }

        private void time_lbl_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                TopMost = true;
            }
            else { TopMost = false; }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void button2_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void button8_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void button10_Click_2(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void notepadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("notepad.exe");
        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            byte[] exe = Properties.Resources.App;
            Process.Start("App.exe");

        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            byte[] exe = Properties.Resources.App;
            Process.Start("App.exe");
        }

        private void toolStripMenuItem3_Click_1(object sender, EventArgs e)
        {
            
        }

        private void taskManagerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            byte[] exe = Properties.Resources.TaskManager;
            Process.Start("TaskManager.exe");
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
           
        }

        private void casioCalculatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            byte[] exe = Properties.Resources.Casio;
            Process.Start("Casio.exe");
        }

        private void simpleCalculatorExampleByAvidToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainCalculator frm = new MainCalculator();
            frm.Show();
        }

        private void calculatorEx2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            byte[] exe = Properties.Resources.App;
            Process.Start("App.exe");
        }

        private void winSpyToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void winSpyToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void patchIDMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void diskCleanUPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("cleanmgr");
        }

        private void viewSystemPropertiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("sysdm.cpl");
        }

        private void deviceManagerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("devmgmt.msc");
        }

        private void regeditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("regedit");
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Radio frm = new Radio();
            frm.Show();
        }

        private void wirelessKeyviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void wirelessKeyviewFor64bitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void toolStripMenuItem3_Click_2(object sender, EventArgs e)
        {
            SopcastTV frm = new SopcastTV();
            frm.Show();
        }
        
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            
            
        }
        AxWMPLib.AxWindowsMediaPlayer mp;
        private void button11_Click_2(object sender, EventArgs e)
        {
            
            mp.settings.volume++;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }
    }
}
