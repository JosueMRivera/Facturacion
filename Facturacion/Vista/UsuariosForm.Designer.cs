
namespace Vista
{
    partial class UsuariosForm
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
            this.Nombretxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.passwordtxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.correotxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.RolCB = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.EstaActivocheckBox = new System.Windows.Forms.CheckBox();
            this.Adjuntarbt = new System.Windows.Forms.Button();
            this.FotoPB = new System.Windows.Forms.PictureBox();
            this.Nuevobt = new System.Windows.Forms.Button();
            this.Modificarbt = new System.Windows.Forms.Button();
            this.guardarbt = new System.Windows.Forms.Button();
            this.Eliminarbt = new System.Windows.Forms.Button();
            this.Cancelarbt = new System.Windows.Forms.Button();
            this.UsuariosDGV = new System.Windows.Forms.DataGridView();
            this.mostrarcontraseñabt = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.FotoPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UsuariosDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo:";
            // 
            // Codigotxt
            // 
            this.Codigotxt.Enabled = false;
            this.Codigotxt.Location = new System.Drawing.Point(108, 17);
            this.Codigotxt.Name = "Codigotxt";
            this.Codigotxt.Size = new System.Drawing.Size(252, 22);
            this.Codigotxt.TabIndex = 1;
            // 
            // Nombretxt
            // 
            this.Nombretxt.Enabled = false;
            this.Nombretxt.Location = new System.Drawing.Point(108, 52);
            this.Nombretxt.Name = "Nombretxt";
            this.Nombretxt.Size = new System.Drawing.Size(252, 22);
            this.Nombretxt.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre:";
            // 
            // passwordtxt
            // 
            this.passwordtxt.Enabled = false;
            this.passwordtxt.Location = new System.Drawing.Point(108, 90);
            this.passwordtxt.Name = "passwordtxt";
            this.passwordtxt.PasswordChar = '*';
            this.passwordtxt.Size = new System.Drawing.Size(252, 22);
            this.passwordtxt.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Contraseña:";
            // 
            // correotxt
            // 
            this.correotxt.Enabled = false;
            this.correotxt.Location = new System.Drawing.Point(108, 128);
            this.correotxt.Name = "correotxt";
            this.correotxt.Size = new System.Drawing.Size(252, 22);
            this.correotxt.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Email:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Rol:";
            // 
            // RolCB
            // 
            this.RolCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RolCB.Enabled = false;
            this.RolCB.FormattingEnabled = true;
            this.RolCB.Items.AddRange(new object[] {
            "Administrador",
            "Usuario"});
            this.RolCB.Location = new System.Drawing.Point(107, 165);
            this.RolCB.Name = "RolCB";
            this.RolCB.Size = new System.Drawing.Size(253, 24);
            this.RolCB.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 209);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Esta Activo:";
            // 
            // EstaActivocheckBox
            // 
            this.EstaActivocheckBox.AutoSize = true;
            this.EstaActivocheckBox.Enabled = false;
            this.EstaActivocheckBox.Location = new System.Drawing.Point(108, 211);
            this.EstaActivocheckBox.Name = "EstaActivocheckBox";
            this.EstaActivocheckBox.Size = new System.Drawing.Size(15, 14);
            this.EstaActivocheckBox.TabIndex = 11;
            this.EstaActivocheckBox.UseVisualStyleBackColor = true;
            // 
            // Adjuntarbt
            // 
            this.Adjuntarbt.Enabled = false;
            this.Adjuntarbt.FlatAppearance.BorderSize = 0;
            this.Adjuntarbt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Adjuntarbt.Image = global::Vista.Properties.Resources.buscar_imagen;
            this.Adjuntarbt.Location = new System.Drawing.Point(582, 118);
            this.Adjuntarbt.Name = "Adjuntarbt";
            this.Adjuntarbt.Size = new System.Drawing.Size(37, 32);
            this.Adjuntarbt.TabIndex = 13;
            this.Adjuntarbt.UseVisualStyleBackColor = true;
            this.Adjuntarbt.Click += new System.EventHandler(this.Adjuntarbt_Click);
            // 
            // FotoPB
            // 
            this.FotoPB.BackColor = System.Drawing.Color.White;
            this.FotoPB.Location = new System.Drawing.Point(401, 17);
            this.FotoPB.Name = "FotoPB";
            this.FotoPB.Size = new System.Drawing.Size(175, 133);
            this.FotoPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FotoPB.TabIndex = 12;
            this.FotoPB.TabStop = false;
            // 
            // Nuevobt
            // 
            this.Nuevobt.BackColor = System.Drawing.Color.White;
            this.Nuevobt.Location = new System.Drawing.Point(108, 244);
            this.Nuevobt.Name = "Nuevobt";
            this.Nuevobt.Size = new System.Drawing.Size(80, 30);
            this.Nuevobt.TabIndex = 14;
            this.Nuevobt.Text = "Nuevo";
            this.Nuevobt.UseVisualStyleBackColor = false;
            this.Nuevobt.Click += new System.EventHandler(this.Nuevobt_Click);
            // 
            // Modificarbt
            // 
            this.Modificarbt.BackColor = System.Drawing.Color.White;
            this.Modificarbt.Location = new System.Drawing.Point(194, 244);
            this.Modificarbt.Name = "Modificarbt";
            this.Modificarbt.Size = new System.Drawing.Size(80, 30);
            this.Modificarbt.TabIndex = 15;
            this.Modificarbt.Text = "Modificar";
            this.Modificarbt.UseVisualStyleBackColor = false;
            this.Modificarbt.Click += new System.EventHandler(this.Modificarbt_Click);
            // 
            // guardarbt
            // 
            this.guardarbt.BackColor = System.Drawing.Color.White;
            this.guardarbt.Enabled = false;
            this.guardarbt.Location = new System.Drawing.Point(280, 244);
            this.guardarbt.Name = "guardarbt";
            this.guardarbt.Size = new System.Drawing.Size(80, 30);
            this.guardarbt.TabIndex = 16;
            this.guardarbt.Text = "Guardar";
            this.guardarbt.UseVisualStyleBackColor = false;
            this.guardarbt.Click += new System.EventHandler(this.guardarbt_Click);
            // 
            // Eliminarbt
            // 
            this.Eliminarbt.BackColor = System.Drawing.Color.White;
            this.Eliminarbt.Location = new System.Drawing.Point(366, 244);
            this.Eliminarbt.Name = "Eliminarbt";
            this.Eliminarbt.Size = new System.Drawing.Size(80, 30);
            this.Eliminarbt.TabIndex = 17;
            this.Eliminarbt.Text = "Eliminar";
            this.Eliminarbt.UseVisualStyleBackColor = false;
            this.Eliminarbt.Click += new System.EventHandler(this.Eliminarbt_Click);
            // 
            // Cancelarbt
            // 
            this.Cancelarbt.BackColor = System.Drawing.Color.White;
            this.Cancelarbt.Enabled = false;
            this.Cancelarbt.Location = new System.Drawing.Point(452, 244);
            this.Cancelarbt.Name = "Cancelarbt";
            this.Cancelarbt.Size = new System.Drawing.Size(80, 30);
            this.Cancelarbt.TabIndex = 18;
            this.Cancelarbt.Text = "Cancelar";
            this.Cancelarbt.UseVisualStyleBackColor = false;
            this.Cancelarbt.Click += new System.EventHandler(this.Cancelarbt_Click);
            // 
            // UsuariosDGV
            // 
            this.UsuariosDGV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UsuariosDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UsuariosDGV.Location = new System.Drawing.Point(0, 280);
            this.UsuariosDGV.Name = "UsuariosDGV";
            this.UsuariosDGV.Size = new System.Drawing.Size(669, 198);
            this.UsuariosDGV.TabIndex = 19;
            // 
            // mostrarcontraseñabt
            // 
            this.mostrarcontraseñabt.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mostrarcontraseñabt.FlatAppearance.BorderSize = 0;
            this.mostrarcontraseñabt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mostrarcontraseñabt.Image = global::Vista.Properties.Resources.mostrar;
            this.mostrarcontraseñabt.Location = new System.Drawing.Point(366, 90);
            this.mostrarcontraseñabt.Name = "mostrarcontraseñabt";
            this.mostrarcontraseñabt.Size = new System.Drawing.Size(18, 23);
            this.mostrarcontraseñabt.TabIndex = 23;
            this.mostrarcontraseñabt.UseVisualStyleBackColor = true;
            this.mostrarcontraseñabt.Click += new System.EventHandler(this.mostrarcontraseñabt_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // UsuariosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 478);
            this.Controls.Add(this.mostrarcontraseñabt);
            this.Controls.Add(this.UsuariosDGV);
            this.Controls.Add(this.Cancelarbt);
            this.Controls.Add(this.Eliminarbt);
            this.Controls.Add(this.guardarbt);
            this.Controls.Add(this.Modificarbt);
            this.Controls.Add(this.Nuevobt);
            this.Controls.Add(this.Adjuntarbt);
            this.Controls.Add(this.FotoPB);
            this.Controls.Add(this.EstaActivocheckBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.RolCB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.correotxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.passwordtxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Nombretxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Codigotxt);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UsuariosForm";
            this.Text = "Usuarios";
            this.Load += new System.EventHandler(this.UsuariosForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FotoPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UsuariosDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Codigotxt;
        private System.Windows.Forms.TextBox Nombretxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox passwordtxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox correotxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox RolCB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox EstaActivocheckBox;
        private System.Windows.Forms.PictureBox FotoPB;
        private System.Windows.Forms.Button Adjuntarbt;
        private System.Windows.Forms.Button Nuevobt;
        private System.Windows.Forms.Button Modificarbt;
        private System.Windows.Forms.Button guardarbt;
        private System.Windows.Forms.Button Eliminarbt;
        private System.Windows.Forms.Button Cancelarbt;
        private System.Windows.Forms.DataGridView UsuariosDGV;
        private System.Windows.Forms.Button mostrarcontraseñabt;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}