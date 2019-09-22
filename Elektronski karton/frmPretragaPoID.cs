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
    public partial class frmPretragaPoID : Form
    {
        public frmPretragaPoID()
        {
            InitializeComponent();
        }

        private void bPretraga_Click(object sender, EventArgs e)
        {
            if (tbID.Text == "")
            {
                MessageBox.Show("Greška u unosu!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                List<string> rows = new List<string>();
                rows = DB.select5("SELECT ime, prezime, god_rodj, adresa, bolesti_rizika FROM pacijent WHERE Id=" + tbID.Text);
                popunilistView(listView1, rows);
            }
        }

        #region popunilistView
        private void popunilistView(ListView listView1, List<string> rows)
        {
            listView1.Columns.Clear();
            listView1.Items.Clear();
            listView1.View = View.Details; //da bi se videle kolone tj. naslovi u listView            
            listView1.Columns.Add("Ime");
            listView1.Columns.Add("Prezime");
            listView1.Columns.Add("Godina rodjenja");
            listView1.Columns.Add("Adresa"); 
            listView1.Columns.Add("Bolesti rizika");
            try
            {
                foreach (string item in rows) //ciklus koji prolazi kroz svaki element u listi rows, a rows dodeljujemo kad pozivamo metodu
                {
                    ListViewItem lv1 = new ListViewItem(item.Split('|')[0]);
                    lv1.SubItems.Add(item.Split('|')[1]); 
                    lv1.SubItems.Add(item.Split('|')[2]); 
                    lv1.SubItems.Add(item.Split('|')[3]);
                    lv1.SubItems.Add(item.Split('|')[4]);
                    listView1.Items.Add(lv1);

                }
                listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            }
            catch (Exception)
            {
                MessageBox.Show("Nema podataka", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        #endregion

        private void tbID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        } //da prihvata samo brojeve

        private void frmPretragaPoID_FormClosing(object sender, FormClosingEventArgs e)
        {
            
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

