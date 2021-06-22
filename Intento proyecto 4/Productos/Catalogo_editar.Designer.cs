namespace Intento_proyecto_4.Productos
{
    partial class Catalogo_editar
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
            this.boton_cancelar = new System.Windows.Forms.Button();
            this.boton_guardar = new System.Windows.Forms.Button();
            this.id_nueva = new System.Windows.Forms.TextBox();
            this.precio_nuevo = new System.Windows.Forms.TextBox();
            this.desc_nueva = new System.Windows.Forms.TextBox();
            this.cant_nueva = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(2, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 32);
            this.label1.TabIndex = 6;
            this.label1.Text = "Porfavor, seleccione la ID actual del producto que desea editar:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // boton_cancelar
            // 
            this.boton_cancelar.Location = new System.Drawing.Point(170, 227);
            this.boton_cancelar.Name = "boton_cancelar";
            this.boton_cancelar.Size = new System.Drawing.Size(75, 23);
            this.boton_cancelar.TabIndex = 5;
            this.boton_cancelar.Text = "Volver";
            this.boton_cancelar.UseVisualStyleBackColor = true;
            this.boton_cancelar.Click += new System.EventHandler(this.boton_cancelar_Click);
            // 
            // boton_guardar
            // 
            this.boton_guardar.Location = new System.Drawing.Point(35, 227);
            this.boton_guardar.Name = "boton_guardar";
            this.boton_guardar.Size = new System.Drawing.Size(75, 23);
            this.boton_guardar.TabIndex = 4;
            this.boton_guardar.Text = "Guardar";
            this.boton_guardar.UseVisualStyleBackColor = true;
            this.boton_guardar.Click += new System.EventHandler(this.boton_eliminar_Click);
            // 
            // id_nueva
            // 
            this.id_nueva.Location = new System.Drawing.Point(131, 87);
            this.id_nueva.Name = "id_nueva";
            this.id_nueva.Size = new System.Drawing.Size(127, 20);
            this.id_nueva.TabIndex = 8;
            this.id_nueva.TextChanged += new System.EventHandler(this.id_nueva_TextChanged);
            // 
            // precio_nuevo
            // 
            this.precio_nuevo.Location = new System.Drawing.Point(131, 120);
            this.precio_nuevo.Name = "precio_nuevo";
            this.precio_nuevo.Size = new System.Drawing.Size(127, 20);
            this.precio_nuevo.TabIndex = 9;
            this.precio_nuevo.TextChanged += new System.EventHandler(this.precio_nuevo_TextChanged);
            // 
            // desc_nueva
            // 
            this.desc_nueva.Location = new System.Drawing.Point(131, 155);
            this.desc_nueva.Name = "desc_nueva";
            this.desc_nueva.Size = new System.Drawing.Size(127, 20);
            this.desc_nueva.TabIndex = 10;
            this.desc_nueva.TextChanged += new System.EventHandler(this.desc_nueva_TextChanged);
            // 
            // cant_nueva
            // 
            this.cant_nueva.Location = new System.Drawing.Point(131, 192);
            this.cant_nueva.Name = "cant_nueva";
            this.cant_nueva.Size = new System.Drawing.Size(127, 20);
            this.cant_nueva.TabIndex = 11;
            this.cant_nueva.TextChanged += new System.EventHandler(this.cant_nueva_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "ID producto";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Precio";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Descripción";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Cantidad en almacén";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(47, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(185, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Ingrese nuevos campos del producto:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(189, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(83, 21);
            this.comboBox1.TabIndex = 17;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Catalogo_editar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.ControlBox = false;
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cant_nueva);
            this.Controls.Add(this.desc_nueva);
            this.Controls.Add(this.precio_nuevo);
            this.Controls.Add(this.id_nueva);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.boton_cancelar);
            this.Controls.Add(this.boton_guardar);
            this.MaximizeBox = false;
            this.Name = "Catalogo_editar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar producto";
            this.Load += new System.EventHandler(this.Catalogo_editar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button boton_cancelar;
        private System.Windows.Forms.Button boton_guardar;
        private System.Windows.Forms.TextBox id_nueva;
        private System.Windows.Forms.TextBox precio_nuevo;
        private System.Windows.Forms.TextBox desc_nueva;
        private System.Windows.Forms.TextBox cant_nueva;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}