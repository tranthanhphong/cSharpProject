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
    public partial class Library : Form
    {
        public Library()
        {
            InitializeComponent();
        }

        private void mediaInfoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.mediaInfoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataDataSet1);

        }

        private void Library_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataDataSet2.MediaInfo' table. You can move, or remove it, as needed.
            this.mediaInfoTableAdapter1.Fill(this.dataDataSet2.MediaInfo);
            // TODO: This line of code loads data into the 'dataDataSet1.MediaInfo' table. You can move, or remove it, as needed.
            this.mediaInfoTableAdapter.Fill(this.dataDataSet1.MediaInfo);

        }

        private void yearLabel_Click(object sender, EventArgs e)
        {

        }

        private void mediaInfoBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

        private void nameTextEdit_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}
