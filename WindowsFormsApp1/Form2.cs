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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

            textBox1.KeyDown += textBox1_KeyDown;


            textBox3.Enabled = false;
            //textBox3.Visible = false;

            textBox1.GotFocus += Control_GotFocus;
            textBox1.LostFocus += Control_LostFocus;

            textBox2.GotFocus += Control_GotFocus;// dodavanje na nastan
            textBox2.LostFocus += Control_LostFocus;

            this.KeyDown += Form2_KeyDown;
        }

        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            //MessageBox.Show("vo forma se naogjam " + e.KeyCode.ToString());
            //if (e.KeyCode == Keys.F1)
            //{
            //    MessageBox.Show(sender.GetType().Name.ToUpper());
            //    if (sender.GetType().Name.ToUpper() == "TEXTBOX")
            //    {

            //        TextBox ss = sender as TextBox;
            //        string ime = ss.Name;

            //        MessageBox.Show("Barate pomos ... od " + ime);
            //    }
            //}


        }
        public void Control_GotFocus(object sender, EventArgs e)
        {
            TextBox t = sender as TextBox;
            t.SelectAll();
            ((TextBox)sender).BackColor = Color.Yellow;
            
        }
        public void Control_LostFocus(object sender, EventArgs e)
        {
            TextBox t = sender as TextBox;
            t.SelectAll();
            ((TextBox)sender).BackColor = Color.White;
        }
        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
                textBox1.KeyDown -= textBox1_KeyDown;

            //textBox1.Width = 50;
            //textBox1.GotFocus -= Control_GotFocus; -= odzemanje na nastan
           // textBox1.LostFocus -= Control_LostFocus;


            double a = 0;
            double b = 0;
            double c = 0;

            try
            {
                a = Convert.ToDouble(textBox1.Text);
                b = Convert.ToDouble(textBox2.Text);

                c = a * b;

                textBox3.Text = c.ToString();
                lblError.Text = "...";
                lblError.ForeColor = Color.Green;
                textBox4.Text = textBox4.Text + textBox1.Text + " * " + textBox2.Text + " = " + textBox3.Text + "\r\n";
                textBox4.Select(textBox4.Text.Length, 0);   // se pozicionira na posledniot karakter
                textBox4.ScrollToCaret();                   // skrolot odi najdolu

                //MessageBox.Show("anastas " + textBox4.Text.Length);

                textBox1.Text = "0";textBox2.Text = "0";textBox3.Text = "0";
                textBox1.Focus();
          

            }
            catch
            {
                lblError.Text = "Greska ...";
                lblError.ForeColor = Color.Red;
                MessageBox.Show("nee uspesno");
                textBox1.Focus();
            }

            button1.Enabled = false;
            timer1.Enabled = true;


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            button1.Enabled = true;
            timer1.Enabled = false;
        }


        private void xxx_SamoBrojki_KeyDown(object sender, KeyEventArgs e, bool DaliDaImaTocka)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
                return;
            }
            //void kako nastan koj mozi da se povikuva od bilo kade. Od bilo koj Textbox.

            //TextBox xSender1 = (TextBox)sender;
            //MessageBox.Show(xSender1.Name);

            //MessageBox.Show(e.KeyCode.ToString());
            bool OkPritisnato = false;

            if (
                (e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9) ||
                (e.KeyCode >= Keys.NumPad0 && e.KeyCode <= Keys.NumPad9) ||
                e.KeyCode == Keys.Back ||
                (e.KeyCode == Keys.Decimal && DaliDaImaTocka) ||
                (e.KeyCode == Keys.OemPeriod && DaliDaImaTocka) ||
                e.KeyCode == Keys.Right ||
                e.KeyCode == Keys.Left
               )
            {
                if (e.KeyCode == Keys.Decimal || e.KeyCode == Keys.OemPeriod)
                {
                    string[] ImaTocki;
                    //ImaTocki = textBox1.Text.Split('.');
                    TextBox xSender = (TextBox)sender;
                    ImaTocki = xSender.Text.Split('.');
                    //MessageBox.Show(ImaTocki.Length.ToString());
                    if (ImaTocki.Length >= 2)
                        OkPritisnato = false;
                    else
                        OkPritisnato = true;
                }
                else
                {
                    OkPritisnato = true;
                }
            }
            else
            {
                OkPritisnato = false;
            }


            if (OkPritisnato)
                e.SuppressKeyPress = false;
            else
                e.SuppressKeyPress = true;
        }
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            xxx_SamoBrojki_KeyDown(sender, e, true);

            if (e.KeyCode == Keys.F1)
            {
                //MessageBox.Show(sender.GetType().Name.ToUpper());
                if (sender.GetType().Name.ToUpper() == "TEXTBOX")
                {

                    TextBox ss = sender as TextBox;
                    string ime = ss.Name;

                    MessageBox.Show("Barate pomos ... od " + ime);
                }
            }
        }

       
        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            xxx_SamoBrojki_KeyDown(sender, e, false);

            if (e.KeyCode == Keys.F1)
            {
                //MessageBox.Show(sender.GetType().Name.ToUpper());
                if (sender.GetType().Name.ToUpper() == "TEXTBOX")
                {

                    TextBox ss = sender as TextBox;
                    string ime = ss.Name;

                    MessageBox.Show("Barate pomos ... od " + ime);
                }
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }
    }
}
