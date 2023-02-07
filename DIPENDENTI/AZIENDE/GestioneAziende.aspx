<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="GestioneAziende.aspx.cs" Inherits="gestioneAziende" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>  

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">

      <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>

    <div style="margin-top:400px;">
        <%-- pulsante che apre il popup --%>
        <asp:Button ID="btnIns" runat="server" Text="Inserisci" />
    </div>
    <%-- chiamata del popup --%>
    <cc1:ModalPopupExtender ID="mp1" runat="server" PopupControlID="Panl1" TargetControlID="btnIns"
        CancelControlID="Button3" BackgroundCssClass="Background">
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
        <iframe style="width: 400px; height: 400px;" id="irm1" src="InsAziende.aspx" runat="server"></iframe>
        <br />
        <asp:Button ID="Button3" runat="server" Text="Close" />
        <%--chiude il popup--%>
    </asp:Panel>


    <%-- pulsante che apre il popup --%>
    <asp:Button ID="btnMod" runat="server" Text="Modifica" />

    <%-- chiamata del popup --%>
    <cc1:ModalPopupExtender ID="mp2" runat="server" PopupControlID="modifica" TargetControlID="btnMod"
        CancelControlID="Button4" BackgroundCssClass="Background">
    </cc1:ModalPopupExtender>

    <%-- contenuto del popup --%>
    <asp:Panel
        ID="modifica"
        runat="server"
        CssClass="Popup"
        align="center"
        Style="display: none">
        <%--ci pensa lo script manager a renderlo visibile--%>

        <%--l'iframe è un contenitore che ha la possibilità di richiamare una pagina--%>
        <iframe style="width: 400px; height: 400px;" id="Iframe1" src="ModificaAziende.aspx" runat="server"></iframe>
        <br />
        <asp:Button ID="Button4" runat="server" Text="Close" />
        <%--chiude il popup--%>
    </asp:Panel>

</asp:Content>

