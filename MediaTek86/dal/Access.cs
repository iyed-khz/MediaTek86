using System;

namespace MediaTek86.dal
{
    /// <summary>
    /// Classe d'accès aux données : base pour toutes les requêtes.
    /// </summary>
    public class Access
    {
        /// <summary>
        /// Chaîne de connexion à la base de données.
        /// </summary>
        private static readonly string connectionString = "server=localhost;user id=root;password=;database=mediatek86;";

        /// <summary>
        /// Méthode pour récupérer la chaîne de connexion.
        /// </summary>
        /// <returns>La chaîne de connexion SQL.</returns>
        public static string GetConnectionString()
        {
            return connectionString;
        }
    }
}

