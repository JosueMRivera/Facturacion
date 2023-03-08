
namespace Vista
{
    partial class ProductosForm
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.Codigotxt = new System.Windows.Forms.TextBox();
            this.Descripciontxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Existenciatxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Preciotxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ImagenPB = new System.Windows.Forms.PictureBox();
            this.Adjuntarimagenbt = new System.Windows.Forms.Button();
            this.Cancelarbt = new System.Windows.Forms.Button();
            this.Eliminarbt = new System.Windows.Forms.Button();
            this.guardarbt = new System.Windows.Forms.Button();
            this.Modificarbt = new System.Windows.Forms.Button();
            this.Nuevobt = new System.Windows.Forms.Button();
            this.ProductosDGV = new System.Windows.Forms.DataGridView();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.EstaActivocheckBox = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ImagenPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductosDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo:";
            // 
            // Codigotxt
            // 
            this.Codigotxt.Enabled = false;
            this.Codigotxt.Location = new System.Drawing.Point(116, 17);
            this.Codigotxt.Name = "Codigotxt";
            this.Codigotxt.Size = new System.Drawing.Size(204, 22);
            this.Codigotxt.TabIndex = 1;
            // 
            // Descripciontxt
            // 
            this.Descripciontxt.Enabled = false;
            this.Descripciontxt.Location = new System.Drawing.Point(116, 51);
            this.Descripciontxt.Name = "Descripciontxt";
            this.Descripciontxt.Size = new System.Drawing.Size(204, 22);
            this.Descripciontxt.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Descripcion:";
            // 
            // Existenciatxt
            // 
            this.Existenciatxt.Enabled = false;
            this.Existenciatxt.Location = new System.Drawing.Point(116, 89);
            this.Existenciatxt.Name = "Existenciatxt";
            this.Existenciatxt.Size = new System.Drawing.Size(204, 22);
            this.Existenciatxt.TabIndex = 5;
            this.Existenciatxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Existenciatxt_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Existencia:";
            // 
            // Preciotxt
            // 
            this.Preciotxt.Enabled = false;
            this.Preciotxt.Location = new System.Drawing.Point(116, 127);
            this.Preciotxt.Name = "Preciotxt";
            this.Preciotxt.Size = new System.Drawing.Size(204, 22);
            this.Preciotxt.TabIndex = 7;
            this.Preciotxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Preciotxt_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Precio:";
            // 
            // ImagenPB
            // 
            this.ImagenPB.BackColor = System.Drawing.Color.White;
            this.ImagenPB.Location = new System.Drawing.Point(355, 17);
            this.ImagenPB.Name = "ImagenPB";
            this.ImagenPB.Size = new System.Drawing.Size(147, 129);
            this.ImagenPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImagenPB.TabIndex = 8;
            this.ImagenPB.TabStop = false;
            // 
            // Adjuntarimagenbt
            // 
            this.Adjuntarimagenbt.Enabled = false;
            this.Adjuntarimagenbt.FlatAppearance.BorderSize = 0;
            this.Adjuntarimagenbt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Adjuntarimagenbt.Image = global::Vista.Properties.Resources.buscar_imagen;
            this.Adjuntarimagenbt.Location = new System.Drawing.Point(508, 114);
            this.Adjuntarimagenbt.Name = "Adjuntarimagenbt";
            this.Adjuntarimagenbt.Size = new System.Drawing.Size(37, 32);
            this.Adjuntarimagenbt.TabIndex = 14;
            this.Adjuntarimagenbt.UseVisualStyleBackColor = true;
            this.Adjuntarimagenbt.Click += new System.EventHandler(this.Adjuntarimagenbt_Click);
            // 
            // Cancelarbt
            // 
            this.Cancelarbt.BackColor = System.Drawing.Color.White;
            this.Cancelarbt.Enabled = false;
            this.Cancelarbt.Location = new System.Drawing.Point(465, 206);
            this.Cancelarbt.Name = "Cancelarbt";
            this.Cancelarbt.Size = new System.Drawing.Size(80, 30);
            this.Cancelarbt.TabIndex = 23;
            this.Cancelarbt.Text = "Cancelar";
            this.Cancelarbt.UseVisualStyleBackColor = false;
            this.Cancelarbt.Click += new System.EventHandler(this.Cancelarbt_Click);
            // 
            // Eliminarbt
            // 
            this.Eliminarbt.BackColor = System.Drawing.Color.White;
            this.Eliminarbt.Location = new System.Drawing.Point(379, 206);
            this.Eliminarbt.Name = "Eliminarbt";
            this.Eliminarbt.Size = new System.Drawing.Size(80, 30);
            this.Eliminarbt.TabIndex = 22;
            this.Eliminarbt.Text = "Eliminar";
            this.Eliminarbt.UseVisualStyleBackColor = false;
            this.Eliminarbt.Click += new System.EventHandler(this.Eliminarbt_Click);
            // 
            // guardarbt
            // 
            this.guardarbt.BackColor = System.Drawing.Color.White;
            this.guardarbt.Enabled = false;
            this.guardarbt.Location = new System.Drawing.Point(293, 206);
            this.guardarbt.Name = "guardarbt";
            this.guardarbt.Size = new System.Drawing.Size(80, 30);
            this.guardarbt.TabIndex = 21;
            this.guardarbt.Text = "Guardar";
            this.guardarbt.UseVisualStyleBackColor = false;
            this.guardarbt.Click += new System.EventHandler(this.guardarbt_Click);
            // 
            // Modificarbt
            // 
            this.Modificarbt.BackColor = System.Drawing.Color.White;
            this.Modificarbt.Location = new System.Drawing.Point(207, 206);
            this.Modificarbt.Name = "Modificarbt";
            this.Modificarbt.Size = new System.Drawing.Size(80, 30);
            this.Modificarbt.TabIndex = 20;
            this.Modificarbt.Text = "Modificar";
            this.Modificarbt.UseVisualStyleBackColor = false;
            this.Modificarbt.Click += new System.EventHandler(this.Modificarbt_Click);
            // 
            // Nuevobt
            // 
            this.Nuevobt.BackColor = System.Drawing.Color.White;
            this.Nuevobt.Location = new System.Drawing.Point(121, 206);
            this.Nuevobt.Name = "Nuevobt";
            this.Nuevobt.Size = new System.Drawing.Size(80, 30);
            this.Nuevobt.TabIndex = 19;
            this.Nuevobt.Text = "Nuevo";
            this.Nuevobt.UseVisualStyleBackColor = false;
            this.Nuevobt.Click += new System.EventHandler(this.Nuevobt_Click);
            // 
            // ProductosDGV
            // 
            this.ProductosDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductosDGV.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ProductosDGV.Location = new System.Drawing.Point(0, 242);
            this.ProductosDGV.Name = "ProductosDGV";
            this.ProductosDGV.Size = new System.Drawing.Size(686, 166);
            this.ProductosDGV.TabIndex = 24;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // EstaActivocheckBox
            // 
            this.EstaActivocheckBox.AutoSize = true;
            this.EstaActivocheckBox.Enabled = false;
            this.EstaActivocheckBox.Location = new System.Drawing.Point(121, 171);
            this.EstaActivocheckBox.Name = "EstaActivocheckBox";
            this.EstaActivocheckBox.Size = new System.Drawing.Size(15, 14);
            this.EstaActivocheckBox.TabIndex = 26;
            this.EstaActivocheckBox.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 16);
            this.label6.TabIndex = 25;
            this.label6.Text = "Esta Activo:";
            // 
            // ProductosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 408);
            this.Controls.Add(this.EstaActivocheckBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ProductosDGV);
            this.Controls.Add(this.Cancelarbt);
            this.Controls.Add(this.Eliminarbt);
            this.Controls.Add(this.guardarbt);
            this.Controls.Add(this.Modificarbt);
            this.Controls.Add(this.Nuevobt);
            this.Controls.Add(this.Adjuntarimagenbt);
            this.Controls.Add(this.ImagenPB);
            this.Controls.Add(this.Preciotxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Existenciatxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Descripciontxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Codigotxt);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ProductosForm";
            this.Text = "Productos";
            this.Load += new System.EventHandler(this.ProductosForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ImagenPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductosDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Codigotxt;
        private System.Windows.Forms.TextBox Descripciontxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Existenciatxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Preciotxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox ImagenPB;
        private System.Windows.Forms.Button Adjuntarimagenbt;
        private System.Windows.Forms.Button Cancelarbt;
        private System.Windows.Forms.Button Eliminarbt;
        private System.Windows.Forms.Button guardarbt;
        private System.Windows.Forms.Button Modificarbt;
        private System.Windows.Forms.Button Nuevobt;
        private System.Windows.Forms.DataGridView ProductosDGV;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.CheckBox EstaActivocheckBox;
        private System.Windows.Forms.Label label6;
    }
}