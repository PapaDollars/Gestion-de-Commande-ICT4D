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
    public partial class FormClient : Form
    {
        public FormClient()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FormClient_Load(object sender, EventArgs e)
        {
            FirstLoad();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            cni.Text = "";
            name.Text = "";
            surname.Text = "";
            city.Text = "";
            phone.Text = "";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (cni.Text == "")
            {
                name.Text = "";
                surname.Text = "";
                city.Text = "";
                phone.Text = "";
                MessageBox.Show("Veillez remplir le champs cni");
            }
            else
            {
                string requestMethod = "POST";
                Stream dataStream;
                string postData = "cni=" + cni.Text;
                string contenttype = "application/x-www-form-urlencoded";
                byte[] byteArray = Encoding.UTF8.GetBytes(postData);
                String URL = "https://tpteam3.000webhostapp.com/rechercherClient.php";

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

                JavaScriptSerializer js = new JavaScriptSerializer();
                //User md=js.Deserialize<User>(json);
                List<User> md = JsonConvert.DeserializeObject<List<User>>(json);

                if (md.Count == 0)
                {
                    MessageBox.Show("Utilisateur non trouver");
                }
                else
                {
                    Console.WriteLine(md.Count);

                    Console.WriteLine(md[0].nom);
                    Console.WriteLine(md[0].mdp);
                    Console.WriteLine(md[0].cni);
                    name.Text = md[0].nom;
                    surname.Text = md[0].prenom;
                    city.Text = md[0].ville;
                    phone.Text = md[0].numTel.ToString();
                }
            }
            Console.ReadLine();
        }


        // fonction pour charger les donnees
        private void FirstLoad()
        {
            HttpWebRequest WebReq = (HttpWebRequest)WebRequest.Create(string.Format("https://tpteam3.000webhostapp.com/allUsers.php"));

            WebReq.Method = "POST";

            HttpWebResponse WebResp = (HttpWebResponse)WebReq.GetResponse();

            Console.WriteLine(WebResp.StatusCode);
            Console.WriteLine(WebResp.Server);

            string jsonString;
            using (Stream stream = WebResp.GetResponseStream())   //modified from your code since the using statement disposes the stream automatically when done
            {
                StreamReader reader = new StreamReader(stream, System.Text.Encoding.UTF8);
                jsonString = reader.ReadToEnd();
            }

            List<User> users = JsonConvert.DeserializeObject<List<User>>(jsonString);

            Console.WriteLine(users.Count);


            dataGridView1.DataSource = users;

            dataGridView1.Columns["mdp"].Visible = false;
            dataGridView1.Columns["isAdmin"].Visible = false;
        }

        private void btnAdd_Click(object sender, System.EventArgs e)
        {
            if (cni.Text == "" || name.Text == "" || surname.Text == "" || city.Text == "" || phone.Text == "")
            {
                MessageBox.Show("Veillez remplir tous les champs");
            }
            else
            {
                try
                {
                    string requestMethod = "POST";
                    Stream dataStream;
                    //string postData = "var1=Hello&var2=Cshap!";
                    string postData = "cni=" + cni.Text + "&nom=" + name.Text + "&prenom=" + surname.Text + "&ville=" + city.Text + "&mdp=user&isAdmin=1&numTel=" + phone.Text;
                    string contenttype = "application/x-www-form-urlencoded";
                    byte[] byteArray = Encoding.UTF8.GetBytes(postData);
                    string uri = "https://kufuli.000webhostapp.com/mobile/isAble.php";
                    String URL = "https://tpteam3.000webhostapp.com/newUser.php";


                    WebRequest req = WebRequest.Create(URL);
                    req.Method = requestMethod;
                    req.ContentLength = byteArray.Length;
                    req.ContentType = contenttype;
                    dataStream = req.GetRequestStream();
                    dataStream.Write(byteArray, 0, byteArray.Length);

                    dataStream.Close();

                    WebResponse resp = req.GetResponse();

                    /*Console.WriteLine(resp.StatusCode);
                    Console.WriteLine(resp.Server);*/

                    StreamReader reader = new StreamReader(resp.GetResponseStream());

                    string json = reader.ReadToEnd();
                    Console.WriteLine(json);

                    JavaScriptSerializer js = new JavaScriptSerializer();
                    //User md=js.Deserialize<User>(json);
                    Item items = JsonConvert.DeserializeObject<Item>(json);
                    //List<User> md = JsonConvert.DeserializeObject<List<User>>(json);
                    if (items.success == true)
                    {
                        MessageBox.Show("Ajout effectuer avec success");
                        FirstLoad();
                    }
                    else
                        MessageBox.Show("Vos identifiants sont incorrectes");
                }
                catch
                {
                    MessageBox.Show("Vos identifiants sont incorrectes");
                }
            }
        }

        private void btnEdit_Click(object sender, System.EventArgs e)
        {
            if (cni.Text == "" || name.Text == "" || surname.Text == "" || city.Text == "" || phone.Text == "")
            {
                MessageBox.Show("Veillez selectionnez ou rechercher un utilisateur");
            }
            else
            {
                string requestMethod = "POST";
                Stream dataStream;
                string postData = "cni=" + cni.Text + "&nom=" + name.Text + "&prenom=" + surname.Text + "&ville=" + city.Text + "&mdp=user&isAdmin=1&numTel=" + phone.Text;
                string contenttype = "application/x-www-form-urlencoded";
                byte[] byteArray = Encoding.UTF8.GetBytes(postData);
                String URL = "https://tpteam3.000webhostapp.com/modifierClient.php";


                WebRequest req = WebRequest.Create(URL);
                req.Method = requestMethod;
                req.ContentLength = byteArray.Length;
                req.ContentType = contenttype;
                dataStream = req.GetRequestStream();
                dataStream.Write(byteArray, 0, byteArray.Length);

                dataStream.Close();

                WebResponse resp = req.GetResponse();

                /*Console.WriteLine(resp.StatusCode);
                Console.WriteLine(resp.Server);*/

                StreamReader reader = new StreamReader(resp.GetResponseStream());

                string json = reader.ReadToEnd();
                Console.WriteLine(json);

                JavaScriptSerializer js = new JavaScriptSerializer();
                //User md=js.Deserialize<User>(json);
                Item items = JsonConvert.DeserializeObject<Item>(json);
                //List<User> md = JsonConvert.DeserializeObject<List<User>>(json);
                if (items.success == true)
                {
                    MessageBox.Show("Modification effectuer avec success");
                    FirstLoad();
                }
                else
                    MessageBox.Show("Nous avons rencontrer un probleme");
            }
        }



        private void btnDelete_Click(object sender, System.EventArgs e)
        {
            if (cni.Text == "")
            {
                MessageBox.Show("Veillez remplir le champ cni");
            }
            else
            {
                try
                {
                    HttpWebRequest WebReq = (HttpWebRequest)WebRequest.Create(string.Format("https://tpteam3.000webhostapp.com/supprimerClient.php"));

                    WebReq.Method = "POST";
                    string postData = "cni=" + cni.Text;
                    string contenttype = "application/x-www-form-urlencoded";
                    byte[] byteArray = Encoding.UTF8.GetBytes(postData);

                    WebReq.ContentLength = byteArray.Length;
                    WebReq.ContentType = contenttype;
                    Stream dataStream = WebReq.GetRequestStream();
                    dataStream.Write(byteArray, 0, byteArray.Length);

                    dataStream.Close();
                    HttpWebResponse WebResp = (HttpWebResponse)WebReq.GetResponse();

                    Console.WriteLine(WebResp.StatusCode);
                    Console.WriteLine(WebResp.Server);

                    string jsonString;
                    using (Stream stream = WebResp.GetResponseStream())   //modified from your code since the using statement disposes the stream automatically when done
                    {
                        StreamReader reader = new StreamReader(stream, System.Text.Encoding.UTF8);
                        jsonString = reader.ReadToEnd();
                    }
                    Console.WriteLine(jsonString);
                    Item items = JsonConvert.DeserializeObject<Item>(jsonString);

                    Console.WriteLine(items.message); //returns 921, the number of items on that page
                    if (items.success == true)
                    {
                        MessageBox.Show("Suppression effectuee");
                        //FirstLoad();
                        FirstLoad();
                        cni.Text = "";
                        name.Text = "";
                        surname.Text = "";
                        city.Text = "";
                        phone.Text = "";
                    }
                    else
                        MessageBox.Show("Nous avons rencontrer un probleme");
                    //Console.WriteLine(items.success);
                    //Console.ReadLine();
                }
                catch
                {
                    MessageBox.Show("Nous avons rencontrer un probleme");
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex] != null)
            {
                dataGridView1.CurrentRow.Selected = true;
                name.Text = dataGridView1.Rows[e.RowIndex].Cells["nom"].FormattedValue.ToString();
                cni.Text = dataGridView1.Rows[e.RowIndex].Cells["cni"].FormattedValue.ToString();
                surname.Text = dataGridView1.Rows[e.RowIndex].Cells["prenom"].FormattedValue.ToString();
                city.Text = dataGridView1.Rows[e.RowIndex].Cells["ville"].FormattedValue.ToString();
                phone.Text = dataGridView1.Rows[e.RowIndex].Cells["numTel"].FormattedValue.ToString();

                //surname.Text = selectedUser.prenom;
                //city.Text = selectedUser.ville;
            }
        }





    }
}
