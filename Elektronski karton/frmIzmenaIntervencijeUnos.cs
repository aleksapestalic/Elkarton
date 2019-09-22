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
    public partial class frmIzmenaIntervencijeUnos : Form
    {
        public frmIzmenaIntervencijeUnos()
        {
            InitializeComponent();
        }
        public string ID { get; set; }
        private void frmIzmenaIntervencijeUnos_Load(object sender, EventArgs e)
        {
            string query = "SELECT intervencija.Id, anamneza, dijagnoza, terapija, datum, napomena FROM intervencija JOIN pacijent ON intervencija.pacijent_id=pacijent.Id " +
                "WHERE pacijent_id=" + this.ID;
            List<string> pacijenti = new List<string>();
            pacijenti = DB.select6(query);
            popunilistView(listView1, pacijenti);
        }

        #region popunilistView
        private void popunilistView(ListView listView1, List<string> rows)
        {
            listView1.Columns.Clear();
            listView1.Items.Clear();
            listView1.View = View.Details; //da bi se videle kolone tj naslovi u listView            
            listView1.Columns.Add("Šifra");
            listView1.Columns.Add("Anamneza");
            listView1.Columns.Add("Dijagnoza");
            listView1.Columns.Add("Terapija"); //sve ovo je za upis kolona tj "naslova" u listView
            listView1.Columns.Add("Datum");
            listView1.Columns.Add("Napomena");
            try
            {
                foreach (string item in rows) //ciklus koji prolazi kroz svaki element u listi rows, a rows dodeljujemo kad pozivamo metodu
                {
                    ListViewItem lv1 = new ListViewItem(item.Split('|')[0]);
                    lv1.SubItems.Add(item.Split('|')[1]); //subItem je ono polje koje nije prvi red u listView
                    lv1.SubItems.Add(item.Split('|')[2]);
                    lv1.SubItems.Add(item.Split('|')[3]);
                    lv1.SubItems.Add(item.Split('|')[4]);
                    lv1.SubItems.Add(item.Split('|')[5]);
                    listView1.Items.Add(lv1);

                }
                listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize); //da bi se sve lepo videlo u listView-u
            }
            catch (Exception)
            {
                MessageBox.Show("Nema podataka", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        #endregion
        string selectedId;
        private void listView1_Click(object sender, EventArgs e)
        {
            selectedId = listView1.SelectedItems[0].Text; //selectedId = id intervencije
            //popunjavam postojeca polja
            List<string> intervencijaSve = new List<string>();
            intervencijaSve = DB.select7("SELECT anamneza, dijagnoza, terapija, puna_cena, isplaceno, datum, napomena FROM intervencija WHERE Id=" + selectedId);

            tbAnamneza.Text = intervencijaSve[0].Split('|')[0];
            tbDijagnoza.Text = intervencijaSve[0].Split('|')[1];
            tbTerapija.Text = intervencijaSve[0].Split('|')[2];
            tbPunaCena.Text = intervencijaSve[0].Split('|')[3];
            tbIsplaceno.Text = intervencijaSve[0].Split('|')[4];
            tbDatum.Text = intervencijaSve[0].Split('|')[5];
            tbNapomena.Text = intervencijaSve[0].Split('|')[6];
            try
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //MessageBox.Show("Greška u unosu podataka!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void bUnesi_Click(object sender, EventArgs e)
        {
            try
            {
                string sqlUpdateCommand = "UPDATE intervencija SET anamneza='" + tbAnamneza.Text + "', dijagnoza='" + tbDijagnoza.Text + "', terapija='" + tbTerapija.Text + "', puna_cena='" + tbPunaCena.Text + "', isplaceno='" + tbIsplaceno.Text + "', napomena='" + tbNapomena.Text + "', datum ='" + tbDatum.Text + "'" +
                     " WHERE Id=" + selectedId;
                DB.execute(sqlUpdateCommand);
                MessageBox.Show("Uspešno ste izmenili intervenciju.", "Uspeh", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (Exception)
            {
                MessageBox.Show("Greška u unosu podataka.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://aleksapestalic.github.io");
        }
    }
}