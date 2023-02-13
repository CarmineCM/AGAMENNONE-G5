<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="GestioneAziende.aspx.cs" Inherits="gestioneAziende" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div style="margin-top: 340px;">
        <div class="card">
            <asp:GridView ID="grigliaAzienda" runat="server" AutoGenerateColumns="False" DataKeyNames="chiave" DataSourceID="SDSAziende" OnSelectedIndexChanged="grigliaAzienda_SelectedIndexChanged">
                <Columns>
                    <asp:CommandField ShowSelectButton="True" />
                    <asp:BoundField DataField="chiave" HeaderText="chiave" InsertVisible="False" ReadOnly="True" SortExpression="chiave" Visible="False" />
                    <asp:BoundField DataField="RAGIONESOCIALE" HeaderText="RAGIONESOCIALE" SortExpression="RAGIONESOCIALE" />
                    <asp:BoundField DataField="INDIRIZZO" HeaderText="INDIRIZZO" SortExpression="INDIRIZZO" />
                    <asp:BoundField DataField="CITTA" HeaderText="CITTA" SortExpression="CITTA" />
                    <asp:BoundField DataField="CAP" HeaderText="CAP" SortExpression="CAP" />
                    <asp:BoundField DataField="PROVINCIA" HeaderText="PROVINCIA" SortExpression="PROVINCIA" />
                    <asp:BoundField DataField="EMAIL" HeaderText="EMAIL" SortExpression="EMAIL" />
                    <asp:BoundField DataField="TELEFONO" HeaderText="TELEFONO" SortExpression="TELEFONO" />
                    <asp:BoundField DataField="CODICEFISCALE" HeaderText="CODICEFISCALE" SortExpression="CODICEFISCALE" />
                    <asp:BoundField DataField="PIVA" HeaderText="PIVA" SortExpression="PIVA" />
                    <asp:BoundField DataField="PEC" HeaderText="PEC" SortExpression="PEC" />
                    <asp:BoundField DataField="CFE" HeaderText="CFE" SortExpression="CFE" />
                    <asp:BoundField DataField="TITOLARE" HeaderText="TITOLARE" SortExpression="TITOLARE" />
                    <asp:BoundField DataField="EMAILTITOLARE" HeaderText="EMAILTITOLARE" SortExpression="EMAILTITOLARE" />
                    <asp:BoundField DataField="TELTITOLARE" HeaderText="TELTITOLARE" SortExpression="TELTITOLARE" />
                </Columns>
            </asp:GridView>
            <asp:SqlDataSource ID="SDSAziende" runat="server" ConnectionString="<%$ ConnectionStrings:AGAMENNONEConnectionString %>" SelectCommand="spAZIENDE_SelectAll" SelectCommandType="StoredProcedure"></asp:SqlDataSource>
        </div>
    </div>

    <div class="card text-center w-25" style="margin-top: 10%;">
        <div class="card-header">Cosa Vuoi fare? </div>
        <div class="card-body">
            <%-- pulsante che apre il popup --%>
            <asp:Button ID="btnIns" runat="server" Text="Inserisci" class="btn btn-light" />

            <%-- pulsante che apre il popup --%>
            <asp:Button ID="btnMod" runat="server" Text="Modifica" class="btn btn-light" />
        </div>
    </div>


    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>

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
        <iframe style="width: 700px; height: 700px;" id="irm1" src="InsAziende.aspx" runat="server"></iframe>
        <br />
        <asp:Button ID="Button3" runat="server" Text="Close" />
        <%--chiude il popup--%>
    </asp:Panel>

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
        <iframe style="width: 700px; height: 700px;" id="Iframe1" src="ModificeAzienda.aspx" runat="server"></iframe>
        <br />
        <asp:Button ID="Button4" runat="server" Text="Close" />
        <%--chiude il popup--%>
    </asp:Panel>

</asp:Content>

