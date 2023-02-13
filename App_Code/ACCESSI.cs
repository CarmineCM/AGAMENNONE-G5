using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

public class ACCESSI
{
    public static string chiave;
    public static string chiaveDIPENDENTE;
    public static string DATAORA;
    public static string EVENTO;
    public static string DATAINIZIO;
    public static string DATAFINE;


    public static void spACCESSI_DeleteAll()
    {
        DATABASE.cmd.CommandText = "spACCESSI_DeleteAll";
        DATABASE.EseguiSPNonRead();
    }



    public static void spACCESSI_Insert()
    {
        DATABASE.cmd.Parameters.Clear();
        DATABASE.cmd.CommandText = "spACCESSI_Insert";
        DATABASE.cmd.Parameters.AddWithValue("chiaveDIPENDENTE", chiaveDIPENDENTE);
        DATABASE.cmd.Parameters.AddWithValue("DATAORA", DATAORA);
        DATABASE.cmd.Parameters.AddWithValue("EVENTO", EVENTO);
        DATABASE.EseguiSPNonRead();
    }

    public static DataTable spACCESSI_SelectAll()
    {
        DATABASE.cmd.CommandText = "spACCESSI_SelectAll";
        DATABASE.DT = DATABASE.EseguiSPRead();
        return DATABASE.DT;
    }


    public static DataTable spACCESSI_SelectDate_Interval()
    {
        DATABASE.cmd.CommandText = "spACCESSI_SelectDate_Interval";
        DATABASE.cmd.Parameters.AddWithValue("DATAINIZIO", DATAINIZIO);
        DATABASE.cmd.Parameters.AddWithValue("DATAFINE", DATAFINE);
        DATABASE.DT = DATABASE.EseguiSPRead();
        return DATABASE.DT;
    }
}