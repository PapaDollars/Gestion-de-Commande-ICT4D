using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_commande
{
    class User
    {
        public int cni { get; set; }
        public string nom { get; set; }
        public string prenom { get; set; }
        public string ville { get; set; }
        public string mdp { get; set; }
        public int isAdmin { get; set; }
        public int numTel { get; set; }
    }
}
