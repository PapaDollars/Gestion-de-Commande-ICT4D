using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Connexion
{
    public partial class consultation : Form
    {
        public consultation()
        {
            InitializeComponent();
            generates();
        }
        public void generates()
        {
            MySqlConnection connexion = new MySqlConnection("database=ict207 ; server=localhost ; user id=root ; pwd=");
            connexion.Open();
            try
            {
                string requete = "select * from commande";
                MySqlCommand cmmd = new MySqlCommand(requete, connexion);
                MySqlDataAdapter data = new MySqlDataAdapter(cmmd);
                DataTable dt = new DataTable();
                dt.Clear();
                data.Fill(dt);
                dataGridView1.DataSource = dt;

                connexion.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        public void SearchData(string valueToSearch)
        {
            MySqlConnection cn = new MySqlConnection("database=ict207 ; server=localhost ; user id=root ; pwd=");
            try
            {

                cn.Open();
                string query = "SELECT * FROM commande where CONCAT(`numero`, `cni`, `date`) like '%" + valueToSearch + "%'";
                MySqlCommand command = new MySqlCommand(query, cn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridView1.DataSource = table;
                cn.Close();

            }
            catch
            {
                MessageBox.Show("La selection des commande a Echouer");
            }

        }

       
        private void button3_Click(object sender, EventArgs e)
        {
            MySqlConnection cn = new MySqlConnection("database=ict207 ; server=localhost ; user id=root ; pwd=");

            try
            {
               
                cn.Open();
                MySqlCommand cmd = new MySqlCommand("select * from commande", cn);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;
                cn.Close();


            }
            catch
            {

                MessageBox.Show("Vous n'etes pas connecter");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string valueToSearh = textBoxValueToSearch.Text.ToString();
            SearchData(valueToSearh);
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ProductsForm form = new ProductsForm();
            form.ShowDialog();
        }

        private void buyer_Click(object sender, EventArgs e)
        {
            BuyerForm FORM = new BuyerForm();
            FORM.ShowDialog();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            string valueToSearh = textBoxValueToSearch.Text.ToString();
            SearchData(valueToSearh);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                MySqlConnection cn = new MySqlConnection("database=ict207 ; server=localhost ; user id=root ; pwd=");
                String temp;
                //dataGridView1.CurrentRow.Selected = true;
                temp = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                cn.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "select * from produit where numero='" + temp + "'";
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView2.DataSource = dt;

                total.Text = "0";
                decimal Total = 0;

                for (int i = 0; i < dataGridView2.Rows.Count - 1; i++)
                {
                    Total += Convert.ToDecimal(dataGridView2.Rows[i].Cells["Prix"].Value);
                }

                total.Text = Total.ToString();
                cn.Close();
            }
            catch
            {

            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection cn = new MySqlConnection("database=ict207 ; server=localhost ; user id=root ; pwd=");
                cn.Open();
                MySqlCommand cmd = new MySqlCommand("select * from commande", cn);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;
                cn.Close();


            }
            catch
            {

                MessageBox.Show("Vous n'etes pas connecter");
            }
        }

    }
}
