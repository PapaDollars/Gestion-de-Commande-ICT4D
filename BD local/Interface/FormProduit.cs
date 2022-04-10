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
    public partial class FormProduit : Form
    {
        public FormProduit()
        {
            InitializeComponent();
            
        }
      

        private void FormProduit_Load(object sender, EventArgs e)
        {

        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            refer.Text = "";
            intit.Text = "";
            qte.Text = "";
            prx.Text = "";
            cat.Text = "";
            numCom.Text = "";
            refer.Focus();
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            String reference = refer.Text;
            String num = numCom.Text;
            String intitule = intit.Text;
            String categorie = cat.Text;
            String quantite = qte.Text;
            String prix = prx.Text;
            refer.Focus();

            if (reference != "" & intitule != "" & quantite != "" & prix != "")
            {
                if (categorie == "Quincaillerie" | categorie == "accessoiresFfixatoin" | categorie == "boulonnerie" | categorie == "visserie" | categorie == "clouterie")
                {
                    MySqlConnection connexion = new MySqlConnection("database=ict207 ; server=localhost ; user id=root ; pwd=");
                    
                    try
                    {
                        connexion.Open();
                        // La commande Insert.
                        string sql = "Insert into produit (Reference, Intitule, Categorie , Quantite , Prix, numero) "
                                                         + " values (@reference, @intitule, @categorie ,@quantite ,@prix ,@num ) ";

                        MySqlCommand cmd = connexion.CreateCommand();
                        cmd.CommandText = sql;

                        cmd.CommandText = "INSERT INTO produit (Reference, Intitule, Categorie , Quantite , Prix, numero) VALUES (@reference, @intitule, @categorie ,@quantite ,@prix, @num)";

                        cmd.Parameters.AddWithValue("@Reference", refer.Text);
                        cmd.Parameters.AddWithValue("@Intitule", intit.Text);
                        cmd.Parameters.AddWithValue("@Categorie", cat.Text);
                        cmd.Parameters.AddWithValue("@Quantite", qte.Text);
                        cmd.Parameters.AddWithValue("@Prix", prx.Text);
                        cmd.Parameters.AddWithValue("@num", numCom.Text);

                        cmd.ExecuteNonQuery();

                        addproduit form = new addproduit();
                        form.ShowDialog();
                       // MessageBox.Show("Produit ajouter avec succes.");

                        connexion.Close();
                    }
                    catch
                    {
                        MessageBox.Show(" Echec De Connexion. ", " Attention ! ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else { MessageBox.Show("Categorie Non Selectionner."); }

            }
            else { champsvide form = new champsvide();form.ShowDialog(); /*MessageBox.Show(" Champ(s) Vide(s). ", " Attention ! ", MessageBoxButtons.OK, MessageBoxIcon.Error);*/ }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close() ;
        }

        private void num_com_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
