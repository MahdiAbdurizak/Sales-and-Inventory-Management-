using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Data.OleDb;
namespace products_Management.DAL
{
class DataAccessLayer
{
    SqlConnection sqlconn;
    public DataAccessLayer()
    {
        string mode = Properties.Settings.Default.Mode;
        if (mode == "SQL")
        {
            sqlconn = new SqlConnection(@"Server=" + Properties.Settings.Default.Server + ";Database=" + 
                Properties.Settings.Default.Database + "; Integrated Security=false; User ID=" +
                Properties.Settings.Default.ID + ";Password =" + Properties.Settings.Default.Password +"");
        }
        else
        {

            sqlconn = new SqlConnection(@"Server=" + Properties.Settings.Default.Server + ";Database=" + Properties.Settings.Default.Database + "; Integrated Security=true");
        }
    }

    public void Open()
    {
        if (sqlconn.State != ConnectionState.Open)
        {
            sqlconn.Open();

        }

    }

    public void Close()
    {
        if (sqlconn.State == ConnectionState.Open)
        {
            sqlconn.Close();

        }


    }

    // Method To Read Data From Database

    public DataTable SelectData(string stored_prcedure, SqlParameter[] param)
    {
        SqlCommand sqlcmd = new SqlCommand();
        sqlcmd.CommandType = CommandType.StoredProcedure;
        sqlcmd.CommandText = stored_prcedure;
        sqlcmd.Connection = sqlconn;

        if (param !=null)
        {    
            for(int i=0;i<param.Length;i++)
            {sqlcmd.Parameters.Add(param[i]);
            }
        }

      SqlDataAdapter da=new SqlDataAdapter(sqlcmd);
      DataTable dt=new DataTable();
        da.Fill(dt);
        return dt;

 

    }

    // Method To Inser,Update And Delate Data From Database

    public void ExecuteCommand(string stored_prcedure, SqlParameter[] param)
    {
          SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.CommandText = stored_prcedure;
            sqlcmd.Connection = sqlconn;

            if (param != null)
            {
                sqlcmd.Parameters.AddRange(param);
            }

            sqlcmd.ExecuteNonQuery();
        
       



        }
    

}
}
