using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using StockIt_2.models;

namespace StockIt_2.controllers
{
    public class TransporteurComponent : IComponent
    {
        private string Title = "Transporteur";
        public Transporteur Transporteur;

        public TransporteurComponent(Transporteur transporteur)
        {
            Transporteur = transporteur;
        }

        public void Compose(IContainer container)
        {
            container.Column(column =>
            {
                column.Spacing(2);

                column.Item().BorderBottom(1).PaddingBottom(5).Text(Title).SemiBold();

                column.Item().Text("Nom: "+Transporteur.nom);
                column.Item().Text("Prenom: " + Transporteur.prenom);
                column.Item().Text("Adresse: " + Transporteur.adresse);
                column.Item().Text("Matricule: " + Transporteur.matricule);
                column.Item().Text("TEL: " + Transporteur.tel);
            });
        }
    }
}
