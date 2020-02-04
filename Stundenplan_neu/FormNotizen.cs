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
    public partial class FormNotizen : Form
    {
        public FormNotizen()
        {
            InitializeComponent();

            if (string.IsNullOrEmpty(Fach.ArrayNn[Fach.zahler])) // Bei nicht eingetragenem Array "Keine Notiz" anzeigen
            {
                lblNotiz.Text = "Keine Notiz";
            }
            else
            {
                lblNotiz.Text = Fach.ArrayNn[Fach.zahler];
            }

            lblNotiz.Text = Fach.ArrayNn[Fach.zahler];

        }

        private void btnSpeichern_Click(object sender, EventArgs e)
        {
            Fach.ArrayNn[Fach.zahler] = txtNotzEing.Text;
            lblNotiz.Text = Fach.ArrayNn[Fach.zahler];
            Properties.Settings.Default.ArrayNo0 = Fach.ArrayNn[0];
            Properties.Settings.Default.ArrayNo0 = Fach.ArrayNn[1];
            Properties.Settings.Default.ArrayNo0 = Fach.ArrayNn[2];
            Properties.Settings.Default.ArrayNo0 = Fach.ArrayNn[3];
            Properties.Settings.Default.ArrayNo0 = Fach.ArrayNn[4];
            Properties.Settings.Default.ArrayNo0 = Fach.ArrayNn[5];
            Properties.Settings.Default.ArrayNo0 = Fach.ArrayNn[6];
            Properties.Settings.Default.ArrayNo0 = Fach.ArrayNn[7];
            Properties.Settings.Default.ArrayNo0 = Fach.ArrayNn[8];
            Properties.Settings.Default.ArrayNo0 = Fach.ArrayNn[9];
            Properties.Settings.Default.ArrayNo0 = Fach.ArrayNn[10];
            Properties.Settings.Default.ArrayNo0 = Fach.ArrayNn[11];
            Properties.Settings.Default.ArrayNo0 = Fach.ArrayNn[12];
            Properties.Settings.Default.ArrayNo0 = Fach.ArrayNn[13];
            Properties.Settings.Default.ArrayNo0 = Fach.ArrayNn[14];
            Properties.Settings.Default.ArrayNo0 = Fach.ArrayNn[15];
            Properties.Settings.Default.ArrayNo0 = Fach.ArrayNn[16];
            Properties.Settings.Default.ArrayNo0 = Fach.ArrayNn[17];
            Properties.Settings.Default.ArrayNo0 = Fach.ArrayNn[18];
            Properties.Settings.Default.ArrayNo0 = Fach.ArrayNn[19];
            Properties.Settings.Default.ArrayNo0 = Fach.ArrayNn[20];
            Properties.Settings.Default.ArrayNo0 = Fach.ArrayNn[21];
            Properties.Settings.Default.ArrayNo0 = Fach.ArrayNn[22];
            Properties.Settings.Default.ArrayNo0 = Fach.ArrayNn[23];
            Properties.Settings.Default.ArrayNo0 = Fach.ArrayNn[24];
            Properties.Settings.Default.ArrayNo0 = Fach.ArrayNn[25];
            Properties.Settings.Default.ArrayNo0 = Fach.ArrayNn[26];
            Properties.Settings.Default.ArrayNo0 = Fach.ArrayNn[27];
            Properties.Settings.Default.ArrayNo0 = Fach.ArrayNn[28];
            Properties.Settings.Default.ArrayNo0 = Fach.ArrayNn[29];
            Properties.Settings.Default.ArrayNo0 = Fach.ArrayNn[30];
            Properties.Settings.Default.ArrayNo0 = Fach.ArrayNn[31];
            Properties.Settings.Default.ArrayNo0 = Fach.ArrayNn[32];
            Properties.Settings.Default.ArrayNo0 = Fach.ArrayNn[33];
            Properties.Settings.Default.ArrayNo0 = Fach.ArrayNn[34];
            Properties.Settings.Default.ArrayNo0 = Fach.ArrayNn[35];
            Properties.Settings.Default.ArrayNo0 = Fach.ArrayNn[36];
            Properties.Settings.Default.ArrayNo0 = Fach.ArrayNn[37];
            Properties.Settings.Default.ArrayNo0 = Fach.ArrayNn[38];
            Properties.Settings.Default.ArrayNo0 = Fach.ArrayNn[39];
            Properties.Settings.Default.ArrayNo0 = Fach.ArrayNn[40];
            Properties.Settings.Default.ArrayNo0 = Fach.ArrayNn[41];
            Properties.Settings.Default.ArrayNo0 = Fach.ArrayNn[42];
            Properties.Settings.Default.ArrayNo0 = Fach.ArrayNn[43];
            Properties.Settings.Default.ArrayNo0 = Fach.ArrayNn[44];
            Properties.Settings.Default.ArrayNo0 = Fach.ArrayNn[45];
            Properties.Settings.Default.ArrayNo0 = Fach.ArrayNn[46];
            Properties.Settings.Default.ArrayNo0 = Fach.ArrayNn[47];
        }

        private void btnBeenden_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("Möchten Sie wirklich Beenden?", "Hilfe", MessageBoxButtons.YesNo)) == DialogResult.Yes)
            {
                this.Close();

            }
            else
            {

            }
        }

        private void btnLoeschen_Click(object sender, EventArgs e)
        {
            lblNotiz.Text = "";

        }

        private void FormNotizen_Load(object sender, EventArgs e)
        {

        }
    }
}
