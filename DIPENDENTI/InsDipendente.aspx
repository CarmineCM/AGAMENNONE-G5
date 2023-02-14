<%@ Page Language="C#" AutoEventWireup="true" CodeFile="InsDipendente.aspx.cs" Inherits="InsDipendente" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Inserisci Dipendente</title>
     <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-1BmE4kWBq78iYhFldvKuhfTAU6auU8tT94WrHftjDbrCEXSU1oBoqyl2QvZ6jIW3" crossorigin="anonymous" />
</head>
<body>
    <form id="form1" runat="server">

        <div class="container py-5 mt-5">
            <div class="row d-flex justify-content-center align-items-center">
                <div class="col-lg-8 col-xl-6">

                    <div class="card-header  text-center">
                        <label>Scegli l'azienda per il nuovo dipendete</label>
                        <asp:DropDownList ID="ddlAzienda" runat="server" DataSourceID="SDSDIPENDENTE" DataTextField="RAGIONESOCIALE" DataValueField="chiave"></asp:DropDownList>
                        <asp:SqlDataSource ID="SDSDIPENDENTE" runat="server" ConnectionString="<%$ ConnectionStrings:AGAMENNONEConnectionString %>" SelectCommand="spAZIENDE_SelectAll_DDL" SelectCommandType="StoredProcedure">
                        </asp:SqlDataSource>
                    </div>
                    <div class="row">

                        <div class="col-sm-6">
                            <div class="card">
                                <div class="card-body">
                                    <asp:Literal ID="ltlEMail" runat="server">Inserisci l'EMail</asp:Literal>
                                    <asp:TextBox ID="txtEMail" runat="server"></asp:TextBox>
                                </div>
                            </div>
                        </div>

                        <div class="col-sm-6">
                            <div class="card">
                                <div class="card-body">
                                    <asp:Literal ID="ltlPwd" runat="server">Inserisci la password</asp:Literal>
                                    <asp:TextBox ID="txtPwd" runat="server" TextMode="Password"></asp:TextBox>
                                </div>
                            </div>
                        </div>
                       
                        <div class="col-sm-6">
                            <div class="card">
                                <div class="card-body">
                                    <asp:Literal ID="ltlA_N" runat="server">Abilita/Disabilita dipendete (A/N)</asp:Literal>
                                    <asp:DropDownList ID="ddlAbilita" runat="server">
                                        <asp:ListItem Value="True">ABILITA</asp:ListItem>
                                        <asp:ListItem Value="False">Disabilita</asp:ListItem>
                                    </asp:DropDownList>
                                </div>
                            </div>
                        </div>
                        
                            <div class="col-sm-6">
                            <div class="card">
                                <div class="card-body">
                                    <asp:Literal ID="ltlPrimoAccesso" runat="server">Primo Accesso</asp:Literal>
                                    <asp:DropDownList ID="ddlPrimoAccesso" runat="server">
                                        <asp:ListItem Value="True">Si</asp:ListItem>
                                        <asp:ListItem Value="False">No</asp:ListItem>
                                    </asp:DropDownList>
                                </div>
                            </div>
                        </div>

                        <div class="col-sm-6">
                            <div class="card">
                                <div class="card-body">
                                    <asp:Literal ID="ltlRuolo" runat="server">Inserisci il ruolo del dipendete (U,O,A,E)</asp:Literal>
                                    <asp:DropDownList ID="ddlRuolo" runat="server">
                                        <asp:ListItem Value="A">Admin</asp:ListItem>
                                        <asp:ListItem Value="O">Operatore</asp:ListItem>
                                        <asp:ListItem Value="U">Utente Interno</asp:ListItem>
                                        <asp:ListItem Value="E">Utente Esterno</asp:ListItem>
                                    </asp:DropDownList>
                                </div>
                            </div>
                        </div>

                        <div class="col-sm-6">
                            <div class="card">
                                <div class="card-body">
                                    <asp:Literal ID="ltlCognome" runat="server">Inserisci il Cognome</asp:Literal>
                                    <asp:TextBox ID="txtCognome" runat="server"></asp:TextBox>
                                </div>
                            </div>
                        </div>

                        <div class="col-sm-6">
                            <div class="card">
                                <div class="card-body">
                                    <asp:Literal ID="ltlNome" runat="server">Inserisci il Nome</asp:Literal>
                                    <asp:TextBox ID="txtNome" runat="server"></asp:TextBox>
                                </div>
                            </div>
                        </div>

                        <div class="col-sm-6">
                            <div class="card">
                                <div class="card-body">
                                    <asp:Literal ID="ltlIndirizzo" runat="server">Inserisci l'Indirizzo</asp:Literal>
                                    <asp:TextBox ID="txtIndirizzo" runat="server"></asp:TextBox>
                                </div>
                            </div>
                        </div>

                        <div class="col-sm-6">
                            <div class="card">
                                <div class="card-body">
                                    <asp:Literal ID="ltlCitta" runat="server">Inserisci la Città</asp:Literal>
                                    <asp:TextBox ID="txtCitta" runat="server"></asp:TextBox>
                                </div>
                            </div>
                        </div>

                        <div class="col-sm-6">
                            <div class="card">
                                <div class="card-body">
                                    <asp:Literal ID="ltlCap" runat="server">Inserisci il CAP</asp:Literal>
                                    <asp:TextBox ID="txtCap" runat="server" max="99999"  MaxLength="5"></asp:TextBox>
                                </div>
                            </div>
                        </div>

                        <div class="col-sm-6">
                            <div class="card">
                                <div class="card-body">
                                    <asp:Literal ID="ltlPtovincia" runat="server">Inserisci la Provincia</asp:Literal>
                                    <asp:TextBox ID="txtProvincia" runat="server" MaxLength="2"></asp:TextBox>
                                </div>
                            </div>
                        </div>

                        <div class="col-sm-6">
                            <div class="card">
                                <div class="card-body">
                                    <asp:Literal ID="ltlTelefono" runat="server">Inserisci il Telefono</asp:Literal>
                                    <asp:TextBox ID="txtTelefono" runat="server"></asp:TextBox>
                                </div>
                            </div>
                        </div>

                        <div class="col-sm-6">
                            <div class="card">
                                <div class="card-body">
                                    <asp:Literal ID="ltlCostoOrario" runat="server">Inserisci il Costo Orario</asp:Literal>
                                    <asp:TextBox ID="txtCostoOrario" runat="server" TextMode="Number"></asp:TextBox>
                                </div>
                            </div>
                        </div>

                        <div class="col-sm-6">
                            <div class="card">
                                <div class="card-body">
                                    <asp:Literal ID="ltlDataInizio" runat="server">Inserisci la data di inizio rapporto</asp:Literal>
                                    <asp:TextBox ID="txtDataInizio" runat="server" TextMode="Date"></asp:TextBox>
                                </div>
                            </div>
                        </div>

                        <div class="col-sm-6">
                            <div class="card">
                                <div class="card-body">
                                    <asp:Literal ID="ltlDataFine" runat="server">Inserisci la data di fine rapporto</asp:Literal>
                                    <asp:TextBox ID="txtDataFine" runat="server" TextMode="Date"></asp:TextBox>
                                </div>
                            </div>
                        </div>
                        
                        <div class="card-footer text-center">
                            <asp:Button ID="btnDipendente" runat="server" Text="Inserisci azienda" OnClick="btnDipendente_Click"  />
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </form>
</body>
</html>