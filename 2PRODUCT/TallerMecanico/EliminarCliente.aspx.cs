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
    public partial class EliminarCliente : System.Web.UI.Page
    {
        LogicaNegocios ob2 = new LogicaNegocios();
        AccesoBD ob1 = new AccesoBD();
        protected void Page_Load(object sender, EventArgs e)
        {
            Panel1.Visible = false;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ob2.EliminarCliente(TextBox1.Text, TextBox2.Text, Convert.ToInt32(TextBox3.Text), TextBox7.Text);
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Panel1.Visible = true;

            DataSet contenedor = new DataSet();
            SqlConnection cnab = new SqlConnection();
            string m = "";
            ob1.ABRIR();
            contenedor = ob1.ConsultaDataSet(ob1.CONEXION);
            ob1.CERRAR();
            if (contenedor != null)
            {
                GridView1.DataSource = contenedor.Tables[0];
                GridView1.DataBind();
            }
        }

        protected void Button8_Click(object sender, EventArgs e)
        {
            Response.Redirect("Menu.aspx");
        }
    }
}