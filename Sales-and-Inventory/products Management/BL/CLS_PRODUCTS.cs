using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace products_Management.BL
{
    class CLS_PRODUCTS
    {
        public DataTable GET_ALL_CATEGORIES()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("GET_ALL_CATEGORIES", null);
            DAL.Close();
            return Dt;
        }
        public DataTable GET_ALL_Suppliers()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("GET_ALL_Suppliers", null);
            DAL.Close();
            return Dt;
        }
        public DataTable Inventory_TR()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("Inventory_TR", null);
            DAL.Close();
            return Dt;
        }







        public void ADD_PRODUCT(string ID, string Product_Name,
            string Description, string Standard_Cost, string List_Price,
           string Quantity_Per_Unit, string Category)
           
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[7];
            param[0] = new SqlParameter("@ID", SqlDbType.VarChar,30);
            param[0].Value = ID;
            param[1] = new SqlParameter("@Product_Name", SqlDbType.NVarChar, 50);
            param[1].Value = Product_Name;
            param[2] = new SqlParameter("@Description", SqlDbType.NText);
            param[2].Value = Description;
            param[3] = new SqlParameter("@Standard_Cost", SqlDbType.VarChar,50);
            param[3].Value = Standard_Cost;
            param[4] = new SqlParameter("@List_Price", SqlDbType.VarChar,50);
            param[4].Value = List_Price;
            param[5] = new SqlParameter("@Quantity_Per_Unit", SqlDbType.NVarChar,50);
            param[5].Value = Quantity_Per_Unit;
            param[6] = new SqlParameter("@Category", SqlDbType.NVarChar,50);
            param[6].Value = Category;
           

            DAL.ExecuteCommand("ADD_PRODUCT ", param);
            DAL.Close();


        }
        public DataTable VerifyProductID(string ID)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ID", SqlDbType.VarChar, 30);
            param[0].Value = ID;
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("VerifyProductID", param);
            DAL.Close();
            return Dt;
        }

        public DataTable GET_ALL_PRODUCTS()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("GET_ALL_PRODUCTS", null);
            DAL.Close();
            return Dt;
        }
        public DataTable SearchProduct(string ID)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ID", SqlDbType.NVarChar,50);
            param[0].Value = ID;
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("SearchProduct", param);
            DAL.Close();
            return Dt;
        }

        public void DeleteProduct(string ID)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ID", SqlDbType.VarChar,30);
            param[0].Value = ID;
            DAL.ExecuteCommand("DeleteProduct ", param);
            DAL.Close();
        }
        public DataTable GET_IMAGE_PRDUCT(string ID)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ID", SqlDbType.VarChar, 50);
            param[0].Value = ID;
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("GET_IMAGE_PRDUCT", param);
            DAL.Close();
            return Dt;
        }
       

        public void UPDATE_PRDUCT(string ID, string Product_Name,
           string Description, string Standard_Cost, string List_Price,
          string Quantity_Per_Unit, string Category)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[7];
            param[0] = new SqlParameter("@ID", SqlDbType.VarChar, 30);
            param[0].Value = ID;
            param[1] = new SqlParameter("@Product_Name", SqlDbType.NVarChar, 50);
            param[1].Value = Product_Name;
            param[2] = new SqlParameter("@Description", SqlDbType.NText);
            param[2].Value = Description;
            param[3] = new SqlParameter("@Standard_Cost", SqlDbType.VarChar,50);
            param[3].Value = Standard_Cost;
            param[4] = new SqlParameter("@List_Price", SqlDbType.VarChar,50);
            param[4].Value = List_Price;
            param[5] = new SqlParameter("@Quantity_Per_Unit", SqlDbType.NVarChar, 50);
            param[5].Value = Quantity_Per_Unit;
            param[6] = new SqlParameter("@Category", SqlDbType.NVarChar, 50);
            param[6].Value = Category;
           

            DAL.ExecuteCommand("UPDATE_PRDUCT", param);
            DAL.Close();


        }

      
           

          


        



            




        
          



       


    }
}
