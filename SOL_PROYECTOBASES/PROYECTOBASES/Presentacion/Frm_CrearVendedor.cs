﻿using System;
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
    public partial class Frm_CrearVendedor : Form
    {
        public Frm_CrearVendedor()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCrearVendedor_Click(object sender, EventArgs e)
        {
            try
            {
                // Recuperar los valores de los TextBox
                string nombre = txtNombreVendedor.Text.Trim();
                string correo = txtCorreoVendedor.Text.Trim();
                string telefono = txtTelefonoVendedor.Text.Trim();

                // Crear una instancia de VendedorService
                VendedorService vendedorService = new VendedorService();

                // Llamar al método para crear el vendedor
                vendedorService.CrearVendedor(nombre, correo, telefono);

                // Mostrar un mensaje de éxito
                MessageBox.Show("El vendedor ha sido creado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // Manejar cualquier error que ocurra durante el proceso
                MessageBox.Show("Ocurrió un error al crear el vendedor: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtTelefonoVendedor_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtCorreoVendedor_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNombreVendedor_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
