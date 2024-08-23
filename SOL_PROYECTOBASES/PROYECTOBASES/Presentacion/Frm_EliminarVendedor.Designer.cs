namespace PROYECTOBASES.Presentacion
{
    partial class Frm_EliminarVendedor
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnEliminarVendedor = new System.Windows.Forms.Button();
            this.txtIdVendedorEliminar = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(139, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "ID Vendedor";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnEliminarVendedor
            // 
            this.btnEliminarVendedor.Location = new System.Drawing.Point(243, 198);
            this.btnEliminarVendedor.Name = "btnEliminarVendedor";
            this.btnEliminarVendedor.Size = new System.Drawing.Size(170, 57);
            this.btnEliminarVendedor.TabIndex = 4;
            this.btnEliminarVendedor.Text = "Eliminar";
            this.btnEliminarVendedor.UseVisualStyleBackColor = true;
            // 
            // txtIdVendedorEliminar
            // 
            this.txtIdVendedorEliminar.Location = new System.Drawing.Point(313, 93);
            this.txtIdVendedorEliminar.Name = "txtIdVendedorEliminar";
            this.txtIdVendedorEliminar.Size = new System.Drawing.Size(100, 20);
            this.txtIdVendedorEliminar.TabIndex = 3;
            // 
            // Frm_EliminarVendedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEliminarVendedor);
            this.Controls.Add(this.txtIdVendedorEliminar);
            this.Name = "Frm_EliminarVendedor";
            this.Text = "Frm_EliminarVendedor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEliminarVendedor;
        private System.Windows.Forms.TextBox txtIdVendedorEliminar;
    }
}