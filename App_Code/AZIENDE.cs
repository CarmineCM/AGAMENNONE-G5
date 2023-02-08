using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;

public class AZIENDE
{
    public static int chiave;
    public static string RAGIONESOCIALE;
    public static string INDIRIZZO;
    public static string CITTA;
    public static string CAP;
    public static string PROVINCIA;
    public static string EMAIL;
    public static string TELEFONO;
    public static string CODICEFISCALE;
    public static string PIVA;
    public static string PEC;
    public static string CFE;
    public static string TITOLARE;
    public static string EMAILTITOLARE;
    public static string TELTITOLARE; 

    public static void spAZIENDE_Insert()
    {
        DATABASE.cmd.CommandText = "spACCESSI_Insert";
        DATABASE.cmd.Parameters.AddWithValue("RAGIONESOCIALE", RAGIONESOCIALE);
        DATABASE.cmd.Parameters.AddWithValue("INDIRIZZO", INDIRIZZO);
        DATABASE.cmd.Parameters.AddWithValue("CITTA", CITTA);
        DATABASE.cmd.Parameters.AddWithValue("CAP", CAP);
        DATABASE.cmd.Parameters.AddWithValue("PROVINCIA", PROVINCIA);
        DATABASE.cmd.Parameters.AddWithValue("EMAIL", EMAIL);
        DATABASE.cmd.Parameters.AddWithValue("TELEFONO", TELEFONO);
        DATABASE.cmd.Parameters.AddWithValue("CODICEFISCALE", CODICEFISCALE);
        DATABASE.cmd.Parameters.AddWithValue("PIVA", PIVA);
        DATABASE.cmd.Parameters.AddWithValue("PEC", PEC);
        DATABASE.cmd.Parameters.AddWithValue("CFE", CFE);
        DATABASE.cmd.Parameters.AddWithValue("TITOLARE", TITOLARE);
        DATABASE.cmd.Parameters.AddWithValue("EMAILTITOLARE", EMAILTITOLARE);
        DATABASE.cmd.Parameters.AddWithValue("TELTITOLARE", TELTITOLARE);
        DATABASE.EseguiSPNonRead();
    }

    public static DataTable spAZIENDE_SelectAll()
    {
        DATABASE.cmd.CommandText = "spAZIENDE_SelectAll";
        DATABASE.DT = DATABASE.EseguiSPRead();
        return DATABASE.DT;
    }

    public static DataTable spAZIENDE_SelectAll_DDL()
    {
        DATABASE.cmd.CommandText = "spAZIENDE_SelectAll_DDL";
        DATABASE.DT = DATABASE.EseguiSPRead();
        return DATABASE.DT;
    }

    public static DataTable spAZIENDE_SelectByKey()
    {
        DATABASE.cmd.CommandText = "spAZIENDE_SelectBykey";
        DATABASE.DT = DATABASE.EseguiSPRead();
        return DATABASE.DT;
    }

    public static void spAZIENDE_Update()
    {
        DATABASE.cmd.CommandText = "spAZIENDE_Update";
        DATABASE.cmd.Parameters.AddWithValue("chiave", chiave);
        DATABASE.cmd.Parameters.AddWithValue("RAGIONESOCIALE", RAGIONESOCIALE);
        DATABASE.cmd.Parameters.AddWithValue("INDIRIZZO", INDIRIZZO);
        DATABASE.cmd.Parameters.AddWithValue("CITTA", CITTA);
        DATABASE.cmd.Parameters.AddWithValue("CAP", CAP);
        DATABASE.cmd.Parameters.AddWithValue("PROVINCIA", PROVINCIA);
        DATABASE.cmd.Parameters.AddWithValue("EMAIL", EMAIL);
        DATABASE.cmd.Parameters.AddWithValue("TELEFONO", TELEFONO);
        DATABASE.cmd.Parameters.AddWithValue("CODICEFISCALE", CODICEFISCALE);
        DATABASE.cmd.Parameters.AddWithValue("PIVA", PIVA);
        DATABASE.cmd.Parameters.AddWithValue("PEC", PEC);
        DATABASE.cmd.Parameters.AddWithValue("CFE", CFE);
        DATABASE.cmd.Parameters.AddWithValue("TITOLARE", TITOLARE);
        DATABASE.cmd.Parameters.AddWithValue("EMAILTITOLARE", EMAILTITOLARE);
        DATABASE.cmd.Parameters.AddWithValue("TELTITOLARE", TELTITOLARE);
        DATABASE.EseguiSPNonRead();
    }
}