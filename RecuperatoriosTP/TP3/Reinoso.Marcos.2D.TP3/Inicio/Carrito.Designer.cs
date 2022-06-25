
namespace Tp3
{
    partial class Carrito
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Carrito));
            this.ltbx_pedidos = new System.Windows.Forms.ListBox();
            this.btn_cerrarPedido = new System.Windows.Forms.Button();
            this.btn_borrarPedidos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ltbx_pedidos
            // 
            this.ltbx_pedidos.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ltbx_pedidos.FormattingEnabled = true;
            this.ltbx_pedidos.ItemHeight = 15;
            this.ltbx_pedidos.Location = new System.Drawing.Point(57, 48);
            this.ltbx_pedidos.Name = "ltbx_pedidos";
            this.ltbx_pedidos.Size = new System.Drawing.Size(529, 304);
            this.ltbx_pedidos.TabIndex = 0;
            // 
            // btn_cerrarPedido
            // 
            this.btn_cerrarPedido.Location = new System.Drawing.Point(489, 395);
            this.btn_cerrarPedido.Name = "btn_cerrarPedido";
            this.btn_cerrarPedido.Size = new System.Drawing.Size(174, 34);
            this.btn_cerrarPedido.TabIndex = 1;
            this.btn_cerrarPedido.Text = "Cerrar Pedido";
            this.btn_cerrarPedido.UseVisualStyleBackColor = true;
            this.btn_cerrarPedido.Click += new System.EventHandler(this.btn_cerrarPedido_Click);
            // 
            // btn_borrarPedidos
            // 
            this.btn_borrarPedidos.Location = new System.Drawing.Point(12, 395);
            this.btn_borrarPedidos.Name = "btn_borrarPedidos";
            this.btn_borrarPedidos.Size = new System.Drawing.Size(174, 34);
            this.btn_borrarPedidos.TabIndex = 2;
            this.btn_borrarPedidos.Text = "Borrar Pedidos";
            this.btn_borrarPedidos.UseVisualStyleBackColor = true;
            this.btn_borrarPedidos.Click += new System.EventHandler(this.btn_borrarPedidos_Click);
            // 
            // Carrito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(675, 450);
            this.Controls.Add(this.btn_borrarPedidos);
            this.Controls.Add(this.btn_cerrarPedido);
            this.Controls.Add(this.ltbx_pedidos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Carrito";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Carrito";
            this.Load += new System.EventHandler(this.Carrito_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox ltbx_pedidos;
        private System.Windows.Forms.Button btn_cerrarPedido;
        private System.Windows.Forms.Button btn_borrarPedidos;
    }
}