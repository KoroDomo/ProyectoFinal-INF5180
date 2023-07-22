<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HospedarPersona.aspx.cs" Inherits="Recepcion.Paginas.HospedarPersona" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblnombreHuesped" CssClass="lblHospedaje" runat="server" Text="Ingrese nombre:  "></asp:Label>
            <asp:TextBox ID="TxtHuespedenombre" runat="server" Height="16px"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="lblapellidosHuesped" CssClass="lblHospedaje" runat="server" Text="Ingrese Apellidos: "></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server" Height="16px"></asp:TextBox>
        </div>
          <div>
            <asp:Label ID="Label2" CssClass="lblHospedaje" runat="server" Text="Ingrese nombre: "></asp:Label>
            <asp:TextBox ID="TextBox2" runat="server" Height="16px"></asp:TextBox>
        </div>
       
    </form>
</body>
</html>
