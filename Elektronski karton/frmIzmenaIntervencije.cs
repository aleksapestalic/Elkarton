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
    public partial class frmIzmenaIntervencije : Form
    {
        public frmIzmenaIntervencije()
        {
            InitializeComponent();
        }
        List<int> ids = new List<int>();
        private void bNadjiPacijenta_Click(object sender, EventArgs e)
        {
            List<string> rezPretrage = new List<string>();
            listBox1.Items.Clear();
            rezPretrage = DB.select6("SELECT * FROM pacijent WHERE ime = '" + tbIme.Text + "' AND prezime = '" + tbPrezime.Text + "'");
            popuniListBox(listBox1, rezPretrage);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string id = listBox1.SelectedItem.ToString().Substring(0, listBox1.SelectedItem.ToString().IndexOf(",")); //idPacijenta
                frmIzmenaIntervencijeUnos frmUnos = new frmIzmenaIntervencijeUnos();
                frmUnos.ID = id;
                frmUnos.Show();
            }
            catch (Exception)
            {
                MessageBox.Show("Morate selektovati pacijenta!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        int[] popuniListBox(ListBox lb, List<string> rows)
        {
            try
            {
                foreach (var item in rows)
                {
                    lb.Items.Add(item.Split('|')[0] + ",     " + item.Split('|')[1] + " " + item.Split('|')[2] + ", Godina rodjenja: " + item.Split('|')[3] + ", Adresa: " + item.Split('|')[4] + ", Bolesti rizika: " + item.Split('|')[5]);
                    ids.Add(Convert.ToInt32(item.Split('|')[0]));
                }
                int[] id = ids.ToArray();
                return id;
            }
            catch (Exception)
            {
                MessageBox.Show("Greška u unosu!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Refresh();
            this.Hide();
        }

        private void frmIzmenaIntervencije_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://aleksapestalic.github.io");
        }
    }
}
