<%@ Page Language="C#" AutoEventWireup="true" CodeFile="InsFattura.aspx.cs" Inherits="InsFattura" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Inserisci Fattura</title>
     <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-1BmE4kWBq78iYhFldvKuhfTAU6auU8tT94WrHftjDbrCEXSU1oBoqyl2QvZ6jIW3" crossorigin="anonymous" />
</head>
<body>
    <form id="form1" runat="server">

           <h2 class="text-center">INSERISCI FATTURE</h2>

        <!-- DROPDOWNLIST -->
        <div class="container px-4">
            <div class="row gx-5">
                <div class="col">
                    <div class="p-3">
                        <asp:Label ID="lbScegliCommessa" runat="server" Text="SCEGLI COMMESSA" class="control-label col-sm-4"></asp:Label>
                    </div>
                </div>
                <div class="col">
                    <div class="p-3">
                        <asp:DropDownList ID="ddlCommesssa" runat="server"></asp:DropDownList>
                    </div>
                </div>
            </div>
        </div>

        <!-- COMPILAZIONE CAMPI -->
        <div class="container" runat="server">
            <div class="row g-2">
                <!-- NUMERO FATTURA -->
                <div class="col-6">
                    <div class="p-3">
                        <asp:Label ID="lbNumFattura" runat="server" Text="Numero Fattura"></asp:Label>
                        <asp:TextBox ID="txtNumeroFattura" runat="server"></asp:TextBox>
                    </div>
                </div>

                <!-- DATA FATTURA -->
                <div class="col-6">
                    <div class="p-3">
                        <asp:Label ID="lbDataFattura" runat="server" Text="Data Fattura"></asp:Label>
                        <asp:TextBox ID="txtDataFattura" runat="server" TextMode="DateTime"></asp:TextBox>
                    </div>
                </div>

                <!-- IMPORTO FATTURA -->
                <div class="col-6">
                    <div class="p-3">
                        <asp:Label ID="lbImportoFattura" runat="server" Text="Importo Fattura"></asp:Label>
                        <asp:TextBox ID="txtImporto" runat="server"></asp:TextBox>
                    </div>
                </div>
                <!-- ALIQUOTA -->
                <div class="col-6">
                    <div class="p-3">
                        <asp:Label ID="lbAliquota" runat="server" Text="Aliquota"></asp:Label>
                        <asp:TextBox ID="txtAliquota" runat="server"></asp:TextBox>
                    </div>
                </div>
            </div>
        </div>
        <div class="container" runat="server">
            <div class="row g-2">
                <!-- DESCRIZIONE -->
                <div class="col-6">
                    <div class="p-3">
                        <asp:Label ID="lbDescrizione" runat="server" Text="Descrizione"></asp:Label>
                        <asp:TextBox ID="txtDescrizione" runat="server"></asp:TextBox>
                    </div>
                </div>

                <!-- DATA SALDO -->
                <div class="col-6">
                    <div class="p-3">
                        <asp:Label ID="lbSaldo" runat="server" Text="Data Saldo"></asp:Label>
                        <asp:TextBox ID="txtDataSaldo" runat="server"></asp:TextBox>
                    </div>
                </div>
            </div>
        </div>

        <!-- BOTTONE MODIFICA -->

        <div class="d-grid gap-2 col-6 mx-auto">
            <asp:Button ID="btnSalva" class="btn btn-primary" runat="server" Text="SALVA DATI" OnClick="btnSalva_Click" />
        </div>
    </form>
</body>
</html>