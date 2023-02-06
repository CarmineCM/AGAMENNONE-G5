using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;

public class REFERENTICOMMESSE
{
    public int chiave;
    public int chiaveREFERENTE;
    public int chiaveCOMMESSA;
    public REFERENTICOMMESSE()
    {
       
    }

    public void spREFERENTICOMMESSE_DeleteAll()
    {
        DATABASE D = new DATABASE();
        D.cmd.CommandText = "spREFERENTICOMMESSE_DeleteAll";
        D.EseguiSPNonRead();
    }

    public void spREFERENTICOMMESSE_Insert()
    {
        DATABASE D = new DATABASE();
        D.cmd.CommandText = "spREFERENTICOMMESSE_Insert";
        D.cmd.Parameters.AddWithValue("chiaveREFERENTE", chiaveREFERENTE);
        D.cmd.Parameters.AddWithValue("chiaveCOMMESSA", chiaveCOMMESSA);
        D.EseguiSPNonRead();
    }
}