namespace Intento_proyecto_4.Vendedores
{
    partial class Vendedores_anadir
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
            this.id_vendedor = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.direccion_vendedor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.boton_cancelar = new System.Windows.Forms.Button();
            this.apellidos_vendedor = new System.Windows.Forms.TextBox();
            this.nombres_vendedor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.boton_listo = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // id_vendedor
            // 
            this.id_vendedor.Enabled = false;
            this.id_vendedor.Location = new System.Drawing.Point(177, 10);
            this.id_vendedor.Name = "id_vendedor";
            this.id_vendedor.Size = new System.Drawing.Size(100, 20);
            this.id_vendedor.TabIndex = 21;
            this.id_vendedor.TextChanged += new System.EventHandler(this.id_manual_vendedor_TextChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(8, 10);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(158, 17);
            this.checkBox1.TabIndex = 20;
            this.checkBox1.Text = "Especificar ID manualmente";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // direccion_vendedor
            // 
            this.direccion_vendedor.Location = new System.Drawing.Point(92, 128);
            this.direccion_vendedor.Name = "direccion_vendedor";
            this.direccion_vendedor.Size = new System.Drawing.Size(100, 20);
            this.direccion_vendedor.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(86, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Direccion del vendedor";
            // 
            // boton_cancelar
            // 
            this.boton_cancelar.Location = new System.Drawing.Point(159, 218);
            this.boton_cancelar.Name = "boton_cancelar";
            this.boton_cancelar.Size = new System.Drawing.Size(99, 34);
            this.boton_cancelar.TabIndex = 17;
            this.boton_cancelar.Text = "Cancelar";
            this.boton_cancelar.UseVisualStyleBackColor = true;
            this.boton_cancelar.Click += new System.EventHandler(this.boton_cancelar_Click);
            // 
            // apellidos_vendedor
            // 
            this.apellidos_vendedor.Location = new System.Drawing.Point(159, 65);
            this.apellidos_vendedor.Name = "apellidos_vendedor";
            this.apellidos_vendedor.Size = new System.Drawing.Size(100, 20);
            this.apellidos_vendedor.TabIndex = 16;
            // 
            // nombres_vendedor
            // 
            this.nombres_vendedor.Location = new System.Drawing.Point(28, 65);
            this.nombres_vendedor.Name = "nombres_vendedor";
            this.nombres_vendedor.Size = new System.Drawing.Size(100, 20);
            this.nombres_vendedor.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(160, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Apellidos del vendedor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Nombre(s) del vendedor";
            // 
            // boton_listo
            // 
            this.boton_listo.Location = new System.Drawing.Point(19, 218);
            this.boton_listo.Name = "boton_listo";
            this.boton_listo.Size = new System.Drawing.Size(99, 34);
            this.boton_listo.TabIndex = 12;
            this.boton_listo.Text = "Listo!";
            this.boton_listo.UseVisualStyleBackColor = true;
            this.boton_listo.Click += new System.EventHandler(this.boton_listo_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(138, 172);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(13, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 26);
            this.label1.TabIndex = 23;
            this.label1.Text = "ID de la sucursal en la que labora:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Vendedores_anadir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.id_vendedor);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.direccion_vendedor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.boton_cancelar);
            this.Controls.Add(this.apellidos_vendedor);
            this.Controls.Add(this.nombres_vendedor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.boton_listo);
            this.MaximizeBox = false;
            this.Name = "Vendedores_anadir";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Añadir vendedor";
            this.Load += new System.EventHandler(this.Vendedores_anadir_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox id_vendedor;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox direccion_vendedor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button boton_cancelar;
        private System.Windows.Forms.TextBox apellidos_vendedor;
        private System.Windows.Forms.TextBox nombres_vendedor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button boton_listo;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
    }
}