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
using Newtonsoft.Json;



namespace Gestion_commande.forms
{
    public partial class FormProduct : Form
    {
        int cat;
        List<Categorie> categories;

        public FormProduct()
        {
            InitializeComponent();
        }

        private void tel_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (reference.Text == "" || intitule.Text == "" || qte.Text == "" || prix.Text == "")
            {
                MessageBox.Show("Veillez remplir tous les champs");
            }
            else
            {
                switch (comboBox2.SelectedItem.ToString())
                {
                    case "Electromenager":
                        cat = 1;
                        break;
                    case "Clouterie":
                        cat = 2;
                        break;
                    case "Quicaillerie":
                        cat = 3;
                        break;
                    case "Boulonerie":
                        cat = 4;
                        break;
                }
                try
                {
                    string requestMethod = "POST";
                    Stream dataStream;
                    //string postData = "var1=Hello&var2=Cshap!";
                    string postData = "Reference=" + reference.Text + "&Intitule=" + intitule.Text + "&Quantite=" + qte.Text + "&Prix=" + prix.Text + "&id_cat=" + cat;
                    string contenttype = "application/x-www-form-urlencoded";
                    byte[] byteArray = Encoding.UTF8.GetBytes(postData);
                    string uri = "https://kufuli.000webhostapp.com/mobile/isAble.php";
                    String URL = "https://tpteam3.000webhostapp.com/newProduit.php";


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

        public void FirstLoad()
        {
            HttpWebRequest WebReq = (HttpWebRequest)WebRequest.Create(string.Format("https://tpteam3.000webhostapp.com/allProducts.php"));

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

            Console.WriteLine(jsonString);
            List<Product> users = JsonConvert.DeserializeObject<List<Product>>(jsonString);

            Console.WriteLine(users.Count);

            
            dataGridView1.DataSource = users;

            //dataGridView1.Columns["mdp"].Visible = false;
            //dataGridView1.Columns["isAdmin"].Visible = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (reference.Text == "" || intitule.Text == "" || qte.Text == "" || prix.Text == "")
            {
                MessageBox.Show("Veillez selectionnez ou rechercher un utilisateur");
            }
            else
            {
                for (int i = 0; i < categories.Count; i++)
                {
                    if (comboBox2.SelectedItem.ToString() == categories[i].nom)
                        cat = i + 1;
                }
                /*switch (comboBox2.SelectedItem.ToString())
                {
                    case "Electromenager":
                        cat = 1;
                        break;
                    case "Clouterie":
                        cat = 2;
                        break;
                    case "Quicaillerie":
                        cat = 3;
                        break;
                    case "Boulonerie":
                        cat = 4;
                        break;
                }*/
                string requestMethod = "POST";
                Stream dataStream;
                string postData = "Reference=" + reference.Text + "&Intitule=" + intitule.Text + "&Quantite=" + qte.Text + "&Prix=" + prix.Text + "&id_cat=" + cat;
                string contenttype = "application/x-www-form-urlencoded";
                byte[] byteArray = Encoding.UTF8.GetBytes(postData);
                String URL = "https://tpteam3.000webhostapp.com/modifierProduit.php";


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
                Console.WriteLine(cat);
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

        private void button10_Click(object sender, EventArgs e)
        {
            if (reference.Text == "")
            {
                MessageBox.Show("Veillez remplir le champ cni");
            }
            else
            {
                try
                {
                    HttpWebRequest WebReq = (HttpWebRequest)WebRequest.Create(string.Format("https://tpteam3.000webhostapp.com/deleteProduit.php"));

                    WebReq.Method = "POST";
                    string postData = "Reference=" + reference.Text;
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
                        FirstLoad();
                        reference.Text = "";
                        intitule.Text = "";
                        qte.Text = "";
                        prix.Text = "";
                        //phone.Text = "";
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

        private void button6_Click(object sender, EventArgs e)
        {
            if (reference.Text == "")
            {
                intitule.Text = "";
                qte.Text = "";
                prix.Text = "";
                MessageBox.Show("Veillez remplir le champs cni");
            }
            else
            {
                string requestMethod = "POST";
                Stream dataStream;
                string postData = "Reference=" + reference.Text;
                string contenttype = "application/x-www-form-urlencoded";
                byte[] byteArray = Encoding.UTF8.GetBytes(postData);
                String URL = "https://tpteam3.000webhostapp.com/rechercherProduit.php";

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
                List<Product> md = JsonConvert.DeserializeObject<List<Product>>(json);

                if (md.Count == 0)
                {
                    MessageBox.Show("Utilisateur non trouver");
                }
                else
                {
                    Console.WriteLine(md.Count);

                    Console.WriteLine(md[0].reference);
                    Console.WriteLine(md[0].intitule);
                    Console.WriteLine(md[0].quantite);
                    intitule.Text = md[0].intitule;
                    qte.Text = md[0].quantite.ToString();
                    prix.Text = md[0].prix.ToString();

                    switch (md[0].id_cat.ToString())
                    {
                        case "1":
                            comboBox2.SelectedItem = "Electromenager";
                            break;
                        case "2":
                            comboBox2.SelectedItem = "Clouterie";
                            break;
                        case "3":
                            comboBox2.SelectedItem = "Quincaillerie";
                            break;
                        case "4":
                            comboBox2.SelectedItem = "Boulonerie";
                            break;
                        //city.Text = md[0].ville;
                        //phone.Text = md[0].numTel.ToString();
                    }
                }
                //Console.ReadLine();
            }
        }

        private void FormProduct_Load(object sender, EventArgs e)
        {
            FirstLoad();
            FirstLoad1();
        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex] != null)
            {
                dataGridView1.CurrentRow.Selected = true;
                reference.Text = dataGridView1.Rows[e.RowIndex].Cells["reference"].FormattedValue.ToString();
                intitule.Text = dataGridView1.Rows[e.RowIndex].Cells["intitule"].FormattedValue.ToString();
                qte.Text = dataGridView1.Rows[e.RowIndex].Cells["quantite"].FormattedValue.ToString();
                prix.Text = dataGridView1.Rows[e.RowIndex].Cells["prix"].FormattedValue.ToString();
                string n= dataGridView1.Rows[e.RowIndex].Cells["id_cat"].FormattedValue.ToString();
                Console.WriteLine(n);
                comboBox2.Text = categories[int.Parse(n)-1].nom.ToString();

                /*switch (dataGridView1.Rows[e.RowIndex].Cells["id_cat"].FormattedValue.ToString())
                {
                    case "1":
                        Console.Write("oui");
                        comboBox2.SelectedItem = "Electromenager";
                        break;
                    case "2":
                        comboBox2.SelectedItem = "Clouterie";
                        break;
                    case "3":
                        comboBox2.SelectedItem = "Quincaillerie";
                        break;
                    case "4":
                        comboBox2.SelectedItem = "Boulonerie";
                        break;
                    //city.Text = md[0].ville;
                    //phone.Text = md[0].numTel.ToString();
                }*/
                //comboBox2.SelectedItem = 
                //city.Text = dataGridView1.Rows[e.RowIndex].Cells["ville"].FormattedValue.ToString();
                //phone.Text = dataGridView1.Rows[e.RowIndex].Cells["numTel"].FormattedValue.ToString();

                //surname.Text = selectedUser.prenom;
                //city.Text = selectedUser.ville;
            }
        }

        private void FirstLoad1()
        {
            HttpWebRequest WebReq = (HttpWebRequest)WebRequest.Create(string.Format("https://tpteam3.000webhostapp.com/allCat.php"));

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

            categories = JsonConvert.DeserializeObject<List<Categorie>>(jsonString);



            Console.WriteLine(categories.Count);
            for (int i = 0; i < categories.Count; i++)
            {
                //cnis.Add(users[i].cni.ToString());
               comboBox2.Items.Add(categories[i].nom);
            }

            //dataGridView1.DataSource = users;


            //dataGridView1.Columns["mdp"].Visible = false;
            //dataGridView1.Columns["isAdmin"].Visible = false;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            reference.Text = "";
            intitule.Text = "";
            qte.Text = "";
            prix.Text = "";
            comboBox2.SelectedText = "Select Category";
        }
    }
}
