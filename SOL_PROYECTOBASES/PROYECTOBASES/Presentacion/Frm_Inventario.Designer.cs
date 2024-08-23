namespace PROYECTOBASES.Presentacion
{
    partial class Frm_Inventario
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
            this.VistaInventario = new System.Windows.Forms.DataGridView();
            this.btnMostrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.VistaInventario)).BeginInit();
            this.SuspendLayout();
            // 
            // VistaInventario
            // 
            this.VistaInventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.VistaInventario.Location = new System.Drawing.Point(145, 26);
            this.VistaInventario.Name = "VistaInventario";
            this.VistaInventario.Size = new System.Drawing.Size(531, 257);
            this.VistaInventario.TabIndex = 0;
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(309, 384);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(75, 23);
            this.btnMostrar.TabIndex = 1;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // Frm_Inventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.VistaInventario);
            this.Name = "Frm_Inventario";
            this.Text = "Frm_Inventario";
            ((System.ComponentModel.ISupportInitialize)(this.VistaInventario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView VistaInventario;
        private System.Windows.Forms.Button btnMostrar;
    }
}