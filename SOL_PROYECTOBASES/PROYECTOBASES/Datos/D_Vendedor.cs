using System;
using System.Data;
using System.Data.SqlClient;
using PROYECTOBASES.Datos;  // Asegúrate de incluir el namespace donde está tu clase de conexión

public class VendedorService
{
    private conexion _conexion;

    // Constructor para inicializar la instancia de conexión
    public VendedorService()
    {
        _conexion = conexion.getInstancia();  // Utiliza el patrón Singleton para obtener la instancia de conexión
    }

    // Método para crear un vendedor
    public void CrearVendedor(string nombre, string correo, string telefono)
    {
        using (SqlConnection connection = _conexion.CrearConexion())
        {
            try
            {
                connection.Open();  // Abrir la conexión

                using (SqlCommand command = new SqlCommand("CrearVendedor", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    // Agregar los parámetros al comando
                    command.Parameters.AddWithValue("@nombre", nombre);
                    command.Parameters.AddWithValue("@correo", correo);
                    command.Parameters.AddWithValue("@telefono", telefono);

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

    // Método para eliminar un vendedor
    public void EliminarVendedor(int id)
    {
        using (SqlConnection connection = _conexion.CrearConexion())
        {
            try
            {
                connection.Open();  // Abrir la conexión

                using (SqlCommand command = new SqlCommand("EliminarVendedor", connection))
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

    // Método para modificar un vendedor
    public void ModificarVendedor(int id, string nombre, string correo, string telefono)
    {
        using (SqlConnection connection = _conexion.CrearConexion())
        {
            try
            {
                connection.Open();  // Abrir la conexión

                using (SqlCommand command = new SqlCommand("ModificarVendedor", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    // Agregar los parámetros al comando
                    command.Parameters.AddWithValue("@id", id);
                    command.Parameters.AddWithValue("@nombre", nombre);
                    command.Parameters.AddWithValue("@correo", correo);
                    command.Parameters.AddWithValue("@telefono", telefono);

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
