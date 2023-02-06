using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

public class ACCESSI
{
    public int chiave;
    public int chiaveDIPENDENTE;
    public string DATAORA;
    public string EVENTO;
    public string DATAINIZIO;
    public string DATAFINE;

    public ACCESSI()
    {

    }

    public void spACCESSI_DeleteAll()
    {
        DATABASE D = new DATABASE();
        D.cmd.CommandText = "spACCESSI_DeleteAll";
        D.EseguiSPNonRead();
    }



    public void spACCESSI_Insert()
    {
        DATABASE D = new DATABASE();
        D.cmd.CommandText = "spACCESSI_Insert";
        D.cmd.Parameters.AddWithValue("chiaveDipendenti", chiaveDIPENDENTE);
        D.cmd.Parameters.AddWithValue("DATAORA", DATAORA);
        D.cmd.Parameters.AddWithValue("EVENTO", EVENTO);
        D.EseguiSPNonRead();
    }

    public DataTable spACCESSI_SelectAll()
    {
        DATABASE D = new DATABASE();
        D.cmd.CommandText = "spACCESSI_SelectAll";
        D.DT = D.EseguiSPRead();
        return D.DT;
    }


    public DataTable spACCESSI_SelectDate_Interval()
    {
        DATABASE D = new DATABASE();
        D.cmd.CommandText = "spACCESSI_SelectDate_Interval";
        D.cmd.Parameters.AddWithValue("DATAINIZIO", DATAINIZIO);
        D.cmd.Parameters.AddWithValue("DATAFINE", DATAFINE);
        D.DT = D.EseguiSPRead();
        return D.DT;
    }
}