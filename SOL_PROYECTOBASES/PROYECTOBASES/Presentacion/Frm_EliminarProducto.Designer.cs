namespace PROYECTOBASES.Presentacion
{
    partial class Frm_EliminarProducto
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtEliminarProducto = new System.Windows.Forms.TextBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(102, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID produto a eliminar";
            // 
            // txtEliminarProducto
            // 
            this.txtEliminarProducto.Location = new System.Drawing.Point(240, 107);
            this.txtEliminarProducto.Name = "txtEliminarProducto";
            this.txtEliminarProducto.Size = new System.Drawing.Size(100, 20);
            this.txtEliminarProducto.TabIndex = 2;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(192, 220);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // Frm_EliminarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 450);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.txtEliminarProducto);
            this.Controls.Add(this.label2);
            this.Name = "Frm_EliminarProducto";
            this.Text = "Frm_EliminarProducto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEliminarProducto;
        private System.Windows.Forms.Button btnEliminar;
    }
}