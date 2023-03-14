using Datos;
using Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Vista
{
    public partial class ClientesForm : Syncfusion.Windows.Forms.Office2010Form
    {
        public ClientesForm()
        {
            InitializeComponent();
        }
        string tipoOperacion;

        DataTable dt = new DataTable();
        ClienteDB clienteDB = new ClienteDB();
        Cliente clientes = new Cliente();

        private void HabilitarControles()
        {
            identidadtxt.Enabled = true;
            Nombretxt.Enabled = true;
            telefonotxt.Enabled = true;
            correotxt.Enabled = true;
            direcciontxt.Enabled = true;
            EstaActivocheckBox.Enabled = true;
            guardarbt.Enabled = true;
            Cancelarbt.Enabled = true;
            Nuevobt.Enabled = false;
            Modificarbt.Enabled = false;
            FechaNacimientodateTimePicker.Enabled = true;

        }

        private void DeshabilitarControles()
        {
            identidadtxt.Enabled = false;
            Nombretxt.Enabled = false;
            telefonotxt.Enabled = false;
            correotxt.Enabled = false;
            direcciontxt.Enabled = false;
            EstaActivocheckBox.Enabled = false;
            guardarbt.Enabled = false;
            Cancelarbt.Enabled = false;
            Nuevobt.Enabled = true;
            Modificarbt.Enabled = true;
            FechaNacimientodateTimePicker.Enabled = false;
        }

        private void LimpiarControles()
        {
            identidadtxt.Clear();
            Nombretxt.Clear();
            telefonotxt.Clear();
            correotxt.Clear();
            direcciontxt.Clear();
            FechaNacimientodateTimePicker.CustomFormat = " ";
            fechanacimientotxt.Clear();
            EstaActivocheckBox.Checked = false;
        }

        private void Nuevobt_Click(object sender, EventArgs e)
        {
            identidadtxt.Focus();
            HabilitarControles();
            tipoOperacion = "Nuevo";
        }

        private void Cancelarbt_Click(object sender, EventArgs e)
        {
            DeshabilitarControles();
            LimpiarControles();
        }

        private void TraerClientes()
        {
            ClientesDGV.DataSource = clienteDB.DevolverClientes();
        }

        private void guardarbt_Click(object sender, EventArgs e)
        {
            if (tipoOperacion == "Nuevo")
            {
                if (string.IsNullOrEmpty(identidadtxt.Text))
                {
                    errorProvider1.SetError(identidadtxt, "Ingrese una Identidad");
                    identidadtxt.Focus();
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
                if (string.IsNullOrEmpty(telefonotxt.Text))
                {
                    errorProvider1.SetError(telefonotxt, "Ingrese un Telefono");
                    telefonotxt.Focus();
                    return;
                }
                errorProvider1.Clear();
                if (string.IsNullOrEmpty(direcciontxt.Text))
                {
                    errorProvider1.SetError(direcciontxt, "Ingrese una Direccion");
                    direcciontxt.Focus();
                    return;
                }
                errorProvider1.Clear();

                clientes.Identidad = identidadtxt.Text;
                clientes.Nombre = Nombretxt.Text;
                clientes.Telefono = telefonotxt.Text;
                clientes.Correo = correotxt.Text;
                clientes.Direccion = direcciontxt.Text;
                clientes.FechaNacimiento = FechaNacimientodateTimePicker.Value.Date;
                clientes.EstaActivo = EstaActivocheckBox.Checked;

                //Insertar en la base de datos

                bool inserto = clienteDB.Insertar(clientes);

                if (inserto)
                {
                    LimpiarControles();
                    DeshabilitarControles();
                    TraerClientes();
                    MessageBox.Show("Registro guardado");

                }
                else
                {
                    MessageBox.Show("No se pudo guardar el registro");
                }


            }
            else if (tipoOperacion == "Modificar")
            {
                clientes.Identidad = identidadtxt.Text;
                clientes.Nombre = Nombretxt.Text;
                clientes.Telefono = telefonotxt.Text;
                clientes.Correo = correotxt.Text;
                clientes.Direccion = direcciontxt.Text;
                clientes.FechaNacimiento = FechaNacimientodateTimePicker.Value;
                clientes.EstaActivo = EstaActivocheckBox.Checked;

                bool modifico = clienteDB.Editar(clientes);
                if (modifico)
                {
                    LimpiarControles();
                    DeshabilitarControles();
                    TraerClientes();
                    MessageBox.Show("Registro actualizado correctamente");
                }
                else
                {
                    MessageBox.Show("No se pudo actualizar el registro");
                }

            }
        }

        private void Eliminarbt_Click(object sender, EventArgs e)
        {
            if (ClientesDGV.SelectedRows.Count > 0)
            {

                DialogResult resultado = MessageBox.Show("Esta seguro de eliminar el registro", "Advertencia", MessageBoxButtons.YesNo);
                if (resultado == DialogResult.Yes)
                {
                    bool elimino = clienteDB.Eliminar(ClientesDGV.CurrentRow.Cells["Identidad"].Value.ToString());

                    if (elimino)
                    {
                        LimpiarControles();
                        DeshabilitarControles();
                        TraerClientes();
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

        private void Modificarbt_Click(object sender, EventArgs e)
        {
            tipoOperacion = "Modificar";
            if (ClientesDGV.SelectedRows.Count > 0)
            {
                fechanacimientotxt.Enabled = true;
                identidadtxt.Text = ClientesDGV.CurrentRow.Cells["Identidad"].Value.ToString();
                Nombretxt.Text = ClientesDGV.CurrentRow.Cells["Nombre"].Value.ToString();
                telefonotxt.Text = ClientesDGV.CurrentRow.Cells["Telefono"].Value.ToString();
                correotxt.Text = ClientesDGV.CurrentRow.Cells["Correo"].Value.ToString();
                direcciontxt.Text = ClientesDGV.CurrentRow.Cells["Direccion"].Value.ToString();
                FechaNacimientodateTimePicker.Value = Convert.ToDateTime(ClientesDGV.CurrentRow.Cells["FechaNacimiento"].Value);
                EstaActivocheckBox.Checked = Convert.ToBoolean(ClientesDGV.CurrentRow.Cells["EstaActivo"].Value);
                HabilitarControles();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un registro");
            }
        }

        private void ClientesForm_Load(object sender, EventArgs e)
        {
            TraerClientes();
        }

        private void busquedatxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void busquedatxt_KeyUp(object sender, KeyEventArgs e)
        {
            if (string.IsNullOrEmpty(busquedatxt.Text))
            {
                TraerClientes();
            }
            else
            {
                ClientesDGV.DataSource = clienteDB.DevolverClientesPorIdentidad(busquedatxt.Text);
            }
        }

        private void FechaNacimientodateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            FechaNacimientodateTimePicker.CustomFormat = "dd/MM/yyyy";
        }

        private void FechaNacimientodateTimePicker_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Back) || (e.KeyCode == Keys.Delete))
            {
                FechaNacimientodateTimePicker.CustomFormat = " ";
            }
        }
    }
}
