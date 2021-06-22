namespace Intento_proyecto_4
{
    partial class Catalogo
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
            this.boton_listo = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.precio_de_producto = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.cant_de_producto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.desc_de_producto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // boton_listo
            // 
            this.boton_listo.Location = new System.Drawing.Point(23, 215);
            this.boton_listo.Name = "boton_listo";
            this.boton_listo.Size = new System.Drawing.Size(99, 34);
            this.boton_listo.TabIndex = 0;
            this.boton_listo.Text = "Listo!";
            this.boton_listo.UseVisualStyleBackColor = true;
            this.boton_listo.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(97, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Precio del producto";
            // 
            // precio_de_producto
            // 
            this.precio_de_producto.Location = new System.Drawing.Point(96, 123);
            this.precio_de_producto.Name = "precio_de_producto";
            this.precio_de_producto.Size = new System.Drawing.Size(100, 20);
            this.precio_de_producto.TabIndex = 6;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(163, 215);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 34);
            this.button2.TabIndex = 7;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cant_de_producto
            // 
            this.cant_de_producto.Location = new System.Drawing.Point(96, 187);
            this.cant_de_producto.Name = "cant_de_producto";
            this.cant_de_producto.Size = new System.Drawing.Size(100, 20);
            this.cant_de_producto.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(90, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Cantidad en existencia";
            // 
            // desc_de_producto
            // 
            this.desc_de_producto.Location = new System.Drawing.Point(96, 64);
            this.desc_de_producto.Name = "desc_de_producto";
            this.desc_de_producto.Size = new System.Drawing.Size(100, 20);
            this.desc_de_producto.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Descripción del producto";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(12, 7);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(158, 17);
            this.checkBox1.TabIndex = 10;
            this.checkBox1.Text = "Especificar ID manualmente";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(181, 7);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 11;
            // 
            // Catalogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.ControlBox = false;
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.cant_de_producto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.precio_de_producto);
            this.Controls.Add(this.desc_de_producto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.boton_listo);
            this.MaximizeBox = false;
            this.Name = "Catalogo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Catalogo";
            this.Load += new System.EventHandler(this.Catalogo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button boton_listo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox precio_de_producto;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox cant_de_producto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox desc_de_producto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox textBox1;
    }
}