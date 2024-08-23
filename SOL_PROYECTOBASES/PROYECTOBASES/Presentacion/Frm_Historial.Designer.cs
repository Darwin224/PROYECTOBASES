namespace PROYECTOBASES.Presentacion
{
    partial class Frm_Historial
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
            this.HistorialVentas = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.txtHistorial = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.HistorialVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // HistorialVentas
            // 
            this.HistorialVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.HistorialVentas.Location = new System.Drawing.Point(31, 39);
            this.HistorialVentas.Name = "HistorialVentas";
            this.HistorialVentas.Size = new System.Drawing.Size(738, 268);
            this.HistorialVentas.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(334, 389);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtHistorial
            // 
            this.txtHistorial.Location = new System.Drawing.Point(323, 329);
            this.txtHistorial.Name = "txtHistorial";
            this.txtHistorial.Size = new System.Drawing.Size(100, 20);
            this.txtHistorial.TabIndex = 2;
            // 
            // Frm_Historial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtHistorial);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.HistorialVentas);
            this.Name = "Frm_Historial";
            this.Text = "Frm_Historial";
            ((System.ComponentModel.ISupportInitialize)(this.HistorialVentas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView HistorialVentas;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtHistorial;
    }
}