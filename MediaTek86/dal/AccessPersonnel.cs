using System.Collections.Generic;
using MySql.Data.MySqlClient;
using MediaTek86.Modele;

namespace MediaTek86.dal
{
    public class AccessPersonnel
    {
        /// <summary>
        /// Récupère la liste de tous les personnels.
        /// </summary>
        /// <returns>Liste d'objets Personnel</returns>
        public static List<Personnel> GetAllPersonnels()
        {
            List<Personnel> personnels = new List<Personnel>();

            string req = "SELECT idpersonnel, nom, prenom, tel, mail, idservice FROM personnel;";
            LoadPersonnels(personnels, req);

            return personnels;
        }

        private static void LoadPersonnels(List<Personnel> personnels, string req)
        {
            using (MySqlConnection connection = new MySqlConnection(Access.GetConnectionString()))
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand(req, connection);
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Personnel personnel = new Personnel(
                        reader.GetInt32("idpersonnel"),
                        reader.GetString("nom"),
                        reader.GetString("prenom"),
                        reader.GetString("tel"),
                        reader.GetString("mail"),
                        reader.GetInt32("idservice")
                    );
                    personnels.Add(personnel);
                }
            }
        }
    }
}
