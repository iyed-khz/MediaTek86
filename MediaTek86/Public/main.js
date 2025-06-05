using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaTek86.Public
{
    class main
    {
        // main.js

document.addEventListener('DOMContentLoaded', function() {
            console.log('Application JavaScript loaded.');

            // Exemple d'interaction JS (affichage d'une modale de confirmation simple)
            // Ceci est une base, la logique de confirmation sera gérée par les contrôleurs plus tard.
            document.querySelectorAll('.btn-confirm-delete').forEach(button => {
                button.addEventListener('click', function (event) {
                    // Pour l'instant, juste pour le visuel, on peut afficher une alerte JS
                    // Dans une vraie application, ce serait une modale plus sophistiquée
                    const confirmed = confirm('Êtes-vous sûr de vouloir supprimer cet élément ?');
                    if (!confirmed) {
                        event.preventDefault(); // Empêche l'action par défaut si l'utilisateur annule
                    }
                });
            });
        });
    }
}
