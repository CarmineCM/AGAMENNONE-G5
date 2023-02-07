<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ModificaCommessa.aspx.cs" Inherits="ModificaCommessa" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Modifica Commessa</title>
</head>
<body>
    <form id="form1" runat="server">
        
         <div class="container-fluid px-1 py-5 mx-auto">
        <div class="row d-flex justify-content-center">
            <div class="col-xl-7 col-lg-8 col-md-9 col-11 text-center">
                <div class="card">
                    <h5 class="text-center mb-4">Modifica Commessa</h5>
                    <form class="form-card" onsubmit="event.preventDefault()">
                        <div class="row justify-content-between text-left">
                            <div class="form-group col-sm-6 flex-column d-flex">
                                <asp:Label class="form-control-label px-3" ID="lbModificaCorpoOra" runat="server" Text="Modifica Corpo Ora"></asp:Label>
                                <asp:TextBox ID="txtModificaCorpoOra" placeholder="Modifica Corpo Ora" runat="server"></asp:TextBox>
                            </div>
                        </div>
                        <!--DATA APERTURA-->
                        <div class="row justify-content-between text-left">
                            <div class="form-group col-sm-6 flex-column d-flex">
                                <asp:Label class="form-control-label px-3" ID="lbDataApertura" runat="server" Text="Modifica Data Apertura"></asp:Label>
                                <asp:Calendar ID="calendarDataApertura" runat="server" BackColor="White" BorderColor="#999999" CellPadding="4" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" ForeColor="Black" Height="180px" Width="200px">
                                    <DayHeaderStyle BackColor="#CCCCCC" Font-Bold="True" Font-Size="7pt" />
                                    <NextPrevStyle VerticalAlign="Bottom" />
                                    <OtherMonthDayStyle ForeColor="#808080" />
                                    <SelectedDayStyle BackColor="#666666" Font-Bold="True" ForeColor="White" />
                                    <SelectorStyle BackColor="#CCCCCC" />
                                    <TitleStyle BackColor="#999999" BorderColor="Black" Font-Bold="True" />
                                    <TodayDayStyle BackColor="#CCCCCC" ForeColor="Black" />
                                    <WeekendDayStyle BackColor="#FFFFCC" BorderStyle="Dotted" />
                                </asp:Calendar>
                            </div>

                        <!--DATA CHIUSURA-->
                            <div class="form-group col-sm-6 flex-column d-flex">
                                <asp:Label class="form-control-label px-3" ID="lbDataChiusura" runat="server" Text="Modifica Data Chiusura"></asp:Label>
                                <asp:Calendar ID="calendarDataChiusura" runat="server" BackColor="White" BorderColor="#999999" CellPadding="4" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" ForeColor="Black" Height="180px" Width="200px">
                                    <DayHeaderStyle BackColor="#CCCCCC" Font-Bold="True" Font-Size="7pt" />
                                    <NextPrevStyle VerticalAlign="Bottom" />
                                    <OtherMonthDayStyle ForeColor="#808080" />
                                    <SelectedDayStyle BackColor="#666666" Font-Bold="True" ForeColor="White" />
                                    <SelectorStyle BackColor="#CCCCCC" />
                                    <TitleStyle BackColor="#999999" BorderColor="Black" Font-Bold="True" />
                                    <TodayDayStyle BackColor="#CCCCCC" ForeColor="Black" />
                                    <WeekendDayStyle BackColor="#FFFFCC" />
                                </asp:Calendar>
                            </div>
                        </div>

                        <!--DATA CONSEGNA-->
                        <div class="row justify-content-between text-left">
                            <div class="form-group col-sm-6 flex-column d-flex">
                                <asp:Label class="form-control-label px-3" ID="lbDataConsegna" runat="server" Text="Modifica Data Consegna"></asp:Label>
                                <asp:Calendar ID="CalendarDataConsegna" runat="server" BackColor="White" BorderColor="#999999" CellPadding="4" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" ForeColor="Black" Height="180px" Width="200px">
                                    <DayHeaderStyle BackColor="#CCCCCC" Font-Bold="True" Font-Size="7pt" />
                                    <NextPrevStyle VerticalAlign="Bottom" />
                                    <OtherMonthDayStyle ForeColor="#808080" />
                                    <SelectedDayStyle BackColor="#666666" Font-Bold="True" ForeColor="White" />
                                    <SelectorStyle BackColor="#CCCCCC" />
                                    <TitleStyle BackColor="#999999" BorderColor="Black" Font-Bold="True" />
                                    <TodayDayStyle BackColor="#CCCCCC" ForeColor="Black" />
                                    <WeekendDayStyle BackColor="#FFFFCC" />
                                </asp:Calendar>
                            </div>
                        </div>

                        <!--DESCRIZIONE-->
                        <div class="row justify-content-between text-left">
                            <div class="form-group col-12 flex-column d-flex">
                                <asp:Label class="form-control-label px-3" ID="lbDescrizione" runat="server" Text="Descrizione Commessa"></asp:Label>
                                <asp:TextBox ID="txtDescrizione" placeholder="Descrivi Commessa" runat="server"></asp:TextBox>
                            </div>
                        </div>



                        <!--BOTTONE SALVA DATI-->
                        <div class="row justify-content-end">
                            <div class="form-group col-sm-6">
                                <asp:Button ID="btnModifica" runat="server" Text="Modifica i Dati" />
                            </div>
                        </div>
                    </form>
                </div>
            </div>
        </div>
    </div>

    </form>
</body>
</html>
