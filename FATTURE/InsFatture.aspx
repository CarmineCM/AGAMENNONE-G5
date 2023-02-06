<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="InsFatture.aspx.cs" Inherits="insFatture" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

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
                        <asp:Button ID="Button1" runat="server" Text="Inserisci fattura" />
                    </div>

                </div>
            </div>

            <div class="mt-3">
                <asp:GridView ID="GridView1" runat="server"></asp:GridView>
            </div>
        </div>
    </div>

</asp:Content>

