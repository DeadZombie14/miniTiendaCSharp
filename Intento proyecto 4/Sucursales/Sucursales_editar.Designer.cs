namespace Intento_proyecto_4.Sucursales
{
    partial class Sucursales_editar
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
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.telefono_nuevo = new System.Windows.Forms.TextBox();
            this.direccion_nueva = new System.Windows.Forms.TextBox();
            this.id_nueva = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.boton_cancelar = new System.Windows.Forms.Button();
            this.boton_guardar = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(52, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(191, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "Ingrese nuevos campos de la sucursal:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Telefono";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Direccion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "ID sucursal";
            // 
            // telefono_nuevo
            // 
            this.telefono_nuevo.Location = new System.Drawing.Point(136, 157);
            this.telefono_nuevo.Name = "telefono_nuevo";
            this.telefono_nuevo.Size = new System.Drawing.Size(127, 20);
            this.telefono_nuevo.TabIndex = 23;
            // 
            // direccion_nueva
            // 
            this.direccion_nueva.Location = new System.Drawing.Point(136, 122);
            this.direccion_nueva.Name = "direccion_nueva";
            this.direccion_nueva.Size = new System.Drawing.Size(127, 20);
            this.direccion_nueva.TabIndex = 22;
            // 
            // id_nueva
            // 
            this.id_nueva.Location = new System.Drawing.Point(136, 89);
            this.id_nueva.Name = "id_nueva";
            this.id_nueva.Size = new System.Drawing.Size(127, 20);
            this.id_nueva.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(7, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 32);
            this.label1.TabIndex = 19;
            this.label1.Text = "Porfavor, seleccione la ID actual de la sucursal que desea editar:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // boton_cancelar
            // 
            this.boton_cancelar.Location = new System.Drawing.Point(188, 192);
            this.boton_cancelar.Name = "boton_cancelar";
            this.boton_cancelar.Size = new System.Drawing.Size(75, 23);
            this.boton_cancelar.TabIndex = 18;
            this.boton_cancelar.Text = "Volver";
            this.boton_cancelar.UseVisualStyleBackColor = true;
            this.boton_cancelar.Click += new System.EventHandler(this.boton_cancelar_Click);
            // 
            // boton_guardar
            // 
            this.boton_guardar.Location = new System.Drawing.Point(53, 192);
            this.boton_guardar.Name = "boton_guardar";
            this.boton_guardar.Size = new System.Drawing.Size(75, 23);
            this.boton_guardar.TabIndex = 17;
            this.boton_guardar.Text = "Guardar";
            this.boton_guardar.UseVisualStyleBackColor = true;
            this.boton_guardar.Click += new System.EventHandler(this.boton_guardar_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(188, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(83, 21);
            this.comboBox1.TabIndex = 30;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Sucursales_editar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(284, 227);
            this.ControlBox = false;
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.telefono_nuevo);
            this.Controls.Add(this.direccion_nueva);
            this.Controls.Add(this.id_nueva);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.boton_cancelar);
            this.Controls.Add(this.boton_guardar);
            this.MaximizeBox = false;
            this.Name = "Sucursales_editar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar sucursal";
            this.Load += new System.EventHandler(this.Sucursales_editar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox telefono_nuevo;
        private System.Windows.Forms.TextBox direccion_nueva;
        private System.Windows.Forms.TextBox id_nueva;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button boton_cancelar;
        private System.Windows.Forms.Button boton_guardar;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}