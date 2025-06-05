using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaTek86.Model
{
    public class Responsable
    {
        // Si vous prévoyez une table pour les responsables, ajoutez un Id
        // public int Id { get; set; } 

        public string Login { get; set; }

        // Ce champ devrait stocker le HASH du mot de passe, pas le mot de passe en clair.
        // Pour la vue Login.cshtml, vous aurez besoin d'une propriété pour saisir le mot de passe en clair
        // qui sera ensuite hashé pour comparaison.
        // Pour la liaison de modèle dans le formulaire de connexion, ce Pwd sera temporairement le mdp en clair.
        public string Pwd { get; set; }
    }
}
