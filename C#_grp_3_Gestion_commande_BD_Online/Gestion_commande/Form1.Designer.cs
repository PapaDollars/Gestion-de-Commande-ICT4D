namespace Gestion_commande
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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnDeconnect = new System.Windows.Forms.Button();
            this.btnConsult = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnProduits = new System.Windows.Forms.Button();
            this.btnClient = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelDesktopPane = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panelMenu.Controls.Add(this.btnDeconnect);
            this.panelMenu.Controls.Add(this.btnConsult);
            this.panelMenu.Controls.Add(this.button3);
            this.panelMenu.Controls.Add(this.btnProduits);
            this.panelMenu.Controls.Add(this.btnClient);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(496, 1172);
            this.panelMenu.TabIndex = 0;
            // 
            // btnDeconnect
            // 
            this.btnDeconnect.Image = global::Gestion_commande.Properties.Resources.settings;
            this.btnDeconnect.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeconnect.Location = new System.Drawing.Point(0, 610);
            this.btnDeconnect.Name = "btnDeconnect";
            this.btnDeconnect.Size = new System.Drawing.Size(496, 102);
            this.btnDeconnect.TabIndex = 5;
            this.btnDeconnect.Text = "DECONNEXION";
            this.btnDeconnect.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDeconnect.UseVisualStyleBackColor = true;
            this.btnDeconnect.Click += new System.EventHandler(this.btnDeconnect_Click);
            // 
            // btnConsult
            // 
            this.btnConsult.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnConsult.Image = global::Gestion_commande.Properties.Resources.bar_chart;
            this.btnConsult.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsult.Location = new System.Drawing.Point(0, 508);
            this.btnConsult.Name = "btnConsult";
            this.btnConsult.Size = new System.Drawing.Size(496, 102);
            this.btnConsult.TabIndex = 4;
            this.btnConsult.Text = "CONSULTATION";
            this.btnConsult.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConsult.UseVisualStyleBackColor = true;
            this.btnConsult.Click += new System.EventHandler(this.btnConsult_Click);
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Top;
            this.button3.Image = global::Gestion_commande.Properties.Resources.shopping_cart__1_;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(0, 406);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(496, 102);
            this.button3.TabIndex = 3;
            this.button3.Text = "GESTION DES COMMANDES";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnProduits
            // 
            this.btnProduits.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProduits.Image = global::Gestion_commande.Properties.Resources.shopping_list;
            this.btnProduits.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProduits.Location = new System.Drawing.Point(0, 304);
            this.btnProduits.Name = "btnProduits";
            this.btnProduits.Size = new System.Drawing.Size(496, 102);
            this.btnProduits.TabIndex = 2;
            this.btnProduits.Text = "GESTION DES PRODUITS";
            this.btnProduits.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProduits.UseVisualStyleBackColor = true;
            this.btnProduits.Click += new System.EventHandler(this.btnProduits_Click);
            // 
            // btnClient
            // 
            this.btnClient.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnClient.Image = global::Gestion_commande.Properties.Resources.value__1_;
            this.btnClient.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClient.Location = new System.Drawing.Point(0, 202);
            this.btnClient.Name = "btnClient";
            this.btnClient.Size = new System.Drawing.Size(496, 102);
            this.btnClient.TabIndex = 1;
            this.btnClient.Text = "GESTION DES CLIENTS";
            this.btnClient.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClient.UseVisualStyleBackColor = true;
            this.btnClient.Click += new System.EventHandler(this.btnClient_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.panel1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(496, 202);
            this.panelLogo.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(496, 202);
            this.panel1.TabIndex = 0;
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panelTitleBar.Controls.Add(this.label1);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(496, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(1699, 100);
            this.panelTitleBar.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(653, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(431, 88);
            this.label1.TabIndex = 0;
            this.label1.Text = "ACCEUIL";
            // 
            // panelDesktopPane
            // 
            this.panelDesktopPane.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktopPane.Location = new System.Drawing.Point(496, 100);
            this.panelDesktopPane.Name = "panelDesktopPane";
            this.panelDesktopPane.Size = new System.Drawing.Size(1699, 1072);
            this.panelDesktopPane.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2195, 1172);
            this.Controls.Add(this.panelDesktopPane);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelTitleBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnClient;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button btnConsult;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnProduits;
        private System.Windows.Forms.Button btnDeconnect;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelDesktopPane;
    }
}

