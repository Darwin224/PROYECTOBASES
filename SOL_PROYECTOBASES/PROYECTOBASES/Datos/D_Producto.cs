using System;
using System.Data;
using System.Data.SqlClient;
using PROYECTOBASES.Datos;  // Asegúrate de incluir el namespace donde está tu clase de conexión

public class ProductoService
{
    private conexion _conexion;

    // Constructor para inicializar la instancia de conexión
    public ProductoService()
    {
        _conexion = conexion.getInstancia();  // Utiliza el patrón Singleton para obtener la instancia de conexión
    }

    // Método para crear un producto y un tipo de producto (correspondiente al procedimiento almacenado CrearProductoYTipo)
    public void CrearProductoYTipo(
    string productoNombre,
    string productoTamaño,
    string productoMarca,
    string tipoNombre,
    int idTienda,
    decimal precio,
    int reorden,
    int cantidad)
    {
        using (SqlConnection connection = _conexion.CrearConexion())
        {
            try
            {
                connection.Open();  // Abrir la conexión

                using (SqlCommand command = new SqlCommand("CrearProductoYTipo", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    // Agregar los parámetros al comando
                    command.Parameters.AddWithValue("@productoNombre", productoNombre);
                    command.Parameters.AddWithValue("@productoTamaño", productoTamaño);
                    command.Parameters.AddWithValue("@productoMarca", productoMarca);
                    command.Parameters.AddWithValue("@tipoNombre", tipoNombre);
                    command.Parameters.AddWithValue("@idTienda", idTienda);
                    command.Parameters.AddWithValue("@precio", precio);
                    command.Parameters.AddWithValue("@Reorden", reorden);
                    command.Parameters.AddWithValue("@Cantidad", cantidad);

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


    // Método para eliminar un producto (correspondiente al procedimiento almacenado EliminarProducto)
    public void EliminarProducto(int id)
    {
        using (SqlConnection connection = _conexion.CrearConexion())
        {
            try
            {
                connection.Open();  // Abrir la conexión

                using (SqlCommand command = new SqlCommand("EliminarProducto", connection))
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

    // Método para modificar un producto y el tipo de producto (correspondiente al procedimiento almacenado ModificarProductoYTipo)
    public void ModificarProductoYTipo(int id, string nombre, string tamaño, string marca, string nombreTipoProducto)
    {
        using (SqlConnection connection = _conexion.CrearConexion())
        {
            try
            {
                connection.Open();  // Abrir la conexión

                using (SqlCommand command = new SqlCommand("ModificarProductoYTipo", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    // Agregar los parámetros al comando
                    command.Parameters.AddWithValue("@id", id);
                    command.Parameters.AddWithValue("@nombre", nombre);
                    command.Parameters.AddWithValue("@tamaño", tamaño);
                    command.Parameters.AddWithValue("@marca", marca);
                    command.Parameters.AddWithValue("@nombreTipoProducto", nombreTipoProducto);

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
