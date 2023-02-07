<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ModificaDipendente.aspx.cs" Inherits="ModifcaDipendente" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Modifica Dipendente</title>
</head>
<body>
    <form id="form1" runat="server">

        <div class="container mt-5">
            <table class="mt-5 d-flex justify-content-center align-items-center">
                <tr>
                    <td class="justify-content-center align-items-center text-align-center">
                        <p></p>
                        <asp:GridView ID="GridView1" runat="server"></asp:GridView>
                        <asp:Button ID="Button1" runat="server" Text="ModifcaDipendete" />
                    </td>
                </tr>
            </table>
            <div class="container py-5 mt-5">
                <div class="row d-flex justify-content-center align-items-center">
                    <div class="col-lg-8 col-xl-6">

                        <div class="card-header  text-center">
                            <label>Scegli l'azienda per il nuovo dipendete</label>
                            <asp:DropDownList ID="DropDownList1" runat="server"></asp:DropDownList>
                        </div>
                        <div class="row">

                            <div class="col-sm-6">
                                <div class="card">
                                    <div class="card-body">
                                        <asp:Literal ID="ltlEMail" runat="server">Modifica l'EMail</asp:Literal>
                                        <asp:TextBox ID="txtEMail" runat="server"></asp:TextBox>
                                    </div>
                                </div>
                            </div>

                            <div class="col-sm-6">
                                <div class="card">
                                    <div class="card-body">
                                        <asp:Literal ID="ltlPwd" runat="server">Modifica la password</asp:Literal>
                                        <asp:TextBox ID="txtPwd" runat="server"></asp:TextBox>
                                    </div>
                                </div>
                            </div>
                            <div class="col-sm-6">
                                <div class="card">
                                    <div class="card-body">
                                        <asp:Literal ID="ltlA_N" runat="server">Abilita/Disabilita dipendete (A/N)</asp:Literal>
                                        <asp:TextBox ID="txtA_N" runat="server"></asp:TextBox>
                                    </div>
                                </div>
                            </div>

                            <div class="col-sm-6">
                                <div class="card">
                                    <div class="card-body">
                                        <asp:Literal ID="ltlRuolo" runat="server">Modifica il ruolo del dipendete (U,O,A,E)</asp:Literal>
                                        <asp:TextBox ID="txtRuolo" runat="server"></asp:TextBox>
                                    </div>
                                </div>
                            </div>

                            <div class="col-sm-6">
                                <div class="card">
                                    <div class="card-body">
                                        <asp:Literal ID="ltlCognome" runat="server">Modifica il Cognome</asp:Literal>
                                        <asp:TextBox ID="txtCognome" runat="server"></asp:TextBox>
                                    </div>
                                </div>
                            </div>

                            <div class="col-sm-6">
                                <div class="card">
                                    <div class="card-body">
                                        <asp:Literal ID="ltlNome" runat="server">Modifica il Nome</asp:Literal>
                                        <asp:TextBox ID="txtNome" runat="server"></asp:TextBox>
                                    </div>
                                </div>
                            </div>

                            <div class="col-sm-6">
                                <div class="card">
                                    <div class="card-body">
                                        <asp:Literal ID="ltlIndirizzo" runat="server">Modifica l'Indirizzo</asp:Literal>
                                        <asp:TextBox ID="txtIndirizzo" runat="server"></asp:TextBox>
                                    </div>
                                </div>
                            </div>


                            <div class="col-sm-6">
                                <div class="card">
                                    <div class="card-body">
                                        <asp:Literal ID="ltlCitta" runat="server">Modifica la Città</asp:Literal>
                                        <asp:TextBox ID="txtCitta" runat="server"></asp:TextBox>
                                    </div>
                                </div>
                            </div>

                            <div class="col-sm-6">
                                <div class="card">
                                    <div class="card-body">
                                        <asp:Literal ID="ltlCap" runat="server">Modifica il CAP</asp:Literal>
                                        <asp:TextBox ID="txtCap" runat="server"></asp:TextBox>
                                    </div>
                                </div>
                            </div>

                            <div class="col-sm-6">
                                <div class="card">
                                    <div class="card-body">
                                        <asp:Literal ID="ltlPtovincia" runat="server">Modifica la Provincia</asp:Literal>
                                        <asp:TextBox ID="txtProvincia" runat="server"></asp:TextBox>
                                    </div>
                                </div>
                            </div>

                            <div class="col-sm-6">
                                <div class="card">
                                    <div class="card-body">
                                        <asp:Literal ID="ltlTelefono" runat="server">Modifica il Telefono</asp:Literal>
                                        <asp:TextBox ID="txtTelefono" runat="server"></asp:TextBox>
                                    </div>
                                </div>
                            </div>

                            <div class="col-sm-6">
                                <div class="card">
                                    <div class="card-body">
                                        <asp:Literal ID="ltlCostoOrario" runat="server">Modifica il Costo Orario</asp:Literal>
                                        <asp:TextBox ID="txtCostoOrario" runat="server"></asp:TextBox>
                                    </div>
                                </div>
                            </div>

                            <div class="col-sm-6">
                                <div class="card">
                                    <div class="card-body">
                                        <asp:Literal ID="ltlDataInizio" runat="server">Modifica la data di inizio rapporto</asp:Literal>
                                        <asp:TextBox ID="txtDataInizio" runat="server"></asp:TextBox>
                                    </div>
                                </div>
                            </div>

                            <div class="col-sm-6">
                                <div class="card">
                                    <div class="card-body">
                                        <asp:Literal ID="ltlDataFine" runat="server">Modifica la data di fine rapporto</asp:Literal>
                                        <asp:TextBox ID="txtDataFine" runat="server"></asp:TextBox>
                                    </div>
                                </div>
                            </div>



                            <div class="card-footer text-center">
                                <asp:Button ID="Button2" runat="server" Text="Modifica azienda" />
                            </div>

                        </div>
                    </div>
                </div>
            </div>
        </div>

    </form>
</body>
</html>
