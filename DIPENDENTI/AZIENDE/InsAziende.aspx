<%@ Page Language="C#" AutoEventWireup="true" CodeFile="InsAziende.aspx.cs" Inherits="InsAzienda" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Inserisci Azienda</title>
</head>
<body>
    <form id="form1" runat="server">

        <div class="container py-5 mt-5">
            <div class="row d-flex justify-content-center align-items-center">
                <div class="col-lg-8 col-xl-6">

                    <div class="card-header  text-center">
                        <label>Inserisci Azienda</label>
                    </div>
                    <div class="row">
                        <div class="col-sm-6">
                            <div class="card">
                                <div class="card-body">
                                    <asp:Literal ID="ltlRagioneSociale" runat="server">Inserisci la Ragione Sociale</asp:Literal>
                                    <asp:TextBox ID="txtRagioneSociale" runat="server"></asp:TextBox>
                                </div>
                            </div>
                        </div>

                        <div class="col-sm-6">
                            <div class="card">
                                <div class="card-body">
                                    <asp:Literal ID="ltlIndirizzo" runat="server">Inserisci l'indirizzo</asp:Literal>
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
                                    <asp:Literal ID="ltlCap" runat="server">Inserisci il cap</asp:Literal>
                                    <asp:TextBox ID="txtCap" runat="server"></asp:TextBox>
                                </div>
                            </div>
                        </div>

                        <div class="col-sm-6">
                            <div class="card">
                                <div class="card-body">
                                    <asp:Literal ID="ltlProvincia" runat="server">Inserisci la provincia</asp:Literal>
                                    <asp:TextBox ID="txtProvincia" runat="server"></asp:TextBox>
                                </div>
                            </div>
                        </div>

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
                                    <asp:Literal ID="ltlTelefono" runat="server">Inserisci il telefono</asp:Literal>
                                    <asp:TextBox ID="txtTelefono" runat="server"></asp:TextBox>
                                </div>
                            </div>
                        </div>

                        <div class="col-sm-6">
                            <div class="card">
                                <div class="card-body">
                                    <asp:Literal ID="ltlCodiceFiscale" runat="server">Inserisci il Codice Fiscale</asp:Literal>
                                    <asp:TextBox ID="txtCodiceFiscale" runat="server"></asp:TextBox>
                                </div>
                            </div>
                        </div>

                        <div class="col-sm-6">
                            <div class="card">
                                <div class="card-body">
                                    <asp:Literal ID="ltlPartitaIVA" runat="server">Inserisci la Partita IVA</asp:Literal>
                                    <asp:TextBox ID="txtPartivaIVA" runat="server"></asp:TextBox>
                                </div>
                            </div>
                        </div>

                        <div class="col-sm-6">
                            <div class="card">
                                <div class="card-body">
                                    <asp:Literal ID="ltlPEC" runat="server">Inserisci la PEC</asp:Literal>
                                    <asp:TextBox ID="txtPEC" runat="server"></asp:TextBox>
                                </div>
                            </div>
                        </div>

                        <div class="col-sm-6">
                            <div class="card">
                                <div class="card-body">
                                    <asp:Literal ID="ltlCFE" runat="server">Inserisci il CFE</asp:Literal>
                                    <asp:TextBox ID="txtCFE" runat="server"></asp:TextBox>
                                </div>
                            </div>
                        </div>

                        <div class="col-sm-6">
                            <div class="card">
                                <div class="card-body">
                                    <asp:Literal ID="ltlTitolare" runat="server">Inserisci il titolare</asp:Literal>
                                    <asp:TextBox ID="txtTitolare" runat="server"></asp:TextBox>
                                </div>
                            </div>
                        </div>

                        <div class="col-sm-6">
                            <div class="card">
                                <div class="card-body">
                                    <asp:Literal ID="ltlEMailTitolare" runat="server">Inserisci l'EMail del titolare</asp:Literal>
                                    <asp:TextBox ID="txtEMailTitolare" runat="server"></asp:TextBox>
                                </div>
                            </div>
                        </div>

                        <div class="col-sm-6">
                            <div class="card">
                                <div class="card-body">
                                    <asp:Literal ID="ltlTelTitolare" runat="server">Inserisci el telefono del titolare</asp:Literal>
                                    <asp:TextBox ID="txtTelTitolare" runat="server"></asp:TextBox>
                                </div>
                            </div>
                        </div>

                        <div class="card-footer text-center">
                            <asp:Button ID="BtnInserisciAzienda" runat="server" Text="Inserisci azienda" OnClick="BtnInserisciAzienda_Click" />
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
