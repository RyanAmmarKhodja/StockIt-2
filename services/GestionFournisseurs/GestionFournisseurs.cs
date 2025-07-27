using Microsoft.Data.Sqlite;
using StockIt_2.models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace StockIt_2.services.GestionFournisseurs
{
    public class GestionFournisseurs
    {
        public static void ajouterFournisseur(string nom, string prenom, string rc, string ai, string nif, string nis, string tel, string n_bl, string n_facture, string adresse) {

            using (var conn = Db.GetConnection())
            {
                string query = "INSERT INTO fournisseurs (nom, prenom, RC, AI, NIF, NIS, TEL, N_BL, N_FACTURE, Adresse)" +
                    " VALUES (@nom, @prenom, @rc, @ai, @nif, @nis, @tel, @n_bl, @n_facture, @adresse)";
                try {
                    using (var cmd = new SqliteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@nom", nom);
                        cmd.Parameters.AddWithValue("@prenom", prenom);
                        cmd.Parameters.AddWithValue("@rc", rc);
                        cmd.Parameters.AddWithValue("@ai", ai);
                        cmd.Parameters.AddWithValue("@nif", nif);
                        cmd.Parameters.AddWithValue("@nis", nis);
                        cmd.Parameters.AddWithValue("@tel", tel);
                        cmd.Parameters.AddWithValue("@n_bl", n_bl);
                        cmd.Parameters.AddWithValue("@n_facture", n_facture);
                        cmd.Parameters.AddWithValue("@adresse", adresse);
                        int rows = cmd.ExecuteNonQuery();
                        MessageBox.Show($"{rows} fournisseur(s) ajouté(s).");
                    }
                } catch (Exception e){
                    MessageBox.Show("Error: " + e.Message);
                }
                
            }
        }

        public List<Fournisseur> GetFournisseurs()
        {
            var fournisseurs = new List<Fournisseur>();


            using (var conn = Db.GetConnection())
            {
                conn.Open();
                string query = "SELECT * FROM fournisseurs";


                try
                {
                    using (var cmd = new SqliteCommand(query, conn))
                    using (SqliteDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var fournisseur = new Fournisseur
                            {
                                id = reader.GetInt32(0),           // Column index 0: id
                                nom = reader.GetString(1),        // Column index 1: name
                                prenom = reader.GetString(2),
                                adresse = reader.GetString(3),
                                rc = reader.GetString(4),
                                ai = reader.GetString(5),
                                nif = reader.GetString(6),
                                nis = reader.GetString(7),
                                tel = reader.GetString(8),
                                n_bl = reader.GetString(9),
                                n_facture = reader.GetString(10)
                            };
                            fournisseurs.Add(fournisseur);
                        }
                    }
                    return fournisseurs;
                }
                catch (Exception e)
                {
                    MessageBox.Show("Error : " + e.Message);
                    return new List<Fournisseur>();
                }
            }
        }

        public static Fournisseur GetFournisseurById(int id)
        {
            using (var conn = Db.GetConnection())
            {
                conn.Open();
                string query = "SELECT * FROM fournisseurs WHERE id = @id";
                try
                {
                    using (var cmd = new SqliteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        using (SqliteDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                return new Fournisseur
                                {
                                    id = reader.GetInt32(0),
                                    nom = reader.GetString(1),
                                    prenom = reader.GetString(2),
                                    adresse = reader.GetString(3),
                                    rc = reader.GetString(4),
                                    ai = reader.GetString(5),
                                    nif = reader.GetString(6),
                                    nis = reader.GetString(7),
                                    tel = reader.GetString(8),
                                    n_bl = reader.GetString(9),
                                    n_facture = reader.GetString(10)
                                };
                            }
                        }
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show("Error: " + e.Message);
                }
            }
            return null;
        }


        public static void UpdateFournisseur(Fournisseur fournisseur)
        {
            using (var conn = Db.GetConnection())
            {
                string query = "UPDATE fournisseurs SET nom = @nom, prenom = @prenom, Adresse = @adresse, RC = @rc, AI = @ai, NIF = @nif, NIS = @nis, TEL = @tel, N_BL = @n_bl, N_FACTURE = @n_facture WHERE id = @id";
                try
                {
                    using (var cmd = new SqliteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", fournisseur.id);
                        cmd.Parameters.AddWithValue("@nom", fournisseur.nom);
                        cmd.Parameters.AddWithValue("@prenom", fournisseur.prenom);
                        cmd.Parameters.AddWithValue("@adresse", fournisseur.adresse);
                        cmd.Parameters.AddWithValue("@rc", fournisseur.rc);
                        cmd.Parameters.AddWithValue("@ai", fournisseur.ai);
                        cmd.Parameters.AddWithValue("@nif", fournisseur.nif);
                        cmd.Parameters.AddWithValue("@nis", fournisseur.nis);
                        cmd.Parameters.AddWithValue("@tel", fournisseur.tel);
                        cmd.Parameters.AddWithValue("@n_bl", fournisseur.n_bl);
                        cmd.Parameters.AddWithValue("@n_facture", fournisseur.n_facture);
                        int rows = cmd.ExecuteNonQuery();
                        MessageBox.Show($"{rows} fournisseur(s) mis à jour(s).");
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show("Error: " + e.Message);
                }
            }
        }

        public bool check_fournissuer()
        {
            return true;
        }
    }
}
