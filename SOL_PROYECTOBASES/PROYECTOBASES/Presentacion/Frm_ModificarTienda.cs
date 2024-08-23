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
    public partial class Frm_ModificarTienda : Form
    {
        public Frm_ModificarTienda()
        {
            InitializeComponent();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                // Recuperar los valores de los TextBox
                int idModificar;
                string id = txtID.Text.Trim();

                // Convertir el ID a entero
                if (!int.TryParse(id, out idModificar))
                {
                    MessageBox.Show("El ID debe ser un número entero válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string nombre = txtNombre.Text.Trim();
                string horario = txtHorario.Text.Trim();
                string pais = txtPais.Text.Trim();
                string ciudad = txtCiudad.Text.Trim();
                string direccion = txtDireccion.Text.Trim();

                // Crear una instancia de TiendaService
                TiendaService tiendaService = new TiendaService();

                // Llamar al método para modificar la tienda y su ubicación
                tiendaService.ModificarTiendaYUbicacion(idModificar, nombre, horario, pais, ciudad, direccion);

                // Mostrar un mensaje de éxito
                MessageBox.Show("La tienda ha sido modificada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // Manejar cualquier error que ocurra durante el proceso
                MessageBox.Show("Ocurrió un error al modificar la tienda: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
