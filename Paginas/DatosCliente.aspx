<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DatosCliente.aspx.cs" Inherits="Recepcion.Paginas.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <link rel="stylesheet" type="text/css" href="Index.css" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="TituloDeDatos">
            <h1>DATOS DEL CLIENTE</h1>
            <div class="TablaDeDatosCliente">
                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CssClass="TablaDeDatosCliente">
                    <Columns>
                        <asp:BoundField DataField="nombredepersonadb" HeaderText="NOMBRE" />
                        <asp:BoundField DataField="apellidosdb" HeaderText="APELLIDOS" />
                        <asp:BoundField DataField="ceduladb" HeaderText="CEDULA" />
                        <asp:BoundField DataField="cantidaddb" HeaderText="PERSONAS" />
                        <asp:BoundField DataField="nochesdb" HeaderText="NOCHES" />
                        <asp:BoundField DataField="preciodb" HeaderText="PRECIO" />
                    </Columns>
                </asp:GridView>
            </div>
        </div>
    </form>
</body>
</html>