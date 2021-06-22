namespace Intento_proyecto_4.Tienda
{
    partial class Tienda_anadir
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.boton_agregar = new System.Windows.Forms.Button();
            this.boton_cancelar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.desc_producto = new System.Windows.Forms.TextBox();
            this.precio_producto = new System.Windows.Forms.TextBox();
            this.cant_producto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cant_a_ordenar = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID producto";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(136, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // boton_agregar
            // 
            this.boton_agregar.Location = new System.Drawing.Point(30, 191);
            this.boton_agregar.Name = "boton_agregar";
            this.boton_agregar.Size = new System.Drawing.Size(121, 23);
            this.boton_agregar.TabIndex = 2;
            this.boton_agregar.Text = "Agregar producto";
            this.boton_agregar.UseVisualStyleBackColor = true;
            this.boton_agregar.Click += new System.EventHandler(this.boton_agregar_Click);
            // 
            // boton_cancelar
            // 
            this.boton_cancelar.Location = new System.Drawing.Point(182, 191);
            this.boton_cancelar.Name = "boton_cancelar";
            this.boton_cancelar.Size = new System.Drawing.Size(75, 23);
            this.boton_cancelar.TabIndex = 3;
            this.boton_cancelar.Text = "Salir";
            this.boton_cancelar.UseVisualStyleBackColor = true;
            this.boton_cancelar.Click += new System.EventHandler(this.boton_cancelar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Precio:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Descripcion:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Disponibles:";
            // 
            // desc_producto
            // 
            this.desc_producto.Location = new System.Drawing.Point(136, 45);
            this.desc_producto.Name = "desc_producto";
            this.desc_producto.ReadOnly = true;
            this.desc_producto.Size = new System.Drawing.Size(121, 20);
            this.desc_producto.TabIndex = 7;
            // 
            // precio_producto
            // 
            this.precio_producto.Location = new System.Drawing.Point(136, 80);
            this.precio_producto.Name = "precio_producto";
            this.precio_producto.ReadOnly = true;
            this.precio_producto.Size = new System.Drawing.Size(121, 20);
            this.precio_producto.TabIndex = 8;
            // 
            // cant_producto
            // 
            this.cant_producto.Location = new System.Drawing.Point(136, 116);
            this.cant_producto.Name = "cant_producto";
            this.cant_producto.ReadOnly = true;
            this.cant_producto.Size = new System.Drawing.Size(121, 20);
            this.cant_producto.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Deseo ordenar(cantidad):";
            // 
            // cant_a_ordenar
            // 
            this.cant_a_ordenar.Location = new System.Drawing.Point(163, 153);
            this.cant_a_ordenar.Name = "cant_a_ordenar";
            this.cant_a_ordenar.Size = new System.Drawing.Size(94, 20);
            this.cant_a_ordenar.TabIndex = 11;
            // 
            // Tienda_anadir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(284, 227);
            this.ControlBox = false;
            this.Controls.Add(this.cant_a_ordenar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cant_producto);
            this.Controls.Add(this.precio_producto);
            this.Controls.Add(this.desc_producto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.boton_cancelar);
            this.Controls.Add(this.boton_agregar);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Tienda_anadir";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Añadir productos";
            this.Load += new System.EventHandler(this.Tienda_anadir_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button boton_agregar;
        private System.Windows.Forms.Button boton_cancelar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox desc_producto;
        private System.Windows.Forms.TextBox precio_producto;
        private System.Windows.Forms.TextBox cant_producto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox cant_a_ordenar;
    }
}