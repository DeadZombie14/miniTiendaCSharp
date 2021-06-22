namespace Intento_proyecto_4.Sucursales
{
    partial class Sucursales_buscar
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
            this.label4 = new System.Windows.Forms.Label();
            this.boton_cancelar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Direccion = new System.Windows.Forms.TextBox();
            this.Telefono = new System.Windows.Forms.TextBox();
            this.ID_sucursal = new System.Windows.Forms.TextBox();
            this.boton_buscar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(74, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 35;
            this.label4.Text = "Telefono";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // boton_cancelar
            // 
            this.boton_cancelar.Location = new System.Drawing.Point(56, 171);
            this.boton_cancelar.Name = "boton_cancelar";
            this.boton_cancelar.Size = new System.Drawing.Size(96, 23);
            this.boton_cancelar.TabIndex = 33;
            this.boton_cancelar.Text = "Cancelar";
            this.boton_cancelar.UseVisualStyleBackColor = true;
            this.boton_cancelar.Click += new System.EventHandler(this.boton_cancelar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "Direccion";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "ID sucursal";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Direccion
            // 
            this.Direccion.Location = new System.Drawing.Point(12, 67);
            this.Direccion.Name = "Direccion";
            this.Direccion.Size = new System.Drawing.Size(182, 20);
            this.Direccion.TabIndex = 29;
            // 
            // Telefono
            // 
            this.Telefono.Location = new System.Drawing.Point(12, 106);
            this.Telefono.Name = "Telefono";
            this.Telefono.Size = new System.Drawing.Size(182, 20);
            this.Telefono.TabIndex = 28;
            // 
            // ID_sucursal
            // 
            this.ID_sucursal.Location = new System.Drawing.Point(12, 28);
            this.ID_sucursal.Name = "ID_sucursal";
            this.ID_sucursal.Size = new System.Drawing.Size(182, 20);
            this.ID_sucursal.TabIndex = 27;
            // 
            // boton_buscar
            // 
            this.boton_buscar.Location = new System.Drawing.Point(56, 142);
            this.boton_buscar.Name = "boton_buscar";
            this.boton_buscar.Size = new System.Drawing.Size(96, 23);
            this.boton_buscar.TabIndex = 26;
            this.boton_buscar.Text = "Buscar!";
            this.boton_buscar.UseVisualStyleBackColor = true;
            this.boton_buscar.Click += new System.EventHandler(this.boton_buscar_Click);
            // 
            // Sucursales_buscar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(207, 205);
            this.ControlBox = false;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.boton_cancelar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Direccion);
            this.Controls.Add(this.Telefono);
            this.Controls.Add(this.ID_sucursal);
            this.Controls.Add(this.boton_buscar);
            this.MaximizeBox = false;
            this.Name = "Sucursales_buscar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar";
            this.Load += new System.EventHandler(this.Sucursales_buscar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button boton_cancelar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Direccion;
        private System.Windows.Forms.TextBox Telefono;
        private System.Windows.Forms.TextBox ID_sucursal;
        private System.Windows.Forms.Button boton_buscar;
    }
}