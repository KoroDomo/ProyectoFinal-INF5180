using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Recepcion.Clases
{
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

            public string HabitacionOcupada { get; set; }

           
            //COnstructor vacio

            public Persona() { 
        
        
             }


        //Metodo para insertar

        public void InsertarHuesped(string nombre,string correo,string telefono)
        {
            int n = 0;

            try {
                SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["HotelPuntual"].ConnectionString);
                string sCon = "INSERT INTO Huespedes (Nombre,CorreoElectronico,Telefono)values(@Nombre,@correo,@telefono);";

                //Instruccion que abre la conexion de BD
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }

                /*Se utiliza cuando necesitas ejecutar un tipo de sentencia Sql a la base de datos (los tipos pueden ser: Delete, Update, Insert o Select)*/
                SqlCommand cmd = new SqlCommand(sCon, connection);
                cmd.Parameters.Add(new SqlParameter("@Nombre", nombre));
                cmd.Parameters.Add(new SqlParameter("@correo", correo));
                cmd.Parameters.Add(new SqlParameter("@telefono", telefono));
              
                n = cmd.ExecuteNonQuery();

            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }

            if (n > 0)
            {
                Console.WriteLine("Se ha(n) insertado {0} registro(s).", n);
            }
            else
            {
                Console.WriteLine("Inténtalo de nuevo que ha ocurrido un error.");
            }

        }
          
           





        }



        


    
}