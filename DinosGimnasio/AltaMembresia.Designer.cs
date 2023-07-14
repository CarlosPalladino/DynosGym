namespace DinosGimnasio
{
    partial class AltaMembresia
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
            this.cboMembresia = new System.Windows.Forms.ComboBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.brnAceptar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lblMembresia = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.dateIncio = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cboMembresia
            // 
            this.cboMembresia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMembresia.FormattingEnabled = true;
            this.cboMembresia.Location = new System.Drawing.Point(264, 100);
            this.cboMembresia.Name = "cboMembresia";
            this.cboMembresia.Size = new System.Drawing.Size(183, 21);
            this.cboMembresia.TabIndex = 0;
            this.cboMembresia.SelectedIndexChanged += new System.EventHandler(this.cboMembresia_SelectedIndexChanged);
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(264, 160);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(183, 20);
            this.txtPrecio.TabIndex = 1;
            // 
            // brnAceptar
            // 
            this.brnAceptar.Location = new System.Drawing.Point(416, 344);
            this.brnAceptar.Name = "brnAceptar";
            this.brnAceptar.Size = new System.Drawing.Size(82, 30);
            this.brnAceptar.TabIndex = 2;
            this.brnAceptar.Text = "Agregar";
            this.brnAceptar.UseVisualStyleBackColor = true;
            this.brnAceptar.Click += new System.EventHandler(this.brnAceptar_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(256, 343);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 31);
            this.button2.TabIndex = 3;
            this.button2.Text = "cancelar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // lblMembresia
            // 
            this.lblMembresia.AutoSize = true;
            this.lblMembresia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMembresia.Location = new System.Drawing.Point(161, 105);
            this.lblMembresia.Name = "lblMembresia";
            this.lblMembresia.Size = new System.Drawing.Size(84, 16);
            this.lblMembresia.TabIndex = 4;
            this.lblMembresia.Text = "Membresia";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.Location = new System.Drawing.Point(161, 164);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(52, 16);
            this.lblPrecio.TabIndex = 5;
            this.lblPrecio.Text = "Precio";
            // 
            // dateIncio
            // 
            this.dateIncio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateIncio.Location = new System.Drawing.Point(334, 247);
            this.dateIncio.Name = "dateIncio";
            this.dateIncio.Size = new System.Drawing.Size(99, 20);
            this.dateIncio.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(208, 251);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Inicio";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(318, 35);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(115, 16);
            this.lblTitulo.TabIndex = 8;
            this.lblTitulo.Text = "Alta Membresia";
            // 
            // AltaMembresia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateIncio);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblMembresia);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.brnAceptar);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.cboMembresia);
            this.Name = "AltaMembresia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AltaMembresia";
            this.Load += new System.EventHandler(this.AltaMembresia_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboMembresia;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Button brnAceptar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblMembresia;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.DateTimePicker dateIncio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTitulo;
    }
}