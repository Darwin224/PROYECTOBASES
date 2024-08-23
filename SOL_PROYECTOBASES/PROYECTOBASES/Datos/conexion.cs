using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTOBASES.Datos
{
    public class conexion
    {
        private string Base;
        private string Servidor;
        private string Usuario;
        private string Clave;
        private static conexion con = null;

        private conexion()
        {

            this.Base = "JETSTEREO";
            this.Servidor = "proyectosql.curh6fahahxm.us-east-1.rds.amazonaws.com";
            this.Usuario = "Admin";
            this.Clave = "Admin123";


        }

        public SqlConnection CrearConexion()
        {
            SqlConnection Cadena = new SqlConnection();
            try
            {
                Cadena.ConnectionString = "Server=" + this.Servidor + ",1433;" +  // Nota el uso del puerto 1433
                                  "Database=" + this.Base + ";" +
                                  "User Id=" + this.Usuario + ";" +
                                  "Password=" + this.Clave + ";";

            }
            catch (Exception ex)
            {
                Cadena = null;


                throw ex;
            }

            return Cadena;

        }

        public static conexion getInstancia()
        {
            if (con == null)
            {
                con = new conexion();

            }
            return con;
        }
    }

}
