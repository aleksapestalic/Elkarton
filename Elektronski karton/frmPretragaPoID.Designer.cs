namespace Elektronski_karton
{
    partial class frmPretragaPoID
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPretragaPoID));
            this.bPretraga = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bNazad = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bPretraga
            // 
            this.bPretraga.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bPretraga.Location = new System.Drawing.Point(12, 86);
            this.bPretraga.Name = "bPretraga";
            this.bPretraga.Size = new System.Drawing.Size(467, 28);
            this.bPretraga.TabIndex = 18;
            this.bPretraga.Text = "Pretraži";
            this.bPretraga.UseVisualStyleBackColor = true;
            this.bPretraga.Click += new System.EventHandler(this.bPretraga_Click);
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(12, 120);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(467, 126);
            this.listView1.TabIndex = 17;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbID);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(467, 70);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(125, 27);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(325, 20);
            this.tbID.TabIndex = 1;
            this.tbID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbID_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(15, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 18);
            this.label1.TabIndex = 12;
            this.label1.Text = "Šifra pacijenta:";
            // 
            // bNazad
            // 
            this.bNazad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bNazad.Location = new System.Drawing.Point(407, 258);
            this.bNazad.Name = "bNazad";
            this.bNazad.Size = new System.Drawing.Size(72, 25);
            this.bNazad.TabIndex = 19;
            this.bNazad.Text = "Nazad";
            this.bNazad.UseVisualStyleBackColor = true;
            this.bNazad.Click += new System.EventHandler(this.bNazad_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.DarkRed;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.Navy;
            this.linkLabel1.Location = new System.Drawing.Point(326, 292);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(156, 13);
            this.linkLabel1.TabIndex = 20;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Made by Aleksa Peštalić, 2019.";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // frmPretragaPoID
            // 
            this.AcceptButton = this.bPretraga;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 314);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.bNazad);
            this.Controls.Add(this.bPretraga);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPretragaPoID";
            this.Text = "Pretraga po šifri pacijenta - ELKARTON";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPretragaPoID_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bPretraga;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bNazad;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}