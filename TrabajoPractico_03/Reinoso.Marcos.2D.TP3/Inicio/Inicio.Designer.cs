
namespace Tp3
{
    partial class Inicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            this.btn_musica = new System.Windows.Forms.Button();
            this.btn_transporte = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_musica
            // 
            this.btn_musica.Location = new System.Drawing.Point(295, 213);
            this.btn_musica.Name = "btn_musica";
            this.btn_musica.Size = new System.Drawing.Size(194, 48);
            this.btn_musica.TabIndex = 0;
            this.btn_musica.Text = "UTN Musica";
            this.btn_musica.UseVisualStyleBackColor = true;
            this.btn_musica.Click += new System.EventHandler(this.btn_musica_Click);
            // 
            // btn_transporte
            // 
            this.btn_transporte.Location = new System.Drawing.Point(295, 83);
            this.btn_transporte.Name = "btn_transporte";
            this.btn_transporte.Size = new System.Drawing.Size(194, 49);
            this.btn_transporte.TabIndex = 1;
            this.btn_transporte.Text = "Transporte";
            this.btn_transporte.UseVisualStyleBackColor = true;
            this.btn_transporte.Click += new System.EventHandler(this.btn_transporte_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.Location = new System.Drawing.Point(257, 365);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(269, 46);
            this.btn_salir.TabIndex = 2;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_transporte);
            this.Controls.Add(this.btn_musica);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Inicio";
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.Inicio_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_musica;
        private System.Windows.Forms.Button btn_transporte;
        private System.Windows.Forms.Button btn_salir;
    }
}