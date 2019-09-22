namespace Elektronski_karton
{
    partial class frmDetaljiPacijenta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDetaljiPacijenta));
            this.lIme = new System.Windows.Forms.Label();
            this.lPrezime = new System.Windows.Forms.Label();
            this.lGodiste = new System.Windows.Forms.Label();
            this.lAdresa = new System.Windows.Forms.Label();
            this.lBolestiRizika = new System.Windows.Forms.Label();
            this.lSifraPacijenta = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lIme
            // 
            this.lIme.AutoSize = true;
            this.lIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lIme.Location = new System.Drawing.Point(9, 24);
            this.lIme.Name = "lIme";
            this.lIme.Size = new System.Drawing.Size(32, 18);
            this.lIme.TabIndex = 0;
            this.lIme.Text = "Ime";
            // 
            // lPrezime
            // 
            this.lPrezime.AutoSize = true;
            this.lPrezime.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lPrezime.Location = new System.Drawing.Point(9, 42);
            this.lPrezime.Name = "lPrezime";
            this.lPrezime.Size = new System.Drawing.Size(63, 18);
            this.lPrezime.TabIndex = 1;
            this.lPrezime.Text = "Prezime";
            // 
            // lGodiste
            // 
            this.lGodiste.AutoSize = true;
            this.lGodiste.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lGodiste.Location = new System.Drawing.Point(9, 60);
            this.lGodiste.Name = "lGodiste";
            this.lGodiste.Size = new System.Drawing.Size(60, 18);
            this.lGodiste.TabIndex = 2;
            this.lGodiste.Text = "Godiste";
            // 
            // lAdresa
            // 
            this.lAdresa.AutoSize = true;
            this.lAdresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lAdresa.Location = new System.Drawing.Point(9, 78);
            this.lAdresa.Name = "lAdresa";
            this.lAdresa.Size = new System.Drawing.Size(54, 18);
            this.lAdresa.TabIndex = 3;
            this.lAdresa.Text = "Adresa";
            // 
            // lBolestiRizika
            // 
            this.lBolestiRizika.AutoSize = true;
            this.lBolestiRizika.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lBolestiRizika.Location = new System.Drawing.Point(9, 96);
            this.lBolestiRizika.Name = "lBolestiRizika";
            this.lBolestiRizika.Size = new System.Drawing.Size(92, 18);
            this.lBolestiRizika.TabIndex = 4;
            this.lBolestiRizika.Text = "bolestiRizika";
            // 
            // lSifraPacijenta
            // 
            this.lSifraPacijenta.AutoSize = true;
            this.lSifraPacijenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lSifraPacijenta.Location = new System.Drawing.Point(9, 147);
            this.lSifraPacijenta.Name = "lSifraPacijenta";
            this.lSifraPacijenta.Size = new System.Drawing.Size(96, 18);
            this.lSifraPacijenta.TabIndex = 5;
            this.lSifraPacijenta.Text = "sifraPacijenta";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lPrezime);
            this.groupBox1.Controls.Add(this.lSifraPacijenta);
            this.groupBox1.Controls.Add(this.lIme);
            this.groupBox1.Controls.Add(this.lBolestiRizika);
            this.groupBox1.Controls.Add(this.lGodiste);
            this.groupBox1.Controls.Add(this.lAdresa);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(398, 187);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Podaci o pacijentu";
            // 
            // listView1
            // 
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(12, 233);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(776, 272);
            this.listView1.TabIndex = 7;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 212);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Intervencije:";
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.DarkRed;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.Navy;
            this.linkLabel1.Location = new System.Drawing.Point(635, 511);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(153, 13);
            this.linkLabel1.TabIndex = 8;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Made by Aleksa Peštalić, 2018";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // frmDetaljiPacijenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 533);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDetaljiPacijenta";
            this.Text = "Detalji pacijenta - ELKARTON";
            this.Load += new System.EventHandler(this.frmDetaljiPacijenta_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lIme;
        private System.Windows.Forms.Label lPrezime;
        private System.Windows.Forms.Label lGodiste;
        private System.Windows.Forms.Label lAdresa;
        private System.Windows.Forms.Label lBolestiRizika;
        private System.Windows.Forms.Label lSifraPacijenta;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}