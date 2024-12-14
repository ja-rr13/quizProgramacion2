using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Reflection;
using quiz1.capa_modelo;
using quiz1.capa_logica;

namespace quiz1.capa_vista
{
    public partial class clase : System.Web.UI.Page
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
                using (SqlCommand cmd = new SqlCommand("SELECT *  FROM clase"))
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

       

       

       

       
        protected void Agregar_Click(object sender, EventArgs e)
        {
           
            CLSclase.NombreClase = NombreC.Text;
            CLSclase.descripcion = descripcion.Text;
            CLSclase.escuelaID = int.Parse(EscuelaID.Text);

            if (Clase.AgregarClase(CLSclase.NombreClase,CLSclase.descripcion,CLSclase.escuelaID) > 0)
            {
                MostrarAlerta(this, "clase ingresada");
               
                LlenarGrid();
            }
            else
            {
                MostrarAlerta(this, "Error al ingresar clase");
            }
        }

        protected void Borrar_Click(object sender, EventArgs e)
        {

            CLSclase.id = int.Parse(CID.Text);



            if (Clase.EliminarClase(CLSclase.id) > 0)
            {
                MostrarAlerta(this, "Clase Borrada");
               
                LlenarGrid();

            }
            else
            {
                MostrarAlerta(this, "Error al borrar Clase");
            }
        }

        protected void Modificar_Click(object sender, EventArgs e)
        {
            CLSclase.id= int.Parse(CID.Text);
            CLSclase.NombreClase = NombreC.Text;
            CLSclase.descripcion = descripcion.Text;
            CLSclase.escuelaID = int.Parse(EscuelaID.Text);

            if (Clase.ModificaClase(CLSclase.id,CLSclase.NombreClase, CLSclase.descripcion, CLSclase.escuelaID) > 0)
            {
                MostrarAlerta(this, "clase modificado");
               
                LlenarGrid();
            }
            else
            {
                MostrarAlerta(this, "Error al modificar clase");
            }
        }

        protected void Consultar_Click(object sender, EventArgs e)
        {
            CLSclase.id = int.Parse(CID.Text);

            if (Clase.ConsultarClase(CLSclase.id) > 0)
            {
                MostrarAlerta(this, "clase encontrada");
               
                LlenarGrid();
            }
            else
            {
                MostrarAlerta(this, "Clase no encontrada");
            }
        }
    }
}