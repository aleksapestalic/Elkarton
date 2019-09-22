using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Elektronski_karton
{
    public partial class frmDetaljiPacijenta : Form
    {
        public frmDetaljiPacijenta()
        {
            InitializeComponent();
        }

        public string PacijentID { get; set; }
        
        private void frmDetaljiPacijenta_Load(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(this.PacijentID);

            List<string> rows = new List<string>();
            string comm = "SELECT ime, prezime, god_rodj, adresa, bolesti_rizika FROM pacijent WHERE Id = " + id;
            rows = DB.select5(comm);
            lSifraPacijenta.Text = "Šifra: " + this.PacijentID;
           
            foreach (var item in rows)
            {
                lIme.Text = "Ime: " + item.Split('|')[0];
                lPrezime.Text = "Prezime: " + item.Split('|')[1];
                lGodiste.Text = "Godina rođenja: " + item.Split('|')[2];
                lAdresa.Text = "Adresa: " + item.Split('|')[3];
                lBolestiRizika.Text = "Bolesti rizika: " + item.Split('|')[4];
            }

            PrikaziIntervencije(this.PacijentID);

        }

        private void PrikaziIntervencije(string id)
        {
            string comm2 = "SELECT anamneza, dijagnoza, terapija, puna_cena, isplaceno, datum, doktor.ime, doktor.prezime, napomena FROM intervencija JOIN doktor ON intervencija.doktor_id=doktor.Id WHERE pacijent_id=" + id;
            List<string> rowsIntervencije = new List<string>();
            rowsIntervencije = DB.select9(comm2);

            popunilistView(listView1, rowsIntervencije);
        }

        #region popunilistView
        private void popunilistView(ListView listView1, List<string> rows)
        {
            listView1.Columns.Clear();
            listView1.Items.Clear();
            listView1.View = View.Details; //da bi se videle kolone tj naslovi u listView            
            listView1.Columns.Add("Anamneza");
            listView1.Columns.Add("Dijagnoza");
            listView1.Columns.Add("Terapija");
            listView1.Columns.Add("Puna cena"); 
            listView1.Columns.Add("Isplaćeno");
            listView1.Columns.Add("Datum");
            listView1.Columns.Add("Doktor");
            listView1.Columns.Add("Napomena");
            
            try
            {
                foreach (string item in rows) //ciklus koji prolazi kroz svaki element u listi rows, a rows dodeljujemo kad pozivamo metodu
                {
                    ListViewItem lv1 = new ListViewItem(item.Split('|')[0]);
                    lv1.SubItems.Add(item.Split('|')[1]);
                    lv1.SubItems.Add(item.Split('|')[2]); 
                    lv1.SubItems.Add(item.Split('|')[3]);
                    lv1.SubItems.Add(item.Split('|')[4]);
                    lv1.SubItems.Add(item.Split('|')[5]);
                    lv1.SubItems.Add(item.Split('|')[6] + " " + item.Split('|')[7]);
                    lv1.SubItems.Add(item.Split('|')[8]);
                    listView1.Items.Add(lv1);

                }
                listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize); //da bi se sve lepo videlo u listView-u
            }
            catch (Exception)
            {
                MessageBox.Show("Za traženog pacijenta nema zabeleženih intervencija", "Obaveštenje", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }

        }

        #endregion

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://aleksapestalic.github.io");
        }
    }
}
