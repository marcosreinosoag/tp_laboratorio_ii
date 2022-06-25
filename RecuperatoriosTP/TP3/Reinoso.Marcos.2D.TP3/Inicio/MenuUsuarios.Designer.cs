
namespace Tp3
{
    partial class MenuUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuUsuarios));
            this.btn_agregar = new System.Windows.Forms.Button();
            this.btn_modificar = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.dtg_usuarios = new System.Windows.Forms.DataGridView();
            this.btn_usuarioConMenorEdad = new System.Windows.Forms.Button();
            this.btn_usuarioConMayorEdad = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_usuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_agregar
            // 
            this.btn_agregar.Location = new System.Drawing.Point(31, 386);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(166, 40);
            this.btn_agregar.TabIndex = 0;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // btn_modificar
            // 
            this.btn_modificar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_modificar.Location = new System.Drawing.Point(277, 387);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(182, 39);
            this.btn_modificar.TabIndex = 1;
            this.btn_modificar.Text = "Modificar";
            this.btn_modificar.UseVisualStyleBackColor = true;
            this.btn_modificar.Click += new System.EventHandler(this.btn_modificar_Click);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Location = new System.Drawing.Point(536, 386);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(174, 39);
            this.btn_eliminar.TabIndex = 2;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // dtg_usuarios
            // 
            this.dtg_usuarios.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dtg_usuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_usuarios.Location = new System.Drawing.Point(31, 47);
            this.dtg_usuarios.Name = "dtg_usuarios";
            this.dtg_usuarios.RowTemplate.Height = 25;
            this.dtg_usuarios.Size = new System.Drawing.Size(679, 317);
            this.dtg_usuarios.TabIndex = 3;
            // 
            // btn_usuarioConMenorEdad
            // 
            this.btn_usuarioConMenorEdad.Location = new System.Drawing.Point(520, 12);
            this.btn_usuarioConMenorEdad.Name = "btn_usuarioConMenorEdad";
            this.btn_usuarioConMenorEdad.Size = new System.Drawing.Size(190, 28);
            this.btn_usuarioConMenorEdad.TabIndex = 4;
            this.btn_usuarioConMenorEdad.Text = "Usuario Con Menor Edad";
            this.btn_usuarioConMenorEdad.UseVisualStyleBackColor = true;
            this.btn_usuarioConMenorEdad.Click += new System.EventHandler(this.btn_usuarioConMenorEdad_Click);
            // 
            // btn_usuarioConMayorEdad
            // 
            this.btn_usuarioConMayorEdad.Location = new System.Drawing.Point(31, 12);
            this.btn_usuarioConMayorEdad.Name = "btn_usuarioConMayorEdad";
            this.btn_usuarioConMayorEdad.Size = new System.Drawing.Size(190, 28);
            this.btn_usuarioConMayorEdad.TabIndex = 5;
            this.btn_usuarioConMayorEdad.Text = "Usuario Con Mayor Edad";
            this.btn_usuarioConMayorEdad.UseVisualStyleBackColor = true;
            this.btn_usuarioConMayorEdad.Click += new System.EventHandler(this.btn_usuarioConMayorEdad_Click);
            // 
            // MenuUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_usuarioConMayorEdad);
            this.Controls.Add(this.btn_usuarioConMenorEdad);
            this.Controls.Add(this.dtg_usuarios);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.btn_modificar);
            this.Controls.Add(this.btn_agregar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MenuUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuarios";
            this.Load += new System.EventHandler(this.Usuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_usuarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.Button btn_modificar;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.DataGridView dtg_usuarios;
        private System.Windows.Forms.Button btn_usuarioConMenorEdad;
        private System.Windows.Forms.Button btn_usuarioConMayorEdad;
    }
}