namespace Elektronski_karton
{
    partial class frmIzmenaIntervencijeUnos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIzmenaIntervencijeUnos));
            this.listView1 = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.tbAnamneza = new System.Windows.Forms.TextBox();
            this.tbDijagnoza = new System.Windows.Forms.TextBox();
            this.tbTerapija = new System.Windows.Forms.TextBox();
            this.tbPunaCena = new System.Windows.Forms.TextBox();
            this.tbIsplaceno = new System.Windows.Forms.TextBox();
            this.tbNapomena = new System.Windows.Forms.TextBox();
            this.tbDatum = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.bUnesi = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(12, 40);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(605, 193);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.Click += new System.EventHandler(this.listView1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(293, 18);
            this.label2.TabIndex = 46;
            this.label2.Text = "Izaberite intervenciju koju želite da izmenite:";
            // 
            // tbAnamneza
            // 
            this.tbAnamneza.Location = new System.Drawing.Point(108, 252);
            this.tbAnamneza.Multiline = true;
            this.tbAnamneza.Name = "tbAnamneza";
            this.tbAnamneza.Size = new System.Drawing.Size(509, 20);
            this.tbAnamneza.TabIndex = 47;
            // 
            // tbDijagnoza
            // 
            this.tbDijagnoza.Location = new System.Drawing.Point(108, 278);
            this.tbDijagnoza.Name = "tbDijagnoza";
            this.tbDijagnoza.Size = new System.Drawing.Size(509, 20);
            this.tbDijagnoza.TabIndex = 48;
            // 
            // tbTerapija
            // 
            this.tbTerapija.Location = new System.Drawing.Point(108, 304);
            this.tbTerapija.Name = "tbTerapija";
            this.tbTerapija.Size = new System.Drawing.Size(509, 20);
            this.tbTerapija.TabIndex = 49;
            // 
            // tbPunaCena
            // 
            this.tbPunaCena.Location = new System.Drawing.Point(108, 330);
            this.tbPunaCena.Name = "tbPunaCena";
            this.tbPunaCena.Size = new System.Drawing.Size(509, 20);
            this.tbPunaCena.TabIndex = 50;
            // 
            // tbIsplaceno
            // 
            this.tbIsplaceno.Location = new System.Drawing.Point(108, 356);
            this.tbIsplaceno.Name = "tbIsplaceno";
            this.tbIsplaceno.Size = new System.Drawing.Size(509, 20);
            this.tbIsplaceno.TabIndex = 51;
            // 
            // tbNapomena
            // 
            this.tbNapomena.Location = new System.Drawing.Point(108, 382);
            this.tbNapomena.Name = "tbNapomena";
            this.tbNapomena.Size = new System.Drawing.Size(509, 20);
            this.tbNapomena.TabIndex = 52;
            // 
            // tbDatum
            // 
            this.tbDatum.Location = new System.Drawing.Point(108, 408);
            this.tbDatum.Name = "tbDatum";
            this.tbDatum.Size = new System.Drawing.Size(509, 20);
            this.tbDatum.TabIndex = 53;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.Location = new System.Drawing.Point(9, 251);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 18);
            this.label10.TabIndex = 56;
            this.label10.Text = "Anamneza:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(9, 277);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 18);
            this.label1.TabIndex = 57;
            this.label1.Text = "Dijagnoza:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(9, 303);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 18);
            this.label3.TabIndex = 58;
            this.label3.Text = "Terapija:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(9, 329);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 18);
            this.label4.TabIndex = 59;
            this.label4.Text = "Puna cena:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(9, 355);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 18);
            this.label5.TabIndex = 60;
            this.label5.Text = "Isplaćeno:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(9, 381);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 18);
            this.label6.TabIndex = 61;
            this.label6.Text = "Napomena:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(9, 407);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 18);
            this.label7.TabIndex = 62;
            this.label7.Text = "Datum:";
            // 
            // bUnesi
            // 
            this.bUnesi.Location = new System.Drawing.Point(523, 434);
            this.bUnesi.Name = "bUnesi";
            this.bUnesi.Size = new System.Drawing.Size(94, 32);
            this.bUnesi.TabIndex = 63;
            this.bUnesi.Text = "Izmeni!";
            this.bUnesi.UseVisualStyleBackColor = true;
            this.bUnesi.Click += new System.EventHandler(this.bUnesi_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(555, 489);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(62, 25);
            this.button1.TabIndex = 64;
            this.button1.Text = "Nazad";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.DarkRed;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.Navy;
            this.linkLabel1.Location = new System.Drawing.Point(464, 522);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(156, 13);
            this.linkLabel1.TabIndex = 65;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Made by Aleksa Peštalić, 2019.";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // frmIzmenaIntervencijeUnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 544);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bUnesi);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tbDatum);
            this.Controls.Add(this.tbNapomena);
            this.Controls.Add(this.tbIsplaceno);
            this.Controls.Add(this.tbPunaCena);
            this.Controls.Add(this.tbTerapija);
            this.Controls.Add(this.tbDijagnoza);
            this.Controls.Add(this.tbAnamneza);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmIzmenaIntervencijeUnos";
            this.Text = "Izmena intervencije - ELKARTON";
            this.Load += new System.EventHandler(this.frmIzmenaIntervencijeUnos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbAnamneza;
        private System.Windows.Forms.TextBox tbDijagnoza;
        private System.Windows.Forms.TextBox tbTerapija;
        private System.Windows.Forms.TextBox tbPunaCena;
        private System.Windows.Forms.TextBox tbIsplaceno;
        private System.Windows.Forms.TextBox tbNapomena;
        private System.Windows.Forms.TextBox tbDatum;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button bUnesi;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}