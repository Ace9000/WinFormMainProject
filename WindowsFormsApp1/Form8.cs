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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        //Ana1990
        string SkrienString = ""; int BrojacZaSkrienString = 0;
        int brojac = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            brojac = brojac - 1;
            label1.Text = brojac.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            brojac = brojac + 1;
            label1.Text = brojac.ToString();
        }

        // Ako vo formata 'Form8' propertito 'KeyPreview' ne namesteno TRUE togas PRVO se povikuva 
        // KetPress, KeyDown od formata a potoa istite od 'objektite' (kopcina, textboksovi) 
        private void Form8_KeyDown(object sender, KeyEventArgs e)
        {
            //MessageBox.Show("Form8_KeyDown");
            //return;

            KeysConverter kc = new KeysConverter();

            BrojacZaSkrienString = BrojacZaSkrienString + 1;
            SkrienString = SkrienString + kc.ConvertToString(e.KeyCode);
            if (SkrienString == "ANA1990") button3.Visible = true;


            if (BrojacZaSkrienString >= 7) SkrienString = "";
            

            //e.SuppressKeyPress = true;
            
            if (e.KeyCode == Keys.OemMinus || e.KeyCode == Keys.Subtract)
            {
                //MessageBox.Show("1111");
                e.SuppressKeyPress = false;
                brojac = brojac - 1;
                label1.Text = brojac.ToString();
            }

            if (e.KeyCode == Keys.Oemplus || e.KeyCode == Keys.Add)
            {
                //MessageBox.Show("1111");
                e.SuppressKeyPress = false;
                brojac = brojac + 1;
                label1.Text = brojac.ToString();
            }

        }

        private void button1_KeyDown(object sender, KeyEventArgs e)
        {
           // MessageBox.Show("button1_KeyDown");
        }

        private void button3_Click(object sender, EventArgs e)
        {
          //  MessageBox.Show("Pozdrav za Anasatas ...");
        }
    }
}
