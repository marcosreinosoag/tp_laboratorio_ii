
namespace Tp3
{
    partial class MenuMusica
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuMusica));
            this.btn_salir = new System.Windows.Forms.Button();
            this.btn_usuarios = new System.Windows.Forms.Button();
            this.dtg_stockInstrumento = new System.Windows.Forms.DataGridView();
            this.btn_carrito = new System.Windows.Forms.Button();
            this.cmb_instrumentos = new System.Windows.Forms.ComboBox();
            this.btn_instrumentos = new System.Windows.Forms.Button();
            this.lbl_Usuario = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_stockInstrumento)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_salir
            // 
            this.btn_salir.Location = new System.Drawing.Point(600, 394);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(175, 43);
            this.btn_salir.TabIndex = 0;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // btn_usuarios
            // 
            this.btn_usuarios.Location = new System.Drawing.Point(30, 5);
            this.btn_usuarios.Name = "btn_usuarios";
            this.btn_usuarios.Size = new System.Drawing.Size(171, 40);
            this.btn_usuarios.TabIndex = 2;
            this.btn_usuarios.Text = "Usuarios";
            this.btn_usuarios.UseVisualStyleBackColor = true;
            this.btn_usuarios.Click += new System.EventHandler(this.btn_usuarios_Click);
            // 
            // dtg_stockInstrumento
            // 
            this.dtg_stockInstrumento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_stockInstrumento.Location = new System.Drawing.Point(30, 51);
            this.dtg_stockInstrumento.Name = "dtg_stockInstrumento";
            this.dtg_stockInstrumento.RowTemplate.Height = 25;
            this.dtg_stockInstrumento.Size = new System.Drawing.Size(630, 325);
            this.dtg_stockInstrumento.TabIndex = 3;
            this.dtg_stockInstrumento.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_stockInstrumento_CellDoubleClick);
            // 
            // btn_carrito
            // 
            this.btn_carrito.Image = ((System.Drawing.Image)(resources.GetObject("btn_carrito.Image")));
            this.btn_carrito.Location = new System.Drawing.Point(722, 12);
            this.btn_carrito.Name = "btn_carrito";
            this.btn_carrito.Size = new System.Drawing.Size(53, 41);
            this.btn_carrito.TabIndex = 4;
            this.btn_carrito.UseVisualStyleBackColor = true;
            this.btn_carrito.Click += new System.EventHandler(this.btn_carrito_Click);
            // 
            // cmb_instrumentos
            // 
            this.cmb_instrumentos.FormattingEnabled = true;
            this.cmb_instrumentos.Location = new System.Drawing.Point(586, 12);
            this.cmb_instrumentos.Name = "cmb_instrumentos";
            this.cmb_instrumentos.Size = new System.Drawing.Size(74, 23);
            this.cmb_instrumentos.TabIndex = 5;
            this.cmb_instrumentos.SelectedIndexChanged += new System.EventHandler(this.cmb_instrumentos_SelectedIndexChanged);
            // 
            // btn_instrumentos
            // 
            this.btn_instrumentos.Location = new System.Drawing.Point(397, 5);
            this.btn_instrumentos.Name = "btn_instrumentos";
            this.btn_instrumentos.Size = new System.Drawing.Size(171, 40);
            this.btn_instrumentos.TabIndex = 6;
            this.btn_instrumentos.Text = "Instrumentos";
            this.btn_instrumentos.UseVisualStyleBackColor = true;
            // 
            // lbl_Usuario
            // 
            this.lbl_Usuario.AutoSize = true;
            this.lbl_Usuario.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_Usuario.Location = new System.Drawing.Point(249, 408);
            this.lbl_Usuario.Name = "lbl_Usuario";
            this.lbl_Usuario.Size = new System.Drawing.Size(0, 15);
            this.lbl_Usuario.TabIndex = 7;
            // 
            // MenuMusica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_Usuario);
            this.Controls.Add(this.btn_instrumentos);
            this.Controls.Add(this.cmb_instrumentos);
            this.Controls.Add(this.btn_carrito);
            this.Controls.Add(this.dtg_stockInstrumento);
            this.Controls.Add(this.btn_usuarios);
            this.Controls.Add(this.btn_salir);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MenuMusica";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.MenuMusica_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_stockInstrumento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Button btn_usuarios;
        private System.Windows.Forms.DataGridView dtg_stockInstrumento;
        private System.Windows.Forms.Button btn_carrito;
        private System.Windows.Forms.ComboBox cmb_instrumentos;
        private System.Windows.Forms.Button btn_instrumentos;
        private System.Windows.Forms.Label lbl_Usuario;
    }
}