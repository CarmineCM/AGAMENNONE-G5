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
    public int chiave;
    public int chiaveCLIENTE;
    public int chiaveRESPONSABILE;
    public string CORPOORA;
    public string DATAAPERTURA;
    public string DATACHIUSURA;
    public string DATACONSEGNA;
    public string DESCRIZIONE;
    public string IMPORTOCORPO;
    public string IMPORTOORARIO;
    public string ANTICIPO;
    public string PERNOTTAMENTO;
    public string PASTO;
    public string KM;
    public string PEDAGGI;
    public string MEZZI;
    public COMMESSE()
    {

    }

    public void spCOMMESSE_Insert()
    {
        DATABASE D = new DATABASE();
        D.cmd.CommandText = "spCOMMESSE_Insert";
        D.cmd.Parameters.AddWithValue("chiaveCLIENTE", chiaveCLIENTE);
        D.cmd.Parameters.AddWithValue("chiaveRESPONSABILE", chiaveRESPONSABILE);
        D.cmd.Parameters.AddWithValue("CORPOORA", CORPOORA);
        D.cmd.Parameters.AddWithValue("DATAAPERTURA", DATAAPERTURA);
        D.cmd.Parameters.AddWithValue("DATACHIUSURA", DATACHIUSURA);
        D.cmd.Parameters.AddWithValue("DATACONSEGNA", DATACONSEGNA);
        D.cmd.Parameters.AddWithValue("DESCRIZIONE", DESCRIZIONE);
        D.cmd.Parameters.AddWithValue("IMPORTOCORPO", IMPORTOCORPO);
        D.cmd.Parameters.AddWithValue("IMPORTOORARIO", IMPORTOORARIO);
        D.cmd.Parameters.AddWithValue("ANTICIPO", ANTICIPO);
        D.cmd.Parameters.AddWithValue("PERNOTTAMENTO", PERNOTTAMENTO);
        D.cmd.Parameters.AddWithValue("PASTO", PASTO);
        D.cmd.Parameters.AddWithValue("KM", KM);
        D.cmd.Parameters.AddWithValue("PEDAGGI", PEDAGGI);
        D.cmd.Parameters.AddWithValue("MEZZI", MEZZI);
        D.EseguiSPNonRead();
    }

    public DataTable spCOMMESSE_SelectAll()
    {
        DATABASE D = new DATABASE();
        D.cmd.CommandText = "spCOMMESSE_SelectAll";
        D.DT = D.EseguiSPRead();
        return D.DT;
    }

    public DataTable spCOMMESSE_SelectAll_DDL_Cliente()
    {
        DATABASE D = new DATABASE();
        D.cmd.CommandText = "spCOMMESSE_SelectAll_DDL_Cliente";
        D.DT = D.EseguiSPRead();
        return D.DT;
    }

    public DataTable spCOMMESSE_SelectAll_DDL_CorpoOra()
    {
        DATABASE D = new DATABASE();
        D.cmd.CommandText = "spCOMMESSE_SelectAll_DDL_CorpoOra";
        D.DT = D.EseguiSPRead();
        return D.DT;
    }

    public DataTable spCOMMESSE_SelectAll_DDL_Responsabile()
    {
        DATABASE D = new DATABASE();
        D.cmd.CommandText = "spCOMMESSE_SelectAll_DDL_Responsabile";
        D.DT = D.EseguiSPRead();
        return D.DT;
    }

    public DataTable spCOMMESSE_SelectByKey()
    {
        DATABASE D = new DATABASE();
        D.cmd.CommandText = "spCOMMESSE_SelectBykey";
        D.DT = D.EseguiSPRead();
        return D.DT;
    }

    public DataTable spACCESSI_SelectDate_Interval()
    {
        DATABASE D = new DATABASE();
        D.cmd.CommandText = "spACCESSI_SelectDate_Interval";
        D.cmd.Parameters.AddWithValue("DATAAPERTURA", DATAAPERTURA);
        D.cmd.Parameters.AddWithValue("DATACHIUSURA", DATACHIUSURA);
        D.DT = D.EseguiSPRead();
        return D.DT;
    }

    public void spCOMMESSE_Update()
    {
        DATABASE D = new DATABASE();
        D.cmd.CommandText = "spCOMMESSE_Update";
        D.cmd.Parameters.AddWithValue("chiave", chiave);
        D.cmd.Parameters.AddWithValue("chiaveCLIENTE", chiaveCLIENTE);
        D.cmd.Parameters.AddWithValue("chiaveRESPONSABILE", chiaveRESPONSABILE);
        D.cmd.Parameters.AddWithValue("CORPOORA", CORPOORA);
        D.cmd.Parameters.AddWithValue("DATAAPERTURA", DATAAPERTURA);
        D.cmd.Parameters.AddWithValue("DATACHIUSURA", DATACHIUSURA);
        D.cmd.Parameters.AddWithValue("DATACONSEGNA", DATACONSEGNA);
        D.cmd.Parameters.AddWithValue("DESCRIZIONE", DESCRIZIONE);
        D.cmd.Parameters.AddWithValue("IMPORTOCORPO", IMPORTOCORPO);
        D.cmd.Parameters.AddWithValue("IMPORTOORARIO", IMPORTOORARIO);
        D.cmd.Parameters.AddWithValue("ANTICIPO", ANTICIPO);
        D.cmd.Parameters.AddWithValue("PERNOTTAMENTO", PERNOTTAMENTO);
        D.cmd.Parameters.AddWithValue("PASTO", PASTO);
        D.cmd.Parameters.AddWithValue("KM", KM);
        D.cmd.Parameters.AddWithValue("PEDAGGI", PEDAGGI);
        D.cmd.Parameters.AddWithValue("MEZZI", MEZZI);
        D.EseguiSPNonRead();
    }

}