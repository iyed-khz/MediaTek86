using System.Collections.Generic;
using MediaTek86.Model;

namespace MediaTek86.Controller
{
    public class PersonnelController
    {
        private List<Personnel> personnels;

        public PersonnelController()
        {
            personnels = new List<Personnel>
            {
                new Personnel(1, "Durand", "Alice", "alice.durand@email.com", "0123456789"),
                new Personnel(2, "Martin", "Bob", "bob.martin@email.com", "0987654321")
            };
        }

        public List<Personnel> GetAllPersonnels()
        {
            return personnels;
        }

        public void AjouterPersonnel(Personnel personnel)
        {
            personnels.Add(personnel);
        }

        public void SupprimerPersonnel(int id)
        {
            personnels.RemoveAll(p => p.Id == id);
        }
    }
}

