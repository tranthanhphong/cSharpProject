using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HUFLITplayer
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
            Time.Enabled = true;
            Time.Interval = 3000;

        }

        private void Time_Tick(object sender, EventArgs e)
        {
            if (this.Opacity <= 1.0)
            {
                this.Opacity += 0.025;
            }
            else { Time.Stop(); }

            Time.Stop();
            this.DialogResult = DialogResult.OK;
            this.Close();

        }

        private void SplashScreen_Load(object sender, EventArgs e)
        {
            this.Opacity = 1.0;
            Time.Start();
            
        }
    }
}
