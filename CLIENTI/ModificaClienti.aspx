﻿<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="ModificaClienti.aspx.cs" Inherits="ModificaClienti" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <section class="h-100 h-custom">
        <br />
        <div class="container py-5 mt-5">
            <div class="row d-flex justify-content-center">
                <div class="col-lg-6 col-xl-6">
                    <%--Card per tabella clienti--%>
                    <div class="card">
                        <div class="card-body">
                            <%--Data Table con i dati dei clienti--%>
                            <h5>Seleziona Cliente:</h5>
                            <asp:GridView runat="server"></asp:GridView>
                            <%--Data Table con i dati dei clienti--%>
                        </div>
                    </div>
                    <%--Card per tabella clienti--%>
                </div>
                <div class="col-lg-6 col-xl-6">
                    <%--Card per modifica dati cliente--%>
                    <div class="card">
                        <div class="card-body">
                            <h5>Modifica dati:</h5>
                            <div class="row">
                                <div class="col-md-4 col-xl-4">
                                    <div class="form-outline">
                                        <asp:Literal ID="Literal1" runat="server">Ragione Sociale:</asp:Literal>
                                        <asp:TextBox ID="txtRS" runat="server"></asp:TextBox>
                                    </div>
                                </div>
                            </div>
                            <div class="row">
                                <div class="col-md-4 col-xl-4">
                                    <div class="form-outline">
                                        <asp:Literal ID="Literal2" runat="server">Indirizzo:</asp:Literal>
                                        <asp:TextBox ID="txtIndirizzo" runat="server"></asp:TextBox>
                                    </div>
                                </div>
                            </div>
                            <div class="row">
                                <div class="col-md-4 col-xl-4">
                                    <div class="form-outline">
                                        <asp:Literal ID="Literal3" runat="server">Città:</asp:Literal>
                                        <asp:TextBox ID="txtCitta" runat="server"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="col-md-5 col-xl-5">
                                    <div class="form-outline">
                                        <asp:Literal ID="Literal4" runat="server">CAP:</asp:Literal>
                                        <asp:TextBox ID="txtCAP" runat="server" MaxLength="5" max="99999"></asp:TextBox>
                                    </div>
                                </div>
                            </div>
                            <div class="row">
                                <div class="col-md-4 col-xl-4">
                                    <div class="form-outline">
                                        <asp:Literal ID="Literal5" runat="server">Provincia:</asp:Literal>
                                        <asp:TextBox ID="txtProvincia" runat="server" MaxLength="2"></asp:TextBox>
                                    </div>
                                </div>
                            </div>
                            <div class="row">
                                <div class="col-md-4 col-xl-4">
                                    <div class="form-outline">
                                        <asp:Literal ID="Literal6" runat="server">eMail:</asp:Literal>
                                        <asp:TextBox ID="txtMail" runat="server" TextMode="Email"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="col-md-5 col-xl-5">
                                    <div class="form-outline">
                                        <asp:Literal ID="Literal7" runat="server">Telefono:</asp:Literal>
                                        <asp:TextBox ID="txtTelefono" runat="server" TextMode="Number"></asp:TextBox>
                                    </div>
                                </div>
                            </div>
                            <div class="row">
                                <div class="col-md-4 col-xl-4">
                                    <div class="form-outline">
                                        <asp:Literal ID="Literal8" runat="server">Codice Fiscale:</asp:Literal>
                                        <asp:TextBox ID="txtCF" runat="server"></asp:TextBox>
                                    </div>
                                </div>
                            </div>
                            <div class="row">
                                <div class="col-md-4 col-xl-4">
                                    <div class="form-outline">
                                        <asp:Literal ID="Literal9" runat="server">PIVA:</asp:Literal>
                                        <asp:TextBox ID="txtPIVA" runat="server"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="col-md-5 col-xl-5">
                                    <div class="form-outline">
                                        <asp:Literal ID="Literal10" runat="server">CFE:</asp:Literal>
                                        <asp:TextBox ID="txtCFE" runat="server"></asp:TextBox>
                                    </div>
                                </div>
                            </div>
                            <div class="row">
                                <div class="col-md-4 col-xl-4">
                                    <div class="form-outline">
                                        <asp:Literal ID="Literal11" runat="server">PEC:</asp:Literal>
                                        <asp:TextBox ID="txtPEC" runat="server"></asp:TextBox>
                                    </div>
                                </div>
                            </div>
                            <div class="row">
                                <div class="col-md-4 col-xl-4">
                                    <div class="form-outline">
                                        <asp:Literal ID="Literal12" runat="server">Titolare:</asp:Literal>
                                        <asp:TextBox ID="txtTitolare" runat="server"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="col-md-5 col-xl-5">
                                    <div class="form-outline">
                                        <asp:Literal ID="Literal13" runat="server">eMail Titolare:</asp:Literal>
                                        <asp:TextBox ID="txtEMailTitolare" runat="server" TextMode="Email"></asp:TextBox>
                                    </div>
                                </div>
                            </div>
                            <div class="row">
                                <div class="col-md-4 col-xl-4">
                                    <div class="form-outline">
                                        <asp:Literal ID="Literal14" runat="server">Numero di telefono/i titolare:</asp:Literal>
                                        <asp:TextBox ID="txtTelefonoTitolare" runat="server"></asp:TextBox>
                                    </div>
                                </div>
                            </div>
                            <div class="row">
                                <div class="col-md-12 col-xl-12">
                                    <div class="form-outline">
                                        <asp:Button ID="btnClienti" class="btn btn-primary" runat="server" Text="Modifiica Cliente" />
                                    </div>
                                </div>
                            </div>
                        </div>
                        <%--Card per modifica dati cliente--%>
                    </div>
                </div>
            </div>
        </div>
    </section>
</asp:Content>

