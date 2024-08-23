namespace PROYECTOBASES.Presentacion
{
    partial class Frm_CrearVendedor
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
            this.SuspendLayout();
            // 
            // btnCrearVendedor
            // 
            this.btnCrearVendedor.Location = new System.Drawing.Point(272, 251);
            this.btnCrearVendedor.Name = "btnCrearVendedor";
            this.btnCrearVendedor.Size = new System.Drawing.Size(135, 40);
            this.btnCrearVendedor.TabIndex = 21;
            this.btnCrearVendedor.Text = "Crear";
            this.btnCrearVendedor.UseVisualStyleBackColor = true;
            this.btnCrearVendedor.Click += new System.EventHandler(this.btnCrearVendedor_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(241, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Telefono";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(241, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Correo";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtTelefonoVendedor
            // 
            this.txtTelefonoVendedor.Location = new System.Drawing.Point(347, 147);
            this.txtTelefonoVendedor.Name = "txtTelefonoVendedor";
            this.txtTelefonoVendedor.Size = new System.Drawing.Size(117, 20);
            this.txtTelefonoVendedor.TabIndex = 14;
            this.txtTelefonoVendedor.TextChanged += new System.EventHandler(this.txtTelefonoVendedor_TextChanged);
            // 
            // txtCorreoVendedor
            // 
            this.txtCorreoVendedor.Location = new System.Drawing.Point(347, 101);
            this.txtCorreoVendedor.Name = "txtCorreoVendedor";
            this.txtCorreoVendedor.Size = new System.Drawing.Size(117, 20);
            this.txtCorreoVendedor.TabIndex = 13;
            this.txtCorreoVendedor.TextChanged += new System.EventHandler(this.txtCorreoVendedor_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(241, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Nombre";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtNombreVendedor
            // 
            this.txtNombreVendedor.Location = new System.Drawing.Point(347, 58);
            this.txtNombreVendedor.Name = "txtNombreVendedor";
            this.txtNombreVendedor.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtNombreVendedor.Size = new System.Drawing.Size(117, 20);
            this.txtNombreVendedor.TabIndex = 11;
            this.txtNombreVendedor.TextChanged += new System.EventHandler(this.txtNombreVendedor_TextChanged);
            // 
            // Frm_CrearVendedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCrearVendedor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTelefonoVendedor);
            this.Controls.Add(this.txtCorreoVendedor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNombreVendedor);
            this.Name = "Frm_CrearVendedor";
            this.Text = "Frm_CrearVendedor";
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
    }
}