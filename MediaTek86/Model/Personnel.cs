using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace MediaTek86.Model
{
    public class Personnel
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Mail { get; set; }
        public string Tel { get; set; }

        // Constructeur avec paramètres
        public Personnel(int id, string nom, string prenom, string mail, string tel)
        {
            Id = id;
            Nom = nom;
            Prenom = prenom;
            Mail = mail;
            Tel = tel;
        }

        // Constructeur sans paramètres (utile pour certains usages)
        public Personnel()
        {
        }
    }
}

