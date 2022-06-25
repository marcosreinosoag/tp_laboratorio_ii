
namespace Tp3
{
    partial class AltaInstrumento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AltaInstrumento));
            this.txb_descripcionInstrumento = new System.Windows.Forms.TextBox();
            this.cmb_tipoInstrumento = new System.Windows.Forms.ComboBox();
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.txb_numeroCantidad = new System.Windows.Forms.TextBox();
            this.txb_precio = new System.Windows.Forms.TextBox();
            this.cmb_guitarraTipoGuitarra = new System.Windows.Forms.ComboBox();
            this.cmb_guitarraTipoColor = new System.Windows.Forms.ComboBox();
            this.btn_errorDescripcion = new System.Windows.Forms.Button();
            this.btn_errorTipoDeGuitarra = new System.Windows.Forms.Button();
            this.btn_errorItemTipoColorGuitarra = new System.Windows.Forms.Button();
            this.btn_errorCantidadInstrumento = new System.Windows.Forms.Button();
            this.btn_errorPrecioInstrumento = new System.Windows.Forms.Button();
            this.btn_errorCantidadPlatillos = new System.Windows.Forms.Button();
            this.txb_cantidadMicrofonos = new System.Windows.Forms.TextBox();
            this.chbx_tieneTremolo = new System.Windows.Forms.CheckBox();
            this.chbx_esElectronica = new System.Windows.Forms.CheckBox();
            this.chbx_doblePedal = new System.Windows.Forms.CheckBox();
            this.btn_errorGuitarraCantidadMicrofonos = new System.Windows.Forms.Button();
            this.txb_bateriaCantidadPlatillos = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txb_descripcionInstrumento
            // 
            this.txb_descripcionInstrumento.Location = new System.Drawing.Point(136, 85);
            this.txb_descripcionInstrumento.Name = "txb_descripcionInstrumento";
            this.txb_descripcionInstrumento.PlaceholderText = "Ingrese Descripcion";
            this.txb_descripcionInstrumento.Size = new System.Drawing.Size(419, 23);
            this.txb_descripcionInstrumento.TabIndex = 0;
            // 
            // cmb_tipoInstrumento
            // 
            this.cmb_tipoInstrumento.FormattingEnabled = true;
            this.cmb_tipoInstrumento.Location = new System.Drawing.Point(136, 37);
            this.cmb_tipoInstrumento.Name = "cmb_tipoInstrumento";
            this.cmb_tipoInstrumento.Size = new System.Drawing.Size(419, 23);
            this.cmb_tipoInstrumento.TabIndex = 2;
            this.cmb_tipoInstrumento.SelectedIndexChanged += new System.EventHandler(this.cmb_consumicion_SelectedIndexChanged);
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.Location = new System.Drawing.Point(492, 446);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(150, 51);
            this.btn_aceptar.TabIndex = 5;
            this.btn_aceptar.Text = "Aceptar";
            this.btn_aceptar.UseVisualStyleBackColor = true;
            this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(47, 446);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(131, 51);
            this.btn_cancelar.TabIndex = 6;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // txb_numeroCantidad
            // 
            this.txb_numeroCantidad.Location = new System.Drawing.Point(136, 134);
            this.txb_numeroCantidad.Name = "txb_numeroCantidad";
            this.txb_numeroCantidad.PlaceholderText = "Ingrese Cantidad";
            this.txb_numeroCantidad.Size = new System.Drawing.Size(419, 23);
            this.txb_numeroCantidad.TabIndex = 13;
            // 
            // txb_precio
            // 
            this.txb_precio.Location = new System.Drawing.Point(136, 187);
            this.txb_precio.Name = "txb_precio";
            this.txb_precio.PlaceholderText = "Ingrese Precio";
            this.txb_precio.Size = new System.Drawing.Size(421, 23);
            this.txb_precio.TabIndex = 14;
            // 
            // cmb_guitarraTipoGuitarra
            // 
            this.cmb_guitarraTipoGuitarra.FormattingEnabled = true;
            this.cmb_guitarraTipoGuitarra.Location = new System.Drawing.Point(135, 282);
            this.cmb_guitarraTipoGuitarra.Name = "cmb_guitarraTipoGuitarra";
            this.cmb_guitarraTipoGuitarra.Size = new System.Drawing.Size(419, 23);
            this.cmb_guitarraTipoGuitarra.TabIndex = 18;
            // 
            // cmb_guitarraTipoColor
            // 
            this.cmb_guitarraTipoColor.FormattingEnabled = true;
            this.cmb_guitarraTipoColor.Location = new System.Drawing.Point(135, 325);
            this.cmb_guitarraTipoColor.Name = "cmb_guitarraTipoColor";
            this.cmb_guitarraTipoColor.Size = new System.Drawing.Size(419, 23);
            this.cmb_guitarraTipoColor.TabIndex = 19;
            // 
            // btn_errorDescripcion
            // 
            this.btn_errorDescripcion.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_errorDescripcion.BackColor = System.Drawing.Color.Black;
            this.btn_errorDescripcion.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_errorDescripcion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btn_errorDescripcion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btn_errorDescripcion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_errorDescripcion.ForeColor = System.Drawing.Color.Black;
            this.btn_errorDescripcion.Image = ((System.Drawing.Image)(resources.GetObject("btn_errorDescripcion.Image")));
            this.btn_errorDescripcion.Location = new System.Drawing.Point(563, 79);
            this.btn_errorDescripcion.Name = "btn_errorDescripcion";
            this.btn_errorDescripcion.Size = new System.Drawing.Size(27, 33);
            this.btn_errorDescripcion.TabIndex = 24;
            this.btn_errorDescripcion.UseVisualStyleBackColor = false;
            this.btn_errorDescripcion.MouseHover += new System.EventHandler(this.btn_errorDescripcion_MouseHover);
            // 
            // btn_errorTipoDeGuitarra
            // 
            this.btn_errorTipoDeGuitarra.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_errorTipoDeGuitarra.BackColor = System.Drawing.Color.Black;
            this.btn_errorTipoDeGuitarra.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_errorTipoDeGuitarra.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btn_errorTipoDeGuitarra.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btn_errorTipoDeGuitarra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_errorTipoDeGuitarra.ForeColor = System.Drawing.Color.Black;
            this.btn_errorTipoDeGuitarra.Image = ((System.Drawing.Image)(resources.GetObject("btn_errorTipoDeGuitarra.Image")));
            this.btn_errorTipoDeGuitarra.Location = new System.Drawing.Point(563, 276);
            this.btn_errorTipoDeGuitarra.Name = "btn_errorTipoDeGuitarra";
            this.btn_errorTipoDeGuitarra.Size = new System.Drawing.Size(27, 33);
            this.btn_errorTipoDeGuitarra.TabIndex = 25;
            this.btn_errorTipoDeGuitarra.UseVisualStyleBackColor = false;
            this.btn_errorTipoDeGuitarra.MouseHover += new System.EventHandler(this.btn_errorTipoDeGuitarra_MouseHover);
            // 
            // btn_errorItemTipoColorGuitarra
            // 
            this.btn_errorItemTipoColorGuitarra.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_errorItemTipoColorGuitarra.BackColor = System.Drawing.Color.Black;
            this.btn_errorItemTipoColorGuitarra.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_errorItemTipoColorGuitarra.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btn_errorItemTipoColorGuitarra.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btn_errorItemTipoColorGuitarra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_errorItemTipoColorGuitarra.ForeColor = System.Drawing.Color.Black;
            this.btn_errorItemTipoColorGuitarra.Image = ((System.Drawing.Image)(resources.GetObject("btn_errorItemTipoColorGuitarra.Image")));
            this.btn_errorItemTipoColorGuitarra.Location = new System.Drawing.Point(565, 319);
            this.btn_errorItemTipoColorGuitarra.Name = "btn_errorItemTipoColorGuitarra";
            this.btn_errorItemTipoColorGuitarra.Size = new System.Drawing.Size(27, 33);
            this.btn_errorItemTipoColorGuitarra.TabIndex = 26;
            this.btn_errorItemTipoColorGuitarra.UseVisualStyleBackColor = false;
            this.btn_errorItemTipoColorGuitarra.MouseHover += new System.EventHandler(this.btn_errorItemTipoColorGuitarra_MouseHover);
            // 
            // btn_errorCantidadInstrumento
            // 
            this.btn_errorCantidadInstrumento.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_errorCantidadInstrumento.BackColor = System.Drawing.Color.Black;
            this.btn_errorCantidadInstrumento.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_errorCantidadInstrumento.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btn_errorCantidadInstrumento.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btn_errorCantidadInstrumento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_errorCantidadInstrumento.ForeColor = System.Drawing.Color.Black;
            this.btn_errorCantidadInstrumento.Image = ((System.Drawing.Image)(resources.GetObject("btn_errorCantidadInstrumento.Image")));
            this.btn_errorCantidadInstrumento.Location = new System.Drawing.Point(563, 128);
            this.btn_errorCantidadInstrumento.Name = "btn_errorCantidadInstrumento";
            this.btn_errorCantidadInstrumento.Size = new System.Drawing.Size(27, 33);
            this.btn_errorCantidadInstrumento.TabIndex = 27;
            this.btn_errorCantidadInstrumento.UseVisualStyleBackColor = false;
            this.btn_errorCantidadInstrumento.MouseHover += new System.EventHandler(this.btn_errorCantidadInstrumento_MouseHover);
            // 
            // btn_errorPrecioInstrumento
            // 
            this.btn_errorPrecioInstrumento.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_errorPrecioInstrumento.BackColor = System.Drawing.Color.Black;
            this.btn_errorPrecioInstrumento.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_errorPrecioInstrumento.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btn_errorPrecioInstrumento.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btn_errorPrecioInstrumento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_errorPrecioInstrumento.ForeColor = System.Drawing.Color.Black;
            this.btn_errorPrecioInstrumento.Image = ((System.Drawing.Image)(resources.GetObject("btn_errorPrecioInstrumento.Image")));
            this.btn_errorPrecioInstrumento.Location = new System.Drawing.Point(565, 181);
            this.btn_errorPrecioInstrumento.Name = "btn_errorPrecioInstrumento";
            this.btn_errorPrecioInstrumento.Size = new System.Drawing.Size(27, 33);
            this.btn_errorPrecioInstrumento.TabIndex = 28;
            this.btn_errorPrecioInstrumento.UseVisualStyleBackColor = false;
            this.btn_errorPrecioInstrumento.MouseHover += new System.EventHandler(this.btn_errorPrecioInstrumento_MouseHover);
            // 
            // btn_errorCantidadPlatillos
            // 
            this.btn_errorCantidadPlatillos.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_errorCantidadPlatillos.BackColor = System.Drawing.Color.Black;
            this.btn_errorCantidadPlatillos.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_errorCantidadPlatillos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btn_errorCantidadPlatillos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btn_errorCantidadPlatillos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_errorCantidadPlatillos.ForeColor = System.Drawing.Color.Black;
            this.btn_errorCantidadPlatillos.Image = ((System.Drawing.Image)(resources.GetObject("btn_errorCantidadPlatillos.Image")));
            this.btn_errorCantidadPlatillos.Location = new System.Drawing.Point(565, 228);
            this.btn_errorCantidadPlatillos.Name = "btn_errorCantidadPlatillos";
            this.btn_errorCantidadPlatillos.Size = new System.Drawing.Size(27, 33);
            this.btn_errorCantidadPlatillos.TabIndex = 29;
            this.btn_errorCantidadPlatillos.UseVisualStyleBackColor = false;
            this.btn_errorCantidadPlatillos.MouseHover += new System.EventHandler(this.btn_errorCantidadPlatillos_MouseHover);
            // 
            // txb_cantidadMicrofonos
            // 
            this.txb_cantidadMicrofonos.Location = new System.Drawing.Point(136, 234);
            this.txb_cantidadMicrofonos.Name = "txb_cantidadMicrofonos";
            this.txb_cantidadMicrofonos.PlaceholderText = "Ingrese Cantidad de Microfonos";
            this.txb_cantidadMicrofonos.Size = new System.Drawing.Size(418, 23);
            this.txb_cantidadMicrofonos.TabIndex = 30;
            // 
            // chbx_tieneTremolo
            // 
            this.chbx_tieneTremolo.AutoSize = true;
            this.chbx_tieneTremolo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.chbx_tieneTremolo.Location = new System.Drawing.Point(294, 373);
            this.chbx_tieneTremolo.Name = "chbx_tieneTremolo";
            this.chbx_tieneTremolo.Size = new System.Drawing.Size(69, 19);
            this.chbx_tieneTremolo.TabIndex = 31;
            this.chbx_tieneTremolo.Text = "Tremolo";
            this.chbx_tieneTremolo.UseVisualStyleBackColor = true;
            this.chbx_tieneTremolo.CheckedChanged += new System.EventHandler(this.chbx_tieneTremolo_CheckedChanged);
            // 
            // chbx_esElectronica
            // 
            this.chbx_esElectronica.AutoSize = true;
            this.chbx_esElectronica.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.chbx_esElectronica.Location = new System.Drawing.Point(468, 373);
            this.chbx_esElectronica.Name = "chbx_esElectronica";
            this.chbx_esElectronica.Size = new System.Drawing.Size(98, 19);
            this.chbx_esElectronica.TabIndex = 32;
            this.chbx_esElectronica.Text = "Es Electronica";
            this.chbx_esElectronica.UseVisualStyleBackColor = true;
            this.chbx_esElectronica.CheckedChanged += new System.EventHandler(this.chbx_esElectronica_CheckedChanged);
            // 
            // chbx_doblePedal
            // 
            this.chbx_doblePedal.AutoSize = true;
            this.chbx_doblePedal.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.chbx_doblePedal.Location = new System.Drawing.Point(95, 372);
            this.chbx_doblePedal.Name = "chbx_doblePedal";
            this.chbx_doblePedal.Size = new System.Drawing.Size(89, 19);
            this.chbx_doblePedal.TabIndex = 33;
            this.chbx_doblePedal.Text = "Doble Pedal";
            this.chbx_doblePedal.UseVisualStyleBackColor = true;
            this.chbx_doblePedal.CheckedChanged += new System.EventHandler(this.chbx_doblePedal_CheckedChanged);
            // 
            // btn_errorGuitarraCantidadMicrofonos
            // 
            this.btn_errorGuitarraCantidadMicrofonos.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_errorGuitarraCantidadMicrofonos.BackColor = System.Drawing.Color.Black;
            this.btn_errorGuitarraCantidadMicrofonos.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_errorGuitarraCantidadMicrofonos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btn_errorGuitarraCantidadMicrofonos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btn_errorGuitarraCantidadMicrofonos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_errorGuitarraCantidadMicrofonos.ForeColor = System.Drawing.Color.Black;
            this.btn_errorGuitarraCantidadMicrofonos.Image = ((System.Drawing.Image)(resources.GetObject("btn_errorGuitarraCantidadMicrofonos.Image")));
            this.btn_errorGuitarraCantidadMicrofonos.Location = new System.Drawing.Point(565, 228);
            this.btn_errorGuitarraCantidadMicrofonos.Name = "btn_errorGuitarraCantidadMicrofonos";
            this.btn_errorGuitarraCantidadMicrofonos.Size = new System.Drawing.Size(27, 33);
            this.btn_errorGuitarraCantidadMicrofonos.TabIndex = 35;
            this.btn_errorGuitarraCantidadMicrofonos.UseVisualStyleBackColor = false;
            this.btn_errorGuitarraCantidadMicrofonos.MouseHover += new System.EventHandler(this.btn_guitarraErrorCantidadMicrofonos_MouseHover);
            // 
            // txb_bateriaCantidadPlatillos
            // 
            this.txb_bateriaCantidadPlatillos.Location = new System.Drawing.Point(136, 234);
            this.txb_bateriaCantidadPlatillos.Name = "txb_bateriaCantidadPlatillos";
            this.txb_bateriaCantidadPlatillos.PlaceholderText = "Ingrese cantidad de platillos";
            this.txb_bateriaCantidadPlatillos.Size = new System.Drawing.Size(419, 23);
            this.txb_bateriaCantidadPlatillos.TabIndex = 34;
            // 
            // AltaInstrumento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(670, 524);
            this.Controls.Add(this.btn_errorGuitarraCantidadMicrofonos);
            this.Controls.Add(this.txb_bateriaCantidadPlatillos);
            this.Controls.Add(this.chbx_doblePedal);
            this.Controls.Add(this.chbx_esElectronica);
            this.Controls.Add(this.chbx_tieneTremolo);
            this.Controls.Add(this.txb_cantidadMicrofonos);
            this.Controls.Add(this.btn_errorCantidadPlatillos);
            this.Controls.Add(this.btn_errorPrecioInstrumento);
            this.Controls.Add(this.btn_errorCantidadInstrumento);
            this.Controls.Add(this.btn_errorItemTipoColorGuitarra);
            this.Controls.Add(this.btn_errorTipoDeGuitarra);
            this.Controls.Add(this.btn_errorDescripcion);
            this.Controls.Add(this.cmb_guitarraTipoColor);
            this.Controls.Add(this.cmb_guitarraTipoGuitarra);
            this.Controls.Add(this.txb_precio);
            this.Controls.Add(this.txb_numeroCantidad);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_aceptar);
            this.Controls.Add(this.cmb_tipoInstrumento);
            this.Controls.Add(this.txb_descripcionInstrumento);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AltaInstrumento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alta/Modificacion Instrumento";
            this.Load += new System.EventHandler(this.AltaConsumicion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txb_descripcionInstrumento;
        private System.Windows.Forms.ComboBox cmb_tipoInstrumento;
        private System.Windows.Forms.Button btn_aceptar;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.TextBox txb_numeroCantidad;
        private System.Windows.Forms.TextBox txb_precio;
        private System.Windows.Forms.ComboBox cmb_guitarraTipoGuitarra;
        private System.Windows.Forms.ComboBox cmb_guitarraTipoColor;
        private System.Windows.Forms.Button btn_errorDescripcion;
        private System.Windows.Forms.Button btn_errorTipoDeGuitarra;
        private System.Windows.Forms.Button btn_errorItemTipoColorGuitarra;
        private System.Windows.Forms.Button btn_errorCantidadInstrumento;
        private System.Windows.Forms.Button btn_errorPrecioInstrumento;
        private System.Windows.Forms.Button btn_errorCantidadPlatillos;
        private System.Windows.Forms.TextBox txb_cantidadMicrofonos;
        private System.Windows.Forms.CheckBox chbx_tieneTremolo;
        private System.Windows.Forms.CheckBox chbx_esElectronica;
        private System.Windows.Forms.CheckBox chbx_doblePedal;
        private System.Windows.Forms.TextBox txb_bateriaCantidadPlatillos;
        private System.Windows.Forms.Button btn_errorGuitarraCantidadMicrofonos;
        private System.Windows.Forms.PictureBox picb_guitarra;
    }
}