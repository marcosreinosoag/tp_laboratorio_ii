
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_registrarse = new System.Windows.Forms.Button();
            this.btn_ingresoCliente = new System.Windows.Forms.Button();
            this.btn_ingresoAdmin = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.btn_ingresar = new System.Windows.Forms.Button();
            this.txb_clave = new System.Windows.Forms.TextBox();
            this.txb_usuario = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, -64);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(687, 476);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btn_registrarse
            // 
            this.btn_registrarse.BackColor = System.Drawing.Color.Red;
            this.btn_registrarse.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_registrarse.ForeColor = System.Drawing.Color.White;
            this.btn_registrarse.Location = new System.Drawing.Point(283, 181);
            this.btn_registrarse.Name = "btn_registrarse";
            this.btn_registrarse.Size = new System.Drawing.Size(167, 24);
            this.btn_registrarse.TabIndex = 21;
            this.btn_registrarse.Text = "Registrase";
            this.btn_registrarse.UseVisualStyleBackColor = false;
            this.btn_registrarse.Click += new System.EventHandler(this.btn_registrarse_Click);
            // 
            // btn_ingresoCliente
            // 
            this.btn_ingresoCliente.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_ingresoCliente.Location = new System.Drawing.Point(120, 222);
            this.btn_ingresoCliente.Name = "btn_ingresoCliente";
            this.btn_ingresoCliente.Size = new System.Drawing.Size(167, 29);
            this.btn_ingresoCliente.TabIndex = 20;
            this.btn_ingresoCliente.Text = "Ingresar Como Cliente";
            this.btn_ingresoCliente.UseVisualStyleBackColor = false;
            this.btn_ingresoCliente.Click += new System.EventHandler(this.btn_ingresoCliente_Click);
            // 
            // btn_ingresoAdmin
            // 
            this.btn_ingresoAdmin.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_ingresoAdmin.Location = new System.Drawing.Point(448, 222);
            this.btn_ingresoAdmin.Name = "btn_ingresoAdmin";
            this.btn_ingresoAdmin.Size = new System.Drawing.Size(174, 29);
            this.btn_ingresoAdmin.TabIndex = 19;
            this.btn_ingresoAdmin.Text = "Ingresar Como Administrador";
            this.btn_ingresoAdmin.UseVisualStyleBackColor = false;
            this.btn_ingresoAdmin.Click += new System.EventHandler(this.btn_ingresoAdmin_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.Location = new System.Drawing.Point(55, 283);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(145, 47);
            this.btn_salir.TabIndex = 18;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // btn_ingresar
            // 
            this.btn_ingresar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_ingresar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_ingresar.Location = new System.Drawing.Point(498, 282);
            this.btn_ingresar.Name = "btn_ingresar";
            this.btn_ingresar.Size = new System.Drawing.Size(156, 48);
            this.btn_ingresar.TabIndex = 17;
            this.btn_ingresar.Text = "Ingresar";
            this.btn_ingresar.UseVisualStyleBackColor = false;
            this.btn_ingresar.Click += new System.EventHandler(this.btn_ingresar_Click);
            // 
            // txb_clave
            // 
            this.txb_clave.Location = new System.Drawing.Point(152, 138);
            this.txb_clave.Name = "txb_clave";
            this.txb_clave.PasswordChar = '*';
            this.txb_clave.PlaceholderText = "Ingrese Clave";
            this.txb_clave.Size = new System.Drawing.Size(421, 23);
            this.txb_clave.TabIndex = 16;
            // 
            // txb_usuario
            // 
            this.txb_usuario.Location = new System.Drawing.Point(152, 74);
            this.txb_usuario.Name = "txb_usuario";
            this.txb_usuario.PlaceholderText = "Ingrese Usuario";
            this.txb_usuario.Size = new System.Drawing.Size(421, 23);
            this.txb_usuario.TabIndex = 15;
            // 
            // LoguinMusica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(725, 407);
            this.Controls.Add(this.btn_registrarse);
            this.Controls.Add(this.btn_ingresoCliente);
            this.Controls.Add(this.btn_ingresoAdmin);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_ingresar);
            this.Controls.Add(this.txb_clave);
            this.Controls.Add(this.txb_usuario);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoguinMusica";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loguin UTN Musica";
            this.Load += new System.EventHandler(this.LoguinMusica_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_registrarse;
        private System.Windows.Forms.Button btn_ingresoCliente;
        private System.Windows.Forms.Button btn_ingresoAdmin;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Button btn_ingresar;
        private System.Windows.Forms.TextBox txb_clave;
        private System.Windows.Forms.TextBox txb_usuario;
    }
}