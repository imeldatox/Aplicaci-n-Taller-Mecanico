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
    public partial class InsertarCliente : System.Web.UI.Page
    {
        LogicaNegocios ob2 = new LogicaNegocios();
        AccesoBD ob1 = new AccesoBD();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ob2.InsertarClien(TextBox9.Text, TextBox10.Text, TextBox11.Text, TextBox12.Text, TextBox13.Text, TextBox14.Text, TextBox15.Text, Convert.ToInt32(TextBox16.Text), TextBox17.Text, TextBox18.Text, TextBox19.Text, TextBox20.Text, Convert.ToInt32(TextBox21.Text));
            Response.Redirect("Revisiones.aspx");
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            DataSet contenedor = new DataSet();
            SqlConnection cnab = new SqlConnection();
            //string m = "";
            ob1.ABRIR();
            contenedor = ob1.ConsultaDataSet(ob1.CONEXION);
            ob1.CERRAR();
            if (contenedor != null)
            {
                GridView1.DataSource = contenedor.Tables[0];
                GridView1.DataBind();
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Menu.aspx");
        }
    }
}