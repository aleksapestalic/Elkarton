using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Elektronski_karton
{
    class DB
    {      
        public static string MyConnection2 = "server=remotemysql.com;uid=az1Qt8dZpk;pwd=ihTg5bupu2;database=az1Qt8dZpk"; //promenim da cita iz propratnog txt-a
        //private static string MyConnection2 = "server=sql7.freemysqlhosting.net;uid=sql7293520;pwd=ivflmq8gcK;database=sql7293520";

        #region Intervencija uz unos pacijenta
        public static void insertIntervencijaUzPacijenta(string Amanmeza, string Dijagnoza, string Terapija, string PunaCena, string Isplaceno, 
            string Napomena, int DoktorID, string Datum, string Ime, string Prezime, string GodRodj, string Adresa, string BolestiRizika)
        {
            MySqlConnection conn = new MySqlConnection(MyConnection2);
            //unosim podatke
            try
            {
                var sqlCommand = "INSERT INTO intervencija (anamneza, dijagnoza, terapija, puna_cena, isplaceno, napomena, pacijent_id, doktor_id, datum) " +
                    "VALUES (@anamneza, @dijagnoza, @terapija, @puna_cena, @isplaceno, @napomena, @pacijent_id, @doktor_id, @datum)";

                conn.Open(); //uspostavlja vezu sa bazom
                MySqlCommand comm = conn.CreateCommand();
                comm.CommandText = sqlCommand;

                // da ne bi ubacivao prazne               
                if (Ime == "") Ime = null;
                if (Prezime == "") Prezime = null;
                if (GodRodj == "") GodRodj = null;
                if (Adresa == "") Adresa = null;
                if (BolestiRizika == "") BolestiRizika = null;

                if (Amanmeza == "") Amanmeza = null;
                if (Dijagnoza == "") Dijagnoza = null;
                if (Terapija == "") Terapija = null;
                if (PunaCena == "") PunaCena = null;
                if (Isplaceno == "") Isplaceno = null;
                if (Datum == "") Datum = null;
                if (BolestiRizika == "") BolestiRizika = null;

                insertPacijent(Ime, Prezime, GodRodj, Adresa, BolestiRizika);
                //trazim id pacijenta na osnovu datih podataka
                string idPacijenta;
                idPacijenta = select1("SELECT Id FROM pacijent " +
                    " WHERE ime = '" + Ime + "' " +
                    "AND prezime='" + Prezime + "' " +
                    "AND god_rodj ='" + GodRodj + "' " +
                    "AND adresa='" + Adresa + "'" +
                    "AND bolesti_rizika='" + BolestiRizika + "'"
                    );
                

                //dodajem vrednosti poljima za unos u bazu
                comm.Parameters.AddWithValue("@anamneza", Amanmeza);
                comm.Parameters.AddWithValue("@dijagnoza", Dijagnoza);
                comm.Parameters.AddWithValue("@terapija", Terapija); //ovde se dodeljuju vrednosti poljima za unos u bazu
                comm.Parameters.AddWithValue("@puna_cena", PunaCena);
                comm.Parameters.AddWithValue("@isplaceno", Isplaceno);
                comm.Parameters.AddWithValue("@napomena", Napomena);
                comm.Parameters.AddWithValue("@pacijent_id", idPacijenta);
                comm.Parameters.AddWithValue("@doktor_id", DoktorID);
                comm.Parameters.AddWithValue("@datum", Datum);

                int a = comm.ExecuteNonQuery(); //izvrsava naredbu
                long id = comm.LastInsertedId;

                if (a > 0)
                {
                    conn.Close();
                    MessageBox.Show("Intervencija uspešno dodata u bazu!", "Uspeh", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show(ex.Message);
                //MessageBox.Show("Greška u unosu!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }
        #endregion

        #region insertIntervencijuZaPostojeceg
        public static void insertIntervencijuZaPostojeceg
            (string anamneza, string dijagnoza, string terapija, string punaCena, string isplaceno, string napomena, int pacijentId, int doktorId, string datum)
        {
            MySqlConnection conn = new MySqlConnection(MyConnection2);

            try
            {
                var sqlCommand = "INSERT INTO intervencija " +
                    "(anamneza, dijagnoza, terapija, puna_cena, isplaceno, napomena, pacijent_id, doktor_id, datum)" +
                    " VALUES " +
                    "(@anamneza, @dijagnoza, @terapija, @punaCena, @isplaceno, @napomena, @pacijentId, @doktorId, @datum)";

                conn.Open(); //uspostavlja vezu sa bazom
                MySqlCommand comm = conn.CreateCommand();
                comm.CommandText = sqlCommand;
                // da ne bi ubacivao prazne
                if (anamneza == "") anamneza = null;
                if (dijagnoza == "") dijagnoza = null;
                if (terapija == "") terapija = null;
                if (punaCena == "") punaCena = null;
                if (isplaceno == "") isplaceno = null;
                if (datum == "") datum = null;
                
                comm.Parameters.AddWithValue("@anamneza", anamneza);
                comm.Parameters.AddWithValue("@dijagnoza", dijagnoza);
                comm.Parameters.AddWithValue("@terapija", terapija);
                comm.Parameters.AddWithValue("@punaCena", punaCena);
                comm.Parameters.AddWithValue("@isplaceno", isplaceno);
                comm.Parameters.AddWithValue("@napomena", napomena);
                comm.Parameters.AddWithValue("@pacijentId", pacijentId);
                comm.Parameters.AddWithValue("@doktorId", doktorId);
                comm.Parameters.AddWithValue("@datum", datum);

                int a = comm.ExecuteNonQuery(); //izvrsava naredbu
                long id = comm.LastInsertedId;

                if (a > 0)
                {
                    conn.Close();
                    MessageBox.Show("Intervencija uspešno dodata u bazu!", "Uspeh", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {
                conn.Close();
                MessageBox.Show("Greška u unosu!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        #endregion

        #region executeSqlQuery
        public static void execute(string sqlCommand) //izvrsava neku sql naredbu, npr DELETE FROM table WHERE id=1, to ubacis kao sqlCommand i on ce to da odradi
        {
            MySqlConnection conn = new MySqlConnection(MyConnection2); //podaci za povezivanje na bazu
            try
            {
                conn.Open();
                MySqlCommand comm = conn.CreateCommand();
                comm.CommandText = sqlCommand;
                comm.ExecuteNonQuery();
                conn.Close();
            }
            catch
            {
                conn.Close();
                throw;
            }
        }
        #endregion

        #region insertPacijent

        public static void insertPacijent(string Ime, string Prezime, string GodRodj, string Adresa, string BolestiRizika)
        {
            MySqlConnection conn = new MySqlConnection(MyConnection2);

            //proveravam da li vec postoji
            List<string> rows = new List<string>();
            rows = select5(
                "SELECT ime, prezime, god_rodj, adresa, bolesti_rizika FROM pacijent" +
                " WHERE ime='" + Ime + "' " +
                "AND prezime='" + Prezime + "' " +
                "AND god_rodj ='" + GodRodj + "' " +
                "AND adresa='" + Adresa + "'" +
                "AND bolesti_rizika='" + BolestiRizika + "'"
                );
            if (rows == null)
            {
                try
                {
                    var sqlCommand = "INSERT INTO pacijent (ime, prezime, god_rodj, adresa, bolesti_rizika) " +
                        "VALUES (@ime, @prezime, @godRodj, @adresa, @bolestiRizika)";

                    conn.Open(); //uspostavlja vezu sa bazom
                    MySqlCommand comm = conn.CreateCommand();
                    comm.CommandText = sqlCommand;
                    // da ne bi ubacivao prazne
                    if (Ime == "") Ime = null;
                    if (Prezime == "") Prezime = null;
                    if (GodRodj == "") GodRodj = null;
                    if (Adresa == "") Adresa = null;
                    if (BolestiRizika == "") BolestiRizika = null;

                    comm.Parameters.AddWithValue("@ime", Ime);
                    comm.Parameters.AddWithValue("@prezime", Prezime);
                    comm.Parameters.AddWithValue("@godRodj", GodRodj);
                    comm.Parameters.AddWithValue("@adresa", Adresa);
                    comm.Parameters.AddWithValue("@bolestiRizika", BolestiRizika);

                    int a = comm.ExecuteNonQuery(); //izvrsava naredbu
                    long id = comm.LastInsertedId;

                    if (a > 0)
                    {
                        conn.Close();
                        MessageBox.Show("Pacijent uspešno dodat u bazu!", "Uspeh", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception)
                {
                    conn.Close();
                    MessageBox.Show("Greška u unosu!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conn.Close();
                }
            }
            else
            {
                conn.Close();
                MessageBox.Show("Pacijent već postoji u bazi!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }
        #endregion

        #region select 1
        public static string select1(string sqlCommand) //vraca listu sa redovima podataka naguranim u jednu recenicu na osnovu upita (SELECT * FROM table -> sqlCommand)
        {
            MySqlConnection conn = new MySqlConnection(MyConnection2);
            try
            {
                string row = null;
                conn.Open();
                MySqlCommand comm = conn.CreateCommand();
                comm.CommandText = sqlCommand;


                MySqlDataReader reader = comm.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        row = reader.GetString(0);
                    }

                    conn.Close();
                    return row;
                    
                }
                else
                {
                    conn.Close();
                    MessageBox.Show("Greška!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error); return null;                    
                }
                
            }
            catch
            {
                throw;
            }
        }
        #endregion

        #region select 1 list
        public static List<string> select1LIST(string sqlCommand) //vraca listu sa redovima podataka naguranim u jednu recenicu na osnovu upita (SELECT * FROM table -> sqlCommand)
        {
            MySqlConnection conn = new MySqlConnection(MyConnection2);
            try
            {
                List<string> rows = new List<string>();
                conn.Open();
                MySqlCommand comm = conn.CreateCommand();
                comm.CommandText = sqlCommand;


                MySqlDataReader reader = comm.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        rows.Add(reader.GetString(0));
                    }
                    conn.Close();
                    return rows;
                }
                else
                {
                    conn.Close();
                    MessageBox.Show("Greška!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error); return null;
                }

            }
            catch
            {
                conn.Close();
                throw;
            }
        }
        #endregion

        #region select 3
        public static List<string> select3(string sqlCommand) 
        {
            MySqlConnection conn = new MySqlConnection(MyConnection2);
            try
            {
                List<string> rows = new List<string>();
                conn.Open();
                MySqlCommand comm = conn.CreateCommand();
                comm.CommandText = sqlCommand;


                MySqlDataReader reader = comm.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        rows.Add(reader.GetString(0) + "|" + reader.GetString(1) + "|" + reader.GetString(2));
                    }
                    conn.Close();
                    return rows;
                }
                else
                {
                    conn.Close();
                    rows = null; return rows;
                }

            }
            catch
            {
                conn.Close();
                throw;
            }
        }
        #endregion

        #region select 4
        public static List<string> select4(string sqlCommand)
        {
            MySqlConnection conn = new MySqlConnection(MyConnection2);
            try
            {
                List<string> rows = new List<string>();
                conn.Open();
                MySqlCommand comm = conn.CreateCommand();
                comm.CommandText = sqlCommand;


                MySqlDataReader reader = comm.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        rows.Add(reader.GetString(0) + "|" + reader.GetString(1) + "|" + reader.GetString(2) + "|" + reader.GetString(3));
                    }
                    conn.Close();
                    return rows;
                }
                else
                {
                    conn.Close();
                    rows = null; return rows;
                }

            }
            catch
            {
                conn.Close();
                throw;
            }
        }
        #endregion

        #region select 5
        public static List<string> select5(string sqlCommand) //vraca listu sa redovima podataka naguranim u jednu recenicu na osnovu upita (SELECT * FROM table -> sqlCommand)
        {
           // MyConnection2 = this.getConnString();
            MySqlConnection conn = new MySqlConnection(MyConnection2);
            try
            {
                List<string> rows = new List<string>();
                conn.Open();
                MySqlCommand comm = conn.CreateCommand();
                comm.CommandText = sqlCommand;


                MySqlDataReader reader = comm.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        rows.Add(reader.GetString(0) + "|" + reader.GetString(1) + "|" + reader.GetString(2) + "|" + reader.GetString(3) + "|" + reader.GetString(4));
                    }
                    conn.Close();
                    return rows;
                }
                else
                {
                    conn.Close();
                    rows = null; return rows;
                }

            }
            catch
            {
                conn.Close();
                throw;
            }
        }
        #endregion

        #region select 6
        public static List<string> select6(string sqlCommand) //vraca listu sa redovima podataka naguranim u jednu recenicu na osnovu upita (SELECT * FROM table -> sqlCommand)
        {
            MySqlConnection conn = new MySqlConnection(MyConnection2);
            try
            {
                List<string> rows = new List<string>();
                conn.Open();
                MySqlCommand comm = conn.CreateCommand();
                comm.CommandText = sqlCommand;


                MySqlDataReader reader = comm.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        rows.Add(reader.GetString(0) + "|" + reader.GetString(1) + "|" + reader.GetString(2) + "|" + reader.GetString(3) + "|" + reader.GetString(4) + "|" + reader.GetString(5));
                    }
                    conn.Close();
                    return rows;
                }
                else
                {
                    conn.Close();
                    rows = null; return rows;
                }

            }
            catch
            {
                conn.Close();
                throw;
            }
        }
        #endregion

        #region select 7
        public static List<string> select7(string sqlCommand) //vraca listu sa redovima podataka naguranim u jednu recenicu na osnovu upita (SELECT * FROM table -> sqlCommand)
        {
            MySqlConnection conn = new MySqlConnection(MyConnection2);
            try
            {
                List<string> rows = new List<string>();
                conn.Open();
                MySqlCommand comm = conn.CreateCommand();
                comm.CommandText = sqlCommand;


                MySqlDataReader reader = comm.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        rows.Add(reader.GetString(0) + "|" + reader.GetString(1) + "|" + reader.GetString(2) + "|" + reader.GetString(3) + "|" + reader.GetString(4) + "|" + reader.GetString(5) + "|" + reader.GetString(6));
                    }
                    conn.Close();
                    return rows;
                }
                else
                {
                    conn.Close();
                    rows.Add("No rows found."); return rows;
                }

            }
            catch
            {
                conn.Close();
                throw;
            }
        }
        #endregion               

        #region select 8
        public static List<string> select8(string sqlCommand) //vraca listu sa redovima podataka naguranim u jednu recenicu na osnovu upita (SELECT * FROM table -> sqlCommand)
        {
            MySqlConnection conn = new MySqlConnection(MyConnection2);
            try
            {
                List<string> rows = new List<string>();
                conn.Open();
                MySqlCommand comm = conn.CreateCommand();
                comm.CommandText = sqlCommand;


                MySqlDataReader reader = comm.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        rows.Add(reader.GetString(0) + "|" + reader.GetString(1) + "|" + reader.GetString(2) + "|" + reader.GetString(3) + "|" + reader.GetString(4) + "|" + reader.GetString(5) + "|" + reader.GetString(6) + "|" + reader.GetString(7));
                    }
                    conn.Close();
                    return rows;
                }
                else
                {
                    conn.Close();
                    rows.Add("No rows found."); return rows;
                }

            }
            catch
            {
                conn.Close();
                throw;
            }
        }
        #endregion               

        #region select 9
        public static List<string> select9(string sqlCommand) //vraca listu sa redovima podataka naguranim u jednu recenicu na osnovu upita (SELECT * FROM table -> sqlCommand)
        {
            MySqlConnection conn = new MySqlConnection(MyConnection2);
            try
            {
                List<string> rows = new List<string>();
                conn.Open();
                MySqlCommand comm = conn.CreateCommand();
                comm.CommandText = sqlCommand;


                MySqlDataReader reader = comm.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        rows.Add(reader.GetString(0) + "|" + reader.GetString(1) + "|" + reader.GetString(2) + "|" + reader.GetString(3) + "|" + reader.GetString(4) + "|" + reader.GetString(5) + "|" + reader.GetString(6) + "|" + reader.GetString(7) + "|" + reader.GetString(8));
                    }
                    conn.Close();
                    return rows;
                }
                else
                {
                    conn.Close();
                    rows.Add("No rows found."); return rows;
                }

            }
            catch
            {
                conn.Close();
                throw;
            }
        }
        #endregion                       

        #region select 10
        public static List<string> select10(string sqlCommand) //vraca listu sa redovima podataka naguranim u jednu recenicu na osnovu upita (SELECT * FROM table -> sqlCommand)
        {
            MySqlConnection conn = new MySqlConnection(MyConnection2);
            try
            {
                List<string> rows = new List<string>();
                conn.Open();
                MySqlCommand comm = conn.CreateCommand();
                comm.CommandText = sqlCommand;


                MySqlDataReader reader = comm.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        rows.Add(reader.GetString(0) + "|" + reader.GetString(1) + "|" + reader.GetString(2) + "|" + reader.GetString(3) + "|" + reader.GetString(4) + "|" + reader.GetString(5) + "|" + reader.GetString(6) + "|" + reader.GetString(7) + "|" + reader.GetString(8) + "|" + reader.GetString(9));
                    }
                    conn.Close();
                    return rows;
                }
                else
                {
                    conn.Close();
                    rows.Add("No rows found."); return rows;
                }

            }
            catch
            {
                conn.Close();
                throw;
            }
        }
        #endregion               

    }
}
