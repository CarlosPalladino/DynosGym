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
            this.picImg = new System.Windows.Forms.PictureBox();
            this.txtDocu = new System.Windows.Forms.TextBox();
            this.btnIngrsar = new System.Windows.Forms.Button();
            this.lblNombre = new System.Windows.Forms.Label();
            this.LblApellido = new System.Windows.Forms.Label();
            this.Lbl = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lbtittle = new System.Windows.Forms.Label();
            this.lblTipoMembresia = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picImg)).BeginInit();
            this.SuspendLayout();
            // 
            // picImg
            // 
            this.picImg.Location = new System.Drawing.Point(496, 65);
            this.picImg.Name = "picImg";
            this.picImg.Size = new System.Drawing.Size(237, 245);
            this.picImg.TabIndex = 0;
            this.picImg.TabStop = false;
            // 
            // txtDocu
            // 
            this.txtDocu.Location = new System.Drawing.Point(140, 102);
            this.txtDocu.Name = "txtDocu";
            this.txtDocu.Size = new System.Drawing.Size(178, 20);
            this.txtDocu.TabIndex = 1;
            // 
            // btnIngrsar
            // 
            this.btnIngrsar.Location = new System.Drawing.Point(319, 359);
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
            this.lblNombre.Location = new System.Drawing.Point(155, 179);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(35, 13);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "label1";
            this.lblNombre.Visible = false;
            this.lblNombre.VisibleChanged += new System.EventHandler(this.dateTimePicker1_VisibleChanged);
            // 
            // LblApellido
            // 
            this.LblApellido.AutoSize = true;
            this.LblApellido.Location = new System.Drawing.Point(155, 226);
            this.LblApellido.Name = "LblApellido";
            this.LblApellido.Size = new System.Drawing.Size(35, 13);
            this.LblApellido.TabIndex = 4;
            this.LblApellido.Text = "label2";
            this.LblApellido.Visible = false;
            this.LblApellido.VisibleChanged += new System.EventHandler(this.dateTimePicker1_VisibleChanged);
            // 
            // Lbl
            // 
            this.Lbl.AutoSize = true;
            this.Lbl.Location = new System.Drawing.Point(272, 179);
            this.Lbl.Name = "Lbl";
            this.Lbl.Size = new System.Drawing.Size(35, 13);
            this.Lbl.TabIndex = 5;
            this.Lbl.Text = "label3";
            this.Lbl.Visible = false;
            this.Lbl.VisibleChanged += new System.EventHandler(this.dateTimePicker1_VisibleChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(140, 290);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(207, 20);
            this.dateTimePicker1.TabIndex = 7;
            this.dateTimePicker1.Value = new System.DateTime(2023, 6, 25, 20, 47, 54, 0);
            this.dateTimePicker1.VisibleChanged += new System.EventHandler(this.dateTimePicker1_VisibleChanged);
            // 
            // lbtittle
            // 
            this.lbtittle.AutoSize = true;
            this.lbtittle.Location = new System.Drawing.Point(200, 65);
            this.lbtittle.Name = "lbtittle";
            this.lbtittle.Size = new System.Drawing.Size(62, 13);
            this.lbtittle.TabIndex = 8;
            this.lbtittle.Text = "Documento";
            this.lbtittle.Visible = false;
            this.lbtittle.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblTipoMembresia
            // 
            this.lblTipoMembresia.AutoSize = true;
            this.lblTipoMembresia.Location = new System.Drawing.Point(272, 226);
            this.lblTipoMembresia.Name = "lblTipoMembresia";
            this.lblTipoMembresia.Size = new System.Drawing.Size(35, 13);
            this.lblTipoMembresia.TabIndex = 6;
            this.lblTipoMembresia.Text = "label4";
            this.lblTipoMembresia.Visible = false;
            this.lblTipoMembresia.VisibleChanged += new System.EventHandler(this.dateTimePicker1_VisibleChanged);
            // 
            // AccesoUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbtittle);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lblTipoMembresia);
            this.Controls.Add(this.Lbl);
            this.Controls.Add(this.LblApellido);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.btnIngrsar);
            this.Controls.Add(this.txtDocu);
            this.Controls.Add(this.picImg);
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
        private System.Windows.Forms.Label LblApellido;
        private System.Windows.Forms.Label Lbl;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lbtittle;
        private System.Windows.Forms.Label lblTipoMembresia;
    }
}