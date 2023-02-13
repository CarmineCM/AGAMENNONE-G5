using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Diagnostics;


public class COMMESSE
{
    public static string chiave;
    public static int chiaveCLIENTE;
    public static int chiaveRESPONSABILE;
    public static string CORPOORA;
    public static string DATAAPERTURA;
    public static string DATACHIUSURA;
    public static string DATACONSEGNA;
    public static string DESCRIZIONE;
    public static string IMPORTOCORPO;
    public static string IMPORTOORARIO;
    public static string ANTICIPO;
    public static string PERNOTTAMENTO;
    public static string PASTO;
    public static string KM;
    public static string PEDAGGI;
    public static string MEZZI;

    public static void spCOMMESSE_Insert()
    {
        DATABASE.cmd.CommandText = "spCOMMESSE_Insert";
        DATABASE.cmd.Parameters.AddWithValue("chiaveCLIENTE", chiaveCLIENTE);
        DATABASE.cmd.Parameters.AddWithValue("chiaveRESPONSABILE", chiaveRESPONSABILE);
        DATABASE.cmd.Parameters.AddWithValue("CORPOORA", CORPOORA);
        DATABASE.cmd.Parameters.AddWithValue("DATAAPERTURA", DATAAPERTURA);
        DATABASE.cmd.Parameters.AddWithValue("DATACHIUSURA", DATACHIUSURA);
        DATABASE.cmd.Parameters.AddWithValue("DATACONSEGNA", DATACONSEGNA);
        DATABASE.cmd.Parameters.AddWithValue("DESCRIZIONE", DESCRIZIONE);
        DATABASE.cmd.Parameters.AddWithValue("IMPORTOCORPO", IMPORTOCORPO);
        DATABASE.cmd.Parameters.AddWithValue("IMPORTOORARIO", IMPORTOORARIO);
        DATABASE.cmd.Parameters.AddWithValue("ANTICIPO", ANTICIPO);
        DATABASE.cmd.Parameters.AddWithValue("PERNOTTAMENTO", PERNOTTAMENTO);
        DATABASE.cmd.Parameters.AddWithValue("PASTO", PASTO);
        DATABASE.cmd.Parameters.AddWithValue("KM", KM);
        DATABASE.cmd.Parameters.AddWithValue("PEDAGGI", PEDAGGI);
        DATABASE.cmd.Parameters.AddWithValue("MEZZI", MEZZI);
        DATABASE.EseguiSPNonRead();
    }

    public static DataTable spCOMMESSE_SelectAll()
    {
        DATABASE.cmd.CommandText = "spCOMMESSE_SelectAll";
        DATABASE.DT = DATABASE.EseguiSPRead();
        return DATABASE.DT;
    }

    public static DataTable spCOMMESSE_SelectAll_DDL_Cliente()
    {
        DATABASE.cmd.CommandText = "spCOMMESSE_SelectAll_DDL_Cliente";
        DATABASE.DT = DATABASE.EseguiSPRead();
        return DATABASE.DT;
    }

    public static DataTable spCOMMESSE_SelectAll_DDL_CorpoOra()
    {
        DATABASE.cmd.CommandText = "spCOMMESSE_SelectAll_DDL_CorpoOra";
        DATABASE.DT = DATABASE.EseguiSPRead();
        return DATABASE.DT;
    }

    public static DataTable spCOMMESSE_SelectAll_DDL_Responsabile()
    {
        DATABASE.cmd.CommandText = "spCOMMESSE_SelectAll_DDL_Responsabile";
        DATABASE.DT = DATABASE.EseguiSPRead();
        return DATABASE.DT;
    }

    public static DataTable spCOMMESSE_SelectByKey()
    {
        DATABASE.cmd.CommandText = "spCOMMESSE_SelectBykey";
        DATABASE.DT = DATABASE.EseguiSPRead();
        return DATABASE.DT;
    }

    public static DataTable spACCESSI_SelectDate_Interval()
    {
        DATABASE.cmd.CommandText = "spACCESSI_SelectDate_Interval";
        DATABASE.cmd.Parameters.AddWithValue("DATAAPERTURA", DATAAPERTURA);
        DATABASE.cmd.Parameters.AddWithValue("DATACHIUSURA", DATACHIUSURA);
        DATABASE.DT = DATABASE.EseguiSPRead();
        return DATABASE.DT;
    }

    public static void spCOMMESSE_Update()
    {
        DATABASE.cmd.CommandText = "spCOMMESSE_Update";
        DATABASE.cmd.Parameters.AddWithValue("chiave", chiave);
        DATABASE.cmd.Parameters.AddWithValue("chiaveCLIENTE", chiaveCLIENTE);
        DATABASE.cmd.Parameters.AddWithValue("chiaveRESPONSABILE", chiaveRESPONSABILE);
        DATABASE.cmd.Parameters.AddWithValue("CORPOORA", CORPOORA);
        DATABASE.cmd.Parameters.AddWithValue("DATAAPERTURA", DATAAPERTURA);
        DATABASE.cmd.Parameters.AddWithValue("DATACHIUSURA", DATACHIUSURA);
        DATABASE.cmd.Parameters.AddWithValue("DATACONSEGNA", DATACONSEGNA);
        DATABASE.cmd.Parameters.AddWithValue("DESCRIZIONE", DESCRIZIONE);
        DATABASE.cmd.Parameters.AddWithValue("IMPORTOCORPO", IMPORTOCORPO);
        DATABASE.cmd.Parameters.AddWithValue("IMPORTOORARIO", IMPORTOORARIO);
        DATABASE.cmd.Parameters.AddWithValue("ANTICIPO", ANTICIPO);
        DATABASE.cmd.Parameters.AddWithValue("PERNOTTAMENTO", PERNOTTAMENTO);
        DATABASE.cmd.Parameters.AddWithValue("PASTO", PASTO);
        DATABASE.cmd.Parameters.AddWithValue("KM", KM);
        DATABASE.cmd.Parameters.AddWithValue("PEDAGGI", PEDAGGI);
        DATABASE.cmd.Parameters.AddWithValue("MEZZI", MEZZI);
        DATABASE.EseguiSPNonRead();
    }

}