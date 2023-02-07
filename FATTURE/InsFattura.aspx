<%@ Page Language="C#" AutoEventWireup="true" CodeFile="InsFattura.aspx.cs" Inherits="InsFattura" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Inserisci Fattura</title>
</head>
<body>
    <form id="form1" runat="server">
     
         <div class="container py-5 mt-5">
        <div class="row d-flex justify-content-center align-items-center">
            <div class="col-lg-8 col-xl-6">

                <div class="card-header  text-center">
                    <label>Scegli la Commessa</label>
                    <asp:DropDownList ID="DropDownList1" runat="server"></asp:DropDownList>
                </div>
                <div class="row">

                    <div class="col-sm-6">
                        <div class="card">
                            <div class="card-body">
                                <asp:Literal ID="ltlNumeroFattura" runat="server">Inserisci il numero della fattura</asp:Literal>
                                <asp:TextBox ID="txtNumeroFattura" runat="server"></asp:TextBox>
                            </div>
                        </div>
                    </div>

                    <div class="col-sm-6">
                        <div class="card">
                            <div class="card-body">
                                <asp:Literal ID="ltlDataFattura" runat="server">Inserisci la data della fattura</asp:Literal>
                                <asp:TextBox ID="txtDataFattura" runat="server"></asp:TextBox>
                            </div>
                        </div>
                    </div>
                     <div class="col-sm-6">
                        <div class="card">
                            <div class="card-body">
                                <asp:Literal ID="ltlImporto" runat="server">Inserisci l'importo della fattura</asp:Literal>
                                <asp:TextBox ID="txtImporto" runat="server"></asp:TextBox>
                            </div>
                        </div>
                    </div>

                    <div class="col-sm-6">
                        <div class="card">
                            <div class="card-body">
                                <asp:Literal ID="ltlAliquota" runat="server">Inserisci l'Aliquota</asp:Literal>
                                <asp:TextBox ID="txtRuolo" runat="server"></asp:TextBox>
                            </div>
                        </div>
                    </div>

                    <div class="col-sm-6">
                        <div class="card">
                            <div class="card-body">
                                <asp:Literal ID="ltlDescrizione" runat="server">Inserisci la descrizione</asp:Literal>
                                <asp:TextBox ID="txtDescrizione" runat="server"></asp:TextBox>
                            </div>
                        </div>
                    </div>

                    <div class="col-sm-6">
                        <div class="card">
                            <div class="card-body">
                                <asp:Literal ID="ltlDataSaldo" runat="server">Inserisci la data del saldo</asp:Literal>
                                <asp:TextBox ID="txtDataSaldo" runat="server"></asp:TextBox>
                            </div>
                        </div>
                    </div>

                    <div class="card-footer text-center">
                        <asp:Button ID="btnInserisci" runat="server" Text="Inserisci fattura" />
                    </div>

                </div>
            </div>

            <div class="mt-3">
                <asp:GridView ID="gridFatture" runat="server"></asp:GridView>
            </div>
        </div>
    </div>

    </form>
</body>
</html>
