using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;

namespace BusinessLogic
{
    public class BL_Login_Class
    {
        /// Check login validation
        public bool LoginValidation(string userName, string userPass)
        { 
            string query = "SELECT username ,password FROM tbLogin where username = '"+userName+"' and password = '"+userPass+"'";
            StockManagementDatabase smdb_class = new StockManagementDatabase();
            if (smdb_class.ExecuteSelectQuery(query).Rows.Count == 1)
                return true;
            else return false;
        }
       
    }
}
