﻿
namespace Tp3
{
    partial class CerrarPedido
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
            this.txb_direccion = new System.Windows.Forms.TextBox();
            this.lbl_codSeg = new System.Windows.Forms.Label();
            this.lbl_fechaVto = new System.Windows.Forms.Label();
            this.txb_anio = new System.Windows.Forms.TextBox();
            this.lbl_barra = new System.Windows.Forms.Label();
            this.txb_mes = new System.Windows.Forms.TextBox();
            this.txb_codSeguridad = new System.Windows.Forms.TextBox();
            this.txb_tarjetaDeCredito = new System.Windows.Forms.TextBox();
            this.rdb_tajetaDeDebito = new System.Windows.Forms.RadioButton();
            this.rdb_tarjetaDeCredito = new System.Windows.Forms.RadioButton();
            this.rdb_efectivo = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txb_totalCarrito = new System.Windows.Forms.TextBox();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.lbl_retiro = new System.Windows.Forms.Label();
            this.txb_codPostal = new System.Windows.Forms.TextBox();
            this.txb_descripcion = new System.Windows.Forms.TextBox();
            this.chbx_retiroEnLocal = new System.Windows.Forms.CheckBox();
            this.chbx_envioDomicilio = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // txb_direccion
            // 
            this.txb_direccion.Location = new System.Drawing.Point(143, 293);
            this.txb_direccion.Name = "txb_direccion";
            this.txb_direccion.PlaceholderText = "Ingrese direccion";
            this.txb_direccion.Size = new System.Drawing.Size(480, 23);
            this.txb_direccion.TabIndex = 0;
            // 
            // lbl_codSeg
            // 
            this.lbl_codSeg.AutoSize = true;
            this.lbl_codSeg.Location = new System.Drawing.Point(395, 219);
            this.lbl_codSeg.Name = "lbl_codSeg";
            this.lbl_codSeg.Size = new System.Drawing.Size(50, 15);
            this.lbl_codSeg.TabIndex = 30;
            this.lbl_codSeg.Text = "Cod seg";
            // 
            // lbl_fechaVto
            // 
            this.lbl_fechaVto.AutoSize = true;
            this.lbl_fechaVto.Location = new System.Drawing.Point(198, 219);
            this.lbl_fechaVto.Name = "lbl_fechaVto";
            this.lbl_fechaVto.Size = new System.Drawing.Size(58, 15);
            this.lbl_fechaVto.TabIndex = 29;
            this.lbl_fechaVto.Text = "Fecha vto";
            this.lbl_fechaVto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txb_anio
            // 
            this.txb_anio.Location = new System.Drawing.Point(326, 213);
            this.txb_anio.MaxLength = 2;
            this.txb_anio.Name = "txb_anio";
            this.txb_anio.Size = new System.Drawing.Size(44, 23);
            this.txb_anio.TabIndex = 28;
            // 
            // lbl_barra
            // 
            this.lbl_barra.AutoSize = true;
            this.lbl_barra.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_barra.Location = new System.Drawing.Point(312, 213);
            this.lbl_barra.Name = "lbl_barra";
            this.lbl_barra.Size = new System.Drawing.Size(17, 23);
            this.lbl_barra.TabIndex = 27;
            this.lbl_barra.Text = "/";
            // 
            // txb_mes
            // 
            this.txb_mes.Location = new System.Drawing.Point(262, 213);
            this.txb_mes.MaxLength = 2;
            this.txb_mes.Name = "txb_mes";
            this.txb_mes.Size = new System.Drawing.Size(44, 23);
            this.txb_mes.TabIndex = 26;
            // 
            // txb_codSeguridad
            // 
            this.txb_codSeguridad.Location = new System.Drawing.Point(451, 213);
            this.txb_codSeguridad.MaxLength = 3;
            this.txb_codSeguridad.Name = "txb_codSeguridad";
            this.txb_codSeguridad.Size = new System.Drawing.Size(54, 23);
            this.txb_codSeguridad.TabIndex = 25;
            // 
            // txb_tarjetaDeCredito
            // 
            this.txb_tarjetaDeCredito.Location = new System.Drawing.Point(141, 172);
            this.txb_tarjetaDeCredito.MaxLength = 16;
            this.txb_tarjetaDeCredito.Name = "txb_tarjetaDeCredito";
            this.txb_tarjetaDeCredito.Size = new System.Drawing.Size(456, 23);
            this.txb_tarjetaDeCredito.TabIndex = 24;
            // 
            // rdb_tajetaDeDebito
            // 
            this.rdb_tajetaDeDebito.AutoSize = true;
            this.rdb_tajetaDeDebito.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rdb_tajetaDeDebito.Location = new System.Drawing.Point(498, 127);
            this.rdb_tajetaDeDebito.Name = "rdb_tajetaDeDebito";
            this.rdb_tajetaDeDebito.Size = new System.Drawing.Size(113, 19);
            this.rdb_tajetaDeDebito.TabIndex = 23;
            this.rdb_tajetaDeDebito.TabStop = true;
            this.rdb_tajetaDeDebito.Text = "Tarjeta de Debito";
            this.rdb_tajetaDeDebito.UseVisualStyleBackColor = true;
            // 
            // rdb_tarjetaDeCredito
            // 
            this.rdb_tarjetaDeCredito.AutoSize = true;
            this.rdb_tarjetaDeCredito.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rdb_tarjetaDeCredito.Location = new System.Drawing.Point(298, 127);
            this.rdb_tarjetaDeCredito.Name = "rdb_tarjetaDeCredito";
            this.rdb_tarjetaDeCredito.Size = new System.Drawing.Size(117, 19);
            this.rdb_tarjetaDeCredito.TabIndex = 22;
            this.rdb_tarjetaDeCredito.TabStop = true;
            this.rdb_tarjetaDeCredito.Text = "Tarjeta de Credito";
            this.rdb_tarjetaDeCredito.UseVisualStyleBackColor = true;
            // 
            // rdb_efectivo
            // 
            this.rdb_efectivo.AutoSize = true;
            this.rdb_efectivo.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rdb_efectivo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.rdb_efectivo.Location = new System.Drawing.Point(128, 127);
            this.rdb_efectivo.Name = "rdb_efectivo";
            this.rdb_efectivo.Size = new System.Drawing.Size(65, 19);
            this.rdb_efectivo.TabIndex = 21;
            this.rdb_efectivo.TabStop = true;
            this.rdb_efectivo.Text = "Efectivo";
            this.rdb_efectivo.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(298, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 17);
            this.label2.TabIndex = 20;
            this.label2.Text = "Ingrese medio de pago:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(335, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 25);
            this.label1.TabIndex = 19;
            this.label1.Text = "Total";
            // 
            // txb_totalCarrito
            // 
            this.txb_totalCarrito.Location = new System.Drawing.Point(141, 47);
            this.txb_totalCarrito.Name = "txb_totalCarrito";
            this.txb_totalCarrito.Size = new System.Drawing.Size(456, 23);
            this.txb_totalCarrito.TabIndex = 18;
            this.txb_totalCarrito.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(90, 396);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(166, 42);
            this.btn_cancelar.TabIndex = 17;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.Location = new System.Drawing.Point(489, 396);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(180, 42);
            this.btn_aceptar.TabIndex = 16;
            this.btn_aceptar.Text = "Aceptar";
            this.btn_aceptar.UseVisualStyleBackColor = true;
            // 
            // lbl_retiro
            // 
            this.lbl_retiro.AutoSize = true;
            this.lbl_retiro.Location = new System.Drawing.Point(143, 260);
            this.lbl_retiro.Name = "lbl_retiro";
            this.lbl_retiro.Size = new System.Drawing.Size(80, 15);
            this.lbl_retiro.TabIndex = 33;
            this.lbl_retiro.Text = "Tipo de retiro:";
            // 
            // txb_codPostal
            // 
            this.txb_codPostal.Location = new System.Drawing.Point(143, 334);
            this.txb_codPostal.Name = "txb_codPostal";
            this.txb_codPostal.PlaceholderText = "Ingrese Codigo Postal";
            this.txb_codPostal.Size = new System.Drawing.Size(124, 23);
            this.txb_codPostal.TabIndex = 34;
            // 
            // txb_descripcion
            // 
            this.txb_descripcion.Location = new System.Drawing.Point(300, 334);
            this.txb_descripcion.Name = "txb_descripcion";
            this.txb_descripcion.PlaceholderText = "Ingrese descripcion del destino";
            this.txb_descripcion.Size = new System.Drawing.Size(323, 23);
            this.txb_descripcion.TabIndex = 35;
            // 
            // chbx_retiroEnLocal
            // 
            this.chbx_retiroEnLocal.AutoSize = true;
            this.chbx_retiroEnLocal.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chbx_retiroEnLocal.Location = new System.Drawing.Point(239, 259);
            this.chbx_retiroEnLocal.Name = "chbx_retiroEnLocal";
            this.chbx_retiroEnLocal.Size = new System.Drawing.Size(104, 19);
            this.chbx_retiroEnLocal.TabIndex = 36;
            this.chbx_retiroEnLocal.Text = "Retiro en Local";
            this.chbx_retiroEnLocal.UseVisualStyleBackColor = true;
            // 
            // chbx_envioDomicilio
            // 
            this.chbx_envioDomicilio.AutoSize = true;
            this.chbx_envioDomicilio.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chbx_envioDomicilio.Location = new System.Drawing.Point(364, 260);
            this.chbx_envioDomicilio.Name = "chbx_envioDomicilio";
            this.chbx_envioDomicilio.Size = new System.Drawing.Size(118, 19);
            this.chbx_envioDomicilio.TabIndex = 37;
            this.chbx_envioDomicilio.Text = "Envio a Domicilio";
            this.chbx_envioDomicilio.UseVisualStyleBackColor = true;
            // 
            // CerrarPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(735, 450);
            this.Controls.Add(this.chbx_envioDomicilio);
            this.Controls.Add(this.chbx_retiroEnLocal);
            this.Controls.Add(this.txb_descripcion);
            this.Controls.Add(this.txb_codPostal);
            this.Controls.Add(this.lbl_retiro);
            this.Controls.Add(this.lbl_codSeg);
            this.Controls.Add(this.lbl_fechaVto);
            this.Controls.Add(this.txb_anio);
            this.Controls.Add(this.lbl_barra);
            this.Controls.Add(this.txb_mes);
            this.Controls.Add(this.txb_codSeguridad);
            this.Controls.Add(this.txb_tarjetaDeCredito);
            this.Controls.Add(this.rdb_tajetaDeDebito);
            this.Controls.Add(this.rdb_tarjetaDeCredito);
            this.Controls.Add(this.rdb_efectivo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txb_totalCarrito);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_aceptar);
            this.Controls.Add(this.txb_direccion);
            this.Name = "CerrarPedido";
            this.Text = "CerrarPedido";
            this.Load += new System.EventHandler(this.CerrarPedido_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txb_direccion;
        private System.Windows.Forms.Label lbl_codSeg;
        private System.Windows.Forms.Label lbl_fechaVto;
        private System.Windows.Forms.TextBox txb_anio;
        private System.Windows.Forms.Label lbl_barra;
        private System.Windows.Forms.TextBox txb_mes;
        private System.Windows.Forms.TextBox txb_codSeguridad;
        private System.Windows.Forms.TextBox txb_tarjetaDeCredito;
        private System.Windows.Forms.RadioButton rdb_tajetaDeDebito;
        private System.Windows.Forms.RadioButton rdb_tarjetaDeCredito;
        private System.Windows.Forms.RadioButton rdb_efectivo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txb_totalCarrito;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_aceptar;
        private System.Windows.Forms.Label lbl_retiro;
        private System.Windows.Forms.TextBox txb_codPostal;
        private System.Windows.Forms.TextBox txb_descripcion;
        private System.Windows.Forms.CheckBox chbx_retiroEnLocal;
        private System.Windows.Forms.CheckBox chbx_envioDomicilio;
    }
}