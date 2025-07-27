using Microsoft.Data.Sqlite;
using StockIt_2.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockIt_2.services.GestionBon
{
    public class GestionBon
    {
        public static int ajouterBon(Bon bon)
        {
            int lastInsertedId = 0;
            using (var conn = Db.GetConnection())
            {
                string query = "INSERT INTO bons (date, category_fournisseur,id_fournisseur,id_transporteur, prix_transport_unitaire, total_amount)" +
                    " VALUES (@date, @category_fournisseur, @id_fournisseur, @id_transporteur, @prix_transport_unitaire, @total_amount)";
                try
                {
                    using (var cmd = new SqliteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@date", bon.Date);
                        cmd.Parameters.AddWithValue("@category_fournisseur", bon.category_fournisseur);
                        cmd.Parameters.AddWithValue("@id_fournisseur", bon.fournisseur.id);
                        cmd.Parameters.AddWithValue("@id_transporteur", bon.transporteur.id);
                        cmd.Parameters.AddWithValue("@prix_transport_unitaire", bon.prix_transport_unitaire);
                        cmd.Parameters.AddWithValue("@total_amount", bon.total_amount);
                        int rows = cmd.ExecuteNonQuery();
                        MessageBox.Show($"{rows} Bon(s) ajouté(s).");

                        using (var cmdId = new SqliteCommand("SELECT last_insert_rowid()", conn))
                        {
                            lastInsertedId = Convert.ToInt32(cmdId.ExecuteScalar());
                        }
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show("Error: " + e.Message);
                }

                return lastInsertedId;
            }
        }



    }
}
