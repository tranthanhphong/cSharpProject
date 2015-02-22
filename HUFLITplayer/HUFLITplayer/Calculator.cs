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
    public partial class MainCalculator : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd,
                         int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        private static extern bool ReleaseCapture();


        double resultValue = 0; // declare the result value. set zero.
        string operationPerformed = ""; //
        bool isOperationPerformed = false;

        public MainCalculator()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainCalculator.ActiveForm.Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutCalculator frm = new AboutCalculator();
            frm.TopMost = true;
            frm.Show();
        }

        private void MainCalculator_Load(object sender, EventArgs e)
        {

        }

        private void button_click(object sender, EventArgs e)
        {
            if ((textbox_result.Text == "0") || (isOperationPerformed))
            {
                textbox_result.Clear();
            }
            isOperationPerformed = false;
            Button button = (Button)sender;
            if (textbox_result.Text == ".")
            {
                if (!button.Text.Contains("."))
                {
                    textbox_result.Text = textbox_result.Text + button.Text;
                }
            }
            else
                textbox_result.Text = textbox_result.Text + button.Text;
        }

        private void operator_click(object sender, EventArgs e)
        {
            Button button = (Button)sender; // see above

            if (resultValue != 0)
            {
                button18.PerformClick(); // equal operator
                operationPerformed = button.Text; //declared in the header

                labelCurrentOperator.Text = resultValue + " " + operationPerformed;
                isOperationPerformed = true;
            }
            else
            {
                operationPerformed = button.Text; //declared in the header
                resultValue = double.Parse(textbox_result.Text); // convert string to double from text box
                labelCurrentOperator.Text = resultValue + " " + operationPerformed;
                isOperationPerformed = true;
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            switch (operationPerformed)
            {
                case "+":
                    textbox_result.Text = (resultValue + double.Parse(textbox_result.Text)).ToString();
                    break;
                case "-":
                    textbox_result.Text = (resultValue - double.Parse(textbox_result.Text)).ToString();
                    break;
                case "*":
                    textbox_result.Text = (resultValue * double.Parse(textbox_result.Text)).ToString();
                    break;
                case "/":
                    textbox_result.Text = (resultValue / double.Parse(textbox_result.Text)).ToString();
                    break;
                default:
                    break;

            }
            resultValue = Double.Parse(textbox_result.Text);
            operationPerformed = "";
            
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textbox_result.Clear();
            
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textbox_result.Text = textbox_result.Text.Remove(textbox_result.Text.Length-1, 1);
            // int i = richTextBox1.Text.Length;
            // richTextBox1.Text = richTextBox1.Text.Substring(0, i - 1);
        }

        private void MainCalculator_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(new Pen(Color.Black, 3),
                            this.DisplayRectangle);    
        }

        private void button19_Click(object sender, EventArgs e)
        {
            MainCalculator.ActiveForm.Close();
        }

        private void menuStrip1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            TopMost = true;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                TopMost = true;
            }
            else { TopMost = false; }
        }
    }
}
