using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//private System.Windows.Forms.Form f = System.Windows.Forms.Application.OpenForms["Form1"];

namespace Stundenplan_neu
{
    public partial class FormEditor : Form
    {
        Database data = new Database();

        Form1 form1;
        // liste fuer die Faecher erstellen
        //List<string> Faecherlist = new List<string>();
        
        public FormEditor(Form1 form_1)
        {
            InitializeComponent();
            form1 = form_1;
            // Daten von Datenbank ins Array einlesen
            //ArrayList statistikListe = new DatenModel().lesen();
            //ArrayList statistikListe = new DatenModel().lesen();
            data.Lesen();
            // Die Liste mit der Methode aktualisieren
            refreshFaecher();
            Listeneuerstellen();
            refreshList();
            // Den Zaehler +1 setzen um die Zahl im Label richtig zu setzen
            int k = Fach.zaehler + 1;
            LblFach.Text = "Fach " + k + " von 7";
            //leeren Eintrag fuer Liste erstellen


        }

        private void BtnFachhinzufuegen_Click(object sender, EventArgs e)
        {
            int x = 0;
            int i = Fach.zaehler;
            // Die eingegeben Werte aus den Textboxen holen
            string name = txbFachname.Text;
            string lehrer = txbLehrer.Text;
            string raum = txbRaum.Text;

            if (System.Text.RegularExpressions.Regex.IsMatch(txbRaum.Text, "[ ^ 0-9]"))
            {
                x = 1;
            }
        
                //Falss ein Wert vergessen wurde
                if (name == "")
                {
                    MessageBox.Show("Feld Name ist leer");
                    return;
                }
                else if (txbFachname.Text.Length > 12)
                {
                    MessageBox.Show("Fachname zu lange");
                    return;
                }
                else if (System.Text.RegularExpressions.Regex.IsMatch(txbFachname.Text, "[ ^ 0-9]"))
                {
                    MessageBox.Show("Bitte keinen Nummerischen Fachnnamen eintragen");
                    return;
                }
                else if (lehrer == "")
                {
                    MessageBox.Show("Feld Lehrer ist leer");
                    return;
                }
                else if (txbLehrer.Text.Length > 14)
                {
                    MessageBox.Show("Lehrername zu lange");
                    return;
                }
                else if (System.Text.RegularExpressions.Regex.IsMatch(txbLehrer.Text, "[ ^ 0-9]"))
                {
                    MessageBox.Show("Bitte keinen Nummerischen Lehrernamen eintragen");
                    return;
                }
                else if (raum == "")
                {
                    MessageBox.Show("Feld Raum ist leer");
                    return; 
                }
                else if (x != 1)
                {
                    MessageBox.Show("Bitte Nummmerischen Wert eintragen");
                    return;
                }
                else if (txbFachname.Text.Length > 8)
                {
                    MessageBox.Show("Raumname zu lange");
                     return;
                }
            else
                        {
                            //Maximal 7 Eintrage
                            if (i <= 6)
                            {
                                // Fach x nach abspeichern im Label anzeigen 
                                int k = i + 2;
                                LblFach.Text = "Fach " + k + " von 7";
                                // fuer die Nummerierung  
                                string s = Convert.ToString(i);

                                // Im Array die Felder zuweisen
                                Fach.Array[i, 1] = name;
                                Fach.Array[i, 2] = lehrer;
                                Fach.Array[i, 3] = raum;
                                Fach.Array[i, 0] = s;
                                // In die Liste die Namenswerte eintragen
                                Fach.Faecherlist.Add(Fach.Array[i, 1]);
                                // Fuer die Auflistung im loeschen Button (mit Nummer)
                                //comboBox46.Items.Add(Fach.Array[i, 0] + ". " + Fach.Array[i, 1]);
                                // Itemlist aktualisieren
                                data.Schreiben();
                                data.Lesen();
                                refreshList();
                                refreshFaecher();
                                // Liste aktualisieren
                                i++;
                                Fach.zaehler++;
                                // Info das ein neues Fach erstellt worden ist
                                MessageBox.Show("Fach hinzugefuegt");

                            }
                            else
                            {
                                //Fehlermeldung wenn zuviele Faecher erstellt worden sind
                                MessageBox.Show("Zuviele Faecher, bitte mindestens eins loeschen");
                                return;
                         }
                        }
            

        } 

