using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace products_Management.BL
{
    class CLS_ORDERS
    {

        public DataTable GET_LAST_ORDER_ID()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("GET_LAST_ORDER_ID", null);
            DAL.Close();
            return Dt;
        }
        public DataTable GET_LAST_Transaction_ID()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("GET_LAST_Transaction_ID", null);
            DAL.Close();
            return Dt;
        }
        public DataTable GET_LAST_PurchaseORDER_ID()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("GET_LAST_PurchaseORDER_ID", null);
            DAL.Close();
            return Dt;
        }

        public DataTable GET_LAST_ORDER_FOR_PRINT()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("GET_LAST_ORDER_FOR_PRINT", null);
            DAL.Close();
            return Dt;
        }


        public void ADD_ORDER2(int ID_ORDER,
             DateTime DATE_ORDER, double TOTAL_PAYMENT, double AMOUNT_DUE, string SALESMAN, string Notes)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[6];
            param[0] = new SqlParameter("@ID_ORDER", SqlDbType.Int);
            param[0].Value = ID_ORDER;

          

            param[1] = new SqlParameter("@DATE_ORDER", SqlDbType.DateTime);
            param[1].Value = DATE_ORDER;

            param[2] = new SqlParameter("@SALESMAN", SqlDbType.VarChar,75);
            param[2].Value = SALESMAN;

            param[3] = new SqlParameter("@Notes", SqlDbType.NText);
            param[3].Value = Notes;
            param[4] = new SqlParameter("@TOTAL_PAYMENT", SqlDbType.Money);
            param[4].Value = TOTAL_PAYMENT;
            param[5] = new SqlParameter("@AMOUNT_DUE", SqlDbType.Money);
            param[5].Value = AMOUNT_DUE;
           

            DAL.ExecuteCommand("ADD_ORDER2", param);
            DAL.Close();
        }
        public void ADD_ORDER(int ID_ORDER, int CUSTOMER_ID,
           DateTime DATE_ORDER, float DIISCOUNT, string TOTAL_AMOUNT,
           string TOTAL_PAYMENT, string AMOUNT_DUE, string SALESMAN, string Notes)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[9];
            param[0] = new SqlParameter("@ID_ORDER", SqlDbType.Int);
            param[0].Value = ID_ORDER;
            param[1] = new SqlParameter("@CUSTOMER_ID", SqlDbType.Int);
            param[1].Value = CUSTOMER_ID;
            param[2] = new SqlParameter("@DATE_ORDER", SqlDbType.DateTime);
            param[2].Value = DATE_ORDER;
            param[3] = new SqlParameter("@DIISCOUNT", SqlDbType.Float);
            param[3].Value = DIISCOUNT;
            param[4] = new SqlParameter("@TOTAL_AMOUNT", SqlDbType.VarChar,50);
            param[4].Value = TOTAL_AMOUNT;
            param[5] = new SqlParameter("@SALESMAN", SqlDbType.VarChar, 75);
            param[5].Value = SALESMAN;
            param[6] = new SqlParameter("@Notes", SqlDbType.NText);
            param[6].Value = Notes;
            param[7] = new SqlParameter("@TOTAL_PAYMENT", SqlDbType.VarChar,50);
            param[7].Value = TOTAL_PAYMENT;
            param[8] = new SqlParameter("@AMOUNT_DUE", SqlDbType.VarChar,50);
            param[8].Value = AMOUNT_DUE;
           

            DAL.ExecuteCommand("ADD_ORDER", param);
            DAL.Close();
        }
        public void EDIT_ORDER(int ID_ORDER, int CUSTOMER_ID,
         DateTime DATE_ORDER, float DIISCOUNT, string TOTAL_AMOUNT,
          string TOTAL_PAYMENT, string AMOUNT_DUE, string SALESMAN, string Notes)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[9];
            param[0] = new SqlParameter("@ID_ORDER", SqlDbType.Int);
            param[0].Value = ID_ORDER;

            param[1] = new SqlParameter("@CUSTOMER_ID", SqlDbType.Int);
            param[1].Value = CUSTOMER_ID;


            param[2] = new SqlParameter("@DATE_ORDER", SqlDbType.DateTime);
            param[2].Value = DATE_ORDER;
            param[3] = new SqlParameter("@DIISCOUNT", SqlDbType.Float);
            param[3].Value = DIISCOUNT;
            param[4] = new SqlParameter("@TOTAL_AMOUNT", SqlDbType.VarChar,50);
            param[4].Value = TOTAL_AMOUNT;

            param[5] = new SqlParameter("@SALESMAN", SqlDbType.VarChar, 75);
            param[5].Value = SALESMAN;

            param[6] = new SqlParameter("@Notes", SqlDbType.NText);
            param[6].Value = Notes;
            param[7] = new SqlParameter("@TOTAL_PAYMENT", SqlDbType.VarChar, 50);
            param[7].Value = TOTAL_PAYMENT;
            param[8] = new SqlParameter("@AMOUNT_DUE", SqlDbType.VarChar, 50);
            param[8].Value = AMOUNT_DUE;


            DAL.ExecuteCommand("EDIT_ORDER", param);
            DAL.Close();
        }

        public void EDIT_Purchase_Orders(int ID_ORDER, int CUSTOMER_ID,
       DateTime DATE_ORDER, string TOTAL_PAYMENT, string AMOUNT_DUE, string SALESMAN, string Notes)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[7];
            param[0] = new SqlParameter("@ID_ORDER", SqlDbType.Int);
            param[0].Value = ID_ORDER;

            param[1] = new SqlParameter("@CUSTOMER_ID", SqlDbType.Int);
            param[1].Value = CUSTOMER_ID;


            param[2] = new SqlParameter("@DATE_ORDER", SqlDbType.DateTime);
            param[2].Value = DATE_ORDER;

            param[3] = new SqlParameter("@SALESMAN", SqlDbType.VarChar, 75);
            param[3].Value = SALESMAN;

            param[4] = new SqlParameter("@Notes", SqlDbType.NText);
            param[4].Value = Notes;
            param[5] = new SqlParameter("@TOTAL_PAYMENT", SqlDbType.VarChar,50);
            param[5].Value = TOTAL_PAYMENT;
            param[6] = new SqlParameter("@AMOUNT_DUE", SqlDbType.VarChar,50);
            param[6].Value = AMOUNT_DUE;


            DAL.ExecuteCommand("EDIT_Purchase_Orders", param);
            DAL.Close();
        }

        public void ADD_Purchase_Orders(int ID_ORDER, int CUSTOMER_ID,
            DateTime DATE_ORDER, string TOTAL_PAYMENT, string AMOUNT_DUE, string SALESMAN, string Notes)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[7];
            param[0] = new SqlParameter("@ID_ORDER", SqlDbType.Int);
            param[0].Value = ID_ORDER;

            param[1] = new SqlParameter("@CUSTOMER_ID", SqlDbType.Int);
            param[1].Value = CUSTOMER_ID;


            param[2] = new SqlParameter("@DATE_ORDER", SqlDbType.DateTime);
            param[2].Value = DATE_ORDER;

            param[3] = new SqlParameter("@SALESMAN", SqlDbType.VarChar,50);
            param[3].Value = SALESMAN;

            param[4] = new SqlParameter("@Notes", SqlDbType.NText);
            param[4].Value = Notes;
            param[5] = new SqlParameter("@TOTAL_PAYMENT", SqlDbType.VarChar,50);
            param[5].Value = TOTAL_PAYMENT;
            param[6] = new SqlParameter("@AMOUNT_DUE", SqlDbType.VarChar,50);
            param[6].Value = AMOUNT_DUE;

            DAL.ExecuteCommand("ADD_Purchase_Orders", param);
            DAL.Close();
        }


        public void ADD_ORDER_DETAILS(int ID_ORDER , string ID_PRODUCT,
             int QTE, string PRICE, string AMOUNT, int Inventory_ID, string Cost)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[7];
            param[0] = new SqlParameter("@ID_ORDER", SqlDbType.Int);
            param[0].Value = ID_ORDER;

            param[1] = new SqlParameter("@ID_PRODUCT", SqlDbType.VarChar,30);
            param[1].Value = ID_PRODUCT;
            param[2] = new SqlParameter("@QTE", SqlDbType.Int);
            param[2].Value = QTE;
            param[3] = new SqlParameter("@PRICE", SqlDbType.VarChar,50);
            param[3].Value = PRICE;
            param[4] = new SqlParameter("@AMOUNT", SqlDbType.VarChar,50);
            param[4].Value = AMOUNT;
            param[5] = new SqlParameter("@Inventory_ID", SqlDbType.Int);
            param[5].Value = Inventory_ID;
            param[6] = new SqlParameter("@Cost", SqlDbType.VarChar, 50);
            param[6].Value = Cost;
          
            DAL.ExecuteCommand("ADD_ORDER_DETAILS", param);
            DAL.Close();
        }
        public void EDIT_ORDER_DETAILS(int ID_ORDER, string ID_PRODUCT,
            int QTE, string PRICE, string AMOUNT,
             int Inventory_ID,string Cost)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[7];
            param[0] = new SqlParameter("@ID_ORDER", SqlDbType.Int);
            param[0].Value = ID_ORDER;

            param[1] = new SqlParameter("@ID_PRODUCT", SqlDbType.VarChar,30);
            param[1].Value = ID_PRODUCT;


            param[2] = new SqlParameter("@QTE", SqlDbType.Int);
            param[2].Value = QTE;

            param[3] = new SqlParameter("@PRICE", SqlDbType.VarChar,50);
            param[3].Value = PRICE;

            param[4] = new SqlParameter("@AMOUNT", SqlDbType.VarChar,50);
            param[4].Value = AMOUNT;
            param[5] = new SqlParameter("@Inventory_ID", SqlDbType.Int);
            param[5].Value = Inventory_ID;
            param[6] = new SqlParameter("@Cost", SqlDbType.VarChar,50);
            param[6].Value = Cost;


            DAL.ExecuteCommand("EDIT_ORDER_DETAILS", param);
            DAL.Close();
        }

        public void EDIT_Purchase_DETAILS(int ID_ORDER, string ID_PRODUCT,
           int QTE, string PRICE, string AMOUNT,
            int Inventory_ID)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[6];
            param[0] = new SqlParameter("@ID_ORDER", SqlDbType.Int);
            param[0].Value = ID_ORDER;

            param[1] = new SqlParameter("@ID_PRODUCT", SqlDbType.VarChar, 30);
            param[1].Value = ID_PRODUCT;


            param[2] = new SqlParameter("@QTE", SqlDbType.Int);
            param[2].Value = QTE;

            param[3] = new SqlParameter("@PRICE", SqlDbType.VarChar, 50);
            param[3].Value = PRICE;

            param[4] = new SqlParameter("@AMOUNT", SqlDbType.VarChar, 50);
            param[4].Value = AMOUNT;
            param[5] = new SqlParameter("@Inventory_ID", SqlDbType.Int);
            param[5].Value = Inventory_ID;
           

            DAL.ExecuteCommand("EDIT_Purchase_DETAILS", param);
            DAL.Close();
        }






        public void ADD_Purchase_Order_Details(int ID_ORDER, string ID_PRODUCT,
            int QTE, string PRICE, string TOTAL_AMOUNT,DateTime Date_Received, int Inventory_ID)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[7];
            param[0] = new SqlParameter("@ID_ORDER", SqlDbType.Int);
            param[0].Value = ID_ORDER;

            param[1] = new SqlParameter("@ID_PRODUCT", SqlDbType.VarChar,30);
            param[1].Value = ID_PRODUCT;


            param[2] = new SqlParameter("@QTE", SqlDbType.Int);
            param[2].Value = QTE;

            param[3] = new SqlParameter("@PRICE", SqlDbType.VarChar,50);
            param[3].Value = PRICE;
            param[4] = new SqlParameter("@TOTAL_AMOUNT", SqlDbType.VarChar,50);
            param[4].Value = TOTAL_AMOUNT;

            param[5] = new SqlParameter("@Date_Received", SqlDbType.DateTime);
            param[5].Value = Date_Received;
          //  param[6] = new SqlParameter("@Posted_To_Inventory", SqlDbType.Bit);
           // param[6].Value = Posted_To_Inventory;
           
           
            param[6] = new SqlParameter("@Inventory_ID", SqlDbType.Int);
            param[6].Value = Inventory_ID;
            DAL.ExecuteCommand("ADD_Purchase_Order_Details", param);
            DAL.Close();
        }




        public void Inventory_Transactions(int ID, int Transaction_Type, DateTime Transaction_Created_Date,
            string ID_PRODUCT, int QTE, int Purchase_Order_ID, int ID_ORDER, string Criterion)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[8];
            param[0] = new SqlParameter("@ID", SqlDbType.Int);
            param[0].Value = ID;
            param[1] = new SqlParameter("@Transaction_Type", SqlDbType.Int);
            param[1].Value = Transaction_Type;

            param[2] = new SqlParameter("@Transaction_Created_Date", SqlDbType.DateTime);
            param[2].Value = Transaction_Created_Date;


            param[3] = new SqlParameter("@ID_PRODUCT", SqlDbType.VarChar,30);
            param[3].Value = ID_PRODUCT;

            param[4] = new SqlParameter("@QTE", SqlDbType.Int);
            param[4].Value = QTE;

            param[5] = new SqlParameter("@Purchase_Order_ID", SqlDbType.Int);
            param[5].Value = Purchase_Order_ID;
            param[6] = new SqlParameter("@ID_ORDER", SqlDbType.Int);
            param[6].Value = ID_ORDER;
            param[7] = new SqlParameter("@Criterion", SqlDbType.VarChar,25);
            param[7].Value = Criterion;
           
            DAL.ExecuteCommand("Inventory_Transactions", param);
            DAL.Close();
        }

        public void EDIT_Inventory_Transactions(int ID, int Transaction_Type, DateTime Transaction_Created_Date,
           string ID_PRODUCT, int QTE, int Purchase_Order_ID, int ID_ORDER, string Criterion)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[8];
            param[0] = new SqlParameter("@ID", SqlDbType.Int);
            param[0].Value = ID;
            param[1] = new SqlParameter("@Transaction_Type", SqlDbType.Int);
            param[1].Value = Transaction_Type;

            param[2] = new SqlParameter("@Transaction_Created_Date", SqlDbType.DateTime);
            param[2].Value = Transaction_Created_Date;


            param[3] = new SqlParameter("@ID_PRODUCT", SqlDbType.VarChar,30);
            param[3].Value = ID_PRODUCT;

            param[4] = new SqlParameter("@QTE", SqlDbType.Int);
            param[4].Value = QTE;

            param[5] = new SqlParameter("@Purchase_Order_ID", SqlDbType.Int);
            param[5].Value = Purchase_Order_ID;
            param[6] = new SqlParameter("@ID_ORDER", SqlDbType.Int);
            param[6].Value = ID_ORDER;
            param[7] = new SqlParameter("@Criterion", SqlDbType.VarChar, 25);
            param[7].Value = Criterion;

            DAL.ExecuteCommand("EDIT_Inventory_Transactions", param);
            DAL.Close();
        }

        public DataTable VarifyQty(string ID_PRODUCT, int Qty_Entered)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@ID", SqlDbType.VarChar,30);
            param[0].Value = ID_PRODUCT;
            param[1] = new SqlParameter("@Qty_Entered", SqlDbType.Int);
            param[1].Value = Qty_Entered;
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("VarifyQty", param);
            DAL.Close();
            return Dt;
        }

        public DataTable GetOrderDetails( int ID_ORDER)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ID_ORDER", SqlDbType.Int);
            param[0].Value = ID_ORDER;
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("GetOrderDetails", param);
            DAL.Close();
            return Dt;
       
           
        }
        public DataTable GetOrderDetailsForUpdate(int ID_ORDER)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ID_ORDER", SqlDbType.Int);
            param[0].Value = ID_ORDER;
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("GetOrderDetailsForUpdate", param);
            DAL.Close();
            return Dt;


        }
        public DataTable GET_Transaction_ID(int ID_ORDER)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ID_ORDER", SqlDbType.Int);
            param[0].Value = ID_ORDER;
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("GET_Transaction_ID", param);
            DAL.Close();
            return Dt;


        }
        public DataTable GET_Transaction_ID2(int ID_ORDER)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ID_ORDER", SqlDbType.Int);
            param[0].Value = ID_ORDER;
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("GET_Transaction_ID2", param);
            DAL.Close();
            return Dt;


        }
        public DataTable GetPurchaseOrderDetailsForUpdate(int ID_ORDER)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ID_ORDER", SqlDbType.Int);
            param[0].Value = ID_ORDER;
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("GetPurchase Order DetailsForUpdate", param);
            DAL.Close();
            return Dt;


        }

        public DataTable GetOrderDetailsCADI(int ID_ORDER)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ID_ORDER", SqlDbType.Int);
            param[0].Value = ID_ORDER;
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("GetOrderDetailsCADI", param);
            DAL.Close();
            return Dt;


        }

        public DataTable SearchOrders3(string Criterion)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@Criterion", SqlDbType.NVarChar,50);
            param[0].Value = Criterion;
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("SearchOrders3", param);
            DAL.Close();
            return Dt;


        }
        public DataTable SearchOrders(string Criterion)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@Criterion", SqlDbType.NVarChar, 50);
            param[0].Value = Criterion;
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("SearchOrders", param);
            DAL.Close();
            return Dt;


        }
        public DataTable SearchOrders2(string Criterion)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@Criterion", SqlDbType.NVarChar, 50);
            param[0].Value = Criterion;
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("SearchOrders2", param);
            DAL.Close();
            return Dt;


        }
        public DataTable Search_Purchase_Orders(string Criterion)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@Criterion", SqlDbType.NVarChar, 50);
            param[0].Value = Criterion;
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("Search_Purchase_Orders", param);
            DAL.Close();
            return Dt;


        }

        public void DELETE_Order(int ID)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ID", SqlDbType.Int);
            param[0].Value = ID;
            DAL.ExecuteCommand("DELETE_Order", param);
            DAL.Close();
        }
        public void DELETE_Purchase_Order(int ID)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ID", SqlDbType.Int);
            param[0].Value = ID;
            DAL.ExecuteCommand("DELETE_Purchase_Order", param);
            DAL.Close();
        }
        public DataTable ORDER_TOTAL()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("ORDER_TOTAL", null);
            DAL.Close();
            return Dt;
        }
        public DataTable ITEM_TOTAL()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("ITEM_TOTAL", null);
            DAL.Close();
            return Dt;
        }
        public DataTable PURCHASE_TOTAL()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("PURCHASE_TOTAL", null);
            DAL.Close();
            return Dt;
        }
       
        public DataTable ORDER_TOTAL_TODAY(DateTime Date)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@Date", SqlDbType.DateTime);
            param[0].Value = Date;
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("ORDER_TOTAL_TODAY", param);
            DAL.Close();
            return Dt;


        }

        public DataTable PURCHASE_TOTAL_TODAY(DateTime Date)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@Date", SqlDbType.DateTime);
            param[0].Value = Date;
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("PURCHASE_TOTAL_TODAY", param);
            DAL.Close();
            return Dt;


        }
        public DataTable ITEM_TOTAL_TODAY(DateTime Date)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@Date", SqlDbType.DateTime);
            param[0].Value = Date;
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("ITEM_TOTAL_TODAY", param);
            DAL.Close();
            return Dt;


        }
        public DataTable ORDER_TOTAL_BETWEEN(DateTime Date, DateTime Date1)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@Date", SqlDbType.DateTime);
            param[0].Value = Date;
            param[1] = new SqlParameter("@Date1", SqlDbType.DateTime);
            param[1].Value = Date1;
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("ORDER_TOTAL_BETWEEN", param);
            DAL.Close();
            return Dt;


        }
        public DataTable ITEM_TOTAL_BETWEEN(DateTime Date, DateTime Date1)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@Date", SqlDbType.DateTime);
            param[0].Value = Date;
            param[1] = new SqlParameter("@Date1", SqlDbType.DateTime);
            param[1].Value = Date1;
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("ITEM_TOTAL_BETWEEN", param);
            DAL.Close();
            return Dt;


        }
        public DataTable PURCHASE_TOTAL_BETWEEN(DateTime Date, DateTime Date1)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@Date", SqlDbType.DateTime);
            param[0].Value = Date;
            param[1] = new SqlParameter("@Date1", SqlDbType.DateTime);
            param[1].Value = Date1;
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("PURCHASE_TOTAL_BETWEEN", param);
            DAL.Close();
            return Dt;


        }

        public DataTable GET_CUSTOMER_ID()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("GET_CUSTOMER_ID", null);
            DAL.Close();
            return Dt;
        }
        public DataTable GET_SUPPLIER_ID()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("GET_SUPPLIER_ID", null);
            DAL.Close();
            return Dt;
        }

        public DataTable ORDER_TOTAL_CUSTOMER(int ID)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ID", SqlDbType.Int);
            param[0].Value = ID;
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("ORDER_TOTAL_CUSTOMER", param);
            DAL.Close();
            return Dt;


        }

        public DataTable PURCHASE_TOTAL_SUPPLIER(int ID)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ID", SqlDbType.Int);
            param[0].Value = ID;
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("PURCHASE_TOTAL_SUPPLIER", param);
            DAL.Close();
            return Dt;


        }



    }
}
