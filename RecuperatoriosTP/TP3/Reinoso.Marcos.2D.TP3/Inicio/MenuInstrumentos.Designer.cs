
namespace Tp3
{
    partial class MenuInstrumentos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuInstrumentos));
            this.dtg_stock = new System.Windows.Forms.DataGridView();
            this.btn_agregarInstrumento = new System.Windows.Forms.Button();
            this.btn_modificarInstrumento = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.cmb_tipoIntrumento = new System.Windows.Forms.ComboBox();
            this.btn_eliminarInstrumento = new System.Windows.Forms.Button();
            this.btn_instrumentoMasCaro = new System.Windows.Forms.Button();
            this.btn_instrumentoMasEconomico = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_stock)).BeginInit();
            this.SuspendLayout();
            // 
            // dtg_stock
            // 
            this.dtg_stock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_stock.Location = new System.Drawing.Point(358, 54);
            this.dtg_stock.Name = "dtg_stock";
            this.dtg_stock.RowTemplate.Height = 25;
            this.dtg_stock.Size = new System.Drawing.Size(491, 396);
            this.dtg_stock.TabIndex = 0;
            // 
            // btn_agregarInstrumento
            // 
            this.btn_agregarInstrumento.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_agregarInstrumento.Location = new System.Drawing.Point(32, 57);
            this.btn_agregarInstrumento.Name = "btn_agregarInstrumento";
            this.btn_agregarInstrumento.Size = new System.Drawing.Size(254, 34);
            this.btn_agregarInstrumento.TabIndex = 1;
            this.btn_agregarInstrumento.Text = "Agregar Instrumento";
            this.btn_agregarInstrumento.UseVisualStyleBackColor = true;
            this.btn_agregarInstrumento.Click += new System.EventHandler(this.btn_agregarInstrumento_Click);
            // 
            // btn_modificarInstrumento
            // 
            this.btn_modificarInstrumento.Location = new System.Drawing.Point(32, 110);
            this.btn_modificarInstrumento.Name = "btn_modificarInstrumento";
            this.btn_modificarInstrumento.Size = new System.Drawing.Size(253, 36);
            this.btn_modificarInstrumento.TabIndex = 2;
            this.btn_modificarInstrumento.Text = "Modificar Instrumento";
            this.btn_modificarInstrumento.UseVisualStyleBackColor = true;
            this.btn_modificarInstrumento.Click += new System.EventHandler(this.btn_modificarInstrumento_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.Location = new System.Drawing.Point(32, 216);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(253, 37);
            this.btn_salir.TabIndex = 3;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // cmb_tipoIntrumento
            // 
            this.cmb_tipoIntrumento.FormattingEnabled = true;
            this.cmb_tipoIntrumento.Location = new System.Drawing.Point(746, 12);
            this.cmb_tipoIntrumento.Name = "cmb_tipoIntrumento";
            this.cmb_tipoIntrumento.Size = new System.Drawing.Size(103, 23);
            this.cmb_tipoIntrumento.TabIndex = 4;
            this.cmb_tipoIntrumento.SelectedIndexChanged += new System.EventHandler(this.cmb_tipoIntrumento_SelectedIndexChanged);
            // 
            // btn_eliminarInstrumento
            // 
            this.btn_eliminarInstrumento.Location = new System.Drawing.Point(32, 164);
            this.btn_eliminarInstrumento.Name = "btn_eliminarInstrumento";
            this.btn_eliminarInstrumento.Size = new System.Drawing.Size(251, 36);
            this.btn_eliminarInstrumento.TabIndex = 5;
            this.btn_eliminarInstrumento.Text = "Eliminar Instrumento";
            this.btn_eliminarInstrumento.UseVisualStyleBackColor = true;
            this.btn_eliminarInstrumento.Click += new System.EventHandler(this.btn_eliminarInstrumento_Click);
            // 
            // btn_instrumentoMasCaro
            // 
            this.btn_instrumentoMasCaro.Location = new System.Drawing.Point(32, 353);
            this.btn_instrumentoMasCaro.Name = "btn_instrumentoMasCaro";
            this.btn_instrumentoMasCaro.Size = new System.Drawing.Size(269, 37);
            this.btn_instrumentoMasCaro.TabIndex = 6;
            this.btn_instrumentoMasCaro.Text = "Instrumento mas caro";
            this.btn_instrumentoMasCaro.UseVisualStyleBackColor = true;
            this.btn_instrumentoMasCaro.Click += new System.EventHandler(this.btn_instrumentoMasCaro_Click);
            // 
            // btn_instrumentoMasEconomico
            // 
            this.btn_instrumentoMasEconomico.Location = new System.Drawing.Point(32, 414);
            this.btn_instrumentoMasEconomico.Name = "btn_instrumentoMasEconomico";
            this.btn_instrumentoMasEconomico.Size = new System.Drawing.Size(269, 35);
            this.btn_instrumentoMasEconomico.TabIndex = 7;
            this.btn_instrumentoMasEconomico.Text = "Instrumento mas economico";
            this.btn_instrumentoMasEconomico.UseVisualStyleBackColor = true;
            this.btn_instrumentoMasEconomico.Click += new System.EventHandler(this.btn_instrumentoMasEconomico_Click);
            // 
            // MenuInstrumentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(893, 504);
            this.Controls.Add(this.btn_instrumentoMasEconomico);
            this.Controls.Add(this.btn_instrumentoMasCaro);
            this.Controls.Add(this.btn_eliminarInstrumento);
            this.Controls.Add(this.cmb_tipoIntrumento);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_modificarInstrumento);
            this.Controls.Add(this.btn_agregarInstrumento);
            this.Controls.Add(this.dtg_stock);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MenuInstrumentos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventario";
            this.Load += new System.EventHandler(this.Inventario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_stock)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtg_stock;
        private System.Windows.Forms.Button btn_agregarInstrumento;
        private System.Windows.Forms.Button btn_modificarInstrumento;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.ComboBox cmb_tipoIntrumento;
        private System.Windows.Forms.Button btn_eliminarInstrumento;
        private System.Windows.Forms.Button btn_instrumentoMasCaro;
        private System.Windows.Forms.Button btn_instrumentoMasEconomico;
    }
}