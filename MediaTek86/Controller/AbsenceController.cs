namespace MediaTek86.Model
{
    public class Absence
    {
        public int Id { get; set; }
        public int IdPersonnel { get; set; }
        public string Motif { get; set; }
        public DateTime DateDebut { get; set; }
        public DateTime DateFin { get; set; }

        public Absence(int id, int idPersonnel, string motif, DateTime dateDebut, DateTime dateFin)
        {
            Id = id;
            IdPersonnel = idPersonnel;
            Motif = motif;
            DateDebut = dateDebut;
            DateFin = dateFin;
        }

        // Constructeur sans paramètre (utile parfois)
        public Absence()
        {
        }
    }
}

