using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;

public class FATTURE
{
    public int chiave;
    public int chiaveCOMMESSA;
    public string NUMEROFATTURA;
    public string DATAFATTURA;
    public string IMPORTO;
    public string ALIQUOTA;
    public string DESCRIZIONE;
    public string DATASALDO;
    public string DATAINIZIO;
    public string DATAFINE;

    public FATTURE()
    {
 
    }

    public void spFATTURE_Insert()
    {
        DATABASE D = new DATABASE();
        D.cmd.CommandText = "spFATTURE_Insert";
        D.cmd.Parameters.AddWithValue("chiaveCOMMESSA", chiaveCOMMESSA);
        D.cmd.Parameters.AddWithValue("NUMEROFATTURA", NUMEROFATTURA);
        D.cmd.Parameters.AddWithValue("DATAFATTURA", DATAFATTURA);
        D.cmd.Parameters.AddWithValue("IMPORTO", IMPORTO);
        D.cmd.Parameters.AddWithValue("ALIQUOTA", ALIQUOTA);
        D.cmd.Parameters.AddWithValue("DESCRIZIONE", DESCRIZIONE);
        D.cmd.Parameters.AddWithValue("DATASALDO", DATASALDO);
        D.EseguiSPNonRead();
    }

    public void spFATTURE_SelectAll()
    {
        DATABASE D = new DATABASE();
        D.cmd.CommandText = "spFATTURE_SelectAll";
        D.DT = D.EseguiSPRead();
    }

    public DataTable spFATTURE_ByDataSaldo()
    {
        DATABASE D = new DATABASE();
        D.cmd.CommandText = "spFATTURE_ByDataSaldo";
        D.cmd.Parameters.AddWithValue("DATASALDO", DATASALDO);
        return D.DT;
    }

    public DataTable spFATTURE_SelectByKey()
    {
        DATABASE D = new DATABASE();
        D.cmd.CommandText = "spFATTURE_SelectBykey";
        D.DT = D.EseguiSPRead();
        return D.DT;
    }

    public DataTable spFATTURE_ByMonth()
    {
        DATABASE D = new DATABASE();
        D.cmd.CommandText = "spFATTURE_ByMonth";
        D.cmd.Parameters.AddWithValue("DATAFATTURE", DATAFATTURA);
        return D.DT;
    }

    public DataTable spFATTURE_ByYear()
    {
        DATABASE D = new DATABASE();
        D.cmd.CommandText = "spFATTURE_ByMonth";
        D.cmd.Parameters.AddWithValue("DATAFATTURE", DATAFATTURA);
        return D.DT;
    }

    public DataTable spFATTURE_SelectDate_Interval()
    {
        DATABASE D = new DATABASE();
        D.cmd.CommandText = "spFATTURE_SelectDate_Interval";
        D.cmd.Parameters.AddWithValue("DATAINIZIO", DATAINIZIO);
        D.cmd.Parameters.AddWithValue("DATAFINE", DATAFINE);
        D.DT = D.EseguiSPRead();
        return D.DT;
    }
}