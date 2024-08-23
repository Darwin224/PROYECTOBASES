using PROYECTOBASES.Datos;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

public class VistaService
{
    private conexion _conexion;

    // Constructor para inicializar la instancia de conexión
    public VistaService()
    {
        _conexion = conexion.getInstancia();  // Utiliza el patrón Singleton para obtener la instancia de conexión
    }

    // Método para obtener datos de una vista
    public DataTable ObtenerDatosVista(string nombreVista)
    {
        DataTable dataTable = new DataTable();

        using (SqlConnection connection = _conexion.CrearConexion())
        {
            try
            {
                connection.Open();  // Abrir la conexión

                // Crear el comando SQL para seleccionar datos de la vista
                using (SqlCommand command = new SqlCommand($"SELECT * FROM {nombreVista}", connection))
                {
                    // Crear un adaptador para llenar el DataTable
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(dataTable);
                    }
                }
            }
            catch (Exception ex)
            {
                // Manejar errores de conexión y SQL
                MessageBox.Show("Ocurrió un error al obtener datos de la vista: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        return dataTable;
    }
}
