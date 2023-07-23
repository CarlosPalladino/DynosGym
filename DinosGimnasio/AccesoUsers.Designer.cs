namespace DinosGimnasio
{
    partial class AccesoUsers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccesoUsers));
            this.picImg = new System.Windows.Forms.PictureBox();
            this.txtDocu = new System.Windows.Forms.TextBox();
            this.btnIngrsar = new System.Windows.Forms.Button();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.Nacimiento = new System.Windows.Forms.DateTimePicker();
            this.lbtittle = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picImg)).BeginInit();
            this.SuspendLayout();
            // 
            // picImg
            // 
            this.picImg.Location = new System.Drawing.Point(491, 65);
            this.picImg.Name = "picImg";
            this.picImg.Size = new System.Drawing.Size(237, 245);
            this.picImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picImg.TabIndex = 0;
            this.picImg.TabStop = false;
            this.picImg.Click += new System.EventHandler(this.picImg_Click);
            // 
            // txtDocu
            // 
            this.txtDocu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDocu.Location = new System.Drawing.Point(176, 124);
            this.txtDocu.Name = "txtDocu";
            this.txtDocu.Size = new System.Drawing.Size(178, 22);
            this.txtDocu.TabIndex = 1;
            // 
            // btnIngrsar
            // 
            this.btnIngrsar.Location = new System.Drawing.Point(315, 361);
            this.btnIngrsar.Name = "btnIngrsar";
            this.btnIngrsar.Size = new System.Drawing.Size(109, 39);
            this.btnIngrsar.TabIndex = 2;
            this.btnIngrsar.Text = "Ingresa";
            this.btnIngrsar.UseVisualStyleBackColor = true;
            this.btnIngrsar.Click += new System.EventHandler(this.btnIngrsar_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(127, 218);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(62, 16);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.Location = new System.Drawing.Point(329, 218);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(65, 16);
            this.lblApellido.TabIndex = 5;
            this.lblApellido.Text = "Apellido";
            // 
            // Nacimiento
            // 
            this.Nacimiento.Location = new System.Drawing.Point(160, 290);
            this.Nacimiento.MaxDate = new System.DateTime(2023, 12, 31, 0, 0, 0, 0);
            this.Nacimiento.MinDate = new System.DateTime(1950, 12, 31, 0, 0, 0, 0);
            this.Nacimiento.Name = "Nacimiento";
            this.Nacimiento.Size = new System.Drawing.Size(207, 20);
            this.Nacimiento.TabIndex = 7;
            this.Nacimiento.Value = new System.DateTime(2023, 7, 8, 0, 0, 0, 0);
            // 
            // lbtittle
            // 
            this.lbtittle.AutoSize = true;
            this.lbtittle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtittle.Location = new System.Drawing.Point(213, 77);
            this.lbtittle.Name = "lbtittle";
            this.lbtittle.Size = new System.Drawing.Size(85, 16);
            this.lbtittle.TabIndex = 8;
            this.lbtittle.Text = "Documento";
            this.lbtittle.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(341, 22);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(96, 16);
            this.lblTitulo.TabIndex = 9;
            this.lblTitulo.Text = "Acceso User";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // AccesoUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lbtittle);
            this.Controls.Add(this.Nacimiento);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.btnIngrsar);
            this.Controls.Add(this.txtDocu);
            this.Controls.Add(this.picImg);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AccesoUsers";
            this.Text = "AccesoUsers";
            this.Load += new System.EventHandler(this.AccesoUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picImg;
        private System.Windows.Forms.TextBox txtDocu;
        private System.Windows.Forms.Button btnIngrsar;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.DateTimePicker Nacimiento;
        private System.Windows.Forms.Label lbtittle;
        private System.Windows.Forms.Label lblTitulo;
    }
}