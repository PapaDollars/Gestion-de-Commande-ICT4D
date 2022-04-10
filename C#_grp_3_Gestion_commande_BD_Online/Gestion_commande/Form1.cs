using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_commande
{
    public partial class Form1 : Form
    {
        private Form activeForm;

        public Form1()
        {
            InitializeComponent();
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();
            //ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktopPane.Controls.Add(childForm);
            this.panelDesktopPane.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            label1.Text = childForm.Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            OpenChildForm(new forms.FormClient(), sender);
        }

        private void btnProduits_Click(object sender, EventArgs e)
        {
            OpenChildForm(new forms.FormProduct(), sender);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenChildForm(new forms.FormCommande(), sender);
        }

        private void btnConsult_Click(object sender, EventArgs e)
        {
            OpenChildForm(new forms.FormConsult(), sender);
        }

        private void btnDeconnect_Click(object sender, EventArgs e)
        {
            new Login().Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
