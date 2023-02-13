<%@ Page Language="C#" AutoEventWireup="true" CodeFile="RegistrazionePopup.aspx.cs" Inherits="RegistrazionePopup" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Registrazione</title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0-alpha1/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-GLhlTQ8iRABdZLl6O3oVMWSktQOp6b7In1Zl3/Jr59b6EGGoI1aFkw7cmDA6j6gD" crossorigin="anonymous" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="card Popup">
            <div class="card-body">
                <div class="row">
                    <div class="col-lg-6">
                        <asp:Label ID="Label2" runat="server" Text="Nome:"></asp:Label>
                        <asp:TextBox ID="txtNome" runat="server" MaxLength="50"></asp:TextBox>
                    </div>
                    <div class="col-lg-6">
                        <asp:Label ID="Label3" runat="server" Text="Cognome:"></asp:Label>
                        <asp:TextBox ID="txtCognome" runat="server" MaxLength="50"></asp:TextBox>
                    </div>
                </div>
                <div class="row">
                    <div class="col-lg-6">
                        <asp:Label ID="Label1" runat="server" Text="Inserisci nuova mail aziendale:"></asp:Label>
                        <asp:TextBox ID="txtMail" runat="server" MaxLength="50" TextMode="Email"></asp:TextBox>
                    </div>
                </div>
                <br />
                <div class="row">
                    <asp:Button ID="btnRegistrazione" runat="server" Text="Registrati" OnClick="btnRegistrazione_Click" />
                </div>
            </div>
        </div>
    </form>
</body>
</html>
