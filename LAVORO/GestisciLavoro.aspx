<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="GestisciLavoro.aspx.cs" Inherits="GesioneLavoro" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">

    <div style="margin-top: 340px;">
        <div class="card">
            <asp:GridView ID="grigliaLavoro" runat="server" AutoGenerateColumns="False" DataKeyNames="chiave" DataSourceID="SDSLavoro" OnSelectedIndexChanged="grigliaLavoro_SelectedIndexChanged">
                <Columns>
                    <asp:CommandField ShowSelectButton="True" />
                    <asp:BoundField DataField="chiave" HeaderText="chiave" InsertVisible="False" ReadOnly="True" SortExpression="chiave" />
                    <asp:BoundField DataField="chiaveCOMMESSA" HeaderText="chiaveCOMMESSA" SortExpression="chiaveCOMMESSA" />
                    <asp:BoundField DataField="chiaveDIPENDENTE" HeaderText="chiaveDIPENDENTE" SortExpression="chiaveDIPENDENTE" />
                    <asp:BoundField DataField="DATAORA" HeaderText="DATAORA" SortExpression="DATAORA" />
                    <asp:BoundField DataField="ORE" HeaderText="ORE" SortExpression="ORE" />
                    <asp:BoundField DataField="DESCRIZIONE" HeaderText="DESCRIZIONE" SortExpression="DESCRIZIONE" />
                    <asp:BoundField DataField="PERNOTTAMENTO" HeaderText="PERNOTTAMENTO" SortExpression="PERNOTTAMENTO" />
                    <asp:BoundField DataField="PASTO" HeaderText="PASTO" SortExpression="PASTO" />
                    <asp:BoundField DataField="KM" HeaderText="KM" SortExpression="KM" />
                    <asp:BoundField DataField="PEDAGGI" HeaderText="PEDAGGI" SortExpression="PEDAGGI" />
                    <asp:BoundField DataField="MEZZI" HeaderText="MEZZI" SortExpression="MEZZI" />
                    <asp:BoundField DataField="SPESEEXTRA" HeaderText="SPESEEXTRA" SortExpression="SPESEEXTRA" />
                    <asp:BoundField DataField="DESCRIZIONESPESEEXTRA" HeaderText="DESCRIZIONESPESEEXTRA" SortExpression="DESCRIZIONESPESEEXTRA" />
                    <asp:CheckBoxField DataField="ACCETTAZIONESPESE" HeaderText="ACCETTAZIONESPESE" SortExpression="ACCETTAZIONESPESE" />
                </Columns>
            </asp:GridView>
            <asp:SqlDataSource ID="SDSLavoro" runat="server" ConnectionString="<%$ ConnectionStrings:AGAMENNONEConnectionString %>" SelectCommand="spLAVORI_SelectAll" SelectCommandType="StoredProcedure"></asp:SqlDataSource>
        </div>
    </div>

        <div class="container">
        <div class="row align-items-center">
            <div class="col">
                <div class="col"></div>
                <div class="col">
                    <div class="card text-center w-50" style="margin-top: 10%;">
                        <div class="card-header">Cosa Vuoi fare? </div>
                        <div class="card-body">
                            <%-- pulsante che apre il popup --%>
                            <asp:Button ID="btnIns" runat="server" Text="Inserisci" class="btn btn-light" />

                            <%-- pulsante che apre il popup --%>
                            <asp:Button ID="btnMod" runat="server" Text="Modifica" class="btn btn-light" />
                        </div>
                    </div>
                </div>
                <div class="col"></div>
            </div>
        </div>
    </div>

    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>


    <%-- chiamata del popup --%>
    <cc1:ModalPopupExtender ID="mp1" runat="server" PopupControlID="Panl1" TargetControlID="btnIns"
        CancelControlID="Button2" BackgroundCssClass="Background">
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
        <iframe style="width: 700px; height: 700px;" id="irm1" src="../LAVORO/InsLavoro.aspx" runat="server"></iframe>
        <br />
        <asp:Button ID="Button2" runat="server" Text="Close" />
        <%--chiude il popup--%>
    </asp:Panel>

    <%-- chiamata del popup --%>
    <cc1:ModalPopupExtender ID="mp2" runat="server" PopupControlID="modifica" TargetControlID="btnMod"
        CancelControlID="Button3" BackgroundCssClass="Background">
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
        <iframe style="width: 400px; height: 400px;" id="Iframe1" src="../LAVORO/ModificaLavoro.aspx" runat="server"></iframe>
        <br />
        <asp:Button ID="Button3" runat="server" Text="Close" />
        <%--chiude il popup--%>
    </asp:Panel>
</asp:Content>