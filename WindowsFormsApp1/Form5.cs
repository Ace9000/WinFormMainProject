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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        int Brojac = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;

            timer1.Interval = 3000;
            timer1.Enabled = true;

            if (button1.Text == "Pocni") button1.Text = "Zavrsi";
            else if (button1.Text == "Zavrsi")
            {
                button1.Text = "Pocni";
                timer1.Enabled = false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Brojac = Brojac + 1;
            if (Brojac >= 4) Brojac = 1;

            //MessageBox.Show(Brojac.ToString());

            if (Brojac == 1)
            {
                pictureBox1.Visible = true;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
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

    }
}
