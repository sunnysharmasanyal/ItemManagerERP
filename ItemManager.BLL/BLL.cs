
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ItemManager.DTO;
using ItemManager.DAL;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System;

namespace ItemManager.BLL
{

    public class BLL
    {
        //accessing the objects and using the objects
        
        public static void GetVal(Objects objs)
        {


            Connection objdal = new Connection();
            if (objs.id == null)
            {
                objdal.Add(objs);
            }
            else
            {
                objdal.updateData(objs);
            }
        }
        
       public void getDelete(Objects obj)
        {
            Connection getDel = new Connection();
            getDel.delete(obj);

        }


        public static DataTable Valget()
        {
            Connection mycon = new Connection();
            return mycon.GridLoad();

        }

        public static DataTable DirectSearch()
        {
          
            return DAL.Connection.directLoadGrid();
        }

        public  static DataTable  search (string type, string color , string location)
        {

            Connection mycon = new Connection();
            return mycon.searchType(type, color, location);
           }
        public static void IssueData( string weight, string id)

        {
            Connection con = new Connection();
            con.IssueForm( weight, id);


        }
        public  static void receive (string Weight, string id)
        {
            Connection con = new Connection();
            con.ReceiveForm(Weight, id);
        }
        public static DataTable Msearch(string type, string color,string location)
        {
            Connection cn = new Connection();
          return  cn.MainFormSearch(type,color,location);
        }

       
    }
}



    
