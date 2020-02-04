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
    public partial class FormHilfe : Form
    {
        public FormHilfe()
        {
            InitializeComponent();
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

        private void btnNotizen_Click_1(object sender, EventArgs e)
        {
            txtInfo.Text = "Um sich Notizen für die einzelenen Fächer anzeigen zu lassen, wählen Sie das enstrepchende Fach aus";
        }

        private void btnCredits_Click_1(object sender, EventArgs e)
        {
            txtInfo.Text = "Sebastian Bär; Marvin Graphics; Johannes Stenglein; Mike Juraszczyk";
        }

        private void btnBeenden_Click_1(object sender, EventArgs e)
        {
            if ((MessageBox.Show("Möchten Sie wirklich Beenden?", "Hilfe", MessageBoxButtons.YesNo)) == DialogResult.Yes)
            {
                this.Close();

            }
            else
            {

            }
        }

        private void btnNotenberechnung_Click(object sender, EventArgs e)
        {
            txtInfo.Text = "Wenn Sie sich Ihren Notenschnitt ausrechnen lassen wollen, drücken Sie den Button Notenberechnung auf der Hauptseite.";
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            txtInfo.Text = "Mit Hilfe des Info Buttons können Sie sich eine Notiz abspeichern";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtInfo.Text = "Über die Kontaktdaten können Sie die E-Mail Adressen der Dozenten hinzufügen";
        }
    }
}
