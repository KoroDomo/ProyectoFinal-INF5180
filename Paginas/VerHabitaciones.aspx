<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VerHabitaciones.aspx.cs" Inherits="Recepcion.Paginas.VerHabitaciones" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <link href="../css/Index.css" rel="stylesheet" />
    <title>Ver Habitaciones</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
             <asp:GridView ID="GridView1" runat="server" CssClass="GridViewHabitaciones" AutoGenerateColumns="False">
                        <Columns>
                            <asp:BoundField DataField="Nombre" HeaderText="Nombre" />
                            <asp:BoundField DataField="Apellido" HeaderText="Apellido" />
                            <asp:BoundField DataField="ID" HeaderText="ID" />
                            <asp:TemplateField HeaderText="Tiempo Restante">
                                <ItemTemplate>
                                    <%# TiempoDeAlquilerRestante(Convert.ToDateTime(Eval("FechaDeReserva"))) %>
                                </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>
                    </asp:GridView>
            <p><asp:label ID="lbltitulo" runat="server"></asp:label></p>
            <div>
                <asp:Table ID="Table1" runat="server" Width="300px">
                    <asp:TableRow>
                        <asp:TableCell>
                         
                            
                  <asp:Button ID="btn1_1" runat="server" Text="A-1" CssClass="HabitacionLibre" OnClick="btnHabitacion_Click" />
                        </asp:TableCell>
                        <asp:TableCell>
                            <asp:Button ID="btn1_2" runat="server" Text="A-2" CssClass="HabitacionLibre" OnClick="btnHabitacion_Click" />
                        </asp:TableCell>
                        <asp:TableCell>
                            <asp:Button ID="btn1_3" runat="server" Text="A-3" CssClass="HabitacionLibre" OnClick="btnHabitacion_Click" />
                        </asp:TableCell>
                        <asp:TableCell>
                            <asp:Button ID="btn1_4" runat="server" Text="A-4" CssClass="HabitacionLibre" OnClick="btnHabitacion_Click" />
                        </asp:TableCell>
                    </asp:TableRow>

                    <asp:TableRow>
                        <asp:TableCell>
                            <asp:Button ID="btn2_1" runat="server" Text="B-1" CssClass="HabitacionLibre" OnClick="btnHabitacion_Click" />
                        </asp:TableCell>
                        <asp:TableCell>
                            <asp:Button ID="btn2_2" runat="server" Text="B-2" CssClass="HabitacionLibre" OnClick="btnHabitacion_Click" />
                        </asp:TableCell>
                        <asp:TableCell>
                            <asp:Button ID="btn2_3" runat="server" Text="B-3" CssClass="HabitacionLibre" OnClick="btnHabitacion_Click" />
                        </asp:TableCell>
                        <asp:TableCell>
                            <asp:Button ID="btn2_4" runat="server" Text="B-4" CssClass="HabitacionLibre" OnClick="btnHabitacion_Click" />
                        </asp:TableCell>
                    </asp:TableRow>

                    <asp:TableRow>
                        <asp:TableCell>
                            <asp:Button ID="btn3_1" runat="server" Text="C-1" CssClass="HabitacionLibre" OnClick="btnHabitacion_Click" />
                        </asp:TableCell>
                        <asp:TableCell>
                            <asp:Button ID="btn3_2" runat="server" Text="C-2" CssClass="HabitacionLibre" OnClick="btnHabitacion_Click" />
                        </asp:TableCell>
                        <asp:TableCell>
                            <asp:Button ID="btn3_3" runat="server" Text="C-3" CssClass="HabitacionLibre" OnClick="btnHabitacion_Click" />
                        </asp:TableCell>
                        <asp:TableCell>
                            <asp:Button ID="btn3_4" runat="server" Text="C-4" CssClass="HabitacionLibre" OnClick="btnHabitacion_Click" />
                        </asp:TableCell>
                    </asp:TableRow>
                    <asp:TableRow>
                        <asp:TableCell>
                            <asp:Button ID="btn4_1" runat="server" Text="D-1" CssClass="HabitacionLibre" OnClick="btnHabitacion_Click" />
                        </asp:TableCell>
                        <asp:TableCell>
                            <asp:Button ID="btn4_2" runat="server" Text="D-2" CssClass="HabitacionLibre" OnClick="btnHabitacion_Click" />
                        </asp:TableCell>
                        <asp:TableCell>
                            <asp:Button ID="btn4_3" runat="server" Text="D-3"  CssClass="HabitacionLibre" OnClick="btnHabitacion_Click" />
                        </asp:TableCell>
                        <asp:TableCell>
                            <asp:Button ID="btn4_4" runat="server" Text="D-4" CssClass="HabitacionLibre" OnClick="btnHabitacion_Click" />
                        </asp:TableCell>
                    </asp:TableRow>
                </asp:Table>
               
            </div>
            <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
        </div>
    </form>
</body>
</html>
