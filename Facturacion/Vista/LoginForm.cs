﻿using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void cancelarbt_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void aceptarbt_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Usuariotxt.Text))
            {
                errorProvider1.SetError(Usuariotxt, "Ingrese un Usuario");
                Usuariotxt.Focus();
                return;
            }
            errorProvider1.Clear();

            if (string.IsNullOrEmpty(Contraseñatxt.Text))
            {
                errorProvider1.SetError(Contraseñatxt, "Ingrese una Contraseña");
                Contraseñatxt.Focus();
                return;
            }
            errorProvider1.Clear();

            //Validar en la base de datos

            Login login = new Login(Usuariotxt.Text, Contraseñatxt.Text);
            Usuario usuario = new Usuario();
            UsuarioDB usuarioDB = new UsuarioDB();


            //Mostramos el menu

            Menu menuformulario = new Menu();
            this.Hide();
            menuformulario.Show();



        }

        private void mostrarcontraseñabt_Click(object sender, EventArgs e)
        {
            if (Contraseñatxt.PasswordChar == '*')
            {
                Contraseñatxt.PasswordChar = '\0';
            }
            else
            {
                Contraseñatxt.PasswordChar = '*';
            }
        }
    }
}