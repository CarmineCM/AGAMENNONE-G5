using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

public class EVENTI
{
    public int chiave;
    public int chiaveDIPENDENTE;
    public string DATAORA;
    public string EVENTO;
    public string DATAINIZIO;
    public string DATAFINE;

    public EVENTI()
    {

    }

    public void spEVENTI_DeleteAll()
    {
        DATABASE D = new DATABASE();
        D.cmd.CommandText = "spEVENTI_DeleteAll";
        D.EseguiSPNonRead();
    }

    public void spEVENTI_Insert()
    {
        DATABASE D = new DATABASE();
        D.cmd.CommandText = "spEVENTI_Insert";
        D.cmd.Parameters.AddWithValue("chiaveDipendenti", chiaveDIPENDENTE);
        D.cmd.Parameters.AddWithValue("DATAORA", DATAORA);
        D.cmd.Parameters.AddWithValue("EVENTO", EVENTO);
        D.EseguiSPNonRead();
    }

    public DataTable spEVENTI_SelectAll()
    {
        DATABASE D = new DATABASE();
        D.cmd.CommandText = "spEVENTI_SelectAll";
        D.DT = D.EseguiSPRead();
        return D.DT;
    }

    public DataTable spEVENTI_SelectDate_Interval()
    {
        DATABASE D = new DATABASE();
        D.cmd.CommandText = "spEVENTI_SelectDate_Interval";
        D.cmd.Parameters.AddWithValue("DATAINIZIO", DATAINIZIO);
        D.cmd.Parameters.AddWithValue("DATAFINE", DATAFINE);
        D.DT = D.EseguiSPRead();
        return D.DT;
    }
}