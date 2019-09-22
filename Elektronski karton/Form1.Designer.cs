namespace Elektronski_karton
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pRETRAGAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.poImenuPrezimenuIGodiniRođenjaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.poBolestimaOpasnostiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.poJedinstvenojŠifriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uNOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.noviPacijentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novaIntervencijaPostojećemPacijentuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izmenaPostojećegToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pacijentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.intervencijeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listView1 = new System.Windows.Forms.ListView();
            this.tbPrezime = new System.Windows.Forms.TextBox();
            this.bPretraga = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.bReset = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pRETRAGAToolStripMenuItem,
            this.uNOSToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(719, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // pRETRAGAToolStripMenuItem
            // 
            this.pRETRAGAToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.poImenuPrezimenuIGodiniRođenjaToolStripMenuItem,
            this.poBolestimaOpasnostiToolStripMenuItem,
            this.poJedinstvenojŠifriToolStripMenuItem});
            this.pRETRAGAToolStripMenuItem.Name = "pRETRAGAToolStripMenuItem";
            this.pRETRAGAToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.pRETRAGAToolStripMenuItem.Text = "PRETRAGA";
            // 
            // poImenuPrezimenuIGodiniRođenjaToolStripMenuItem
            // 
            this.poImenuPrezimenuIGodiniRođenjaToolStripMenuItem.Name = "poImenuPrezimenuIGodiniRođenjaToolStripMenuItem";
            this.poImenuPrezimenuIGodiniRođenjaToolStripMenuItem.Size = new System.Drawing.Size(310, 22);
            this.poImenuPrezimenuIGodiniRođenjaToolStripMenuItem.Text = "Po imenu, prezimenu, adresi i godini rođenja";
            this.poImenuPrezimenuIGodiniRođenjaToolStripMenuItem.Click += new System.EventHandler(this.poImenuPrezimenuIGodiniRođenjaToolStripMenuItem_Click);
            // 
            // poBolestimaOpasnostiToolStripMenuItem
            // 
            this.poBolestimaOpasnostiToolStripMenuItem.Name = "poBolestimaOpasnostiToolStripMenuItem";
            this.poBolestimaOpasnostiToolStripMenuItem.Size = new System.Drawing.Size(310, 22);
            this.poBolestimaOpasnostiToolStripMenuItem.Text = "Po bolestima rizika";
            this.poBolestimaOpasnostiToolStripMenuItem.Click += new System.EventHandler(this.poBolestimaOpasnostiToolStripMenuItem_Click);
            // 
            // poJedinstvenojŠifriToolStripMenuItem
            // 
            this.poJedinstvenojŠifriToolStripMenuItem.Name = "poJedinstvenojŠifriToolStripMenuItem";
            this.poJedinstvenojŠifriToolStripMenuItem.Size = new System.Drawing.Size(310, 22);
            this.poJedinstvenojŠifriToolStripMenuItem.Text = "Po jedinstvenoj šifri";
            this.poJedinstvenojŠifriToolStripMenuItem.Click += new System.EventHandler(this.poJedinstvenojŠifriToolStripMenuItem_Click);
            // 
            // uNOSToolStripMenuItem
            // 
            this.uNOSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.noviPacijentToolStripMenuItem,
            this.novaIntervencijaPostojećemPacijentuToolStripMenuItem,
            this.izmenaPostojećegToolStripMenuItem});
            this.uNOSToolStripMenuItem.Name = "uNOSToolStripMenuItem";
            this.uNOSToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.uNOSToolStripMenuItem.Text = "UNOS";
            // 
            // noviPacijentToolStripMenuItem
            // 
            this.noviPacijentToolStripMenuItem.Name = "noviPacijentToolStripMenuItem";
            this.noviPacijentToolStripMenuItem.Size = new System.Drawing.Size(283, 22);
            this.noviPacijentToolStripMenuItem.Text = "Novi pacijent";
            this.noviPacijentToolStripMenuItem.Click += new System.EventHandler(this.noviPacijentToolStripMenuItem_Click);
            // 
            // novaIntervencijaPostojećemPacijentuToolStripMenuItem
            // 
            this.novaIntervencijaPostojećemPacijentuToolStripMenuItem.Name = "novaIntervencijaPostojećemPacijentuToolStripMenuItem";
            this.novaIntervencijaPostojećemPacijentuToolStripMenuItem.Size = new System.Drawing.Size(283, 22);
            this.novaIntervencijaPostojećemPacijentuToolStripMenuItem.Text = "Nova intervencija postojećem pacijentu";
            this.novaIntervencijaPostojećemPacijentuToolStripMenuItem.Click += new System.EventHandler(this.novaIntervencijaPostojećemPacijentuToolStripMenuItem_Click);
            // 
            // izmenaPostojećegToolStripMenuItem
            // 
            this.izmenaPostojećegToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pacijentaToolStripMenuItem,
            this.intervencijeToolStripMenuItem});
            this.izmenaPostojećegToolStripMenuItem.Name = "izmenaPostojećegToolStripMenuItem";
            this.izmenaPostojećegToolStripMenuItem.Size = new System.Drawing.Size(283, 22);
            this.izmenaPostojećegToolStripMenuItem.Text = "Izmena";
            // 
            // pacijentaToolStripMenuItem
            // 
            this.pacijentaToolStripMenuItem.Name = "pacijentaToolStripMenuItem";
            this.pacijentaToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.pacijentaToolStripMenuItem.Text = "Pacijenta";
            this.pacijentaToolStripMenuItem.Click += new System.EventHandler(this.pacijentaToolStripMenuItem_Click);
            // 
            // intervencijeToolStripMenuItem
            // 
            this.intervencijeToolStripMenuItem.Name = "intervencijeToolStripMenuItem";
            this.intervencijeToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.intervencijeToolStripMenuItem.Text = "Intervencije";
            this.intervencijeToolStripMenuItem.Click += new System.EventHandler(this.intervencijeToolStripMenuItem_Click);
            // 
            // listView1
            // 
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(12, 93);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(695, 463);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.DoubleClick += new System.EventHandler(this.listView1_DoubleClick);
            // 
            // tbPrezime
            // 
            this.tbPrezime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPrezime.Location = new System.Drawing.Point(95, 50);
            this.tbPrezime.Name = "tbPrezime";
            this.tbPrezime.Size = new System.Drawing.Size(100, 22);
            this.tbPrezime.TabIndex = 3;
            // 
            // bPretraga
            // 
            this.bPretraga.Location = new System.Drawing.Point(201, 50);
            this.bPretraga.Name = "bPretraga";
            this.bPretraga.Size = new System.Drawing.Size(81, 22);
            this.bPretraga.TabIndex = 4;
            this.bPretraga.Text = "Pretraga";
            this.bPretraga.UseVisualStyleBackColor = true;
            this.bPretraga.Click += new System.EventHandler(this.bPretraga_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Prezime:";
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.DarkRed;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.Navy;
            this.linkLabel1.Location = new System.Drawing.Point(554, 563);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(156, 13);
            this.linkLabel1.TabIndex = 7;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Made by Aleksa Peštalić, 2019.";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // bReset
            // 
            this.bReset.Location = new System.Drawing.Point(611, 51);
            this.bReset.Name = "bReset";
            this.bReset.Size = new System.Drawing.Size(96, 22);
            this.bReset.TabIndex = 8;
            this.bReset.Text = "Brisanje pretrage";
            this.bReset.UseVisualStyleBackColor = true;
            this.bReset.Click += new System.EventHandler(this.bReset_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.bPretraga;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 585);
            this.Controls.Add(this.bReset);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bPretraga);
            this.Controls.Add(this.tbPrezime);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "ELKARTON";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem pRETRAGAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem poImenuPrezimenuIGodiniRođenjaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem poBolestimaOpasnostiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem poJedinstvenojŠifriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uNOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem noviPacijentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izmenaPostojećegToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novaIntervencijaPostojećemPacijentuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pacijentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem intervencijeToolStripMenuItem;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TextBox tbPrezime;
        private System.Windows.Forms.Button bPretraga;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button bReset;
    }
}

