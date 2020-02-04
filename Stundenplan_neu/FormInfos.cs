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
    public partial class FormInfos : Form
    {
        public FormInfos()
        {
            InitializeComponent();
            getData();
        }

        public void getData()
        {
            Label[,] Labelarray = new Label[7, 5]{{ LblFach1, LblLehrer1, LblRaum1, LblDNote1, LblKontaktdaten1},{ LblFach2, LblLehrer2, LblRaum2, LblDNote2, LblKontaktdaten2 },{ LblFach3, LblLehrer3, LblRaum3, LblDNote3, LblKontaktdaten3 },{ LblFach4, LblLehrer4, LblRaum4, LblDNote4, LblKontaktdaten4 }, { LblFach5, LblLehrer5, LblRaum5, LblDNote5, LblKontaktdaten5 },{ LblFach6, LblLehrer6, LblRaum6, LblDNote6, LblKontaktdaten6 } ,{ LblFach7, LblLehrer7, LblRaum8, LblDNote7, LblKontaktdaten7 } };
            for(int x = 0; x<7;x++)
            {
                Labelarray[x, 0].Text = Fach.Array[x, 1];
                Labelarray[x, 1].Text = Fach.Array[x, 2];
                Labelarray[x, 2].Text = Fach.Array[x, 3];
                Labelarray[x, 3].Text = Fach.Array[x, 5];
                Labelarray[x, 4].Text = Fach.Array[x, 4];
            }
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            getData();
        }
    }
}
