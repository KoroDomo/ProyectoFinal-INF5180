using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
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
            
            lblSeleccion.Text =""+Session["Habitacion"];
        }

        protected void Insertar(object sender, EventArgs e)
        {
            
           
            //string id = txtID.Text;
            string nombre = txtNombre.Text;
            string apellidos = txtApellidos.Text;
            string cedula = txtCedula.Text;
            int cantidadPersonas = int.Parse(txtCantidad.Text);
            string habitacion = lblSeleccion.Text; //El valor sera el de la habitacion seleccionada en VerHabitaciones
            int noches = Convert.ToInt32(txtNoches.Text);


            double total = Convert.ToDouble(lblPrecio.Text); //El precio dependera de la cantidad de noches ingresadas
            total += total * noches;
            List<Persona> personasRegistradas = new List<Persona> { };

            personasRegistradas.Add(new Persona { Nombre = nombre, Apellido = apellidos, Cedula = cedula, CantidadPersonas = cantidadPersonas, Habitacion = habitacion, Noches = noches, Total = total }
            );

           
            try {
                SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Hotel"].ConnectionString);
                string query = "INSERT INTO Cliente(nombre, apellidos, cedula, cantidadP, habitacion, noches, total) VALUES(@Nombre, @Apellidos, @Cedula, @CantidadP, @Habitacion, @Noches, @Total)";
              


                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand(query, con);

                foreach (Persona p in personasRegistradas)
                {

                    //cmd.Parameters.AddWithValue("@ID", id);
                    cmd.Parameters.AddWithValue("@Nombre", p.Nombre);
                    cmd.Parameters.AddWithValue("@Apellidos", p.Apellido);
                    cmd.Parameters.AddWithValue("@Cedula", p.Cedula);
                    cmd.Parameters.AddWithValue("@CantidadP", p.CantidadPersonas);
                    cmd.Parameters.AddWithValue("@Habitacion", p.Habitacion);
                    cmd.Parameters.AddWithValue("@Noches", p.Noches);
                    cmd.Parameters.AddWithValue("@Total", p.Total);
                    cmd.ExecuteNonQuery();
                }
               
               
                con.Close();


            } catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

          

            lblConfirmacion.Visible = true;
            //btnRegistrar.Enabled = false;
            btnRegresar.Enabled = true;

            foreach(var persona in personasRegistradas)
            {
                System.Diagnostics.Debug.WriteLine(persona.ToString());
            }

            LimpiarPagina();
            Response.Redirect("VerHabitaciones.aspx");

        }

        protected void btnRegresar_Click(object sender, EventArgs e)
        {
            Response.Redirect("VerHabitaciones.aspx");
        }
        private void LimpiarPagina()
        {
            //txtID.Text = "";
            txtNombre.Text = "";
            txtApellidos.Text = " ";
            txtCedula.Text = " ";
            txtCantidad.Text = " ";
            txtNoches.Text = "0";
            lblSeleccion.Text = "";
            lblPrecio.Text = "0.00";
        }

    }
   
}