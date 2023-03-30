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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnKopce1_Click(object sender, EventArgs e)
        {
            Form2 xx = new Form2();

            xx.ShowDialog();
            //xx.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 xx = new Form3();

            xx.ShowDialog();
        }
        private void Form4_Load(object sender, EventArgs e)

        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 xx = new Form4();
            xx.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form5 xx = new Form5();
            xx.ShowDialog();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Form6 xx = new Form6();
            xx.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form7 xx = new Form7();
            xx.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form8 xx = new Form8();
            xx.ShowDialog();
        }
    }
}
