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
    public partial class Frm_EliminarProducto : Form
    {
        public Frm_EliminarProducto()
        {
            InitializeComponent();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener el ID del producto desde el TextBox
                int idProducto;
                if (!int.TryParse(txtEliminarProducto.Text.Trim(), out idProducto))
                {
                    MessageBox.Show("Por favor, ingrese un ID de producto válido.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Crear una instancia de ProductoService
                ProductoService productoService = new ProductoService();

                // Llamar al método para eliminar el producto
                productoService.EliminarProducto(idProducto);

                // Mostrar un mensaje de éxito
                MessageBox.Show("El producto ha sido eliminado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // Manejar cualquier error que ocurra durante el proceso
                MessageBox.Show("Ocurrió un error al eliminar el producto: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
