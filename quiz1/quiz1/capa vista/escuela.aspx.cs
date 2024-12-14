using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using quiz1.capa_modelo;
using quiz1.capa_logica;

namespace quiz1.capa_vista
{
    public partial class escuela : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LlenarGrid();
        }
        protected void LlenarGrid()
        {
            string constr = ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT *  FROM escuela"))
                {
                    using (SqlDataAdapter sda = new SqlDataAdapter())
                    {
                        cmd.Connection = con;
                        sda.SelectCommand = cmd;
                        using (DataTable dt = new DataTable())
                        {
                            sda.Fill(dt);
                            GridView1.DataSource = dt;
                            GridView1.DataBind();
                        }
                    }
                }
            }
        }
        public static void MostrarAlerta(Page page, string message)
        {
            string script = $"<script type='text/javascript'>alert('{message}');</script>";
            ClientScriptManager cs = page.ClientScript;
            cs.RegisterStartupScript(page.GetType(), "AlertScript", script);
        }



        protected void Agregar_Click1(object sender, EventArgs e)
        {

            CLSescuela.NombreEscuela = Nombre.Text;
            CLSescuela.Descripccion = descripcion.Text;

            CLSescuela.telefono = telefono.Text;
            CLSescuela.correo = correo.Text;
            CLSescuela.codigoPostal = CPostal.Text;
            CLSescuela.direccionPostal = Dpostal.Text;


            if (Escuela.AgregarEscuela(CLSescuela.NombreEscuela, CLSescuela.Descripccion, CLSescuela.correo, CLSescuela.telefono, CLSescuela.codigoPostal, CLSescuela.direccionPostal) > 0)
            {
                MostrarAlerta(this, "escuela ingresada");
                LlenarGrid();
            }
            else
            {
                MostrarAlerta(this, "Error al ingresar escuela");
            }
        }





        protected void Borrar_Click1(object sender, EventArgs e)
        {
            CLSescuela.id = int.Parse(ID.Text);



            if (Escuela.EliminarEscuela(CLSescuela.id) > 0)
            {
                MostrarAlerta(this, "escuela Borrada");
                LlenarGrid();
            }
            else
            {
                MostrarAlerta(this, "Error al borrar escuela");
            }

        }

        protected void Modificar_Click1(object sender, EventArgs e)
        {
            CLSescuela.id = int.Parse(ID.Text);

            CLSescuela.NombreEscuela = Nombre.Text;
            CLSescuela.Descripccion = descripcion.Text;

            CLSescuela.telefono = telefono.Text;
            CLSescuela.correo = correo.Text;
            CLSescuela.codigoPostal = CPostal.Text;
            CLSescuela.direccionPostal = Dpostal.Text;


            if (Escuela.ModificarEscuela(CLSescuela.id, CLSescuela.NombreEscuela, CLSescuela.Descripccion, CLSescuela.correo, CLSescuela.telefono, CLSescuela.codigoPostal, CLSescuela.direccionPostal) > 0)
            {
                MostrarAlerta(this, "escuela modificada");
                ID.Text = "";

                LlenarGrid();
            }
            else
            {
                MostrarAlerta(this, "Error al modificar escuela");
            }

        }

        protected void Consultar_Click1(object sender, EventArgs e)
        {

            CLSescuela.id = int.Parse(ID.Text);

            if (Escuela.ConsultarEscuela(CLSescuela.id) > 0)
            {

            
            MostrarAlerta(this, "escuela encontrada");
            ID.Text = "";

            LlenarGrid();
        }
            else
            {
                MostrarAlerta(this, "Error al encontrar escuela");
    }



}
    }
}
    