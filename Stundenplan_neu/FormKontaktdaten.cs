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
    public partial class FormKontaktdaten : Form
    {
        Database data = new Database();
        public FormKontaktdaten()
        {
            InitializeComponent();
            data.Lesen();
            // lbl Fach mit den Werten aus dem Array befuellen
            LblFach1.Text = Fach.Array[0, 1];
            LblFach2.Text = Fach.Array[1, 1];
            LblFach3.Text = Fach.Array[2, 1];
            LblFach4.Text = Fach.Array[3, 1];
            LblFach5.Text = Fach.Array[4, 1];
            LblFach6.Text = Fach.Array[5, 1];
            LblFach7.Text = Fach.Array[6, 1];
            // lbl Lehrer mit den Werten aus dem Array befuellen
            LblLehrer1.Text = Fach.Array[0, 2];
            LblLehrer2.Text = Fach.Array[1, 2];
            LblLehrer3.Text = Fach.Array[2, 2];
            LblLehrer4.Text = Fach.Array[3, 2];
            LblLehrer5.Text = Fach.Array[4, 2];
            LblLehrer6.Text = Fach.Array[5, 2];
            LblLehrer7.Text = Fach.Array[6, 2];

            TxtBxFach1.Text = Fach.Array[0, 4];
            TxtBxFach2.Text = Fach.Array[1, 4];
            TxtBxFach3.Text = Fach.Array[2, 4];
            TxtBxFach4.Text = Fach.Array[0, 4];
            TxtBxFach5.Text = Fach.Array[0, 4];
            TxtBxFach6.Text = Fach.Array[0, 4];
            TxtBxFach7.Text = Fach.Array[0, 4];
            // lbl Kontaktdaten mit den Werten aus dem Array befuellen
            /*Fach.Array[0, 4] = Properties.Settings.Default.Array04;
            Fach.Array[1, 4] = Properties.Settings.Default.Array14;
            Fach.Array[2, 4] = Properties.Settings.Default.Array24;
            Fach.Array[3, 4] = Properties.Settings.Default.Array34;
            Fach.Array[4, 4] = Properties.Settings.Default.Array44;
            Fach.Array[5, 4] = Properties.Settings.Default.Array54;
            Fach.Array[6, 4] = Properties.Settings.Default.Array64;*/

            /*LblKontaktdaten1.Text = Fach.Array[0, 4];
            LblKontaktdaten2.Text = Fach.Array[1, 4];
            LblKontaktdaten3.Text = Fach.Array[2, 4];
            LblKontaktdaten4.Text = Fach.Array[3, 4];
            LblKontaktdaten5.Text = Fach.Array[4, 4];
            LblKontaktdaten6.Text = Fach.Array[5, 4];
            LblKontaktdaten7.Text = Fach.Array[6, 4];*/

            Visibility();

        }

        private void BtnKontakdateneintragen_Click(object sender, EventArgs e)
        {
            //Mit den Kontaktdaten befuellen
            /*TxtBxFach1.Text = Fach.Array[0, 4];
            TxtBxFach2.Text = Fach.Array[1, 4];
            TxtBxFach3.Text = Fach.Array[2, 4];
            TxtBxFach4.Text = Fach.Array[0, 4];
            TxtBxFach5.Text = Fach.Array[0, 4];
            TxtBxFach6.Text = Fach.Array[0, 4];
            TxtBxFach7.Text = Fach.Array[0, 4];*/

            Fach.Array[0, 4] = TxtBxFach1.Text;
            Fach.Array[1, 4] = TxtBxFach2.Text;
            Fach.Array[2, 4] = TxtBxFach3.Text;
            Fach.Array[3, 4] = TxtBxFach4.Text;
            Fach.Array[4, 4] = TxtBxFach5.Text;
            Fach.Array[5, 4] = TxtBxFach6.Text;
            Fach.Array[6, 4] = TxtBxFach7.Text;

            /*
            Properties.Settings.Default.Array04 = Fach.Array[0, 4];
            Properties.Settings.Default.Array04 = Fach.Array[1, 4];
            Properties.Settings.Default.Array04 = Fach.Array[2, 4];
            Properties.Settings.Default.Array04 = Fach.Array[3, 4];
            Properties.Settings.Default.Array04 = Fach.Array[4, 4];
            Properties.Settings.Default.Array04 = Fach.Array[5, 4];
            Properties.Settings.Default.Array04 = Fach.Array[6, 4];*/
 
            //Label Kontakdaten  mit den Werten aus dem Array befuellen
            /*LblKontaktdaten1.Text = Fach.Array[0, 4];
            LblKontaktdaten2.Text = Fach.Array[1, 4];
            LblKontaktdaten3.Text = Fach.Array[2, 4];
            LblKontaktdaten4.Text = Fach.Array[3, 4];
            LblKontaktdaten5.Text = Fach.Array[4, 4];
            LblKontaktdaten6.Text = Fach.Array[5, 4]; 
            LblKontaktdaten7.Text = Fach.Array[6, 4];*/

            data.Schreiben();
            MessageBox.Show("Kontakdaten eingetragen");
            data.Lesen();
            Visibility();
        }

        private void Visibility()
        {
            if (string.IsNullOrEmpty(LblFach1.Text))
            {
                TxtBxFach1.Visible = false;
            }
            else
            {
                TxtBxFach1.Visible = true;
            }
            if (string.IsNullOrEmpty(LblFach2.Text))
            {
                TxtBxFach2.Visible = false;
            }
            else
            {
                TxtBxFach2.Visible = true;
            }
            if (string.IsNullOrEmpty(LblFach3.Text))
            {
                TxtBxFach3.Visible = false;
            }
            else
            {
                TxtBxFach3.Visible = true;
            }
            if (string.IsNullOrEmpty(LblFach4.Text))
            {
                TxtBxFach4.Visible = false;
            }
            else
            {
                TxtBxFach4.Visible = true;
            }
            if (string.IsNullOrEmpty(LblFach5.Text))
            {
                TxtBxFach5.Visible = false;
            }
            else
            {
                TxtBxFach5.Visible = true;
            }
            if (string.IsNullOrEmpty(LblFach6.Text))
            {
                TxtBxFach6.Visible = false;
            }
            else
            {
                TxtBxFach6.Visible = true;
            }
            if (string.IsNullOrEmpty(LblFach7.Text))
            {
                TxtBxFach7.Visible = false;
            }
            else
            {
                TxtBxFach7.Visible = true;
            }
        }
        private void BtnBeenden_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Wollen Sie wirklich Beenden?", "Sicher?", MessageBoxButtons.OKCancel, MessageBoxIcon.Error) == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}
