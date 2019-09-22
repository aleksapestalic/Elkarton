namespace Elektronski_karton
{
    partial class frmIzmenaPacijenta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIzmenaPacijenta));
            this.tbIme = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbPrezime = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.bNadjiPacijenta = new System.Windows.Forms.Button();
            this.bNazad = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bIzmeni = new System.Windows.Forms.Button();
            this.tbAdresa2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbIme2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbGodRodj2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tbPrezime2 = new System.Windows.Forms.TextBox();
            this.tbBolestiRizika2 = new System.Windows.Forms.TextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbIme
            // 
            this.tbIme.Location = new System.Drawing.Point(142, 43);
            this.tbIme.Name = "tbIme";
            this.tbIme.Size = new System.Drawing.Size(385, 20);
            this.tbIme.TabIndex = 34;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(23, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 18);
            this.label3.TabIndex = 40;
            this.label3.Text = "Prezime:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(23, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 18);
            this.label4.TabIndex = 39;
            this.label4.Text = "Ime:";
            // 
            // tbPrezime
            // 
            this.tbPrezime.Location = new System.Drawing.Point(142, 69);
            this.tbPrezime.Name = "tbPrezime";
            this.tbPrezime.Size = new System.Drawing.Size(385, 20);
            this.tbPrezime.TabIndex = 35;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(26, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(329, 18);
            this.label2.TabIndex = 38;
            this.label2.Text = "Izaberite pacijenta čije podatke želite da izmenite:";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(26, 173);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(501, 95);
            this.listBox1.TabIndex = 37;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // bNadjiPacijenta
            // 
            this.bNadjiPacijenta.Location = new System.Drawing.Point(443, 95);
            this.bNadjiPacijenta.Name = "bNadjiPacijenta";
            this.bNadjiPacijenta.Size = new System.Drawing.Size(84, 23);
            this.bNadjiPacijenta.TabIndex = 36;
            this.bNadjiPacijenta.Text = "OK";
            this.bNadjiPacijenta.UseVisualStyleBackColor = true;
            this.bNadjiPacijenta.Click += new System.EventHandler(this.bNadjiPacijenta_Click);
            // 
            // bNazad
            // 
            this.bNazad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bNazad.Location = new System.Drawing.Point(500, 558);
            this.bNazad.Name = "bNazad";
            this.bNazad.Size = new System.Drawing.Size(72, 25);
            this.bNazad.TabIndex = 41;
            this.bNazad.Text = "Nazad";
            this.bNazad.UseVisualStyleBackColor = true;
            this.bNazad.Click += new System.EventHandler(this.bNazad_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bIzmeni);
            this.groupBox2.Controls.Add(this.tbAdresa2);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.tbIme2);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.tbGodRodj2);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.tbPrezime2);
            this.groupBox2.Controls.Add(this.tbBolestiRizika2);
            this.groupBox2.Location = new System.Drawing.Point(29, 294);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(498, 245);
            this.groupBox2.TabIndex = 42;
            this.groupBox2.TabStop = false;
            // 
            // bIzmeni
            // 
            this.bIzmeni.Location = new System.Drawing.Point(403, 160);
            this.bIzmeni.Name = "bIzmeni";
            this.bIzmeni.Size = new System.Drawing.Size(64, 23);
            this.bIzmeni.TabIndex = 43;
            this.bIzmeni.Text = "Izmeni!";
            this.bIzmeni.UseVisualStyleBackColor = true;
            this.bIzmeni.Click += new System.EventHandler(this.bIzmeni_Click);
            // 
            // tbAdresa2
            // 
            this.tbAdresa2.Location = new System.Drawing.Point(134, 108);
            this.tbAdresa2.Name = "tbAdresa2";
            this.tbAdresa2.Size = new System.Drawing.Size(333, 20);
            this.tbAdresa2.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(15, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 18);
            this.label5.TabIndex = 21;
            this.label5.Text = "Adresa:";
            // 
            // tbIme2
            // 
            this.tbIme2.Location = new System.Drawing.Point(134, 30);
            this.tbIme2.Name = "tbIme2";
            this.tbIme2.Size = new System.Drawing.Size(333, 20);
            this.tbIme2.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(15, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 18);
            this.label6.TabIndex = 16;
            this.label6.Text = "Godina rođenja:";
            // 
            // tbGodRodj2
            // 
            this.tbGodRodj2.Location = new System.Drawing.Point(134, 82);
            this.tbGodRodj2.Name = "tbGodRodj2";
            this.tbGodRodj2.Size = new System.Drawing.Size(333, 20);
            this.tbGodRodj2.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(15, 133);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 18);
            this.label7.TabIndex = 14;
            this.label7.Text = "Bolesti rizika:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(15, 55);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 18);
            this.label9.TabIndex = 13;
            this.label9.Text = "Prezime:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.Location = new System.Drawing.Point(15, 29);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 18);
            this.label10.TabIndex = 12;
            this.label10.Text = "Ime:";
            // 
            // tbPrezime2
            // 
            this.tbPrezime2.Location = new System.Drawing.Point(134, 56);
            this.tbPrezime2.Name = "tbPrezime2";
            this.tbPrezime2.Size = new System.Drawing.Size(333, 20);
            this.tbPrezime2.TabIndex = 8;
            // 
            // tbBolestiRizika2
            // 
            this.tbBolestiRizika2.Location = new System.Drawing.Point(134, 134);
            this.tbBolestiRizika2.Name = "tbBolestiRizika2";
            this.tbBolestiRizika2.Size = new System.Drawing.Size(333, 20);
            this.tbBolestiRizika2.TabIndex = 11;
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.DarkRed;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.Navy;
            this.linkLabel1.Location = new System.Drawing.Point(419, 592);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(156, 13);
            this.linkLabel1.TabIndex = 43;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Made by Aleksa Peštalić, 2019.";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // frmIzmenaPacijenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 614);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.bNazad);
            this.Controls.Add(this.tbIme);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbPrezime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.bNadjiPacijenta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmIzmenaPacijenta";
            this.Text = "Izmena pacijenta - ELKARTON";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmIzmenaPacijenta_FormClosing);
            this.Load += new System.EventHandler(this.frmIzmenaPacijenta_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbIme;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbPrezime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button bNadjiPacijenta;
        private System.Windows.Forms.Button bNazad;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbAdresa2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbIme2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbGodRodj2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbPrezime2;
        private System.Windows.Forms.TextBox tbBolestiRizika2;
        private System.Windows.Forms.Button bIzmeni;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}