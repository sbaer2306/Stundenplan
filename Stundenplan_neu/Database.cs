using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Stundenplan_neu
{ 
    class Database
    {

        private MySqlConnection conn;

        public Database()
        {
            conn = new MySqlConnection(
                "server=127.0.0.1;port=3306;" +
                "username=root;" +
                "database=stundenplan");

            try
            {
                conn.Open();
                 //MessageBox.Show("DB-Verbindung OK");
            }
            catch
            {
                MessageBox.Show("Fehler Datenbank");
            }
        }

        ~Database()
        {
            conn.Close();
        }

        public void NotenSchreiben()
        {
            string[,] BArray = new string[7, 5];

            MySqlDataAdapter da = new MySqlDataAdapter(
            "SELECT * FROM noten;", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            int i = 0;
            foreach (DataRow row in dt.Rows)
            {
                string no_id = row.ItemArray[0].ToString();
                /*string fa_id = row.ItemArray[1].ToString();
                string sa1 = row.ItemArray[2].ToString();
                string sa2 = row.ItemArray[3].ToString();
                string sa3 = row.ItemArray[4].ToString();
                string ex1 = row.ItemArray[4].ToString();
                string ex2 = row.ItemArray[4].ToString();
                string ex3 = row.ItemArray[4].ToString();
                string ex4 = row.ItemArray[4].ToString();*/
                BArray[i, 0] = no_id;
                /*BArray[i, 1] = lehrer;
                BArray[i, 2] = raum;
                BArray[i, 3] = kontakt;
                BArray[i, 4] = fa_id;*/
                i++;
            }

            try
            {
                if (BArray[0, 0] == null)
                {
                    String sql;
                    sql = "INSERT INTO noten(no_id, fa_id, sa1, sa2, sa3, ex1, ex2, ex3, ex4)";
                    sql += "VALUES(@no_id1, @fa_id1, @schulaufgabe1, @schulaufgabe2, @schulaufgabe3, @extemporale1, @extemporale2, @extemporale3, @extemporale4)";

                    MySqlCommand cmd = new MySqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("@no_id1", 1);
                    cmd.Parameters.AddWithValue("@fa_id1", 1);
                    cmd.Parameters.AddWithValue("@schulaufgabe1", Convert.ToInt32(Fach.Array[7, 0]));
                    cmd.Parameters.AddWithValue("@schulaufgabe2", Fach.Array[7, 1]);
                    cmd.Parameters.AddWithValue("@schulaufgabe3", Fach.Array[7, 2]);
                    cmd.Parameters.AddWithValue("@extemporale1", Fach.Array[7, 3]);
                    cmd.Parameters.AddWithValue("@extemporale2", Fach.Array[7, 4]);
                    cmd.Parameters.AddWithValue("@extemporale3", Fach.Array[7, 5]);
                    cmd.Parameters.AddWithValue("@extemporale4", Fach.Array[7, 6]);

                    cmd.ExecuteNonQuery();
                }
                else
                {
                    String sql;
                    sql = "UPDATE `noten` SET `fa_id`=@fa_id1,`sa1`=@schulaufgabe1,`sa2`=@schulaufgabe2, `sa3`=@schulaufgabe3, `ex1`=@extemporale1, `ex2`=@extemporale2, `ex3`=@extemporale3, `ex4`=@extemporale4 WHERE no_id=1";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("@fa_id1", 1);
                    cmd.Parameters.AddWithValue("@schulaufgabe1", Convert.ToInt32(Fach.Array[7, 0]));
                    cmd.Parameters.AddWithValue("@schulaufgabe2", Fach.Array[7, 1]);
                    cmd.Parameters.AddWithValue("@schulaufgabe3", Fach.Array[7, 2]);
                    cmd.Parameters.AddWithValue("@extemporale1", Fach.Array[7, 3]);
                    cmd.Parameters.AddWithValue("@extemporale2", Fach.Array[7, 4]);
                    cmd.Parameters.AddWithValue("@extemporale3", Fach.Array[7, 5]);
                    cmd.Parameters.AddWithValue("@extemporale4", Fach.Array[7, 6]);
                    cmd.ExecuteNonQuery();
                }

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }

        public void Schreiben()
        {
            //Database dm = new Database();
            //dm.Lesen();
            /*
            sql += "(@name2, @lehrer2, @raum2,@fa_id2),";
            sql += "(@name3, @lehrer3, @raum3,@fa_id3),";
            sql += "(@name4, @lehrer4, @raum4,@fa_id4),";
            sql += "(@name5, @lehrer5, @raum5,@fa_id5),";
            sql += "(@name6, @lehrer6, @raum6,@fa_id6),";
            sql += "(@name7, @lehrer7, @raum7,@fa_id7);";
            */

            string[,] AArray = new string[7, 5];

            MySqlDataAdapter da = new MySqlDataAdapter(
            "SELECT * FROM fach;", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            int i = 0;
            foreach (DataRow row in dt.Rows)
            {
                string name = row.ItemArray[0].ToString();
                string lehrer = row.ItemArray[1].ToString();
                string raum = row.ItemArray[2].ToString();
                string kontakt = row.ItemArray[3].ToString();
                string fa_id = row.ItemArray[4].ToString();
                AArray[i, 0] = name;
                AArray[i, 1] = lehrer;
                AArray[i, 2] = raum;
                AArray[i, 3] = kontakt;
                AArray[i, 4] = fa_id;
                i++;
            }

            try
            {

                if (AArray[0, 4] == null && Fach.Array[0, 1] != null)
                {
                    String sql;
                    sql = "INSERT INTO fach(name,lehrer,raum,kontakt,fa_id)";
                    sql += "VALUES(@name1, @lehrer1, @raum1, @kontakt1, @fa_id1)";

                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@name1", Fach.Array[0, 1]);
                    cmd.Parameters.AddWithValue("@lehrer1", Fach.Array[0, 2]);
                    cmd.Parameters.AddWithValue("@raum1", Fach.Array[0, 3]);
                    cmd.Parameters.AddWithValue("@kontakt1", Fach.Array[0, 4]);
                    cmd.Parameters.AddWithValue("@fa_id1", 1);
                    cmd.ExecuteNonQuery();
                }
                else
                {
                    String sql;
                    sql = "UPDATE `fach` SET `name`=@name1,`lehrer`=@lehrer1,`raum`=@raum1,`kontakt`=@kontakt1 WHERE fa_id=1";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("@name1", Fach.Array[0, 1]);
                    cmd.Parameters.AddWithValue("@lehrer1", Fach.Array[0, 2]);
                    cmd.Parameters.AddWithValue("@raum1", Fach.Array[0, 3]);
                    cmd.Parameters.AddWithValue("@kontakt1", Fach.Array[0, 4]);
                    cmd.ExecuteNonQuery();
                }
                if (AArray[1, 4] == null && Fach.Array[1, 1] != null)
                {
                    MessageBox.Show(Fach.Array[1, 1]);
                    String sql;
                    sql = "INSERT INTO fach(name,lehrer,raum,kontakt,fa_id)";
                    sql += "VALUES(@name2, @lehrer2, @raum2, @kontakt2, @fa_id2)";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("@name2", Fach.Array[1, 1]);
                    cmd.Parameters.AddWithValue("@lehrer2", Fach.Array[1, 2]);
                    cmd.Parameters.AddWithValue("@raum2", Fach.Array[1, 3]);
                    cmd.Parameters.AddWithValue("@kontakt2", Fach.Array[1, 4]);
                    cmd.Parameters.AddWithValue("@fa_id2", 2);
                    cmd.ExecuteNonQuery();
                }
                else
                {
                    String sql;
                    sql = "UPDATE `fach` SET `name`=@name2,`lehrer`=@lehrer2,`raum`=@raum2,`kontakt`=@kontakt2 WHERE fa_id=2";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("@name2", Fach.Array[1, 1]);
                    cmd.Parameters.AddWithValue("@lehrer2", Fach.Array[1, 2]);
                    cmd.Parameters.AddWithValue("@raum2", Fach.Array[1, 3]);
                    cmd.Parameters.AddWithValue("@kontakt2", Fach.Array[1, 4]);
                    cmd.ExecuteNonQuery();
                } 
                if (AArray[2, 4] == null && Fach.Array[2, 1] != null)
                {
                    String sql;
                    sql = "INSERT INTO fach(name,lehrer,raum,kontakt,fa_id)";
                    sql += "VALUES(@name3, @lehrer3, @raum3, @kontakt3, @fa_id3)";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("@name3", Fach.Array[2, 1]);
                    cmd.Parameters.AddWithValue("@lehrer3", Fach.Array[2, 2]);
                    cmd.Parameters.AddWithValue("@raum3", Fach.Array[2, 3]);
                    cmd.Parameters.AddWithValue("@kontakt3", Fach.Array[2, 4]);
                    cmd.Parameters.AddWithValue("@fa_id3", 3);
                    cmd.ExecuteNonQuery();
                }
                else
                { 
                    String sql;
                    sql = "UPDATE `fach` SET `name`=@name3,`lehrer`=@lehrer3,`raum`=@raum3,`kontakt`=@kontakt3 WHERE fa_id=3";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("@name3", Fach.Array[2, 1]);
                    cmd.Parameters.AddWithValue("@lehrer3", Fach.Array[2, 2]);
                    cmd.Parameters.AddWithValue("@raum3", Fach.Array[2, 3]);
                    cmd.Parameters.AddWithValue("@kontakt3", Fach.Array[2, 4]);
                    cmd.ExecuteNonQuery();
                }
                if (AArray[3, 4] == null && Fach.Array[3, 1] != null)
                {
                    String sql;
                    sql = "INSERT INTO fach(name,lehrer,raum,kontakt,fa_id)";
                    sql += "VALUES(@name4, @lehrer4, @raum4, @kontakt4, @fa_id4)";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("@name4", Fach.Array[3, 1]);
                    cmd.Parameters.AddWithValue("@lehrer4", Fach.Array[3, 2]);
                    cmd.Parameters.AddWithValue("@raum4", Fach.Array[3, 3]);
                    cmd.Parameters.AddWithValue("@kontakt4", Fach.Array[3, 4]);
                    cmd.Parameters.AddWithValue("@fa_id4", 4);
                    cmd.ExecuteNonQuery();
                }
                else
                {
                    String sql;
                    sql = "UPDATE `fach` SET `name`=@name4,`lehrer`=@lehrer4,`raum`=@raum4,`kontakt`=@kontakt4 WHERE fa_id=4";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("@name4", Fach.Array[3, 1]);
                    cmd.Parameters.AddWithValue("@lehrer4", Fach.Array[3, 2]);
                    cmd.Parameters.AddWithValue("@raum4", Fach.Array[3, 3]);
                    cmd.Parameters.AddWithValue("@kontakt4", Fach.Array[3, 4]);
                    cmd.ExecuteNonQuery();
                }
                if (AArray[4, 4] == null && Fach.Array[4, 1] != null)
                { 
                    String sql;
                    sql = "INSERT INTO fach(name,lehrer,raum,kontakt,fa_id)";
                    sql += "VALUES(@name5, @lehrer5, @raum5, @kontakt5, @fa_id5)";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("@name5", Fach.Array[4, 1]);
                    cmd.Parameters.AddWithValue("@lehrer5", Fach.Array[4, 2]);
                    cmd.Parameters.AddWithValue("@raum5", Fach.Array[4, 3]);
                    cmd.Parameters.AddWithValue("@kontakt5", Fach.Array[4, 4]);
                    cmd.Parameters.AddWithValue("@fa_id5", 5);
                    cmd.ExecuteNonQuery();
                }
                else
                {
                    String sql;
                    sql = "UPDATE `fach` SET `name`=@name5,`lehrer`=@lehrer5,`raum`=@raum5,`kontakt`=@kontakt5 WHERE fa_id=5";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("@name5", Fach.Array[4, 1]);
                    cmd.Parameters.AddWithValue("@lehrer5", Fach.Array[4, 2]);
                    cmd.Parameters.AddWithValue("@raum5", Fach.Array[4, 3]);
                    cmd.Parameters.AddWithValue("@kontakt5", Fach.Array[4, 4]);
                    cmd.ExecuteNonQuery();
                }
                if (AArray[5, 4] == null && Fach.Array[5, 1] != null)
                {
                    String sql;
                    sql = "INSERT INTO fach(name,lehrer,raum,kontakt,fa_id)";
                    sql += "VALUES(@name6, @lehrer6, @raum6, @kontakt6, @fa_id6)";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("@name6", Fach.Array[5, 1]);
                    cmd.Parameters.AddWithValue("@lehrer6", Fach.Array[5, 2]);
                    cmd.Parameters.AddWithValue("@raum6", Fach.Array[5, 3]);
                    cmd.Parameters.AddWithValue("@kontakt6", Fach.Array[5, 4]);
                    cmd.Parameters.AddWithValue("@fa_id6", 6);
                    cmd.ExecuteNonQuery();
                }
                else
                {
                    String sql;
                    sql = "UPDATE `fach` SET `name`=@name6,`lehrer`=@lehrer6,`raum`=@raum6,`kontakt`=@kontakt6 WHERE fa_id=6";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("@name6", Fach.Array[5, 1]);
                    cmd.Parameters.AddWithValue("@lehrer6", Fach.Array[5, 2]);
                    cmd.Parameters.AddWithValue("@raum6", Fach.Array[5, 3]);
                    cmd.Parameters.AddWithValue("@kontakt6", Fach.Array[5, 4]);
                    cmd.ExecuteNonQuery();
                }
                if (AArray[6, 4] == null && Fach.Array[6, 1] != null)
                {
                    String sql;
                    sql = "INSERT INTO fach(name,lehrer,raum,kontakt,fa_id)";
                    sql += "VALUES(@name7, @lehrer7, @raum7, @kontakt7, @fa_id7)";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("@name7", Fach.Array[6, 1]);
                    cmd.Parameters.AddWithValue("@lehrer7", Fach.Array[6, 2]);
                    cmd.Parameters.AddWithValue("@raum7", Fach.Array[6, 3]);
                    cmd.Parameters.AddWithValue("@kontakt7", Fach.Array[6, 4]);
                    cmd.Parameters.AddWithValue("@fa_id7", 7);
                    cmd.ExecuteNonQuery();
                }
                else
                {
                    String sql;
                    sql = "UPDATE `fach` SET `name`=@name7,`lehrer`=@lehrer7,`raum`=@raum7,`kontakt`=@kontakt7 WHERE fa_id=7";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("@name7", Fach.Array[6, 1]);
                    cmd.Parameters.AddWithValue("@lehrer7", Fach.Array[6, 2]);
                    cmd.Parameters.AddWithValue("@raum7", Fach.Array[6, 3]);
                    cmd.Parameters.AddWithValue("@kontakt7", Fach.Array[6, 4]);
                    cmd.ExecuteNonQuery();
                }

                /*
                cmd.Parameters.AddWithValue("@name2", Fach.Array[1, 1]);
                cmd.Parameters.AddWithValue("@lehrer2", Fach.Array[1, 2]);
                cmd.Parameters.AddWithValue("@raum2", Fach.Array[1, 3]);
                cmd.Parameters.AddWithValue("@fa_id2", 2);
                cmd.Parameters.AddWithValue("@name3", Fach.Array[2, 1]);
                cmd.Parameters.AddWithValue("@lehrer3", Fach.Array[2, 2]);
                cmd.Parameters.AddWithValue("@raum3", Fach.Array[2, 3]);
                cmd.Parameters.AddWithValue("@fa_id3", 3);
                cmd.Parameters.AddWithValue("@name4", Fach.Array[3, 1]);
                cmd.Parameters.AddWithValue("@lehrer4", Fach.Array[3, 2]);
                cmd.Parameters.AddWithValue("@raum4", Fach.Array[3, 3]);
                cmd.Parameters.AddWithValue("@fa_id4", 4);
                cmd.Parameters.AddWithValue("@name5", Fach.Array[4, 1]);
                cmd.Parameters.AddWithValue("@lehrer5", Fach.Array[4, 2]);
                cmd.Parameters.AddWithValue("@raum5", Fach.Array[4, 3]);
                cmd.Parameters.AddWithValue("@fa_id5", 5);
                cmd.Parameters.AddWithValue("@name6", Fach.Array[5, 1]);
                cmd.Parameters.AddWithValue("@lehrer6", Fach.Array[5, 2]);
                cmd.Parameters.AddWithValue("@raum6", Fach.Array[5, 3]);
                cmd.Parameters.AddWithValue("@fa_id6", 6);
                cmd.Parameters.AddWithValue("@name7", Fach.Array[6, 1]);
                cmd.Parameters.AddWithValue("@lehrer7", Fach.Array[6, 2]);
                cmd.Parameters.AddWithValue("@raum7", Fach.Array[6, 3]);
                cmd.Parameters.AddWithValue("@fa_id7", 7);

                



                cmd.ExecuteNonQuery();*/
                return;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }


        public void Lesen()
        {
            //ArrayList statistikListe = new ArrayList();

            MySqlDataAdapter da = new MySqlDataAdapter(
                "SELECT * FROM fach;", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            int i = 0;
            foreach (DataRow row in dt.Rows)
            {
                string name = row.ItemArray[0].ToString();
                string lehrer = row.ItemArray[1].ToString();
                string raum = row.ItemArray[2].ToString();
                string kontakt = row.ItemArray[3].ToString();
                Fach.Array[i, 1] = name;
                Fach.Array[i, 2] = lehrer;
                Fach.Array[i, 3] = raum;
                Fach.Array[i, 4] = kontakt;
                i++;
            }
            return;
    
        }
        public void Loeschen()
        {
            try
            {
                String sql;
                sql = "DELETE FROM noten";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            try
            {
                String sql;
                sql = "DELETE FROM fach";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

            return;
        }

        public void LoeschenE(int t)
        {
            try
            {
                t++;
                MessageBox.Show(t.ToString());
                String sql;
                sql = "DELETE FROM `fach` where fa_id=@del ";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@del", t);
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

            return;
        }
    }
}

