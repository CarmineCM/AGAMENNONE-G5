<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Login AGAMENNONE</title>
    <link href="assets/css/login.css" rel="stylesheet" />
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0-alpha1/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-GLhlTQ8iRABdZLl6O3oVMWSktQOp6b7In1Zl3/Jr59b6EGGoI1aFkw7cmDA6j6gD" crossorigin="anonymous" />
</head>
<body>
    <%--background--%>
    <div id="bg">
        <img src="assets/images/login/background.jpg" />
    </div>
    <%--background--%>
    <%--login form--%>
    <form runat="server">
        <div class="logo">
            <img src="assets/images/logo.png" />
        </div>
        <div>
            <div class="form-field">
                <asp:TextBox ID="txtEmail" type="email" runat="server" placeholder="Email / Username" MaxLength="50"></asp:TextBox>
            </div>

            <div class="form-field">
                <asp:TextBox ID="txtPWD" type="password" placeholder="Password" MaxLength="50" runat="server"></asp:TextBox>
            </div>

            <div class="form-field">
                <asp:Button ID="btn_Login" class="btn btn-secondary" Text="Log in" OnClick="btnLogin_Click" runat="server"></asp:Button>
            </div>
        </div>
        <%-- Introduzione di uno script manager --%>
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>

        <%--popup per registrazione--%>

        <%-- pulsante che apre il popup RegistrazionePopup --%>
        <asp:Button ID="btnRegistrazione" runat="server" Text="Registrazione" />

        <%-- chiamata del popup --%>
        <cc1:ModalPopupExtender
            ID="mp1"
            runat="server"
            PopupControlID="Panl1"
            TargetControlID="btnRegistrazione"
            CancelControlID="btnRegistrazionePopup"
            BackgroundCssClass="assets/css/popup.css">
        </cc1:ModalPopupExtender>

        <%-- contenuto del popup --%>
        <asp:Panel
            ID="Panl1"
            runat="server"
            CssClass="Popup"
            align="center"
            Style="display: none">
            <%--ci pensa lo script manager a renderlo visibile--%>

            <%--l'iframe è un contenitore che ha la possibilità di richiamare una pagina--%>
            <iframe style="width: 500px; height: 400px;" id="irm1" src="..\RegistrazionePopup.aspx" runat="server"></iframe>
            <br />
            <asp:Button ID="btnRegistrazionePopup" runat="server" Text="Chiudi" />
            <%--chiude il popup--%>
        </asp:Panel>

        <%--popup per registrazione--%>

        <br />

        <%--popup per cambia password--%>

        <%-- pulsante che apre il popup CambioPasswordPopup --%>
        <asp:Button ID="btnCambiaPWD" runat="server" Text="Cambia Password" />

        <%-- chiamata del popup --%>
        <cc1:ModalPopupExtender
            ID="mp2"
            runat="server"
            PopupControlID="Panl2"
            TargetControlID="btnCambiaPWD"
            CancelControlID="btnCambiaPWDPopup"
            BackgroundCssClass="assets/css/popup.css">
        </cc1:ModalPopupExtender>

        <%-- contenuto del popup --%>
        <asp:Panel
            ID="Panl2"
            runat="server"
            CssClass="Popup"
            align="center"
            Style="display: none">
            <%--ci pensa lo script manager a renderlo visibile--%>

            <%--l'iframe è un contenitore che ha la possibilità di richiamare una pagina--%>
            <iframe style="width: 500px; height: 400px;" id="Iframe1" src="..\CambioPasswordPopup.aspx" runat="server"></iframe>
            <br />
            <asp:Button ID="btnCambiaPWDPopup" runat="server" Text="Chiudi" />
            <%--chiude il popup--%>

            <%--popup per cambia password--%>
        </asp:Panel>
    </form>
    <%--login form--%>
</body>

</html>
