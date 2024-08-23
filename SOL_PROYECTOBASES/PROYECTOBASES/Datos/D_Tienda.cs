using System;
using System.Data;
using System.Data.SqlClient;
using PROYECTOBASES.Datos;  // Asegúrate de incluir el namespace donde está tu clase de conexión

public class TiendaService
{
    private conexion _conexion;

    // Constructor para inicializar la instancia de conexión
    public TiendaService()
    {
        _conexion = conexion.getInstancia();  // Utiliza el patrón Singleton para obtener la instancia de conexión
    }

    // Método para ejecutar el procedimiento almacenado
    public void CrearTienda(string nombre, string horario, string pais, string ciudad, string direccion)
    {
        // Utiliza el método CrearConexion de tu clase conexion para obtener una conexión SQL
        using (SqlConnection connection = _conexion.CrearConexion())
        {
            try
            {
                connection.Open();  // Abrir la conexión

                // Crear el comando SQL para el procedimiento almacenado
                using (SqlCommand command = new SqlCommand("CrearTienda", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    // Agregar los parámetros al comando
                    command.Parameters.AddWithValue("@nombre", nombre);
                    command.Parameters.AddWithValue("@horario", horario);
                    command.Parameters.AddWithValue("@pais", pais);
                    command.Parameters.AddWithValue("@ciudad", ciudad);
                    command.Parameters.AddWithValue("@direccion", direccion);

                    // Ejecutar el procedimiento almacenado
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                // Manejar errores de conexión y SQL
                Console.WriteLine("Ocurrió un error: " + ex.Message);
                throw;
            }
            finally
            {
                // Cerrar la conexión si está abierta
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }
    }

    public void EliminarTienda(int id)
    {
        using (SqlConnection connection = _conexion.CrearConexion())
        {
            try
            {
                connection.Open();  // Abrir la conexión

                using (SqlCommand command = new SqlCommand("EliminarTienda", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    // Agregar el parámetro al comando
                    command.Parameters.AddWithValue("@id", id);

                    // Ejecutar el procedimiento almacenado
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                // Manejar errores de conexión y SQL
                Console.WriteLine("Ocurrió un error: " + ex.Message);
                throw;
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }
    }
    public void ModificarTiendaYUbicacion(int id, string nombre, string horario, string pais, string ciudad, string direccion)
    {
        using (SqlConnection connection = _conexion.CrearConexion())
        {
            try
            {
                connection.Open();  // Abrir la conexión

                using (SqlCommand command = new SqlCommand("ModificarTiendaYUbicacion", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    // Agregar los parámetros al comando
                    command.Parameters.AddWithValue("@id", id);
                    command.Parameters.AddWithValue("@nombre", nombre);
                    command.Parameters.AddWithValue("@horario", horario);
                    command.Parameters.AddWithValue("@pais", pais);
                    command.Parameters.AddWithValue("@ciudad", ciudad);
                    command.Parameters.AddWithValue("@direccion", direccion);

                    // Ejecutar el procedimiento almacenado
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                // Manejar errores de conexión y SQL
                Console.WriteLine("Ocurrió un error: " + ex.Message);
                throw;
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }
    }
}
