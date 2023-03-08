using Datos;
using Entidades;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Vista
{
    public partial class ProductosForm : Syncfusion.Windows.Forms.Office2010Form
    {
        public ProductosForm()
        {
            InitializeComponent();
        }
        string operacion;
        Productos producto;
        ProductoDB productoDB = new ProductoDB();

        private void Nuevobt_Click(object sender, EventArgs e)
        {
            Codigotxt.Focus();
            operacion = "Nuevo";
            HabilitarControles();
        }

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
            Eliminarbt.Enabled = false;
            EstaActivocheckBox.Enabled = true;
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
            Eliminarbt.Enabled = true;
            EstaActivocheckBox.Enabled = false;
        }

        private void LimpiarControles()
        {
            Codigotxt.Clear();
            Descripciontxt.Clear();
            Existenciatxt.Clear();
            Preciotxt.Clear();
            EstaActivocheckBox.Checked = false;
            ImagenPB.Image = null;
            producto = null;
        }

        private void Cancelarbt_Click(object sender, EventArgs e)
        {
            DeshabilitarControles();
            LimpiarControles();
        }

        private void Modificarbt_Click(object sender, EventArgs e)
        {
            operacion = "Modificar";
            if (ProductosDGV.SelectedRows.Count > 0)
            {
                Codigotxt.Text = ProductosDGV.CurrentRow.Cells["Codigo"].Value.ToString();
                Descripciontxt.Text = ProductosDGV.CurrentRow.Cells["Descripcion"].Value.ToString();
                Existenciatxt.Text = ProductosDGV.CurrentRow.Cells["Existencia"].Value.ToString();
                Preciotxt.Text = ProductosDGV.CurrentRow.Cells["Precio"].Value.ToString();
                EstaActivocheckBox.Checked = Convert.ToBoolean(ProductosDGV.CurrentRow.Cells["EstaActivo"].Value);

                byte[] img = productoDB.DevolverFoto(ProductosDGV.CurrentRow.Cells["Codigo"].Value.ToString());

                if (img.Length > 0)
                {
                    MemoryStream ms = new MemoryStream(img);
                    ImagenPB.Image = System.Drawing.Bitmap.FromStream(ms);
                }
                HabilitarControles();
                Codigotxt.ReadOnly = true;
            }
            else
            {
                MessageBox.Show("Debe seleccionar un registro");
            }
        }

        private void guardarbt_Click(object sender, EventArgs e)
        {
            producto = new Productos();
            producto.Codigo = Codigotxt.Text;
            producto.Descripcion = Descripciontxt.Text;
            producto.Precio = Convert.ToDecimal(Preciotxt.Text);
            producto.Existencia = Convert.ToInt32(Existenciatxt.Text);
            producto.EstaActivo = EstaActivocheckBox.Checked;

            if (ImagenPB.Image != null)
            {
                System.IO.MemoryStream ms = new System.IO.MemoryStream();
                ImagenPB.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                producto.Imagen = ms.GetBuffer();
            }

            if (operacion == "Nuevo")
            {
                if (string.IsNullOrEmpty(Codigotxt.Text))
                {
                    errorProvider1.SetError(Codigotxt, "Ingrese un código");
                    Codigotxt.Focus();
                    return;
                }
                errorProvider1.Clear();

                if (string.IsNullOrEmpty(Descripciontxt.Text))
                {
                    errorProvider1.SetError(Descripciontxt, "Ingrese una descripción");
                    Descripciontxt.Focus();
                    return;
                }
                errorProvider1.Clear();

                if (string.IsNullOrEmpty(Existenciatxt.Text))
                {
                    errorProvider1.SetError(Existenciatxt, "Ingrese una existencia");
                    Existenciatxt.Focus();
                    return;
                }
                errorProvider1.Clear();

                if (string.IsNullOrEmpty(Preciotxt.Text))
                {
                    errorProvider1.SetError(Preciotxt, "Ingrese un precio");
                    Preciotxt.Focus();
                    return;
                }
                errorProvider1.Clear();

                bool inserto = productoDB.Insertar(producto);
                if (inserto)
                {
                    DeshabilitarControles();
                    LimpiarControles();
                    TraerProductos();
                    MessageBox.Show("Registro guardado con exito", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se pudo guardar el registro", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (operacion == "Modificar")
            {
                bool modifico = productoDB.Editar(producto);
                if (modifico)
                {
                    Codigotxt.ReadOnly = false;
                    LimpiarControles();
                    DeshabilitarControles();
                    TraerProductos();
                    MessageBox.Show("Registro actualizado con exito", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se pudo actualizar el registro", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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

        private void TraerProductos()
        {
            ProductosDGV.DataSource = productoDB.DevolverProductos(); ;
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
            if (!char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && e.KeyChar != '\b')
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && (sender as TextBox).Text.IndexOf('.') > -1 && e.KeyChar != '\b')
            {
                e.Handled = true;
            }

        }

        private void ProductosForm_Load(object sender, EventArgs e)
        {
            TraerProductos();
        }

        private void Eliminarbt_Click(object sender, EventArgs e)
        {
            if (ProductosDGV.SelectedRows.Count > 0)
            {

                DialogResult resultado = MessageBox.Show("Esta seguro de eliminar el registro", "Advertencia", MessageBoxButtons.YesNo);
                if (resultado == DialogResult.Yes)
                {
                    bool elimino = productoDB.Eliminar(ProductosDGV.CurrentRow.Cells["Codigo"].Value.ToString());

                    if (elimino)
                    {
                        LimpiarControles();
                        DeshabilitarControles();
                        TraerProductos();
                        MessageBox.Show("Registro eliminado con exito", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No se pudo eliminar el registro", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
