
namespace Vista
{
    partial class FacturaForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.FechadateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.Usuariotxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Nombreclientetxt = new System.Windows.Forms.TextBox();
            this.Buscarclientebt = new System.Windows.Forms.Button();
            this.Identidadtxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cantidadtxt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.existenciatxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Descripcionproductotxt = new System.Windows.Forms.TextBox();
            this.Buscarproductobt = new System.Windows.Forms.Button();
            this.codigotxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.DetalleproductoDGV = new System.Windows.Forms.DataGridView();
            this.subtotaltxt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.isvtxt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.descuentotxt = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.totalapagartxt = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cancelarbt = new System.Windows.Forms.Button();
            this.guardarbt = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DetalleproductoDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(412, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nueva Factura";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.FechadateTimePicker);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.Usuariotxt);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(960, 51);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // FechadateTimePicker
            // 
            this.FechadateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FechadateTimePicker.Location = new System.Drawing.Point(842, 15);
            this.FechadateTimePicker.Name = "FechadateTimePicker";
            this.FechadateTimePicker.Size = new System.Drawing.Size(112, 22);
            this.FechadateTimePicker.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(787, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fecha:";
            // 
            // Usuariotxt
            // 
            this.Usuariotxt.Location = new System.Drawing.Point(79, 15);
            this.Usuariotxt.Name = "Usuariotxt";
            this.Usuariotxt.ReadOnly = true;
            this.Usuariotxt.Size = new System.Drawing.Size(219, 22);
            this.Usuariotxt.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Usuario:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Nombreclientetxt);
            this.groupBox2.Controls.Add(this.Buscarclientebt);
            this.groupBox2.Controls.Add(this.Identidadtxt);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(12, 102);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(960, 69);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos Cliente";
            // 
            // Nombreclientetxt
            // 
            this.Nombreclientetxt.Location = new System.Drawing.Point(343, 27);
            this.Nombreclientetxt.Name = "Nombreclientetxt";
            this.Nombreclientetxt.ReadOnly = true;
            this.Nombreclientetxt.Size = new System.Drawing.Size(611, 22);
            this.Nombreclientetxt.TabIndex = 3;
            // 
            // Buscarclientebt
            // 
            this.Buscarclientebt.FlatAppearance.BorderSize = 0;
            this.Buscarclientebt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Buscarclientebt.Image = global::Vista.Properties.Resources.buscar_cliente1;
            this.Buscarclientebt.Location = new System.Drawing.Point(304, 27);
            this.Buscarclientebt.Name = "Buscarclientebt";
            this.Buscarclientebt.Size = new System.Drawing.Size(33, 23);
            this.Buscarclientebt.TabIndex = 2;
            this.Buscarclientebt.UseVisualStyleBackColor = true;
            // 
            // Identidadtxt
            // 
            this.Identidadtxt.Location = new System.Drawing.Point(79, 27);
            this.Identidadtxt.Name = "Identidadtxt";
            this.Identidadtxt.Size = new System.Drawing.Size(219, 22);
            this.Identidadtxt.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Identidad:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cantidadtxt);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.existenciatxt);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.Descripcionproductotxt);
            this.groupBox3.Controls.Add(this.Buscarproductobt);
            this.groupBox3.Controls.Add(this.codigotxt);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(12, 187);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(960, 103);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Datos Cliente";
            // 
            // cantidadtxt
            // 
            this.cantidadtxt.Location = new System.Drawing.Point(842, 65);
            this.cantidadtxt.Name = "cantidadtxt";
            this.cantidadtxt.Size = new System.Drawing.Size(112, 22);
            this.cantidadtxt.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(769, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Cantidad:";
            // 
            // existenciatxt
            // 
            this.existenciatxt.Location = new System.Drawing.Point(79, 65);
            this.existenciatxt.Name = "existenciatxt";
            this.existenciatxt.ReadOnly = true;
            this.existenciatxt.Size = new System.Drawing.Size(219, 22);
            this.existenciatxt.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "Existencia:";
            // 
            // Descripcionproductotxt
            // 
            this.Descripcionproductotxt.Location = new System.Drawing.Point(343, 27);
            this.Descripcionproductotxt.Name = "Descripcionproductotxt";
            this.Descripcionproductotxt.ReadOnly = true;
            this.Descripcionproductotxt.Size = new System.Drawing.Size(611, 22);
            this.Descripcionproductotxt.TabIndex = 3;
            // 
            // Buscarproductobt
            // 
            this.Buscarproductobt.FlatAppearance.BorderSize = 0;
            this.Buscarproductobt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Buscarproductobt.Image = global::Vista.Properties.Resources.buscar_cliente1;
            this.Buscarproductobt.Location = new System.Drawing.Point(304, 27);
            this.Buscarproductobt.Name = "Buscarproductobt";
            this.Buscarproductobt.Size = new System.Drawing.Size(33, 23);
            this.Buscarproductobt.TabIndex = 2;
            this.Buscarproductobt.UseVisualStyleBackColor = true;
            // 
            // codigotxt
            // 
            this.codigotxt.Location = new System.Drawing.Point(79, 27);
            this.codigotxt.Name = "codigotxt";
            this.codigotxt.Size = new System.Drawing.Size(219, 22);
            this.codigotxt.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Codigo:";
            // 
            // DetalleproductoDGV
            // 
            this.DetalleproductoDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DetalleproductoDGV.Location = new System.Drawing.Point(2, 308);
            this.DetalleproductoDGV.Name = "DetalleproductoDGV";
            this.DetalleproductoDGV.Size = new System.Drawing.Size(982, 169);
            this.DetalleproductoDGV.TabIndex = 6;
            // 
            // subtotaltxt
            // 
            this.subtotaltxt.Location = new System.Drawing.Point(825, 492);
            this.subtotaltxt.Name = "subtotaltxt";
            this.subtotaltxt.ReadOnly = true;
            this.subtotaltxt.Size = new System.Drawing.Size(147, 22);
            this.subtotaltxt.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(744, 495);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 16);
            this.label9.TabIndex = 8;
            this.label9.Text = "Sub Total:";
            // 
            // isvtxt
            // 
            this.isvtxt.Location = new System.Drawing.Point(825, 519);
            this.isvtxt.Name = "isvtxt";
            this.isvtxt.ReadOnly = true;
            this.isvtxt.Size = new System.Drawing.Size(147, 22);
            this.isvtxt.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(781, 522);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 16);
            this.label8.TabIndex = 10;
            this.label8.Text = "ISV:";
            // 
            // descuentotxt
            // 
            this.descuentotxt.Location = new System.Drawing.Point(825, 549);
            this.descuentotxt.Name = "descuentotxt";
            this.descuentotxt.Size = new System.Drawing.Size(147, 22);
            this.descuentotxt.TabIndex = 13;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(737, 552);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 16);
            this.label10.TabIndex = 12;
            this.label10.Text = "Descuento:";
            // 
            // totalapagartxt
            // 
            this.totalapagartxt.Location = new System.Drawing.Point(825, 579);
            this.totalapagartxt.Name = "totalapagartxt";
            this.totalapagartxt.ReadOnly = true;
            this.totalapagartxt.Size = new System.Drawing.Size(147, 22);
            this.totalapagartxt.TabIndex = 15;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(720, 582);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(93, 16);
            this.label11.TabIndex = 14;
            this.label11.Text = "Total a Pagar:";
            // 
            // cancelarbt
            // 
            this.cancelarbt.BackColor = System.Drawing.Color.White;
            this.cancelarbt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelarbt.Image = global::Vista.Properties.Resources.cancelar;
            this.cancelarbt.Location = new System.Drawing.Point(117, 572);
            this.cancelarbt.Name = "cancelarbt";
            this.cancelarbt.Size = new System.Drawing.Size(106, 36);
            this.cancelarbt.TabIndex = 24;
            this.cancelarbt.Text = "Cancelar";
            this.cancelarbt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cancelarbt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cancelarbt.UseVisualStyleBackColor = false;
            // 
            // guardarbt
            // 
            this.guardarbt.BackColor = System.Drawing.Color.White;
            this.guardarbt.Enabled = false;
            this.guardarbt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guardarbt.Image = global::Vista.Properties.Resources.guardar;
            this.guardarbt.Location = new System.Drawing.Point(5, 572);
            this.guardarbt.Name = "guardarbt";
            this.guardarbt.Size = new System.Drawing.Size(106, 36);
            this.guardarbt.TabIndex = 23;
            this.guardarbt.Text = "Guardar";
            this.guardarbt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.guardarbt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.guardarbt.UseVisualStyleBackColor = false;
            // 
            // FacturaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(984, 618);
            this.Controls.Add(this.cancelarbt);
            this.Controls.Add(this.guardarbt);
            this.Controls.Add(this.totalapagartxt);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.descuentotxt);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.isvtxt);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.DetalleproductoDGV);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.subtotaltxt);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FacturaForm";
            this.Text = "FacturaForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DetalleproductoDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox Usuariotxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker FechadateTimePicker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox Nombreclientetxt;
        private System.Windows.Forms.Button Buscarclientebt;
        private System.Windows.Forms.TextBox Identidadtxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox cantidadtxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox existenciatxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Descripcionproductotxt;
        private System.Windows.Forms.Button Buscarproductobt;
        private System.Windows.Forms.TextBox codigotxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView DetalleproductoDGV;
        private System.Windows.Forms.TextBox subtotaltxt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox isvtxt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox descuentotxt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox totalapagartxt;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button cancelarbt;
        private System.Windows.Forms.Button guardarbt;
    }
}