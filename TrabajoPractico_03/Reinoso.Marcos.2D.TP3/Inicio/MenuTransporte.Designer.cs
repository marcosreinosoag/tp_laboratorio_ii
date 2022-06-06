
namespace Tp3
{
    partial class MenuTransporte
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
            this.btn_salir = new System.Windows.Forms.Button();
            this.btn_enviosRealizados = new System.Windows.Forms.Button();
            this.btn_Usuario = new System.Windows.Forms.Button();
            this.dtg_enviosARealizar = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_enviosARealizar)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_salir
            // 
            this.btn_salir.Location = new System.Drawing.Point(582, 373);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(187, 54);
            this.btn_salir.TabIndex = 0;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // btn_enviosRealizados
            // 
            this.btn_enviosRealizados.Location = new System.Drawing.Point(290, 373);
            this.btn_enviosRealizados.Name = "btn_enviosRealizados";
            this.btn_enviosRealizados.Size = new System.Drawing.Size(187, 54);
            this.btn_enviosRealizados.TabIndex = 1;
            this.btn_enviosRealizados.Text = "Envios Realizados";
            this.btn_enviosRealizados.UseVisualStyleBackColor = true;
            // 
            // btn_Usuario
            // 
            this.btn_Usuario.Location = new System.Drawing.Point(22, 373);
            this.btn_Usuario.Name = "btn_Usuario";
            this.btn_Usuario.Size = new System.Drawing.Size(187, 54);
            this.btn_Usuario.TabIndex = 2;
            this.btn_Usuario.Text = "Usuarios";
            this.btn_Usuario.UseVisualStyleBackColor = true;
            // 
            // dtg_enviosARealizar
            // 
            this.dtg_enviosARealizar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_enviosARealizar.Location = new System.Drawing.Point(22, 47);
            this.dtg_enviosARealizar.Name = "dtg_enviosARealizar";
            this.dtg_enviosARealizar.RowTemplate.Height = 25;
            this.dtg_enviosARealizar.Size = new System.Drawing.Size(747, 277);
            this.dtg_enviosARealizar.TabIndex = 3;
            // 
            // MenuTransporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtg_enviosARealizar);
            this.Controls.Add(this.btn_Usuario);
            this.Controls.Add(this.btn_enviosRealizados);
            this.Controls.Add(this.btn_salir);
            this.Name = "MenuTransporte";
            this.Text = "Menu";
            ((System.ComponentModel.ISupportInitialize)(this.dtg_enviosARealizar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Button btn_enviosRealizados;
        private System.Windows.Forms.Button btn_Usuario;
        private System.Windows.Forms.DataGridView dtg_enviosARealizar;
    }
}