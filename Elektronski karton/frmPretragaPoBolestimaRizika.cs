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
    public partial class frmPretragaPoBolestimaRizika : Form
    {
        public frmPretragaPoBolestimaRizika()
        {
            InitializeComponent();
        }

        private void bPretraga_Click(object sender, EventArgs e)
        {
            if (tbKeyword.Text == "") { MessageBox.Show("Morate uneti ključnu reč!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            else
            {
                List<string> rows = new List<string>();
                rows = DB.select5("SELECT ime, prezime, god_rodj, adresa, bolesti_rizika FROM pacijent WHERE bolesti_rizika LIKE('%" + tbKeyword.Text + "%')");
                popunilistView(listView1, rows);
            }
        }

        #region popunilistView
        private void popunilistView(ListView listView1, List<string> rows)
        {
            listView1.Columns.Clear();
            listView1.Items.Clear();
            listView1.View = View.Details; //da bi se videle kolone tj naslovi u listView            
            listView1.Columns.Add("Ime");
            listView1.Columns.Add("Prezime");
            listView1.Columns.Add("Godina rodjenja");
            listView1.Columns.Add("Adresa"); //sve ovo je za upis kolona tj "naslova" u listView
            listView1.Columns.Add("Bolesti rizika");
            try
            {
                foreach (string item in rows) //ciklus koji prolazi kroz svaki element u listi rows, a rows dodeljujemo kad pozivamo metodu
                {
                    ListViewItem lv1 = new ListViewItem(item.Split('|')[0]);
                    lv1.SubItems.Add(item.Split('|')[1]); //subItem je ono polje koje nije prvi red u listView
                    lv1.SubItems.Add(item.Split('|')[2]); // item.split[1,2,3....] zato sto je to kolona koju uzimamo iz baze (item[1] je GlumacID, item[2] je ime itd... 
                    lv1.SubItems.Add(item.Split('|')[3]);
                    lv1.SubItems.Add(item.Split('|')[4]);
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

        private void frmPretragaPoBolestimaOpasnosti_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void tbKeyword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                bPretraga.PerformClick();
            }
        }

        private void bNazad_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Refresh();
            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://aleksapestalic.github.io");
        }
    }
}
