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


namespace Gestion_commande
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string userName = username.Text;
            String password = mdp.Text;

            if (userName == "" || password == "")
            {
                MessageBox.Show("Vous devez remplir tous les champs svp");
            }
            else
            {
                try
                {
                    string requestMethod = "POST";
                    Stream dataStream;
                    //string postData = "var1=Hello&var2=Cshap!";
                    //string postData = "username=dav&password=123";
                    string postData = "username=" + userName + "&password=" + password;
                    string contenttype = "application/x-www-form-urlencoded";
                    byte[] byteArray = Encoding.UTF8.GetBytes(postData);
                    string uri = "https://kufuli.000webhostapp.com/mobile/isAble.php";
                    String URL = "https://tpteam3.000webhostapp.com/login.php";


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
                    Console.WriteLine(items.success);
                    //Console.WriteLine(md[0].nom);
                    //Console.WriteLine(md[0].mdp);
                    //Console.ReadLine();

                    if (items.success == true)
                    {

                        //menu men = new menu();
                        //men.Show();
                        //men.gestion.Enabled = true;
                        new Form1().Show();
                        this.Hide();
                        //this.Hide();
                    }
                }
                catch
                {
                    MessageBox.Show("Nous avons rencontrer un probleme de connexion");
                }
            }
        }
    }
}
