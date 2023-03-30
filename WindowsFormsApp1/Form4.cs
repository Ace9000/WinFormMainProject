using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(tabControl1.SelectedIndex.ToString());
            //MessageBox.Show(tabControl1.SelectedTab.Name);
            //MessageBox.Show(tabControl1.SelectedTab.Text);
            //tabControl1.SelectedTab.Text = "xxx";
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double a = 0;
            double b = 0;
            double c = 0;

            try
            {
                a = Convert.ToDouble(textBox1.Text);
                b = Convert.ToDouble(textBox2.Text);

                c = a / b;

                textBox3.Text = c.ToString();
                lblError.Text = "...";
                lblError.ForeColor = Color.Green;
            }
            catch 
            {
                lblError.Text = "Greska ...";
                lblError.ForeColor = Color.Red;
                //MessageBox.Show("nee uspesno");
                textBox1.Focus();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = 0;   
            double b = 0;
            double c = 0;

            try
            {
                a = Convert.ToDouble(textBox4.Text);
                b = Convert.ToDouble(textBox5.Text);

                c = a * b;
                textBox6.Text = c.ToString();
            }
            catch
            {
                Label1.Text = "Greska ...";
                Label1.ForeColor = Color.Red;
                MessageBox.Show("nee uspesno");
                textBox1.Focus();
            }

        }

        private void btnPing_Click(object sender, EventArgs e)
        {
            try
            {
                lblErrorIP.Text = "Greska";

                Ping myPing = new Ping();
                PingReply reply = myPing.Send(txtIP.Text, 1000);
                if (reply != null)
                {
                    if (reply.Status == IPStatus.Success)
                    {
                        lblErrorIP.Text = "Ok";
                    }
                    else
                    {
                        lblErrorIP.Text = "Greska";
                    }
                    //MessageBox.Show("Status :  " + reply.Status + " \n Time : " + reply.RoundtripTime.ToString() + " \n Address : " + reply.Address);
                    //Console.WriteLine("Status :  " + reply.Status + " \n Time : " + reply.RoundtripTime.ToString() + " \n Address : " + reply.Address);
                    //Console.WriteLine(reply.ToString());

                }
            }
            catch
            {
                
            }
        }

        private void txtIP_Validated(object sender, EventArgs e)
        {
            //if (txtIP.Text.Length == 0)
            //{
            //    MessageBox.Show("vnesi nesto");
            //}
        }

        private void txtIP_Leave(object sender, EventArgs e)
        {
            if (txtIP.Text.Length == 0)
            {
                MessageBox.Show("vnesi nesto");
                return;
            }

            string[] xx = txtIP.Text.Split('.');

            //foreach(string x in xx)
            //{
            //    MessageBox.Show(x);
            //}
            //MessageBox.Show(xx.Length.ToString());

            if (xx.Length != 4)
            {
                MessageBox.Show("vnesi 4 elementi");
                return;
            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            string VnesenoVoIP = txtIP.Text;
            string novstr = "";
            //novstr = VnesenoVoIP;

            //MessageBox.Show(VnesenoVoIP);
            int BrojTocki = 0;

            foreach (char aaa in VnesenoVoIP)
            {
                //MessageBox.Show(x.ToString());
                if (aaa == '.') BrojTocki = BrojTocki + 1;

                if(aaa == 'a')
                    novstr = novstr + "-A-";
                else
                    novstr = novstr + aaa;
                
                MessageBox.Show("novstr=" + novstr);
            }
            MessageBox.Show("Vo tekstot:" + VnesenoVoIP + " ima " + BrojTocki.ToString() + " tocki.");

        }

    }
}
