namespace Intento_proyecto_4.Vendedores
{
    partial class Vendedores_menu
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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.boton_volver = new System.Windows.Forms.Button();
            this.boton_editar = new System.Windows.Forms.Button();
            this.boton_buscar = new System.Windows.Forms.Button();
            this.boton_eliminar = new System.Windows.Forms.Button();
            this.boton_actualizar = new System.Windows.Forms.Button();
            this.boton_anadir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label1.Font = new System.Drawing.Font("Salina", 20.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(413, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 32);
            this.label1.TabIndex = 40;
            this.label1.Text = "Directorio de vendedores";
            this.label1.Click += new System.EventHandler(this.label1_Click);
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
            this.dataGridView1.Location = new System.Drawing.Point(287, 46);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(547, 275);
            this.dataGridView1.TabIndex = 34;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(345, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(53, 40);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 41;
            this.pictureBox2.TabStop = false;
            // 
            // boton_volver
            // 
            this.boton_volver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.boton_volver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.boton_volver.Image = global::Intento_proyecto_4.Properties.Resources.icono_volver;
            this.boton_volver.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.boton_volver.Location = new System.Drawing.Point(7, 7);
            this.boton_volver.Name = "boton_volver";
            this.boton_volver.Size = new System.Drawing.Size(33, 36);
            this.boton_volver.TabIndex = 39;
            this.boton_volver.UseVisualStyleBackColor = false;
            this.boton_volver.Click += new System.EventHandler(this.button4_Click);
            // 
            // boton_editar
            // 
            this.boton_editar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.boton_editar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.boton_editar.Image = global::Intento_proyecto_4.Properties.Resources.icono_editar;
            this.boton_editar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.boton_editar.Location = new System.Drawing.Point(7, 271);
            this.boton_editar.Name = "boton_editar";
            this.boton_editar.Size = new System.Drawing.Size(265, 50);
            this.boton_editar.TabIndex = 38;
            this.boton_editar.Text = "Editar vendedor";
            this.boton_editar.UseVisualStyleBackColor = false;
            this.boton_editar.Click += new System.EventHandler(this.boton_editar_Click);
            // 
            // boton_buscar
            // 
            this.boton_buscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.boton_buscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.boton_buscar.Image = global::Intento_proyecto_4.Properties.Resources.icono_buscar1;
            this.boton_buscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.boton_buscar.Location = new System.Drawing.Point(7, 215);
            this.boton_buscar.Name = "boton_buscar";
            this.boton_buscar.Size = new System.Drawing.Size(265, 50);
            this.boton_buscar.TabIndex = 37;
            this.boton_buscar.Text = "Buscar vendedor...";
            this.boton_buscar.UseVisualStyleBackColor = false;
            this.boton_buscar.Click += new System.EventHandler(this.boton_buscar_Click);
            // 
            // boton_eliminar
            // 
            this.boton_eliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.boton_eliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.boton_eliminar.Image = global::Intento_proyecto_4.Properties.Resources.icono_eliminar2;
            this.boton_eliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.boton_eliminar.Location = new System.Drawing.Point(7, 158);
            this.boton_eliminar.Name = "boton_eliminar";
            this.boton_eliminar.Size = new System.Drawing.Size(265, 50);
            this.boton_eliminar.TabIndex = 36;
            this.boton_eliminar.Text = "Eliminar vendedor de la lista";
            this.boton_eliminar.UseVisualStyleBackColor = false;
            this.boton_eliminar.Click += new System.EventHandler(this.boton_eliminar_Click);
            // 
            // boton_actualizar
            // 
            this.boton_actualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.boton_actualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.boton_actualizar.Image = global::Intento_proyecto_4.Properties.Resources.icono_actualizar;
            this.boton_actualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.boton_actualizar.Location = new System.Drawing.Point(7, 102);
            this.boton_actualizar.Name = "boton_actualizar";
            this.boton_actualizar.Size = new System.Drawing.Size(265, 50);
            this.boton_actualizar.TabIndex = 35;
            this.boton_actualizar.Text = "Actualizar directorio";
            this.boton_actualizar.UseVisualStyleBackColor = false;
            this.boton_actualizar.Click += new System.EventHandler(this.boton_actualizar_Click);
            // 
            // boton_anadir
            // 
            this.boton_anadir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.boton_anadir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.boton_anadir.Image = global::Intento_proyecto_4.Properties.Resources.icono_anadir;
            this.boton_anadir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.boton_anadir.Location = new System.Drawing.Point(7, 46);
            this.boton_anadir.Name = "boton_anadir";
            this.boton_anadir.Size = new System.Drawing.Size(265, 50);
            this.boton_anadir.TabIndex = 33;
            this.boton_anadir.Text = "Añadir vendedor";
            this.boton_anadir.UseVisualStyleBackColor = false;
            this.boton_anadir.Click += new System.EventHandler(this.boton_anadir_Click);
            // 
            // Vendedores_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(840, 328);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.boton_volver);
            this.Controls.Add(this.boton_editar);
            this.Controls.Add(this.boton_buscar);
            this.Controls.Add(this.boton_eliminar);
            this.Controls.Add(this.boton_actualizar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.boton_anadir);
            this.MaximizeBox = false;
            this.Name = "Vendedores_menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vendedores_menu";
            this.Load += new System.EventHandler(this.Vendedores_menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button boton_volver;
        private System.Windows.Forms.Button boton_editar;
        private System.Windows.Forms.Button boton_buscar;
        private System.Windows.Forms.Button boton_eliminar;
        private System.Windows.Forms.Button boton_actualizar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button boton_anadir;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}