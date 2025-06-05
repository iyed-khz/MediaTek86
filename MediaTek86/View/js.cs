using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MediaTek86.View
{
    public class js
    {
        // JavaScript personnalisé pour le projet MediaTek86
        // Vous pouvez reprendre les scripts de votre fichier main.js précédent ici

        // Exemple de confirmation de suppression (à améliorer pour la robustesse)
        Document.addEventListener('DOMContentLoaded', private function()
        {
            const deleteButtons = document.querySelectorAll('.btn-confirm-delete');
            deleteButtons.forEach(button => {
            button.addEventListener('click', function(event) {
            // Prévient la navigation immédiate pour les liens <a>
            // Pour les <button type="submit"> dans un <form>, la logique serait différente
            if (!confirm('Êtes-vous sûr de vouloir supprimer cet élément ?\nCette action est irréversible.'))
            {
                event.preventDefault(); 
            }
            // Si confirmé, le comportement par défaut du lien (navigation) se poursuit.
        } 
        

         // Vous pouvez ajouter d'autres scripts ici, par exemple:
         // - Validation de date de fin >= date de début pour les absences
         // - Initialisation de plugins JS (datepicker, etc.)
        
     }
}
