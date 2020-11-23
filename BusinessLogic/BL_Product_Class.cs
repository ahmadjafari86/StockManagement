using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using System.Data;

namespace BusinessLogic
{
    public class BL_Product_Class
    {
        private readonly StockManagementDatabase smdb_class = new StockManagementDatabase();
        public DataTable SelectProduct()
        {
            string query = "Select * from tbProduct";
            return smdb_class.ExecuteSelectQuery(query);
        }
        public bool InsertProduct(string productCode, string productName, bool status)
        {
            string query = "Insert into tbProduct values ('"+productCode+ "','" +productName+ "','" +status+ "')";
            return smdb_class.ExecuteInsertQuery(query);
        }
        public bool DeleteProduct(string productCode)
        {
            string query = "DELETE From tbProduct Where productCode = '" + productCode + "'";
            return smdb_class.DeleteQuery(query);
        }
    }
}
