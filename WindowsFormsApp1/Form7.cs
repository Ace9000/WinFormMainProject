using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace WindowsFormsApp1
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        int Brojac = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;

            timer1.Interval = 3000; timer2.Interval = 1000; timer3.Interval = 2000;
            timer1.Enabled = true; timer2.Enabled = false; timer3.Enabled = false;

            if (button1.Text == "Pocni") { button1.Text = "Zavrsi"; Brojac = 0; }
            else if (button1.Text == "Zavrsi")
            {
                button1.Text = "Pocni";
                timer1.Enabled = false; timer2.Enabled = false; timer3.Enabled = false;
            }
        }

        private void PromeniSemafor()
        {
            if (Brojac == 1)
            {
                pictureBox1.Visible = true;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                timer1.Enabled = false; timer2.Enabled = true; timer3.Enabled = false;
                //MessageBox.Show("Crveno");
            }
            else if (Brojac == 2)
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = true;
                pictureBox3.Visible = false;
                timer1.Enabled = false; timer2.Enabled = false; timer3.Enabled = true;
                //MessageBox.Show("Zolto");
            }
            else if (Brojac == 3)
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = true;
                timer1.Enabled = true; timer2.Enabled = false; timer3.Enabled = false;
                //MessageBox.Show("Zeleno");
            }
        }

        private void ZgolemiBrojac()
        {
            Brojac = Brojac + 1;
            if (Brojac >= 4) Brojac = 1;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            ZgolemiBrojac();

            PromeniSemafor();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            ZgolemiBrojac();

            PromeniSemafor();
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            ZgolemiBrojac();

            PromeniSemafor();

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Form5 xx = new Form5();
            //xx.ShowDialog();

            System.Diagnostics.Process.Start("www.simchostoimenov.com");
            linkLabel1.LinkVisited=true;
        }

        private void button2_MouseDown(object sender, MouseEventArgs e)
        {
            //switch (e.Button)
            //{
            //    case MouseButtons.Left:
            //        MessageBox.Show("The left button was clicked");
            //        break;
            //    case MouseButtons.Right:
            //        MessageBox.Show("The right button was clicked");
            //        break;
            //    case MouseButtons.Middle:
            //        MessageBox.Show("The middle button was clicked");
            //        break;
            //    default:
            //        MessageBox.Show("Some other button was clicked");
            //        break;
            //}

            if (e.Button == MouseButtons.Left)
            {
                MessageBox.Show("The left button was clicked");
                this.Close();
            }
            else if (e.Button == MouseButtons.Right)
            {
                MessageBox.Show("The right button was clicked");
            }
            else if (e.Button == MouseButtons.Middle)
            {
                MessageBox.Show("The Middle button was clicked");
            }
            else
            {
                MessageBox.Show("Some other button was clicked");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Dialog aForm = new Dialog();
            DialogResult aResult;
            aResult = aForm.ShowDialog();

            if (aResult == DialogResult.Yes)
            {
                MessageBox.Show("Yes ...");
            }
            else
            {
                MessageBox.Show("No ...");
            }
        }
    }
}
