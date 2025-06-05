using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaTek86.Model
{
    public class absence
    {
        public int Id { get; set; }
        public int IdPersonnel { get; set; }
        public string Motif { get; set; }
        public DateTime DateDebut { get; set; }
        public DateTime DateFin { get; set; }

        public absence(int id, int idPersonnel, string motif, DateTime dateDebut, DateTime dateFin)
        {
            Id = id;
            IdPersonnel = idPersonnel;
            Motif = motif;
            DateDebut = dateDebut;
            DateFin = dateFin;
        }
        
    }
}
