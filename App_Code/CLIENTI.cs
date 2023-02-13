using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;


public class CLIENTI
{
    public static string chiave;
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

    public static void spCLIENTI_Insert()
    {
        DATABASE.cmd.Parameters.Clear();
        DATABASE.cmd.CommandText = "spCLIENTI_Insert";
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

    public static DataTable spCLIENTI_SelectAll()
    {
        DATABASE.cmd.CommandText = "spCLIENTI_SelectAll";
        DATABASE.DT = DATABASE.EseguiSPRead();
        return DATABASE.DT;
    }

    public static DataTable spCLIENTI_SelectAll_DDL()
    {
        DATABASE.cmd.CommandText = "spCLIENTI_SelectAll_DDL";
        DATABASE.DT = DATABASE.EseguiSPRead();
        return DATABASE.DT;
    }

    public static DataTable spCLIENTI_SelectByKey()
    {
        DATABASE.cmd.Parameters.Clear();
        DATABASE.cmd.CommandText = "spCLIENTI_SelectBykey";
        DATABASE.cmd.Parameters.AddWithValue("chiave", chiave);
        DATABASE.DT = DATABASE.EseguiSPRead();
        return DATABASE.DT;
    }

    public static void spCLIENTI_Update()
    {
        DATABASE.cmd.Parameters.Clear();
        DATABASE.cmd.CommandText = "spCLIENTI_Update";
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