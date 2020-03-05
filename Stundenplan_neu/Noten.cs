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
    public partial class Noten : Form
    {
        Database data = new Database();

        public Noten()
        {
            InitializeComponent();
        }

        //penise

        private void Noten_Load(object sender, EventArgs e)
        {
            int zaeler = 0;
            //test

            lbFach1.Text = Fach.Array[zaeler, 1];
            zaeler++;
            lbFach2.Text = Fach.Array[zaeler, 1];
            zaeler++;
            lbFach3.Text = Fach.Array[zaeler, 1];
            zaeler++;
            lbFach4.Text = Fach.Array[zaeler, 1];
            zaeler++;
            lbFach5.Text = Fach.Array[zaeler, 1];
            zaeler++;
            lbFach6.Text = Fach.Array[zaeler, 1];
            zaeler++;
            lbFach7.Text = Fach.Array[zaeler, 1];
            zaeler++;

            // Schulaufgaben Laden   
            
            // WIRD DURCH DATENBANK ERSETZT!     
            /*
            Fach.Array[7, 0] = Properties.Settings.Default.F1S1;             // Schulaufgaben
            Fach.Array[7, 1] = Properties.Settings.Default.F1S2;
            Fach.Array[7, 2] = Properties.Settings.Default.F1S3;
            Fach.Array[8, 0] = Properties.Settings.Default.F2S1;
            Fach.Array[8, 1] = Properties.Settings.Default.F2S2;
            Fach.Array[8, 2] = Properties.Settings.Default.F2S3;
            Fach.Array[9, 0] = Properties.Settings.Default.F3S1;
            Fach.Array[9, 1] = Properties.Settings.Default.F3S2;
            Fach.Array[9, 2] = Properties.Settings.Default.F3S3;
            Fach.Array[10, 0] = Properties.Settings.Default.F4S1;
            Fach.Array[10, 1] = Properties.Settings.Default.F4S2;
            Fach.Array[10, 2] = Properties.Settings.Default.F4S3;
            Fach.Array[11, 0] = Properties.Settings.Default.F5S1;
            Fach.Array[11, 1] = Properties.Settings.Default.F5S2;
            Fach.Array[11, 2] = Properties.Settings.Default.F5S3;
            Fach.Array[12, 0] = Properties.Settings.Default.F6S1;
            Fach.Array[12, 1] = Properties.Settings.Default.F6S2;
            Fach.Array[12, 2] = Properties.Settings.Default.F6S3;
            Fach.Array[13, 0] = Properties.Settings.Default.F7S1;
            Fach.Array[13, 1] = Properties.Settings.Default.F7S2;
            Fach.Array[13, 2] = Properties.Settings.Default.F7S3;
            Fach.Array[7, 3] = Properties.Settings.Default.F1E1;            // Stegreifaufgaben
            Fach.Array[7, 4] = Properties.Settings.Default.F1E2;
            Fach.Array[7, 5] = Properties.Settings.Default.F1E3;
            Fach.Array[7, 6] = Properties.Settings.Default.F1E4;
            Fach.Array[8, 3] = Properties.Settings.Default.F2E1;
            Fach.Array[8, 4] = Properties.Settings.Default.F2E2;
            Fach.Array[8, 5] = Properties.Settings.Default.F2E3;
            Fach.Array[8, 6] = Properties.Settings.Default.F2E4;
            Fach.Array[9, 3] = Properties.Settings.Default.F3E1;
            Fach.Array[9, 4] = Properties.Settings.Default.F3E2;
            Fach.Array[9, 5] = Properties.Settings.Default.F3E3;
            Fach.Array[9, 6] = Properties.Settings.Default.F3E4;
            Fach.Array[10, 3] = Properties.Settings.Default.F4E1;
            Fach.Array[10, 4] = Properties.Settings.Default.F4E2;
            Fach.Array[10, 5] = Properties.Settings.Default.F4E3;
            Fach.Array[10, 6] = Properties.Settings.Default.F4E4;
            Fach.Array[11, 3] = Properties.Settings.Default.F5E1;
            Fach.Array[11, 4] = Properties.Settings.Default.F5E2;
            Fach.Array[11, 5] = Properties.Settings.Default.F5E3;
            Fach.Array[11, 6] = Properties.Settings.Default.F5E4;
            Fach.Array[12, 3] = Properties.Settings.Default.F6E1;
            Fach.Array[12, 4] = Properties.Settings.Default.F6E2;
            Fach.Array[12, 5] = Properties.Settings.Default.F6E3;
            Fach.Array[12, 6] = Properties.Settings.Default.F6E4;
            Fach.Array[13, 3] = Properties.Settings.Default.F7E1;
            Fach.Array[13, 4] = Properties.Settings.Default.F7E2;
            Fach.Array[13, 5] = Properties.Settings.Default.F7E3;
            Fach.Array[13, 6] = Properties.Settings.Default.F7E4;
            */
            tbF1S1.Text = Fach.Array[7, 0];
            tbF1S2.Text = Fach.Array[7, 1];
            tbF1S3.Text = Fach.Array[7, 2];
            tbF2S1.Text = Fach.Array[8, 0];
            tbF2S2.Text = Fach.Array[8, 1];
            tbF2S3.Text = Fach.Array[8, 2];
            tbF3S1.Text = Fach.Array[9, 0];
            tbF3S2.Text = Fach.Array[9, 1];
            tbF3S3.Text = Fach.Array[9, 2];
            tbF4S1.Text = Fach.Array[10, 0];
            tbF4S2.Text = Fach.Array[10, 1];
            tbF4S3.Text = Fach.Array[10, 2];
            tbF5S1.Text = Fach.Array[11, 0];
            tbF5S2.Text = Fach.Array[11, 1];
            tbF5S3.Text = Fach.Array[11, 2];
            tbF6S1.Text = Fach.Array[12, 0];
            tbF6S2.Text = Fach.Array[12, 1];
            tbF6S3.Text = Fach.Array[12, 2];
            tbF7S1.Text = Fach.Array[13, 0];
            tbF7S2.Text = Fach.Array[13, 1];
            tbF7S3.Text = Fach.Array[13, 2];

            // Stegreifaufgaben Laden
            tbF1E1.Text = Fach.Array[7, 3];
            tbF1E2.Text = Fach.Array[7, 4];
            tbF1E3.Text = Fach.Array[7, 5];
            tbF1E4.Text = Fach.Array[7, 6];
            tbF2E1.Text = Fach.Array[8, 3];
            tbF2E2.Text = Fach.Array[8, 4];
            tbF2E3.Text = Fach.Array[8, 5];
            tbF2E4.Text = Fach.Array[8, 6];
            tbF3E1.Text = Fach.Array[9, 3];
            tbF3E2.Text = Fach.Array[9, 4];
            tbF3E3.Text = Fach.Array[9, 5];
            tbF3E4.Text = Fach.Array[9, 6];
            tbF4E1.Text = Fach.Array[10, 3];
            tbF4E2.Text = Fach.Array[10, 4];
            tbF4E3.Text = Fach.Array[10, 5];
            tbF4E4.Text = Fach.Array[10, 6];
            tbF5E1.Text = Fach.Array[11, 3];
            tbF5E2.Text = Fach.Array[11, 4];
            tbF5E3.Text = Fach.Array[11, 5];
            tbF5E4.Text = Fach.Array[11, 6];
            tbF6E1.Text = Fach.Array[12, 3];
            tbF6E2.Text = Fach.Array[12, 4];
            tbF6E3.Text = Fach.Array[12, 5];
            tbF6E4.Text = Fach.Array[12, 6];
            tbF7E1.Text = Fach.Array[13, 3];
            tbF7E2.Text = Fach.Array[13, 4];
            tbF7E3.Text = Fach.Array[13, 5];
            tbF7E4.Text = Fach.Array[13, 6];


        }

        private void btnberechnen_Click(object sender, EventArgs e)
        {

            int Summe, Wert, i;
            double SummeS;
            string Ergebnis;
            i = 0;

            // Fach 1 Berechnung
            Wert = int.Parse(tbF1S1.Text);      // Convertieren
            if (Wert != 0)
            {
                i = i + 2;              // Notenzähler
            }
            Summe = Wert;
            Wert = int.Parse(tbF1S2.Text);
            if (Wert != 0)
            {
                i = i + 2;
            }
            Summe = Summe + Wert;
            Wert = int.Parse(tbF1S3.Text);
            if (Wert != 0)
            {
                i = i + 2;
            }
            Summe = Summe + Wert;
            SummeS = Summe * 2;       // Gewichtung


            Wert = int.Parse(tbF1E1.Text);
            if (Wert != 0)
            {
                i = i + 1;
            }
            Summe = Wert;
            Wert = int.Parse(tbF1E2.Text);
            if (Wert != 0)
            {
                i = i + 1;
            }
            Summe = Summe + Wert;
            Wert = int.Parse(tbF1E3.Text);
            if (Wert != 0)
            {
                i = i + 1;
            }
            Summe = Summe + Wert;
            Wert = int.Parse(tbF1E4.Text);
            if (Wert != 0)
            {
                i = i + 1;
            }
            Summe = Summe + Wert;

            SummeS = SummeS + Summe;
            SummeS = SummeS / i;                // durch Anzahl von Noten
            SummeS = Math.Round(SummeS, 2);     // nur 2 Dezimalstellen
            Ergebnis = SummeS.ToString();       // Convertieren zu String
            lblF1.Text = Ergebnis;              // Ergebnis anzeigen
            

            // Fach 2 Berechnung
            i = 0;
            Wert = int.Parse(tbF2S1.Text);
            if (Wert != 0)
            {
                i = i + 2;
            }
            Summe = Wert;
            Wert = int.Parse(tbF2S2.Text);
            if (Wert != 0)
            {
                i = i + 2;
            }
            Summe = Summe + Wert;
            Wert = int.Parse(tbF2S3.Text);
            if (Wert != 0)
            {
                i = i + 2;
            }
            Summe = Summe + Wert;
            SummeS = Summe * 2;


            Wert = int.Parse(tbF2E1.Text);
            if (Wert != 0)
            {
                i = i + 1;
            }
            Summe = Wert;
            Wert = int.Parse(tbF2E2.Text);
            if (Wert != 0)
            {
                i = i + 1;
            }
            Summe = Summe + Wert;
            Wert = int.Parse(tbF2E3.Text);
            if (Wert != 0)
            {
                i = i + 1;
            }
            Summe = Summe + Wert;
            Wert = int.Parse(tbF2E4.Text);
            if (Wert != 0)
            {
                i = i + 1;
            }
            Summe = Summe + Wert;
            SummeS = SummeS + Summe;
            SummeS = SummeS / i;
            SummeS = Math.Round(SummeS, 2);
            Ergebnis = SummeS.ToString();
            lblF2.Text = Ergebnis;

            // Fach 3 Berechnung
            i = 0;
            Wert = int.Parse(tbF3S1.Text);
            if (Wert != 0)
            {
                i = i + 2;
            }
            Summe = Wert;
            Wert = int.Parse(tbF3S2.Text);
            if (Wert != 0)
            {
                i = i + 2;
            }
            Summe = Summe + Wert;
            Wert = int.Parse(tbF3S3.Text);
            if (Wert != 0)
            {
                i = i + 2;
            }
            Summe = Summe + Wert;

            SummeS = Summe * 2;


            Wert = int.Parse(tbF3E1.Text);
            if (Wert != 0)
            {
                i = i + 1;
            }
            Summe = Wert;
            Wert = int.Parse(tbF3E2.Text);
            if (Wert != 0)
            {
                i = i + 1;
            }
            Summe = Summe + Wert;
            Wert = int.Parse(tbF3E3.Text);
            if (Wert != 0)
            {
                i = i + 1;
            }
            Summe = Summe + Wert;
            Wert = int.Parse(tbF3E4.Text);
            if (Wert != 0)
            {
                i = i + 1;
            }
            Summe = Summe + Wert;

            SummeS = SummeS + Summe;
            SummeS = SummeS / i;
            SummeS = Math.Round(SummeS, 2);
            Ergebnis = SummeS.ToString();
            lblF3.Text = Ergebnis;

            // Fach 4 Berechnung
            i = 0;
            Wert = int.Parse(tbF4S1.Text);
            if (Wert != 0)
            {
                i = i + 2;
            }
            Summe = Wert;
            Wert = int.Parse(tbF4S2.Text);
            if (Wert != 0)
            {
                i = i + 2;
            }
            Summe = Summe + Wert;
            Wert = int.Parse(tbF4S3.Text);
            if (Wert != 0)
            {
                i = i + 2;
            }
            Summe = Summe + Wert;

            SummeS = Summe * 2;


            Wert = int.Parse(tbF4E1.Text);
            if (Wert != 0)
            {
                i = i + 1;
            }
            Summe = Wert;
            Wert = int.Parse(tbF4E2.Text);
            if (Wert != 0)
            {
                i = i + 1;
            }
            Summe = Summe + Wert;
            Wert = int.Parse(tbF4E3.Text);
            if (Wert != 0)
            {
                i = i + 1;
            }
            Summe = Summe + Wert;
            Wert = int.Parse(tbF4E4.Text);
            if (Wert != 0)
            {
                i = i + 1;
            }
            Summe = Summe + Wert;

            SummeS = SummeS + Summe;
            SummeS = SummeS / i;
            SummeS = Math.Round(SummeS, 2);
            Ergebnis = SummeS.ToString();
            lblF4.Text = Ergebnis;

            // Fach 5
            i = 0;
            Wert = int.Parse(tbF5S1.Text);
            if (Wert != 0)
            {
                i = i + 2;
            }
            Summe = Wert;
            Wert = int.Parse(tbF5S2.Text);
            if (Wert != 0)
            {
                i = i + 2;
            }
            Summe = Summe + Wert;
            Wert = int.Parse(tbF5S3.Text);
            if (Wert != 0)
            {
                i = i + 2;
            }
            Summe = Summe + Wert;

            SummeS = Summe * 2;

            Wert = int.Parse(tbF5E1.Text);
            if (Wert != 0)
            {
                i = i + 1;
            }
            Summe = Wert;
            Wert = int.Parse(tbF5E2.Text);
            if (Wert != 0)
            {
                i = i + 1;
            }
            Summe = Summe + Wert;
            Wert = int.Parse(tbF5E3.Text);
            if (Wert != 0)
            {
                i = i + 1;
            }
            Summe = Summe + Wert;
            Wert = int.Parse(tbF5E4.Text);
            if (Wert != 0)
            {
                i = i + 1;
            }
            Summe = Summe + Wert;

            SummeS = SummeS + Summe;
            SummeS = SummeS / i;
            SummeS = Math.Round(SummeS, 2);
            Ergebnis = SummeS.ToString();
            lblF5.Text = Ergebnis;

            // Fach 6
            i = 0;
            Wert = int.Parse(tbF6S1.Text);
            if (Wert != 0)
            {
                i = i + 2;
            }
            Summe = Wert;
            Wert = int.Parse(tbF6S2.Text);
            if (Wert != 0)
            {
                i = i + 2;
            }
            Summe = Summe + Wert;
            Wert = int.Parse(tbF6S3.Text);
            if (Wert != 0)
            {
                i = i + 2;
            }
            Summe = Summe + Wert;

            SummeS = Summe * 2;


            Wert = int.Parse(tbF6E1.Text);
            if (Wert != 0)
            {
                i = i + 1;
            }
            Summe = Wert;
            Wert = int.Parse(tbF6E2.Text);
            if (Wert != 0)
            {
                i = i + 1;
            }
            Summe = Summe + Wert;
            Wert = int.Parse(tbF6E3.Text);
            if (Wert != 0)
            {
                i = i + 1;
            }
            Summe = Summe + Wert;
            Wert = int.Parse(tbF6E4.Text);
            if (Wert != 0)
            {
                i = i + 1;
            }
            Summe = Summe + Wert;

            SummeS = SummeS + Summe;
            SummeS = SummeS / i;
            SummeS = Math.Round(SummeS, 2);
            Ergebnis = SummeS.ToString();
            lblF6.Text = Ergebnis;

            // Fach 7
            i = 0;
            Wert = int.Parse(tbF7S1.Text);
            if (Wert != 0)
            {
                i = i + 2;
            }
            Summe = Wert;
            Wert = int.Parse(tbF7S2.Text);
            if (Wert != 0)
            {
                i = i + 2;
            }
            Summe = Summe + Wert;
            Wert = int.Parse(tbF7S3.Text);
            if (Wert != 0)
            {
                i = i + 2;
            }
            Summe = Summe + Wert;

            SummeS = Summe * 2;


            Wert = int.Parse(tbF7E1.Text);
            if (Wert != 0)
            {
                i = i + 1;
            }
            Summe = Wert;
            Wert = int.Parse(tbF7E2.Text);
            if (Wert != 0)
            {
                i = i + 1;
            }
            Summe = Summe + Wert;
            Wert = int.Parse(tbF7E3.Text);
            if (Wert != 0)
            {
                i = i + 1;
            }
            Summe = Summe + Wert;
            Wert = int.Parse(tbF7E4.Text);
            if (Wert != 0)
            {
                i = i + 1;
            }
            Summe = Summe + Wert;

            SummeS = SummeS + Summe;
            SummeS = SummeS / i;
            SummeS = Math.Round(SummeS, 2);
            Ergebnis = SummeS.ToString();
            lblF7.Text = Ergebnis;
        }

        private void buttonSpeichern_Click(object sender, EventArgs e)
        {
            data.NotenSchreiben();

            // Schulaufgaben Speichern
            // In Array speichern
            Fach.Array[7, 0] = tbF1S1.Text;
            Fach.Array[7, 1] = tbF1S2.Text;
            Fach.Array[7, 2] = tbF1S3.Text;
            Fach.Array[8, 0] = tbF2S1.Text;
            Fach.Array[8, 1] = tbF2S2.Text;
            Fach.Array[8, 2] = tbF2S3.Text;
            Fach.Array[9, 0] = tbF3S1.Text;
            Fach.Array[9, 1] = tbF3S2.Text;
            Fach.Array[9, 2] = tbF3S3.Text;
            Fach.Array[10, 0] = tbF4S1.Text;
            Fach.Array[10, 1] = tbF4S2.Text;
            Fach.Array[10, 2] = tbF4S3.Text;
            Fach.Array[11, 0] = tbF5S1.Text;
            Fach.Array[11, 1] = tbF5S2.Text;
            Fach.Array[11, 2] = tbF5S3.Text;
            Fach.Array[12, 0] = tbF6S1.Text;
            Fach.Array[12, 1] = tbF6S2.Text;
            Fach.Array[12, 2] = tbF6S3.Text;
            Fach.Array[13, 0] = tbF7S1.Text;
            Fach.Array[13, 1] = tbF7S2.Text;
            Fach.Array[13, 2] = tbF7S3.Text;


            // WIRD DURCH DATENBANK ERSETZT!
           /* Properties.Settings.Default.F1S1 = Fach.Array[7, 0];
            Properties.Settings.Default.F1S2 = Fach.Array[7, 1];
            Properties.Settings.Default.F1S3 = Fach.Array[7, 2];
            Properties.Settings.Default.F2S1 = Fach.Array[8, 0];
            Properties.Settings.Default.F2S2 = Fach.Array[8, 1];
            Properties.Settings.Default.F2S3 = Fach.Array[8, 2];
            Properties.Settings.Default.F3S1 = Fach.Array[9, 0];
            Properties.Settings.Default.F3S2 = Fach.Array[9, 1];
            Properties.Settings.Default.F3S3 = Fach.Array[9, 2];
            Properties.Settings.Default.F4S1 = Fach.Array[10, 0];
            Properties.Settings.Default.F4S2 = Fach.Array[10, 1];
            Properties.Settings.Default.F4S3 = Fach.Array[10, 2];
            Properties.Settings.Default.F5S1 = Fach.Array[11, 0];
            Properties.Settings.Default.F5S2 = Fach.Array[11, 1];
            Properties.Settings.Default.F5S3 = Fach.Array[11, 2];
            Properties.Settings.Default.F6S1 = Fach.Array[12, 0];
            Properties.Settings.Default.F6S2 = Fach.Array[12, 1];
            Properties.Settings.Default.F6S3 = Fach.Array[12, 2];
            Properties.Settings.Default.F7S1 = Fach.Array[13, 0];
            Properties.Settings.Default.F7S2 = Fach.Array[13, 1];
            Properties.Settings.Default.F7S3 = Fach.Array[13, 2];

            Properties.Settings.Default.F1E1 = Fach.Array[7, 3];
            Properties.Settings.Default.F1E2 = Fach.Array[7, 4];
            Properties.Settings.Default.F1E3 = Fach.Array[7, 5];
            Properties.Settings.Default.F1E4 = Fach.Array[7, 6];
            Properties.Settings.Default.F2E1 = Fach.Array[8, 3];
            Properties.Settings.Default.F2E2 = Fach.Array[8, 4];
            Properties.Settings.Default.F2E3 = Fach.Array[8, 5];
            Properties.Settings.Default.F2E4 = Fach.Array[8, 6];
            Properties.Settings.Default.F3E1 = Fach.Array[9, 3];
            Properties.Settings.Default.F3E2 = Fach.Array[9, 4];
            Properties.Settings.Default.F3E3 = Fach.Array[9, 5];
            Properties.Settings.Default.F3E4 = Fach.Array[9, 6];
            Properties.Settings.Default.F4E1 = Fach.Array[10, 3];
            Properties.Settings.Default.F4E2 = Fach.Array[10, 4];
            Properties.Settings.Default.F4E3 = Fach.Array[10, 5];
            Properties.Settings.Default.F4E4 = Fach.Array[10, 6];
            Properties.Settings.Default.F5E1 = Fach.Array[11, 3];
            Properties.Settings.Default.F5E2 = Fach.Array[11, 4];
            Properties.Settings.Default.F5E3 = Fach.Array[11, 5];
            Properties.Settings.Default.F5E4 = Fach.Array[11, 6];
            Properties.Settings.Default.F6E1 = Fach.Array[12, 3];
            Properties.Settings.Default.F6E2 = Fach.Array[12, 4];
            Properties.Settings.Default.F6E3 = Fach.Array[12, 5];
            Properties.Settings.Default.F6E4 = Fach.Array[12, 6];
            Properties.Settings.Default.F7E1 = Fach.Array[13, 3];
            Properties.Settings.Default.F7E2 = Fach.Array[13, 4];
            Properties.Settings.Default.F7E3 = Fach.Array[13, 5];
            Properties.Settings.Default.F7E4 = Fach.Array[13, 6];
            Properties.Settings.Default.Save();
        */

            // Stegreifaufgaben Speichern
            Fach.Array[7, 3] = tbF1E1.Text;
            Fach.Array[7, 4] = tbF1E2.Text;
            Fach.Array[7, 5] = tbF1E3.Text;
            Fach.Array[7, 6] = tbF1E4.Text;
            Fach.Array[8, 3] = tbF2E1.Text;
            Fach.Array[8, 4] = tbF2E2.Text;
            Fach.Array[8, 5] = tbF2E3.Text;
            Fach.Array[8, 6] = tbF2E4.Text;
            Fach.Array[9, 3] = tbF3E1.Text;
            Fach.Array[9, 4] = tbF3E2.Text;
            Fach.Array[9, 5] = tbF3E3.Text;
            Fach.Array[9, 6] = tbF3E4.Text;
            Fach.Array[10, 3] = tbF4E1.Text;
            Fach.Array[10, 4] = tbF4E2.Text;
            Fach.Array[10, 5] = tbF4E3.Text;
            Fach.Array[10, 6] = tbF4E4.Text;
            Fach.Array[11, 3] = tbF5E1.Text;
            Fach.Array[11, 4] = tbF5E2.Text;
            Fach.Array[11, 5] = tbF5E3.Text;
            Fach.Array[11, 6] = tbF5E4.Text;
            Fach.Array[12, 3] = tbF6E1.Text;
            Fach.Array[12, 4] = tbF6E2.Text;
            Fach.Array[12, 5] = tbF6E3.Text;
            Fach.Array[12, 6] = tbF6E4.Text;
            Fach.Array[13, 3] = tbF7E1.Text;
            Fach.Array[13, 4] = tbF7E2.Text;
            Fach.Array[13, 5] = tbF7E3.Text;
            Fach.Array[13, 6] = tbF7E4.Text;
           
 
        }

        private void btnende_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Wollen Sie wirklich Beenden?", "Sicher?", MessageBoxButtons.OKCancel, MessageBoxIcon.Error) == DialogResult.OK)
            {
                this.Close();
            }
    }

        private void TbF1S1_KeyPress(object sender, KeyPressEventArgs e)
        {
         char chr = e.KeyChar;
         if (!Char.IsDigit(chr) && chr != 8)
         {
         e.Handled = true;
         MessageBox.Show("Falsche Eingabe");
         }
        if (tbF1S1.Text.Length > 1)
            {
                MessageBox.Show("Falsche Eingabe");
                return;
            }
        }
        private void tbF1S2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char chr = e.KeyChar;
            if (!Char.IsDigit(chr) && chr != 8)
            {
                e.Handled = true;
                MessageBox.Show("Falsche Eingabe");
            }
        } 
        private void tbF1S3_KeyPress(object sender, KeyPressEventArgs e)
        {
            char chr = e.KeyChar;
            if (!Char.IsDigit(chr) && chr != 8)
            {
                e.Handled = true;
                MessageBox.Show("Falsche Eingabe");
            }
        }

        private void tbF1E1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char chr = e.KeyChar;
            if (!Char.IsDigit(chr) && chr != 8)
            {
                e.Handled = true;
                MessageBox.Show("Falsche Eingabe");
            }
        }

        private void tbF1E2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char chr = e.KeyChar;
            if (!Char.IsDigit(chr) && chr != 8)
            {
                e.Handled = true;
                MessageBox.Show("Falsche Eingabe");
            }
        }

        private void tbF1E3_KeyPress(object sender, KeyPressEventArgs e)
        {
            char chr = e.KeyChar;
            if (!Char.IsDigit(chr) && chr != 8)
            {
                e.Handled = true;
                MessageBox.Show("Falsche Eingabe");
            }
        }

        private void tbF1E4_KeyPress(object sender, KeyPressEventArgs e)
        {
            char chr = e.KeyChar;
            if (!Char.IsDigit(chr) && chr != 8)
            {
                e.Handled = true;
                MessageBox.Show("Falsche Eingabe");
            }
        }

        private void tbF2S1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char chr = e.KeyChar;
            if (!Char.IsDigit(chr) && chr != 8)
            {
                e.Handled = true;
                MessageBox.Show("Falsche Eingabe");
            }
        }

        private void tbF2S2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char chr = e.KeyChar;
            if (!Char.IsDigit(chr) && chr != 8)
            {
                e.Handled = true;
                MessageBox.Show("Falsche Eingabe");
            }
        }

        private void tbF2S3_KeyPress(object sender, KeyPressEventArgs e)
        {
            char chr = e.KeyChar;
            if (!Char.IsDigit(chr) && chr != 8)
            {
                e.Handled = true;
                MessageBox.Show("Falsche Eingabe");
            }
        }

        private void tbF2E1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char chr = e.KeyChar;
            if (!Char.IsDigit(chr) && chr != 8)
            {
                e.Handled = true;
                MessageBox.Show("Falsche Eingabe");
            }
        }

        private void tbF2E2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char chr = e.KeyChar;
            if (!Char.IsDigit(chr) && chr != 8)
            {
                e.Handled = true;
                MessageBox.Show("Falsche Eingabe");
            }
        }

        private void tbF2E3_KeyPress(object sender, KeyPressEventArgs e)
        {
            char chr = e.KeyChar;
            if (!Char.IsDigit(chr) && chr != 8)
            {
                e.Handled = true;
                MessageBox.Show("Falsche Eingabe");
            }
        }

        private void tbF2E4_KeyPress(object sender, KeyPressEventArgs e)
        {
            char chr = e.KeyChar;
            if (!Char.IsDigit(chr) && chr != 8)
            {
                e.Handled = true;
                MessageBox.Show("Falsche Eingabe");
            }
        }

        private void tbF3S1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char chr = e.KeyChar;
            if (!Char.IsDigit(chr) && chr != 8)
            {
                e.Handled = true;
                MessageBox.Show("Falsche Eingabe");
            }
        }

        private void tbF3S2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char chr = e.KeyChar;
            if (!Char.IsDigit(chr) && chr != 8)
            {
                e.Handled = true;
                MessageBox.Show("Falsche Eingabe");
            }
        }

        private void tbF3S3_KeyPress(object sender, KeyPressEventArgs e)
        {
            char chr = e.KeyChar;
            if (!Char.IsDigit(chr) && chr != 8)
            {
                e.Handled = true;
                MessageBox.Show("Falsche Eingabe");
            }
        }

        private void tbF3E1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char chr = e.KeyChar;
            if (!Char.IsDigit(chr) && chr != 8)
            {
                e.Handled = true;
                MessageBox.Show("Falsche Eingabe");
            }
        }

        private void tbF3E2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char chr = e.KeyChar;
            if (!Char.IsDigit(chr) && chr != 8)
            {
                e.Handled = true;
                MessageBox.Show("Falsche Eingabe");
            }
        }

        private void tbF3E3_KeyPress(object sender, KeyPressEventArgs e)
        {
            char chr = e.KeyChar;
            if (!Char.IsDigit(chr) && chr != 8)
            {
                e.Handled = true;
                MessageBox.Show("Falsche Eingabe");
            }
        }

        private void tbF3E4_KeyPress(object sender, KeyPressEventArgs e)
        {
            char chr = e.KeyChar;
            if (!Char.IsDigit(chr) && chr != 8)
            {
                e.Handled = true;
                MessageBox.Show("Falsche Eingabe");
            }
        }

        private void tbF4S1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char chr = e.KeyChar;
            if (!Char.IsDigit(chr) && chr != 8)
            {
                e.Handled = true;
                MessageBox.Show("Falsche Eingabe");
            }
        }

        private void tbF4S2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char chr = e.KeyChar;
            if (!Char.IsDigit(chr) && chr != 8)
            {
                e.Handled = true;
                MessageBox.Show("Falsche Eingabe");
            }
        }

        private void tbF4S3_KeyPress(object sender, KeyPressEventArgs e)
        {
            char chr = e.KeyChar;
            if (!Char.IsDigit(chr) && chr != 8)
            {
                e.Handled = true;
                MessageBox.Show("Falsche Eingabe");
            }
        }

        private void tbF4E1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char chr = e.KeyChar;
            if (!Char.IsDigit(chr) && chr != 8)
            {
                e.Handled = true;
                MessageBox.Show("Falsche Eingabe");
            }
        }

        private void tbF4E2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char chr = e.KeyChar;
            if (!Char.IsDigit(chr) && chr != 8)
            {
                e.Handled = true;
                MessageBox.Show("Falsche Eingabe");
            }
        }

        private void tbF4E3_KeyPress(object sender, KeyPressEventArgs e)
        {
            char chr = e.KeyChar;
            if (!Char.IsDigit(chr) && chr != 8)
            {
                e.Handled = true;
                MessageBox.Show("Falsche Eingabe");
            }
        }

        private void tbF4E4_KeyPress(object sender, KeyPressEventArgs e)
        {
            char chr = e.KeyChar;
            if (!Char.IsDigit(chr) && chr != 8)
            {
                e.Handled = true;
                MessageBox.Show("Falsche Eingabe");
            }
        }

        private void tbF5S1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char chr = e.KeyChar;
            if (!Char.IsDigit(chr) && chr != 8)
            {
                e.Handled = true;
                MessageBox.Show("Falsche Eingabe");
            }
        }

        private void tbF5S2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char chr = e.KeyChar;
            if (!Char.IsDigit(chr) && chr != 8)
            {
                e.Handled = true;
                MessageBox.Show("Falsche Eingabe");
            }
        }

        private void tbF5S3_KeyPress(object sender, KeyPressEventArgs e)
        {
            char chr = e.KeyChar;
            if (!Char.IsDigit(chr) && chr != 8)
            {
                e.Handled = true;
                MessageBox.Show("Falsche Eingabe");
            }
        }

        private void tbF5E1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char chr = e.KeyChar;
            if (!Char.IsDigit(chr) && chr != 8)
            {
                e.Handled = true;
                MessageBox.Show("Falsche Eingabe");
            }
        }

        private void tbF5E2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char chr = e.KeyChar;
            if (!Char.IsDigit(chr) && chr != 8)
            {
                e.Handled = true;
                MessageBox.Show("Falsche Eingabe");
            }
        }

        private void tbF5E3_KeyPress(object sender, KeyPressEventArgs e)
        {
            char chr = e.KeyChar;
            if (!Char.IsDigit(chr) && chr != 8)
            {
                e.Handled = true;
                MessageBox.Show("Falsche Eingabe");
            }
        }

        private void tbF5E4_KeyPress(object sender, KeyPressEventArgs e)
        {
            char chr = e.KeyChar;
            if (!Char.IsDigit(chr) && chr != 8)
            {
                e.Handled = true;
                MessageBox.Show("Falsche Eingabe");
            }
        }

        private void tbF6S1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char chr = e.KeyChar;
            if (!Char.IsDigit(chr) && chr != 8)
            {
                e.Handled = true;
                MessageBox.Show("Falsche Eingabe");
            }
        }

        private void tbF6S2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char chr = e.KeyChar;
            if (!Char.IsDigit(chr) && chr != 8)
            {
                e.Handled = true;
                MessageBox.Show("Falsche Eingabe");
            }
        }

        private void tbF6S3_KeyPress(object sender, KeyPressEventArgs e)
        {
            char chr = e.KeyChar;
            if (!Char.IsDigit(chr) && chr != 8)
            {
                e.Handled = true;
                MessageBox.Show("Falsche Eingabe");
            }
        }

        private void tbF6E1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char chr = e.KeyChar;
            if (!Char.IsDigit(chr) && chr != 8)
            {
                e.Handled = true;
                MessageBox.Show("Falsche Eingabe");
            }
        }

        private void tbF6E2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char chr = e.KeyChar;
            if (!Char.IsDigit(chr) && chr != 8)
            {
                e.Handled = true;
                MessageBox.Show("Falsche Eingabe");
            }
        }

        private void tbF6E3_KeyPress(object sender, KeyPressEventArgs e)
        {
            char chr = e.KeyChar;
            if (!Char.IsDigit(chr) && chr != 8)
            {
                e.Handled = true;
                MessageBox.Show("Falsche Eingabe");
            }
        }

        private void tbF6E4_KeyPress(object sender, KeyPressEventArgs e)
        {
            char chr = e.KeyChar;
            if (!Char.IsDigit(chr) && chr != 8)
            {
                e.Handled = true;
                MessageBox.Show("Falsche Eingabe");
            }
        }

        private void tbF7S1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char chr = e.KeyChar;
            if (!Char.IsDigit(chr) && chr != 8)
            {
                e.Handled = true;
                MessageBox.Show("Falsche Eingabe");
            }
        }

        private void tbF7S2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char chr = e.KeyChar;
            if (!Char.IsDigit(chr) && chr != 8)
            {
                e.Handled = true;
                MessageBox.Show("Falsche Eingabe");
            }
        }

        private void tbF7S3_KeyPress(object sender, KeyPressEventArgs e)
        {
            char chr = e.KeyChar;
            if (!Char.IsDigit(chr) && chr != 8)
            {
                e.Handled = true;
                MessageBox.Show("Falsche Eingabe");
            }
        }

        private void tbF7E1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char chr = e.KeyChar;
            if (!Char.IsDigit(chr) && chr != 8)
            {
                e.Handled = true;
                MessageBox.Show("Falsche Eingabe");
            }
        }

        private void tbF7E2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char chr = e.KeyChar;
            if (!Char.IsDigit(chr) && chr != 8)
            {
                e.Handled = true;
                MessageBox.Show("Falsche Eingabe");
            }
        }

        private void tbF7E3_KeyPress(object sender, KeyPressEventArgs e)
        {
            char chr = e.KeyChar;
            if (!Char.IsDigit(chr) && chr != 8)
            {
                e.Handled = true;
                MessageBox.Show("Falsche Eingabe");
            }
        }

        private void tbF7E4_KeyPress(object sender, KeyPressEventArgs e)
        {
            char chr = e.KeyChar;
            if (!Char.IsDigit(chr) && chr != 8)
            {
                e.Handled = true;
                MessageBox.Show("Falsche Eingabe");
            }
        }

        private void tbF1S1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

