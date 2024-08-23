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
    public partial class Frm_EliminarVendedor : Form
    {
        public Frm_EliminarVendedor()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
    
        }

        private void frm_closing(object sender, FormClosingEventArgs e)
        {

        }

        private void btnEliminarVendedor_Click(object sender, EventArgs e)
        {
            try
            {
                // Recuperar el valor del TextBox
                int idVendedor = int.Parse(txtIdVendedorEliminar.Text.Trim());

                // Crear una instancia de VendedorService
                VendedorService vendedorService = new VendedorService();

                // Llamar al método para eliminar el vendedor
                vendedorService.EliminarVendedor(idVendedor);

                // Mostrar un mensaje de éxito
                MessageBox.Show("El vendedor ha sido eliminado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (FormatException)
            {
                // Manejar error de formato si el ID no es un número válido
                MessageBox.Show("Por favor, ingrese un ID de vendedor válido.", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                // Manejar cualquier otro error que ocurra durante el proceso
                MessageBox.Show("Ocurrió un error al eliminar el vendedor: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
