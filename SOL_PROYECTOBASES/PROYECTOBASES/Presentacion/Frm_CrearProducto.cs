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
    public partial class Frm_CrearProducto : Form
    {
        public Frm_CrearProducto()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            try
            {
                // Recuperar los valores de los TextBox
                string nombreProducto = txtNombreProducto.Text.Trim();
                string tamañoProducto = txtTamaño.Text.Trim();
                string marcaProducto = txtMarca.Text.Trim();
                string nombreTipoProducto = txtTipo.Text.Trim();

                // Crear una instancia de ProductoService
                ProductoService productoService = new ProductoService();

                // Llamar al método para crear el producto y el tipo de producto
                productoService.CrearProductoYTipo(nombreProducto, tamañoProducto, marcaProducto, nombreTipoProducto);

                // Mostrar un mensaje de éxito
                MessageBox.Show("El producto y su tipo han sido creados exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // Manejar cualquier error que ocurra durante el proceso
                MessageBox.Show("Ocurrió un error al crear el producto: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
