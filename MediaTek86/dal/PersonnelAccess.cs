using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediaTek86.modele;

namespace MediaTek86.dal
{
    public class PersonnelAccess
    {
        private readonly Access access = null;

        public PersonnelAccess()
        {
            access = Access.GetInstance();
        }

        public List<Personnel> GetLesPersonnels()
        {
            List<Personnel> lesDeveloppeurs = new List<Personnel>();
            if (access.Manager != null)
            {
                string req = "select p.idpersonnel as idpersonnel,p.idservice as idservice, p.nom as nom, p.prenom as prenom, p.tel as tel, p.mail as mail ";
                req += "from personnel p ";
                req += "order by nom, prenom;";
                try
                {
                    List<Object[]> records = access.Manager.ReqSelect(req);
                    if (records != null)
                    {
                        foreach (Object[] record in records)
                        {
                            Personnel personnel = new Personnel((int)record[0], (int)record[1], (string)record[2],
                                (string)record[3], (string)record[4], (string)record[5]);
                            lesDeveloppeurs.Add(personnel);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Environment.Exit(0);
                }
            }
            return lesDeveloppeurs;
        }

        public void DelPersonnel(Personnel personnel)
        {
            if (access.Manager != null)
            {
                string req = "delete from personnel where idpersonnel = @idpersonnel;";
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                parameters.Add("@idpersonnel", personnel.idpersonnel);
                try
                {
                    access.Manager.ReqUpdate(req, parameters);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Environment.Exit(0);
                }
            }
        }
        public void AddPersonnel(Personnel personnel)
        {
            if (access.Manager != null)
            {
                string req = "insert into personnel(idpersonnel, idservice, nom, prenom, tel, mail) ";
                req += "values (@idpersonnel, @idservice, @nom, @prenom, @tel, @mail);";
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                parameters.Add("@idpersonnel", personnel.idpersonnel);
                parameters.Add("@idservice", personnel.idservice);
                parameters.Add("@nom", personnel.nom);
                parameters.Add("@prenom", personnel.prenom);
                parameters.Add("@tel", personnel.tel);
                parameters.Add("@mail", personnel.mail);
                try
                {
                    access.Manager.ReqUpdate(req, parameters);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Environment.Exit(0);
                }
            }
        }
    }
}
