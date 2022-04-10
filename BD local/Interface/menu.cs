using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Connexion
{
    public partial class menu : Form
    {
        //public int connect;
        public menu()
        {
            InitializeComponent();
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
            
        }

        private void déconnexionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gestion.Enabled = false;
            //if (gestion.Enabled == false) gestion.Enabled = true;
        }

        private void connexionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new MainForm().ShowDialog();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void gestionDesClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new BuyerForm().ShowDialog();
            this.Dispose();
        }

        private void gestionDesCommandesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new BuyingForm().ShowDialog();
            this.Hide();
        }

        private void gestionDesProduitsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ProductsForm().ShowDialog();
            this.Hide();
        }

        private void consultationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            new consultation().ShowDialog();
            this.Hide();
        }

        public void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void fichierToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

    
    }
}
