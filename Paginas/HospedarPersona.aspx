<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HospedarPersona.aspx.cs" Inherits="Recepcion.Paginas.HospedarPersona" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="../css/Hospedar.css" rel="stylesheet" />
    <title>Hospedar</title>
</head>
<body>
    <div class="container">
        <nav>
            <div class="nav__info">
                <h1>Caribbean Palace</h1>
                <small>Sed ut perspiciatis unde omnis iste natus error sit </small>
            </div>
            <span>$ 3, 287, 249</span>
        </nav>
        <section class="section">
            <div class="section__img">
                <img src="../img/dos.jpg" />
            </div>
            <div class="section__form">
             <form id="form1" runat="server">
        <asp:Label ID="lblTitulo" runat="server" Text="Hospedar Cliente"></asp:Label>
        <div class="input">
            <asp:TextBox ID="txtNombre" runat="server" Text="Nombre"></asp:TextBox>
        </div>
        <div class="input">
            <asp:TextBox ID="txtApellidos" runat="server" Text="Apellidos"></asp:TextBox>
        </div>
        <div class="input">
            <asp:TextBox ID="txtCedula" runat="server" Text="Cedula"></asp:TextBox>
        </div>
        <div class="input">
            <asp:TextBox ID="txtCantidad" runat="server" Text="Personas"></asp:TextBox>
        </div>
        <div class="input">
            <asp:TextBox ID="txtNoches" runat="server" OnBlur="CalcularPrecio" Text="Noches"></asp:TextBox>
        </div>
           <div class="form__text">
               <div>
                    <asp:Label ID="lblHabitacion" CssClass="lblHospedaje" runat="server" Text="Habitacion: "></asp:Label>
            <asp:Label ID="lblSeleccion" CssClass="lblHospedaje" runat="server" Text="A-1"></asp:Label>
               </div>
           <div>
                <asp:Label ID="lblTotal" CssClass="lblHospedaje" runat="server" Text="Total a Pagar: "></asp:Label>
            <asp:Label ID="lblPrecio" CssClass="lblHospedaje" runat="server" Text="70.00"></asp:Label>
           </div>
        </div>
        <div class="form__btns">
            <asp:Button ID="btnRegistrar" runat="server" Text="Registrar" OnClick="Insertar"  CssClass="button"/>
            <asp:Button ID="btnRegresar" runat="server" Text="Regresar" Enabled="False" OnClick="btnRegresar_Click" CssClass="button"/>
        </div>
        <br />
        <asp:Label ID="lblConfirmacion" CssClass="lblHospedaje" runat="server" Text="REGISTRO REALIZADO!" ForeColor="Green" Visible="False"></asp:Label>    
    </form>
            </div>
        </section>
        <footer class="footer">
                <div class="footer__col">
                    <h4>Limites</h4>
                    <span>84862</span>
                </div>
                <div class="footer__col">
                    <h4>Temporada</h4>
                    <span>15415</span>
                </div>
            <div class="footer__col">
                    <h4>Periodo</h4>
                    <span>1132</span>
                </div>
            <div class="footer__col">
                    <h4>Ganancia</h4>
                    <span>230520</span>
                </div>
                <div class="footer__col">
                    <h4>Perdida</h4>
                    <span>46515</span>
                </div>
                <div class="footer__col">
                    <h4>Diferencia</h4>
                    <span>15165</span>
                </div>
            </footer>
    </div>
</body>
</html>
