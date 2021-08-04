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
    public partial class ModificarCliente : System.Web.UI.Page
    {
        LogicaNegocios ob2 = new LogicaNegocios();
        AccesoBD ob1 = new AccesoBD();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ob2.ModificarNomCliente(TextBox1.Text, TextBox6.Text);
        }

        protected void Button9_Click(object sender, EventArgs e)
        {
            ob2.ModificarCelCliente(TextBox8.Text, TextBox9.Text);
        }

        protected void Button10_Click(object sender, EventArgs e)
        {
            ob2.ModificarTelCliente(TextBox12.Text, TextBox13.Text);
        }

        protected void Button11_Click(object sender, EventArgs e)
        {
            ob2.ModificarCorrPCliente(TextBox2.Text, TextBox7.Text);
        }

        protected void Button12_Click(object sender, EventArgs e)
        {
            ob2.ModificarCorrCorCliente(TextBox10.Text, TextBox11.Text);
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Panel1.Visible = true;

            DataSet contenedor = new DataSet();
            SqlConnection cnab = new SqlConnection();
            string m = "";
            ob1.ABRIR();
            contenedor = ob1.ConsultaDataSet2(ob1.CONEXION);
            ob1.CERRAR();
            if (contenedor != null)
            {
                GridView1.DataSource = contenedor.Tables[0];
                GridView1.DataBind();
            }
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            ob2.BusquedaCliente(TextBox5.Text);
        }

        protected void Button8_Click(object sender, EventArgs e)
        {
            Response.Redirect("Menu.aspx");
        }
    }
}