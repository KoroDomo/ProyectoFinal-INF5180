<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VerHabitaciones.aspx.cs" Inherits="Recepcion.Paginas.VerHabitaciones" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <script src="https://kit.fontawesome.com/32574f76c1.js" crossorigin="anonymous"></script>
    <link href="../css/VerHab.css" rel="stylesheet" />
    <title>Ver Habitaciones</title>
</head>
<body>
    <form id="form1" runat="server">
            <div  class="container">
                <asp:Table ID="Table1" runat="server" CssClass="table">
                    <asp:TableRow CssClass="row">
                        <asp:TableCell CssClass="HabitacionLibre">                           
                  <asp:Button ID="btn1_1" runat="server" Text="A-1" CssClass="HabitacionLibre" OnClick="btnHabitacion_Click" />
                   <i class="fa-solid fa-bed"></i>
                        </asp:TableCell>
                        <asp:TableCell CssClass="HabitacionLibre">
                            <asp:Button ID="btn1_2" runat="server" Text="A-2" CssClass="HabitacionLibre" OnClick="btnHabitacion_Click" />
                   <i class="fa-solid fa-bed"></i>
                        </asp:TableCell>
                        <asp:TableCell CssClass="HabitacionLibre">
                            <asp:Button ID="btn1_3" runat="server" Text="A-3" CssClass="HabitacionLibre" OnClick="btnHabitacion_Click" />
                   <i class="fa-solid fa-bed"></i>
                        </asp:TableCell>
                        <asp:TableCell CssClass="HabitacionLibre">
                            <asp:Button ID="btn1_4" runat="server" Text="A-4" CssClass="HabitacionLibre" OnClick="btnHabitacion_Click" />
                             <i class="fa-solid fa-bed"></i>
                        </asp:TableCell>
                    </asp:TableRow>

                    <asp:TableRow CssClass="row">
                        <asp:TableCell CssClass="HabitacionLibre">
                            <asp:Button ID="btn2_1" runat="server" Text="B-1" CssClass="HabitacionLibre" OnClick="btnHabitacion_Click" />
                             <i class="fa-solid fa-bed"></i>
                        </asp:TableCell>
                        <asp:TableCell CssClass="HabitacionLibre">
                            <asp:Button ID="btn2_2" runat="server" Text="B-2" CssClass="HabitacionLibre" OnClick="btnHabitacion_Click" />
                             <i class="fa-solid fa-bed"></i>
                        </asp:TableCell>
                        <asp:TableCell CssClass="HabitacionLibre">
                            <asp:Button ID="btn2_3" runat="server" Text="B-3" CssClass="HabitacionLibre" OnClick="btnHabitacion_Click" />
                             <i class="fa-solid fa-bed"></i>
                        </asp:TableCell>
                        <asp:TableCell CssClass="HabitacionLibre">
                            <asp:Button ID="btn2_4" runat="server" Text="B-4" CssClass="HabitacionLibre" OnClick="btnHabitacion_Click" />
                             <i class="fa-solid fa-bed"></i>
                        </asp:TableCell>
                    </asp:TableRow>

                    <asp:TableRow CssClass="row">
                        <asp:TableCell CssClass="HabitacionLibre">
                            <asp:Button ID="btn3_1" runat="server" Text="C-1" CssClass="HabitacionLibre" OnClick="btnHabitacion_Click" />
                             <i class="fa-solid fa-bed"></i>
                        </asp:TableCell>
                        <asp:TableCell CssClass="HabitacionLibre">
                            <asp:Button ID="btn3_2" runat="server" Text="C-2" CssClass="HabitacionLibre" OnClick="btnHabitacion_Click" />
                             <i class="fa-solid fa-bed"></i>
                        </asp:TableCell>
                        <asp:TableCell CssClass="HabitacionLibre">
                            <asp:Button ID="btn3_3" runat="server" Text="C-3" CssClass="HabitacionLibre" OnClick="btnHabitacion_Click" />
                             <i class="fa-solid fa-bed"></i>
                        </asp:TableCell>
                        <asp:TableCell CssClass="HabitacionLibre">
                            <asp:Button ID="btn3_4" runat="server" Text="C-4" CssClass="HabitacionLibre" OnClick="btnHabitacion_Click" />
                             <i class="fa-solid fa-bed"></i>
                        </asp:TableCell>
                    </asp:TableRow>
                    <asp:TableRow CssClass="row">
                        <asp:TableCell CssClass="HabitacionLibre">
                            <asp:Button ID="btn4_1" runat="server" Text="D-1" CssClass="HabitacionLibre" OnClick="btnHabitacion_Click" />
                             <i class="fa-solid fa-bed"></i>
                        </asp:TableCell>
                        <asp:TableCell CssClass="HabitacionLibre">
                            <asp:Button ID="btn4_2" runat="server" Text="D-2" CssClass="HabitacionLibre" OnClick="btnHabitacion_Click" />
                             <i class="fa-solid fa-bed"></i>
                        </asp:TableCell>
                        <asp:TableCell CssClass="HabitacionLibre">
                            <asp:Button ID="btn4_3" runat="server" Text="D-3"  CssClass="HabitacionLibre" OnClick="btnHabitacion_Click" />
                             <i class="fa-solid fa-bed"></i>
                        </asp:TableCell>
                        <asp:TableCell CssClass="HabitacionLibre">
                            <asp:Button ID="btn4_4" runat="server" Text="D-4" CssClass="HabitacionLibre" OnClick="btnHabitacion_Click" />
                             <i class="fa-solid fa-bed"></i>
                        </asp:TableCell>
                    </asp:TableRow>
                </asp:Table>
               
            </div>
            <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    </form>
</body>
</html>
