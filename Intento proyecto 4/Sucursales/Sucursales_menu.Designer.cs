namespace Intento_proyecto_4.Sucursales
{
    partial class Sucursales_menu
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Volver = new System.Windows.Forms.Button();
            this.EditarSucursal = new System.Windows.Forms.Button();
            this.BuscarSucursal = new System.Windows.Forms.Button();
            this.EliminarSucursal = new System.Windows.Forms.Button();
            this.ActualizarTabla = new System.Windows.Forms.Button();
            this.AnadirSucursal = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label1.Font = new System.Drawing.Font("Salina", 20.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Olive;
            this.label1.Location = new System.Drawing.Point(347, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 32);
            this.label1.TabIndex = 24;
            this.label1.Text = "Directorio de sucursales";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.GridColor = System.Drawing.Color.Red;
            this.dataGridView1.Location = new System.Drawing.Point(281, 48);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(347, 274);
            this.dataGridView1.TabIndex = 18;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(281, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(53, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // Volver
            // 
            this.Volver.BackColor = System.Drawing.Color.Olive;
            this.Volver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Volver.ForeColor = System.Drawing.SystemColors.Control;
            this.Volver.Image = global::Intento_proyecto_4.Properties.Resources.icono_volver;
            this.Volver.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Volver.Location = new System.Drawing.Point(4, 6);
            this.Volver.Name = "Volver";
            this.Volver.Size = new System.Drawing.Size(33, 36);
            this.Volver.TabIndex = 23;
            this.Volver.UseVisualStyleBackColor = false;
            this.Volver.Click += new System.EventHandler(this.button4_Click);
            // 
            // EditarSucursal
            // 
            this.EditarSucursal.BackColor = System.Drawing.Color.Olive;
            this.EditarSucursal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EditarSucursal.ForeColor = System.Drawing.SystemColors.Control;
            this.EditarSucursal.Image = global::Intento_proyecto_4.Properties.Resources.icono_editar;
            this.EditarSucursal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EditarSucursal.Location = new System.Drawing.Point(4, 272);
            this.EditarSucursal.Name = "EditarSucursal";
            this.EditarSucursal.Size = new System.Drawing.Size(265, 50);
            this.EditarSucursal.TabIndex = 22;
            this.EditarSucursal.Text = "Editar sucursal";
            this.EditarSucursal.UseVisualStyleBackColor = false;
            this.EditarSucursal.Click += new System.EventHandler(this.EditarSucursal_Click);
            // 
            // BuscarSucursal
            // 
            this.BuscarSucursal.BackColor = System.Drawing.Color.Olive;
            this.BuscarSucursal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BuscarSucursal.ForeColor = System.Drawing.SystemColors.Control;
            this.BuscarSucursal.Image = global::Intento_proyecto_4.Properties.Resources.icono_buscar1;
            this.BuscarSucursal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BuscarSucursal.Location = new System.Drawing.Point(4, 216);
            this.BuscarSucursal.Name = "BuscarSucursal";
            this.BuscarSucursal.Size = new System.Drawing.Size(265, 50);
            this.BuscarSucursal.TabIndex = 21;
            this.BuscarSucursal.Text = "Buscar sucursal...";
            this.BuscarSucursal.UseVisualStyleBackColor = false;
            this.BuscarSucursal.Click += new System.EventHandler(this.BuscarSucursal_Click);
            // 
            // EliminarSucursal
            // 
            this.EliminarSucursal.BackColor = System.Drawing.Color.Olive;
            this.EliminarSucursal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EliminarSucursal.ForeColor = System.Drawing.SystemColors.Control;
            this.EliminarSucursal.Image = global::Intento_proyecto_4.Properties.Resources.icono_eliminar2;
            this.EliminarSucursal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EliminarSucursal.Location = new System.Drawing.Point(4, 160);
            this.EliminarSucursal.Name = "EliminarSucursal";
            this.EliminarSucursal.Size = new System.Drawing.Size(265, 50);
            this.EliminarSucursal.TabIndex = 20;
            this.EliminarSucursal.Text = "Eliminar sucursal";
            this.EliminarSucursal.UseVisualStyleBackColor = false;
            this.EliminarSucursal.Click += new System.EventHandler(this.EliminarSucursal_Click);
            // 
            // ActualizarTabla
            // 
            this.ActualizarTabla.BackColor = System.Drawing.Color.Olive;
            this.ActualizarTabla.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ActualizarTabla.ForeColor = System.Drawing.SystemColors.Control;
            this.ActualizarTabla.Image = global::Intento_proyecto_4.Properties.Resources.icono_actualizar;
            this.ActualizarTabla.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ActualizarTabla.Location = new System.Drawing.Point(4, 104);
            this.ActualizarTabla.Name = "ActualizarTabla";
            this.ActualizarTabla.Size = new System.Drawing.Size(265, 50);
            this.ActualizarTabla.TabIndex = 19;
            this.ActualizarTabla.Text = "Actualizar lista";
            this.ActualizarTabla.UseVisualStyleBackColor = false;
            this.ActualizarTabla.Click += new System.EventHandler(this.ActualizarTabla_Click);
            // 
            // AnadirSucursal
            // 
            this.AnadirSucursal.BackColor = System.Drawing.Color.Olive;
            this.AnadirSucursal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnadirSucursal.ForeColor = System.Drawing.SystemColors.Control;
            this.AnadirSucursal.Image = global::Intento_proyecto_4.Properties.Resources.icono_anadir;
            this.AnadirSucursal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AnadirSucursal.Location = new System.Drawing.Point(4, 48);
            this.AnadirSucursal.Name = "AnadirSucursal";
            this.AnadirSucursal.Size = new System.Drawing.Size(265, 50);
            this.AnadirSucursal.TabIndex = 17;
            this.AnadirSucursal.Text = "Añadir sucursal";
            this.AnadirSucursal.UseVisualStyleBackColor = false;
            this.AnadirSucursal.Click += new System.EventHandler(this.AnadirSucursal_Click);
            // 
            // Sucursales_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(634, 332);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Volver);
            this.Controls.Add(this.EditarSucursal);
            this.Controls.Add(this.BuscarSucursal);
            this.Controls.Add(this.EliminarSucursal);
            this.Controls.Add(this.ActualizarTabla);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.AnadirSucursal);
            this.MaximizeBox = false;
            this.Name = "Sucursales_menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menú de sucursales";
            this.Load += new System.EventHandler(this.Sucursales_menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Volver;
        private System.Windows.Forms.Button EditarSucursal;
        private System.Windows.Forms.Button BuscarSucursal;
        private System.Windows.Forms.Button EliminarSucursal;
        private System.Windows.Forms.Button ActualizarTabla;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button AnadirSucursal;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}