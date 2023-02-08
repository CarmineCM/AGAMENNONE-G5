using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

public class EVENTI
{
    public static int chiave;
    public static int chiaveDIPENDENTE;
    public static string DATAORA;
    public static string EVENTO;
    public static string DATAINIZIO;
    public static string DATAFINE;

    public static void spEVENTI_DeleteAll()
    {
        DATABASE.cmd.CommandText = "spEVENTI_DeleteAll";
        DATABASE.EseguiSPNonRead();
    }

    public static void spEVENTI_Insert()
    {
        DATABASE.cmd.CommandText = "spEVENTI_Insert";
        DATABASE.cmd.Parameters.AddWithValue("chiaveDipendenti", chiaveDIPENDENTE);
        DATABASE.cmd.Parameters.AddWithValue("DATAORA", DATAORA);
        DATABASE.cmd.Parameters.AddWithValue("EVENTO", EVENTO);
        DATABASE.EseguiSPNonRead();
    }

    public static DataTable spEVENTI_SelectAll()
    {
        DATABASE.cmd.CommandText = "spEVENTI_SelectAll";
        DATABASE.DT = DATABASE.EseguiSPRead();
        return DATABASE.DT;
    }

    public static DataTable spEVENTI_SelectDate_Interval()
    {
        DATABASE.cmd.CommandText = "spEVENTI_SelectDate_Interval";
        DATABASE.cmd.Parameters.AddWithValue("DATAINIZIO", DATAINIZIO);
        DATABASE.cmd.Parameters.AddWithValue("DATAFINE", DATAFINE);
        DATABASE.DT = DATABASE.EseguiSPRead();
        return DATABASE.DT;
    }
}