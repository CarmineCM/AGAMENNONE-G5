<%@ Page Language="C#" AutoEventWireup="true" CodeFile="InsLavoro.aspx.cs" Inherits="LAVORO_InsLavoro" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Inserisci Lavoro</title>
</head>
<body>
    <form id="form1" runat="server">

        <div class="container py-5 mt-5">
            <div class="row d-flex justify-content-center align-items-center">
                <div class="col-lg-8 col-xl-6">
                    <div class="card-header  text-center">
                        <label>Scegli la Commessa</label>
                        <asp:DropDownList ID="ddlCommesse" runat="server"></asp:DropDownList>
                    </div>
                    <div class="row">
                        <div class="col-sm-6">
                            <label>Scegli il Dipendete</label>
                            <asp:DropDownList ID="ddlDipendenti" runat="server"></asp:DropDownList>
                        </div>
                        <div class="card">
                            <div class="card-body">
                                <asp:Literal ID="ltlDataOra" runat="server">Inserisci la data e l'ora</asp:Literal>
                                <asp:TextBox ID="txtDataOra" runat="server"></asp:TextBox>
                            </div>
                        </div>
                    </div>

                    <div class="col-sm-6">
                        <div class="card">
                            <div class="card-body">
                                <asp:Literal ID="ltlOre" runat="server">Inserisci le ore lavorate</asp:Literal>
                                <asp:TextBox ID="txtOre" runat="server"></asp:TextBox>
                            </div>
                        </div>
                    </div>
                    <div class="col-sm-6">
                        <div class="card">
                            <div class="card-body">
                                <asp:Literal ID="ltlDescrizione" runat="server">Descrizione</asp:Literal>
                                <asp:TextBox ID="txtDescrizione" runat="server"></asp:TextBox>
                            </div>
                        </div>
                    </div>

                    <div class="col-sm-6">
                        <div class="card">
                            <div class="card-body">
                                <asp:Literal ID="ltlPernottamento" runat="server">Pernottamento</asp:Literal>
                                <asp:TextBox ID="txtPernottamento" runat="server"></asp:TextBox>
                            </div>
                        </div>
                    </div>

                    <div class="col-sm-6">
                        <div class="card">
                            <div class="card-body">
                                <asp:Literal ID="ltlPasti" runat="server">Pasti</asp:Literal>
                                <asp:TextBox ID="txtPasti" runat="server"></asp:TextBox>
                            </div>
                        </div>
                    </div>

                    <div class="col-sm-6">
                        <div class="card">
                            <div class="card-body">
                                <asp:Literal ID="ltlKm" runat="server">Inserisci il KM</asp:Literal>
                                <asp:TextBox ID="txtKm" runat="server"></asp:TextBox>
                            </div>
                        </div>
                    </div>

                    <div class="col-sm-6">
                        <div class="card">
                            <div class="card-body">
                                <asp:Literal ID="ltlPedaggi" runat="server">Inserisci pedaggio</asp:Literal>
                                <asp:TextBox ID="txtPedaggi" runat="server"></asp:TextBox>
                            </div>
                        </div>
                    </div>


                    <div class="col-sm-6">
                        <div class="card">
                            <div class="card-body">
                                <asp:Literal ID="ltlMezzi" runat="server">Mezzi di trasporto</asp:Literal>
                                <asp:TextBox ID="txtMEzzi" runat="server"></asp:TextBox>
                            </div>
                        </div>
                    </div>

                    <div class="col-sm-6">
                        <div class="card">
                            <div class="card-body">
                                <asp:Literal ID="ltlSpeseExtra" runat="server">Inserisci le Spese Extra</asp:Literal>
                                <asp:TextBox ID="txtSpeseExtra" runat="server"></asp:TextBox>
                            </div>
                        </div>
                    </div>

                    <div class="col-sm-6">
                        <div class="card">
                            <div class="card-body">
                                <asp:Literal ID="ltlDescrizioneSP" runat="server">Descrizione Spesa Extra</asp:Literal>
                                <asp:TextBox ID="txtDescrizioneSP" runat="server"></asp:TextBox>
                            </div>
                        </div>
                    </div>



                    <div class="card-footer text-center">
                        <asp:Button ID="btnInserisci" runat="server" Text="Inserisci lavoro" />
                    </div>

                    </div>
                </div>

                <div class="mt-3">
                    <asp:GridView ID="gridLavoro" runat="server"></asp:GridView>
                </div>
            </div>
       

    </form>
</body>
</html>
