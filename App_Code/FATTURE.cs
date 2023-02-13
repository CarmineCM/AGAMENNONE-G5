using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;

public class FATTURE
{
    public static int chiave;
    public static string chiaveCOMMESSA;
    public static string NUMEROFATTURA;
    public static string DATAFATTURA;
    public static string IMPORTO;
    public static string ALIQUOTA;
    public static string DESCRIZIONE;
    public static string DATASALDO;
    public static string DATAINIZIO;
    public static string DATAFINE;

    public static void spFATTURE_Insert()
    {
        DATABASE.cmd.Parameters.Clear();
        DATABASE.cmd.CommandText = "spFATTURE_Insert";
        DATABASE.cmd.Parameters.AddWithValue("chiaveCOMMESSA", chiaveCOMMESSA);
        DATABASE.cmd.Parameters.AddWithValue("NUMEROFATTURA", NUMEROFATTURA);
        DATABASE.cmd.Parameters.AddWithValue("DATAFATTURA", DATAFATTURA);
        DATABASE.cmd.Parameters.AddWithValue("IMPORTO", IMPORTO);
        DATABASE.cmd.Parameters.AddWithValue("ALIQUOTA", ALIQUOTA);
        DATABASE.cmd.Parameters.AddWithValue("DESCRIZIONE", DESCRIZIONE);
        DATABASE.cmd.Parameters.AddWithValue("DATASALDO", DATASALDO);
        DATABASE.EseguiSPNonRead();
    }

    public static void spFATTURE_SelectAll()
    {
        DATABASE.cmd.CommandText = "spFATTURE_SelectAll";
        DATABASE.DT = DATABASE.EseguiSPRead();
    }

    public static DataTable spFATTURE_ByDataSaldo()
    {
        DATABASE.cmd.CommandText = "spFATTURE_ByDataSaldo";
        DATABASE.cmd.Parameters.AddWithValue("DATASALDO", DATASALDO);
        return DATABASE.DT;
    }

    public static DataTable spFATTURE_SelectByKey()
    {
        DATABASE.cmd.CommandText = "spFATTURE_SelectBykey";
        DATABASE.DT = DATABASE.EseguiSPRead();
        return DATABASE.DT;
    }

    public static DataTable spFATTURE_ByMonth()
    {
        DATABASE.cmd.CommandText = "spFATTURE_ByMonth";
        DATABASE.cmd.Parameters.AddWithValue("DATAFATTURE", DATAFATTURA);
        return DATABASE.DT;
    }

    public static DataTable spFATTURE_ByYear()
    {
        DATABASE.cmd.CommandText = "spFATTURE_ByMonth";
        DATABASE.cmd.Parameters.AddWithValue("DATAFATTURE", DATAFATTURA);
        return DATABASE.DT;
    }

    public static DataTable spFATTURE_SelectDate_Interval()
    {
        DATABASE.cmd.CommandText = "spFATTURE_SelectDate_Interval";
        DATABASE.cmd.Parameters.AddWithValue("DATAINIZIO", DATAINIZIO);
        DATABASE.cmd.Parameters.AddWithValue("DATAFINE", DATAFINE);
        DATABASE.DT = DATABASE.EseguiSPRead();
        return DATABASE.DT;
    }
}