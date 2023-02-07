<%@ Page Language="C#" AutoEventWireup="true" CodeFile="InsClienti.aspx.cs" Inherits="InsClienti" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Inserisci Cliente</title>
</head>
<body>
    <form id="form1" runat="server">
        <section class="h-100 h-custom">
        <br />
        <div class="container py-5 mt-5">
            <div class="row d-flex justify-content-center align-items-center">
                <div class="col-lg-10 col-xl-10">
                    <div class="card">
                        <div class="card-body form-control">
                            <h3 class="card-title">Inserisci Cliente</h3>
                            <div class="row">
                                <div class="col-md-6">
                                    <div class="form-outline">
                                        <asp:Literal ID="Literal1" runat="server">Ragione Sociale:</asp:Literal>
                                        <asp:TextBox ID="txtRS" runat="server"></asp:TextBox>
                                    </div>
                                </div>
                            </div>
                            <br />
                            <div class="row">
                                <div class="col-md-6">
                                    <div class="form-outline">
                                        <asp:Literal ID="Literal2" runat="server">Indirizzo:</asp:Literal>
                                        <asp:TextBox ID="txtIndirizzo" runat="server"></asp:TextBox>
                                    </div>
                                </div>
                            </div>
                            <br />
                            <div class="row">
                                <div class="col-md-4">
                                    <div class="form-outline">
                                        <asp:Literal ID="Literal3" runat="server">Città:</asp:Literal>
                                        <asp:TextBox ID="txtCitta" runat="server"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="col-md-4">
                                    <div class="form-outline">
                                        <asp:Literal ID="Literal4" runat="server">CAP:</asp:Literal>
                                        <asp:TextBox ID="txtCAP" runat="server" max="99999" TextMode="Number"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="col-md-4">
                                    <div class="form-outline">
                                        <asp:Literal ID="Literal5" runat="server">Provincia:</asp:Literal>
                                        <asp:TextBox ID="txtProvincia" runat="server" MaxLength="2"></asp:TextBox>
                                    </div>
                                </div>
                            </div>
                            <br />
                            <div class="row">
                                <div class="col-md-6">
                                    <div class="form-outline">
                                        <asp:Literal ID="Literal6" runat="server">eMail:</asp:Literal>
                                        <asp:TextBox ID="txtMail" runat="server" TextMode="Email"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="col-md-6">
                                    <div class="form-outline">
                                        <asp:Literal ID="Literal7" runat="server">Telefono:</asp:Literal>
                                        <asp:TextBox ID="txtTelefono" runat="server" TextMode="Number"></asp:TextBox>
                                    </div>
                                </div>
                            </div>
                            <br />
                            <div class="row">
                                <div class="col-md-6">
                                    <div class="form-outline">
                                        <asp:Literal ID="Literal8" runat="server">Codice Fiscale:</asp:Literal>
                                        <asp:TextBox ID="txtCF" runat="server"></asp:TextBox>
                                    </div>
                                </div>
                            </div>
                            <br />
                            <div class="row">
                                <div class="col-md-6">
                                    <div class="form-outline">
                                        <asp:Literal ID="Literal9" runat="server">PIVA:</asp:Literal>
                                        <asp:TextBox ID="txtPIVA" runat="server"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="col-md-4">
                                    <div class="form-outline">
                                        <asp:Literal ID="Literal10" runat="server">CFE:</asp:Literal>
                                        <asp:TextBox ID="txtCFE" runat="server"></asp:TextBox>
                                    </div>
                                </div>
                            </div>
                            <br />
                            <div class="row">
                                <div class="col-md-6">
                                    <div class="form-outline">
                                        <asp:Literal ID="Literal11" runat="server">PEC:</asp:Literal>
                                        <asp:TextBox ID="txtPEC" runat="server"></asp:TextBox>
                                    </div>
                                </div>
                            </div>
                            <br />
                            <div class="row">
                                <div class="col-md-6">
                                    <div class="form-outline">
                                        <asp:Literal ID="Literal12" runat="server">Titolare:</asp:Literal>
                                        <asp:TextBox ID="txtTitolare" runat="server"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="col-md-5">
                                    <div class="form-outline">
                                        <asp:Literal ID="Literal13" runat="server">eMail Titolare:</asp:Literal>
                                        <asp:TextBox ID="txtEMailTitolare" runat="server" TextMode="Email"></asp:TextBox>
                                    </div>
                                </div>
                            </div>
                            <br />
                            <div class="row">
                                <div class="col-md-6">
                                    <div class="form-outline">
                                        <asp:Literal ID="Literal14" runat="server">Numero di telefono/i titolare:</asp:Literal>
                                        <asp:TextBox ID="txtTelefonoTitolare" runat="server" TextMode="Number"></asp:TextBox>
                                    </div>
                                </div>
                            </div>
                            <br />
                            <div class="row">
                                <div class="col-md-2">
                                    <div class="form-outline">
                                        <asp:Button ID="btnClienti" class="btn btn-primary" runat="server" Text="Aggiungi Cliente" />
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>
    </form>
</body>
</html>
