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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.brnAceptar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lblMembresia = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.dateIncio = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cboMembresia
            // 
            this.cboMembresia.FormattingEnabled = true;
            this.cboMembresia.Location = new System.Drawing.Point(264, 100);
            this.cboMembresia.Name = "cboMembresia";
            this.cboMembresia.Size = new System.Drawing.Size(183, 21);
            this.cboMembresia.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(264, 156);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(183, 20);
            this.textBox1.TabIndex = 1;
            // 
            // brnAceptar
            // 
            this.brnAceptar.Location = new System.Drawing.Point(390, 315);
            this.brnAceptar.Name = "brnAceptar";
            this.brnAceptar.Size = new System.Drawing.Size(82, 30);
            this.brnAceptar.TabIndex = 2;
            this.brnAceptar.Text = "Agregar";
            this.brnAceptar.UseVisualStyleBackColor = true;
            this.brnAceptar.Click += new System.EventHandler(this.brnAceptar_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(230, 314);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 31);
            this.button2.TabIndex = 3;
            this.button2.Text = "cancelar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // lblMembresia
            // 
            this.lblMembresia.AutoSize = true;
            this.lblMembresia.Location = new System.Drawing.Point(198, 108);
            this.lblMembresia.Name = "lblMembresia";
            this.lblMembresia.Size = new System.Drawing.Size(58, 13);
            this.lblMembresia.TabIndex = 4;
            this.lblMembresia.Text = "Membresia";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(198, 163);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(37, 13);
            this.lblPrecio.TabIndex = 5;
            this.lblPrecio.Text = "Precio";
            // 
            // dateIncio
            // 
            this.dateIncio.Location = new System.Drawing.Point(305, 226);
            this.dateIncio.Name = "dateIncio";
            this.dateIncio.Size = new System.Drawing.Size(99, 20);
            this.dateIncio.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(198, 232);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Iniciio";
            // 
            // AltaMembresia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateIncio);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblMembresia);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.brnAceptar);
            this.Controls.Add(this.textBox1);
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button brnAceptar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblMembresia;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.DateTimePicker dateIncio;
        private System.Windows.Forms.Label label1;
    }
}