namespace DinosGimnasio
{
    partial class Registro
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblContacto = new System.Windows.Forms.Label();
            this.txtContacto = new System.Windows.Forms.TextBox();
            this.BtnTomarFoto = new System.Windows.Forms.Button();
            this.lblAltura = new System.Windows.Forms.Label();
            this.lblPeso = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.pickImagen = new System.Windows.Forms.PictureBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.BtnReset = new System.Windows.Forms.Button();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.txtApelido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblDni = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pickImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.btnAgregar);
            this.panel1.Controls.Add(this.lblContacto);
            this.panel1.Controls.Add(this.txtContacto);
            this.panel1.Controls.Add(this.BtnTomarFoto);
            this.panel1.Controls.Add(this.lblAltura);
            this.panel1.Controls.Add(this.lblPeso);
            this.panel1.Controls.Add(this.lblFecha);
            this.panel1.Controls.Add(this.txtAltura);
            this.panel1.Controls.Add(this.txtPeso);
            this.panel1.Controls.Add(this.dtpFecha);
            this.panel1.Controls.Add(this.pickImagen);
            this.panel1.Controls.Add(this.btnAceptar);
            this.panel1.Controls.Add(this.BtnReset);
            this.panel1.Controls.Add(this.txtDni);
            this.panel1.Controls.Add(this.txtApelido);
            this.panel1.Controls.Add(this.txtNombre);
            this.panel1.Controls.Add(this.lblDni);
            this.panel1.Controls.Add(this.lblApellido);
            this.panel1.Controls.Add(this.lblNombre);
            this.panel1.Location = new System.Drawing.Point(265, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(626, 510);
            this.panel1.TabIndex = 0;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(413, 321);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(71, 23);
            this.btnAgregar.TabIndex = 29;
            this.btnAgregar.Text = "agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblContacto
            // 
            this.lblContacto.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.lblContacto.AutoSize = true;
            this.lblContacto.Location = new System.Drawing.Point(264, 158);
            this.lblContacto.Name = "lblContacto";
            this.lblContacto.Size = new System.Drawing.Size(50, 13);
            this.lblContacto.TabIndex = 28;
            this.lblContacto.Text = "Contacto";
            // 
            // txtContacto
            // 
            this.txtContacto.Location = new System.Drawing.Point(348, 151);
            this.txtContacto.Name = "txtContacto";
            this.txtContacto.Size = new System.Drawing.Size(114, 20);
            this.txtContacto.TabIndex = 27;
            // 
            // BtnTomarFoto
            // 
            this.BtnTomarFoto.Location = new System.Drawing.Point(413, 362);
            this.BtnTomarFoto.Name = "BtnTomarFoto";
            this.BtnTomarFoto.Size = new System.Drawing.Size(71, 21);
            this.BtnTomarFoto.TabIndex = 26;
            this.BtnTomarFoto.Text = "Sacar Foto";
            this.BtnTomarFoto.UseVisualStyleBackColor = true;
            this.BtnTomarFoto.Click += new System.EventHandler(this.BtnTomarFoto_Click);
            // 
            // lblAltura
            // 
            this.lblAltura.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.lblAltura.AutoSize = true;
            this.lblAltura.Location = new System.Drawing.Point(43, 114);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(34, 13);
            this.lblAltura.TabIndex = 24;
            this.lblAltura.Text = "Altura";
            // 
            // lblPeso
            // 
            this.lblPeso.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.lblPeso.AutoSize = true;
            this.lblPeso.Location = new System.Drawing.Point(264, 114);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(31, 13);
            this.lblPeso.TabIndex = 23;
            this.lblPeso.Text = "Peso";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(43, 202);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(53, 13);
            this.lblFecha.TabIndex = 22;
            this.lblFecha.Text = "Incripcion";
            // 
            // txtAltura
            // 
            this.txtAltura.Location = new System.Drawing.Point(127, 107);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(114, 20);
            this.txtAltura.TabIndex = 20;
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(348, 107);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(114, 20);
            this.txtPeso.TabIndex = 19;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(134, 196);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(107, 20);
            this.dtpFecha.TabIndex = 18;
            // 
            // pickImagen
            // 
            this.pickImagen.BackColor = System.Drawing.Color.AliceBlue;
            this.pickImagen.Location = new System.Drawing.Point(222, 285);
            this.pickImagen.Name = "pickImagen";
            this.pickImagen.Size = new System.Drawing.Size(171, 152);
            this.pickImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pickImagen.TabIndex = 13;
            this.pickImagen.TabStop = false;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(348, 475);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(95, 22);
            this.btnAceptar.TabIndex = 11;
            this.btnAceptar.Text = "Agregar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // BtnReset
            // 
            this.BtnReset.Location = new System.Drawing.Point(186, 475);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.Size = new System.Drawing.Size(95, 22);
            this.BtnReset.TabIndex = 10;
            this.BtnReset.Text = "Cancelar";
            this.BtnReset.UseVisualStyleBackColor = true;
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(127, 151);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(114, 20);
            this.txtDni.TabIndex = 8;
            // 
            // txtApelido
            // 
            this.txtApelido.Location = new System.Drawing.Point(348, 67);
            this.txtApelido.Name = "txtApelido";
            this.txtApelido.Size = new System.Drawing.Size(114, 20);
            this.txtApelido.TabIndex = 7;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(127, 64);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(114, 20);
            this.txtNombre.TabIndex = 6;
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Location = new System.Drawing.Point(43, 158);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(35, 13);
            this.lblDni.TabIndex = 3;
            this.lblDni.Text = "D.N. I";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(264, 70);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(44, 13);
            this.lblApellido.TabIndex = 2;
            this.lblApellido.Text = "Apellido";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(43, 67);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre";
            // 
            // Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1195, 682);
            this.Controls.Add(this.panel1);
            this.Name = "Registro";
            this.Text = "Registro";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Registro_FormClosed);
            this.Load += new System.EventHandler(this.Registro_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pickImagen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.TextBox txtApelido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.PictureBox pickImagen;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button BtnReset;
        private System.Windows.Forms.Button BtnTomarFoto;
        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label lblContacto;
        private System.Windows.Forms.TextBox txtContacto;
        private System.Windows.Forms.Button btnAgregar;
    }
}