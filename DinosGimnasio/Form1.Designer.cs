namespace DinosGimnasio
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.PanelMenu = new System.Windows.Forms.Panel();
            this.PanelLog = new System.Windows.Forms.Panel();
            this.BtnLogin = new System.Windows.Forms.Button();
            this.PanelMenu.SuspendLayout();
            this.PanelLog.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(19, 1);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(51, 21);
            this.textBox1.TabIndex = 0;
            // 
            // PanelMenu
            // 
            this.PanelMenu.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.PanelMenu.Controls.Add(this.PanelLog);
            this.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelMenu.Location = new System.Drawing.Point(7, 7);
            this.PanelMenu.Name = "PanelMenu";
            this.PanelMenu.Size = new System.Drawing.Size(256, 511);
            this.PanelMenu.TabIndex = 1;
            // 
            // PanelLog
            // 
            this.PanelLog.BackColor = System.Drawing.Color.DarkSlateGray;
            this.PanelLog.Controls.Add(this.BtnLogin);
            this.PanelLog.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelLog.Location = new System.Drawing.Point(0, 0);
            this.PanelLog.Name = "PanelLog";
            this.PanelLog.Size = new System.Drawing.Size(256, 251);
            this.PanelLog.TabIndex = 0;
            // 
            // BtnLogin
            // 
            this.BtnLogin.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnLogin.BackColor = System.Drawing.Color.DarkSlateGray;
            this.BtnLogin.Dock = System.Windows.Forms.DockStyle.Left;
            this.BtnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLogin.Font = new System.Drawing.Font("Lucida Sans Typewriter", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLogin.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.BtnLogin.Location = new System.Drawing.Point(0, 0);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(256, 251);
            this.BtnLogin.TabIndex = 0;
            this.BtnLogin.Text = "Ingresá";
            this.BtnLogin.UseVisualStyleBackColor = false;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(895, 525);
            this.Controls.Add(this.PanelMenu);
            this.Controls.Add(this.textBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.GrayText;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(7);
            this.Text = "Form1";
            this.PanelMenu.ResumeLayout(false);
            this.PanelLog.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel PanelMenu;
        private System.Windows.Forms.Panel PanelLog;
        private System.Windows.Forms.Button BtnLogin;
    }
}

