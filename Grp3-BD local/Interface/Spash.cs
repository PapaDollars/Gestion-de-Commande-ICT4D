/*
 * Created by SharpDevelop.
 * User: harding legrand
 * Date: 04/01/2022
 * Time: 02:25
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Connexion
{
	/// <summary>
	/// Description of Spash.
	/// </summary>
	public partial class Spash : Form
	{
		public Spash()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		int startPoint = 0;
		void Timer1Tick(object sender, EventArgs e)
		{
			startPoint += 1;
			Myprogress.Value = startPoint;
			if(Myprogress.Value == 100)
			{
				Myprogress.Value = 0;
				timer1.Stop();
				menu log = new menu();
				this.Hide();
				log.Show();
			}
		}
		void SpashLoad(object sender, EventArgs e)
		{
			timer1.Start();

		}
	}
}
