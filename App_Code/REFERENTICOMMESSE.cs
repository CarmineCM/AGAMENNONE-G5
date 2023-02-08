using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;

public class REFERENTICOMMESSE
{
    public static int chiave;
    public static int chiaveREFERENTE;
    public static int chiaveCOMMESSA;

    public static void spREFERENTICOMMESSE_DeleteAll()
    {
        DATABASE.cmd.CommandText = "spREFERENTICOMMESSE_DeleteAll";
        DATABASE.EseguiSPNonRead();
    }

    public static void spREFERENTICOMMESSE_Insert()
    {
        DATABASE.cmd.CommandText = "spREFERENTICOMMESSE_Insert";
        DATABASE.cmd.Parameters.AddWithValue("chiaveREFERENTE", chiaveREFERENTE);
        DATABASE.cmd.Parameters.AddWithValue("chiaveCOMMESSA", chiaveCOMMESSA);
        DATABASE.EseguiSPNonRead();
    }
}