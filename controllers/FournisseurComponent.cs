using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using QuestPDF.Drawing;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using StockIt_2.models;

namespace StockIt_2.controllers
{
    public class FournisseurComponent : IComponent
    {
        private string Title = "Fournisseur";
        public Fournisseur Fournisseur;

        public FournisseurComponent(Fournisseur fournisseur)
        {
            Fournisseur = fournisseur;
        }

        public void Compose(IContainer container)
        {
            container.Column(column =>
            {
                column.Spacing(2);

                column.Item().BorderBottom(1).PaddingBottom(5).Text(Title).SemiBold();

                column.Item().Text("Nom: "+Fournisseur.nom);
                column.Item().Text("Prenom: "+Fournisseur.prenom);
                column.Item().Text("Adresse: "+Fournisseur.adresse);
                column.Item().Text("RC: "+Fournisseur.rc);
                column.Item().Text("AI: "+Fournisseur.ai);
                column.Item().Text("NIF: "+Fournisseur.nif);
                column.Item().Text("NIS: "+Fournisseur.nis);
                column.Item().Text("TEL: "+Fournisseur.tel);
                column.Item().Text("N° BL: " + Fournisseur.n_bl);
                column.Item().Text("N° Facture: " + Fournisseur.n_facture);
            });
        }
    }
}
