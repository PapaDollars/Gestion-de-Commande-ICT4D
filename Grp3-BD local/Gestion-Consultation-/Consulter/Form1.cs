using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Consulter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static string chaineDeConnexion = "database=ict207 ; server=localhost ; user id=root ; pwd=";
        static MySqlConnection cn = new MySqlConnection(chaineDeConnexion);



        public void SearchData(string valueToSearch)
        {

            try
            {
                //cn.Open();
                string query = "SELECT * FROM commande where CONCAT(`numero`, `cni`, `date`) like '%" + valueToSearch + "%'";
                MySqlCommand command = new MySqlCommand(query, cn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridView1.DataSource = table;


            }
            catch
            {

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string valueToSearh = textBoxValueToSearch.Text.ToString();
            SearchData(valueToSearh);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SearchData("");
        }

        private void button3_Click(object sender, EventArgs e)
        {
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
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
              
               textBox1.Text = "0";
                decimal Total = 0;

                for (int i = 0; i < dataGridView2.Rows.Count -1 ; i++)
                {
                    Total += Convert.ToDecimal(dataGridView2.Rows[i].Cells["Prix"].Value);
                }

                textBox1.Text = Total.ToString();
                cn.Close();
            }
            catch
            {

            }
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void textBoxValueToSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
