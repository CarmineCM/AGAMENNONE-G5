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
    public static string chiave;
    public static string chiaveAZIENDA;
    public static string EMAIL;
    public static string PWD;
    public static bool ABILITATO;
    public static bool PRIMOACCESSO;
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

    public static void spDIPENDENTI_CambioPassword()
    {
        DATABASE.cmd.Parameters.Clear();
        DATABASE.cmd.CommandText = "spDIPENDENTI_CambioPassword";
        DATABASE.cmd.Parameters.AddWithValue("chiave", chiave);
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
        DATABASE.cmd.Parameters.Clear();
        DATABASE.cmd.CommandText = "spDIPENDENTI_Insert";
        DATABASE.cmd.Parameters.AddWithValue("chiaveAZIENDA", chiaveAZIENDA);
        DATABASE.cmd.Parameters.AddWithValue("EMAIL", EMAIL);
        DATABASE.cmd.Parameters.AddWithValue("PWD", PWD);
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
        DATABASE.cmd.Parameters.Clear();
        DATABASE.cmd.CommandText = "spDIPENDENTI_Login";
        DATABASE.cmd.Parameters.AddWithValue("EMAIL", EMAIL);
        DATABASE.cmd.Parameters.AddWithValue("PWD", PWD);
        DATABASE.DT = DATABASE.EseguiSPRead();
        return DATABASE.DT;
    }

    public static void spDIPENDENTI_Registra()
    {
        DATABASE.cmd.Parameters.Clear();
        DATABASE.cmd.CommandText = "spDIPENDENTI_Registra";
        DATABASE.cmd.Parameters.AddWithValue("EMAIL", EMAIL);
        DATABASE.cmd.Parameters.AddWithValue("PWD", PWD);
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

    public static void spDIPENDENTI_Update()
    {
        DATABASE.cmd.CommandText = "spDIPENDENTI_Update";
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

    public static DataTable spDIPENDENTI_GetDipendentiByMail()
    {
        DATABASE.DT.Clear();
        DATABASE.cmd.Parameters.Clear();
        DATABASE.cmd.CommandText = "spDIPENDENTI_GetDipendentiByMail";
        DATABASE.cmd.Parameters.AddWithValue("@EMAIL", EMAIL);
        DATABASE.DT = DATABASE.EseguiSPRead();
        return DATABASE.DT;
    }

    public static DataTable spDIPENDENTI_GetchiaveByEMailPWD()
    {
        DATABASE.DT.Clear();
        DATABASE.cmd.Parameters.Clear();
        DATABASE.cmd.CommandText = "spDIPENDENTI_GetchiaveByEMailPWD";
        DATABASE.cmd.Parameters.AddWithValue("EMAIL", EMAIL);
        DATABASE.cmd.Parameters.AddWithValue("PWD", PWD);
        DATABASE.DT = DATABASE.EseguiSPRead();
        return DATABASE.DT;
    }
}