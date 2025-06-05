using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaTek86.Model
{
    public class Service
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Le nom du service est requis.")]
        public string NomService { get; set; }

        // Optionnel: pour lister les personnels liés directement
        // public ICollection<Personnel>? Personnels { get; set; }
    }
}
