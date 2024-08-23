namespace PROYECTOBASES.Presentacion
{
    partial class Frm_ModificarTienda
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
            this.btnModificar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtCiudad = new System.Windows.Forms.TextBox();
            this.txtPais = new System.Windows.Forms.TextBox();
            this.txtHorario = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(340, 345);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(135, 40);
            this.btnModificar.TabIndex = 21;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(289, 252);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Direccion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(289, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Ciudad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(289, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Pais";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(289, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Horario";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(395, 249);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(117, 20);
            this.txtDireccion.TabIndex = 16;
            // 
            // txtCiudad
            // 
            this.txtCiudad.Location = new System.Drawing.Point(395, 204);
            this.txtCiudad.Name = "txtCiudad";
            this.txtCiudad.Size = new System.Drawing.Size(117, 20);
            this.txtCiudad.TabIndex = 15;
            // 
            // txtPais
            // 
            this.txtPais.Location = new System.Drawing.Point(395, 154);
            this.txtPais.Name = "txtPais";
            this.txtPais.Size = new System.Drawing.Size(117, 20);
            this.txtPais.TabIndex = 14;
            // 
            // txtHorario
            // 
            this.txtHorario.Location = new System.Drawing.Point(395, 108);
            this.txtHorario.Name = "txtHorario";
            this.txtHorario.Size = new System.Drawing.Size(117, 20);
            this.txtHorario.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(289, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(395, 65);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtNombre.Size = new System.Drawing.Size(117, 20);
            this.txtNombre.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(289, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "ID";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(395, 28);
            this.txtID.Name = "txtID";
            this.txtID.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtID.Size = new System.Drawing.Size(117, 20);
            this.txtID.TabIndex = 23;
            // 
            // Frm_ModificarTienda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtCiudad);
            this.Controls.Add(this.txtPais);
            this.Controls.Add(this.txtHorario);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtNombre);
            this.Name = "Frm_ModificarTienda";
            this.Text = "Frm_Modificar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtCiudad;
        private System.Windows.Forms.TextBox txtPais;
        private System.Windows.Forms.TextBox txtHorario;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtID;
    }
}