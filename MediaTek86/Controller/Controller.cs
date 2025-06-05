using System.Collections.Generic;
using MediaTek86.Modele;
using MediaTek86.dal;

namespace MediaTek86.Controller
{
    public class Controller
    {
        /// <summary>
        /// Récupère la liste de tous les personnels.
        /// </summary>
        /// <returns>Liste de personnels</returns>
        public List<Personnel> GetAllPersonnels()
        {
            return AccessPersonnel.GetAllPersonnels();
        }

        /// <summary>
        /// Récupère la liste des absences d’un personnel.
        /// </summary>
        /// <param name="idPersonnel">Identifiant du personnel</param>
        /// <returns>Liste d’absences</returns>
        public List<Absence> GetAbsencesByPersonnel(int idPersonnel)
        {
            return AccessAbsence.GetAbsencesByPersonnel(idPersonnel);
        }

        /// <summary>
        /// Récupère la liste de tous les motifs d’absence.
        /// </summary>
        /// <returns>Liste de motifs</returns>
        public List<Motif> GetAllMotifs()
        {
            return AccessMotif.GetAllMotifs();
        }
    }
}
