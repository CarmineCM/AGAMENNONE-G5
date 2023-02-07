﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ModificaReferente.aspx.cs" Inherits="COMMESSE_ModificaRefente" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Modifica Referente</title>
</head>
<body>
    <form id="form1" runat="server">
        
        <div class="container py-5 mt-5">
        <div class="row d-flex justify-content-center align-items-center">
            <div class="col-lg-8 col-xl-6">

                <div class="card-header  text-center">
                    <label>Scegli il Cliente</label>
                    <asp:DropDownList ID="ddlClienti" runat="server"></asp:DropDownList>
                </div>
                <div class="row">

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
                                <asp:Literal ID="ltlEMail" runat="server">Modifica l'EMail</asp:Literal>
                                <asp:TextBox ID="txtEMail" runat="server"></asp:TextBox>
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


                    <div class="card-footer text-center">
                        <asp:Button ID="btnModifica" runat="server" Text="Modifica referente" />
                    </div>

                </div>
            </div>

            <div class="mt-3">
                <asp:GridView ID="gridReferenti" runat="server"></asp:GridView>
            </div>
        </div>
    </div>
    </div>

    </form>
</body>
</html>
