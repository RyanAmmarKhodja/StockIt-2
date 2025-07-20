using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockIt_2.models
{
    public class Bon
    {
        public int Id { get; set; }
        public string Date { get; set; }
        public string fournisseur_nom { get; set; }
        public string fournisseur_prenom { get; set; }
        public string transporteur_nom { get; set; }
        public string transporteur_prenom { get; set; }
        public string designation { get; set; }
        public string nbr { get; set; }
        public string poids_kg { get; set; }
        public string prix_unitaire { get; set; }
        public string prix_transport_unitaire { get; set; }
        public string total_amount { get; set; }
    }
}
