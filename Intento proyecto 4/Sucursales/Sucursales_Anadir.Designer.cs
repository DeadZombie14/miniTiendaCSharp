namespace Intento_proyecto_4.Sucursales
{
    partial class Sucursales_anadir
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
            this.telefono = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.direccion = new System.Windows.Forms.TextBox();
            this.id_sucursal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.boton_listo = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // telefono
            // 
            this.telefono.Location = new System.Drawing.Point(99, 163);
            this.telefono.Name = "telefono";
            this.telefono.Size = new System.Drawing.Size(100, 20);
            this.telefono.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(93, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Telefono de la sucursal";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(163, 214);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 34);
            this.button2.TabIndex = 15;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // direccion
            // 
            this.direccion.Location = new System.Drawing.Point(99, 99);
            this.direccion.Name = "direccion";
            this.direccion.Size = new System.Drawing.Size(100, 20);
            this.direccion.TabIndex = 14;
            // 
            // id_sucursal
            // 
            this.id_sucursal.Enabled = false;
            this.id_sucursal.Location = new System.Drawing.Point(172, 22);
            this.id_sucursal.Name = "id_sucursal";
            this.id_sucursal.Size = new System.Drawing.Size(100, 20);
            this.id_sucursal.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(90, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Direccion de la sucursal";
            // 
            // boton_listo
            // 
            this.boton_listo.Location = new System.Drawing.Point(23, 214);
            this.boton_listo.Name = "boton_listo";
            this.boton_listo.Size = new System.Drawing.Size(99, 34);
            this.boton_listo.TabIndex = 10;
            this.boton_listo.Text = "Listo!";
            this.boton_listo.UseVisualStyleBackColor = true;
            this.boton_listo.Click += new System.EventHandler(this.boton_listo_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(8, 22);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(158, 17);
            this.checkBox1.TabIndex = 18;
            this.checkBox1.Text = "Especificar ID manualmente";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Sucursales_anadir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.telefono);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.direccion);
            this.Controls.Add(this.id_sucursal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.boton_listo);
            this.Name = "Sucursales_anadir";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Añadir sucursal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox telefono;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox direccion;
        private System.Windows.Forms.TextBox id_sucursal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button boton_listo;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}