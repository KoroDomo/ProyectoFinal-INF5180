﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
            if (sender is Button)
            {
                
            }
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
            personasRegistradas[i].crearHilo();
            i++;

            //txtID.Text = "";
            txtNombre.Text = "";
            txtApellidos.Text = " ";
            txtCedula.Text = " ";
            txtCantidad.Text = " ";
            txtNoches.Text = "0";
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
                    cmd.Parameters.AddWithValue("@Cantidad", cantidadPersonas);
                    cmd.Parameters.AddWithValue("@Habitacion", habitacion);
                    cmd.Parameters.AddWithValue("@Noches", noches);
                    cmd.Parameters.AddWithValue("@Total", total);
                    cmd.Connection = con;
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
            

            lblConfirmacion.Visible = true;
            //btnRegistrar.Enabled = false;
            btnRegresar.Enabled = true;

            foreach(var persona in personasRegistradas)
            {
                System.Diagnostics.Debug.WriteLine(persona.ToString());
            }



        }

        

        protected void btnRegresar_Click(object sender, EventArgs e)
        {
            Response.Redirect("VerHabitaciones.aspx");
        }

         
    }
}