using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ItemManager.DTO
{
    public class Objects
    {
       

        public string id { get; set; }


        public string type { get; set; }
        public string  count { get; set; }
        public string color { get; set; }
        public int lotno { get; set; }
        public string weight { get; set; }
        public string location { get; set; }

        

       

        //public  int id()
        //{
        //    SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-NR4D8TG\SQLEXPRESS;Initial Catalog=InventoryManagement;Integrated Security=True");
        //    con.Open();
        //    SqlCommand cmd = new SqlCommand("select pk_id from ItemManager where pk_id = " + ID + "", con);
        //    cmd.Parameters.Add(new SqlParameter("ID", 1));
        //    return 1;
        //}
    }

}
