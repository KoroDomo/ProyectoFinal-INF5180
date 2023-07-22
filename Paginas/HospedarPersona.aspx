<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HospedarPersona.aspx.cs" Inherits="Recepcion.Paginas.HospedarPersona" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="lblTitulo" runat="server" Text="Hospedar Cliente"></asp:Label>
        <br />
        <br />
        <div>
            <asp:Label ID="lblNombre" CssClass="lblHospedaje" runat="server" Text="Nombre:  "></asp:Label>
            <asp:TextBox ID="txtNombre" runat="server" Height="16px"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="lblApellidos" CssClass="lblHospedaje" runat="server" Text="Apellidos: "></asp:Label>
            <asp:TextBox ID="txtApellidos" runat="server" Height="16px"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="lblCedula" CssClass="lblHospedaje" runat="server" Text="Cedula: "></asp:Label>
            <asp:TextBox ID="txtCedula" runat="server" Height="16px"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="lblCantidad" CssClass="lblHospedaje" runat="server" Text="Cantidad de Personas: "></asp:Label>
            <asp:TextBox ID="txtCantidad" runat="server" Height="16px"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="lblHabitacion" CssClass="lblHospedaje" runat="server" Text="Habitacion: "></asp:Label>
            <asp:Label ID="lblSeleccion" CssClass="lblHospedaje" runat="server" Text="1A"></asp:Label>
        </div>
        <div>
            <asp:Label ID="lblNoches" CssClass="lblHospedaje" runat="server" Text="Noches: "></asp:Label>
            <asp:TextBox ID="txtNoches" runat="server" Height="16px"></asp:TextBox>
        </div>
        <br />
        <div>
            <asp:Label ID="lblTotal" CssClass="lblHospedaje" runat="server" Text="Total a Pagar: "></asp:Label>
            <asp:Label ID="lblPrecio" CssClass="lblHospedaje" runat="server" Text="0.00"></asp:Label>
        </div>
        <br />
        <br />
        <asp:Button ID="btnRegistrar" runat="server" Text="Registrar" OnClick="Insertar"  />

       
    </form>
</body>
</html>
