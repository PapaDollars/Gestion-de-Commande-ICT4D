namespace Connexion
{
    partial class menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(menu));
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connexionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.déconnexionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestion = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDesClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDesCommandesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDesProduitsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Location = new System.Drawing.Point(40, 78);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(660, 278);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Black;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem,
            this.gestion,
            this.quitterToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(740, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connexionToolStripMenuItem,
            this.déconnexionToolStripMenuItem});
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.fichierToolStripMenuItem.Text = "Fichier";
            this.fichierToolStripMenuItem.Click += new System.EventHandler(this.fichierToolStripMenuItem_Click);
            // 
            // connexionToolStripMenuItem
            // 
            this.connexionToolStripMenuItem.Name = "connexionToolStripMenuItem";
            this.connexionToolStripMenuItem.Size = new System.Drawing.Size(165, 24);
            this.connexionToolStripMenuItem.Text = "Connexion";
            this.connexionToolStripMenuItem.Click += new System.EventHandler(this.connexionToolStripMenuItem_Click);
            // 
            // déconnexionToolStripMenuItem
            // 
            this.déconnexionToolStripMenuItem.Enabled = false;
            this.déconnexionToolStripMenuItem.Name = "déconnexionToolStripMenuItem";
            this.déconnexionToolStripMenuItem.Size = new System.Drawing.Size(165, 24);
            this.déconnexionToolStripMenuItem.Text = "Déconnexion";
            this.déconnexionToolStripMenuItem.Click += new System.EventHandler(this.déconnexionToolStripMenuItem_Click);
            // 
            // gestion
            // 
            this.gestion.BackColor = System.Drawing.Color.White;
            this.gestion.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionDesClientToolStripMenuItem,
            this.gestionDesCommandesToolStripMenuItem,
            this.gestionDesProduitsToolStripMenuItem,
            this.consultationToolStripMenuItem});
            this.gestion.Enabled = false;
            this.gestion.Name = "gestion";
            this.gestion.Size = new System.Drawing.Size(71, 24);
            this.gestion.Text = "Gestion";
            this.gestion.Click += new System.EventHandler(this.gestion_Click);
            // 
            // gestionDesClientToolStripMenuItem
            // 
            this.gestionDesClientToolStripMenuItem.Name = "gestionDesClientToolStripMenuItem";
            this.gestionDesClientToolStripMenuItem.Size = new System.Drawing.Size(251, 24);
            this.gestionDesClientToolStripMenuItem.Text = "Gestion des Client...";
            this.gestionDesClientToolStripMenuItem.Click += new System.EventHandler(this.gestionDesClientToolStripMenuItem_Click);
            // 
            // gestionDesCommandesToolStripMenuItem
            // 
            this.gestionDesCommandesToolStripMenuItem.Name = "gestionDesCommandesToolStripMenuItem";
            this.gestionDesCommandesToolStripMenuItem.Size = new System.Drawing.Size(251, 24);
            this.gestionDesCommandesToolStripMenuItem.Text = "Gestion des Commandes...";
            this.gestionDesCommandesToolStripMenuItem.Click += new System.EventHandler(this.gestionDesCommandesToolStripMenuItem_Click);
            // 
            // gestionDesProduitsToolStripMenuItem
            // 
            this.gestionDesProduitsToolStripMenuItem.Name = "gestionDesProduitsToolStripMenuItem";
            this.gestionDesProduitsToolStripMenuItem.Size = new System.Drawing.Size(251, 24);
            this.gestionDesProduitsToolStripMenuItem.Text = "Gestion des Produits";
            this.gestionDesProduitsToolStripMenuItem.Click += new System.EventHandler(this.gestionDesProduitsToolStripMenuItem_Click);
            // 
            // consultationToolStripMenuItem
            // 
            this.consultationToolStripMenuItem.Name = "consultationToolStripMenuItem";
            this.consultationToolStripMenuItem.Size = new System.Drawing.Size(251, 24);
            this.consultationToolStripMenuItem.Text = "Consultation";
            this.consultationToolStripMenuItem.Click += new System.EventHandler(this.consultationToolStripMenuItem_Click);
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
            this.quitterToolStripMenuItem.Text = "Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(705, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "X";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(740, 399);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "menu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connexionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem déconnexionToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem gestion;
        private System.Windows.Forms.ToolStripMenuItem gestionDesClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDesCommandesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDesProduitsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.Label label1;
    }
}