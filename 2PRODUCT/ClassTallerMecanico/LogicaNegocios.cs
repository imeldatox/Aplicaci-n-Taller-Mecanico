using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ClassTallerMecanico
{
    public class LogicaNegocios
    {

        AccesoBD BD = new AccesoBD();
        //logueo
        public static DataTable LOGEO(string us, string cel)
        {
            AccesoBD login = new AccesoBD();
            return login.Login(us, cel);
        }
        //insertar
        public void InsertarClien(string nomb, string apP, string apm, string celu, string telOf, string coper, string corcorp, int fmarca, string modelo, string año, string color, string placa, int dueño)
        {
            BD.ABRIR();
            BD.InsertarCliente(nomb, apP, apm, celu, telOf, coper, corcorp, fmarca, modelo, año, color, placa, dueño);
            BD.CERRAR();
        }

        public void InsertarRevision(string entrada, string falla, string diagnostico, int autorizacion, int auto, int mecanico, string detall, string gar, string sal, int ficre)
        {
            BD.ABRIR();
            BD.InsertarRevision(entrada, falla, diagnostico, autorizacion, auto, mecanico, detall, gar, sal, ficre);
            BD.CERRAR();
        }

        public void InsertarConexion(int cliente, int automovil, int marca, int revisado, int reparado, int meca)
        {
            BD.ABRIR();
            BD.InsertarConexion(cliente, automovil, marca, revisado, reparado, meca);
            BD.CERRAR();
        }

        public void EliminarCliente(string nombrecliente, string modeloauto, int automov, string salidaa)
        {
            BD.ABRIR();
            BD.EliminarCliente(nombrecliente, modeloauto, automov, salidaa);
            BD.CERRAR();
        }

        public void ModificarNomCliente(string Nom1, string Nom2)
        {
            BD.ABRIR();
            BD.ModificarNomCliente(Nom1, Nom2);
            BD.CERRAR();
        }

        public void ModificarCelCliente(string celular1, string celular2)
        {
            BD.ABRIR();
            BD.ModificarCelCliente(celular1, celular2);
            BD.CERRAR();
        }

        public void ModificarTelCliente(string Telefono1, string Telefono2)
        {
            BD.ABRIR();
            BD.ModificarTelCliente(Telefono1, Telefono2);
            BD.CERRAR();
        }

        public void ModificarCorrPCliente(string CorreoP1, string CorreoP2)
        {
            BD.ABRIR();
            BD.ModificarCorrPCliente(CorreoP1, CorreoP2);
            BD.CERRAR();
        }

        public void ModificarCorrCorCliente(string correoC1, string correoC2)
        {
            BD.ABRIR();
            BD.ModificarCorrCorCliente(correoC1, correoC2);
            BD.CERRAR();
        }

        public void BusquedaCliente(string nombreclient)
        {
            BD.ABRIR();
            BD.BusquedaCliente(nombreclient);
            BD.CERRAR();
        }

    }
}
