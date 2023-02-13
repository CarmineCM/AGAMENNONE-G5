<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="GestisciCommesse.aspx.cs" Inherits="GestisciCommesse" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div style="margin-top:340px;">
        <div class="card">
            <asp:GridView ID="grigliaCommesse" runat="server" AutoGenerateColumns="False" CellPadding="4" DataKeyNames="chiave" DataSourceID="SDSCommesse" ForeColor="#333333" GridLines="None" OnSelectedIndexChanged="grigliaCommesse_SelectedIndexChanged">
                <AlternatingRowStyle BackColor="White" />
                <Columns>
                    <asp:BoundField DataField="chiave" HeaderText="chiave" InsertVisible="False" ReadOnly="True" SortExpression="chiave" />
                    <asp:BoundField DataField="chiaveCLIENTE" HeaderText="chiaveCLIENTE" SortExpression="chiaveCLIENTE" />
                    <asp:BoundField DataField="chiaveRESPONSABILE" HeaderText="chiaveRESPONSABILE" SortExpression="chiaveRESPONSABILE" />
                    <asp:BoundField DataField="CORPOORA" HeaderText="CORPOORA" SortExpression="CORPOORA" />
                    <asp:BoundField DataField="DATAAPERTURA" HeaderText="DATAAPERTURA" SortExpression="DATAAPERTURA" />
                    <asp:BoundField DataField="DATACHIUSURA" HeaderText="DATACHIUSURA" SortExpression="DATACHIUSURA" />
                    <asp:BoundField DataField="DATACONSEGNA" HeaderText="DATACONSEGNA" SortExpression="DATACONSEGNA" />
                    <asp:BoundField DataField="DESCRIZIONE" HeaderText="DESCRIZIONE" SortExpression="DESCRIZIONE" />
                    <asp:BoundField DataField="IMPORTOCORPO" HeaderText="IMPORTOCORPO" SortExpression="IMPORTOCORPO" />
                    <asp:BoundField DataField="IMPORTOORARIO" HeaderText="IMPORTOORARIO" SortExpression="IMPORTOORARIO" />
                    <asp:BoundField DataField="ANTICIPO" HeaderText="ANTICIPO" SortExpression="ANTICIPO" />
                    <asp:BoundField DataField="PERNOTTAMENTO" HeaderText="PERNOTTAMENTO" SortExpression="PERNOTTAMENTO" />
                    <asp:BoundField DataField="PASTO" HeaderText="PASTO" SortExpression="PASTO" />
                    <asp:BoundField DataField="KM" HeaderText="KM" SortExpression="KM" />
                    <asp:BoundField DataField="PEDAGGI" HeaderText="PEDAGGI" SortExpression="PEDAGGI" />
                    <asp:BoundField DataField="MEZZI" HeaderText="MEZZI" SortExpression="MEZZI" />
                </Columns>
                <EditRowStyle BackColor="#2461BF" />
                <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="#EFF3FB" />
                <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                <SortedAscendingCellStyle BackColor="#F5F7FB" />
                <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                <SortedDescendingCellStyle BackColor="#E9EBEF" />
                <SortedDescendingHeaderStyle BackColor="#4870BE" />
            </asp:GridView>
            <asp:SqlDataSource ID="SDSCommesse" runat="server" ConnectionString="<%$ ConnectionStrings:AGAMENNONEConnectionString %>" SelectCommand="spCOMMESSE_SelectAll" SelectCommandType="StoredProcedure"></asp:SqlDataSource>
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
        <iframe style="width: 700px; height: 700px;" id="irm1" src="InsCommesse.aspx" runat="server"></iframe>
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
        <iframe style="width: 700px; height: 700px;" id="Iframe1" src="ModificaCommessa.aspx" runat="server"></iframe>
        <br />
        <asp:Button ID="Button4" runat="server" Text="Close" />
        <%--chiude il popup--%>
    </asp:Panel>
</asp:Content>