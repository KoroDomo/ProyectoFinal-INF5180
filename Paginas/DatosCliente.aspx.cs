using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Recepcion.Paginas
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string nombre = Request.QueryString["nombre"];
                string apellido = Request.QueryString["apellido"];
                string cedula = Request.QueryString["cedula"];

                lblNombre.Text = nombre;
                lblApellido.Text = apellido;
                lblCedula.Text = cedula;
                ConsultarBaseDeDatos();
            }
        }
        private void ConsultarBaseDeDatos()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM TablaHipotetica WHERE Cedula = @cedula";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@cedula", lblCedula.Text);
                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    GridView1.DataSource = dt;
                    GridView1.DataBind();
                    con.Close();
                }
            }
        }
    }
}