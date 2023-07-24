using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Recepcion.Paginas
{
    public partial class VerHabitaciones : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                CargarHabitaciones();
            }
        }
        public class Persona
        {
            public string Nombre { get; set; }
            public string Apellido { get; set; }
            public int ID { get; set; }
            public DateTime FechaDeReserva { get; set; }
            public string Cedula { get; set; }
            public int CantidadPersonas { get; set; }
            public string Habitacion { get; set; }
            public int Noches { get; set; }
            public double Total { get; set; }

            public override string ToString()
            {
                return "Nombre: " + Nombre + " | Apellidos: " + Apellido + " | Cedula" + Cedula;
            }

        }
        //Metodo para cargar las habitaciones
        private void CargarHabitaciones()
        {
            List<Persona> listaPersonas = ObtenerPersonasDesdeLaBaseDeDatos();
              //GridView1.DataSource = listaPersonas;
              //GridView1.DataBind();
           
            for (int i = 0; i < Table1.Rows.Count; i++)
            {
                TableRow row = Table1.Rows[i];
                for (int j = 0; j < row.Cells.Count; j++)
                {
                    //lbltitulo.Text= row.Cells[j].ToString();
                    TableCell cell = row.Cells[j];
                    foreach (Control control in cell.Controls)
                    {
                        if (control is Button button)
                        {
                            button.Click += btnHabitacion_Click;
                            string habitacion = button.CssClass;
                            string numerohabitacion=button.Text;
                            bool habitacionLibre = ObtenerEstadoHabitacion(habitacion);

                            //if (habitacionLibre != false)
                            // Si la hab esta libre
                            if (habitacionLibre)
                            {
                                button.Click += btnHabitacion_Click;
                                button.CssClass = "HabitacionLibre";
                                
                            }
                            else if(habitacionLibre == false)
                            {
                                button.CssClass = "HabitacionOcupada";
                                button.Text = $"{numerohabitacion} Ocupada";

                            }


                            //Response.Redirect("HospedarPersona.aspx?habitacion=" + habitacion);

                        }
                    }
                }
            }

        }

        protected void btnHabitacion_Click(object sender, EventArgs e)
        {
            Button botonHabitacion = (Button)sender;
           
            string prueba= botonHabitacion.CssClass;
            string habitacion = botonHabitacion.Text;
           
            bool habitacionLibre = ObtenerEstadoHabitacion(prueba);

            //if (habitacionOcupada != false)
            // Si la hab esta libre ir al fomrulario, de lo contrario mostrar datos de persona
            if (habitacionLibre)
            {
                Persona personaOcupandoHabitacion = ObtenerPersonaOcupandoHabitacion(habitacion);
                List<Persona> listaPersonas = new List<Persona> { personaOcupandoHabitacion };
                //GridView1.DataSource = listaPersonas;
                //GridView1.DataBind();
                Response.Redirect("HospedarPersona.aspx?habitacion=" + habitacion);

            }
            else 
            {
                //Por el momento se queda en VerHab
                Response.Redirect("VerHabitaciones.aspx");
            }
        }
        public TimeSpan TiempoDeAlquilerRestante(DateTime FechaDeReserva)
        {
            TimeSpan tiempotranscurrido = DateTime.Now - FechaDeReserva;
            return tiempotranscurrido;
        }

        private bool ObtenerEstadoHabitacion(string habitacion)
        {
            if (habitacion.Equals("HabitacionLibre")){
                
                return true;

            }
            else
            {
                return false;
            }                
        }

        private List<Persona> ObtenerPersonasDesdeLaBaseDeDatos()
        {
            List<Persona> listaPersonas = new List<Persona>
            {
                new Persona { Nombre = "Harry", Apellido = "Potter", ID = 11234564, FechaDeReserva = new DateTime(2023, 7, 1) },
                new Persona { Nombre = "Silver", Apellido = "Gomez", ID = 2564654, FechaDeReserva = new DateTime(2023, 7, 5) },
                new Persona { Nombre = "Glorfindel", Apellido = "De La Flor", ID = 354655464, FechaDeReserva = new DateTime(2023, 7, 10) },
            };
            return listaPersonas;
        }
        private Persona ObtenerPersonaOcupandoHabitacion(string habitacion)
        {
            return new Persona { Nombre = "Juan", Apellido = "Perez", ID = 1, FechaDeReserva = new DateTime(2023, 7, 1) };
        }

 
    }
}
