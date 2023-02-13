using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class RegistrazionePopup : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }


   
    protected void btnRegistrazione_Click(object sender, EventArgs e)
    {
        string nuovaMail = txtNome.Text.Trim() + "." + txtCognome.Text.Trim() + "@agamennone.it";
        //controlli formali
        //controllo se la mail inserita dall'utente è a norma
        if (txtMail.Text.EndsWith("@agamennone.it"))
        {
            //vedo se esiste già una mail dipendente nel db uguale a quella inserita dal nuovo dipendente
            DIPENDENTI.EMAIL = nuovaMail;
            DataTable DT = new DataTable();
            //pulisco i parametri del db
            DT = DIPENDENTI.spDIPENDENTI_GetDipendentiByMail();
            if (DT.Rows.Count == 0)
            {
                //se non esiste, ulteriore controllo formale per verificare se la mail inserita rispetta la convenzione nome.cognome@agamennone.it
                if (nuovaMail == txtNome.Text.Trim() + "." + txtCognome.Text.Trim() + "@agamennone.it")
                {
                    DT.Clear();
                    //genero una password tramite la classe cryptazione, la crypto e poi la mando al DB
                    CRYPTAZIONE.tempPass = CRYPTAZIONE.CreatePassword();
                    DIPENDENTI.PWD = CRYPTAZIONE.Crypta(CRYPTAZIONE.tempPass);
                    DIPENDENTI.spDIPENDENTI_Registra();
                    //registro la nuova mail scritta dall'utente
                    //genero e creo la password temporanea

                    //mi preparo per inviare la mail al nuovo utente
                    SmtpClient client = new SmtpClient();

                    //imposto il server di invio della mail
                    client.Credentials = new NetworkCredential("generation@brovia.it", "!Pr0secc0!");
                    client.Port = 25;
                    client.Host = "brovia.it";
                    client.EnableSsl = false;

                    //imposto il messaggio
                    MailMessage mail = new MailMessage();
                    mail.From = new MailAddress("generation@brovia.it"); //mittente
                    mail.To.Add("matteo.scarnera27@gmail.com"); //destinatario
                    mail.IsBodyHtml = true; //mail è scritta in html
                    mail.Subject = "Nuova Registrazione database AGAMENNONE"; //oggetto
                                                                              //messaggio
                    mail.Body = "<h2>Amministratore,<br/> questa è una mail generata in automatico per darle la password temporanea per un nuovo dipendente. <br/>Il suo nome è:'" + txtNome.Text.Trim() + "' '" + txtCognome.Text.Trim() + "', e la password temporanea è:'" + CRYPTAZIONE.Decrypta(DIPENDENTI.PWD) + "'<br/>Si ricordi di attivare il nuovo dipendente presso la piattaforma AGAMENNONE, e di consegnargl* la password il prima possibile.</h2>";
                    //mail.Body = "<h2>Il suo nome è:'" + txtNome.Text.Trim() + "' '" + txtCognome.Text.Trim() + "', e la password temporanea è:  <h2><br/>";
                    //mail.Body = "<h2>'" + CRYPTAZIONE.Decrypta(DIPENDENTI.PWD) + "'<h2><br/>";
                    //mail.Body = "<h2>Si ricordi di attivare il nuovo dipendente presso la piattaforma AGAMENNONE, e di consegnargl* la password il prima possibile.</h2><br/>";


                    client.Send(mail); //mando mail

                    //alert di conferma avvenuta registrazione
                    ClientScript.RegisterStartupScript(this.GetType(), "ERRORE", "alert('" + CRYPTAZIONE.Decrypta(DIPENDENTI.PWD) + "'');", true);
                    ClientScript.RegisterStartupScript(this.GetType(), "ERRORE", "alert('Registrazione avvenuta con successo! Riceverai la tua password temporanea dall'amministratore a breve.');", true);
                    return;
                }
                else
                {
                    //se la mail non è a norma, allora alert e return
                    ClientScript.RegisterStartupScript(this.GetType(), "ERRORE", "alert('Mail non a norma. Inserisci nome e cognome nella tua mail');", true);
                    return;
                }
            }
            else
            {
                //se la mail esiste, controllo se l'utente è abilitato
                if ((bool)DT.Rows[0]["ABILITATO"] == true)
                {
                    //se lo è, avviso che verrà contattato dall'amministratore a breve per ricevere la password temporanea
                    ClientScript.RegisterStartupScript(this.GetType(), "ERRORE", "alert('Utente abilitato. Verrai contattato dall'amministratore per tua password temporanea a breve.');", true);
                    return;
                }
                // se non è abilitato, avviso che verrà abilitato a breve e di attendere per password temporanea.
                ClientScript.RegisterStartupScript(this.GetType(), "ERRORE", "alert('Dipendente non abilitato. Attendi che l'amministratore ti abiliti e ti consegni la password temporanea.');", true);
                return;
            }
        }
        else
        {
            //se la mail non è a norma, avviso che la mail è scritta male e return
            ClientScript.RegisterStartupScript(this.GetType(), "ERRORE", "alert('Mail non aziendale o non a norma. Inserisci il formato corretto');", true);
            return;
        }
    }
}