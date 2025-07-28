using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuestPDF.Drawing;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using StockIt_2.models;
using StockIt_2.services.GestionCoords;



namespace StockIt_2.controllers
{
    public class InvoiceDocument : IDocument
    {

        public Bon bon { get; }

        public InvoiceDocument(Bon model)
        {
            bon = model;
        }



        public DocumentMetadata GetMetadata() => DocumentMetadata.Default;
        public DocumentSettings GetSettings() => DocumentSettings.Default;
        public void Compose(IDocumentContainer container)
        {
            container
            .Page(page =>
            {
                page.Margin(50);

                page.Header().Element(ComposeHeader);
                page.Content().Element(ComposeContent);

                page.Footer().AlignCenter().Text(x =>
                {
                    x.CurrentPageNumber();
                    x.Span(" / ");
                    x.TotalPages();
                });
            });
        }

        void ComposeHeader(IContainer container)
        {
            container.Row(row =>
            {
                row.RelativeItem().Column(column =>
                {
                    column.Item().Text(text =>
                    {
                        text.Span("EURL GUEMOURI SOFIANE");
                    });

                    column.Item().AlignRight().Text($"Freha le: {bon.Date:d}").SemiBold();

                    column.Item()
                        .Text($"Bon de récéption N°{bon.Id}/{bon.Date:yyyy}")
                        .FontSize(20).SemiBold().FontColor(Colors.Blue.Medium);
                });

                //row.ConstantItem(100).Height(50).Placeholder();
            });
        }

        void ComposeContent(IContainer container)
        {
            //container
            //    .PaddingVertical(40)
            //    .Height(250)
            //    .Background(Colors.Grey.Lighten3)
            //    .AlignCenter()
            //    .AlignMiddle()
            //    .Text("Content").FontSize(16);

            container.PaddingVertical(40).Column(column =>
            {
                column.Item().Row(row =>
                {
                    row.RelativeItem().Component(new FournisseurComponent(bon.fournisseur));
                    row.ConstantItem(50);
                    row.RelativeItem().Component(new TransporteurComponent(bon.transporteur));

                });


                column.Spacing(5);
                column.Item().Element(ComposeTable);
                column.Item().Element(ComposeTableTransport);
                column.Item().AlignRight().Text($"TG: {bon.total_amount} DZD").FontSize(14);

                column.Item().PaddingTop(25).Element(ComposeComments);
            });
        }

        void ComposeTable(IContainer container)
        {
            container.Table(table =>
            {
                table.ColumnsDefinition(columns =>
                {
                    columns.RelativeColumn(25);
                    columns.RelativeColumn(10);
                    columns.RelativeColumn(10);
                    columns.RelativeColumn(10);
                    columns.RelativeColumn(10);
                });

                table.Header(header =>
                {
                    header.Cell().Element(CellStyle).Text("Designation");
                    header.Cell().Element(CellStyle).AlignCenter().Text("NBR");
                    header.Cell().Element(CellStyle).AlignCenter().Text("KG");
                    header.Cell().Element(CellStyle).AlignCenter().Text("PU");
                    header.Cell().Element(CellStyle).AlignCenter().Text("TTC");

                    static IContainer CellStyle(IContainer container)
                    {
                        return container.DefaultTextStyle(x => x.SemiBold()).PaddingVertical(5).BorderBottom(1).BorderColor(Colors.Black);
                    }
                });

                foreach (var item in bon.Items)
                {
                    table.Cell().Element(CellStyle).Text(item.designation);
                    table.Cell().Element(CellStyle).AlignCenter().Text(item.nbr);
                    table.Cell().Element(CellStyle).AlignCenter().Text($"{item.poids_kg}");
                    table.Cell().Element(CellStyle).AlignCenter().Text(item.prix_unitaire);
                    table.Cell().Element(CellStyle).AlignCenter().Text($"{item.ttc}");

                    static IContainer CellStyle(IContainer container)
                    {
                        return container.BorderBottom(1).BorderColor(Colors.Grey.Lighten2).PaddingVertical(5);
                    }
                }
            });
        }

        void ComposeTableTransport(IContainer container)
        {
            container.Table(table =>
            {
                table.ColumnsDefinition(columns =>
                {
                    columns.RelativeColumn(25);
                    columns.RelativeColumn(10);
                    columns.RelativeColumn(10);
                    columns.RelativeColumn(10);
                    columns.RelativeColumn(10);
                });

                table.Header(header =>
                {
                    header.Cell().Element(CellStyle).Text("Transport");
                    header.Cell().Element(CellStyle).AlignCenter().Text("NBR");
                    header.Cell().Element(CellStyle).AlignCenter().Text("KG");
                    header.Cell().Element(CellStyle).AlignCenter().Text("PU");
                    header.Cell().Element(CellStyle).AlignCenter().Text("TTC");

                    static IContainer CellStyle(IContainer container)
                    {
                        return container.DefaultTextStyle(x => x.SemiBold()).PaddingVertical(5).BorderBottom(1).BorderColor(Colors.Black);
                    }
                });

                foreach (var item in bon.Items)
                {
                    table.Cell().Element(CellStyle).Text(" ");
                    table.Cell().Element(CellStyle).AlignCenter().Text(item.nbr);
                    table.Cell().Element(CellStyle).AlignCenter().Text($"{item.poids_kg}");
                    table.Cell().Element(CellStyle).AlignCenter().Text(item.prix_unitaire);
                    table.Cell().Element(CellStyle).AlignCenter().Text($"{item.ttc}");

                    static IContainer CellStyle(IContainer container)
                    {
                        return container.BorderBottom(1).BorderColor(Colors.Grey.Lighten2).PaddingVertical(5);
                    }
                }
            });
        }

        void ComposeComments(IContainer container)
        {
            container.Padding(10).Column(column =>
            {
                GestionCoords gestionCoords = new GestionCoords();
                Coords coords = gestionCoords.GetCoords();

                column.Spacing(5);
                column.Item().Text("Coordonnées").FontSize(14);
                column.Item().Text("Tel: ");
                column.Item().Text("Email: ");
                column.Item().Text("Adresse: "+coords.adresse);
                column.Item().Text("AI: "+coords.ai);
                column.Item().Text("NIF: "+coords.nif);
                column.Item().Text("NIS: "+coords.nis);
            });
        }
    }
}
