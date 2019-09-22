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
    public partial class novaIntervencijaPostojecemPac : Form
    {
        public novaIntervencijaPostojecemPac()
        {
            InitializeComponent();
        }

        private void novaIntervencijaPostojecemPac_Load(object sender, EventArgs e)
        {
            gbIntervencija.Hide();
            this.Size = new Size(530, 370); //dok ne obelezi pacijenta u listi
            bNazad.Location = new Point(430, 301);
            List<string> rows = new List<string>();
            rows = DB.select6("SELECT * FROM pacijent WHERE ime = '" + tbIme.Text + "' AND prezime = '" + tbPrezime.Text + "'"); //vadim sve pacijente po imenu i prezimenu
            popuniListBox(listBox1, rows);


            if (listBox1.SelectedItem != null || (string)listBox1.SelectedItem != "")
            {
                // prosiri firmu, izvadi id i salji ga dalje. POsle obavezno poruku izbaci da je uspesno
            }
        }

        private void bNazad_Click(object sender, EventArgs e)
        {
            Form frm1 = new Form1();
            frm1.Show(); this.Hide();
        }

        private void novaIntervencijaPostojecemPac_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void bDodaj_Click(object sender, EventArgs e)
        {

        }

        int[] popuniListBox(ListBox lb, List<string> rows)
        {
            List<int> ids = new List<int>();
            foreach (var item in rows)
            {
                lb.Items.Add(item.Split('|')[1] + " " + item.Split('|')[2] + ", Godina rodjenja: " + item.Split('|')[3] + ", Adresa: " + item.Split('|')[4] + ", Bolesti rizika: " + item.Split('|')[5]);
                ids.Add(Convert.ToInt32(item.Split('|')[0]));
            }
            int[] id = ids.ToArray();
            return id;
        }
    }
}
