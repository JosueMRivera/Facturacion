using Datos;
using Entidades;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Vista
{
    public partial class UsuariosForm : Syncfusion.Windows.Forms.Office2010Form
    {
        public UsuariosForm()
        {
            InitializeComponent();
        }
        string tipoOperacion;

        DataTable dt = new DataTable();
        UsuarioDB usuarioDB = new UsuarioDB();

        Usuario user = new Usuario();

        private void HabilitarControles()
        {
            Codigotxt.Enabled = true;
            Nombretxt.Enabled = true;
            passwordtxt.Enabled = true;
            correotxt.Enabled = true;
            RolCB.Enabled = true;
            EstaActivocheckBox.Enabled = true;
            Adjuntarbt.Enabled = true;
            guardarbt.Enabled = true;
            Cancelarbt.Enabled = true;
            Nuevobt.Enabled = false;
            Modificarbt.Enabled = false;
        }

        private void DeshabilitarControles()
        {
            Codigotxt.Enabled = false;
            Nombretxt.Enabled = false;
            passwordtxt.Enabled = false;
            correotxt.Enabled = false;
            RolCB.Enabled = false;
            EstaActivocheckBox.Enabled = false;
            Adjuntarbt.Enabled = false;
            guardarbt.Enabled = false;
            Cancelarbt.Enabled = false;
            Nuevobt.Enabled = true;
            Modificarbt.Enabled = true;
        }

        private void LimpiarControles()
        {
            Codigotxt.Clear();
            Nombretxt.Clear();
            passwordtxt.Clear();
            correotxt.Clear();
            RolCB.Text = "";
            EstaActivocheckBox.Checked = false;
            FotoPB.Image = null;
        }

        private void mostrarcontraseñabt_Click(object sender, EventArgs e)
        {
            if (passwordtxt.PasswordChar == '*')
            {
                passwordtxt.PasswordChar = '\0';
            }
            else
            {
                passwordtxt.PasswordChar = '*';
            }
        }

        private void Nuevobt_Click(object sender, EventArgs e)
        {
            Codigotxt.Focus();
            HabilitarControles();
            tipoOperacion = "Nuevo";
        }

        private void Cancelarbt_Click(object sender, EventArgs e)
        {
            DeshabilitarControles();
            LimpiarControles();
        }

        private void guardarbt_Click(object sender, EventArgs e)
        {
            if (tipoOperacion == "Nuevo")
            {
                if (string.IsNullOrEmpty(Codigotxt.Text))
                {
                    errorProvider1.SetError(Codigotxt, "Ingrese un Codigo");
                    Codigotxt.Focus();
                    return;
                }
                errorProvider1.Clear();
                if (string.IsNullOrEmpty(Nombretxt.Text))
                {
                    errorProvider1.SetError(Nombretxt, "Ingrese un Nombre");
                    Nombretxt.Focus();
                    return;
                }
                errorProvider1.Clear();
                if (string.IsNullOrEmpty(passwordtxt.Text))
                {
                    errorProvider1.SetError(passwordtxt, "Ingrese una Contraseña");
                    passwordtxt.Focus();
                    return;
                }
                errorProvider1.Clear();
                if (string.IsNullOrEmpty(RolCB.Text))
                {
                    errorProvider1.SetError(RolCB, "Seleccione un Rol");
                    RolCB.Focus();
                    return;
                }
                errorProvider1.Clear();

                user.CodigoUsuario = Codigotxt.Text;
                user.Nombre = Nombretxt.Text;
                user.Contraseña = passwordtxt.Text;
                user.Rol = RolCB.Text;
                user.Correo = correotxt.Text;
                user.EstaActivo = EstaActivocheckBox.Checked;

                if (FotoPB.Image != null)
                {
                    System.IO.MemoryStream ms = new System.IO.MemoryStream();
                    FotoPB.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    user.Foto = ms.GetBuffer();
                }

                //Insertar en la base de datos

                bool inserto = usuarioDB.Insertar(user);

                if (inserto)
                {
                    LimpiarControles();
                    DeshabilitarControles();
                    TraerUsuarios();
                    MessageBox.Show("Registro guardado");
                    
                }
                else
                {
                    MessageBox.Show("No se pudo guardar el registro");
                }


            }
            else if (tipoOperacion == "Modificar")
            {
                user.CodigoUsuario = Codigotxt.Text;
                user.Nombre = Nombretxt.Text;
                user.Contraseña = passwordtxt.Text;
                user.Rol = RolCB.Text;
                user.Correo = correotxt.Text;
                user.EstaActivo = EstaActivocheckBox.Checked;

                if (FotoPB.Image != null)
                {
                    System.IO.MemoryStream ms = new System.IO.MemoryStream();
                    FotoPB.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    user.Foto = ms.GetBuffer();
                }

                bool modifico = usuarioDB.Editar(user);
                if (modifico)
                {
                    LimpiarControles();
                    DeshabilitarControles();
                    TraerUsuarios();
                    MessageBox.Show("Registro actualizado correctamente");
                }
                else
                {
                    MessageBox.Show("No se pudo actualizar el registro");
                }

            }
        }

        private void Modificarbt_Click(object sender, EventArgs e)
        {
            tipoOperacion = "Modificar";
            if (UsuariosDGV.SelectedRows.Count > 0)
            {
                Codigotxt.Text = UsuariosDGV.CurrentRow.Cells["CodigoUsuario"].Value.ToString();
                Nombretxt.Text = UsuariosDGV.CurrentRow.Cells["Nombre"].Value.ToString();
                passwordtxt.Text = UsuariosDGV.CurrentRow.Cells["Password"].Value.ToString();
                correotxt.Text = UsuariosDGV.CurrentRow.Cells["Correo"].Value.ToString();
                RolCB.Text = UsuariosDGV.CurrentRow.Cells["Rol"].Value.ToString();
                EstaActivocheckBox.Checked = Convert.ToBoolean(UsuariosDGV.CurrentRow.Cells["EstadoActivo"].Value);

                byte[] miFoto = usuarioDB.DevolverFoto(Codigotxt.Text = UsuariosDGV.CurrentRow.Cells["CodigoUsuario"].Value.ToString());
                if (miFoto.Length > 0)
                {
                    MemoryStream ms = new MemoryStream(miFoto);
                    FotoPB.Image = System.Drawing.Bitmap.FromStream(ms);
                }

                HabilitarControles();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un registro");
            }
        }

        private void Adjuntarbt_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            DialogResult resultado = dialog.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                FotoPB.Image = Image.FromFile(dialog.FileName);
            }

        }

        private void UsuariosForm_Load(object sender, EventArgs e)
        {
            TraerUsuarios();
        }

        private void TraerUsuarios()
        {
            dt = usuarioDB.DevolverUsuarios();
            UsuariosDGV.DataSource = dt;
        }

        private void Eliminarbt_Click(object sender, EventArgs e)
        {
            if (UsuariosDGV.SelectedRows.Count > 0)
            {

                DialogResult resultado = MessageBox.Show("Esta seguro de eliminar el registro", "Advertencia", MessageBoxButtons.YesNo);
                if (resultado == DialogResult.Yes)
                {
                    bool elimino = usuarioDB.Eliminar(UsuariosDGV.CurrentRow.Cells["CodigoUsuario"].Value.ToString());

                    if (elimino)
                    {
                        LimpiarControles();
                        DeshabilitarControles();
                        TraerUsuarios();
                        MessageBox.Show("Registro eliminado");
                    }
                    else
                    {
                        MessageBox.Show("No se pudo eliminar el registro");
                    }
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un registro");
            }
        }
    }
}
