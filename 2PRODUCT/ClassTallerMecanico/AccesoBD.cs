using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace ClassTallerMecanico
{
    public class AccesoBD
    {

        public string cadeConex { get; set; }
        public SqlConnection CONEXION = new SqlConnection();
        public SqlCommand COMANDO = new SqlCommand();

        public AccesoBD()
        {
            string CadCon = (@"Data Source = DESKTOP-8G10411\SQLEXPRESS; Initial Catalog = MiTaller2021; Integrated Security = false; user = imelda; pwd = Lord0120;");
            //@"Data Source = LAPTOP-CU3COPN9; Initial Catalog = MiTaller2021; Integrated Security = true;");
            CONEXION = new SqlConnection(CadCon);
            //cuando se hace con contraseña
            //@"Data Source = LAPTOP-CU3COPN9; Initial Catalog = MiTaller2021; Integrated Security = false; user = imelda; pwd = Lord0120"
            CONEXION = new SqlConnection(CadCon);
            COMANDO.Connection = CONEXION;
        }

        public bool ABRIR()
        {
            try
            {
                CONEXION.Open();
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }
        public SqlConnection AbrirConexion(ref string msj)
        {
            SqlConnection cn1 = new SqlConnection();
            cn1.ConnectionString = cadeConex;

            try
            {
                cn1.Open();
                msj = "Conexion abierta";
            }
            catch (Exception h)
            {
                cn1 = null;
                msj = "Error" + h.Message;
            }
            return cn1;
        }

        public void CERRAR()
        {
            CONEXION.Close();
        }

        public DataSet ConsultaDataSet(SqlConnection abierta)
        {
            SqlCommand carrito = new SqlCommand();
            SqlDataAdapter trailer = new SqlDataAdapter();
            DataSet cajaGrande = new DataSet();
            string querySQL = "select * from BusqCliente;";

            if (abierta != null)
            {
                //si la conexion esta abierta se va a cargamos el carrito
                carrito.CommandText = querySQL;
                carrito.Connection = abierta;
                trailer.SelectCommand = carrito;

                try
                {
                    //mandar el trailer a la base de datos y obtener los resultados en el DataSet
                    trailer.Fill(cajaGrande);
                    //msj = "Consulta correcta";
                }
                catch (Exception f)
                {
                    cajaGrande = null;
                    //msj = "Error: " + f.Message;
                }
            }
            else
            {
                //msj = "no hay conexion abierta";
                cajaGrande = null;
            }
            return cajaGrande;
        }

        public DataSet ConsultaDataSet2(SqlConnection abierta2)
        {
            SqlCommand carrito = new SqlCommand();
            SqlDataAdapter trailer = new SqlDataAdapter();
            DataSet cajaGrande = new DataSet();
            string querySQL = "select * from MuestraCliente;";

            if (abierta2 != null)
            {
                //si la conexion esta abierta se va a cargamos el carrito
                carrito.CommandText = querySQL;
                carrito.Connection = abierta2;
                trailer.SelectCommand = carrito;

                try
                {
                    //mandar el trailer a la base de datos y obtener los resultados en el DataSet
                    trailer.Fill(cajaGrande);
                    //msj = "Consulta correcta";
                }
                catch (Exception f)
                {
                    cajaGrande = null;
                    //msj = "Error: " + f.Message;
                }
            }
            else
            {
                //msj = "no hay conexion abierta";
                cajaGrande = null;
            }
            return cajaGrande;
        }

        public DataSet ConsultaDataSet3(SqlConnection abierta3)
        {
            SqlCommand carrito = new SqlCommand();
            SqlDataAdapter trailer = new SqlDataAdapter();
            DataSet cajaGrande = new DataSet();
            string querySQL = "select * from Cliente;";

            if (abierta3 != null)
            {
                //si la conexion esta abierta se va a cargamos el carrito
                carrito.CommandText = querySQL;
                carrito.Connection = abierta3;
                trailer.SelectCommand = carrito;

                try
                {
                    //mandar el trailer a la base de datos y obtener los resultados en el DataSet
                    trailer.Fill(cajaGrande);
                    //msj = "Consulta correcta";
                }
                catch (Exception f)
                {
                    cajaGrande = null;
                    //msj = "Error: " + f.Message;
                }
            }
            else
            {
                //msj = "no hay conexion abierta";
                cajaGrande = null;
            }
            return cajaGrande;
        }

        public DataTable Login(string usu, string cel)
        {
            DataTable login = new DataTable("Login");
            SqlConnection sql = new SqlConnection();
            try
            {
                sql.ConnectionString = CONEXION.ConnectionString;

                SqlCommand sqlCm = new SqlCommand("LOGEO", sql);
                sqlCm.CommandType = CommandType.StoredProcedure;

                sqlCm.Parameters.Add("@Usuario", SqlDbType.VarChar).Value = usu;
                sqlCm.Parameters.Add("@Cel", SqlDbType.VarChar).Value = cel;

                SqlDataAdapter sqlAdp = new SqlDataAdapter(sqlCm);
                sqlAdp.Fill(login);

            }
            catch
            {
                login = null;
            }
            return login;
        }

        public string InsertarCliente(string nom, string app, string apm, string cel, string teloficial, string coPer, string coCorpo, int fmarca, string modelo, string año, string color, string placa, int dueño)
        {
            string msj = "";
            try
            {
                SqlParameter[] paramD = new SqlParameter[13];
                paramD[0] = new SqlParameter("@Nom", SqlDbType.VarChar);
                paramD[0].Value = nom;
                paramD[1] = new SqlParameter("@App", SqlDbType.VarChar);
                paramD[1].Value = app;
                paramD[2] = new SqlParameter("@ApM", SqlDbType.VarChar);
                paramD[2].Value = apm;
                paramD[3] = new SqlParameter("@Cel", SqlDbType.VarChar);
                paramD[3].Value = cel;
                paramD[4] = new SqlParameter("@telOficina", SqlDbType.VarChar);
                paramD[4].Value = teloficial;
                paramD[5] = new SqlParameter("@coPer", SqlDbType.VarChar);
                paramD[5].Value = coPer;
                paramD[6] = new SqlParameter("@corCorp", SqlDbType.VarChar);
                paramD[6].Value = coCorpo;
                paramD[7] = new SqlParameter("@fMarca", SqlDbType.Int);
                paramD[7].Value = fmarca;
                paramD[8] = new SqlParameter("@modelo", SqlDbType.VarChar);
                paramD[8].Value = modelo;
                paramD[9] = new SqlParameter("@añoo", SqlDbType.VarChar);
                paramD[9].Value = año;
                paramD[10] = new SqlParameter("@colorr", SqlDbType.VarChar);
                paramD[10].Value = color;
                paramD[11] = new SqlParameter("@placaa", SqlDbType.VarChar);
                paramD[11].Value = placa;
                paramD[12] = new SqlParameter("@dueñoo", SqlDbType.Int);
                paramD[12].Value = dueño;
                COMANDO.CommandType = CommandType.StoredProcedure;
                COMANDO.CommandText = "Insertar_Cliente";
                COMANDO.Connection = CONEXION;
                COMANDO.Parameters.AddRange(paramD);
                COMANDO.ExecuteNonQuery();
                msj = "Ingresado Correctamente";
            }
            catch (Exception)
            {
                SqlParameter[] paramD = new SqlParameter[13];
                paramD[0] = new SqlParameter("@Nom", SqlDbType.VarChar);
                paramD[0].Value = nom;
                paramD[1] = new SqlParameter("@App", SqlDbType.VarChar);
                paramD[1].Value = app;
                paramD[2] = new SqlParameter("@ApM", SqlDbType.VarChar);
                paramD[2].Value = apm;
                paramD[3] = new SqlParameter("@Cel", SqlDbType.VarChar);
                paramD[3].Value = cel;
                paramD[4] = new SqlParameter("@telOficina", SqlDbType.VarChar);
                paramD[4].Value = teloficial;
                paramD[5] = new SqlParameter("@coPer", SqlDbType.VarChar);
                paramD[5].Value = coPer;
                paramD[6] = new SqlParameter("@corCorp", SqlDbType.VarChar);
                paramD[6].Value = coCorpo;
                paramD[7] = new SqlParameter("@fMarca", SqlDbType.Int);
                paramD[7].Value = fmarca;
                paramD[8] = new SqlParameter("@modelo", SqlDbType.VarChar);
                paramD[8].Value = modelo;
                paramD[9] = new SqlParameter("@añoo", SqlDbType.VarChar);
                paramD[9].Value = año;
                paramD[10] = new SqlParameter("@colorr", SqlDbType.VarChar);
                paramD[10].Value = color;
                paramD[11] = new SqlParameter("@placaa", SqlDbType.VarChar);
                paramD[11].Value = placa;
                paramD[12] = new SqlParameter("@dueñoo", SqlDbType.Int);
                paramD[12].Value = dueño;
                COMANDO.CommandType = CommandType.StoredProcedure;
                COMANDO.CommandText = "Insertar_Cliente";
                COMANDO.Connection = CONEXION;
                COMANDO.Parameters.AddRange(paramD);
                COMANDO.ExecuteNonQuery();
                msj = "Ingresado Correctamente";
            }
            return msj;
        }





        public string InsertarRevision(string entra, string falla, string diagnostic, int autorizacion, int auto, int mecanic, string detalles, string garantia, string salida, int ficrevis)
        {
            string msj = "";
            try
            {
                SqlParameter[] paramD = new SqlParameter[10];
                paramD[0] = new SqlParameter("@entra", SqlDbType.Date);
                paramD[0].Value = entra;
                paramD[1] = new SqlParameter("@falla", SqlDbType.VarChar);
                paramD[1].Value = falla;
                paramD[2] = new SqlParameter("@diagno", SqlDbType.VarChar);
                paramD[2].Value = diagnostic;
                paramD[3] = new SqlParameter("@Autoriz", SqlDbType.Bit);
                paramD[3].Value = autorizacion;
                paramD[4] = new SqlParameter("@auto", SqlDbType.Int);
                paramD[4].Value = auto;
                paramD[5] = new SqlParameter("@mecanic", SqlDbType.Int);
                paramD[5].Value = mecanic;

                paramD[6] = new SqlParameter("@detalle", SqlDbType.VarChar);
                paramD[6].Value = detalles;
                paramD[7] = new SqlParameter("@garan", SqlDbType.VarChar);
                paramD[7].Value = garantia;
                paramD[8] = new SqlParameter("@salid", SqlDbType.Date);
                paramD[8].Value = salida;
                paramD[9] = new SqlParameter("@ficRevis", SqlDbType.Int);
                paramD[9].Value = ficrevis;
                COMANDO.CommandType = CommandType.StoredProcedure;
                COMANDO.CommandText = "Insertar_Revision";
                COMANDO.Connection = CONEXION;
                COMANDO.Parameters.AddRange(paramD);
                COMANDO.ExecuteNonQuery();
                msj = "Ingresado Correctamente";
            }
            catch (Exception)
            {
                SqlParameter[] paramD = new SqlParameter[10];
                paramD[0] = new SqlParameter("@entra", SqlDbType.Date);
                paramD[0].Value = entra;
                paramD[1] = new SqlParameter("@falla", SqlDbType.VarChar);
                paramD[1].Value = falla;
                paramD[2] = new SqlParameter("@diagno", SqlDbType.VarChar);
                paramD[2].Value = diagnostic;
                paramD[3] = new SqlParameter("@Autoriz", SqlDbType.Bit);
                paramD[3].Value = autorizacion;
                paramD[4] = new SqlParameter("@auto", SqlDbType.Int);
                paramD[4].Value = auto;
                paramD[5] = new SqlParameter("@mecanic", SqlDbType.Int);
                paramD[5].Value = mecanic;

                paramD[6] = new SqlParameter("@detalle", SqlDbType.VarChar);
                paramD[6].Value = detalles;
                paramD[7] = new SqlParameter("@garan", SqlDbType.VarChar);
                paramD[7].Value = garantia;
                paramD[8] = new SqlParameter("@salid", SqlDbType.Date);
                paramD[8].Value = salida;
                paramD[9] = new SqlParameter("@ficRevis", SqlDbType.Int);
                paramD[9].Value = ficrevis;
                COMANDO.CommandType = CommandType.StoredProcedure;
                COMANDO.CommandText = "Insertar_Revision";
                COMANDO.Connection = CONEXION;
                COMANDO.Parameters.AddRange(paramD);
                COMANDO.ExecuteNonQuery();
                msj = "Ingresado Correctamente";
            }
            return msj;
        }


        public string InsertarConexion(int cliente, int automov, int marca, int revisar, int reparar, int mecanico)
        {
            string msj = "";
            try
            {
                SqlParameter[] paramD = new SqlParameter[6];
                paramD[0] = new SqlParameter("@clien", SqlDbType.Int);
                paramD[0].Value = cliente;
                paramD[1] = new SqlParameter("@aut", SqlDbType.Int);
                paramD[1].Value = automov;
                paramD[2] = new SqlParameter("@marc", SqlDbType.Int);
                paramD[2].Value = marca;
                paramD[3] = new SqlParameter("@rev", SqlDbType.Int);
                paramD[3].Value = revisar;
                paramD[4] = new SqlParameter("@repa", SqlDbType.Int);
                paramD[4].Value = reparar;
                paramD[5] = new SqlParameter("@meca", SqlDbType.Int);
                paramD[5].Value = mecanico;
                COMANDO.CommandType = CommandType.StoredProcedure;
                COMANDO.CommandText = "Insertar_Conexion";
                COMANDO.Connection = CONEXION;
                COMANDO.Parameters.AddRange(paramD);
                COMANDO.ExecuteNonQuery();
                msj = "Ingresado Correctamente";
            }
            catch (Exception)
            {
                SqlParameter[] paramD = new SqlParameter[6];
                paramD[0] = new SqlParameter("@clien", SqlDbType.Int);
                paramD[0].Value = cliente;
                paramD[1] = new SqlParameter("@aut", SqlDbType.Int);
                paramD[1].Value = automov;
                paramD[2] = new SqlParameter("@marc", SqlDbType.Int);
                paramD[2].Value = marca;
                paramD[3] = new SqlParameter("@rev", SqlDbType.Int);
                paramD[3].Value = revisar;
                paramD[4] = new SqlParameter("@repa", SqlDbType.Int);
                paramD[4].Value = reparar;
                paramD[5] = new SqlParameter("@meca", SqlDbType.Int);
                paramD[5].Value = mecanico;
                COMANDO.CommandType = CommandType.StoredProcedure;
                COMANDO.CommandText = "Insertar_Conexion";
                COMANDO.Connection = CONEXION;
                COMANDO.Parameters.AddRange(paramD);
                COMANDO.ExecuteNonQuery();
                msj = "Ingresado Correctamente";
            }
            return msj;
        }

        public string EliminarCliente(string NomCliente, string ModeloAut, int Auto, string salid)
        {
            string msj = "";
            try
            {
                SqlParameter[] paramD = new SqlParameter[4];
                paramD[0] = new SqlParameter("@NomCli", SqlDbType.VarChar);
                paramD[0].Value = NomCliente;
                paramD[1] = new SqlParameter("@ModAuto", SqlDbType.VarChar);
                paramD[1].Value = ModeloAut;
                paramD[2] = new SqlParameter("@Autoo", SqlDbType.Int);
                paramD[2].Value = Auto;
                paramD[3] = new SqlParameter("@salida", SqlDbType.Date);
                paramD[3].Value = salid;
                COMANDO.CommandType = CommandType.StoredProcedure;
                COMANDO.CommandText = "Eliminar_Cliente";
                COMANDO.Connection = CONEXION;
                COMANDO.Parameters.AddRange(paramD);
                COMANDO.ExecuteNonQuery();
                msj = "Ingresado Correctamente";
            }
            catch (Exception)
            {
                SqlParameter[] paramD = new SqlParameter[4];
                paramD[0] = new SqlParameter("@NomCli", SqlDbType.VarChar);
                paramD[0].Value = NomCliente;
                paramD[1] = new SqlParameter("@ModAuto", SqlDbType.VarChar);
                paramD[1].Value = ModeloAut;
                paramD[2] = new SqlParameter("@Autoo", SqlDbType.Int);
                paramD[2].Value = Auto;
                paramD[3] = new SqlParameter("@salida", SqlDbType.Date);
                paramD[3].Value = salid;
                COMANDO.CommandType = CommandType.StoredProcedure;
                COMANDO.CommandText = "Eliminar_Cliente";
                COMANDO.Connection = CONEXION;
                COMANDO.Parameters.AddRange(paramD);
                COMANDO.ExecuteNonQuery();
                msj = "Ingresado Correctamente";
            }
            return msj;
        }

        public string ModificarNomCliente(string Nombre1, string Nomb2)
        {
            string msj = "";
            try
            {
                SqlParameter[] paramD = new SqlParameter[2];
                paramD[0] = new SqlParameter("@Nom1", SqlDbType.VarChar);
                paramD[0].Value = Nombre1;
                paramD[1] = new SqlParameter("@NomMod", SqlDbType.VarChar);
                paramD[1].Value = Nomb2;
                COMANDO.CommandType = CommandType.StoredProcedure;
                COMANDO.CommandText = "Modificar_NomCliente";
                COMANDO.Connection = CONEXION;
                COMANDO.Parameters.AddRange(paramD);
                COMANDO.ExecuteNonQuery();
                msj = "Ingresado Correctamente";
            }
            catch (Exception)
            {
                SqlParameter[] paramD = new SqlParameter[2];
                paramD[0] = new SqlParameter("@Nom1", SqlDbType.VarChar);
                paramD[0].Value = Nombre1;
                paramD[1] = new SqlParameter("@NomMod", SqlDbType.VarChar);
                paramD[1].Value = Nomb2;
                COMANDO.CommandType = CommandType.StoredProcedure;
                COMANDO.CommandText = "Modificar_NomCliente";
                COMANDO.Connection = CONEXION;
                COMANDO.Parameters.AddRange(paramD);
                COMANDO.ExecuteNonQuery();
                msj = "Ingresado Correctamente";
            }
            return msj;
        }


        public string ModificarCelCliente(string Celular1, string Celu2)
        {
            string msj = "";
            try
            {
                SqlParameter[] paramD = new SqlParameter[2];
                paramD[0] = new SqlParameter("@cel1", SqlDbType.VarChar);
                paramD[0].Value = Celular1;
                paramD[1] = new SqlParameter("@celMod", SqlDbType.VarChar);
                paramD[1].Value = Celu2;
                COMANDO.CommandType = CommandType.StoredProcedure;
                COMANDO.CommandText = "Modificar_CelCliente";
                COMANDO.Connection = CONEXION;
                COMANDO.Parameters.AddRange(paramD);
                COMANDO.ExecuteNonQuery();
                msj = "Ingresado Correctamente";
            }
            catch (Exception)
            {
                SqlParameter[] paramD = new SqlParameter[2];
                paramD[0] = new SqlParameter("@cel1", SqlDbType.VarChar);
                paramD[0].Value = Celular1;
                paramD[1] = new SqlParameter("@celMod", SqlDbType.VarChar);
                paramD[1].Value = Celu2;
                COMANDO.CommandType = CommandType.StoredProcedure;
                COMANDO.CommandText = "Modificar_CelCliente";
                COMANDO.Connection = CONEXION;
                COMANDO.Parameters.AddRange(paramD);
                COMANDO.ExecuteNonQuery();
                msj = "Ingresado Correctamente";
            }
            return msj;
        }


        public string ModificarTelCliente(string Telefono1, string Telef2)
        {
            string msj = "";
            try
            {
                SqlParameter[] paramD = new SqlParameter[2];
                paramD[0] = new SqlParameter("@tel1", SqlDbType.VarChar);
                paramD[0].Value = Telefono1;
                paramD[1] = new SqlParameter("@telMod", SqlDbType.VarChar);
                paramD[1].Value = Telef2;
                COMANDO.CommandType = CommandType.StoredProcedure;
                COMANDO.CommandText = "Modificar_TelCliente";
                COMANDO.Connection = CONEXION;
                COMANDO.Parameters.AddRange(paramD);
                COMANDO.ExecuteNonQuery();
                msj = "Ingresado Correctamente";
            }
            catch (Exception)
            {
                SqlParameter[] paramD = new SqlParameter[2];
                paramD[0] = new SqlParameter("@tel1", SqlDbType.VarChar);
                paramD[0].Value = Telefono1;
                paramD[1] = new SqlParameter("@telMod", SqlDbType.VarChar);
                paramD[1].Value = Telef2;
                COMANDO.CommandType = CommandType.StoredProcedure;
                COMANDO.CommandText = "Modificar_TelCliente";
                COMANDO.Connection = CONEXION;
                COMANDO.Parameters.AddRange(paramD);
                COMANDO.ExecuteNonQuery();
                msj = "Ingresado Correctamente";
            }
            return msj;
        }


        public string ModificarCorrPCliente(string CorreoP1, string CorreoP2)
        {
            string msj = "";
            try
            {
                SqlParameter[] paramD = new SqlParameter[2];
                paramD[0] = new SqlParameter("@corP1", SqlDbType.VarChar);
                paramD[0].Value = CorreoP1;
                paramD[1] = new SqlParameter("@corPMod", SqlDbType.VarChar);
                paramD[1].Value = CorreoP2;
                COMANDO.CommandType = CommandType.StoredProcedure;
                COMANDO.CommandText = "Modificar_CorrPCliente";
                COMANDO.Connection = CONEXION;
                COMANDO.Parameters.AddRange(paramD);
                COMANDO.ExecuteNonQuery();
                msj = "Ingresado Correctamente";
            }
            catch (Exception)
            {
                SqlParameter[] paramD = new SqlParameter[2];
                paramD[0] = new SqlParameter("@corP1", SqlDbType.VarChar);
                paramD[0].Value = CorreoP1;
                paramD[1] = new SqlParameter("@corPMod", SqlDbType.VarChar);
                paramD[1].Value = CorreoP2;
                COMANDO.CommandType = CommandType.StoredProcedure;
                COMANDO.CommandText = "Modificar_CorrPCliente";
                COMANDO.Connection = CONEXION;
                COMANDO.Parameters.AddRange(paramD);
                COMANDO.ExecuteNonQuery();
                msj = "Ingresado Correctamente";
            }
            return msj;
        }

        public string ModificarCorrCorCliente(string CorreoCo1, string CorreoCo2)
        {
            string msj = "";
            try
            {
                SqlParameter[] paramD = new SqlParameter[2];
                paramD[0] = new SqlParameter("@corCor1", SqlDbType.VarChar);
                paramD[0].Value = CorreoCo1;
                paramD[1] = new SqlParameter("@corCorMod", SqlDbType.VarChar);
                paramD[1].Value = CorreoCo2;
                COMANDO.CommandType = CommandType.StoredProcedure;
                COMANDO.CommandText = "Modificar_CorrCorCliente";
                COMANDO.Connection = CONEXION;
                COMANDO.Parameters.AddRange(paramD);
                COMANDO.ExecuteNonQuery();
                msj = "Ingresado Correctamente";
            }
            catch (Exception)
            {
                SqlParameter[] paramD = new SqlParameter[2];
                paramD[0] = new SqlParameter("@corCor1", SqlDbType.VarChar);
                paramD[0].Value = CorreoCo1;
                paramD[1] = new SqlParameter("@corCorMod", SqlDbType.VarChar);
                paramD[1].Value = CorreoCo2;
                COMANDO.CommandType = CommandType.StoredProcedure;
                COMANDO.CommandText = "Modificar_CorrCorCliente";
                COMANDO.Connection = CONEXION;
                COMANDO.Parameters.AddRange(paramD);
                COMANDO.ExecuteNonQuery();
                msj = "Ingresado Correctamente";
            }
            return msj;
        }

        public string BusquedaCliente(string nombrr)
        {
            string m = "";
            try
            {
                SqlParameter[] paramD = new SqlParameter[1];
                paramD[0] = new SqlParameter("@Nom", SqlDbType.VarChar);
                paramD[0].Value = nombrr;
                COMANDO.CommandType = CommandType.StoredProcedure;
                COMANDO.CommandText = "Busqueda_Cliente";
                COMANDO.Connection = CONEXION;
                COMANDO.Parameters.AddRange(paramD);
                COMANDO.ExecuteNonQuery();
                m = "Ingresado Correctamente";
            }
            catch (Exception)
            {
                SqlParameter[] paramD = new SqlParameter[1];
                paramD[0] = new SqlParameter("@Nom", SqlDbType.VarChar);
                paramD[0].Value = nombrr;
                COMANDO.CommandType = CommandType.StoredProcedure;
                COMANDO.CommandText = "Busqueda_Cliente";
                COMANDO.Connection = CONEXION;
                COMANDO.Parameters.AddRange(paramD);
                COMANDO.ExecuteNonQuery();
                m = "Ingresado Correctamente";
            }
            return m;
        }

    }
}
