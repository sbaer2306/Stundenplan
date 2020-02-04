using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stundenplan_neu
{
    class Fach
    {
        
        // Array in das die Informationen abgespeichert werden
        public static string[,] Array = new string[14,7];
        // Zaehler fuer Position im Array
        public static int zaehler = 0;
        // Liste auf die die Comboboxen zugreifen
        public static List<string> Faecherlist = new List<string>();

        // Array zum Speichern der Notizen
        public static string[] ArrayNn = new string[47];
        public static int zahler = 0;

        // Array zum Speichern der Noten
        //
        public static int zehler = 0;
    }
}
