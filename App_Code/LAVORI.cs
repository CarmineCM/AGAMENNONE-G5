using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;

public class LAVORI
{
    public static int chiave;
    public static int chiaveCOMMESSA;
    public static int chiaveDIPENDENTE;
    public static string DATAORA;
    public static string ORE;
    public static string DESCRIZIONE;
    public static string PERNOTTAMENTO;
    public static string PASTO;
    public static string KM;
    public static string PEDAGGI;
    public static string MEZZI;
    public static string SPESEEXTRA;
    public static string DESCRIZIONESPESEEXTRA;
    public static string ACCETTAZIONESPESE;


    public static void spLAVORI_Accetta()
    {
        DATABASE.cmd.CommandText = "spLAVORI_Accetta";
        DATABASE.cmd.Parameters.AddWithValue("chiave",chiave);
    }

    public static void spLAVORI_Insert()
    {
        DATABASE.cmd.CommandText = "spLAVORI_Insert";
        DATABASE.cmd.Parameters.AddWithValue("chiaveCOMMESSA", chiaveCOMMESSA);
        DATABASE.cmd.Parameters.AddWithValue("chiaveDIPENDENTE", chiaveDIPENDENTE);
        DATABASE.cmd.Parameters.AddWithValue("DATAORA", DATAORA);
        DATABASE.cmd.Parameters.AddWithValue("ORE", ORE);
        DATABASE.cmd.Parameters.AddWithValue("DESCRIZIONE", DESCRIZIONE);
        DATABASE.cmd.Parameters.AddWithValue("PERNOTTAMENTO", PERNOTTAMENTO);
        DATABASE.cmd.Parameters.AddWithValue("PASTO", PASTO);
        DATABASE.cmd.Parameters.AddWithValue("KM", KM);
        DATABASE.cmd.Parameters.AddWithValue("PEDAGGI", PEDAGGI);
        DATABASE.cmd.Parameters.AddWithValue("MEZZI", MEZZI);
        DATABASE.cmd.Parameters.AddWithValue("SPESEEXTRA", SPESEEXTRA);
        DATABASE.cmd.Parameters.AddWithValue("DESCRIZIONESPESEEXTRA", DESCRIZIONESPESEEXTRA);
        DATABASE.cmd.Parameters.AddWithValue("ACCETTAZIONESPESE", ACCETTAZIONESPESE);
        DATABASE.EseguiSPNonRead();
    }

    public static DataTable spLAVORI_SelectAll()
    {
        DATABASE.cmd.CommandText = "spLAVORI_SelectAll";
        DATABASE.DT = DATABASE.EseguiSPRead();
        return DATABASE.DT;
    }

    public static DataTable spLAVORI_SelectByAccettazioneSpese()
    {
        DATABASE.cmd.CommandText = "spLAVORI_SelectByAccettazioneSpese";
        DATABASE.cmd.Parameters.AddWithValue("ACCETTAZIONESPESE", ACCETTAZIONESPESE);
        DATABASE.DT = DATABASE.EseguiSPRead();
        return DATABASE.DT;
    }
        
    public static DataTable spLAVORI_SelectByCommessa()
    {
        DATABASE.cmd.CommandText = "spLAVORI_SelectByCommessa";
        DATABASE.cmd.Parameters.AddWithValue("chiaveCOMMESSA", chiaveCOMMESSA);
        DATABASE.DT = DATABASE.EseguiSPRead();
        return DATABASE.DT;
    }

    public static DataTable spLAVORI_SelectByDipendenti_DDL()
    {
        DATABASE.cmd.CommandText = "spLAVORI_SelectByDipendenti_DDL";
        DATABASE.cmd.Parameters.AddWithValue("chiaveDIPENDENTE", chiaveDIPENDENTE);
        DATABASE.DT = DATABASE.EseguiSPRead();
        return DATABASE.DT;
    }

    public static DataTable spLAVORI_SelectByKey()
    {
        DATABASE.cmd.CommandText = "spLAVORI_SelectBykey";
        DATABASE.DT = DATABASE.EseguiSPRead();
        return DATABASE.DT;
    }

    public static void spLAVORI_Update()
    {
        DATABASE.cmd.CommandText = "spLAVORI_Update";
        DATABASE.cmd.Parameters.AddWithValue("chiave", chiave);
        DATABASE.cmd.Parameters.AddWithValue("chiaveCOMMESSA", chiaveCOMMESSA);
        DATABASE.cmd.Parameters.AddWithValue("chiaveDIPENDENTE", chiaveDIPENDENTE);
        DATABASE.cmd.Parameters.AddWithValue("DATAORA", DATAORA);
        DATABASE.cmd.Parameters.AddWithValue("ORE", ORE);
        DATABASE.cmd.Parameters.AddWithValue("DESCRIZIONE", DESCRIZIONE);
        DATABASE.cmd.Parameters.AddWithValue("PERNOTTAMENTO", PERNOTTAMENTO);
        DATABASE.cmd.Parameters.AddWithValue("PASTO", PASTO);
        DATABASE.cmd.Parameters.AddWithValue("KM", KM);
        DATABASE.cmd.Parameters.AddWithValue("PEDAGGI", PEDAGGI);
        DATABASE.cmd.Parameters.AddWithValue("MEZZI", MEZZI);
        DATABASE.cmd.Parameters.AddWithValue("SPESEEXTRA", SPESEEXTRA);
        DATABASE.cmd.Parameters.AddWithValue("DESCRIZIONESPESEEXTRA", DESCRIZIONESPESEEXTRA);
        DATABASE.cmd.Parameters.AddWithValue("ACCETTAZIONESPESE", ACCETTAZIONESPESE);
        DATABASE.EseguiSPNonRead();
    }
}