        private void BtnFachereintragen_Click(object sender, EventArgs e)
        {
            // Werte an die Buttons uebergeben (Buttons sind public)
            form1.BtnMo1.Text = CmbBxMo1.Text;
            form1.BtnMo2.Text = CmbBxMo2.Text;
            form1.BtnMo3.Text = CmbBxMo3.Text;
            form1.BtnMo4.Text = CmbBxMo4.Text;
            form1.BtnMo5.Text = CmbBxMo5.Text;
            form1.BtnMo6.Text = CmbBxMo6.Text;
            form1.BtnMo7.Text = CmbBxMo7.Text;
            form1.BtnMo8.Text = CmbBxMo8.Text;
            form1.BtnMo9.Text = CmbBxMo9.Text;
            form1.BtnDi1.Text = CmbBxDi1.Text;
            form1.BtnDi2.Text = CmbBxDi2.Text;
            form1.BtnDi3.Text = CmbBxDi3.Text;
            form1.BtnDi4.Text = CmbBxDi4.Text;
            form1.BtnDi5.Text = CmbBxDi5.Text;
            form1.BtnDi6.Text = CmbBxDi6.Text;
            form1.BtnDi7.Text = CmbBxDi7.Text;
            form1.BtnDi8.Text = CmbBxDi8.Text;
            form1.BtnDi9.Text = CmbBxDi9.Text;
            form1.BtnMi1.Text = CmbBxMi1.Text;
            form1.BtnMi2.Text = CmbBxMi2.Text;
            form1.BtnMi3.Text = CmbBxMi3.Text;
            form1.BtnMi4.Text = CmbBxMi4.Text;
            form1.BtnMi5.Text = CmbBxMi5.Text;
            form1.BtnMi6.Text = CmbBxMi6.Text;
            form1.BtnMi7.Text = CmbBxMi7.Text;
            form1.BtnMi8.Text = CmbBxMi8.Text;
            form1.BtnMi9.Text = CmbBxMi9.Text;
            form1.BtnDo1.Text = CmbBxDo1.Text;
            form1.BtnDo2.Text = CmbBxDo3.Text;
            form1.BtnDo3.Text = CmbBxDo2.Text;
            form1.BtnDo4.Text = CmbBxDo4.Text;
            form1.BtnDo5.Text = CmbBxDo5.Text;
            form1.BtnDo6.Text = CmbBxDo6.Text;
            form1.BtnDo7.Text = CmbBxDo7.Text;
            form1.BtnDo8.Text = CmbBxDo9.Text;
            form1.BtnDo9.Text = CmbBxDo8.Text;
            form1.BtnFr1.Text = CmbBxFr1.Text;
            form1.BtnFr2.Text = CmbBxFr2.Text;
            form1.BtnFr3.Text = CmbBxFr3.Text;
            form1.BtnFr4.Text = CmbBxFr4.Text;
            form1.BtnFr5.Text = CmbBxFr5.Text;
            form1.BtnFr6.Text = CmbBxFr6.Text;
            form1.BtnFr7.Text = CmbBxFr7.Text;
            form1.BtnFr8.Text = CmbBxFr8.Text;
            form1.BtnFr9.Text = CmbBxFr9.Text;

            /* Buttons speichern
            Properties.Settings.Default.Mo1 = form1.BtnMo1.Text;
            Properties.Settings.Default.Mo2 = form1.BtnMo2.Text;
            Properties.Settings.Default.Mo3 = form1.BtnMo3.Text;
            Properties.Settings.Default.Mo4 = form1.BtnMo4.Text;
            Properties.Settings.Default.Mo5 = form1.BtnMo5.Text;
            Properties.Settings.Default.Mo6 = form1.BtnMo6.Text;
            Properties.Settings.Default.Mo7 = form1.BtnMo7.Text;
            Properties.Settings.Default.Mo8 = form1.BtnMo8.Text;
            Properties.Settings.Default.Mo9 = form1.BtnMo9.Text;

            Properties.Settings.Default.Di1 = form1.BtnDi1.Text;
            Properties.Settings.Default.Di2 = form1.BtnDi2.Text;
            Properties.Settings.Default.Di3 = form1.BtnDi3.Text;
            Properties.Settings.Default.Di4 = form1.BtnDi4.Text;
            Properties.Settings.Default.Di5 = form1.BtnDi5.Text;
            Properties.Settings.Default.Di6 = form1.BtnDi6.Text;
            Properties.Settings.Default.Di7 = form1.BtnDi7.Text;
            Properties.Settings.Default.Di8 = form1.BtnDi8.Text;
            Properties.Settings.Default.Di9 = form1.BtnDi9.Text;

            Properties.Settings.Default.Mi1 = form1.BtnMi1.Text;
            Properties.Settings.Default.Mi2 = form1.BtnMi2.Text;
            Properties.Settings.Default.Mi3 = form1.BtnMi3.Text;
            Properties.Settings.Default.Mi4 = form1.BtnMi4.Text;
            Properties.Settings.Default.Mi5 = form1.BtnMi5.Text;
            Properties.Settings.Default.Mi6 = form1.BtnMi6.Text;
            Properties.Settings.Default.Mi7 = form1.BtnMi7.Text;
            Properties.Settings.Default.Mi8 = form1.BtnMi8.Text;
            Properties.Settings.Default.Mi9 = form1.BtnMi9.Text;

            Properties.Settings.Default.Do1 = form1.BtnDo1.Text;
            Properties.Settings.Default.Do2 = form1.BtnDo2.Text;
            Properties.Settings.Default.Do3 = form1.BtnDo3.Text;
            Properties.Settings.Default.Do4 = form1.BtnDo4.Text;
            Properties.Settings.Default.Do5 = form1.BtnDo5.Text;
            Properties.Settings.Default.Do6 = form1.BtnDo6.Text;
            Properties.Settings.Default.Do7 = form1.BtnDo7.Text;
            Properties.Settings.Default.Do8 = form1.BtnDo8.Text;
            Properties.Settings.Default.Do9 = form1.BtnDo9.Text;

            Properties.Settings.Default.Fr1 = form1.BtnFr1.Text;
            Properties.Settings.Default.Fr2 = form1.BtnFr2.Text;
            Properties.Settings.Default.Fr3 = form1.BtnFr3.Text;
            Properties.Settings.Default.Fr4 = form1.BtnFr4.Text;
            Properties.Settings.Default.Fr5 = form1.BtnFr5.Text;
            Properties.Settings.Default.Fr6 = form1.BtnFr6.Text;
            Properties.Settings.Default.Fr7 = form1.BtnFr7.Text;
            Properties.Settings.Default.Fr8 = form1.BtnFr8.Text;
            Properties.Settings.Default.Fr9 = form1.BtnFr9.Text;

            // Arrays speichern
            Properties.Settings.Default.Array01 = Fach.Array[0, 1];
            Properties.Settings.Default.Array02 = Fach.Array[0, 2];
            Properties.Settings.Default.Array03 = Fach.Array[0, 3];

            Properties.Settings.Default.Array11 = Fach.Array[1, 1];
            Properties.Settings.Default.Array12 = Fach.Array[1, 2];
            Properties.Settings.Default.Array13 = Fach.Array[1, 3];

            Properties.Settings.Default.Array21 = Fach.Array[2, 1];
            Properties.Settings.Default.Array22 = Fach.Array[2, 2];
            Properties.Settings.Default.Array23 = Fach.Array[2, 3];

            Properties.Settings.Default.Array31 = Fach.Array[3, 1];
            Properties.Settings.Default.Array32 = Fach.Array[3, 2];
            Properties.Settings.Default.Array33 = Fach.Array[3, 3];

            Properties.Settings.Default.Array41 = Fach.Array[4, 1];
            Properties.Settings.Default.Array42 = Fach.Array[4, 2];
            Properties.Settings.Default.Array43 = Fach.Array[4, 3];

            Properties.Settings.Default.Array51 = Fach.Array[5, 1];
            Properties.Settings.Default.Array52 = Fach.Array[5, 2];
            Properties.Settings.Default.Array53 = Fach.Array[5, 3];

            Properties.Settings.Default.Array61 = Fach.Array[6, 1];
            Properties.Settings.Default.Array62 = Fach.Array[6, 2];
            Properties.Settings.Default.Array63 = Fach.Array[6, 3];
            Properties.Settings.Default.Save();*/
        }
        private void BtnClear_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Wollen Sie wirklich ALLES loeschen?", "Sicher?", MessageBoxButtons.OKCancel, MessageBoxIcon.Error) == DialogResult.OK)
            {
                LblFach.Text = "Fach 1 von 7";
                Fach.Faecherlist.Clear();
                //Cache loeschen und "refreshen"
                
                Fach.Faecherlist.Add("");
                //Zaehler wieder auf Null setzen
                Fach.zaehler = 0;
                //Werte im Array auf null setzen
                for (int x = 0; x < 7; x++)
                {
                    Fach.Array[x, 0] = null;
                    Fach.Array[x, 1] = null;
                    Fach.Array[x, 2] = null;
                    Fach.Array[x, 3] = null;
                    Fach.Array[x, 4] = null;
                }
                data.Schreiben();
                data.Lesen();
                refreshList();
                refreshFaecher();
            }
        }
        

