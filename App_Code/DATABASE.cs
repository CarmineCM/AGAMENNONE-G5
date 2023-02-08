using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Xml.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Cryptography.X509Certificates;

public class DATABASE
{
    static SqlConnection conn = new SqlConnection();
    public static SqlCommand cmd = new SqlCommand();
    static SqlDataAdapter DA = new SqlDataAdapter();
    public static DataTable DT = new DataTable();

    //con il codice in basso riesce a reperire la connectionString e a connettersi, ma non chiude mai la connessione finché non si spegne il server

    static DATABASE()
    {
        conn.ConnectionString = ConfigurationManager.ConnectionStrings["AGAMENNONEConnectionString"].ConnectionString;
        cmd.Connection = conn;
    }

    //seleziona query
    public static void EseguiSPNonRead()
    {
        cmd.CommandType = CommandType.StoredProcedure;
        conn.Open();
        cmd.ExecuteNonQuery();
        conn.Close();
    }

    public static DataTable EseguiSPRead()
    {
        cmd.CommandType = CommandType.StoredProcedure;
        DA.SelectCommand = cmd;
        DA.Fill(DT);
        return DT;
    }
}