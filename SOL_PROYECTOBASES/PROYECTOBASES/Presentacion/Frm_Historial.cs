using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTOBASES.Presentacion
{
    public partial class Frm_Historial : Form
    {
        public Frm_Historial()
        {
            InitializeComponent();

        }

        private void CargarHistorialVentas(int idTienda)
        {
            try
            {
                // Crear una instancia de VistaService
                VistaService vistaService = new VistaService();

                // Obtener los datos del historial de ventas para la tienda especificada
                int id = int.Parse(txtHistorial.Text.Trim());  // Convertir el texto del TextBox a entero
                DataTable historialVentas = vistaService.ObtenerHistorialVentasPorTienda(id);

                // Asignar el DataTable al DataGridView
                HistorialVentas.DataSource = historialVentas;
            }
            catch (Exception ex)
            {
                // Manejar errores y mostrar mensaje
                MessageBox.Show("Ocurrió un error al cargar el historial de ventas: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Recuperar el ID de la tienda desde el TextBox
                int idTienda;
                if (int.TryParse(txtHistorial.Text.Trim(), out idTienda))
                {
                    // Crear una instancia de VistaService
                    VistaService vistaService = new VistaService();

                    // Llamar al método para obtener datos de la vista filtrados por ID
                    DataTable dtHistorial = vistaService.ObtenerHistorialVentasPorTienda(idTienda);

                    // Asignar el DataTable a un DataGridView o cualquier otro control para mostrar los datos
                    HistorialVentas.DataSource = dtHistorial;
                }
                else
                {
                    MessageBox.Show("Por favor, ingrese un ID válido.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                // Manejar cualquier error que ocurra durante el proceso
                MessageBox.Show("Ocurrió un error al mostrar el historial: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
