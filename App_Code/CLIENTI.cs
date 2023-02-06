using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;


public class CLIENTI
{
    public int chiave;
    public string RAGIONESOCIALE;
    public string INDIRIZZO;
    public string CITTA;
    public string CAP;
    public string PROVINCIA;
    public string EMAIL;
    public string TELEFONO;
    public string CODICEFISCALE;
    public string PIVA;
    public string PEC;
    public string CFE;
    public string TITOLARE;
    public string EMAILTITOLARE;
    public string TELTITOLARE;


    public CLIENTI()
    {

    }

    public void spCLIENTI_Insert()
    {
        DATABASE D = new DATABASE();
        D.cmd.CommandText = "spCLIENTI_Insert";
        D.cmd.Parameters.AddWithValue("RAGIONESOCIALE", RAGIONESOCIALE);
        D.cmd.Parameters.AddWithValue("INDIRIZZO", INDIRIZZO);
        D.cmd.Parameters.AddWithValue("CITTA", CITTA);
        D.cmd.Parameters.AddWithValue("CAP", CAP);
        D.cmd.Parameters.AddWithValue("PROVINCIA", PROVINCIA);
        D.cmd.Parameters.AddWithValue("EMAIL", EMAIL);
        D.cmd.Parameters.AddWithValue("TELEFONO", TELEFONO);
        D.cmd.Parameters.AddWithValue("CODICEFISCALE", CODICEFISCALE);
        D.cmd.Parameters.AddWithValue("PIVA", PIVA);
        D.cmd.Parameters.AddWithValue("PEC", PEC);
        D.cmd.Parameters.AddWithValue("CFE", CFE);
        D.cmd.Parameters.AddWithValue("TITOLARE", TITOLARE);
        D.cmd.Parameters.AddWithValue("EMAILTITOLARE", EMAILTITOLARE);
        D.cmd.Parameters.AddWithValue("TELTITOLARE", TELTITOLARE);
        D.EseguiSPNonRead();
    }

    public DataTable spCLIENTI_SelectAll()
    {
        DATABASE D = new DATABASE();
        D.cmd.CommandText = "spCLIENTI_SelectAll";
        D.DT = D.EseguiSPRead();
        return D.DT;
    }

    public DataTable spCLIENTI_SelectAll_DDL()
    {
        DATABASE D = new DATABASE();
        D.cmd.CommandText = "spCLIENTI_SelectAll_DDL";
        D.DT = D.EseguiSPRead();
        return D.DT;
    }

    public DataTable spCLIENTI_SelectByKey()
    {
        DATABASE D = new DATABASE();
        D.cmd.CommandText = "spCLIENTI_SelectBykey";
        D.DT = D.EseguiSPRead();
        return D.DT;
    }

    public void spCLIENTI_Update()
    {
        DATABASE D = new DATABASE();
        D.cmd.CommandText = "spCLIENTI_Update";
        D.cmd.Parameters.AddWithValue("chiave", chiave);
        D.cmd.Parameters.AddWithValue("RAGIONESOCIALE", RAGIONESOCIALE);
        D.cmd.Parameters.AddWithValue("INDIRIZZO", INDIRIZZO);
        D.cmd.Parameters.AddWithValue("CITTA", CITTA);
        D.cmd.Parameters.AddWithValue("CAP", CAP);
        D.cmd.Parameters.AddWithValue("PROVINCIA", PROVINCIA);
        D.cmd.Parameters.AddWithValue("EMAIL", EMAIL);
        D.cmd.Parameters.AddWithValue("TELEFONO", TELEFONO);
        D.cmd.Parameters.AddWithValue("CODICEFISCALE", CODICEFISCALE);
        D.cmd.Parameters.AddWithValue("PIVA", PIVA);
        D.cmd.Parameters.AddWithValue("PEC", PEC);
        D.cmd.Parameters.AddWithValue("CFE", CFE);
        D.cmd.Parameters.AddWithValue("TITOLARE", TITOLARE);
        D.cmd.Parameters.AddWithValue("EMAILTITOLARE", EMAILTITOLARE);
        D.cmd.Parameters.AddWithValue("TELTITOLARE", TELTITOLARE);
        D.EseguiSPNonRead();
    }
}