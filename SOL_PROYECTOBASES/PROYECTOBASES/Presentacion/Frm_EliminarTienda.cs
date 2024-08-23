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
    public partial class Frm_EliminarTienda : Form
    {
        public Frm_EliminarTienda()
        {
            InitializeComponent();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // Crear una instancia del servicio Tienda
            TiendaService tiendaService = new TiendaService();

            try
            {
                // Verificar que el contenido del TextBox no esté vacío
                if (!string.IsNullOrWhiteSpace(txtIdEliminar.Text))
                {
                    // Convertir el valor del TextBox a un entero
                    int id;
                    if (int.TryParse(txtIdEliminar.Text, out id))
                    {
                        // Llamar al método para eliminar la tienda
                        tiendaService.EliminarTienda(id);

                        // Mostrar un mensaje de éxito
                        MessageBox.Show("Tienda eliminada correctamente.");
                    }
                    else
                    {
                        // Mostrar un mensaje de error si la conversión falla
                        MessageBox.Show("El ID ingresado no es válido.");
                    }
                }
                else
                {
                    // Mostrar un mensaje de advertencia si el TextBox está vacío
                    MessageBox.Show("Por favor, ingrese un ID para eliminar.");
                }
            }
            catch (Exception ex)
            {
                // Manejar cualquier excepción que ocurra durante el proceso de eliminación
                MessageBox.Show("Ocurrió un error al eliminar la tienda: " + ex.Message);
            }
        }
    }
}
