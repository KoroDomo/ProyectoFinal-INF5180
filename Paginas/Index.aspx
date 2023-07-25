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
            <nav>
                <span>
                    Hola de vuelta, Puntual!
                </span>
               <div class="nav__links">
                    <ul>
                    <li class="active">Hotel</li>
                    <li>Galeria</li>
                    <li>bar</li>
                    <li>gym</li>
                    <li>especiales</li>
                    <li class="active">restaurante</li>
                    <li class="active">spa</li>
                    <li class="active">contacto</li>
                </ul>
               </div>
            </nav>

            <div class="top">
               <h2>Bienvenido a</h2>
               <h1>Carribbean</h1>
            </div>

            <div class="index__bottom">
                <div class="index__left">
                <img src="../img/uno.jpg" />
                </div>
                <div class="index__right">
                <img src="../img/dos.jpg" />
                <p>Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo.
                    <br /><br />
                    - Laudantium Quasi
                </p>
                <asp:Button ID="btnVerHabitaciones" runat="server" Text="Ver Habitaciones" class="btn" OnClick="btn_VerHabitaciones"/>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
