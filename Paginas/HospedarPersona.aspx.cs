using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using static Recepcion.Paginas.VerHabitaciones;

namespace Recepcion.Paginas
{
    public partial class HospedarPersona : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }



        protected void Insertar(object sender, EventArgs e)
        {
            int i = 0; //variable contador
            //string id = txtID.Text;
            string nombre = txtNombre.Text;
            string apellidos = txtApellidos.Text;
            string cedula = txtCedula.Text;
            int cantidadPersonas = Convert.ToInt32(txtCantidad.Text);
            string habitacion = lblSeleccion.Text; //El valor sera el de la habitacion seleccionada en VerHabitaciones
            int noches = Convert.ToInt32(txtNoches.Text);
            double total = Convert.ToDouble(lblPrecio.Text); //El precio dependera de la cantidad de noches ingresadas

            List<Persona> personasRegistradas = new List<Persona>{};

            personasRegistradas.Add(
                new Persona { Nombre = nombre, Apellido = apellidos, Cedula = cedula, CantidadPersonas = cantidadPersonas, Habitacion = habitacion, Noches = noches, Total = total }
            );
            

            //txtID.Text = "";
            txtNombre.Text = "";
            txtApellidos.Text = " ";
            txtCedula.Text = " ";
            txtCantidad.Text = " ";
            txtNoches.Text = "";
            lblSeleccion.Text = "";
            lblPrecio.Text = "0.00";

            int idCliente = 0;
            int idHabitacion = 1;
            var datasource = @"OFLO\SQLEXPRESS"; //Nombre de la Base de la conexion
            var database = "hotel"; //Nombre de la Base de Datos
            string str = "Data Source =" + datasource + ";Initial Catalog=" + database + ";Integrated Security=True;MultipleActiveResultSets=True";
            string query1 = "INSERT INTO clientes(nombre, apellido, cedula) VALUES(@Nombre, @Apellidos, @Cedula); SELECT SCOPE_IDENTITY();";
            string query2 = "INSERT INTO reservacion(id_cliente, id_habitacion, cantidad_noches, cantidad_personas, status) VALUES(@IdCliente, @IdHabitacion, @Noches, @Personas, @Status)";
            //string query3 = "INSERT INTO reservacion(cantidad_noches, status) VALUES(@Habitacion)";
            using (SqlConnection con = new SqlConnection(str))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(query1, con))
                {

                    cmd.Parameters.AddWithValue("@Nombre", nombre);
                    cmd.Parameters.AddWithValue("@Apellidos", apellidos);
                    cmd.Parameters.AddWithValue("@Cedula", cedula);
                    idCliente = Convert.ToInt32(cmd.ExecuteScalar());
                    cmd.Connection = con;
                    //con.Open();
                    //cmd.ExecuteNonQuery();
                    con.Close();
                }

                con.Open();
                using (SqlCommand cmd = new SqlCommand(query2, con))
                {

                    cmd.Parameters.AddWithValue("@IdCliente", idCliente);
                    //reservarHabitacion();
                    cmd.Parameters.AddWithValue("@IdHabitacion", idCliente);
                    cmd.Parameters.AddWithValue("@Noches", noches);
                    cmd.Parameters.AddWithValue("@Personas", cantidadPersonas);
                    cmd.Parameters.AddWithValue("@Status", 1);
                    cmd.Connection = con;
                    //con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }

            void reservarHabitacion()
            {
                switch (habitacion)
                {
                    case "A-1":
                        idHabitacion = 1;
                        break;
                    case "A-2":
                        idHabitacion = 2;
                        break;
                    case "A-3":
                        idHabitacion = 3;
                        break;
                    case "A-4":
                        idHabitacion = 4;
                        break;
                    case "B-1":
                        idHabitacion = 5;
                        break;
                    case "B-2":
                        idHabitacion = 6;
                        break;
                    case "B-3":
                        idHabitacion = 7;
                        break;
                    case "B-4":
                        idHabitacion = 8;
                        break;
                    case "C-1":
                        idHabitacion = 9;
                        break;
                    case "C-2":
                        idHabitacion = 10;
                        break;
                    case "C-3":
                        idHabitacion = 11;
                        break;
                    case "C-4":
                        idHabitacion = 12;
                        break;
                    case "D-1":
                        idHabitacion = 13;
                        break;
                    case "D-2":
                        idHabitacion = 14;
                        break;
                    case "D-3":
                        idHabitacion = 15;
                        break;
                    case "D-4":
                        idHabitacion = 16;
                        break;
                    default:
                        idHabitacion = 0;
                        break;
                }
            }
                       
            

            lblConfirmacion.Visible = true;
            //btnRegistrar.Enabled = false;
            btnRegresar.Enabled = true;

            foreach(var persona in personasRegistradas)
            {
                System.Diagnostics.Debug.WriteLine(persona.ToString());
            }

            personasRegistradas[i].crearHilo();
            i++;

        }

        

        protected void btnRegresar_Click(object sender, EventArgs e)
        {
            Response.Redirect("VerHabitaciones.aspx");
        }

         
    }
}