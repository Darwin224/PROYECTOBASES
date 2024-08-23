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
    public partial class Frm_Tienda : Form
    {
        public Frm_Tienda()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            try
            {
                // Recuperar los valores de los TextBox
                string nombre = txtNombre.Text.Trim();
                string horario = txtHorario.Text.Trim();
                string pais = txtPais.Text.Trim();
                string ciudad = txtCiudad.Text.Trim();
                string direccion = txtDireccion.Text.Trim();

                // Crear una instancia de TiendaService
                TiendaService tiendaService = new TiendaService();

                // Llamar al método para crear la tienda
                tiendaService.CrearTienda(nombre, horario, pais, ciudad, direccion);

                // Mostrar un mensaje de éxito
                MessageBox.Show("La tienda ha sido creada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // Manejar cualquier error que ocurra durante el proceso
                MessageBox.Show("Ocurrió un error al crear la tienda: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
