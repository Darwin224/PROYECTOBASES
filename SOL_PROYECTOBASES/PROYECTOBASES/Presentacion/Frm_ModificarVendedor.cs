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
    public partial class Frm_ModificarVendedor : Form
    {
        public Frm_ModificarVendedor()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnModificarVendedor_Click_1(object sender, EventArgs e)
        {
            try
            {
                // Recuperar los valores de los TextBox
                int idVendedor = int.Parse(txtIdModificarVendedor.Text.Trim());
                string nombre = txtNombreVendedor.Text.Trim();
                string correo = txtCorreoVendedor.Text.Trim();
                string telefono = txtTelefonoVendedor.Text.Trim();

                // Crear una instancia de VendedorService
                VendedorService vendedorService = new VendedorService();

                // Llamar al método para modificar el vendedor
                vendedorService.ModificarVendedor(idVendedor, nombre, correo, telefono);

                // Mostrar un mensaje de éxito
                MessageBox.Show("El vendedor ha sido modificado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (FormatException)
            {
                // Manejar error de formato si el ID no es un número válido
                MessageBox.Show("Por favor, ingrese un ID de vendedor válido.", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                // Manejar cualquier otro error que ocurra durante el proceso
                MessageBox.Show("Ocurrió un error al modificar el vendedor: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
