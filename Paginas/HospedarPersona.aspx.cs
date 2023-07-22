using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Recepcion.Paginas
{
    public partial class HospedarPersona : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Insertar(object sender, EventArgs e)
        {
            //string id = txtID.Text;
            string nombre = txtNombre.Text;
            string apellidos = txtApellidos.Text;
            string cedula = txtCedula.Text;
            string cantidad = txtCantidad.Text;
            string habitacion = lblSeleccion.Text; //El valor sera el de la habitacion seleccionada en VerHabitaciones
            string noches = txtNoches.Text;
            string total = lblPrecio.Text; //El precio dependera de la cantidad de noches ingresadas
            //txtID.Text = "";
            txtNombre.Text = "";
            txtApellidos.Text = " ";
            txtCedula.Text = " ";
            txtCantidad.Text = " ";
            txtNoches.Text = " ";
            lblSeleccion.Text = "";
            lblPrecio.Text = "0.00";

            var datasource = @"OFLO\SQLEXPRESS"; //Nombre de la Base de la conexion
            var database = "Hotel"; //Nombre de la Base de Datos
            string str = "Data Source =" + datasource + ";Initial Catalog=" + database + ";Integrated Security=True;MultipleActiveResultSets=True";
            string query = "INSERT INTO Cliente(nombre, apellidos, cedula, cantidad, habitacion, noches, total) VALUES(@Nombre, @Apellidos, @Cedula, @Cantidad, @Habitacion, @Noches, @Total)";
            using (SqlConnection con = new SqlConnection(str))
            {
                using (SqlCommand cmd = new SqlCommand(query))
                {
                    //cmd.Parameters.AddWithValue("@ID", id);
                    cmd.Parameters.AddWithValue("@Nombre", nombre);
                    cmd.Parameters.AddWithValue("@Apellidos", apellidos);
                    cmd.Parameters.AddWithValue("@Cedula", cedula);
                    cmd.Parameters.AddWithValue("@Cantidad", cantidad);
                    cmd.Parameters.AddWithValue("@Habitacion", habitacion);
                    cmd.Parameters.AddWithValue("@Noches", noches);
                    cmd.Parameters.AddWithValue("@Total", total);
                    cmd.Connection = con;
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }

            /*string CalcularPrecio()
            {
                double x = Convert.ToDouble(this.lblTotal);
                return Convert.ToString(x * 100);
            }*/
            
        }

    
    }
}