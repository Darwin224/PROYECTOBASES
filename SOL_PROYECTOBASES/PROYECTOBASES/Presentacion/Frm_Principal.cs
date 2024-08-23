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
    public partial class Frm_Principal : Form
    {
        public Frm_Principal()
        {
            InitializeComponent();
        }

        // Manejar el evento Click del botón Aceptar
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            // Verificar si el RadioButton "Crear" está seleccionado
            bool esCrearSeleccionado = rdbCrear.Checked;

            // Verificar si el RadioButton "Tienda" está seleccionado
            bool esTiendaSeleccionado = rdbTienda.Checked;

            // Si se selecciona "Crear" y "Tienda", abrir el formulario de crear tienda
            if (esCrearSeleccionado && esTiendaSeleccionado)
            {
                // Abrir el formulario de crear tienda
                Frm_Tienda formularioCrearTienda = new Frm_Tienda();
                formularioCrearTienda.Show();
            }
            else if (rdbEliminar.Checked && rdbTienda.Checked)
            {
                Frm_EliminarTienda formularioEliminarTienda = new Frm_EliminarTienda();
                formularioEliminarTienda.Show();
            }
            else if (rdbModificar.Checked && rdbTienda.Checked)
            {
                // Aquí puedes implementar la lógica para abrir el formulario de modificar tienda
            }
            else if (rdbCrear.Checked && rdbVendedor.Checked)
            {
                // Aquí puedes implementar la lógica para abrir el formulario de crear proveedor
            }
            else if (rdbEliminar.Checked && rdbVendedor.Checked)
            {
                // Aquí puedes implementar la lógica para abrir el formulario de eliminar proveedor
            }
            else if (rdbModificar.Checked && rdbVendedor.Checked)
            {
                // Aquí puedes implementar la lógica para abrir el formulario de modificar proveedor
            }
            else if (rdbCrear.Checked && rdbProducto.Checked)
            {
                // Aquí puedes implementar la lógica para abrir el formulario de crear producto
            }
            else if (rdbEliminar.Checked && rdbProducto.Checked)
            {
                // Aquí puedes implementar la lógica para abrir el formulario de eliminar producto
            }
            else if (rdbModificar.Checked && rdbProducto.Checked)
            {
                // Aquí puedes implementar la lógica para abrir el formulario de modificar producto
            }
            else
            {
                // Mostrar un mensaje si no se ha seleccionado una opción válida
                MessageBox.Show("Por favor, seleccione una acción y una entidad.", "Selección inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    }
}
