
namespace Tp3
{
    partial class LoguinMusica
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoguinMusica));
            this.txb_usuario = new System.Windows.Forms.TextBox();
            this.txb_clave = new System.Windows.Forms.TextBox();
            this.btn_ingresar = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.btn_ingresoAdmin = new System.Windows.Forms.Button();
            this.btn_ingresoCliente = new System.Windows.Forms.Button();
            this.btn_registrarse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txb_usuario
            // 
            this.txb_usuario.Location = new System.Drawing.Point(127, 61);
            this.txb_usuario.Name = "txb_usuario";
            this.txb_usuario.PlaceholderText = "Ingrese Usuario";
            this.txb_usuario.Size = new System.Drawing.Size(421, 23);
            this.txb_usuario.TabIndex = 0;
            // 
            // txb_clave
            // 
            this.txb_clave.Location = new System.Drawing.Point(127, 125);
            this.txb_clave.Name = "txb_clave";
            this.txb_clave.PlaceholderText = "Ingrese Clave";
            this.txb_clave.Size = new System.Drawing.Size(421, 23);
            this.txb_clave.TabIndex = 1;
            // 
            // btn_ingresar
            // 
            this.btn_ingresar.Location = new System.Drawing.Point(473, 269);
            this.btn_ingresar.Name = "btn_ingresar";
            this.btn_ingresar.Size = new System.Drawing.Size(156, 48);
            this.btn_ingresar.TabIndex = 2;
            this.btn_ingresar.Text = "Ingresar";
            this.btn_ingresar.UseVisualStyleBackColor = true;
            this.btn_ingresar.Click += new System.EventHandler(this.btn_ingresar_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.Location = new System.Drawing.Point(30, 270);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(145, 47);
            this.btn_salir.TabIndex = 3;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // btn_ingresoAdmin
            // 
            this.btn_ingresoAdmin.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_ingresoAdmin.Location = new System.Drawing.Point(423, 209);
            this.btn_ingresoAdmin.Name = "btn_ingresoAdmin";
            this.btn_ingresoAdmin.Size = new System.Drawing.Size(174, 29);
            this.btn_ingresoAdmin.TabIndex = 5;
            this.btn_ingresoAdmin.Text = "Ingresar Como Administrador";
            this.btn_ingresoAdmin.UseVisualStyleBackColor = false;
            this.btn_ingresoAdmin.Click += new System.EventHandler(this.btn_ingresoAdmin_Click);
            // 
            // btn_ingresoCliente
            // 
            this.btn_ingresoCliente.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_ingresoCliente.Location = new System.Drawing.Point(95, 209);
            this.btn_ingresoCliente.Name = "btn_ingresoCliente";
            this.btn_ingresoCliente.Size = new System.Drawing.Size(167, 29);
            this.btn_ingresoCliente.TabIndex = 6;
            this.btn_ingresoCliente.Text = "Ingresar Como Cliente";
            this.btn_ingresoCliente.UseVisualStyleBackColor = false;
            this.btn_ingresoCliente.Click += new System.EventHandler(this.btn_ingresoCliente_Click);
            // 
            // btn_registrarse
            // 
            this.btn_registrarse.Location = new System.Drawing.Point(258, 168);
            this.btn_registrarse.Name = "btn_registrarse";
            this.btn_registrarse.Size = new System.Drawing.Size(167, 24);
            this.btn_registrarse.TabIndex = 7;
            this.btn_registrarse.Text = "Registrase";
            this.btn_registrarse.UseVisualStyleBackColor = true;
            this.btn_registrarse.Click += new System.EventHandler(this.btn_registrarse_Click);
            // 
            // LoguinMusica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(656, 343);
            this.Controls.Add(this.btn_registrarse);
            this.Controls.Add(this.btn_ingresoCliente);
            this.Controls.Add(this.btn_ingresoAdmin);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_ingresar);
            this.Controls.Add(this.txb_clave);
            this.Controls.Add(this.txb_usuario);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoguinMusica";
            this.Text = "Loguin Musica";
            this.Load += new System.EventHandler(this.LoguinMusica_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txb_usuario;
        private System.Windows.Forms.TextBox txb_clave;
        private System.Windows.Forms.Button btn_ingresar;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Button btn_ingresoAdmin;
        private System.Windows.Forms.Button btn_ingresoCliente;
        private System.Windows.Forms.Button btn_registrarse;
    }
}