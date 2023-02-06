using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;

public class REFERENTI
{
    public int chiave;
    public int chiaveCLIENTE;
    public string COGNOME;
    public string NOME;
    public string EMAIL;
    public string TELEFONO;

    public REFERENTI()
    {
    
    }

    public void spREFERENTI_Insert()
    {
        DATABASE D = new DATABASE();
        D.cmd.CommandText = "spREFERENTI_Insert";
        D.cmd.Parameters.AddWithValue("chiaveCLIENTE", chiaveCLIENTE);
        D.cmd.Parameters.AddWithValue("COGNOME", COGNOME);
        D.cmd.Parameters.AddWithValue("NOME", NOME);
        D.cmd.Parameters.AddWithValue("EMAIL", EMAIL);
        D.cmd.Parameters.AddWithValue("TELEFONO", TELEFONO);
        D.EseguiSPNonRead();
    }

    public DataTable spREFERENTI_SelectAll()
    {
        DATABASE D = new DATABASE();
        D.cmd.CommandText = "spREFERENTI_SelectAll";
        D.DT = D.EseguiSPRead();
        return D.DT;
    }

    public DataTable spREFERENTI_SelectAll_DDL()
    {
        DATABASE D = new DATABASE();
        D.cmd.CommandText = "spREFERENTI_SelectAll_DDL";
        D.DT = D.EseguiSPRead();
        return D.DT;
    }

    public DataTable spREFERENTI_SelectByKey()
    {
        DATABASE D = new DATABASE();
        D.cmd.CommandText = "spREFERENTI_SelectBykey";
        D.DT = D.EseguiSPRead();
        return D.DT;
    }

    public void spREFERENTI_Update()
    {
        DATABASE D = new DATABASE();
        D.cmd.CommandText = "spREFERENTI_Update";
        D.cmd.Parameters.AddWithValue("chiave", chiave);
        D.cmd.Parameters.AddWithValue("COGNOME", COGNOME);
        D.cmd.Parameters.AddWithValue("NOME", NOME);
        D.cmd.Parameters.AddWithValue("EMAIL", EMAIL);
        D.cmd.Parameters.AddWithValue("TELEFONO", TELEFONO);
        D.EseguiSPNonRead();
    }
}