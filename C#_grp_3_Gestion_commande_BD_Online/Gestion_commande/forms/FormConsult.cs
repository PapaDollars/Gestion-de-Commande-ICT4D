using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Web.Script.Serialization;
using System;
using System.Drawing;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Gestion_commande.forms
{
    public partial class FormConsult : Form
    {
        List<Ref> allRef;
        List<Price> products;
        string numCom;
        public FormConsult()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (cni.Text == "")
            {


                MessageBox.Show("Veillez remplir le champs ID Commande");
            }
            else
            {
                string requestMethod = "POST";
                Stream dataStream;
                string postData = "codeClient=" + cni.Text;
                string contenttype = "application/x-www-form-urlencoded";
                byte[] byteArray = Encoding.UTF8.GetBytes(postData);
                String URL = "https://tpteam3.000webhostapp.com/userCommand.php";

                WebRequest req = WebRequest.Create(URL);
                req.Method = requestMethod;
                req.ContentLength = byteArray.Length;
                req.ContentType = contenttype;
                dataStream = req.GetRequestStream();
                dataStream.Write(byteArray, 0, byteArray.Length);

                dataStream.Close();

                WebResponse resp = req.GetResponse();
                StreamReader reader = new StreamReader(resp.GetResponseStream());

                string json = reader.ReadToEnd();
                Console.WriteLine(json);
                try
                {
                    JavaScriptSerializer js = new JavaScriptSerializer();
                    //User md=js.Deserialize<User>(json);
                    List<commande> md = JsonConvert.DeserializeObject<List<commande>>(json);
                    if (md.Count == 0)
                    {
                        MessageBox.Show("Commande non trouver");
                        dataGridView1.DataSource = null;
                    }
                    else
                    {
                        Console.WriteLine(md.Count);
                        dataGridView1.DataSource = md;
                        //date.Text = md[0].dateCom.Date.ToString();
                    }
                    dataGridView2.DataSource = null;
                }
                catch
                {
                    MessageBox.Show("Commande non trouver");
                }
                //Console.ReadLine();
            }
        }

        private void FirstLoad3(string numCode)
        {
            string requestMethod = "POST";
            Stream dataStream;
            string postData = "numCom=" + numCode;
            string contenttype = "application/x-www-form-urlencoded";
            byte[] byteArray = Encoding.UTF8.GetBytes(postData);
            String URL = "https://tpteam3.000webhostapp.com/selectAllRef.php";

            WebRequest req = WebRequest.Create(URL);
            req.Method = requestMethod;
            req.ContentLength = byteArray.Length;
            req.ContentType = contenttype;
            dataStream = req.GetRequestStream();
            dataStream.Write(byteArray, 0, byteArray.Length);

            dataStream.Close();

            WebResponse resp = req.GetResponse();
            StreamReader reader = new StreamReader(resp.GetResponseStream());

            string json = reader.ReadToEnd();
            Console.WriteLine(json);
            //try
            //{
            JavaScriptSerializer js = new JavaScriptSerializer();
            //User md=js.Deserialize<User>(json);
            allRef = JsonConvert.DeserializeObject<List<Ref>>(json);

            //Console.WriteLine(produi.Count);
            //for (int i = 0; i < produi.Count; i++)
            //{
            //cnis.Add(users[i].cni.ToString());

            //    .Items.Add(produi[i].reference);
            //}

            dataGridView2.DataSource = allRef;


            //dataGridView1.Columns["mdp"].Visible = false;
            //dataGridView1.Columns["isAdmin"].Visible = false;
        }

        private void dataGridView1_CellContentClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {
            numCom = dataGridView1.Rows[e.RowIndex].Cells["numCom"].FormattedValue.ToString();
            FirstLoad3(numCom);
            listeProducts();
            total.Text = somme().ToString();
        }

        private void dataGridView2_CellContentClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {

        }

        public int somme()
        {
            int total = 0;
            if (products != null)
            {
                for (int i = 0; i < allRef.Count; i++)
                {
                    total += allRef[i].qte * products[i].Prix;
                    //if (REFERENCE.SelectedItem.ToString() == allRef[i].nom)
                    //quantite.Text = allRef[i].qte.ToString();
                }
            }
            return total;
        }

        private void listeProducts()
        {
            string requestMethod = "POST";
            Stream dataStream;
            string postData = "numCom=" + numCom;
            string contenttype = "application/x-www-form-urlencoded";
            byte[] byteArray = Encoding.UTF8.GetBytes(postData);
            String URL = "https://tpteam3.000webhostapp.com/allUserProduct.php";

            WebRequest req = WebRequest.Create(URL);
            req.Method = requestMethod;
            req.ContentLength = byteArray.Length;
            req.ContentType = contenttype;
            dataStream = req.GetRequestStream();
            dataStream.Write(byteArray, 0, byteArray.Length);

            dataStream.Close();

            WebResponse resp = req.GetResponse();
            StreamReader reader = new StreamReader(resp.GetResponseStream());

            string json = reader.ReadToEnd();
            Console.WriteLine(json);
            //try
            //{
            JavaScriptSerializer js = new JavaScriptSerializer();
            //User md=js.Deserialize<User>(json);
            try
            {
                products = JsonConvert.DeserializeObject<List<Price>>(json);
            }
            catch (Exception e)
            {
            }
        }
    }
}
