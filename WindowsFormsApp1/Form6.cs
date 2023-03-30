using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form6 : Form
    {
        public Form6()
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

            if (button1.Text == "Pocni") button1.Text = "Zavrsi";
            else if (button1.Text == "Zavrsi")
            {
                button1.Text = "Pocni";
                timer1.Enabled = false; timer2.Enabled = false; timer3.Enabled = false;
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Brojac = Brojac + 1;
            if (Brojac >= 4) Brojac = 1;

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
                //MessageBox.Show("Zolto");
            }
            else if (Brojac == 3)
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = true;
                //MessageBox.Show("Zeleno");
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            Brojac = Brojac + 1;
            if (Brojac >= 4) Brojac = 1;

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
                //MessageBox.Show("Zeleno");
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            Brojac = Brojac + 1;
            if (Brojac >= 4) Brojac = 1;

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
    }
}
