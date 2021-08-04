using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using ClassTallerMecanico;

namespace TallerMecanico
{
    public partial class Menu : System.Web.UI.Page
    {
        LogicaNegocios ob2 = new LogicaNegocios();
        AccesoBD ob1 = new AccesoBD();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button16_Click(object sender, EventArgs e)
        {
            Response.Redirect("ModificarCliente.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("InsertarCliente.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("EliminarCliente.aspx");
        }

        protected void Button15_Click(object sender, EventArgs e)
        {
            Response.Redirect("InsertarCliente.aspx");
        }

        protected void Button14_Click(object sender, EventArgs e)
        {
            Response.Redirect("Index.aspx");
        }

        protected void Button17_Click(object sender, EventArgs e)
        {
            DataSet contenedor = new DataSet();
            SqlConnection cnab = new SqlConnection();
            //string m = "";
            ob1.ABRIR();
            contenedor = ob1.ConsultaDataSet3(ob1.CONEXION);
            ob1.CERRAR();
            if (contenedor != null)
            {
                GridView1.DataSource = contenedor.Tables[0];
                GridView1.DataBind();
            }
        }
    }
}