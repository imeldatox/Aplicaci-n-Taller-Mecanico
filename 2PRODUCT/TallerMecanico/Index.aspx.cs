using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using ClassTallerMecanico;

namespace TallerMecanico
{
    public partial class Index : System.Web.UI.Page
    {
        LogicaNegocios ob2 = new LogicaNegocios();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DataTable tabla = LogicaNegocios.LOGEO(txtUsuario.Text, txtContraseña.Text);
            try
            {
                if (tabla.Rows.Count == 0)
                {
                    TextBox4.Text = "No existe el usuario" + "Sistema Login";//, Response.Write.OK, MessageBoxIcon.Error);   
                }
                else
                {
                    Response.Redirect("Menu.aspx");
                    TextBox4.Text = "Correcta";
                }
            }
            catch (Exception x)
            {
                Response.Write("Corregir");
                
            }
            
        }
    }
}