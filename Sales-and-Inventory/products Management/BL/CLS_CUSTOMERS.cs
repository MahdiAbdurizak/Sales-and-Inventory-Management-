using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace products_Management.BL
{
    class CLS_CUSTOMERS
    {

        public void ADD_CUSTOMER(string Company, string First_Name, string Last_Name,
             string Email, string Mobile, string Address, string Notes)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[7];
            param[0] = new SqlParameter("@Company", SqlDbType.NVarChar, 50);
            param[0].Value = Company;
            param[1] = new SqlParameter("@First_Name", SqlDbType.NVarChar, 50);
            param[1].Value = First_Name;

            param[2] = new SqlParameter("@Last_Name", SqlDbType.NVarChar, 50);
            param[2].Value = Last_Name;

            param[3] = new SqlParameter("@Email_Address", SqlDbType.NVarChar, 50);
            param[3].Value = Email;


            param[4] = new SqlParameter("@Mobile_Phone", SqlDbType.NVarChar, 25);
            param[4].Value = Mobile;
            param[5] = new SqlParameter("@Address", SqlDbType.NText);
            param[5].Value = Address;
            param[6] = new SqlParameter("@Notes", SqlDbType.NText);
            param[6].Value = Notes;
            DAL.ExecuteCommand("ADD_CUSTOMER", param);

            DAL.Close();
        }
        public void ADD_Suppliers(string Company, string First_Name, string Last_Name,
            string Mobile, string Email,  string Notes)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[6];
            param[0] = new SqlParameter("@Company", SqlDbType.NVarChar, 50);
            param[0].Value = Company;
            param[1] = new SqlParameter("@First_Name", SqlDbType.NVarChar, 50);
            param[1].Value = First_Name;

            param[2] = new SqlParameter("@Last_Name", SqlDbType.NVarChar, 50);
            param[2].Value = Last_Name;
            param[3] = new SqlParameter("@Mobile_Phone", SqlDbType.NVarChar, 25);
            param[3].Value = Mobile;

            param[4] = new SqlParameter("@Email_Address", SqlDbType.NVarChar, 50);
            param[4].Value = Email;


           
            
            param[5] = new SqlParameter("@Notes", SqlDbType.NText);
            param[5].Value = Notes;
            DAL.ExecuteCommand("ADD_Suppliers", param);

            DAL.Close();
        }



          
        
        public void EDIT_CUSTOMER(int ID ,string Company, string First_Name, string Last_Name,
             string Email, string Mobile, string Address, string Notes)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[8];
            param[0] = new SqlParameter("@ID", SqlDbType.Int);
            param[0].Value = ID;
            param[1] = new SqlParameter("@Company", SqlDbType.NVarChar, 50);
            param[1].Value = Company;
            param[2] = new SqlParameter("@First_Name", SqlDbType.NVarChar, 50);
            param[2].Value = First_Name;

            param[3] = new SqlParameter("@Last_Name", SqlDbType.NVarChar, 50);
            param[3].Value = Last_Name;

            param[4] = new SqlParameter("@Email_Address", SqlDbType.NVarChar, 50);
            param[4].Value = Email;


            param[5] = new SqlParameter("@Mobile_Phone", SqlDbType.NVarChar, 25);
            param[5].Value = Mobile;
            param[6] = new SqlParameter("@Address", SqlDbType.NText);
            param[6].Value = Address;
            param[7] = new SqlParameter("@Notes", SqlDbType.NText);
            param[7].Value = Notes;
            DAL.ExecuteCommand("EDIT_CUSTOMER", param);
            DAL.Close();
        }

        public void EDIT__Suppliers(int ID, string Company, string First_Name, string Last_Name,
            string Mobile, string Email, string Notes)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[7];
            param[0] = new SqlParameter("@ID", SqlDbType.Int);
            param[0].Value = ID;
            param[1] = new SqlParameter("@Company", SqlDbType.NVarChar, 50);
            param[1].Value = Company;
            param[2] = new SqlParameter("@First_Name", SqlDbType.NVarChar, 50);
            param[2].Value = First_Name;

            param[3] = new SqlParameter("@Last_Name", SqlDbType.NVarChar, 50);
            param[3].Value = Last_Name;

           

            param[4] = new SqlParameter("@Mobile_Phone", SqlDbType.NVarChar, 25);
            param[4].Value = Mobile;
            param[5] = new SqlParameter("@Email_Address", SqlDbType.NVarChar, 50);
            param[5].Value = Email;

           
            param[6] = new SqlParameter("@Notes", SqlDbType.NText);
            param[6].Value = Notes;
            DAL.ExecuteCommand("EDIT__Suppliers", param);
            DAL.Close();
        }
        public void DELETE_CUSTOMER(int ID)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[1];
           
            param[0] = new SqlParameter("@ID", SqlDbType.Int);
            param[0].Value = ID;
            DAL.ExecuteCommand("DELETE_CUSTOMER", param);
            DAL.Close();
        }
        public void DELETE_Suppliers(int ID)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@ID", SqlDbType.Int);
            param[0].Value = ID;
            DAL.ExecuteCommand("DELETE_Suppliers", param);
            DAL.Close();
        }
           
           

           


        
        public DataTable GET_ALL_CUSTOMERS()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("GET_ALL_CUSTOMERS", null);
            DAL.Close();
            return Dt;
        }

        public DataTable GET_ALL_Suppliers2()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("GET_ALL_Suppliers2", null);
            DAL.Close();
            return Dt;
        }
        public DataTable Search_Customer(string Criterion)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@Criterion", SqlDbType.VarChar,50);
            param[0].Value = Criterion;
            Dt = DAL.SelectData("Search_Customer", param);
            DAL.Close();
            return Dt;
        }
        public DataTable Search_Suppliers(string Criterion)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@Criterion", SqlDbType.VarChar, 50);
            param[0].Value = Criterion;
            Dt = DAL.SelectData("Search_Suppliers", param);
            DAL.Close();
            return Dt;
        }
    }
}
