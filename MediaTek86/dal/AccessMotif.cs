using System.Collections.Generic;
using MySql.Data.MySqlClient;
using MediaTek86.Modele;

namespace MediaTek86.dal
{
    public class AccessMotif
    {
        /// <summary>
        /// Récupère la liste de tous les motifs.
        /// </summary>
        /// <returns>Liste d’objets Motif</returns>
        public static List<Motif> GetAllMotifs()
        {
            List<Motif> motifs = new List<Motif>();

            string req = "SELECT idmotif, libelle FROM motif;";
            using (MySqlConnection connection = new MySqlConnection(Access.GetConnectionString()))
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand(req, connection);
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Motif motif = new Motif(
                        reader.GetInt32("idmotif"),
                        reader.GetString("libelle")
                    );
                    motifs.Add(motif);
                }
            }

            return motifs;
        }
    }
}
