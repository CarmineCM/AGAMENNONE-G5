<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="GestisciReferenti.aspx.cs" Inherits="Default2" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="container py-5 mt-5">
        <div class="card">
            <div class="card-body">
                <div class="row  d-flex justify-content-center align-items-center">
                    <div class="col-lg-8 col-xl-6">
                        <div>
                            <asp:GridView ID="grigliaReferenti" runat="server" AutoGenerateColumns="False" BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" CellSpacing="2" DataKeyNames="chiave" DataSourceID="SDSTABELLA" OnSelectedIndexChanged="grigliaReferenti_SelectedIndexChanged">
                                <Columns>
                                    <asp:CommandField ShowSelectButton="True" />
                                    <asp:BoundField DataField="chiave" HeaderText="chiave" InsertVisible="False" ReadOnly="True" SortExpression="chiave" />
                                    <asp:BoundField DataField="chiaveCLIENTE" HeaderText="chiaveCLIENTE" SortExpression="chiaveCLIENTE" />
                                    <asp:BoundField DataField="COGNOME" HeaderText="COGNOME" SortExpression="COGNOME" />
                                    <asp:BoundField DataField="NOME" HeaderText="NOME" SortExpression="NOME" />
                                    <asp:BoundField DataField="EMAIL" HeaderText="EMAIL" SortExpression="EMAIL" />
                                    <asp:BoundField DataField="TELEFONO" HeaderText="TELEFONO" SortExpression="TELEFONO" />
                                </Columns>
                                <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
                                <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
                                <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" />
                                <RowStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
                                <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
                                <SortedAscendingCellStyle BackColor="#FFF1D4" />
                                <SortedAscendingHeaderStyle BackColor="#B95C30" />
                                <SortedDescendingCellStyle BackColor="#F1E5CE" />
                                <SortedDescendingHeaderStyle BackColor="#93451F" />
                            </asp:GridView>
                            <asp:SqlDataSource ID="SDSTABELLA" runat="server" ConnectionString="<%$ ConnectionStrings:AGAMENNONEConnectionString %>" SelectCommand="spREFERENTI_SelectAll" SelectCommandType="StoredProcedure"></asp:SqlDataSource>
                        </div>
                    </div>
                </div>
                <div class="card-footer text-muted">
                    <asp:Button ID="btnIns" runat="server" Text="Inserisci" class="btn btn-primary" />
                    <asp:Button ID="btnMod" runat="server" Text="Modifica" class="btn btn-primary" />
                </div>
            </div>
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
        <iframe style="width: 700px; height: 700px;" id="irm1" src="InsReferente.aspx" runat="server"></iframe>
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
        <iframe style="width: 700px; height: 700px;" id="Iframe1" src="ModificaReferente.aspx" runat="server"></iframe>
        <br />
        <asp:Button ID="Button4" runat="server" Text="Close" />
        <%--chiude il popup--%>
    </asp:Panel>
</asp:Content>