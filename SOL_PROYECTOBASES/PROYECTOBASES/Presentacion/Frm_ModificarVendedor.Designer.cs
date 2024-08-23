namespace PROYECTOBASES.Presentacion
{
    partial class Frm_ModificarVendedor
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
            this.btnCrearVendedor = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTelefonoVendedor = new System.Windows.Forms.TextBox();
            this.txtCorreoVendedor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombreVendedor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIdProveedor = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCrearVendedor
            // 
            this.btnCrearVendedor.Location = new System.Drawing.Point(164, 268);
            this.btnCrearVendedor.Name = "btnCrearVendedor";
            this.btnCrearVendedor.Size = new System.Drawing.Size(135, 40);
            this.btnCrearVendedor.TabIndex = 28;
            this.btnCrearVendedor.Text = "Modificar";
            this.btnCrearVendedor.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(135, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Telefono";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(135, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Correo";
            // 
            // txtTelefonoVendedor
            // 
            this.txtTelefonoVendedor.Location = new System.Drawing.Point(241, 218);
            this.txtTelefonoVendedor.Name = "txtTelefonoVendedor";
            this.txtTelefonoVendedor.Size = new System.Drawing.Size(117, 20);
            this.txtTelefonoVendedor.TabIndex = 25;
            // 
            // txtCorreoVendedor
            // 
            this.txtCorreoVendedor.Location = new System.Drawing.Point(241, 172);
            this.txtCorreoVendedor.Name = "txtCorreoVendedor";
            this.txtCorreoVendedor.Size = new System.Drawing.Size(117, 20);
            this.txtCorreoVendedor.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(135, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Nombre";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtNombreVendedor
            // 
            this.txtNombreVendedor.Location = new System.Drawing.Point(241, 129);
            this.txtNombreVendedor.Name = "txtNombreVendedor";
            this.txtNombreVendedor.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtNombreVendedor.Size = new System.Drawing.Size(117, 20);
            this.txtNombreVendedor.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(135, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "Id Proveedor";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtIdProveedor
            // 
            this.txtIdProveedor.Location = new System.Drawing.Point(241, 81);
            this.txtIdProveedor.Name = "txtIdProveedor";
            this.txtIdProveedor.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtIdProveedor.Size = new System.Drawing.Size(117, 20);
            this.txtIdProveedor.TabIndex = 29;
            this.txtIdProveedor.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Frm_ModificarVendedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtIdProveedor);
            this.Controls.Add(this.btnCrearVendedor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTelefonoVendedor);
            this.Controls.Add(this.txtCorreoVendedor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNombreVendedor);
            this.Name = "Frm_ModificarVendedor";
            this.Text = "Frm_ModificarVendedor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCrearVendedor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTelefonoVendedor;
        private System.Windows.Forms.TextBox txtCorreoVendedor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombreVendedor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIdProveedor;
    }
}