using System;
using System.Collections.Generic;
using MediaTek86.bddmanager;
using System.Data;
using System.Configuration;
using MySql.Data.MySqlClient;

namespace MediaTek86.bddmanager
{
    public class BddManager
    {
        private MySqlConnection connection;

        /// <summary>
        /// Constructeur : initialise la connexion avec la chaîne de connexion
        /// </summary>
        public BddManager()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["MediaTek86DB"].ConnectionString;
            connection = new MySqlConnection(connectionString);
        }

        /// <summary>
        /// Exécute une requête de lecture (SELECT) et retourne les résultats dans un DataTable
        /// </summary>
        /// <param name="query">Requête SQL</param>
        /// <param name="parameters">Paramètres éventuels (clé = nom, valeur = valeur)</param>
        /// <returns>DataTable avec les résultats</returns>
        public DataTable ExecuteReader(string query, Dictionary<string, object> parameters = null)
        {
            DataTable table = new DataTable();
            try
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand(query, connection);

                if (parameters != null)
                {
                    foreach (var param in parameters)
                    {
                        cmd.Parameters.AddWithValue(param.Key, param.Value);
                    }
                }

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(table);
            }
            catch (Exception ex)
            {
                throw new Exception("Erreur lors de la lecture : " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return table;
        }

        /// <summary>
        /// Exécute une requête d’action (INSERT, UPDATE, DELETE)
        /// </summary>
        /// <param name="query">Requête SQL</param>
        /// <param name="parameters">Paramètres</param>
        public void ExecuteNonQuery(string query, Dictionary<string, object> parameters = null)
        {
            try
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand(query, connection);

                if (parameters != null)
                {
                    foreach (var param in parameters)
                    {
                        cmd.Parameters.AddWithValue(param.Key, param.Value);
                    }
                }

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Erreur lors de l’exécution : " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
    }
}

