using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
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
            public string Cedula { get; set; }
            public int CantidadPersonas { get; set; }
            public string Habitacion { get; set; }
            public int Noches { get; set; }
            public double Total { get; set; }

          

            public override string ToString()
            {
                return "Nombre: " + Nombre + " | Apellidos: " + Apellido + " | Cedula" + Cedula+"| Cantidad Personas "+CantidadPersonas+"| Habitacion "+Habitacion+"| Noches "+Noches+" |Total "+Total;
            }

        }
        //Metodo para cargar las habitaciones
        private void CargarHabitaciones()
        {
            List<Persona> listaPersonas = ObtenerPersonasDesdeLaBaseDeDatos();
          // List<Button> buttonLista = BotonesAsignadosHabitacion();
            
            foreach (TableRow row in Table1.Rows)
            {
                foreach (TableCell cell in row.Cells)
                {
                    foreach (Control control in cell.Controls)
                    {
                        if (control is Button button)
                        {

                            foreach (Persona p in listaPersonas)
                            {
                                if (p.Habitacion.Equals(button.Text))
                                {
                                    button.CssClass = "HabitacionOcupada";
                                    cell.CssClass = "HabitacionOcupada";
                                    button.Text= $"{p.Habitacion} Ocupado";
                                }
                               
                            }
                        
                        
                        
                        
                        }




                        }




                    }
            }












                }

        protected void btnHabitacion_Click(object sender, EventArgs e)
        {
            Button botonHabitacion = (Button)sender;

            string prueba = botonHabitacion.CssClass;
            string h = botonHabitacion.Text;


            if (prueba.Equals("HabitacionOcupada")) {


                Response.Redirect("VerHabitaciones.aspx");

            }
            else
            {
                Session["Habitacion"] =h.Substring(0, 3);
                Response.Redirect("HospedarPersona.aspx");

            }


        
        }
       
        private List<Button> BotonesAsignadosHabitacion()
        {

            List<Button> botones = new List<Button>();
            Button btn = new Button();
            btn.CssClass = "HabitacionLibre";
          
            try
            {
                SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Hotel"].ConnectionString);
                string sCon = "SELECT * FROM Cliente";

                SqlDataReader dt;

                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }

                Console.WriteLine("Conexion exitosa!");

                SqlCommand cmd = new SqlCommand(sCon, con);
                dt = cmd.ExecuteReader();
                while (dt.Read())
                {
                   
                    btn.Text = dt[1].ToString();

                   botones.Add(btn);

                }
                dt.Close();

                con.Close();

            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }




            return botones;
        } 

        
        /*Aqui obtiene a las personas de las habitaciones asignadas*/
        private List<Persona> ObtenerPersonasDesdeLaBaseDeDatos()
        {
            List<Persona> lista = new List<Persona> { };
            try
            {
                SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Hotel"].ConnectionString);
                string sCon = "SELECT * FROM Cliente";

                SqlDataReader dt;

                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }

                Console.WriteLine("Conexion exitosa!");

                SqlCommand cmd = new SqlCommand(sCon, con);
                dt = cmd.ExecuteReader();
                while (dt.Read())
                {
                   
                    lista.Add( new Persona { Nombre = dt[1].ToString(), Apellido = dt[2].ToString(), Cedula = dt[3].ToString(), CantidadPersonas =int.Parse(dt[4].ToString()), Habitacion = dt[5].ToString(), Noches = int.Parse(dt[6].ToString()), Total = Double.Parse(dt[7].ToString()) });
                   
                }
                dt.Close();
              
                con.Close();

            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }


           
            return lista;
        }
       
 
    }
}
