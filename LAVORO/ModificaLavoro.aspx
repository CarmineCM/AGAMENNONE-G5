<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ModificaLavoro.aspx.cs" Inherits="LAVORO_ModificaLavoro" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Modifica Lavoro</title>
     <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-1BmE4kWBq78iYhFldvKuhfTAU6auU8tT94WrHftjDbrCEXSU1oBoqyl2QvZ6jIW3" crossorigin="anonymous" />
</head>
<body>
    <form id="form1" runat="server">
        
        <h2 class="text-center">INSERISCI LAVORO</h2>

        <!-- DROPDOWNLIST COMMESSA-->
        <div class="container px-4">
            <div class="row gx-5">
                <div class="col">
                    <div class="p-3">
                        <asp:Label ID="lbScegliCommessa" runat="server" Text="Scegli Commessa"></asp:Label>
                    </div>
                </div>
                <div class="col">
                    <div class="p-3">
                        <asp:DropDownList ID="ddlCommesse" runat="server"></asp:DropDownList>
                    </div>
                </div>
            </div>
        </div>

        <!-- DROPDOWNLIST DIPENDENTI-->
        <div class="container px-4">
            <div class="row gx-5">
                <div class="col">
                    <div class="p-3">
                        <asp:Label ID="lbDipendenti" runat="server" Text="Scegli Dipendenti"></asp:Label>
                    </div>
                </div>
                <div class="col">
                    <div class="p-3">
                        <asp:DropDownList ID="ddlDipendenti" runat="server"></asp:DropDownList>
                    </div>
                </div>
            </div>
        </div>

        <!-- COMPILAZIONE CAMPI -->
        <div class="container" runat="server">
            <div class="row g-2">
                <!-- DATA E ORA -->
                <div class="col-6">
                    <div class="p-3">
                        <asp:Label ID="lbDataOra" runat="server" Text="Data e Ora"></asp:Label>
                        <asp:TextBox ID="txtDataOra" runat="server" TextMode="DateTime"></asp:TextBox>
                    </div>
                </div>

                <!-- ORE LAVORATE -->
                <div class="col-6">
                    <div class="p-3">
                        <asp:Label ID="lbOreLavorate" runat="server" Text="Ore Lavorate"></asp:Label>
                        <asp:TextBox ID="txtOreLavorate" runat="server" TextMode="Time" Height="36px" Width="149px"></asp:TextBox>
                    </div>
                </div>

                <!-- PERNOTTAMENTO -->
                <div class="col-6">
                    <div class="p-3">
                        <asp:Label ID="lbPernottamento" runat="server" Text="Pernottamento"></asp:Label>
                        <asp:TextBox ID="txtPernottamento" runat="server" Width="396px"></asp:TextBox>
                    </div>
                </div>
            </div>
        </div>

        <!-- DESCRIZIONE -->
        <div class="container px-4">
            <div class="row g-52">
                <div class="col-6">
                    <div class="p-3">
                        <asp:Label ID="lbDescrizione" runat="server" Text="Descrizione"></asp:Label>
                        <asp:TextBox ID="txtDescrizione" runat="server" Height="39px" Width="418px"></asp:TextBox>
                    </div>
                </div>
            </div>
        </div>

        <!--SECONDO BLOCCO-->
        <div class="container" runat="server">
            <div class="row g-2">
                <!-- PASTI -->
                <div class="col-6">
                    <div class="p-3">
                        <asp:Label ID="lbPasti" runat="server" Text="Pasti"></asp:Label>
                        <asp:TextBox ID="txtPasti" runat="server"></asp:TextBox>
                    </div>
                </div>
                <!-- KILOMETRI -->
                <div class="col-6">
                    <div class="p-3">
                        <asp:Label ID="lbKilometri" runat="server" Text="Kilometri"></asp:Label>
                        <asp:TextBox ID="txtKilometri" runat="server"></asp:TextBox>
                    </div>
                </div>
                <!-- PEDAGGIO -->
                <div class="col-6">
                    <div class="p-3">
                        <asp:Label ID="lbPedaggio" runat="server" Text="Pedaggio"></asp:Label>
                        <asp:TextBox ID="txtPedaggio" runat="server"></asp:TextBox>
                    </div>
                </div>
                <!-- MEZZI DI TRASPORTO -->
                <div class="col-6">
                    <div class="p-3">
                        <asp:Label ID="lbMezzi" runat="server" Text="Mezzi di trasporto"></asp:Label>
                        <asp:TextBox ID="txtMezzi" runat="server"></asp:TextBox>
                    </div>
                </div>
            </div>
        </div>

        <!--TERZO BLOCCO-->
        <div class="container" runat="server">
            <div class="row g-3">
                <!-- SPESE EXTRA -->
                <div class="col-6">
                    <div class="p-3">
                        <asp:Label ID="lbSpeseExtra" runat="server" Text="Spese Extra"></asp:Label>
                        <asp:TextBox ID="txtSpeseExtra" runat="server"></asp:TextBox>
                    </div>
                </div>

                <!-- DESCRIZIONE SPESE EXTRA -->
                <div class="col-6">
                    <div class="p-3">
                        <asp:Label ID="lbDescrizioneSpeseExtra" runat="server" Text="Descrizione Spese Extra"></asp:Label>
                        <asp:TextBox ID="txtDescrizioneSpeseExtra" runat="server"></asp:TextBox>
                    </div>
                </div>

                <!-- ACCETTAZIONE SPESE EXTRA -->
                <div class="col-6">
                    <div class="p-3">
                        <asp:Label ID="lbAccettazione" runat="server" Text="Accettzione Spese Extra"></asp:Label>
                        <asp:DropDownList ID="ddlAccettazione" runat="server"></asp:DropDownList>

                    </div>
                </div>
            </div>
        </div>
        <!-- BOTTONE INSERISCI LAVORO -->
        <div class="d-grid gap-2 col-6 mx-auto">
            <asp:Button ID="btnInsLavoro" class="btn btn-primary" runat="server" Text="Inserisci Lavoro" OnClick="btnInsLavoro_Click" />
        </div>
    </form>
</body>
</html>