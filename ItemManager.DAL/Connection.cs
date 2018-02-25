using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ItemManager.DTO;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.Configuration;
namespace ItemManager.DAL
{
   
    public class Connection
    {
        //TODO: Creating the Method for accessing and open the Connection 
        string  constring = ConfigurationManager.ConnectionStrings["constring"].ConnectionString;

        
        public void Add(Objects add)
        {

            SqlConnection con = new SqlConnection(constring);

            con.Open();

            SqlCommand cmd = new SqlCommand("insert into ItemManager values ('" + add.type + "'," + add.count + "," + add.lotno + ",'" + add.color + "'," + add.weight + ",'" + add.location + "')", con);

            SqlDataReader rd = cmd.ExecuteReader();
        }

        public void updateData(Objects obj)
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();

            SqlCommand cmd = new SqlCommand("update ItemManager set type='" + obj.type + "', count=" + obj.count + ", Lotno=" + obj.lotno + ", color='" + obj.color + "', weight=" + obj.weight + ", location='" + obj.location + "'" + " where pk_id=" + obj.id, con);


            SqlDataReader rd = cmd.ExecuteReader();
        }

        public static DataTable directLoadGrid()
        {
            DataTable tb = new DataTable();
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["constring"].ConnectionString);
            con.Open();
           

            SqlCommand cmd = new SqlCommand(" select pk_id, weight,Date from Issue", con);
            SqlDataReader dr = cmd.ExecuteReader();
            tb.Load(dr);
            return tb;


        }

        // reading Meethod----> :)        
        public DataTable GridLoad()
        {
            DataTable tb = new DataTable();
            SqlConnection conn = new SqlConnection(constring);
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * from ItemManager", conn);
            SqlDataReader rd = cmd.ExecuteReader();
            tb.Load(rd);

            conn.Close();
            return tb;
        }

        

        public void delete(Objects obj)
        {

            SqlConnection con3 = new SqlConnection(constring);
            con3.Open();
            SqlCommand cmd = new SqlCommand("DELETE FROM ItemManager" + " where pk_id=" + obj.id, con3);
            cmd.ExecuteNonQuery();
            con3.Close();

        }
        public DataTable searchType(string obj, string color, string location)

        {
            DataTable td = new DataTable();

            SqlConnection con = new SqlConnection(constring);
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from ItemManager " + "where  type Like '%" + obj + "%' and color like '%" + color + "%' and location like '%" + location + "%'", con);
            SqlDataReader dr = cmd.ExecuteReader();
            td.Load(dr);

            con.Close();
            cmd.Dispose();
            con.Close();
            con.Dispose();
            return td;

        }
        // Method for Accessing the store Procedure to Update and Insert the data

        public void IssueForm(string weight, string id)
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            SqlCommand cmd = new SqlCommand("Myquerytest1", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Weight", weight);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
            con.Dispose();
        }

        public void ReceiveForm(string Rweight, string Rid)
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            SqlCommand cmd = new SqlCommand("receive_add", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@weight", Rweight);
            cmd.Parameters.AddWithValue("@id", Rid);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
            cmd.Dispose();
        }

        public DataTable MainFormSearch(string type, string color, string location)
        {
            DataTable td = new DataTable();
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            SqlCommand cmd = new SqlCommand("ItemManagerInv", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@type", type);
            cmd.Parameters.AddWithValue("@color", color);
            cmd.Parameters.AddWithValue("@location", location);
            SqlDataReader dr = cmd.ExecuteReader();
            td.Load(dr);

            return td;
        }


           


    }
}
            
            
            

         

           




       





    


