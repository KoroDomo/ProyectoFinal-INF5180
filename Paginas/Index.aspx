<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="Recepcion.Paginas.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
<meta name="viewport" content="width=device-width, initial-scale=1"/>
<link href="../css/Index.css" rel="stylesheet" />
    <title>Recepcion</title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="index">
            <div class="left">
                <img src="../img/uno.jpg" class="img-col-2"/>
                <img src="../img/dos.jpg" />
                <img src="../img/tres.jpg" />
                <img src="../img/cuatro.jpg" />
                <img src="../img/cinco.jpg" />
            </div>
            <div class="right">
                <h1>Paraíso <br /> Caribeño</h1>
                <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam.</p>
                <asp:Button ID="btnVerHabitaciones" runat="server" Text="Ver Habitaciones" class="btn" OnClick="btn_VerHabitaciones"/>
            </div>
        </div>
    </form>
</body>
</html>
