using System.Collections.Generic;
using MySql.Data.MySqlClient;
using MediaTek86.Modele;
namespace MediaTek86.Modele
{
    public class Motif
    {
        public int IdMotif { get; }
        public string Libelle { get; }

        public Motif(int idMotif, string libelle)
        {
            IdMotif = idMotif;
            Libelle = libelle;
        }

        public override string ToString()
        {
            return Libelle;
        }
    }
}
