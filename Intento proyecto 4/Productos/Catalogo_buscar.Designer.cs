namespace Intento_proyecto_4.Productos
{
    partial class Catalogo_buscar
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
            this.boton_cancelar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Precio_producto = new System.Windows.Forms.TextBox();
            this.desc_producto = new System.Windows.Forms.TextBox();
            this.ID_producto = new System.Windows.Forms.TextBox();
            this.boton_buscar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cant_producto = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // boton_cancelar
            // 
            this.boton_cancelar.Location = new System.Drawing.Point(69, 219);
            this.boton_cancelar.Name = "boton_cancelar";
            this.boton_cancelar.Size = new System.Drawing.Size(96, 23);
            this.boton_cancelar.TabIndex = 23;
            this.boton_cancelar.Text = "Cancelar";
            this.boton_cancelar.UseVisualStyleBackColor = true;
            this.boton_cancelar.Click += new System.EventHandler(this.boton_cancelar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Cantidad en existencia";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Precio (MX)";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "ID Producto";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Precio_producto
            // 
            this.Precio_producto.Location = new System.Drawing.Point(12, 71);
            this.Precio_producto.Name = "Precio_producto";
            this.Precio_producto.Size = new System.Drawing.Size(206, 20);
            this.Precio_producto.TabIndex = 19;
            this.Precio_producto.TextChanged += new System.EventHandler(this.Precio_producto_TextChanged);
            // 
            // desc_producto
            // 
            this.desc_producto.Location = new System.Drawing.Point(12, 110);
            this.desc_producto.Name = "desc_producto";
            this.desc_producto.Size = new System.Drawing.Size(206, 20);
            this.desc_producto.TabIndex = 18;
            this.desc_producto.TextChanged += new System.EventHandler(this.desc_producto_TextChanged);
            // 
            // ID_producto
            // 
            this.ID_producto.Location = new System.Drawing.Point(12, 32);
            this.ID_producto.Name = "ID_producto";
            this.ID_producto.Size = new System.Drawing.Size(206, 20);
            this.ID_producto.TabIndex = 17;
            this.ID_producto.TextChanged += new System.EventHandler(this.ID_producto_TextChanged);
            // 
            // boton_buscar
            // 
            this.boton_buscar.Location = new System.Drawing.Point(69, 190);
            this.boton_buscar.Name = "boton_buscar";
            this.boton_buscar.Size = new System.Drawing.Size(96, 23);
            this.boton_buscar.TabIndex = 16;
            this.boton_buscar.Text = "Buscar!";
            this.boton_buscar.UseVisualStyleBackColor = true;
            this.boton_buscar.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(80, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Descripcion";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // cant_producto
            // 
            this.cant_producto.Location = new System.Drawing.Point(12, 149);
            this.cant_producto.Name = "cant_producto";
            this.cant_producto.Size = new System.Drawing.Size(206, 20);
            this.cant_producto.TabIndex = 24;
            this.cant_producto.TextChanged += new System.EventHandler(this.cant_producto_TextChanged);
            // 
            // Catalogo_buscar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(230, 260);
            this.ControlBox = false;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cant_producto);
            this.Controls.Add(this.boton_cancelar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Precio_producto);
            this.Controls.Add(this.desc_producto);
            this.Controls.Add(this.ID_producto);
            this.Controls.Add(this.boton_buscar);
            this.MaximizeBox = false;
            this.Name = "Catalogo_buscar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar productos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button boton_cancelar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Precio_producto;
        private System.Windows.Forms.TextBox desc_producto;
        private System.Windows.Forms.TextBox ID_producto;
        private System.Windows.Forms.Button boton_buscar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox cant_producto;
    }
}