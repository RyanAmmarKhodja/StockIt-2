using Microsoft.Data.Sqlite;
using StockIt_2.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockIt_2.services.GestionIndividu
{
    public class GestionParticulier
    {
        public void AddParticulier(Fournisseur particulier)
        {

            using (var conn = Db.GetConnection())
            {
                string query = "INSERT INTO particuliers (nom, prenom, RC, AI, NIF, NIS, TEL, N_BL, N_FACTURE, Adresse)" +
                    " VALUES (@nom, @prenom, @rc, @ai, @nif, @nis, @tel, @n_bl, @n_facture, @adresse)";
                try
                {
                    using (var cmd = new SqliteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@nom", particulier.nom);
                        cmd.Parameters.AddWithValue("@prenom", particulier.prenom);
                        cmd.Parameters.AddWithValue("@rc", particulier.rc);
                        cmd.Parameters.AddWithValue("@ai", particulier.ai);
                        cmd.Parameters.AddWithValue("@nif", particulier.nif);
                        cmd.Parameters.AddWithValue("@nis", particulier.nis);
                        cmd.Parameters.AddWithValue("@tel", particulier.tel);
                        cmd.Parameters.AddWithValue("@n_bl", particulier.n_bl);
                        cmd.Parameters.AddWithValue("@n_facture", particulier.n_facture);
                        cmd.Parameters.AddWithValue("@adresse", particulier.adresse);
                        int rows = cmd.ExecuteNonQuery();
                        MessageBox.Show($"{rows} fournisseur(s) ajouté(s).");
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show("Error: " + e.Message);
                }

            }
        }

        public bool CheckParticulierByTel(Fournisseur fournisseur)
        {
            using (var conn = Db.GetConnection())
            {
                conn.Open();
                string query = "SELECT * FROM particuliers WHERE nom = @nom AND prenom=@prenom AND TEL=@tel";
                try
                {
                    using (var cmd = new SqliteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@nom", fournisseur.nom);
                        cmd.Parameters.AddWithValue("@prenom", fournisseur.prenom);
                        cmd.Parameters.AddWithValue("@tel", fournisseur.tel);

                        using (SqliteDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                return true;

                            }
                        }
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show("Error: " + e.Message);
                }
                return false;
            }
        }
    }
}
