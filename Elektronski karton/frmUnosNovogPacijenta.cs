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
    public partial class frmUnosNovogPacijenta : Form
    {
        public frmUnosNovogPacijenta()
        {
            InitializeComponent();
        }
        int idDoktora = 0;
        private void frmUnosNovogPacijenta_Load(object sender, EventArgs e)
        {
            this.Height = 313;
            bNazad.Location = new Point(421, 245);
            groupBox2.Hide();

            #region popunjavam comboBox sa doktorima
            List<string> rows = new List<string>();
            string sqlComm = "SELECT ime, prezime, brPecata, Naziv FROM doktor JOIN ordinacija ON doktor.ordinacija_id = ordinacija.Id";
            rows = DB.select4(sqlComm);
            popuniComboBox(comboBox1, rows);
            #endregion

            #region dodajem tekst tbdatumu za danasnji datum
            string danasnjiDatum = DateTime.Now.ToString("dd.MM.yyyy");
            tbDatum.Text = danasnjiDatum;
            #endregion

            
        }
        private void bUnesi_Click(object sender, EventArgs e)
        {
            if (!cbIntervencija.Checked)
            {
                this.Height = 313;
                bNazad.Location = new Point(421, 245);
                DB.insertPacijent(tbIme.Text, tbPrezime.Text, tbGodRodj.Text, tbAdresa.Text, tbBolestiRizika.Text);
            }
            else //ako unosim i intervenciju
            {
                #region trazim id doktora
                string brPecata = comboBox1.SelectedItem.ToString();
                brPecata = brPecata.Substring(brPecata.IndexOf("pecata ") + 7, (brPecata.IndexOf("Ordinacija") - brPecata.IndexOf("pecata ") - 8));
                string sqlComm1 = "SELECT Id FROM doktor WHERE brPecata ='" + brPecata + "'";
                idDoktora = Convert.ToInt32(DB.select1(sqlComm1));
                #endregion

                this.Height = 566;
                bNazad.Location = new Point(421, 496);
                DB.insertIntervencijaUzPacijenta(tbAnamneza.Text, tbDijagnoza.Text, tbTerapija.Text, tbPunaCena.Text, tbIsplaceno.Text,
                    tbNapomena.Text, idDoktora, tbDatum.Text, tbIme.Text, tbPrezime.Text, tbGodRodj.Text, tbAdresa.Text, tbBolestiRizika.Text);
            }
        }

        private void frmUnosNovogPacijenta_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
        
        private void cbIntervencija_CheckedChanged(object sender, EventArgs e)
        {
            if (!cbIntervencija.Checked)
            {
                this.Height = 313;
                bNazad.Location = new Point(421, 245);
                groupBox2.Hide();
            }
            else
            {
                this.Height = 566;
                bNazad.Location = new Point(421, 496);
                groupBox2.Show();
            }
        }

        private void tbGodRodj_KeyPress(object sender, KeyPressEventArgs e)
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

        private void tbBrPecata_KeyPress(object sender, KeyPressEventArgs e)
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

        private void bNazad_Click(object sender, EventArgs e)
        {            
            this.Hide();
        }

        #region popuniComboBox
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
        #endregion

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://aleksapestalic.github.io");
        }
    }
}
    

