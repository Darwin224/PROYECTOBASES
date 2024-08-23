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
                Frm_CrearTienda formularioCrearTienda = new Frm_CrearTienda();
                formularioCrearTienda.Show();
            }
            else if (rdbEliminar.Checked && rdbTienda.Checked)
            {
                Frm_EliminarTienda formularioEliminarTienda = new Frm_EliminarTienda();
                formularioEliminarTienda.Show();
            }
            else if (rdbModificar.Checked && rdbTienda.Checked)
            {
                Frm_ModificarTienda formularioModificarTienda = new Frm_ModificarTienda();
                formularioModificarTienda.Show();
            }
            else if (rdbCrear.Checked && rdbVendedor.Checked)
            {
                Frm_CrearVendedor formularioCrearVendedor = new Frm_CrearVendedor();
                formularioCrearVendedor.Show();
            }
            else if (rdbEliminar.Checked && rdbVendedor.Checked)
            {
                Frm_EliminarVendedor formularioEliminarVendedor = new Frm_EliminarVendedor();
                formularioEliminarVendedor.Show();
            }
            else if (rdbModificar.Checked && rdbVendedor.Checked)
            {
                Frm_ModificarVendedor formularioModificarVendedor = new Frm_ModificarVendedor();
                formularioModificarVendedor.Show();
            }
            else if (rdbCrear.Checked && rdbProducto.Checked)
            {
                Frm_CrearProducto formularioCrearProducto = new Frm_CrearProducto();
                formularioCrearProducto.Show();
            }
            else if (rdbEliminar.Checked && rdbProducto.Checked)
            {
                Frm_EliminarProducto formularioEliminarrProducto = new Frm_EliminarProducto();
                formularioEliminarrProducto.Show();
            }
            else if (rdbModificar.Checked && rdbProducto.Checked)
            {
                Frm_ModificarProducto formularioModificarProducto = new Frm_ModificarProducto();
                formularioModificarProducto.Show();
            }
            else if (rdbMostrar.Checked)
            {
                Frm_Inventario Inventario = new Frm_Inventario();
                Inventario.Show();
            }
            else
            {
                // Mostrar un mensaje si no se ha seleccionado una opción válida
                MessageBox.Show("Por favor, seleccione una acción y una entidad.", "Selección inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    }
}
