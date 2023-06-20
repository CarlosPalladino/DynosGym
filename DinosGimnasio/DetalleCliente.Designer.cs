namespace DinosGimnasio
{
    partial class DetalleCliente
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
            this.picPerdfil = new System.Windows.Forms.PictureBox();
            this.btnAtrás = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblContacto = new System.Windows.Forms.Label();
            this.lblPeso = new System.Windows.Forms.Label();
            this.lblDocumento = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.lblPago = new System.Windows.Forms.Label();
            this.lblMembresia = new System.Windows.Forms.Label();
            this.dateTimeFin = new System.Windows.Forms.DateTimePicker();
            this.DateTimeIncio = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.picPerdfil)).BeginInit();
            this.SuspendLayout();
            // 
            // picPerdfil
            // 
            this.picPerdfil.Location = new System.Drawing.Point(505, 94);
            this.picPerdfil.Name = "picPerdfil";
            this.picPerdfil.Size = new System.Drawing.Size(209, 214);
            this.picPerdfil.TabIndex = 0;
            this.picPerdfil.TabStop = false;
            // 
            // btnAtrás
            // 
            this.btnAtrás.Location = new System.Drawing.Point(238, 405);
            this.btnAtrás.Name = "btnAtrás";
            this.btnAtrás.Size = new System.Drawing.Size(75, 23);
            this.btnAtrás.TabIndex = 7;
            this.btnAtrás.Text = "Atrás";
            this.btnAtrás.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(418, 405);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Modficar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(60, 130);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 9;
            this.lblNombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(60, 183);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(35, 13);
            this.lblApellido.TabIndex = 10;
            this.lblApellido.Text = "label2";
            // 
            // lblContacto
            // 
            this.lblContacto.AutoSize = true;
            this.lblContacto.Location = new System.Drawing.Point(147, 130);
            this.lblContacto.Name = "lblContacto";
            this.lblContacto.Size = new System.Drawing.Size(35, 13);
            this.lblContacto.TabIndex = 11;
            this.lblContacto.Text = "label3";
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Location = new System.Drawing.Point(147, 183);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(35, 13);
            this.lblPeso.TabIndex = 12;
            this.lblPeso.Text = "label4";
            // 
            // lblDocumento
            // 
            this.lblDocumento.AutoSize = true;
            this.lblDocumento.Location = new System.Drawing.Point(228, 130);
            this.lblDocumento.Name = "lblDocumento";
            this.lblDocumento.Size = new System.Drawing.Size(35, 13);
            this.lblDocumento.TabIndex = 13;
            this.lblDocumento.Text = "label5";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(237, 183);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(35, 13);
            this.lblNumero.TabIndex = 14;
            this.lblNumero.Text = "label6";
            // 
            // lblPago
            // 
            this.lblPago.AutoSize = true;
            this.lblPago.Location = new System.Drawing.Point(341, 130);
            this.lblPago.Name = "lblPago";
            this.lblPago.Size = new System.Drawing.Size(35, 13);
            this.lblPago.TabIndex = 15;
            this.lblPago.Text = "label7";
            // 
            // lblMembresia
            // 
            this.lblMembresia.AutoSize = true;
            this.lblMembresia.Location = new System.Drawing.Point(341, 183);
            this.lblMembresia.Name = "lblMembresia";
            this.lblMembresia.Size = new System.Drawing.Size(35, 13);
            this.lblMembresia.TabIndex = 16;
            this.lblMembresia.Text = "label8";
            // 
            // dateTimeFin
            // 
            this.dateTimeFin.Location = new System.Drawing.Point(238, 288);
            this.dateTimeFin.Name = "dateTimeFin";
            this.dateTimeFin.Size = new System.Drawing.Size(200, 20);
            this.dateTimeFin.TabIndex = 17;
            this.dateTimeFin.ValueChanged += new System.EventHandler(this.dateTimeFin_ValueChanged);
            // 
            // DateTimeIncio
            // 
            this.DateTimeIncio.Location = new System.Drawing.Point(12, 288);
            this.DateTimeIncio.MinDate = new System.DateTime(1964, 6, 10, 0, 0, 0, 0);
            this.DateTimeIncio.Name = "DateTimeIncio";
            this.DateTimeIncio.Size = new System.Drawing.Size(200, 20);
            this.DateTimeIncio.TabIndex = 18;
            this.DateTimeIncio.ValueChanged += new System.EventHandler(this.DateTimeIncio_ValueChanged);
            // 
            // DetalleCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DateTimeIncio);
            this.Controls.Add(this.dateTimeFin);
            this.Controls.Add(this.lblMembresia);
            this.Controls.Add(this.lblPago);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.lblDocumento);
            this.Controls.Add(this.lblPeso);
            this.Controls.Add(this.lblContacto);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnAtrás);
            this.Controls.Add(this.picPerdfil);
            this.Name = "DetalleCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "DetalleCliente";
            this.Load += new System.EventHandler(this.DetalleCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picPerdfil)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picPerdfil;
        private System.Windows.Forms.Button btnAtrás;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblContacto;
        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.Label lblDocumento;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Label lblPago;
        private System.Windows.Forms.Label lblMembresia;
        private System.Windows.Forms.DateTimePicker dateTimeFin;
        private System.Windows.Forms.DateTimePicker DateTimeIncio;
    }
}