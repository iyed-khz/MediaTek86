using MediaTek86.bddmanager;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaTek86.dal
{
    public class Responsable
    {
        public static bool CheckLogin(string login, string pwd)
        {
            string req = "SELECT * FROM responsable WHERE login=@login AND pwd=SHA2(@pwd, 256)";
            Dictionary<string, object> parameters = new Dictionary<string, object>
    {
        {"@login", login},
        {"@pwd", pwd}
    };

            DataTable dt = BddManager.GetDataTable(req, parameters);
            return dt.Rows.Count > 0;
        }
    }
}
