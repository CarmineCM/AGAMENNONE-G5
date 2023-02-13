<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CambioPasswordPopup.aspx.cs" Inherits="CambioPasswordPopup" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Cambio Password</title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0-alpha1/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-GLhlTQ8iRABdZLl6O3oVMWSktQOp6b7In1Zl3/Jr59b6EGGoI1aFkw7cmDA6j6gD" crossorigin="anonymous" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="card Popup">
            <div class="card-body">
                <div class="row">
                    <div class="col-lg-6">
                        <asp:Label ID="Label1" runat="server" Text="Inserisci Mail Utente:"></asp:Label>
                        <asp:TextBox ID="txtEmail" runat="server" MaxLength="50" TextMode="Email"></asp:TextBox>
                    </div>
                    <div class="col-lg-6">
                        <asp:Label ID="Label2" runat="server" Text="Inserisci Password Attuale:"></asp:Label>
                        <asp:TextBox ID="txtPWDOld" runat="server" MaxLength="50" TextMode="Password"></asp:TextBox>
                    </div>
                </div>
                <div class="row">
                    <div class="col-lg-6">
                        <asp:Label ID="Label3" runat="server" Text="Nuova Password:"></asp:Label>
                        <asp:TextBox ID="txtPWDNew" runat="server" MaxLength="50" TextMode="Password"></asp:TextBox>
                    </div>
                    <div class="col-lg-6">
                        <asp:Label ID="Label4" runat="server" Text="Conferma Nuova Password:"></asp:Label>
                        <asp:TextBox ID="txtPWDControl" runat="server" MaxLength="50" TextMode="Password"></asp:TextBox>
                    </div>
                    <br />
                    <div class="row">
                        <asp:Button ID="btnCambiaPWD" runat="server" Text="Cambia Password" OnClick="btnCambiaPWD_Click" />
                    </div>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
