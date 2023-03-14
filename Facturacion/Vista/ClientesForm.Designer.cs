
namespace Vista
{
    partial class ClientesForm
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
            this.ClientesDGV = new System.Windows.Forms.DataGridView();
            this.Cancelarbt = new System.Windows.Forms.Button();
            this.Eliminarbt = new System.Windows.Forms.Button();
            this.guardarbt = new System.Windows.Forms.Button();
            this.Modificarbt = new System.Windows.Forms.Button();
            this.Nuevobt = new System.Windows.Forms.Button();
            this.EstaActivocheckBox = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.direcciontxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.telefonotxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Nombretxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.identidadtxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.FechaNacimientodateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.correotxt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.busquedatxt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ClientesDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // ClientesDGV
            // 
            this.ClientesDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ClientesDGV.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ClientesDGV.Location = new System.Drawing.Point(0, 367);
            this.ClientesDGV.Name = "ClientesDGV";
            this.ClientesDGV.Size = new System.Drawing.Size(720, 198);
            this.ClientesDGV.TabIndex = 41;
            // 
            // Cancelarbt
            // 
            this.Cancelarbt.BackColor = System.Drawing.Color.White;
            this.Cancelarbt.Enabled = false;
            this.Cancelarbt.Location = new System.Drawing.Point(451, 285);
            this.Cancelarbt.Name = "Cancelarbt";
            this.Cancelarbt.Size = new System.Drawing.Size(80, 30);
            this.Cancelarbt.TabIndex = 42;
            this.Cancelarbt.Text = "Cancelar";
            this.Cancelarbt.UseVisualStyleBackColor = false;
            this.Cancelarbt.Click += new System.EventHandler(this.Cancelarbt_Click);
            // 
            // Eliminarbt
            // 
            this.Eliminarbt.BackColor = System.Drawing.Color.White;
            this.Eliminarbt.Location = new System.Drawing.Point(365, 285);
            this.Eliminarbt.Name = "Eliminarbt";
            this.Eliminarbt.Size = new System.Drawing.Size(80, 30);
            this.Eliminarbt.TabIndex = 41;
            this.Eliminarbt.Text = "Eliminar";
            this.Eliminarbt.UseVisualStyleBackColor = false;
            this.Eliminarbt.Click += new System.EventHandler(this.Eliminarbt_Click);
            // 
            // guardarbt
            // 
            this.guardarbt.BackColor = System.Drawing.Color.White;
            this.guardarbt.Enabled = false;
            this.guardarbt.Location = new System.Drawing.Point(279, 285);
            this.guardarbt.Name = "guardarbt";
            this.guardarbt.Size = new System.Drawing.Size(80, 30);
            this.guardarbt.TabIndex = 40;
            this.guardarbt.Text = "Guardar";
            this.guardarbt.UseVisualStyleBackColor = false;
            this.guardarbt.Click += new System.EventHandler(this.guardarbt_Click);
            // 
            // Modificarbt
            // 
            this.Modificarbt.BackColor = System.Drawing.Color.White;
            this.Modificarbt.Location = new System.Drawing.Point(193, 285);
            this.Modificarbt.Name = "Modificarbt";
            this.Modificarbt.Size = new System.Drawing.Size(80, 30);
            this.Modificarbt.TabIndex = 39;
            this.Modificarbt.Text = "Modificar";
            this.Modificarbt.UseVisualStyleBackColor = false;
            this.Modificarbt.Click += new System.EventHandler(this.Modificarbt_Click);
            // 
            // Nuevobt
            // 
            this.Nuevobt.BackColor = System.Drawing.Color.White;
            this.Nuevobt.Location = new System.Drawing.Point(107, 285);
            this.Nuevobt.Name = "Nuevobt";
            this.Nuevobt.Size = new System.Drawing.Size(80, 30);
            this.Nuevobt.TabIndex = 38;
            this.Nuevobt.Text = "Nuevo";
            this.Nuevobt.UseVisualStyleBackColor = false;
            this.Nuevobt.Click += new System.EventHandler(this.Nuevobt_Click);
            // 
            // EstaActivocheckBox
            // 
            this.EstaActivocheckBox.AutoSize = true;
            this.EstaActivocheckBox.Enabled = false;
            this.EstaActivocheckBox.Location = new System.Drawing.Point(107, 244);
            this.EstaActivocheckBox.Name = "EstaActivocheckBox";
            this.EstaActivocheckBox.Size = new System.Drawing.Size(15, 14);
            this.EstaActivocheckBox.TabIndex = 37;
            this.EstaActivocheckBox.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 242);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 16);
            this.label6.TabIndex = 34;
            this.label6.Text = "Esta Activo:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 16);
            this.label5.TabIndex = 34;
            this.label5.Text = "Fecha Nacimiento:";
            // 
            // direcciontxt
            // 
            this.direcciontxt.Enabled = false;
            this.direcciontxt.Location = new System.Drawing.Point(107, 161);
            this.direcciontxt.Name = "direcciontxt";
            this.direcciontxt.Size = new System.Drawing.Size(301, 22);
            this.direcciontxt.TabIndex = 33;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 16);
            this.label4.TabIndex = 32;
            this.label4.Text = "Direccion:";
            // 
            // telefonotxt
            // 
            this.telefonotxt.Enabled = false;
            this.telefonotxt.Location = new System.Drawing.Point(107, 91);
            this.telefonotxt.Name = "telefonotxt";
            this.telefonotxt.Size = new System.Drawing.Size(301, 22);
            this.telefonotxt.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 16);
            this.label3.TabIndex = 28;
            this.label3.Text = "Telefono:";
            // 
            // Nombretxt
            // 
            this.Nombretxt.Enabled = false;
            this.Nombretxt.Location = new System.Drawing.Point(107, 53);
            this.Nombretxt.Name = "Nombretxt";
            this.Nombretxt.Size = new System.Drawing.Size(301, 22);
            this.Nombretxt.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 16);
            this.label2.TabIndex = 26;
            this.label2.Text = "Nombre:";
            // 
            // identidadtxt
            // 
            this.identidadtxt.Enabled = false;
            this.identidadtxt.Location = new System.Drawing.Point(107, 18);
            this.identidadtxt.Name = "identidadtxt";
            this.identidadtxt.Size = new System.Drawing.Size(301, 22);
            this.identidadtxt.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 24;
            this.label1.Text = "Identidad:";
            // 
            // FechaNacimientodateTimePicker
            // 
            this.FechaNacimientodateTimePicker.CustomFormat = " ";
            this.FechaNacimientodateTimePicker.Enabled = false;
            this.FechaNacimientodateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FechaNacimientodateTimePicker.Location = new System.Drawing.Point(148, 196);
            this.FechaNacimientodateTimePicker.Name = "FechaNacimientodateTimePicker";
            this.FechaNacimientodateTimePicker.Size = new System.Drawing.Size(120, 22);
            this.FechaNacimientodateTimePicker.TabIndex = 35;
            this.FechaNacimientodateTimePicker.ValueChanged += new System.EventHandler(this.FechaNacimientodateTimePicker_ValueChanged);
            this.FechaNacimientodateTimePicker.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FechaNacimientodateTimePicker_KeyDown);
            // 
            // correotxt
            // 
            this.correotxt.Enabled = false;
            this.correotxt.Location = new System.Drawing.Point(109, 125);
            this.correotxt.Name = "correotxt";
            this.correotxt.Size = new System.Drawing.Size(301, 22);
            this.correotxt.TabIndex = 31;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 128);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 16);
            this.label7.TabIndex = 30;
            this.label7.Text = "Correo:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // busquedatxt
            // 
            this.busquedatxt.Location = new System.Drawing.Point(25, 330);
            this.busquedatxt.Name = "busquedatxt";
            this.busquedatxt.Size = new System.Drawing.Size(134, 22);
            this.busquedatxt.TabIndex = 43;
            this.busquedatxt.TextChanged += new System.EventHandler(this.busquedatxt_TextChanged);
            this.busquedatxt.KeyUp += new System.Windows.Forms.KeyEventHandler(this.busquedatxt_KeyUp);
            // 
            // ClientesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 565);
            this.Controls.Add(this.busquedatxt);
            this.Controls.Add(this.correotxt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.FechaNacimientodateTimePicker);
            this.Controls.Add(this.ClientesDGV);
            this.Controls.Add(this.Cancelarbt);
            this.Controls.Add(this.Eliminarbt);
            this.Controls.Add(this.guardarbt);
            this.Controls.Add(this.Modificarbt);
            this.Controls.Add(this.Nuevobt);
            this.Controls.Add(this.EstaActivocheckBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.direcciontxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.telefonotxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Nombretxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.identidadtxt);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ClientesForm";
            this.Text = "ClientesForm";
            this.Load += new System.EventHandler(this.ClientesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ClientesDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ClientesDGV;
        private System.Windows.Forms.Button Cancelarbt;
        private System.Windows.Forms.Button Eliminarbt;
        private System.Windows.Forms.Button guardarbt;
        private System.Windows.Forms.Button Modificarbt;
        private System.Windows.Forms.Button Nuevobt;
        private System.Windows.Forms.CheckBox EstaActivocheckBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox direcciontxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox telefonotxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Nombretxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox identidadtxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker FechaNacimientodateTimePicker;
        private System.Windows.Forms.TextBox correotxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox busquedatxt;
    }
}