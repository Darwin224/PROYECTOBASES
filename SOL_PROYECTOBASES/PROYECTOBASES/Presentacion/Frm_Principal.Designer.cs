namespace PROYECTOBASES.Presentacion
{
    partial class Frm_Principal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.rdbCrear = new System.Windows.Forms.RadioButton();
            this.rdbEliminar = new System.Windows.Forms.RadioButton();
            this.rdbModificar = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdbTienda = new System.Windows.Forms.RadioButton();
            this.rdbProducto = new System.Windows.Forms.RadioButton();
            this.rdbVendedor = new System.Windows.Forms.RadioButton();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.rdbMostrar = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // rdbCrear
            // 
            this.rdbCrear.AutoSize = true;
            this.rdbCrear.Location = new System.Drawing.Point(43, 48);
            this.rdbCrear.Name = "rdbCrear";
            this.rdbCrear.Size = new System.Drawing.Size(50, 17);
            this.rdbCrear.TabIndex = 0;
            this.rdbCrear.TabStop = true;
            this.rdbCrear.Text = "Crear";
            this.rdbCrear.UseVisualStyleBackColor = true;
            // 
            // rdbEliminar
            // 
            this.rdbEliminar.AutoSize = true;
            this.rdbEliminar.Location = new System.Drawing.Point(43, 82);
            this.rdbEliminar.Name = "rdbEliminar";
            this.rdbEliminar.Size = new System.Drawing.Size(61, 17);
            this.rdbEliminar.TabIndex = 1;
            this.rdbEliminar.TabStop = true;
            this.rdbEliminar.Text = "Eliminar";
            this.rdbEliminar.UseVisualStyleBackColor = true;
            // 
            // rdbModificar
            // 
            this.rdbModificar.AutoSize = true;
            this.rdbModificar.Location = new System.Drawing.Point(43, 116);
            this.rdbModificar.Name = "rdbModificar";
            this.rdbModificar.Size = new System.Drawing.Size(68, 17);
            this.rdbModificar.TabIndex = 2;
            this.rdbModificar.TabStop = true;
            this.rdbModificar.Text = "Modificar";
            this.rdbModificar.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbMostrar);
            this.groupBox1.Controls.Add(this.rdbCrear);
            this.groupBox1.Controls.Add(this.rdbModificar);
            this.groupBox1.Controls.Add(this.rdbEliminar);
            this.groupBox1.Location = new System.Drawing.Point(22, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(219, 169);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdbTienda);
            this.groupBox2.Controls.Add(this.rdbProducto);
            this.groupBox2.Controls.Add(this.rdbVendedor);
            this.groupBox2.Location = new System.Drawing.Point(338, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(369, 209);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            // 
            // rdbTienda
            // 
            this.rdbTienda.AutoSize = true;
            this.rdbTienda.Location = new System.Drawing.Point(146, 56);
            this.rdbTienda.Name = "rdbTienda";
            this.rdbTienda.Size = new System.Drawing.Size(58, 17);
            this.rdbTienda.TabIndex = 3;
            this.rdbTienda.TabStop = true;
            this.rdbTienda.Text = "Tienda";
            this.rdbTienda.UseVisualStyleBackColor = true;
            // 
            // rdbProducto
            // 
            this.rdbProducto.AutoSize = true;
            this.rdbProducto.Location = new System.Drawing.Point(146, 124);
            this.rdbProducto.Name = "rdbProducto";
            this.rdbProducto.Size = new System.Drawing.Size(68, 17);
            this.rdbProducto.TabIndex = 5;
            this.rdbProducto.TabStop = true;
            this.rdbProducto.Text = "Producto";
            this.rdbProducto.UseVisualStyleBackColor = true;
            // 
            // rdbVendedor
            // 
            this.rdbVendedor.AutoSize = true;
            this.rdbVendedor.Location = new System.Drawing.Point(146, 90);
            this.rdbVendedor.Name = "rdbVendedor";
            this.rdbVendedor.Size = new System.Drawing.Size(71, 17);
            this.rdbVendedor.TabIndex = 4;
            this.rdbVendedor.TabStop = true;
            this.rdbVendedor.Text = "Vendedor";
            this.rdbVendedor.UseVisualStyleBackColor = true;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(276, 294);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 5;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // rdbMostrar
            // 
            this.rdbMostrar.AutoSize = true;
            this.rdbMostrar.Location = new System.Drawing.Point(43, 146);
            this.rdbMostrar.Name = "rdbMostrar";
            this.rdbMostrar.Size = new System.Drawing.Size(110, 17);
            this.rdbMostrar.TabIndex = 6;
            this.rdbMostrar.TabStop = true;
            this.rdbMostrar.Text = "Mostrar Inventario";
            this.rdbMostrar.UseVisualStyleBackColor = true;
            // 
            // Frm_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 407);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Frm_Principal";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton rdbCrear;
        private System.Windows.Forms.RadioButton rdbEliminar;
        private System.Windows.Forms.RadioButton rdbModificar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdbTienda;
        private System.Windows.Forms.RadioButton rdbProducto;
        private System.Windows.Forms.RadioButton rdbVendedor;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.RadioButton rdbMostrar;
    }
}