        public void refreshFaecher()
        {
            //Die Textboxen mit den Eintragen von Fach/Lehrer/Raum aktualisieren
            TextBox[,] Textboxarray = new TextBox[7, 3] { { TxtBxFach1, TxtBxLehrer1, TxtBxRaum1 }, { TxtBxFach2, TxtBxLehrer2, TxtBxRaum2 }, { TxtBxFach3, TxtBxLehrer3, TxtBxRaum3 }, { TxtBxFach4, TxtBxLehrer4, TxtBxRaum4 }, { TxtBxFach5, TxtBxLehrer5, TxtBxRaum5 }, { TxtBxFach6, TxtBxLehrer6, TxtBxRaum6}, { TxtBxFach7, TxtBxLehrer7, TxtBxRaum7 } };
            for (int x = 0; x < 7; x++)
            {
                //Wert von den Textboxen mit dennen vom array abgleichen
                Textboxarray[x, 0].Text = Fach.Array[x,1];
                Textboxarray[x, 1].Text = Fach.Array[x,2];
                Textboxarray[x, 2].Text = Fach.Array[x,3];
            }
            data.Lesen();
        }
        public void refreshList()
        {
           
            ComboBox[] Comboboxarray = new ComboBox[45] { CmbBxMo1, CmbBxMo2, CmbBxMo3, CmbBxMo4, CmbBxMo5, CmbBxMo6, CmbBxMo7, CmbBxMo8, CmbBxMo9, CmbBxDi1, CmbBxDi2, CmbBxDi3, CmbBxDi4, CmbBxDi5, CmbBxDi6, CmbBxDi7, CmbBxDi8, CmbBxDi9, CmbBxMi1, CmbBxMi2, CmbBxMi3, CmbBxMi4, CmbBxMi5, CmbBxMi6, CmbBxMi7, CmbBxMi8, CmbBxMi9, CmbBxDo1, CmbBxDo2, CmbBxDo3, CmbBxDo4, CmbBxDo5, CmbBxDo6, CmbBxDo7, CmbBxDo8, CmbBxDo9, CmbBxFr1, CmbBxFr2, CmbBxFr3, CmbBxFr4, CmbBxFr5, CmbBxFr6, CmbBxFr7, CmbBxFr8, CmbBxFr9 };
            for(int x=0; x<45;x++)
            {
                //Die Erstellte Faecherliste mit der Combobox abgleichen 
                Comboboxarray[x].DataSource= Fach.Faecherlist.ToList();
            }
           
        }

