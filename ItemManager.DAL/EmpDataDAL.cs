using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ItemManager.DTO;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.IO;
using System.Configuration;
namespace ItemManager.DAL
{
    public class EmpDataDAL
    {
        string constring = ConfigurationManager.ConnectionStrings["constring"].ConnectionString;
        public void EmpData(empObjects obj, byte[] pic)
        {
            try
            {


                SqlConnection con = new SqlConnection(constring);

                con.Open();

                SqlCommand cmd = new SqlCommand("insert into Emp_details ([name],[address],[state],[Designation],[email],[Mob],[qualification],[username],[password],[Path]) values ('" + obj.name + "','" + obj.Address + "','" + obj.state + "','" + obj.Desigination + "','" + obj.email + "'," + obj.mobilenumber + ",'" + obj.qualification + "','" + obj.username + "','" + obj.password + "','" + pic + "')", con);

                cmd.ExecuteNonQuery();
            }
            catch (Exception) { return; }
        }




        public static void uncheck(TextBox uName)
        {
            DAL.EmpDataDAL.uncheck(uName);
        }

        public static void NewAdmin(empObjects eobj)
        {
            try
            {


                SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["constring"].ConnectionString);

                con.Open();

                SqlCommand cmd = new SqlCommand("insert into AdminLogin values ('" + eobj.Admin + "','" + eobj.AdminPass + "')", con);

                cmd.ExecuteNonQuery();
            }
            catch (Exception) { return; }
        }

