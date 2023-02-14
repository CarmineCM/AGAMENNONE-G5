using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;

public class REFERENTI
{
    public static string chiave;
    public static string chiaveCLIENTE;
    public static string COGNOME;
    public static string NOME;
    public static string EMAIL;
    public static string TELEFONO;

    public static void spREFERENTI_Insert()
    {
        DATABASE.cmd.CommandText = "spREFERENTI_Insert";
        DATABASE.cmd.Parameters.AddWithValue("chiaveCLIENTE", chiaveCLIENTE);
        DATABASE.cmd.Parameters.AddWithValue("COGNOME", COGNOME);
        DATABASE.cmd.Parameters.AddWithValue("NOME", NOME);
        DATABASE.cmd.Parameters.AddWithValue("EMAIL", EMAIL);
        DATABASE.cmd.Parameters.AddWithValue("TELEFONO", TELEFONO);
        DATABASE.EseguiSPNonRead();
    }

    public static DataTable spREFERENTI_SelectAll()
    {
        DATABASE.cmd.CommandText = "spREFERENTI_SelectAll";
        DATABASE.DT = DATABASE.EseguiSPRead();
        return DATABASE.DT;
    }

    public static DataTable spREFERENTI_SelectAll_DDL()
    {
        DATABASE.cmd.CommandText = "spREFERENTI_SelectAll_DDL";
        DATABASE.DT = DATABASE.EseguiSPRead();
        return DATABASE.DT;
    }

    public static DataTable spREFERENTI_SelectByKey()
    {
        DATABASE.cmd.Parameters.Clear();
        DATABASE.cmd.CommandText = "spREFERENTI_SelectBykey";
        DATABASE.cmd.Parameters.AddWithValue("chiave", chiave);
        DATABASE.DT = DATABASE.EseguiSPRead();
        return DATABASE.DT;
    }

    public static void spREFERENTI_Update()
    {
        DATABASE.cmd.Parameters.Clear();
        DATABASE.cmd.CommandText = "spREFERENTI_Update";
        DATABASE.cmd.Parameters.AddWithValue("chiave", chiave);
        DATABASE.cmd.Parameters.AddWithValue("chiaveCLIENTE", chiaveCLIENTE);
        DATABASE.cmd.Parameters.AddWithValue("COGNOME", COGNOME);
        DATABASE.cmd.Parameters.AddWithValue("NOME", NOME);
        DATABASE.cmd.Parameters.AddWithValue("EMAIL", EMAIL);
        DATABASE.cmd.Parameters.AddWithValue("TELEFONO", TELEFONO);
        DATABASE.EseguiSPNonRead();
    }
}