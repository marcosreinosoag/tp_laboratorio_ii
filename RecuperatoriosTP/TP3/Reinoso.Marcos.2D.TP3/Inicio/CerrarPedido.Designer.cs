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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CerrarPedido));
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
            this.txb_totalCompra = new System.Windows.Forms.TextBox();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.btn_errorNumeroTarjeta = new System.Windows.Forms.Button();
            this.btn_errorCodSeg = new System.Windows.Forms.Button();
            this.btn_errorFechaDeVto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_codSeg
            // 
            this.lbl_codSeg.AutoSize = true;
            this.lbl_codSeg.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_codSeg.Location = new System.Drawing.Point(352, 219);
            this.lbl_codSeg.Name = "lbl_codSeg";
            this.lbl_codSeg.Size = new System.Drawing.Size(50, 15);
            this.lbl_codSeg.TabIndex = 30;
            this.lbl_codSeg.Text = "Cod seg";
            // 
            // lbl_fechaVto
            // 
            this.lbl_fechaVto.AutoSize = true;
            this.lbl_fechaVto.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_fechaVto.Location = new System.Drawing.Point(141, 219);
            this.lbl_fechaVto.Name = "lbl_fechaVto";
            this.lbl_fechaVto.Size = new System.Drawing.Size(58, 15);
            this.lbl_fechaVto.TabIndex = 29;
            this.lbl_fechaVto.Text = "Fecha vto";
            this.lbl_fechaVto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txb_anio
            // 
            this.txb_anio.Location = new System.Drawing.Point(269, 213);
            this.txb_anio.MaxLength = 2;
            this.txb_anio.Name = "txb_anio";
            this.txb_anio.Size = new System.Drawing.Size(44, 23);
            this.txb_anio.TabIndex = 28;
            // 
            // lbl_barra
            // 
            this.lbl_barra.AutoSize = true;
            this.lbl_barra.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_barra.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_barra.Location = new System.Drawing.Point(255, 213);
            this.lbl_barra.Name = "lbl_barra";
            this.lbl_barra.Size = new System.Drawing.Size(17, 23);
            this.lbl_barra.TabIndex = 27;
            this.lbl_barra.Text = "/";
            // 
            // txb_mes
            // 
            this.txb_mes.Location = new System.Drawing.Point(205, 213);
            this.txb_mes.MaxLength = 2;
            this.txb_mes.Name = "txb_mes";
            this.txb_mes.Size = new System.Drawing.Size(44, 23);
            this.txb_mes.TabIndex = 26;
            // 
            // txb_codSeguridad
            // 
            this.txb_codSeguridad.Location = new System.Drawing.Point(408, 213);
            this.txb_codSeguridad.MaxLength = 3;
            this.txb_codSeguridad.Name = "txb_codSeguridad";
            this.txb_codSeguridad.Size = new System.Drawing.Size(54, 23);
            this.txb_codSeguridad.TabIndex = 25;
            // 
            // txb_tarjetaDeCredito
            // 
            this.txb_tarjetaDeCredito.Location = new System.Drawing.Point(84, 172);
            this.txb_tarjetaDeCredito.MaxLength = 16;
            this.txb_tarjetaDeCredito.Name = "txb_tarjetaDeCredito";
            this.txb_tarjetaDeCredito.Size = new System.Drawing.Size(456, 23);
            this.txb_tarjetaDeCredito.TabIndex = 24;
            // 
            // rdb_tajetaDeDebito
            // 
            this.rdb_tajetaDeDebito.AutoSize = true;
            this.rdb_tajetaDeDebito.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rdb_tajetaDeDebito.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rdb_tajetaDeDebito.Location = new System.Drawing.Point(441, 127);
            this.rdb_tajetaDeDebito.Name = "rdb_tajetaDeDebito";
            this.rdb_tajetaDeDebito.Size = new System.Drawing.Size(113, 19);
            this.rdb_tajetaDeDebito.TabIndex = 23;
            this.rdb_tajetaDeDebito.TabStop = true;
            this.rdb_tajetaDeDebito.Text = "Tarjeta de Debito";
            this.rdb_tajetaDeDebito.UseVisualStyleBackColor = true;
            this.rdb_tajetaDeDebito.CheckedChanged += new System.EventHandler(this.rdb_tajetaDeDebito_CheckedChanged);
            // 
            // rdb_tarjetaDeCredito
            // 
            this.rdb_tarjetaDeCredito.AutoSize = true;
            this.rdb_tarjetaDeCredito.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rdb_tarjetaDeCredito.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rdb_tarjetaDeCredito.Location = new System.Drawing.Point(241, 127);
            this.rdb_tarjetaDeCredito.Name = "rdb_tarjetaDeCredito";
            this.rdb_tarjetaDeCredito.Size = new System.Drawing.Size(117, 19);
            this.rdb_tarjetaDeCredito.TabIndex = 22;
            this.rdb_tarjetaDeCredito.TabStop = true;
            this.rdb_tarjetaDeCredito.Text = "Tarjeta de Credito";
            this.rdb_tarjetaDeCredito.UseVisualStyleBackColor = true;
            this.rdb_tarjetaDeCredito.CheckedChanged += new System.EventHandler(this.rdb_tarjetaDeCredito_CheckedChanged);
            // 
            // rdb_efectivo
            // 
            this.rdb_efectivo.AutoSize = true;
            this.rdb_efectivo.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rdb_efectivo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.rdb_efectivo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rdb_efectivo.Location = new System.Drawing.Point(71, 127);
            this.rdb_efectivo.Name = "rdb_efectivo";
            this.rdb_efectivo.Size = new System.Drawing.Size(65, 19);
            this.rdb_efectivo.TabIndex = 21;
            this.rdb_efectivo.TabStop = true;
            this.rdb_efectivo.Text = "Efectivo";
            this.rdb_efectivo.UseVisualStyleBackColor = true;
            this.rdb_efectivo.CheckedChanged += new System.EventHandler(this.rdb_efectivo_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(241, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 17);
            this.label2.TabIndex = 20;
            this.label2.Text = "Ingrese medio de pago:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(278, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 25);
            this.label1.TabIndex = 19;
            this.label1.Text = "TOTAL";
            // 
            // txb_totalCompra
            // 
            this.txb_totalCompra.Location = new System.Drawing.Point(84, 47);
            this.txb_totalCompra.Name = "txb_totalCompra";
            this.txb_totalCompra.Size = new System.Drawing.Size(456, 23);
            this.txb_totalCompra.TabIndex = 18;
            this.txb_totalCompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(33, 282);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(166, 42);
            this.btn_cancelar.TabIndex = 17;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.Location = new System.Drawing.Point(408, 282);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(180, 42);
            this.btn_aceptar.TabIndex = 16;
            this.btn_aceptar.Text = "Aceptar";
            this.btn_aceptar.UseVisualStyleBackColor = true;
            this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // btn_errorNumeroTarjeta
            // 
            this.btn_errorNumeroTarjeta.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_errorNumeroTarjeta.BackColor = System.Drawing.Color.Black;
            this.btn_errorNumeroTarjeta.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_errorNumeroTarjeta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btn_errorNumeroTarjeta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btn_errorNumeroTarjeta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_errorNumeroTarjeta.ForeColor = System.Drawing.Color.Black;
            this.btn_errorNumeroTarjeta.Image = ((System.Drawing.Image)(resources.GetObject("btn_errorNumeroTarjeta.Image")));
            this.btn_errorNumeroTarjeta.Location = new System.Drawing.Point(555, 166);
            this.btn_errorNumeroTarjeta.Name = "btn_errorNumeroTarjeta";
            this.btn_errorNumeroTarjeta.Size = new System.Drawing.Size(27, 33);
            this.btn_errorNumeroTarjeta.TabIndex = 31;
            this.btn_errorNumeroTarjeta.UseVisualStyleBackColor = false;
            this.btn_errorNumeroTarjeta.MouseHover += new System.EventHandler(this.btn_errorNumeroTarjeta_MouseHover);
            // 
            // btn_errorCodSeg
            // 
            this.btn_errorCodSeg.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_errorCodSeg.BackColor = System.Drawing.Color.Black;
            this.btn_errorCodSeg.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_errorCodSeg.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btn_errorCodSeg.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btn_errorCodSeg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_errorCodSeg.ForeColor = System.Drawing.Color.Black;
            this.btn_errorCodSeg.Image = ((System.Drawing.Image)(resources.GetObject("btn_errorCodSeg.Image")));
            this.btn_errorCodSeg.Location = new System.Drawing.Point(463, 210);
            this.btn_errorCodSeg.Name = "btn_errorCodSeg";
            this.btn_errorCodSeg.Size = new System.Drawing.Size(27, 33);
            this.btn_errorCodSeg.TabIndex = 32;
            this.btn_errorCodSeg.UseVisualStyleBackColor = false;
            this.btn_errorCodSeg.MouseHover += new System.EventHandler(this.btn_errorCodSeg_MouseHover);
            // 
            // btn_errorFechaDeVto
            // 
            this.btn_errorFechaDeVto.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_errorFechaDeVto.BackColor = System.Drawing.Color.Black;
            this.btn_errorFechaDeVto.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_errorFechaDeVto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btn_errorFechaDeVto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btn_errorFechaDeVto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_errorFechaDeVto.ForeColor = System.Drawing.Color.Black;
            this.btn_errorFechaDeVto.Image = ((System.Drawing.Image)(resources.GetObject("btn_errorFechaDeVto.Image")));
            this.btn_errorFechaDeVto.Location = new System.Drawing.Point(319, 207);
            this.btn_errorFechaDeVto.Name = "btn_errorFechaDeVto";
            this.btn_errorFechaDeVto.Size = new System.Drawing.Size(27, 33);
            this.btn_errorFechaDeVto.TabIndex = 33;
            this.btn_errorFechaDeVto.UseVisualStyleBackColor = false;
            this.btn_errorFechaDeVto.MouseHover += new System.EventHandler(this.btn_errorFechaDeVto_MouseHover);
            // 
            // CerrarPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(621, 350);
            this.Controls.Add(this.btn_errorFechaDeVto);
            this.Controls.Add(this.btn_errorCodSeg);
            this.Controls.Add(this.btn_errorNumeroTarjeta);
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
            this.Controls.Add(this.txb_totalCompra);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_aceptar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CerrarPedido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cerrar Pedido";
            this.Load += new System.EventHandler(this.CerrarPedido_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private System.Windows.Forms.TextBox txb_totalCompra;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_aceptar;
        private System.Windows.Forms.Button btn_errorNumeroTarjeta;
        private System.Windows.Forms.Button btn_errorCodSeg;
        private System.Windows.Forms.Button btn_errorFechaDeVto;
    }
}