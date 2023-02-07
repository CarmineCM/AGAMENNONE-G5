<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="ABdipendente.aspx.cs" Inherits="ABdipendente" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <div class="container py-5 mt-5">
        <div class="row d-flex justify-content-center align-items-center">
            <div class="col-lg-8 col-xl-6">
                <div class="card-body">
                    <div class="card-header  text-center">
                        <label>Dipendenti Abilita/Disabilita</label>
                    </div>
                    <div class="mt-3">
                        <asp:GridView ID="GridView1" runat="server"></asp:GridView>
                    </div>
                     <div class="row">
                    <div class="col-sm-6">
                        <div class="card">
                            <div class="card-body">
                                <asp:Button ID="btnAbilita" runat="server" Text="Abilita Dipendente" />
                            </div>
                        </div>
                    </div>

                    <div class="col-sm-6">
                        <div class="card">
                            <div class="card-body">
                                <asp:Button ID="btnDisabilita" runat="server" Text="Disabilita Dipendente" />
                            </div>
                        </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>

</asp:Content>

