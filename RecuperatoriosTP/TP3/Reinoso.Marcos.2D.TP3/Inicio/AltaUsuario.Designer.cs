
namespace Tp3
{
    partial class AltaUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AltaUsuario));
            this.tbx_id = new System.Windows.Forms.TextBox();
            this.tbx_clave = new System.Windows.Forms.TextBox();
            this.btn_errorCargo = new System.Windows.Forms.Button();
            this.dtm_fechaNac = new System.Windows.Forms.DateTimePicker();
            this.cmb_cargo = new System.Windows.Forms.ComboBox();
            this.tbx_nombre = new System.Windows.Forms.TextBox();
            this.tbx_apellido = new System.Windows.Forms.TextBox();
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_errorFechaNac = new System.Windows.Forms.Button();
            this.btn_errorId = new System.Windows.Forms.Button();
            this.btn_errorClave = new System.Windows.Forms.Button();
            this.btn_errorNombre = new System.Windows.Forms.Button();
            this.btn_errorApellido = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbx_id
            // 
            this.tbx_id.Location = new System.Drawing.Point(108, 25);
            this.tbx_id.MaxLength = 8;
            this.tbx_id.Name = "tbx_id";
            this.tbx_id.PlaceholderText = "Ingrese Id";
            this.tbx_id.Size = new System.Drawing.Size(426, 23);
            this.tbx_id.TabIndex = 25;
            // 
            // tbx_clave
            // 
            this.tbx_clave.Location = new System.Drawing.Point(108, 75);
            this.tbx_clave.Name = "tbx_clave";
            this.tbx_clave.PlaceholderText = "Ingrese Clave";
            this.tbx_clave.Size = new System.Drawing.Size(426, 23);
            this.tbx_clave.TabIndex = 26;
            // 
            // btn_errorCargo
            // 
            this.btn_errorCargo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_errorCargo.BackColor = System.Drawing.Color.Black;
            this.btn_errorCargo.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_errorCargo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btn_errorCargo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btn_errorCargo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_errorCargo.ForeColor = System.Drawing.Color.Black;
            this.btn_errorCargo.Image = ((System.Drawing.Image)(resources.GetObject("btn_errorCargo.Image")));
            this.btn_errorCargo.Location = new System.Drawing.Point(540, 218);
            this.btn_errorCargo.Name = "btn_errorCargo";
            this.btn_errorCargo.Size = new System.Drawing.Size(27, 33);
            this.btn_errorCargo.TabIndex = 40;
            this.btn_errorCargo.UseVisualStyleBackColor = false;
            this.btn_errorCargo.MouseHover += new System.EventHandler(this.btn_errorCargo_MouseHover);
            // 
            // dtm_fechaNac
            // 
            this.dtm_fechaNac.Location = new System.Drawing.Point(108, 276);
            this.dtm_fechaNac.Name = "dtm_fechaNac";
            this.dtm_fechaNac.Size = new System.Drawing.Size(426, 23);
            this.dtm_fechaNac.TabIndex = 28;
            // 
            // cmb_cargo
            // 
            this.cmb_cargo.FormattingEnabled = true;
            this.cmb_cargo.Location = new System.Drawing.Point(108, 224);
            this.cmb_cargo.Name = "cmb_cargo";
            this.cmb_cargo.Size = new System.Drawing.Size(426, 23);
            this.cmb_cargo.TabIndex = 29;
            // 
            // tbx_nombre
            // 
            this.tbx_nombre.Location = new System.Drawing.Point(108, 122);
            this.tbx_nombre.Name = "tbx_nombre";
            this.tbx_nombre.PlaceholderText = "Ingrese Nombre";
            this.tbx_nombre.Size = new System.Drawing.Size(426, 23);
            this.tbx_nombre.TabIndex = 27;
            // 
            // tbx_apellido
            // 
            this.tbx_apellido.Location = new System.Drawing.Point(108, 171);
            this.tbx_apellido.Name = "tbx_apellido";
            this.tbx_apellido.PlaceholderText = "Ingrese Apellido";
            this.tbx_apellido.Size = new System.Drawing.Size(426, 23);
            this.tbx_apellido.TabIndex = 31;
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.Location = new System.Drawing.Point(434, 339);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(150, 44);
            this.btn_aceptar.TabIndex = 32;
            this.btn_aceptar.Text = "Aceptar";
            this.btn_aceptar.UseVisualStyleBackColor = true;
            this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(40, 339);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(150, 44);
            this.btn_cancelar.TabIndex = 33;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_errorFechaNac
            // 
            this.btn_errorFechaNac.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_errorFechaNac.BackColor = System.Drawing.Color.Black;
            this.btn_errorFechaNac.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_errorFechaNac.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btn_errorFechaNac.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btn_errorFechaNac.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_errorFechaNac.ForeColor = System.Drawing.Color.Black;
            this.btn_errorFechaNac.Image = ((System.Drawing.Image)(resources.GetObject("btn_errorFechaNac.Image")));
            this.btn_errorFechaNac.Location = new System.Drawing.Point(541, 273);
            this.btn_errorFechaNac.Name = "btn_errorFechaNac";
            this.btn_errorFechaNac.Size = new System.Drawing.Size(26, 26);
            this.btn_errorFechaNac.TabIndex = 35;
            this.btn_errorFechaNac.UseVisualStyleBackColor = false;
            this.btn_errorFechaNac.MouseHover += new System.EventHandler(this.btn_errorFechaNac_MouseHover);
            // 
            // btn_errorId
            // 
            this.btn_errorId.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_errorId.BackColor = System.Drawing.Color.Black;
            this.btn_errorId.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_errorId.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btn_errorId.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btn_errorId.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_errorId.ForeColor = System.Drawing.Color.Black;
            this.btn_errorId.Image = ((System.Drawing.Image)(resources.GetObject("btn_errorId.Image")));
            this.btn_errorId.Location = new System.Drawing.Point(540, 19);
            this.btn_errorId.Name = "btn_errorId";
            this.btn_errorId.Size = new System.Drawing.Size(27, 33);
            this.btn_errorId.TabIndex = 36;
            this.btn_errorId.UseVisualStyleBackColor = false;
            this.btn_errorId.MouseHover += new System.EventHandler(this.btn_errorId_MouseHover);
            // 
            // btn_errorClave
            // 
            this.btn_errorClave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_errorClave.BackColor = System.Drawing.Color.Black;
            this.btn_errorClave.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_errorClave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btn_errorClave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btn_errorClave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_errorClave.ForeColor = System.Drawing.Color.Black;
            this.btn_errorClave.Image = ((System.Drawing.Image)(resources.GetObject("btn_errorClave.Image")));
            this.btn_errorClave.Location = new System.Drawing.Point(539, 69);
            this.btn_errorClave.Name = "btn_errorClave";
            this.btn_errorClave.Size = new System.Drawing.Size(27, 33);
            this.btn_errorClave.TabIndex = 37;
            this.btn_errorClave.UseVisualStyleBackColor = false;
            this.btn_errorClave.MouseHover += new System.EventHandler(this.btn_errorClave_MouseHover);
            // 
            // btn_errorNombre
            // 
            this.btn_errorNombre.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_errorNombre.BackColor = System.Drawing.Color.Black;
            this.btn_errorNombre.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_errorNombre.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btn_errorNombre.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btn_errorNombre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_errorNombre.ForeColor = System.Drawing.Color.Black;
            this.btn_errorNombre.Image = ((System.Drawing.Image)(resources.GetObject("btn_errorNombre.Image")));
            this.btn_errorNombre.Location = new System.Drawing.Point(539, 116);
            this.btn_errorNombre.Name = "btn_errorNombre";
            this.btn_errorNombre.Size = new System.Drawing.Size(27, 33);
            this.btn_errorNombre.TabIndex = 38;
            this.btn_errorNombre.UseVisualStyleBackColor = false;
            this.btn_errorNombre.MouseHover += new System.EventHandler(this.btn_errorNombre_MouseHover);
            // 
            // btn_errorApellido
            // 
            this.btn_errorApellido.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_errorApellido.BackColor = System.Drawing.Color.Black;
            this.btn_errorApellido.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_errorApellido.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btn_errorApellido.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btn_errorApellido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_errorApellido.ForeColor = System.Drawing.Color.Black;
            this.btn_errorApellido.Image = ((System.Drawing.Image)(resources.GetObject("btn_errorApellido.Image")));
            this.btn_errorApellido.Location = new System.Drawing.Point(540, 165);
            this.btn_errorApellido.Name = "btn_errorApellido";
            this.btn_errorApellido.Size = new System.Drawing.Size(27, 33);
            this.btn_errorApellido.TabIndex = 39;
            this.btn_errorApellido.UseVisualStyleBackColor = false;
            this.btn_errorApellido.MouseHover += new System.EventHandler(this.btn_errorApellido_MouseHover);
            // 
            // AltaUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(621, 400);
            this.Controls.Add(this.btn_errorCargo);
            this.Controls.Add(this.btn_errorApellido);
            this.Controls.Add(this.btn_errorNombre);
            this.Controls.Add(this.btn_errorClave);
            this.Controls.Add(this.btn_errorId);
            this.Controls.Add(this.btn_errorFechaNac);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_aceptar);
            this.Controls.Add(this.tbx_apellido);
            this.Controls.Add(this.cmb_cargo);
            this.Controls.Add(this.dtm_fechaNac);
            this.Controls.Add(this.tbx_nombre);
            this.Controls.Add(this.tbx_clave);
            this.Controls.Add(this.tbx_id);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AltaUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alta / Modificacion Usuario";
            this.Load += new System.EventHandler(this.AltaUsuario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbx_id;
        private System.Windows.Forms.TextBox tbx_clave;
        private System.Windows.Forms.Button btn_errorCargo;
        private System.Windows.Forms.DateTimePicker dtm_fechaNac;
        private System.Windows.Forms.ComboBox cmb_cargo;
        private System.Windows.Forms.TextBox tbx_nombre;
        private System.Windows.Forms.TextBox tbx_apellido;
        private System.Windows.Forms.Button btn_aceptar;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_errorFechaNac;
        private System.Windows.Forms.Button btn_errorId;
        private System.Windows.Forms.Button btn_errorClave;
        private System.Windows.Forms.Button btn_errorNombre;
        private System.Windows.Forms.Button btn_errorApellido;
    }
}