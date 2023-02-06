using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;

public class LAVORI
{
    public int chiave;
    public int chiaveCOMMESSA;
    public int chiaveDIPENDENTE;
    public string DATAORA;
    public string ORE;
    public string DESCRIZIONE;
    public string PERNOTTAMENTO;
    public string PASTO;
    public string KM;
    public string PEDAGGI;
    public string MEZZI;
    public string SPESEEXTRA;
    public string DESCRIZIONESPESEEXTRA;
    public string ACCETTAZIONESPESE;

    public LAVORI()
    {
     
    }

    public void spLAVORI_Accetta()
    {
        DATABASE D = new DATABASE();
        D.cmd.CommandText = "spLAVORI_Accetta";
        D.cmd.Parameters.AddWithValue("chiave",chiave);
    }

    public void spLAVORI_Insert()
    {
        DATABASE D = new DATABASE();
        D.cmd.CommandText = "spLAVORI_Insert";
        D.cmd.Parameters.AddWithValue("chiaveCOMMESSA", chiaveCOMMESSA);
        D.cmd.Parameters.AddWithValue("chiaveDIPENDENTE", chiaveDIPENDENTE);
        D.cmd.Parameters.AddWithValue("DATAORA", DATAORA);
        D.cmd.Parameters.AddWithValue("ORE", ORE);
        D.cmd.Parameters.AddWithValue("DESCRIZIONE", DESCRIZIONE);
        D.cmd.Parameters.AddWithValue("PERNOTTAMENTO", PERNOTTAMENTO);
        D.cmd.Parameters.AddWithValue("PASTO", PASTO);
        D.cmd.Parameters.AddWithValue("KM", KM);
        D.cmd.Parameters.AddWithValue("PEDAGGI", PEDAGGI);
        D.cmd.Parameters.AddWithValue("MEZZI", MEZZI);
        D.cmd.Parameters.AddWithValue("SPESEEXTRA", SPESEEXTRA);
        D.cmd.Parameters.AddWithValue("DESCRIZIONESPESEEXTRA", DESCRIZIONESPESEEXTRA);
        D.cmd.Parameters.AddWithValue("ACCETTAZIONESPESE", ACCETTAZIONESPESE);
        D.EseguiSPNonRead();
    }

    public DataTable spLAVORI_SelectAll()
    {
        DATABASE D = new DATABASE();
        D.cmd.CommandText = "spLAVORI_SelectAll";
        D.DT = D.EseguiSPRead();
        return D.DT;
    }

    public DataTable spLAVORI_SelectByAccettazioneSpese()
    {
        DATABASE D = new DATABASE();
        D.cmd.CommandText = "spLAVORI_SelectByAccettazioneSpese";
        D.cmd.Parameters.AddWithValue("ACCETTAZIONESPESE", ACCETTAZIONESPESE);
        D.DT = D.EseguiSPRead();
        return D.DT;
    }
        
    public DataTable spLAVORI_SelectByCommessa()
    {
        DATABASE D = new DATABASE();
        D.cmd.CommandText = "spLAVORI_SelectByCommessa";
        D.cmd.Parameters.AddWithValue("chiaveCOMMESSA", chiaveCOMMESSA);
        D.DT = D.EseguiSPRead();
        return D.DT;
    }

    public DataTable spLAVORI_SelectByDipendenti_DDL()
    {
        DATABASE D = new DATABASE();
        D.cmd.CommandText = "spLAVORI_SelectByDipendenti_DDL";
        D.cmd.Parameters.AddWithValue("chiaveDIPENDENTE", chiaveDIPENDENTE);
        D.DT = D.EseguiSPRead();
        return D.DT;
    }

    public DataTable spLAVORI_SelectByKey()
    {
        DATABASE D = new DATABASE();
        D.cmd.CommandText = "spLAVORI_SelectBykey";
        D.DT = D.EseguiSPRead();
        return D.DT;
    }

    public void spLAVORI_Update()
    {
        DATABASE D = new DATABASE();
        D.cmd.CommandText = "spLAVORI_Update";
        D.cmd.Parameters.AddWithValue("chiave", chiave);
        D.cmd.Parameters.AddWithValue("chiaveCOMMESSA", chiaveCOMMESSA);
        D.cmd.Parameters.AddWithValue("chiaveDIPENDENTE", chiaveDIPENDENTE);
        D.cmd.Parameters.AddWithValue("DATAORA", DATAORA);
        D.cmd.Parameters.AddWithValue("ORE", ORE);
        D.cmd.Parameters.AddWithValue("DESCRIZIONE", DESCRIZIONE);
        D.cmd.Parameters.AddWithValue("PERNOTTAMENTO", PERNOTTAMENTO);
        D.cmd.Parameters.AddWithValue("PASTO", PASTO);
        D.cmd.Parameters.AddWithValue("KM", KM);
        D.cmd.Parameters.AddWithValue("PEDAGGI", PEDAGGI);
        D.cmd.Parameters.AddWithValue("MEZZI", MEZZI);
        D.cmd.Parameters.AddWithValue("SPESEEXTRA", SPESEEXTRA);
        D.cmd.Parameters.AddWithValue("DESCRIZIONESPESEEXTRA", DESCRIZIONESPESEEXTRA);
        D.cmd.Parameters.AddWithValue("ACCETTAZIONESPESE", ACCETTAZIONESPESE);
        D.EseguiSPNonRead();
    }
}