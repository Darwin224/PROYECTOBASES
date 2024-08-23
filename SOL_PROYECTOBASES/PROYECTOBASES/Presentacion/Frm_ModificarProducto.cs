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
    public partial class Frm_ModificarProducto : Form
    {
        public Frm_ModificarProducto()
        {
            InitializeComponent();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                // Recuperar los valores de los TextBox
                int idProducto = int.Parse(txtIdModificar.Text.Trim());
                string nombre = txtNombreProducto.Text.Trim();
                string tamaño = txtTamaño.Text.Trim();
                string marca = txtMarca.Text.Trim();
                string nombreTipoProducto = txtTipo.Text.Trim();

                // Crear una instancia de ProductoService
                ProductoService productoService = new ProductoService();

                // Llamar al método para modificar el producto y su tipo
                productoService.ModificarProductoYTipo(idProducto, nombre, tamaño, marca, nombreTipoProducto);

                // Mostrar un mensaje de éxito
                MessageBox.Show("El producto ha sido modificado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (FormatException)
            {
                // Manejar errores de formato (por ejemplo, si el ID no es un número válido)
                MessageBox.Show("Por favor, ingrese un ID de producto válido.", "Error de Formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                // Manejar cualquier otro error que ocurra durante el proceso
                MessageBox.Show("Ocurrió un error al modificar el producto: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
