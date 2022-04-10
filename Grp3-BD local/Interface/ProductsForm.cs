using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;   

namespace Connexion
{
	/// <summary>
	/// Description of ProductsForm.
	/// </summary>
	public partial class ProductsForm : Form
	{
        public string BaseDonnee = "database=ict207 ; server=localhost ; user id=root ; pwd=";

		public ProductsForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
            generates();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}

        public void generates()
        {
            MySqlConnection connexion = new MySqlConnection("database=ict207 ; server=localhost ; user id=root ; pwd=");
            connexion.Open();
            try
            {
                string requete = "select * from produit";
                MySqlCommand cmmd = new MySqlCommand(requete, connexion);
                MySqlDataAdapter data = new MySqlDataAdapter(cmmd);
                DataTable dt = new DataTable();
                dt.Clear();
                data.Fill(dt);
                view.DataSource = dt;

                connexion.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        
		void Button5Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

        private void button9_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            
            FormProduit form = new FormProduit();
            form.ShowDialog();
            

        }

        private void button11_Click(object sender, EventArgs e)
        {
            refer.Text = "";
            intit.Text = "";
            qte.Text = "";
            prx.Text = "";
            cat.Text = "";
            numCom.Text = "";
            refer.Focus();

            FormProduit form = new FormProduit();
            form.ShowDialog();
        }

        private void cat_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
           //editern 
            if (numCom.Text == "" | refer.Text == "" | intit.Text == "" | qte.Text == "" | prx.Text == "" | cat.Text == "") { MessageBox.Show(" Impossible de modifier. il y'a Un(des) Champ(s) Vide(s). ", "Impossible", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            else
            {
                try
                {
                    MySqlConnection connexion = new MySqlConnection("database=ict207 ; server=localhost ; user id=root ; pwd=");
                    connexion.Open();

                    MySqlCommand cmd = new MySqlCommand();
                    cmd.Connection = connexion;
                    cmd.CommandText = String.Format("update produit set Intitule='{0}',Quantite='{1}',Prix='{2}', Categorie='{3}' where  numero='{4} AND Reference='{5}'", intit.Text, qte.Text, prx.Text, cat.Text, numCom.Text, refer.Text);
                    int r = cmd.ExecuteNonQuery();

                    if (r != 0)
                    {
                        MessageBox.Show("Produit Bien Modifié", "Modification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        connexion.Close();
                    }
                }
                catch
                {
                    MessageBox.Show(" Echec de Modifier ", "Modification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //DELETE
            if (numCom.Text == "" | refer.Text == "" | intit.Text == "" | qte.Text == "" | prx.Text == "" | cat.Text == "") { MessageBox.Show(" Impossible de Supprimer. il y'a Un(des) Champ(s) Vide(s). ", "Impossible", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            else
            {
                try
                {
                    MySqlConnection connexion = new MySqlConnection(BaseDonnee);
                    connexion.Open();

                    MySqlCommand cmd = new MySqlCommand();
                    cmd.Connection = connexion;
                    cmd.CommandText = String.Format("delete from produit where Reference='{0}'", refer.Text);

                    int r = cmd.ExecuteNonQuery();
                    if (r != 0)
                    {
                        MessageBox.Show("Produit Bien Supprimé", "Suppression", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        refer.Text = "";
                        intit.Text = "";
                        qte.Text = "";
                        prx.Text = "";
                        cat.Text = "";
                        numCom.Text = "";
                        refer.Focus();

                        connexion.Close();
                    }

                }
                catch
                {
                    MessageBox.Show(" Echec de Suppression. ", "Suppression", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void view_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(view.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                view.CurrentRow.Selected = true;
                
                refer.Text = view.Rows[e.RowIndex].Cells[0].Value.ToString();
                intit.Text = view.Rows[e.RowIndex].Cells[1].Value.ToString();
                qte.Text = view.Rows[e.RowIndex].Cells[2].Value.ToString();
                prx.Text = view.Rows[e.RowIndex].Cells[3].Value.ToString();
                cat.Text = view.Rows[e.RowIndex].Cells[4].Value.ToString();
                numCom.Text = view.Rows[e.RowIndex].Cells[5].Value.ToString(); 
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Recherche.Focus();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void actualise_Click(object sender, EventArgs e)
        {
            generates();
        }
        
                
        private void button1_Click(object sender, EventArgs e)
        {
            string recherchereference = Recherche.Text.ToString();
            search(recherchereference);
        }

        public void search(string recherchereference) 
        {
            MySqlConnection connexion = new MySqlConnection("database=ict207 ; server=localhost ; user id=root ; pwd=");

            try
            {
                connexion.Open();
                
                string recherche = "select * from produit where Reference Like '%" + recherchereference + "%'";

                MySqlCommand cmmd = new MySqlCommand(recherche, connexion);
                MySqlDataAdapter data = new MySqlDataAdapter(cmmd);
                DataTable dt = new DataTable();
                dt.Clear();
                data.Fill(dt);
                view.DataSource = dt;

                connexion.Close();
            }
            catch(Exception ee)
            {
                MessageBox.Show(ee.Message + "  Entrez une ''Reference'' Valide.  ", "Reference", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void refer_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //
            MySqlConnection connexion = new MySqlConnection("database=ict207 ; server=localhost ; user id=root ; pwd=");

            try
            {
                connexion.Open();

                string recherche = "select * from produit where Categorie Like '%" + recherchecategorie.Text + "%'";

                MySqlCommand cmmd = new MySqlCommand(recherche, connexion);
                MySqlDataAdapter data = new MySqlDataAdapter(cmmd);
                DataTable dt = new DataTable();
                dt.Clear();
                data.Fill(dt);
                view.DataSource = dt;

                connexion.Close();
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message + "  Entrez une ''Categorie'' Valide.  ", "Categorie", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buyer_Click(object sender, EventArgs e)
        {
            BuyerForm form = new BuyerForm();
            form.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            consultation form = new consultation();
            form.ShowDialog();
        }

        private void Recherche_TextChanged(object sender, EventArgs e)
        {

        }

        private void numCom_TextChanged(object sender, EventArgs e)
        {

        }
	}
}
