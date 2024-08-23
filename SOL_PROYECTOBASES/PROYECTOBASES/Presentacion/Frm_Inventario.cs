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
    public partial class Frm_Inventario : Form
    {
        public Frm_Inventario()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            try
            {
                // Crear una instancia de VistaService
                VistaService vistaService = new VistaService();

                // Obtener datos de la vista
                DataTable datosVista = vistaService.ObtenerDatosVista("Inventario_Productos");

                // Asignar el DataTable al DataGridView
                VistaInventario.DataSource = datosVista;

                // Mostrar un mensaje de éxito
                MessageBox.Show("Datos de la vista cargados exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // Manejar cualquier error que ocurra durante el proceso
                MessageBox.Show("Ocurrió un error al cargar los datos de la vista: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
