﻿
namespace Vista
{
    partial class LoginForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Contraseñatxt = new System.Windows.Forms.TextBox();
            this.Usuariotxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.aceptarbt = new System.Windows.Forms.Button();
            this.cancelarbt = new System.Windows.Forms.Button();
            this.mostrarcontraseñabt = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Contraseñatxt
            // 
            this.Contraseñatxt.Location = new System.Drawing.Point(98, 54);
            this.Contraseñatxt.Name = "Contraseñatxt";
            this.Contraseñatxt.PasswordChar = '*';
            this.Contraseñatxt.Size = new System.Drawing.Size(207, 22);
            this.Contraseñatxt.TabIndex = 18;
            // 
            // Usuariotxt
            // 
            this.Usuariotxt.Location = new System.Drawing.Point(98, 21);
            this.Usuariotxt.Name = "Usuariotxt";
            this.Usuariotxt.Size = new System.Drawing.Size(207, 22);
            this.Usuariotxt.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "Contraseña:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 16);
            this.label1.TabIndex = 15;
            this.label1.Text = "Usuario:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // aceptarbt
            // 
            this.aceptarbt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aceptarbt.Image = global::Vista.Properties.Resources.comprobado;
            this.aceptarbt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.aceptarbt.Location = new System.Drawing.Point(98, 98);
            this.aceptarbt.Name = "aceptarbt";
            this.aceptarbt.Size = new System.Drawing.Size(103, 30);
            this.aceptarbt.TabIndex = 19;
            this.aceptarbt.Text = "Aceptar";
            this.aceptarbt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.aceptarbt.UseVisualStyleBackColor = true;
            this.aceptarbt.Click += new System.EventHandler(this.aceptarbt_Click);
            // 
            // cancelarbt
            // 
            this.cancelarbt.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelarbt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelarbt.Image = global::Vista.Properties.Resources.cancelar;
            this.cancelarbt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cancelarbt.Location = new System.Drawing.Point(202, 98);
            this.cancelarbt.Name = "cancelarbt";
            this.cancelarbt.Size = new System.Drawing.Size(103, 30);
            this.cancelarbt.TabIndex = 21;
            this.cancelarbt.Text = "Cancelar";
            this.cancelarbt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cancelarbt.UseVisualStyleBackColor = true;
            this.cancelarbt.Click += new System.EventHandler(this.cancelarbt_Click);
            // 
            // mostrarcontraseñabt
            // 
            this.mostrarcontraseñabt.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mostrarcontraseñabt.FlatAppearance.BorderSize = 0;
            this.mostrarcontraseñabt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mostrarcontraseñabt.Image = global::Vista.Properties.Resources.mostrar;
            this.mostrarcontraseñabt.Location = new System.Drawing.Point(311, 54);
            this.mostrarcontraseñabt.Name = "mostrarcontraseñabt";
            this.mostrarcontraseñabt.Size = new System.Drawing.Size(18, 23);
            this.mostrarcontraseñabt.TabIndex = 22;
            this.mostrarcontraseñabt.UseVisualStyleBackColor = true;
            this.mostrarcontraseñabt.Click += new System.EventHandler(this.mostrarcontraseñabt_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = global::Vista.Properties.Resources.usuario;
            this.pictureBox1.Location = new System.Drawing.Point(342, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 107);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // Login
            // 
            this.AcceptButton = this.aceptarbt;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelarbt;
            this.ClientSize = new System.Drawing.Size(482, 153);
            this.ControlBox = false;
            this.Controls.Add(this.mostrarcontraseñabt);
            this.Controls.Add(this.cancelarbt);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.aceptarbt);
            this.Controls.Add(this.Contraseñatxt);
            this.Controls.Add(this.Usuariotxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelarbt;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button aceptarbt;
        private System.Windows.Forms.TextBox Contraseñatxt;
        private System.Windows.Forms.TextBox Usuariotxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button mostrarcontraseñabt;
    }
}

