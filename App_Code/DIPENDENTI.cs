using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using Microsoft.SqlServer.Server;
using System.Drawing;

public class DIPENDENTI
{
    public int chiave;
    public int chiaveAZIENDA;
    public string EMAIL;
    public string PWD;
    public string ABILITATO;
    public string PRIMOACCESSO;
    public string RUOLO;
    public string COGNOME;
    public string NOME;
    public string INDIRIZZO;
    public string CITTA;
    public string CAP;
    public string PROVINCIA;
    public string TELEFONO;
    public string COSTOORARIO;
    public string DATAINIZIORAPPORTO;
    public string DATAFINERAPPORTO;
   
    public DIPENDENTI()
    {
  
    }

    public void spDIPENDENTI_Abilita()
    {
        DATABASE D = new DATABASE();
        D.cmd.CommandText = "spDIPENDENTI_Abilita";
        D.cmd.Parameters.AddWithValue("chiave", chiave);
        D.EseguiSPNonRead();
    }

    public void spDIPENDENTI_CambiaPassword()
    {
        DATABASE D = new DATABASE();
        D.cmd.CommandText = "spDIPENDENTI_CambiaPassword";
        D.cmd.Parameters.AddWithValue("PWD", PWD);
        D.EseguiSPNonRead();
    }

    public void spDIPENDENTI_Disabilita()
    {
        DATABASE D = new DATABASE();
        D.cmd.CommandText = "spDIPENDENTI_Disabilita";
        D.cmd.Parameters.AddWithValue("chiave", chiave);
        D.EseguiSPNonRead();
    }

    public void spDIPENDENTI_Insert()
    {
        DATABASE D = new DATABASE();
        D.cmd.CommandText = "spDIPENDENTI_Insert";
        D.cmd.Parameters.AddWithValue("chiaveAZIENDA", chiaveAZIENDA);
        D.cmd.Parameters.AddWithValue("EMAIL", EMAIL);
        D.cmd.Parameters.AddWithValue("PWD", PWD);
        D.cmd.Parameters.AddWithValue("CAP", CAP);
        D.cmd.Parameters.AddWithValue("ABILITATO", ABILITATO);
        D.cmd.Parameters.AddWithValue("PRIMOACCESSO", PRIMOACCESSO);
        D.cmd.Parameters.AddWithValue("RUOLO", RUOLO);
        D.cmd.Parameters.AddWithValue("COGNOME", COGNOME);
        D.cmd.Parameters.AddWithValue("NOME", NOME);
        D.cmd.Parameters.AddWithValue("INDIRIZZO", INDIRIZZO);
        D.cmd.Parameters.AddWithValue("CITTA", CITTA);
        D.cmd.Parameters.AddWithValue("CAP", CAP);
        D.cmd.Parameters.AddWithValue("PROVINCIA", PROVINCIA);
        D.cmd.Parameters.AddWithValue("TELEFONO", TELEFONO);
        D.cmd.Parameters.AddWithValue("COSTOORARIO", COSTOORARIO);
        D.cmd.Parameters.AddWithValue("DATAINIZIORAPPORTO", DATAINIZIORAPPORTO);
        D.cmd.Parameters.AddWithValue("DATAFINERAPPORTO", DATAFINERAPPORTO);
        D.EseguiSPNonRead();
    }

    public DataTable spDIPENDENTI_Login()
    {
        DATABASE D = new DATABASE();
        D.cmd.CommandText = "spDIPENDENTI_Login";
        D.cmd.Parameters.AddWithValue("EMAIL", EMAIL);
        D.cmd.Parameters.AddWithValue("PWD", PWD);
        D.DT = D.EseguiSPRead();
        return D.DT;
    }

    public void spDIPENDENTI_Registra()
    {
        DATABASE D = new DATABASE();
        D.cmd.CommandText = "spDIPENENTI_Registra";
        D.cmd.Parameters.AddWithValue("EMAIL", EMAIL);
        D.EseguiSPNonRead();
    }

    public DataTable spDIPENDENTI_SelectAll()
    {
        DATABASE D = new DATABASE();
        D.cmd.CommandText = "spDIPENDENTI_SelectAll";
        D.DT = D.EseguiSPRead();
        return D.DT;
    }

    public DataTable spDIPENDENTI_SelectAll_DDL()
    {
        DATABASE D = new DATABASE();
        D.cmd.CommandText = "spDIPENDENTI_SelectAll_DDL";
        D.DT = D.EseguiSPRead();
        return D.DT;
    }

    public DataTable spDIPENDENTI_SelectByKey()
    {
        DATABASE D = new DATABASE();
        D.cmd.CommandText = "spDIPENDENTI_SelectBykey";
        D.DT = D.EseguiSPRead();
        return D.DT;
    }

    public void spCLIENTI_Update()
    {
        DATABASE D = new DATABASE();
        D.cmd.CommandText = "spCLIENTI_Update";
        D.cmd.Parameters.AddWithValue("chiave", chiave);
        D.cmd.Parameters.AddWithValue("chiaveAZIENDA", chiaveAZIENDA);
        D.cmd.Parameters.AddWithValue("EMAIL", EMAIL);
        D.cmd.Parameters.AddWithValue("PWD", PWD);
        D.cmd.Parameters.AddWithValue("CAP", CAP);
        D.cmd.Parameters.AddWithValue("ABILITATO", ABILITATO);
        D.cmd.Parameters.AddWithValue("PRIMOACCESSO", PRIMOACCESSO);
        D.cmd.Parameters.AddWithValue("RUOLO", RUOLO);
        D.cmd.Parameters.AddWithValue("COGNOME", COGNOME);
        D.cmd.Parameters.AddWithValue("NOME", NOME);
        D.cmd.Parameters.AddWithValue("INDIRIZZO", INDIRIZZO);
        D.cmd.Parameters.AddWithValue("CITTA", CITTA);
        D.cmd.Parameters.AddWithValue("CAP", CAP);
        D.cmd.Parameters.AddWithValue("PROVINCIA", PROVINCIA);
        D.cmd.Parameters.AddWithValue("TELEFONO", TELEFONO);
        D.cmd.Parameters.AddWithValue("COSTOORARIO", COSTOORARIO);
        D.cmd.Parameters.AddWithValue("DATAINIZIORAPPORTO", DATAINIZIORAPPORTO);
        D.cmd.Parameters.AddWithValue("DATAFINERAPPORTO", DATAFINERAPPORTO);
        D.EseguiSPNonRead();
    }
}