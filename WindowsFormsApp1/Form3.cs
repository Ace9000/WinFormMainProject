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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        public static Button[] xxx = new Button[8];
        String[] Denovi = new String[7] { "Ponedelnik", "Vtornik", "Sreda", "Cetvrtok", "Petok", "Sabota", "Nedela" };
        String[] Meseci = new String[12] { "Januari", "Februari", "Mart", "April", "Maj", "Juni", "Juli", "Avgust", "Septevri", "Oktomvri", "Noemvri", "Dekemvri" };
        String[] stringArrayIme = new string[3];
        int BrojNaVneseniPodatoci = 0;


        private void Form3_Load(object sender, EventArgs e)
        {
           
            int Den = (int)DateTime.Now.DayOfWeek;
            int Mesec = DateTime.Now.Month;
            //MessageBox.Show(Den.ToString());
            lblSegaData.Text = "" + Denovi[Den - 1] + " - " + DateTime.Now.Day + "  " + Meseci[Mesec - 1] + "  " + DateTime.Now.Year;

            Button aButton1 = new Button();
            aButton1.Location = new Point(120, 20);
            aButton1.Text = "Test Button 1";
            aButton1.Width = 150;
            aButton1.Click += ProbaClick;
            //panel1.Controls.Add(aButton1);

            Flp.Controls.Add(aButton1);
            Flp.SetFlowBreak(aButton1, false);
            

            Button aButton11 = new Button();
            Flp.Controls.Add(aButton11);


            Button aButton2 = new Button();
            aButton2.Location = new Point(20, 20);
            aButton2.Text = "Test Button 2";
            aButton2.Width = 150;
            aButton2.Click += ProbaClick;
            this.Controls.Add(aButton2);

            //dodavanje 'button' bez ciklus for
            //xxx[0] = new Button();
            //xxx[0].Name = "btn_" + 1.ToString();
            //xxx[0].Location = new Point(1000, 100);
            //xxx[0].Text = "Test Button " + 1.ToString();
            //xxx[0].Width = 150;
            //xxx[0].Click += ProbaClick;
            //this.Controls.Add(xxx[0]);

            //xxx[1] = new Button();
            //xxx[1].Name = "btn_" + 2.ToString();
            //xxx[1].Location = new Point(1000, 130);
            //xxx[1].Text = "Test Button " + 2.ToString();
            //xxx[1].Width = 150;
            //xxx[1].Click += ProbaClick;
            //this.Controls.Add(xxx[1]);

            for (int i = 0; i <= 7; i++)
            {
                xxx[i] = new Button();
                xxx[i].Name = "btn_" + (i + 1).ToString();
                xxx[i].Location = new Point(1000, 100 + (i * 30));
                xxx[i].Text = "Test Button " + (i + 1).ToString();
                xxx[i].Width = 150;
                xxx[i].Click += ProbaClick;
                this.Controls.Add(xxx[i]);
            }

            // sumiranje bez ciklus i bez niza
            int xi1 = 0; int xi2 = 2; int xi3 = 4;
            int xi = xi1 * 5 + xi2 * 5 + xi3 * 5;
            //MessageBox.Show("xi=" + xi.ToString());


            // sumiranje so ciklus i so niza
            int[] xii = new int[3] { 0, 2, 4 };
            int suma_xii = 0;

            for (int i = 0; i <= 2; i++)
            {
                suma_xii = suma_xii + xii[i] * 5;
            }
            //MessageBox.Show("suma_xii=" + suma_xii.ToString());


            String ime1 = "Anastas";
            String ime2 = "Simon";
            String ime3 = "Petar";

            String[] ime = new String[4] { "Anastas", "Simon", "Petar" , "1111"};
            ime[0] = ime[0] + " aaaaa";

            for (int i = 0; i <= 2; i++)
            {
                //MessageBox.Show(ime[i]);
                ime[i] = ime[i]  +  " simo " + (i + 1).ToString();
            }
            foreach(String si in ime)
            {
                //MessageBox.Show(si);
            }
        
        }

        private void ProbaClick(object sender, EventArgs e)
        {
            MessageBox.Show("xxxxx");
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void btn1Click()
        {
            //MessageBox.Show(dateTimePicker1.Value.ToShortDateString());

            if (!rbMasko.Checked && !rbZensko.Checked)
            {
                MessageBox.Show("Odberete M / Z ");
                groupBox1.Focus();
                
                return;
            }

            DateTime NajgolemaData = DateTime.Now.AddYears(-1);
            if (dateTimePicker1.Value > NajgolemaData)
            {
                MessageBox.Show("Odberete data ... pomala od " + NajgolemaData.ToShortDateString());
                dateTimePicker1.Focus();
                return;
            }

            if (comboBox1.Text.Length < 5)
            {
                MessageBox.Show("Odberete grad ...");
                comboBox1.Focus();
                return;
            }

            if (textBox1.Text.Length != 13)
            {
                MessageBox.Show("nema vneseno 13 brojki");
                textBox1.Focus();
                return;
            }
            if (textBox2.Text.Length <= 5)
            {
                MessageBox.Show("Nemate vneseno adresa");
                textBox2.Focus();
                return;
            }
            if (textBox3.Text.Length <= 3)
            {
                MessageBox.Show("Nemate vneseno Ime");
                textBox3.Focus();
                return;
            }
            if (textBox4.Text.Length <= 5)
            {
                MessageBox.Show("Nemate vneseno Prezime");
                textBox4.Focus();
                return;
            }

            //MessageBox.Show("dosega e ok");

            button1.Enabled = false;
            timer1.Enabled = true;

            //gi cuvame podatocite vo memorijata
            //ova  'if (BrojNaVneseniPodatoci + 1 <= 6)' i ova 'if (BrojNaVneseniPodatoci + 1 <= stringArrayIme.Length)'
            if (BrojNaVneseniPodatoci + 1 <= stringArrayIme.Length)
            {
                stringArrayIme[BrojNaVneseniPodatoci] = textBox3.Text;
                BrojNaVneseniPodatoci++;
            }
            else
            {
                MessageBox.Show("Nemate prostor ...");
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            btn1Click();

            //odzemanje na samiot nastan.
            //button1.Click -= button1_Click;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            button1.Enabled = true;
            timer1.Enabled = false;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (String si in stringArrayIme)
            {
                MessageBox.Show(si);
            }
        }

    }
}