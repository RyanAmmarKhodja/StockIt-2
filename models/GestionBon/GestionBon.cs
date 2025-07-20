using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockIt_2.models.GestionBon
{
    public class GestionBon
    {
        public static void ajouterBon(DateTime date, string f_nom, string f_prenom, string t_nom, string t_prenom, string designation, int nbr, double poids_kg, double prix_unitaire, double prix_transport_unitaire, double total_amount)
        {
            using (var conn = Db.GetConnection())
            {
                string query = "INSERT INTO bons (date, fournisseur_nom,fournisseur_prenom,transporteur_nom,transporteur_prenom, designation, nbr, poids_kg, prix_unitaire, prix_transport_unitaire, total_amount)" +
                    " VALUES (@date, @f_nom, @f_prenom, @t_nom, @t_prenom,@designation, @nbr, @poids_kg, @prix_unitaire, @prix_transport_unitaire, @total_amount)";
                try
                {
                    using (var cmd = new SqliteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@date", date);
                        cmd.Parameters.AddWithValue("@f_nom", f_nom);
                        cmd.Parameters.AddWithValue("@f_prenom", f_prenom);
                        cmd.Parameters.AddWithValue("@t_nom", t_nom);
                        cmd.Parameters.AddWithValue("@t_prenom", t_prenom);
                        cmd.Parameters.AddWithValue("@designation", designation);
                        cmd.Parameters.AddWithValue("@nbr", nbr);
                        cmd.Parameters.AddWithValue("@poids_kg", poids_kg);
                        cmd.Parameters.AddWithValue("@prix_unitaire", prix_unitaire);
                        cmd.Parameters.AddWithValue("@prix_transport_unitaire", prix_transport_unitaire);
                        cmd.Parameters.AddWithValue("@total_amount", total_amount);
                        int rows = cmd.ExecuteNonQuery();
                        MessageBox.Show($"{rows} Bon(s) ajouté(s).");
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show("Error: " + e.Message);
                }
            }
        }

    }
}
