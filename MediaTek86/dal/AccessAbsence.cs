using MySql.Data.MySqlClient;

namespace MediaTek86.dal
{
    public class AccessAbsence
    {
        /// <summary>
        /// Récupère les absences d’un personnel.
        /// </summary>
        /// <param name="idPersonnel">Identifiant du personnel</param>
        /// <returns>Liste d’objets Absence</returns>
        public static List<Absence> GetAbsencesByPersonnel(int idPersonnel)
        {
            List<Absence> absences = new List<Absence>();

            string req = "SELECT idabsence, datedebut, datefin, idmotif, idpersonnel FROM absence WHERE idpersonnel = @id;";
            using (MySqlConnection connection = new MySqlConnection(Access.GetConnectionString()))
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand(req, connection);
                command.Parameters.AddWithValue("@id", idPersonnel);
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Absence absence = new Absence(
                        reader.GetInt32("idabsence"),
                        reader.GetDateTime("datedebut"),
                        reader.GetDateTime("datefin"),
                        reader.GetInt32("idmotif"),
                        reader.GetInt32("idpersonnel")
                    );
                    absences.Add(absence);
                }
            }

            return absences;
        }
    }
}

