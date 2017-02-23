using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace WindowsFormsApplication4
{
    /// <summary>
    /// klasa za spajanje na bazu
    /// </summary>
    public class DB
    {

        public SqlConnection conn = new SqlConnection("Data Source=31.147.204.119\\PISERVER,1433;Initial Catalog=1537_DB;User ID=1537_User;Password=fQWRTkwR"); //definiranje sql veze
        
        public void openDB() {
            conn.Open();
        }

        public void closeDB() {
            conn.Close();
        }

    }
}
