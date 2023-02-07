using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public class DATABASE
{
    public  SqlConnection conn = new SqlConnection();
    public  SqlCommand cmd = new SqlCommand();
    public  SqlDataAdapter DA = new SqlDataAdapter();
    public  DataTable DT = new DataTable();

    static void GetConnectionStrings()
    {
        ConnectionStringSettingsCollection settings = ConfigurationManager.ConnectionStrings;
    }

    public  DATABASE()
    {
        GetConnectionStrings();
    }

    public void EseguiSPNonRead()
    {
        cmd.CommandType = CommandType.StoredProcedure;
        conn.Open();
        cmd.ExecuteNonQuery();
        conn.Close();
    }

    public DataTable EseguiSPRead()
    {
        cmd.CommandType = CommandType.StoredProcedure;
        DA.SelectCommand = cmd;
        DA.Fill(DT);
        return DT;
    }
}