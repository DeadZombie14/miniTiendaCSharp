﻿namespace Intento_proyecto_4.Productos
{
    partial class Catalogo_eliminar
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
            this.boton_eliminar = new System.Windows.Forms.Button();
            this.boton_cancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // boton_eliminar
            // 
            this.boton_eliminar.Location = new System.Drawing.Point(12, 111);
            this.boton_eliminar.Name = "boton_eliminar";
            this.boton_eliminar.Size = new System.Drawing.Size(75, 23);
            this.boton_eliminar.TabIndex = 0;
            this.boton_eliminar.Text = "Eliminar!";
            this.boton_eliminar.UseVisualStyleBackColor = true;
            this.boton_eliminar.Click += new System.EventHandler(this.boton_eliminar_Click);
            // 
            // boton_cancelar
            // 
            this.boton_cancelar.Location = new System.Drawing.Point(147, 111);
            this.boton_cancelar.Name = "boton_cancelar";
            this.boton_cancelar.Size = new System.Drawing.Size(75, 23);
            this.boton_cancelar.TabIndex = 1;
            this.boton_cancelar.Text = "Cancelar";
            this.boton_cancelar.UseVisualStyleBackColor = true;
            this.boton_cancelar.Click += new System.EventHandler(this.boton_cancelar_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(27, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Porfavor, seleccione la ID del producto que desea eliminar:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(54, 63);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 4;
            // 
            // Catalogo_eliminar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(234, 146);
            this.ControlBox = false;
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.boton_cancelar);
            this.Controls.Add(this.boton_eliminar);
            this.MaximizeBox = false;
            this.Name = "Catalogo_eliminar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Confirmar eliminar";
            this.Load += new System.EventHandler(this.Catalogo_eliminar_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button boton_eliminar;
        private System.Windows.Forms.Button boton_cancelar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}