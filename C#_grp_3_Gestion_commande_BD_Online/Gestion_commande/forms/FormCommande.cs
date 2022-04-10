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
    public partial class FormCommande : Form
    {

        List<string> cnis;
        List<Ref> allRef;
        List<Price> products;

        public FormCommande()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            ID.Text = "";
            date.Text = "";
            IdClient.SelectedText = "Select Id Client";
        }

        private void FormCommande_Load(object sender, EventArgs e)
        {
            FirstLoad();
            FirstLoad1();
            FirstLoad2();
            //listeProducts();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (ID.Text == "")
            {


                MessageBox.Show("Veillez remplir le champs ID Commande");
            }
            else
            {
                string requestMethod = "POST";
                Stream dataStream;
                string postData = "numCom=" + ID.Text;
                string contenttype = "application/x-www-form-urlencoded";
                byte[] byteArray = Encoding.UTF8.GetBytes(postData);
                String URL = "https://tpteam3.000webhostapp.com/rechercherCommande.php";

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
                    }
                    else
                    {
                        Console.WriteLine(md.Count);

                        date.Text = md[0].dateCom.Date.ToString();
                        IdClient.Text = md[0].codeClient.ToString();
                        Console.WriteLine(md[0].codeClient);

                    }
                }
                catch
                {
                    MessageBox.Show("Commande non trouver");
                }
                //Console.ReadLine();
            }
        }

        private void button9_Click(object sender, System.EventArgs e)
        {
            if (ID.Text == "" || date.Text == "" || IdClient.SelectedItem.ToString() == "Select Id Client")
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
                    string postData = "numCom=" + ID.Text + "&dateCom=" + date.Text + "&codeClient=" + IdClient.SelectedItem.ToString();
                    string contenttype = "application/x-www-form-urlencoded";
                    byte[] byteArray = Encoding.UTF8.GetBytes(postData);

                    String URL = "https://tpteam3.000webhostapp.com/newCom.php";


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
                        FirstLoad2();
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

        private void button8_Click(object sender, System.EventArgs e)
        {
            if (ID.Text == "" || date.Text == "")
            {
                MessageBox.Show("Veillez selectionnez ou rechercher un utilisateur");
            }
            else
            {

                string requestMethod = "POST";
                Stream dataStream;
                string postData = "numCom=" + ID.Text + "&dateCom=" + date.Text + "&codeClient=" + IdClient.SelectedItem.ToString();
                string contenttype = "application/x-www-form-urlencoded";
                byte[] byteArray = Encoding.UTF8.GetBytes(postData);
                String URL = "https://tpteam3.000webhostapp.com/modifyCommande.php";


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
                    FirstLoad2();
                }
                else
                    MessageBox.Show("Nous avons rencontrer un probleme");
            }
        }

        private void button10_Click(object sender, System.EventArgs e)
        {
            if (ID.Text == "")
            {
                MessageBox.Show("Veillez remplir le champ ID");
            }
            else
            {
                try
                {
                    HttpWebRequest WebReq = (HttpWebRequest)WebRequest.Create(string.Format("https://tpteam3.000webhostapp.com/deleteCommande.php"));

                    WebReq.Method = "POST";
                    string postData = "numCom=" + ID.Text;
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
                        FirstLoad2();
                        ID.Text = "";
                        //name.Text = "";
                        //surname.Text = "";
                        //city.Text = "";
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

        private void button7_Click(object sender, System.EventArgs e)
        {
            if (ID.Text == "")
            {
                MessageBox.Show("Veillez remplir le champs ID");
            }
            else
            {
                REFERENCE.Enabled = true;
                quantite.Enabled = true;
                butAD.Enabled = true;
                butDD.Enabled = true;
                butED.Enabled = true;
                butEDD.Enabled = true;
                butND.Enabled = true;

                ID.Enabled = false;
                date.Enabled = false;
                IdClient.Enabled = false;
                button11.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
                button10.Enabled = false;


                FirstLoad3();
                listeProducts();
                TT.Text = somme().ToString();
            }
        }

        private void butND_Click(object sender, System.EventArgs e)
        {
            quantite.Text = "";
            REFERENCE.SelectedValue = "Select Reference";
        }

        private void butAD_Click(object sender, System.EventArgs e)
        {
            if (quantite.Text == "" || REFERENCE.SelectedItem.ToString() == "Select Reference")
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
                    string postData = "numCom=" + ID.Text + "&Reference=" + REFERENCE.SelectedItem.ToString() + "&quantite=" + quantite.Text;
                    string contenttype = "application/x-www-form-urlencoded";
                    byte[] byteArray = Encoding.UTF8.GetBytes(postData);

                    String URL = "https://tpteam3.000webhostapp.com/addRef.php";


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
                       
                        listeProducts();
                        FirstLoad3();
                        TT.Text = somme().ToString();
                        
                    }
                    else
                        MessageBox.Show("Nous avons rencontrer un probleme. Merci de ressayer");
                }
                catch
                {
                    MessageBox.Show("Une erreur de connexion est survenu");
                }
            }
        }

        private void butDD_Click(object sender, System.EventArgs e)
        {
            if (REFERENCE.SelectedItem.ToString() == "Select Reference" || quantite.Text == "")
            {
                MessageBox.Show("Veillez selectionnezune reference");
            }
            else
            {
                try
                {
                    HttpWebRequest WebReq = (HttpWebRequest)WebRequest.Create(string.Format("https://tpteam3.000webhostapp.com/deleteRef.php"));

                    WebReq.Method = "POST";
                    string postData = "numCom=" + ID.Text + "&Reference=" + REFERENCE.SelectedItem.ToString();
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
                        FirstLoad3();
                        //ID.Text = "";
                        TT.Text = somme().ToString();
                        //name.Text = "";
                        //surname.Text = "";
                        //city.Text = "";
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

        private void butED_Click(object sender, System.EventArgs e)
        {
            if (REFERENCE.SelectedItem.ToString() == "Select Reference")
            {
                MessageBox.Show("Veillez selectionnezune reference");
            }
            else
            {

                string requestMethod = "POST";
                Stream dataStream;
                string postData = "numCom=" + ID.Text + "&Reference=" + REFERENCE.SelectedItem.ToString() + "&quantite=" + quantite.Text;
                string contenttype = "application/x-www-form-urlencoded";
                byte[] byteArray = Encoding.UTF8.GetBytes(postData);
                String URL = "https://tpteam3.000webhostapp.com/modifyRef.php";


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
                    FirstLoad3();
                    TT.Text = somme().ToString();
                }
                else
                    MessageBox.Show("Nous avons rencontrer un probleme");
            }
        }

        private void butEDD_Click(object sender, System.EventArgs e)
        {
            quantite.Text = "";
            REFERENCE.SelectedText = "Select Reference";

            REFERENCE.Enabled = false;
            quantite.Enabled = false;
            butAD.Enabled = false;
            butDD.Enabled = false;
            butED.Enabled = false;
            butEDD.Enabled = false;
            butND.Enabled = false;

            ID.Enabled = true;
            date.Enabled = true;
            IdClient.Enabled = true;
            button11.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
            button10.Enabled = true;

            FirstLoad2();
        }

        private void FirstLoad3()
        {
            string requestMethod = "POST";
            Stream dataStream;
            string postData = "numCom=" + ID.Text;
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

            dataGridView1.DataSource = allRef;


            //dataGridView1.Columns["mdp"].Visible = false;
            //dataGridView1.Columns["isAdmin"].Visible = false;

        }

        private void FirstLoad2()
        {
            HttpWebRequest WebReq = (HttpWebRequest)WebRequest.Create(string.Format("https://tpteam3.000webhostapp.com/allCommande.php"));

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

            List<commande> commande = JsonConvert.DeserializeObject<List<commande>>(jsonString);



            Console.WriteLine(commande.Count);
            dataGridView1.DataSource = commande;
            //for (int i = 0; i < produi.Count; i++)
            //{
            //cnis.Add(users[i].cni.ToString());
            //    REFERENCE.Items.Add(produi[i].reference);
            //}
        }

        private void FirstLoad1()
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

            List<Product> produi = JsonConvert.DeserializeObject<List<Product>>(jsonString);



            Console.WriteLine(produi.Count);
            for (int i = 0; i < produi.Count; i++)
            {
                //cnis.Add(users[i].cni.ToString());
                REFERENCE.Items.Add(produi[i].reference);
            }

            //dataGridView1.DataSource = users;


            //dataGridView1.Columns["mdp"].Visible = false;
            //dataGridView1.Columns["isAdmin"].Visible = false;
        }


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
            for (int i = 0; i < users.Count; i++)
            {
                //cnis.Add(users[i].cni.ToString());
                IdClient.Items.Add(users[i].cni.ToString());
            }

            //dataGridView1.DataSource = users;


            //dataGridView1.Columns["mdp"].Visible = false;
            //dataGridView1.Columns["isAdmin"].Visible = false;
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
            string postData = "numCom=" + ID.Text;
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

        private void REFERENCE_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            for (int i = 0; i < allRef.Count; i++)
            {
                if (REFERENCE.SelectedItem.ToString() == allRef[i].nom)
                    quantite.Text = allRef[i].qte.ToString();
            }
        }
    }
}
