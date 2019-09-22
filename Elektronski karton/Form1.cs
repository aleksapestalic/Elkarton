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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void poImenuPrezimenuIGodiniRođenjaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmPretragaPoSvemu();
            frm.Show();
        }

        private void poBolestimaOpasnostiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmPoBolestima = new frmPretragaPoBolestimaRizika();
            frmPoBolestima.Show();
        }

        private void poJedinstvenojŠifriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmPoSifri = new frmPretragaPoID();
            frmPoSifri.Show();
        }

        private void noviPacijentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmNoviPac = new frmUnosNovogPacijenta();
            frmNoviPac.Show();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void novaIntervencijaPostojećemPacijentuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmNovaInt = new frmNovaIntervencijaPostojecemPac();
            frmNovaInt.Show();
        }

        private void pacijentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmIzmenaPacijenta = new frmIzmenaPacijenta();

            frmIzmenaPacijenta.Show();
        }

        private void intervencijeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmIzmenaInt = new frmIzmenaIntervencije();
            frmIzmenaInt.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            #region popunjavam listu
            string sqlComm = "SELECT pacijent.Id, pacijent.ime, pacijent.prezime, god_rodj, bolesti_rizika FROM pacijent";
            List<string> pacijenti = new List<string>();
            pacijenti = DB.select5(sqlComm);
            popunilistView(listView1, pacijenti);
            #endregion
        }


        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            string selected = listView1.SelectedItems[0].Text; //selected = id pacijenta
            frmDetaljiPacijenta frm = new frmDetaljiPacijenta();
            frm.PacijentID = selected; //saljem id pacijenta kao string
            frm.Show();
        }

        #region popunilistView
        private void popunilistView(ListView listView1, List<string> rows)
        {
            listView1.Columns.Clear();
            listView1.Items.Clear();
            listView1.View = View.Details; //da bi se videle kolone tj naslovi u listView            
            listView1.Columns.Add("Šifra");
            listView1.Columns.Add("Ime");
            listView1.Columns.Add("Prezime");
            listView1.Columns.Add("Godina rođenja"); //sve ovo je za upis kolona tj "naslova" u listView
            listView1.Columns.Add("Bolesti rizika");
            try
            {
                foreach (string item in rows) //ciklus koji prolazi kroz svaki element u listi rows, a rows dodeljujemo kad pozivamo metodu
                {
                    ListViewItem lv1 = new ListViewItem(item.Split('|')[0]);
                    lv1.SubItems.Add(item.Split('|')[1]); //subItem je ono polje koje nije prvi red u listView
                    lv1.SubItems.Add(item.Split('|')[2]);
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

        private void bPretraga_Click(object sender, EventArgs e)
        {

            #region popunjavam listu
            string sqlComm = "SELECT pacijent.Id, pacijent.ime, pacijent.prezime, god_rodj, bolesti_rizika FROM pacijent";
            List<string> pacijenti = new List<string>();
            pacijenti = DB.select5(sqlComm);
            popunilistView(listView1, pacijenti);
            #endregion

            try
            {
                string prezime = tbPrezime.Text;
                if (prezime != String.Empty)
                {
                    List<string> res = new List<string>();
                    for (int i = listView1.Items.Count - 1; i >= 0; i--)
                    {
                        ListViewItem.ListViewSubItem currentItem = listView1.Items[i].SubItems[2];
                        if (currentItem.Text.Contains(prezime))
                        {
                            res = (DB.select5("SELECT Id, ime, prezime, god_rodj, bolesti_rizika FROM pacijent WHERE prezime='" + prezime + "'"));
                            if (res == null || res.Count == 0) MessageBox.Show("Greška", "Nema podataka za unesene parametre!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            listView1.Items.RemoveAt(i);
                        }
                    }
                    popunilistView(listView1, res);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Greška", "Nema podataka za unesene parametre!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://aleksapestalic.github.io");
        }

        private void bReset_Click(object sender, EventArgs e)
        {
            #region popunjavam listu
            string sqlComm = "SELECT pacijent.Id, pacijent.ime, pacijent.prezime, god_rodj, bolesti_rizika FROM pacijent";
            List<string> pacijenti = new List<string>();
            pacijenti = DB.select5(sqlComm);
            popunilistView(listView1, pacijenti);
            #endregion
        }

        public void refreshData()
        {
            #region popunjavam listu
            string sqlComm = "SELECT pacijent.Id, pacijent.ime, pacijent.prezime, god_rodj, bolesti_rizika FROM pacijent";
            List<string> pacijenti = new List<string>();
            pacijenti = DB.select5(sqlComm);
            ListView listView1 = this.listView1;

            listView1.Columns.Clear();
            listView1.Items.Clear();
            listView1.View = View.Details; //da bi se videle kolone tj naslovi u listView            
            listView1.Columns.Add("Šifra");
            listView1.Columns.Add("Ime");
            listView1.Columns.Add("Prezime");
            listView1.Columns.Add("Godina rođenja"); //sve ovo je za upis kolona tj "naslova" u listView
            listView1.Columns.Add("Bolesti rizika");
            try
            {
                foreach (string item in pacijenti) //ciklus koji prolazi kroz svaki element u listi rows, a rows dodeljujemo kad pozivamo metodu
                {
                    ListViewItem lv1 = new ListViewItem(item.Split('|')[0]);
                    lv1.SubItems.Add(item.Split('|')[1]); //subItem je ono polje koje nije prvi red u listView
                    lv1.SubItems.Add(item.Split('|')[2]);
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
            #endregion
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            refreshData();
        }
    }
}
