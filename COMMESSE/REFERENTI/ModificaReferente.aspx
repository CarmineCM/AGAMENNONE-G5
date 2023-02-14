<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ModificaReferente.aspx.cs" Inherits="COMMESSE_ModificaRefente" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Modifica Referente</title>
     <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-1BmE4kWBq78iYhFldvKuhfTAU6auU8tT94WrHftjDbrCEXSU1oBoqyl2QvZ6jIW3" crossorigin="anonymous" />
</head>
<body>
    <form id="form1" runat="server">

        <h2 class="text-center">MODIFICA DATI</h2>

        <!-- DROPDOWNLIST -->
        <div class="container px-4">
            <div class="row gx-5">
                <div class="col">
                    <div class="p-3">
                        <asp:Label ID="lbScegliCliente" runat="server" Text="SCEGLI CLIENTE" class="control-label col-sm-4"></asp:Label>
                    </div>
                </div>
                <div class="col">
                    <div class="p-3">
                        <asp:DropDownList ID="ddlClienti" runat="server" DataSourceID="SDSClientimod" DataTextField="RAGIONESOCIALE" DataValueField="chiave"></asp:DropDownList>
                        <asp:SqlDataSource ID="SDSClientimod" runat="server" ConnectionString="<%$ ConnectionStrings:AGAMENNONEConnectionString %>" SelectCommand="spCLIENTI_SelectAll_DDL" SelectCommandType="StoredProcedure"></asp:SqlDataSource>
                    </div>
                </div>
            </div>
        </div>

        <!-- COMPILAZIONE CAMPI -->
        <div class="container" runat="server">
            <div class="row g-2">
                <!-- COGNOME -->
                <div class="col-6">
                    <div class="p-3">
                        <asp:Label ID="lbCognome" runat="server" Text="COGNOME"></asp:Label>
                        <asp:TextBox ID="txtCognome" runat="server"></asp:TextBox>
                    </div>
                </div>

                <!-- NOME -->
                <div class="col-6">
                    <div class="p-3">
                        <asp:Label ID="lbNome" runat="server" Text="NOME"></asp:Label>
                        <asp:TextBox ID="txtNome" runat="server"></asp:TextBox>
                    </div>
                </div>

                <!-- EMAIL -->
                <div class="col-6">
                    <div class="p-3">
                        <asp:Label ID="lbEmail" runat="server" Text="EMAIL"></asp:Label>
                        <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
                    </div>
                </div>

                <!-- TELEFONO -->
                <div class="col-6">
                    <div class="p-3">
                        <asp:Label ID="lbTelefono" runat="server" Text="TELEFONO"></asp:Label>
                        <asp:TextBox ID="txtTelefono" runat="server"></asp:TextBox>
                    </div>
                </div>
            </div>
        </div>

        <!-- BOTTONE MODIFICA -->

        <div class="d-grid gap-2 col-6 mx-auto">
            <asp:Button ID="btnModifica" class="btn btn-primary" runat="server" Text="MODIFICA DATI" OnClick="btnModifica_Click" />
        </div>
    </form>
</body>
</html>
