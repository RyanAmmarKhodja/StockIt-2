using Microsoft.Data.Sqlite;
using StockIt_2.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockIt_2.services.GestionIndividu
{
    public class GestionIndividu
    {
        public static void ajouterIndividu(Fournisseur individu)
        {

            using (var conn = Db.GetConnection())
            {
                string query = "INSERT INTO individu (nom, prenom, RC, AI, NIF, NIS, TEL, N_BL, N_FACTURE, Adresse)" +
                    " VALUES (@nom, @prenom, @rc, @ai, @nif, @nis, @tel, @n_bl, @n_facture, @adresse)";
                try
                {
                    using (var cmd = new SqliteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@nom", individu.nom);
                        cmd.Parameters.AddWithValue("@prenom", individu.prenom);
                        cmd.Parameters.AddWithValue("@rc", individu.rc);
                        cmd.Parameters.AddWithValue("@ai", individu.ai);
                        cmd.Parameters.AddWithValue("@nif", individu.nif);
                        cmd.Parameters.AddWithValue("@nis", individu.nis);
                        cmd.Parameters.AddWithValue("@tel", individu.tel);
                        cmd.Parameters.AddWithValue("@n_bl", individu.n_bl);
                        cmd.Parameters.AddWithValue("@n_facture", individu.n_facture);
                        cmd.Parameters.AddWithValue("@adresse", individu.adresse);
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

        public bool check_individu()
        {
            return true;
        }

    }
}