        public static object cmbEmpnameFill()
        {
            try
            {
                SqlConnection connect = new SqlConnection(ConfigurationManager.ConnectionStrings["constring"].ConnectionString);
                connect.Open();
                DataTable td = new DataTable();
                SqlDataAdapter sda = new SqlDataAdapter("Select name from Emp_details", connect);
                sda.Fill(td);
                return td;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); throw; }
        }

        public static void AdminPasswordUpd( string newpsd, string user)
        {
            try
            {
                SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["constring"].ConnectionString);
                con.Open();
                SqlCommand cmd = new SqlCommand(" update  AdminLogin SET password = '" + newpsd + "' where username='" + user + "'", con);
                cmd.ExecuteNonQuery();
                return;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

       
        public static void AdminUsernameupd(string iD,string Existing)
        {

            try
            {
                SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["constring"].ConnectionString);
                con.Open();
                SqlCommand cmd = new SqlCommand(" update  AdminLogin SET  Username='" + iD + "' where ID='"+Existing+"'", con);
                cmd.ExecuteNonQuery();
                return;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        public static void AdminPassUpd(object iD, string newpsd, string user)
        {
            throw new NotImplementedException();
        }

        public static object rmMainSearch(string idd, string empName, string empState, string empDesign, string empQual)
        {
            DataTable td = new DataTable();

            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["constring"].ConnectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand("select  [ID],[name],[state],[Designation],[qualification] from Emp_details " + "where id like '%" + idd + "%' and name Like '%" + empName + "%' and state like '%" + empState + "%'  and designation like '%" + empDesign + "%' and  qualification like '%" + empQual + "%'", con);
            SqlDataReader dr = cmd.ExecuteReader();
            td.Load(dr);

            con.Close();
            cmd.Dispose();
            con.Close();
            con.Dispose();
            return td;
        }

        public static void AdminRem(string iD)
        {
            {
                SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["constring"].ConnectionString);
                con.Open();
                SqlCommand cmd = new SqlCommand("Delete from AdminLogin where id =" + iD, con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        public DataTable reqvaltxt( object selectedVal)
        {
            try
            {
                SqlConnection connect = new SqlConnection(constring);
                connect.Open();
                DataTable td = new DataTable();
                SqlDataAdapter sda = new SqlDataAdapter("select basicSalary from Emp_grade where Grade='" + selectedVal + "'", connect);
                sda.Fill(td);
                return td;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); throw; }

        }

        public static void EmpUsernameupd(string ID)
        {
            try
            {
                SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["constring"].ConnectionString);
                con.Open();
                SqlCommand cmd = new SqlCommand(" update  Emp_details SET  Username='" + ID + "'", con);
                cmd.ExecuteNonQuery();
                return;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        public static void totalSalary(string employeeName, string empGrade, int basicsal, int benifits, int totalDeduction, int roundedsalary)
        {
            //try
            //{
                SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["constring"].ConnectionString);
                con.Open();
                SqlCommand cmd = new SqlCommand(" insert into Salary([EmployeeName],[EmployeeGrade],[BasicSalary],[Benefits],[Deduction],[TotalSalary]) values('" + employeeName+"','"+empGrade+"',"+basicsal+","+benifits+","+totalDeduction+","+roundedsalary+ ")", con);
                cmd.ExecuteNonQuery();                                                                          
                return;
            //}
            //catch (Exception ) {  }
        }

        public static void PasswordUpdate(string iD, string newpsd, string user)
        {
            try
            {
                SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["constring"].ConnectionString);
                con.Open();
                SqlCommand cmd = new SqlCommand(" update  Emp_details SET password = '" + newpsd + "' where password='" + iD + "' and username='" + user + "'", con);
                cmd.ExecuteNonQuery();
                return;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }


        public object adminGridLoad(string ename, string estate)
        {
            DataTable td = new DataTable();

            SqlConnection con = new SqlConnection(constring);
            con.Open();
            SqlCommand cmd = new SqlCommand("select [name],[address],[state],[Designation],[Mob],[qualification],[path] from Emp_details " + "where  name Like '%" + ename + "%' and state like '%" + estate + "%' ", con);
            SqlDataReader dr = cmd.ExecuteReader();
            td.Load(dr);

            con.Close();
            cmd.Dispose();
            con.Close();
            con.Dispose();
            return td;
        }

        public void DeleteEmp(string id)
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            SqlCommand cmd = new SqlCommand("Delete from Emp_details where id =" + id, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void updateData(empObjects obj)
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();

            SqlCommand cmd = new SqlCommand("update Emp_details set name ='" + obj.name + "', address ='" + obj.Address + "', state ='" + obj.state + "', Designation ='" + obj.Desigination + "', email ='" + obj.email + "', Mob ='" + obj.mobilenumber + "', qualification='" + obj.qualification + "', username='" + obj.username + "',password='" + obj.password + "'" + " where ID=" + obj.ID, con);


            SqlDataReader rd = cmd.ExecuteReader();
        }
        public DataTable adminLogin(empObjects eobj)
        {
            DataTable td = new DataTable();
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from AdminLogin where username='" +eobj.Admin + "' and password ='" + eobj.AdminPass + "'", con);
            cmd.CommandTimeout = 90;
            SqlDataReader dr = cmd.ExecuteReader();
            td.Load(dr);
            con.Close();
            return (td);

        }

        public DataTable LoginSource(empObjects obj)
        {
            DataTable dt = new DataTable();

            SqlConnection con = new SqlConnection(constring);
            con.Open();
            SqlCommand cmd = new SqlCommand("select [username],[password] from Emp_details where username='" + obj.username + "' and password='" + obj.password + "'", con);

            //cmd.Parameters.AddWithValue("@Username", obj.username);
            //cmd.Parameters.AddWithValue("@pass", obj.password);
            SqlDataReader dr = cmd.ExecuteReader();
            dt.Load(dr);
            return dt;

        }

        public DataTable RetrivalGrid()
        {
            DataTable td = new DataTable();



            SqlConnection con = new SqlConnection(constring);

            con.Open();

            SqlCommand cmd = new SqlCommand("SELECT * from Emp_details", con);
            SqlDataReader dr = cmd.ExecuteReader();
            td.Load(dr);
            return td;
        }
        public static void EmpInfoEdit(string phNumber, string email, string address, string state, string ID)
        {
            try
            {
                SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["constring"].ConnectionString);
                con.Open();
                SqlCommand cmd = new SqlCommand(" update  Emp_details SET Mob='" + phNumber + "',email='" + email + "',address='" + address + "', state='" + state + "' where Username='" + ID + "'", con);
                cmd.ExecuteNonQuery();
                return;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        public DataTable fillCombo()
        {
            try { 
            SqlConnection connect = new SqlConnection(constring);
            connect.Open();
            DataTable td = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter("Select [Grade] ,[basicSalary] from Emp_grade", connect);
            sda.Fill(td);
            return td;
            }catch(Exception ex) { MessageBox.Show(ex.Message); throw; }
        }   

    }



    }
    

