/*
 * Created by SharpDevelop.
 * User: harding legrand
 * Date: 05/01/2022
 * Time: 01:55
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Connexion
{
	/// <summary>
	/// Description of CategotyForm.
	/// </summary>
	public partial class CategotyForm : Form
	{
		public CategotyForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
	}
}
