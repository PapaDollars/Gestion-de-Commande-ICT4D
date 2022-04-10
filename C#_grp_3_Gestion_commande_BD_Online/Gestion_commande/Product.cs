using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_commande
{
    class Product
    {
        public string reference { get; set; }
        public string intitule { get; set; }
        public int quantite { get; set; }
        public int prix { get; set; }
        public int id_cat { get; set; }
    }
}
