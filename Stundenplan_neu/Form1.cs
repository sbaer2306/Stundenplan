using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stundenplan_neu
{
    public partial class Form1 : Form
    {
        Database data = new Database();
        public Form1()
        {
         
            InitializeComponent();
            data.Lesen();

        }

        private void BtnEditor_Click(object sender, EventArgs e)
        {
            FormEditor formeditor = new FormEditor(this); //neues Objekt FormEditor 
            formeditor.ShowDialog(); //FormEditor anzeigen
        }

        private void BtnKontaktdaten_Click(object sender, EventArgs e)
        {

            FormKontaktdaten formkontaktdaten = new FormKontaktdaten();// neues Object fromkontaktdaten
            formkontaktdaten.ShowDialog(); //formkontakdaten anzeigen
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Noten frm = new Noten();
            frm.Show();
        }

        private void btnHilfe_Click(object sender, EventArgs e)
        {
            FormHilfe frm1 = new FormHilfe();
            frm1.ShowDialog();
        }

        private void btnBeenden_Click(object sender, EventArgs e) //Beenden des Fensters
        {
            if ((MessageBox.Show("Möchten Sie wirklich Beenden?", "Hilfe", MessageBoxButtons.YesNo)) == DialogResult.Yes)
            {
                this.Close();

            }
            else
            {

            }
        }


        private void BtnMo1_Click(object sender, EventArgs e)
        {
            Fach.zahler = 1;
            FormNotizen frmNot = new FormNotizen(); //Notizen einfügen
            frmNot.ShowDialog();
        }

        private void BtnMo2_Click(object sender, EventArgs e)
        {
            Fach.zahler = 2;
            FormNotizen frmNot = new FormNotizen(); //Notizen einfügen
            frmNot.ShowDialog();
        }
        private void BtnMo3_Click(object sender, EventArgs e)
        {
            Fach.zahler = 3;
            FormNotizen frmNot = new FormNotizen(); //Notizen einfügen
            frmNot.ShowDialog();
        }
        private void BtnMo4_Click(object sender, EventArgs e)
        {
            Fach.zahler = 4;
            FormNotizen frmNot = new FormNotizen(); //Notizen einfügen
            frmNot.ShowDialog();
        }
        private void BtnMo5_Click(object sender, EventArgs e)
        {
            Fach.zahler = 5;
            FormNotizen frmNot = new FormNotizen(); //Notizen einfügen
            frmNot.ShowDialog();
        }
        private void BtnMo6_Click(object sender, EventArgs e)
        {
            Fach.zahler = 6;
            FormNotizen frmNot = new FormNotizen(); //Notizen einfügen
            frmNot.ShowDialog();
        }
        private void BtnMo7_Click(object sender, EventArgs e)
        {
            Fach.zahler = 7;
            FormNotizen frmNot = new FormNotizen(); //Notizen einfügen
            frmNot.ShowDialog();
        }    
        private void BtnMo8_Click(object sender, EventArgs e)
        {
            Fach.zahler = 8;
            FormNotizen frmNot = new FormNotizen(); //Notizen einfügen
            frmNot.ShowDialog();
        }
          
         private void BtnMo9_Click(object sender, EventArgs e)
        {
            Fach.zahler = 9;
            FormNotizen frmNot = new FormNotizen(); //Notizen einfügen
            frmNot.ShowDialog();
        }
        private void BtnDi1_Click(object sender, EventArgs e)
        {
            Fach.zahler = 10;
            FormNotizen frmNot = new FormNotizen(); //Notizen einfügen
            frmNot.ShowDialog();
        }
        private void BtnDi2_Click(object sender, EventArgs e)
        {
            Fach.zahler = 11;
            FormNotizen frmNot = new FormNotizen(); //Notizen einfügen
            frmNot.ShowDialog();
        }
        private void BtnDi3_Click(object sender, EventArgs e)
         {
            Fach.zahler = 12;
            FormNotizen frmNot = new FormNotizen(); //Notizen einfügen
            frmNot.ShowDialog();
        }
        private void BtnDi4_Click(object sender, EventArgs e)
        {
            Fach.zahler = 13;
            FormNotizen frmNot = new FormNotizen(); //Notizen einfügen
            frmNot.ShowDialog();
        }

        private void BtnDi5_Click(object sender, EventArgs e)
        {
            Fach.zahler = 14;
            FormNotizen frmNot = new FormNotizen(); //Notizen einfügen
            frmNot.ShowDialog();
        }
        private void BtnDi6_Click(object sender, EventArgs e)
        {
            Fach.zahler = 15;
            FormNotizen frmNot = new FormNotizen(); //Notizen einfügen
            frmNot.ShowDialog();
        }

        private void BtnDi7_Click(object sender, EventArgs e)
        {
            Fach.zahler = 16;
            FormNotizen frmNot = new FormNotizen(); //Notizen einfügen
            frmNot.ShowDialog();
        }

        private void BtnDi8_Click(object sender, EventArgs e)
        {
            Fach.zahler = 17;
            FormNotizen frmNot = new FormNotizen(); //Notizen einfügen
            frmNot.ShowDialog();
        }

        private void BtnDi9_Click(object sender, EventArgs e)
        {
            Fach.zahler = 18;
            FormNotizen frmNot = new FormNotizen(); //Notizen einfügen
            frmNot.ShowDialog();
        }

        private void BtnMi1_Click(object sender, EventArgs e)
        {
            Fach.zahler = 19;
            FormNotizen frmNot = new FormNotizen(); //Notizen einfügen
            frmNot.ShowDialog();
        }

        private void BtnMi2_Click(object sender, EventArgs e)
        {
            Fach.zahler = 20;
            FormNotizen frmNot = new FormNotizen(); //Notizen einfügen
            frmNot.ShowDialog();
        }

        private void BtnMi3_Click(object sender, EventArgs e)
        {
            Fach.zahler = 21;
            FormNotizen frmNot = new FormNotizen(); //Notizen einfügen
            frmNot.ShowDialog();
        }

        private void BtnMi4_Click(object sender, EventArgs e)
        {
            Fach.zahler = 21;
            FormNotizen frmNot = new FormNotizen(); //Notizen einfügen
            frmNot.ShowDialog();
        }

        private void BtnMi5_Click(object sender, EventArgs e)
        {
            Fach.zahler = 22;
            FormNotizen frmNot = new FormNotizen(); //Notizen einfügen
            frmNot.ShowDialog();
        }

        private void BtnMi6_Click(object sender, EventArgs e)
        {
            Fach.zahler = 23;
            FormNotizen frmNot = new FormNotizen(); //Notizen einfügen
            frmNot.ShowDialog();
        }
        private void BtnMi7_Click(object sender, EventArgs e)
        {
            Fach.zahler = 24;
            FormNotizen frmNot = new FormNotizen(); //Notizen einfügen
            frmNot.ShowDialog();
        }

        private void BtnMi8_Click(object sender, EventArgs e)
        {
            Fach.zahler = 25;
            FormNotizen frmNot = new FormNotizen(); //Notizen einfügen
            frmNot.ShowDialog();
        }

        private void BtnMi9_Click(object sender, EventArgs e)
        {
            Fach.zahler = 26;
            FormNotizen frmNot = new FormNotizen(); //Notizen einfügen
            frmNot.ShowDialog();
        }

        private void BtnDo1_Click(object sender, EventArgs e)
        {
            Fach.zahler = 27;
            FormNotizen frmNot = new FormNotizen(); //Notizen einfügen
            frmNot.ShowDialog();
        }
        private void BtnDo2_Click(object sender, EventArgs e)
        {
            Fach.zahler = 28;
            FormNotizen frmNot = new FormNotizen(); //Notizen einfügen
            frmNot.ShowDialog();
        }

        private void BtnDo3_Click(object sender, EventArgs e)
        {
            Fach.zahler = 29;
            FormNotizen frmNot = new FormNotizen(); //Notizen einfügen
            frmNot.ShowDialog();
        }

        private void BtnDo4_Click(object sender, EventArgs e)
        {
            Fach.zahler = 30;
            FormNotizen frmNot = new FormNotizen(); //Notizen einfügen
            frmNot.ShowDialog();
        }

        private void BtnDo5_Click(object sender, EventArgs e)
        {
            Fach.zahler = 31;
            FormNotizen frmNot = new FormNotizen(); //Notizen einfügen
            frmNot.ShowDialog();
        }

        private void BtnDo6_Click(object sender, EventArgs e)
        {
            Fach.zahler = 32;
            FormNotizen frmNot = new FormNotizen(); //Notizen einfügen
            frmNot.ShowDialog();
        }

        private void BtnDo7_Click(object sender, EventArgs e)
        {
            Fach.zahler = 33;
            FormNotizen frmNot = new FormNotizen(); //Notizen einfügen
            frmNot.ShowDialog();
        }

        private void BtnDo8_Click(object sender, EventArgs e)
        {
            Fach.zahler = 34;
            FormNotizen frmNot = new FormNotizen(); //Notizen einfügen
            frmNot.ShowDialog();
        }

        private void BtnDo9_Click(object sender, EventArgs e)
        {
            Fach.zahler = 35;
            FormNotizen frmNot = new FormNotizen(); //Notizen einfügen
            frmNot.ShowDialog();
        }

        private void BtnFr1_Click(object sender, EventArgs e)
        {
            Fach.zahler = 36;
            FormNotizen frmNot = new FormNotizen(); //Notizen einfügen
            frmNot.ShowDialog();
        }

        private void BtnFr2_Click(object sender, EventArgs e)
        {
            Fach.zahler = 37;
            FormNotizen frmNot = new FormNotizen(); //Notizen einfügen
            frmNot.ShowDialog();
        }

        private void BtnFr3_Click(object sender, EventArgs e)
        {
            Fach.zahler = 38;
            FormNotizen frmNot = new FormNotizen(); //Notizen einfügen
            frmNot.ShowDialog();
        }

        private void BtnFr4_Click(object sender, EventArgs e)
        {
            Fach.zahler = 39;
            FormNotizen frmNot = new FormNotizen(); //Notizen einfügen
            frmNot.ShowDialog();
        }

        private void BtnFr5_Click(object sender, EventArgs e)
        {
            Fach.zahler = 40;
            FormNotizen frmNot = new FormNotizen(); //Notizen einfügen
            frmNot.ShowDialog();
        }

        private void BtnFr6_Click(object sender, EventArgs e)
        {
            Fach.zahler = 41;
            FormNotizen frmNot = new FormNotizen(); //Notizen einfügen
            frmNot.ShowDialog();
        }

        private void BtnFr7_Click(object sender, EventArgs e)
        {
            Fach.zahler = 42;
            FormNotizen frmNot = new FormNotizen(); //Notizen einfügen
            frmNot.ShowDialog();
        }

        private void BtnFr8_Click(object sender, EventArgs e)
        {
            Fach.zahler = 43;
            FormNotizen frmNot = new FormNotizen(); //Notizen einfügen
            frmNot.ShowDialog();
        }

        private void BtnFr9_Click(object sender, EventArgs e)
        {
            Fach.zahler = 44;
            FormNotizen frmNot = new FormNotizen(); //Notizen einfügen
            frmNot.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Montag Button Laden
            BtnMo1.Text = Properties.Settings.Default.Mo1;
            BtnMo2.Text = Properties.Settings.Default.Mo2;
            BtnMo3.Text = Properties.Settings.Default.Mo3;
            BtnMo4.Text = Properties.Settings.Default.Mo4;
            BtnMo5.Text = Properties.Settings.Default.Mo5;
            BtnMo6.Text = Properties.Settings.Default.Mo6;
            BtnMo7.Text = Properties.Settings.Default.Mo7;
            BtnMo8.Text = Properties.Settings.Default.Mo8;
            BtnMo9.Text = Properties.Settings.Default.Mo9;

            // Dienstag Button Laden
            BtnDi1.Text = Properties.Settings.Default.Di1;
            BtnDi2.Text = Properties.Settings.Default.Di2;
            BtnDi3.Text = Properties.Settings.Default.Di3;
            BtnDi4.Text = Properties.Settings.Default.Di4;
            BtnDi5.Text = Properties.Settings.Default.Di5;
            BtnDi6.Text = Properties.Settings.Default.Di6;
            BtnDi7.Text = Properties.Settings.Default.Di7;
            BtnDi8.Text = Properties.Settings.Default.Di8;
            BtnDi9.Text = Properties.Settings.Default.Di9;

            // Mittwoch Button Laden
            BtnMi1.Text = Properties.Settings.Default.Mi1;
            BtnMi2.Text = Properties.Settings.Default.Mi2;
            BtnMi3.Text = Properties.Settings.Default.Mi3;
            BtnMi4.Text = Properties.Settings.Default.Mi4;
            BtnMi5.Text = Properties.Settings.Default.Mi5;
            BtnMi6.Text = Properties.Settings.Default.Mi6;
            BtnMi7.Text = Properties.Settings.Default.Mi7;
            BtnMi8.Text = Properties.Settings.Default.Mi8;
            BtnMi9.Text = Properties.Settings.Default.Mi9;

            // Donnerstag Button Laden
            BtnDo1.Text = Properties.Settings.Default.Do1;
            BtnDo2.Text = Properties.Settings.Default.Do2;
            BtnDo3.Text = Properties.Settings.Default.Do3;
            BtnDo4.Text = Properties.Settings.Default.Do4;
            BtnDo5.Text = Properties.Settings.Default.Do5;
            BtnDo6.Text = Properties.Settings.Default.Do6;
            BtnDo7.Text = Properties.Settings.Default.Do7;
            BtnDo8.Text = Properties.Settings.Default.Do8;
            BtnDo9.Text = Properties.Settings.Default.Do9;

            // Freitag Button Laden
            BtnFr1.Text = Properties.Settings.Default.Fr1;
            BtnFr2.Text = Properties.Settings.Default.Fr2;
            BtnFr3.Text = Properties.Settings.Default.Fr3;
            BtnFr4.Text = Properties.Settings.Default.Fr4;
            BtnFr5.Text = Properties.Settings.Default.Fr5;
            BtnFr6.Text = Properties.Settings.Default.Fr6;
            BtnFr7.Text = Properties.Settings.Default.Fr7;
            BtnFr8.Text = Properties.Settings.Default.Fr8;
            BtnFr9.Text = Properties.Settings.Default.Fr9;


            // Array Laden
            Fach.Array[0, 1] = Properties.Settings.Default.Array01;
            Fach.Array[0, 2] = Properties.Settings.Default.Array02;
            Fach.Array[0, 3] = Properties.Settings.Default.Array03;
            Fach.Array[0, 4] = Properties.Settings.Default.Array04;
            Fach.Array[0, 5] = Properties.Settings.Default.Array05;

            Fach.Array[1, 1] = Properties.Settings.Default.Array11;
            Fach.Array[1, 2] = Properties.Settings.Default.Array12;
            Fach.Array[1, 3] = Properties.Settings.Default.Array13;
            Fach.Array[1, 4] = Properties.Settings.Default.Array14;
            Fach.Array[1, 5] = Properties.Settings.Default.Array15;

            Fach.Array[2, 1] = Properties.Settings.Default.Array21;
            Fach.Array[2, 2] = Properties.Settings.Default.Array22;
            Fach.Array[2, 3] = Properties.Settings.Default.Array23;
            Fach.Array[2, 4] = Properties.Settings.Default.Array24;
            Fach.Array[2, 5] = Properties.Settings.Default.Array25;

            Fach.Array[3, 1] = Properties.Settings.Default.Array31;
            Fach.Array[3, 2] = Properties.Settings.Default.Array32;
            Fach.Array[3, 3] = Properties.Settings.Default.Array33;
            Fach.Array[3, 4] = Properties.Settings.Default.Array34;
            Fach.Array[3, 5] = Properties.Settings.Default.Array35;

            Fach.Array[4, 1] = Properties.Settings.Default.Array41;
            Fach.Array[4, 2] = Properties.Settings.Default.Array42;
            Fach.Array[4, 3] = Properties.Settings.Default.Array43;
            Fach.Array[4, 4] = Properties.Settings.Default.Array44;
            Fach.Array[4, 5] = Properties.Settings.Default.Array45;

            Fach.Array[5, 1] = Properties.Settings.Default.Array51;
            Fach.Array[5, 2] = Properties.Settings.Default.Array52;
            Fach.Array[5, 3] = Properties.Settings.Default.Array53;
            Fach.Array[5, 4] = Properties.Settings.Default.Array54;
            Fach.Array[5, 5] = Properties.Settings.Default.Array55;

            Fach.Array[6, 1] = Properties.Settings.Default.Array61;
            Fach.Array[6, 2] = Properties.Settings.Default.Array62;
            Fach.Array[6, 3] = Properties.Settings.Default.Array63;
            Fach.Array[6, 4] = Properties.Settings.Default.Array64;
            Fach.Array[6, 5] = Properties.Settings.Default.Array65;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            data.Schreiben();
        }

        private void BtnDo1_Click_1(object sender, EventArgs e)
        {

        }

        private void BtnDo2_Click_1(object sender, EventArgs e)
        {

        }
    }
}
