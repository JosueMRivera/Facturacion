using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Vista
{
    public partial class ProductosForm : Syncfusion.Windows.Forms.Office2010Form
    {
        public ProductosForm()
        {
            InitializeComponent();
        }
        string tipoOperacion;

        private void HabilitarControles()
        {
            Codigotxt.Enabled = true;
            Descripciontxt.Enabled = true;
            Existenciatxt.Enabled = true;
            Preciotxt.Enabled = true;
            Adjuntarimagenbt.Enabled = true;
            guardarbt.Enabled = true;
            Cancelarbt.Enabled = true;
            Nuevobt.Enabled = false;
        }

        private void DeshabilitarControles()
        {
            Codigotxt.Enabled = false;
            Descripciontxt.Enabled = false;
            Existenciatxt.Enabled = false;
            Preciotxt.Enabled = false;
            Adjuntarimagenbt.Enabled = false;
            guardarbt.Enabled = false;
            Cancelarbt.Enabled = false;
            Nuevobt.Enabled = true;
        }

        private void LimpiarControles()
        {
            Codigotxt.Clear();
            Descripciontxt.Clear();
            Existenciatxt.Clear();
            Preciotxt.Clear();
            ImagenPB.Image = null;
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

        private void Modificarbt_Click(object sender, EventArgs e)
        {
            tipoOperacion = "Modificar";
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
                if (string.IsNullOrEmpty(Descripciontxt.Text))
                {
                    errorProvider1.SetError(Descripciontxt, "Ingrese una Descripcion");
                    Descripciontxt.Focus();
                    return;
                }
                errorProvider1.Clear();
                if (string.IsNullOrEmpty(Existenciatxt.Text))
                {
                    errorProvider1.SetError(Existenciatxt, "Ingrese la Existencia");
                    Existenciatxt.Focus();
                    return;
                }
                errorProvider1.Clear();
                if (string.IsNullOrEmpty(Preciotxt.Text))
                {
                    errorProvider1.SetError(Preciotxt, "Ingrese un Precio");
                    Preciotxt.Focus();
                    return;
                }
                errorProvider1.Clear();

                Productos misproductos = new Productos();

                misproductos.Codigo = Codigotxt.Text;
                misproductos.Descripcion = Descripciontxt.Text;
                misproductos.Existencia = Convert.ToInt32(Existenciatxt.Text);
                misproductos.Precio = Convert.ToDecimal(Preciotxt.Text);

                if (ImagenPB.Image != null)
                {
                    System.IO.MemoryStream ms = new System.IO.MemoryStream();
                    ImagenPB.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    misproductos.Imagen = ms.GetBuffer();
                }

                //Insertar en la base de datos

            }


        }

        private void Adjuntarimagenbt_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            DialogResult resultado = dialog.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                ImagenPB.Image = Image.FromFile(dialog.FileName);
            }
        }

        private void Existenciatxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void Preciotxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }

        }



    }
}
