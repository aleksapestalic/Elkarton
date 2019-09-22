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
    public partial class frmNovaIntervencijaPostojecemPac : Form
    {
        public frmNovaIntervencijaPostojecemPac()
        {
            InitializeComponent();
        }
        int SelektovanID;
        int idDoktora;

        private void novaIntervencijaPostojecemPac_Load(object sender, EventArgs e)
        {
            gbIntervencija.Hide();
            this.Size = new Size(662, 383); //dok ne obelezi pacijenta u listi
            bNazad.Location = new Point(562, 311);

            #region dodajem tekst tbdatumu za danasnji datum
            string danasnjiDatum = DateTime.Now.ToString("dd.MM.yyyy");
            tbDatum.Text = danasnjiDatum;
            #endregion

            #region popunjavam comboBox sa doktorima
            List<string> rows = new List<string>();
            string sqlComm = "SELECT ime, prezime, brPecata, Naziv FROM doktor JOIN ordinacija ON doktor.ordinacija_id = ordinacija.Id";
            rows = DB.select4(sqlComm);
            popuniComboBox(comboBox1, rows);
            #endregion
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (listBox1.SelectedItem != null || (string)listBox1.SelectedItem != "")
                {
                    // prosiri formu, izvadi id i salji ga dalje. POsle obavezno poruku izbaci da je uspesno
                    gbIntervencija.Show();
                    this.Size = new Size(662, 647); //da se prosiri forma
                    bNazad.Location = new Point(562, 576);

                    //uzimam id selektovanog
                    string idS = listBox1.SelectedItem.ToString();
                    idS = idS.Substring(0, idS.IndexOf(","));
                    int id = Convert.ToInt32(idS);

                    //imamo id, treba sad da dodam intervenciju
                    SelektovanID = id;

                    //vadim id doktora
                    string brPecata = comboBox1.SelectedItem.ToString();
                    brPecata = brPecata.Substring(brPecata.IndexOf("pecata ") + 7, (brPecata.IndexOf("Ordinacija") - brPecata.IndexOf("pecata ") - 8));
                    string sqlComm = "SELECT Id FROM doktor WHERE brPecata ='" + brPecata + "'";
                    string idDoktoraSTRING = DB.select1(sqlComm);

                    idDoktora = Convert.ToInt32(idDoktoraSTRING); //ID DOKTORA
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Greška u unosu podataka", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bNazad_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Refresh();
            this.Hide();
        }

        private void novaIntervencijaPostojecemPac_FormClosing(object sender, FormClosingEventArgs e)
        {
          
        }

        private void bDodaj_Click(object sender, EventArgs e)
        {
            DB.insertIntervencijuZaPostojeceg(tbAnamneza.Text, tbDijagnoza.Text, tbTerapija.Text, tbPunaCena.Text, tbIsplaceno.Text, tbNapomena.Text, SelektovanID, idDoktora, tbDatum.Text);
           // MessageBox.Show(idDoktora.ToString());
        }

        private void bNadjiPacijenta_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            List<string> rows = new List<string>();
            rows = DB.select6("SELECT * FROM pacijent WHERE ime = '" + tbIme.Text + "' AND prezime = '" + tbPrezime.Text + "'"); //vadim sve pacijente po imenu i prezimenu
            popuniListBox(listBox1, rows);
        }
       
        

        int[] popuniListBox(ListBox lb, List<string> rows)
        {
            try
            {
                List<int> ids = new List<int>();
                foreach (var item in rows)
                {
                    lb.Items.Add(item.Split('|')[0] + ",     " + item.Split('|')[1] + " " + item.Split('|')[2] + ", Godina rodjenja: " + item.Split('|')[3] + ", Adresa: " + item.Split('|')[4] + ", Bolesti rizika: " + item.Split('|')[5]);
                    ids.Add(Convert.ToInt32(item.Split('|')[0]));
                }
                int[] id = ids.ToArray();
                return id;
            }
            catch (Exception )
            {
                MessageBox.Show("Greška u unosu!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;                            
            }
           
        }

        void popuniComboBox(ComboBox cb, List<string> rows)
        {
            try
            {
                foreach (var item in rows)
                {
                    cb.Items.Add(item.Split('|')[0] + " " + item.Split('|')[1] + ", broj pecata " + item.Split('|')[2] + " Ordinacija: " + item.Split('|')[3]);
                    cb.Text = (string)cb.Items[0];
                }
            }
            catch (Exception)
            {
                MessageBox.Show("U bazi ne postoji nijedan doktor!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://aleksapestalic.github.io");
        }
    }
}
