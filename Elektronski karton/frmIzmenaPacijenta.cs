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
    public partial class frmIzmenaPacijenta : Form
    {
        public frmIzmenaPacijenta()
        {
            InitializeComponent();
        }

        private void frmIzmenaPacijenta_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
        List<string> rezPretrage = new List<string>();
        private void frmIzmenaPacijenta_Load(object sender, EventArgs e)
        {
            this.Size = new Size(600, 343);
            bNazad.Location = new Point(500, 274);
            groupBox2.Hide();
        }

        private void bNadjiPacijenta_Click(object sender, EventArgs e)
        {        
            listBox1.Items.Clear();
            rezPretrage = DB.select6("SELECT * FROM pacijent " +
                "WHERE ime = '" + tbIme.Text + "' AND prezime = '" + tbPrezime.Text + "'");
            popuniListBox(listBox1, rezPretrage);
        }

        List<int> ids = new List<int>();

        int id;
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (listBox1.SelectedItem != null || (string)listBox1.SelectedItem != "")
                {
                    this.Height = 633;
                    groupBox2.Show();
                    bNazad.Location = new Point(500, 558);
                    //uzimam id selektovanog
                    string idS = listBox1.SelectedItem.ToString();
                    idS = idS.Substring(0, idS.IndexOf(","));
                    id = Convert.ToInt32(idS); //imamo id

                    //dodajem vrednosti poljima u formi da se ne bi sve kucalo ispocetka
                    tbIme2.Text = rezPretrage[0].Split('|')[1];
                    tbPrezime2.Text = rezPretrage[0].Split('|')[2];
                    tbGodRodj2.Text = rezPretrage[0].Split('|')[3];
                    tbAdresa2.Text = rezPretrage[0].Split('|')[4];
                    tbBolestiRizika2.Text = rezPretrage[0].Split('|')[5];

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Greška u unosu podataka", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bIzmeni_Click(object sender, EventArgs e)
        {
            try
            {
                string sqlUpdateCommand = "UPDATE pacijent SET ime='" + tbIme2.Text + "', prezime='" + tbPrezime2.Text + "', god_rodj='" + tbGodRodj2.Text + "', adresa='" + tbAdresa2.Text + "', bolesti_rizika='" + tbBolestiRizika2.Text + "'" +
                      " WHERE Id=" + id;
                DB.execute(sqlUpdateCommand);
                MessageBox.Show("Uspešno ste izmenili pacijenta.", "Uspeh", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (Exception)
            {
                MessageBox.Show("Greška u unosu podataka!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

