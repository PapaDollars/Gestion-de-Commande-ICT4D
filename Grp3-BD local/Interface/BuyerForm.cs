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
	/// Description of BuyerForm.
	/// </summary>
	public partial class BuyerForm : Form
	{
		public BuyerForm()
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
                string requete = "select * from connexion_client";
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
        private void actualiser() //procédure qui permet de charger le contenu de la table clientdans le Datagridview
        {
            MySqlConnection cn = new MySqlConnection("database=ict207 ; server=localhost ; user id=root ; pwd=");

            cn.Open();
            MySqlCommand cmd = new MySqlCommand("select * from connexion_client", cn);
            MySqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            view.DataSource = null;
            view.DataSource = dt;
            dr.Close();
            cn.Close();
        }
        private bool rechercher_cin(string s) //fonction qui permet de vérifier l'existence d'un client
        {
            MySqlConnection cn = new MySqlConnection("database=ict207 ; server=localhost ; user id=root ; pwd=");

            bool p = false;
            cn.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = cn;
            cmd.CommandText = "select * from connexion_client where cni ='" + s + "';";
            MySqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
                p = true;
            dr.Close();
            cn.Close();
            return p;
            
        }
		void Panel1Paint(object sender, PaintEventArgs e)
		{
			
		}
		void Button5Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
		void Button9Click(object sender, EventArgs e)
		{
	
		}
		void DataGridView1CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			
		}

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (view.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                view.CurrentRow.Selected = true;
                scni.Text = view.Rows[e.RowIndex].Cells[0].Value.ToString();
                password.Text = view.Rows[e.RowIndex].Cells[1].Value.ToString();
                name.Text = view.Rows[e.RowIndex].Cells[2].Value.ToString();
                surname.Text = view.Rows[e.RowIndex].Cells[3].Value.ToString();
                city.Text = view.Rows[e.RowIndex].Cells[4].Value.ToString();
                phone.Text = view.Rows[e.RowIndex].Cells[5].Value.ToString();
                
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            scni.Text = "";
            name.Text = "";
            surname.Text = "";
            city.Text = "";
            phone.Text = "";
            password.Text = "";
            cni.Focus();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MySqlConnection cn = new MySqlConnection("database=ict207 ; server=localhost ; user id=root ; pwd=");

            if (scni.Text == "" || name.Text == "" || surname.Text == "" || city.Text == "" || phone.Text == "" || password.Text == "") //controle de saisie
            {
                MessageBox.Show("Champ vide!!", "champ vide", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    cn.Open();
                    MySqlCommand cmd = new MySqlCommand("INSERT INTO connexion_client( cni,password,nom,prenom,ville,tel) VALUES(@cni,@password,@nom,@prenom,@ville,@tel)", cn);
                    cmd.Parameters.AddWithValue("@cni", scni.Text);
                    cmd.Parameters.AddWithValue("@password", password.Text);
                    cmd.Parameters.AddWithValue("@nom", name.Text);
                    cmd.Parameters.AddWithValue("@prenom", surname.Text);
                    cmd.Parameters.AddWithValue("@ville", city.Text);
                    cmd.Parameters.AddWithValue("@tel", phone.Text);
                    
                    cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();
                    MessageBox.Show("Ajouter!");

                    cn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    cn.Close();
                }

            }
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Recherche.Focus();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            search(Recherche.Text);
        }
        public void search(string recherchereference)
        {
            MySqlConnection connexion = new MySqlConnection("database=ict207 ; server=localhost ; user id=root ; pwd=");

            try
            {
                connexion.Open();

                string recherche = "select * from connexion_client where cni Like '%" + recherchereference + "%'";

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
                MessageBox.Show(ee.Message + "  Entrez une ''cni'' Valide.  ", "CNI Client", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        private void button9_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            

            if (scni.Text == "" || name.Text == "" || surname.Text == "" || city.Text == "" || phone.Text == "" || password.Text == "") //controle de saisie
            {
                MessageBox.Show("Champ vide!!", "champ vide", MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
            else // vérification de l'existence du client dont le CIN est saisi dans la zone CIN
            {
                try
                {
                   MySqlConnection connexion = new MySqlConnection("database=ict207 ; server=localhost ; user id=root ; pwd=");
                    connexion.Open();

                    MySqlCommand cmd = new MySqlCommand();
                    cmd.Connection = connexion;
                    cmd.CommandText = String.Format("delete from connexion_client where cni='{0}'", scni.Text);

                    int r = cmd.ExecuteNonQuery();
                    if (r != 0)
                    {
                        MessageBox.Show("Client Bien Supprimé", "Suppression", MessageBoxButtons.OK, MessageBoxIcon.Information);
                       scni.Text = "";
                        name.Text = "";
                        surname.Text = "";
                        city.Text = "";
                        phone.Text = "";
                        password.Text = "";
                        cni.Focus();

                        connexion.Close();
                    }

                    }
                    catch
                    {
                        MessageBox.Show(" Echec de Suppression. ", "Suppression", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
           
            MySqlConnection cn = new MySqlConnection("database=ict207 ; server=localhost ; user id=root ; pwd=");

            if (scni.Text == "" || name.Text == "" || surname.Text == "" || city.Text == "" || phone.Text == "" || password.Text == "") //controle de saisie
            {
                MessageBox.Show("Champ vide!!", "champ vide", MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
            else // vérification de l'existence du client dont le CIN est saisi dans la zone CIN
            {
                try
                {
                    MySqlConnection connexion = new MySqlConnection("database=ict207 ; server=localhost ; user id=root ; pwd=");
                    connexion.Open();

                    MySqlCommand cmd = new MySqlCommand();
                    cmd.Connection = connexion;
                    cmd.CommandText = "update connexion_client set password='" + password.Text + "',nom='" + name.Text + "',prenom='" + surname.Text + "',ville='" + city.Text + "',tel='" + phone.Text + "' where cni='" + scni.Text + "'";
                    int r = cmd.ExecuteNonQuery();

                    if (r != 0)
                    {
                        MessageBox.Show("Client Bien Modifié", "Modification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        connexion.Close();
                    }
                }
                catch
                {
                    MessageBox.Show(" Echec de Modifier ", "Modification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProductsForm form = new ProductsForm();
            form.ShowDialog();
        }

        private void SCIN_TextChanged(object sender, EventArgs e)
        {

        }
	}
}
