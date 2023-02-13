<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ModificaClienti.aspx.cs" Inherits="ModifcaClienti" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Modifica Clienti</title>
     <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-1BmE4kWBq78iYhFldvKuhfTAU6auU8tT94WrHftjDbrCEXSU1oBoqyl2QvZ6jIW3" crossorigin="anonymous" />
</head>
<body>
    <form id="form1" runat="server">
      <h2 class="text-center">MODIFICA CLIENTE</h2>

        <!-- RAGIONE SOCIALE -->
        <div class="container px-4">
            <div class="row gx-5">
                <div class="col">
                    <div class="p-3">
                        <asp:Label ID="lbRagioneSociale" runat="server">Ragione Sociale:</asp:Label>
                        <asp:TextBox ID="txtRS" runat="server"></asp:TextBox>
                    </div>
                </div>
            </div>
        </div>

        <!-- COMPILAZIONE CAMPI -->
        <div class="container" runat="server">
            <div class="row g-2">
                <!-- INDIRIZZO -->
                <div class="col-6">
                    <div class="p-3">
                        <asp:Label ID="lbIndirizzo" runat="server" Text="Indirizzo"></asp:Label>
                        <asp:TextBox ID="txtIndirizzo" runat="server"></asp:TextBox>
                    </div>
                </div>
                <!-- CITTA -->
                <div class="col-6">
                    <div class="p-3">
                        <asp:Label ID="lbCItta" runat="server" Text="Città"></asp:Label>
                        <asp:TextBox ID="txtCitta" runat="server"></asp:TextBox>
                    </div>
                </div>
                <!-- PROVINCIA -->
                <div class="col-6">
                    <div class="p-3">
                        <asp:Label ID="lbProvincia" runat="server" Text="Provincia"></asp:Label>
                        <asp:TextBox ID="txtProvincia" runat="server"></asp:TextBox>
                    </div>
                </div>
                <!-- CAP -->
                <div class="col-6">
                    <div class="p-3">
                        <asp:Label ID="lbCap" runat="server" Text="Cap"></asp:Label>
                        <asp:TextBox ID="txtCap" runat="server"></asp:TextBox>
                    </div>
                </div>
            </div>
        </div>

        <!--SECONDO BLOCCO-->
        <div class="container" runat="server">
            <div class="row g-2">
                <!-- EMAIL -->
                <div class="col-6">
                    <div class="p-3">
                        <asp:Label ID="lbEmail" runat="server" Text="Email"></asp:Label>
                        <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
                    </div>
                </div>
                <!-- TELEFONO -->
                <div class="col-6">
                    <div class="p-3">
                        <asp:Label ID="lbTelefono" runat="server" Text="Telefono"></asp:Label>
                        <asp:TextBox ID="txtTelefono" runat="server"></asp:TextBox>
                    </div>
                </div>
                <!-- CODICE FISCALE -->
                <div class="col-6">
                    <div class="p-3">
                        <asp:Label ID="lbCodiceFiscale" runat="server" Text="Codice Fiscale"></asp:Label>
                        <asp:TextBox ID="txtCodiceFiscale" runat="server"></asp:TextBox>
                    </div>
                </div>
                <!-- PARTITA IVA -->
                <div class="col-6">
                    <div class="p-3">
                        <asp:Label ID="lbIVA" runat="server" Text="Partita IVA"></asp:Label>
                        <asp:TextBox ID="txtIVA" runat="server"></asp:TextBox>
                    </div>
                </div>
            </div>
        </div>

        <!--TERZO BLOCCO-->
        <div class="container" runat="server">
            <div class="row g-3">
                <!-- CFE -->
                <div class="col-6">
                    <div class="p-3">
                        <asp:Label ID="lbCFE" runat="server" Text="CFE"></asp:Label>
                        <asp:TextBox ID="txtCFE" runat="server"></asp:TextBox>
                    </div>
                </div>
                <!-- PEC -->
                <div class="col-6">
                    <div class="p-3">
                        <asp:Label ID="lbPEC" runat="server" Text="PEC"></asp:Label>
                        <asp:TextBox ID="txtPEC" runat="server"></asp:TextBox>
                    </div>
                </div>
                <!-- NOME TITOLARE -->
                <div class="col-6">
                    <div class="p-3">
                        <asp:Label ID="lbTitolare" runat="server" Text="Nome Titolare"></asp:Label>
                        <asp:TextBox ID="txtNomeTitolare" runat="server"></asp:TextBox>
                    </div>
                </div>
                <!-- EMAIL TITOLARE -->
                <div class="col-6">
                    <div class="p-3">
                        <asp:Label ID="lbEmailTitolare" runat="server" Text="Email Titolare"></asp:Label>
                        <asp:TextBox ID="txtEmailTitolare" runat="server"></asp:TextBox>
                    </div>
                </div>
            </div>
        </div>

        <!-- QUARTO BLOCCO -->
        <div class="container" runat="server">
            <div class="row g-4">
                <!-- NUMERO TITOLARE -->
                <div class="col-6">
                    <div class="p-3">
                        <asp:Label ID="lbNumeroTitolare" runat="server" Text="Numero Telefono Titolare"></asp:Label>
                        <asp:TextBox ID="txtNumeroTitolare" runat="server"></asp:TextBox>
                    </div>
                </div>
            </div>
        </div>

        <!-- BOTTONE MODIFICA -->
        <div class="d-grid gap-2 col-6 mx-auto">
            <asp:Button ID="btnClienti" class="btn btn-primary" runat="server" Text="Modifica Cliente" OnClick="btnClienti_Click" />
        </div>
    </form>
</body>
</html>