        private void BtnAktualisieren_Click(object sender, EventArgs e)
        {
            data.Lesen();
            refreshFaecher();
            Listeneuerstellen();
            refreshList();
        }


        private void BtnAendern_Click(object sender, EventArgs e)
        {
            int q = 0;
            TextBox[,] Textboxarray = new TextBox[7, 3] { { TxtBxFach1, TxtBxLehrer1, TxtBxRaum1 }, { TxtBxFach2, TxtBxLehrer2, TxtBxRaum2 }, { TxtBxFach3, TxtBxLehrer3, TxtBxRaum3 }, { TxtBxFach4, TxtBxLehrer4, TxtBxRaum4 }, { TxtBxFach5, TxtBxLehrer5, TxtBxRaum5 }, { TxtBxFach6, TxtBxLehrer6, TxtBxRaum6 }, { TxtBxFach7, TxtBxLehrer7, TxtBxRaum7 } };
            for (int x = 0; x < 7; x++)
            {
                
                int h = 0;
                if (System.Text.RegularExpressions.Regex.IsMatch(Textboxarray[x, 2].Text, "[ ^ 0-9]"))
                {
                        h = 1;
                }
                if ((string.IsNullOrEmpty(Textboxarray[x, 0].Text)) && (string.IsNullOrEmpty(Textboxarray[x, 1].Text)) && (string.IsNullOrEmpty(Textboxarray[x, 2].Text)))
                {
                    return;
                }
                else if ((string.IsNullOrEmpty(Textboxarray[x, 0].Text)) || (string.IsNullOrEmpty(Textboxarray[x, 1].Text)) || (string.IsNullOrEmpty(Textboxarray[x, 2].Text)))
                {
                    MessageBox.Show("Eines oder mehrere Felder sind leer");
                    return;
                }
                else if (Textboxarray[x, 0].Text.Length > 12)
                {
                    MessageBox.Show("Fachname zu lange");
                    return;
                }
                else if (Textboxarray[x, 1].Text.Length > 14)
                {
                    MessageBox.Show("Lehrername zu lange");
                    return;
                }
                else if (Textboxarray[x, 2].Text.Length > 8)
                {
                    MessageBox.Show("Raumname zu lange");
                    return;
                }
                else if (System.Text.RegularExpressions.Regex.IsMatch(Textboxarray[x, 0].Text, "[ ^ 0-9]"))
                {
                    MessageBox.Show("Bitte keinen Nummerischen Fachnnamen eintragen");
                    return;
                }
                else if (System.Text.RegularExpressions.Regex.IsMatch(Textboxarray[x, 1].Text, "[ ^ 0-9]"))
                {
                    MessageBox.Show("Bitte keinen Nummerischen Lehrernamen eintragen");
                    return;
                }
                else if (h != 1)
                {
                    MessageBox.Show("Bitte Nummmerischen Raumwert eintragen");
                    return;
                }
                else
                {
                    // Werte der Textboxen ins Array eintragen
                    Fach.Array[x, 1] = Textboxarray[x, 0].Text;
                    Fach.Array[x, 2] = Textboxarray[x, 1].Text;
                    Fach.Array[x, 3] = Textboxarray[x, 2].Text;
                    if( q== 0)
                    {
                        MessageBox.Show("Aenderungen gemacht");
                        q++;
                    }
                    if(x==6)
                    {
                        data.Schreiben();
                        data.Lesen();
                        refreshFaecher();
                        Listeneuerstellen();
                        refreshList();
                    }

                }
            }
            //Alles aktualisieren
           // refreshFaecher();
            //Listeneuerstellen();
            //refreshList();
            //MessageBox.Show("Aenderungen gemacht");

        } 
        public void Listeneuerstellen()
        {
            Fach.Faecherlist.Clear();
            //Cache loeschen und "refreshen"
            refreshList();
            // leeres Fach fuer erste Zeile einfuegen
            Fach.Faecherlist.Add("");
            for (int i = 0; i < 7; i++)
            {
                //wenn String nicht leer ist dann Fach in die Liste hinzufuegen
                if (string.IsNullOrEmpty(Fach.Array[i,1]))
                {
                    
                }
                else
                {
                    Fach.Faecherlist.Add(Fach.Array[i, 1]); 
                }
                
            }
        }

        private void BtnBeenden_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Wollen Sie wirklich Beenden?", "Sicher?", MessageBoxButtons.OKCancel, MessageBoxIcon.Error) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void FormEditor_Load(object sender, EventArgs e)
        {

        }

        private void txbFachname_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbRaum_TextChanged(object sender, EventArgs e)
        {

        }
    } 
}
