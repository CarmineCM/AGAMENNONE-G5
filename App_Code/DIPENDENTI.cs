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
    public static int chiave;
    public static int chiaveAZIENDA;
    public static string EMAIL;
    public static string PWD;
    public static string ABILITATO;
    public static string PRIMOACCESSO;
    public static string RUOLO;
    public static string COGNOME;
    public static string NOME;
    public static string INDIRIZZO;
    public static string CITTA;
    public static string CAP;
    public static string PROVINCIA;
    public static string TELEFONO;
    public static string COSTOORARIO;
    public static string DATAINIZIORAPPORTO;
    public static string DATAFINERAPPORTO;

    public static void spDIPENDENTI_Abilita()
    {
        DATABASE.cmd.CommandText = "spDIPENDENTI_Abilita";
        DATABASE.cmd.Parameters.AddWithValue("chiave", chiave);
        DATABASE.EseguiSPNonRead();
    }

    public static void spDIPENDENTI_CambiaPassword()
    {
        DATABASE.cmd.CommandText = "spDIPENDENTI_CambiaPassword";
        DATABASE.cmd.Parameters.AddWithValue("PWD", PWD);
        DATABASE.EseguiSPNonRead();
    }

    public static void spDIPENDENTI_Disabilita()
    {
        DATABASE.cmd.CommandText = "spDIPENDENTI_Disabilita";
        DATABASE.cmd.Parameters.AddWithValue("chiave", chiave);
        DATABASE.EseguiSPNonRead();
    }

    public static void spDIPENDENTI_Insert()
    {
        DATABASE.cmd.CommandText = "spDIPENDENTI_Insert";
        DATABASE.cmd.Parameters.AddWithValue("chiaveAZIENDA", chiaveAZIENDA);
        DATABASE.cmd.Parameters.AddWithValue("EMAIL", EMAIL);
        DATABASE.cmd.Parameters.AddWithValue("PWD", PWD);
        DATABASE.cmd.Parameters.AddWithValue("CAP", CAP);
        DATABASE.cmd.Parameters.AddWithValue("ABILITATO", ABILITATO);
        DATABASE.cmd.Parameters.AddWithValue("PRIMOACCESSO", PRIMOACCESSO);
        DATABASE.cmd.Parameters.AddWithValue("RUOLO", RUOLO);
        DATABASE.cmd.Parameters.AddWithValue("COGNOME", COGNOME);
        DATABASE.cmd.Parameters.AddWithValue("NOME", NOME);
        DATABASE.cmd.Parameters.AddWithValue("INDIRIZZO", INDIRIZZO);
        DATABASE.cmd.Parameters.AddWithValue("CITTA", CITTA);
        DATABASE.cmd.Parameters.AddWithValue("CAP", CAP);
        DATABASE.cmd.Parameters.AddWithValue("PROVINCIA", PROVINCIA);
        DATABASE.cmd.Parameters.AddWithValue("TELEFONO", TELEFONO);
        DATABASE.cmd.Parameters.AddWithValue("COSTOORARIO", COSTOORARIO);
        DATABASE.cmd.Parameters.AddWithValue("DATAINIZIORAPPORTO", DATAINIZIORAPPORTO);
        DATABASE.cmd.Parameters.AddWithValue("DATAFINERAPPORTO", DATAFINERAPPORTO);
        DATABASE.EseguiSPNonRead();
    }

    public static DataTable spDIPENDENTI_Login()
    {
        DATABASE.cmd.CommandText = "spDIPENDENTI_Login";
        DATABASE.cmd.Parameters.AddWithValue("EMAIL", EMAIL);
        DATABASE.cmd.Parameters.AddWithValue("PWD", PWD);
        DATABASE.DT = DATABASE.EseguiSPRead();
        return DATABASE.DT;
    }

    public static void spDIPENDENTI_Registra()
    {
        DATABASE.cmd.CommandText = "spDIPENENTI_Registra";
        DATABASE.cmd.Parameters.AddWithValue("EMAIL", EMAIL);
        DATABASE.EseguiSPNonRead();
    }

    public static DataTable spDIPENDENTI_SelectAll()
    {
        DATABASE.cmd.CommandText = "spDIPENDENTI_SelectAll";
        DATABASE.DT = DATABASE.EseguiSPRead();
        return DATABASE.DT;
    }

    public static DataTable spDIPENDENTI_SelectAll_DDL()
    {
        DATABASE.cmd.CommandText = "spDIPENDENTI_SelectAll_DDL";
        DATABASE.DT = DATABASE.EseguiSPRead();
        return DATABASE.DT;
    }

    public static DataTable spDIPENDENTI_SelectByKey()
    {
        DATABASE.cmd.CommandText = "spDIPENDENTI_SelectBykey";
        DATABASE.DT = DATABASE.EseguiSPRead();
        return DATABASE.DT;
    }

    public static void spCLIENTI_Update()
    {
        DATABASE.cmd.CommandText = "spCLIENTI_Update";
        DATABASE.cmd.Parameters.AddWithValue("chiave", chiave);
        DATABASE.cmd.Parameters.AddWithValue("chiaveAZIENDA", chiaveAZIENDA);
        DATABASE.cmd.Parameters.AddWithValue("EMAIL", EMAIL);
        DATABASE.cmd.Parameters.AddWithValue("PWD", PWD);
        DATABASE.cmd.Parameters.AddWithValue("CAP", CAP);
        DATABASE.cmd.Parameters.AddWithValue("ABILITATO", ABILITATO);
        DATABASE.cmd.Parameters.AddWithValue("PRIMOACCESSO", PRIMOACCESSO);
        DATABASE.cmd.Parameters.AddWithValue("RUOLO", RUOLO);
        DATABASE.cmd.Parameters.AddWithValue("COGNOME", COGNOME);
        DATABASE.cmd.Parameters.AddWithValue("NOME", NOME);
        DATABASE.cmd.Parameters.AddWithValue("INDIRIZZO", INDIRIZZO);
        DATABASE.cmd.Parameters.AddWithValue("CITTA", CITTA);
        DATABASE.cmd.Parameters.AddWithValue("CAP", CAP);
        DATABASE.cmd.Parameters.AddWithValue("PROVINCIA", PROVINCIA);
        DATABASE.cmd.Parameters.AddWithValue("TELEFONO", TELEFONO);
        DATABASE.cmd.Parameters.AddWithValue("COSTOORARIO", COSTOORARIO);
        DATABASE.cmd.Parameters.AddWithValue("DATAINIZIORAPPORTO", DATAINIZIORAPPORTO);
        DATABASE.cmd.Parameters.AddWithValue("DATAFINERAPPORTO", DATAFINERAPPORTO);
        DATABASE.EseguiSPNonRead();
    }
}