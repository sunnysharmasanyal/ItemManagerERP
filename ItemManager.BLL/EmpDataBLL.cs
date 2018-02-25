using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ItemManager.DAL;
using ItemManager.DTO;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.IO;

namespace ItemManager.BLL
{
   public class EmpDataBLL

    {
        DataTable dt = new DataTable();
        public empObjects count;
        DAL.EmpDataDAL empAdd = new EmpDataDAL();
       public  void empDataAdd (empObjects obj, byte[] pic)
        {
          
            empAdd.EmpData(obj,pic); 
        }

       

        public DataTable LoginBLL(empObjects obj)
        {
         
            EmpDataDAL LoginDal = new EmpDataDAL();
          return  LoginDal.LoginSource(obj);
             
           
        }

       

        public static object rmSearch( string idd,string empName, string empState, string empDesign, string empQual)
        {
            return EmpDataDAL.rmMainSearch(idd,empName,empState, empDesign,  empQual);
        }

        public static void AdnewAdmin(empObjects eobj)
        {
            DAL.EmpDataDAL.NewAdmin(eobj);
        }

        public static void AdPassupd( string newpsd, string user)
        {
            DAL.EmpDataDAL.AdminPasswordUpd( newpsd, user);
        }

        public object cmbEmpValueFill()
        {
            return DAL.EmpDataDAL.cmbEmpnameFill();
        }

        public DataTable adlogin(empObjects eobj)
        {
           return empAdd.adminLogin(eobj);
        }
        public DataTable Gload()
        {
         return   empAdd.RetrivalGrid();
        }

        public void update (empObjects obj)
        {
            EmpDataDAL dal = new EmpDataDAL();
            dal.updateData(obj);

        }

        public static void AdUsernameUpd(string iD, string Existing)
        {
            DAL.EmpDataDAL.AdminUsernameupd(iD,Existing);
        }

        public void delEmp(string id)
        {
            EmpDataDAL dalLayer = new EmpDataDAL();
            dalLayer.DeleteEmp(id);
        }

        public DataTable reqValMethod( object selectedVal)
        {
          
         return  empAdd.reqvaltxt( selectedVal);
          
            
        }

        public object adminload(string ename, string estate)
        {
            EmpDataDAL dal = new EmpDataDAL();
         return    dal.adminGridLoad(ename, estate);

             
        }
        public static void editemp(string phNumber, string email, string address, string state, string ID)
        {
            DAL.EmpDataDAL.EmpInfoEdit(phNumber, email, address, state, ID);
        }

        public static void UsernameUpd(string iD)
        {
            DAL.EmpDataDAL.EmpUsernameupd(iD);
        }

        public static void pssupdate(string ID, string newpsd, string user)
        {
            DAL.EmpDataDAL.PasswordUpdate(ID, newpsd,user);
        }
        public DataTable cmbValuefill()
        {
           return empAdd.fillCombo();
        }

        public static void empSalary(string employeeName, string empGrade, int basicsal, int benifits, int totalDeduction, int roundedsalary )
        {
            DAL.EmpDataDAL.totalSalary(employeeName, empGrade, basicsal, benifits, totalDeduction, roundedsalary);
        }

        public static void AdRemove(string iD)
        {
            DAL.EmpDataDAL.AdminRem(iD);
        }
    }
}
