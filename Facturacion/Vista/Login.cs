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
    public partial class Login : Form
    {
        public Login()
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

        }
    }
}
