namespace DinosGimnasio
{
    partial class FormMenu
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
            this.cboMensualidad = new System.Windows.Forms.ComboBox();
            this.btnAgregarImagen = new System.Windows.Forms.Button();
            this.pickImagen = new System.Windows.Forms.PictureBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.BtnReset = new System.Windows.Forms.Button();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.txtApelido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.lblMensualidad = new System.Windows.Forms.Label();
            this.lblDni = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblClave = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblPeso = new System.Windows.Forms.Label();
            this.lblAltura = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.BtnTomarFoto = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pickImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.BtnTomarFoto);
            this.panel1.Controls.Add(this.lbl);
            this.panel1.Controls.Add(this.lblAltura);
            this.panel1.Controls.Add(this.lblPeso);
            this.panel1.Controls.Add(this.lblFecha);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cboMensualidad);
            this.panel1.Controls.Add(this.btnAgregarImagen);
            this.panel1.Controls.Add(this.pickImagen);
            this.panel1.Controls.Add(this.btnAceptar);
            this.panel1.Controls.Add(this.BtnReset);
            this.panel1.Controls.Add(this.txtDni);
            this.panel1.Controls.Add(this.txtApelido);
            this.panel1.Controls.Add(this.txtNombre);
            this.panel1.Controls.Add(this.txtClave);
            this.panel1.Controls.Add(this.lblMensualidad);
            this.panel1.Controls.Add(this.lblDni);
            this.panel1.Controls.Add(this.lblApellido);
            this.panel1.Controls.Add(this.lblNombre);
            this.panel1.Controls.Add(this.lblClave);
            this.panel1.Location = new System.Drawing.Point(265, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(626, 565);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // cboMensualidad
            // 
            this.cboMensualidad.FormattingEnabled = true;
            this.cboMensualidad.Location = new System.Drawing.Point(240, 218);
            this.cboMensualidad.Name = "cboMensualidad";
            this.cboMensualidad.Size = new System.Drawing.Size(114, 21);
            this.cboMensualidad.TabIndex = 15;
            // 
            // btnAgregarImagen
            // 
            this.btnAgregarImagen.Location = new System.Drawing.Point(400, 339);
            this.btnAgregarImagen.Name = "btnAgregarImagen";
            this.btnAgregarImagen.Size = new System.Drawing.Size(71, 21);
            this.btnAgregarImagen.TabIndex = 14;
            this.btnAgregarImagen.Text = "agregar";
            this.btnAgregarImagen.UseVisualStyleBackColor = true;
            // 
            // pickImagen
            // 
            this.pickImagen.BackColor = System.Drawing.Color.AliceBlue;
            this.pickImagen.Location = new System.Drawing.Point(223, 330);
            this.pickImagen.Name = "pickImagen";
            this.pickImagen.Size = new System.Drawing.Size(171, 152);
            this.pickImagen.TabIndex = 13;
            this.pickImagen.TabStop = false;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(346, 517);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(95, 22);
            this.btnAceptar.TabIndex = 11;
            this.btnAceptar.Text = "Agregar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            // 
            // BtnReset
            // 
            this.BtnReset.Location = new System.Drawing.Point(184, 517);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.Size = new System.Drawing.Size(95, 22);
            this.BtnReset.TabIndex = 10;
            this.BtnReset.Text = "Cancelar";
            this.BtnReset.UseVisualStyleBackColor = true;
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(240, 172);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(114, 20);
            this.txtDni.TabIndex = 8;
            // 
            // txtApelido
            // 
            this.txtApelido.Location = new System.Drawing.Point(240, 129);
            this.txtApelido.Name = "txtApelido";
            this.txtApelido.Size = new System.Drawing.Size(114, 20);
            this.txtApelido.TabIndex = 7;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(240, 85);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(114, 20);
            this.txtNombre.TabIndex = 6;
            // 
            // txtClave
            // 
            this.txtClave.Location = new System.Drawing.Point(240, 38);
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(114, 20);
            this.txtClave.TabIndex = 5;
            // 
            // lblMensualidad
            // 
            this.lblMensualidad.AutoSize = true;
            this.lblMensualidad.Location = new System.Drawing.Point(156, 221);
            this.lblMensualidad.Name = "lblMensualidad";
            this.lblMensualidad.Size = new System.Drawing.Size(67, 13);
            this.lblMensualidad.TabIndex = 4;
            this.lblMensualidad.Text = "Mensualidad";
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Location = new System.Drawing.Point(156, 175);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(35, 13);
            this.lblDni.TabIndex = 3;
            this.lblDni.Text = "D.N. I";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(156, 132);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(44, 13);
            this.lblApellido.TabIndex = 2;
            this.lblApellido.Text = "Apellido";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(156, 88);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre";
            // 
            // lblClave
            // 
            this.lblClave.AutoSize = true;
            this.lblClave.Location = new System.Drawing.Point(166, 38);
            this.lblClave.Name = "lblClave";
            this.lblClave.Size = new System.Drawing.Size(34, 13);
            this.lblClave.TabIndex = 0;
            this.lblClave.Text = "Clave";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(450, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Observaciones";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(240, 282);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(107, 20);
            this.dateTimePicker1.TabIndex = 18;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(453, 176);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(114, 20);
            this.textBox1.TabIndex = 21;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(453, 132);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(114, 20);
            this.textBox2.TabIndex = 20;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(453, 85);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(114, 20);
            this.textBox3.TabIndex = 19;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(156, 288);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(53, 13);
            this.lblFecha.TabIndex = 22;
            this.lblFecha.Text = "Incripcion";
            // 
            // lblPeso
            // 
            this.lblPeso.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.lblPeso.AutoSize = true;
            this.lblPeso.Location = new System.Drawing.Point(385, 92);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(31, 13);
            this.lblPeso.TabIndex = 23;
            this.lblPeso.Text = "Peso";
            // 
            // lblAltura
            // 
            this.lblAltura.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.lblAltura.AutoSize = true;
            this.lblAltura.Location = new System.Drawing.Point(385, 136);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(34, 13);
            this.lblAltura.TabIndex = 24;
            this.lblAltura.Text = "Altura";
            // 
            // lbl
            // 
            this.lbl.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(385, 183);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(46, 13);
            this.lbl.TabIndex = 25;
            this.lbl.Text = "Objetivo";
            // 
            // BtnTomarFoto
            // 
            this.BtnTomarFoto.Location = new System.Drawing.Point(400, 391);
            this.BtnTomarFoto.Name = "BtnTomarFoto";
            this.BtnTomarFoto.Size = new System.Drawing.Size(71, 21);
            this.BtnTomarFoto.TabIndex = 26;
            this.BtnTomarFoto.Text = "Sacar Foto";
            this.BtnTomarFoto.UseVisualStyleBackColor = true;
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1195, 682);
            this.Controls.Add(this.panel1);
            this.Name = "FormMenu";
            this.Text = "FormMenu";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pickImagen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblMensualidad;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblClave;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.TextBox txtApelido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.Button btnAgregarImagen;
        private System.Windows.Forms.PictureBox pickImagen;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button BtnReset;
        private System.Windows.Forms.ComboBox cboMensualidad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnTomarFoto;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}