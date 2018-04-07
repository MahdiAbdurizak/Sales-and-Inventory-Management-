using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace products_Management.BL
{
    class CLS_LOGIN
    {
        public DataTable LOGIN(string ID, string PWD)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@ID", SqlDbType.VarChar, 50);
            param[0].Value = ID;

            param[1] = new SqlParameter("@PWD", SqlDbType.VarChar, 50);
            param[1].Value = PWD;



            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("SP_LOGIN2", param);
            DAL.Close();
            return Dt;
        }

        public void ADD_USER(string ID, string FullName,
           string PWD, string UserType)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[4];
            param[0] = new SqlParameter("@ID", SqlDbType.VarChar,50);
            param[0].Value = ID;

            param[1] = new SqlParameter("@FullName", SqlDbType.VarChar, 50);
            param[1].Value = FullName;


            param[2] = new SqlParameter("@PWD", SqlDbType.VarChar,50);
            param[2].Value = PWD;

            param[3] = new SqlParameter("@UserType", SqlDbType.VarChar,50);
            param[3].Value = UserType;


            DAL.ExecuteCommand("ADD_USER ", param);
            DAL.Close();


        }

        public void EDIT_USER(string ID, string FullName,
           string PWD, string UserType)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[4];
            param[0] = new SqlParameter("@ID", SqlDbType.VarChar, 50);
            param[0].Value = ID;

            param[1] = new SqlParameter("@FullName", SqlDbType.VarChar, 50);
            param[1].Value = FullName;


            param[2] = new SqlParameter("@PWD", SqlDbType.VarChar, 50);
            param[2].Value = PWD;

            param[3] = new SqlParameter("@UserType", SqlDbType.VarChar, 50);
            param[3].Value = UserType;


            DAL.ExecuteCommand("EDIT_USER", param);
            DAL.Close();


        }
        public void DELETE_USER(string ID)
          
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ID", SqlDbType.VarChar, 50);
            param[0].Value = ID;


            DAL.ExecuteCommand("DELETE_USER", param);
            DAL.Close();


        }
        public DataTable SearchUsers2(string Criterion)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@Criterion", SqlDbType.VarChar, 50);
            param[0].Value = Criterion;
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("SearchUsers2", param);
            DAL.Close();
            return Dt;


        }




    }
}
