/*
 * Created by SharpDevelop.
 * User: harding legrand
 * Date: 03/01/2022
 * Time: 23:44
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using System.Web.Script.Serialization;

using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using System.Web.Script.Serialization;

namespace Connexion
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
        //Global int connect = 0;
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void PictureBox1Click(object sender, EventArgs e)
		{
	
		}
		void Label1Click(object sender, EventArgs e)
		{
	
		}
		void Label4Click(object sender, EventArgs e)
		{
            name.Text = "";
            password.Text = "";
            name.Focus();
		}
		void Label8Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

        private void button1_Click(object sender, EventArgs e)
        {
            
            try
            {
                MySqlConnection connexion = new MySqlConnection("database=ict207 ; server=localhost ; user id=root ; pwd=");
                connexion.Open();
                bool p; String names = name.Text, passwords = password.Text;

                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = connexion;
                cmd.CommandText = String.Format("select nom,password from connexion_client where nom ='{0}' AND password ='{1}' ", names, passwords );
                MySqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows) p = true; else p = false;
                if (p == true)
                {
                    MessageBox.Show("CONNEXION REUSSI !  ", "CONNEXION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //gestion.Enable = true;

                        menu men = new menu();
                        men.Show();
                        men.gestion.Enabled = true;
                        this.Hide();

                    connexion.Close();
                }
                else { MessageBox.Show(" UserName or Password Invalide.  ", "Compte", MessageBoxButtons.OK, MessageBoxIcon.Error); } 
                
            }
            catch { MessageBox.Show(" UserName ou Password Invalide.  ", "Compte", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

	}
}
