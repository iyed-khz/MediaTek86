using MediaTek86.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaTek86.Controller
{
    public class AuthController
    {
        // Méthode pour afficher la page de connexion (GET request)
        [HttpGet]
        public IActionResult Login()
        {
            // Vous pouvez passer un message d'erreur vide initialement
            ViewBag.ErrorMessage = null;
            return View(); // Cherchera Views/Auth/Login.cshtml par défaut
        }

        // Méthode pour traiter la soumission du formulaire de connexion (POST request)
        [HttpPost]
        public IActionResult Login(string login, string password)
        {
            // Pour l'instant, juste un test visuel
            if (login == "admin" && password == "password") // *** À REMPLACER PAR UNE VRAIE VÉRIFICATION DU HASH DE LA BD ***
            {
                // Rediriger vers la page de gestion du personnel
                return RedirectToAction("List", "Personnel");
            }
            else
            {
                ViewBag.ErrorMessage = "Login ou mot de passe incorrect.";
                return View(); // Retourne à la même vue de login avec le message d'erreur
            }
        }

        // Méthode pour la déconnexion
        public IActionResult Logout()
        {
            // Ici, vous géreriez la déconnexion (par exemple, effacer la session ou le cookie d'authentification)
            return RedirectToAction("Login", "Auth");
        }
    }
}
