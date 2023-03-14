using Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class ClienteDB
    {
        string cadena = "server=localhost; user=root; database=Factura; password=Fersopoles51";

        public bool Insertar(Cliente clientes)
        {
            bool inserto = false;
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append("INSERT INTO cliente VALUES");
                sql.Append(" (@Identidad, @Nombre, @Telefono, @Correo, @Direccion, @FechaNacimiento, @EstaActivo); ");

                using (MySqlConnection _Conexion = new MySqlConnection(cadena))
                {
                    _Conexion.Open();
                    using (MySqlCommand comando = new MySqlCommand(sql.ToString(), _Conexion))
                    {
                        comando.CommandType = CommandType.Text;
                        comando.Parameters.Add("@Identidad", MySqlDbType.VarChar, 25).Value = clientes.Identidad;
                        comando.Parameters.Add("@Nombre", MySqlDbType.VarChar, 50).Value = clientes.Nombre;
                        comando.Parameters.Add("@Telefono", MySqlDbType.VarChar, 15).Value = clientes.Telefono;
                        comando.Parameters.Add("@Correo", MySqlDbType.VarChar, 45).Value = clientes.Correo;
                        comando.Parameters.Add("@Direccion", MySqlDbType.VarChar, 100).Value = clientes.Direccion;
                        comando.Parameters.Add("@FechaNacimiento", MySqlDbType.DateTime).Value = clientes.FechaNacimiento;
                        comando.Parameters.Add("@EstaActivo", MySqlDbType.Bit).Value = clientes.EstaActivo;
                        comando.ExecuteNonQuery();
                        inserto = true;

                    }
                }
            }
            catch (System.Exception ex)
            {
            }

            return inserto;
        }

        public bool Editar(Cliente clientes)
        {
            bool Edito = false;
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append("UPDATE cliente SET ");
                sql.Append(" Nombre = @Nombre, Telefono = @Telefono, Correo = @Correo, Direccion = @Direccion, FechaNacimiento = @FechaNacimiento, EstaActivo = @EstaActivo ");
                sql.Append(" WHERE Identidad = @Identidad; ");

                using (MySqlConnection _Conexion = new MySqlConnection(cadena))
                {
                    _Conexion.Open();
                    using (MySqlCommand comando = new MySqlCommand(sql.ToString(), _Conexion))
                    {
                        comando.CommandType = CommandType.Text;
                        comando.Parameters.Add("@Identidad", MySqlDbType.VarChar, 25).Value = clientes.Identidad;
                        comando.Parameters.Add("@Nombre", MySqlDbType.VarChar, 50).Value = clientes.Nombre;
                        comando.Parameters.Add("@Telefono", MySqlDbType.VarChar, 15).Value = clientes.Telefono;
                        comando.Parameters.Add("@Correo", MySqlDbType.VarChar, 45).Value = clientes.Correo;
                        comando.Parameters.Add("@Direccion", MySqlDbType.VarChar, 100).Value = clientes.Direccion;
                        comando.Parameters.Add("@FechaNacimiento", MySqlDbType.DateTime).Value = clientes.FechaNacimiento;
                        comando.Parameters.Add("@EstaActivo", MySqlDbType.Bit).Value = clientes.EstaActivo;
                        comando.ExecuteNonQuery();
                        Edito = true;

                    }
                }
            }
            catch (System.Exception ex)
            {
            }

            return Edito;
        }

        public bool Eliminar(string identidad)
        {
            bool Elimino = false;
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append("DELETE FROM cliente ");
                sql.Append(" WHERE Identidad = @Identidad; ");

                using (MySqlConnection _Conexion = new MySqlConnection(cadena))
                {
                    _Conexion.Open();
                    using (MySqlCommand comando = new MySqlCommand(sql.ToString(), _Conexion))
                    {
                        comando.CommandType = CommandType.Text;
                        comando.Parameters.Add("@Identidad", MySqlDbType.VarChar, 50).Value = identidad;
                        comando.ExecuteNonQuery();
                        Elimino = true;

                    }
                }
            }
            catch (System.Exception ex)
            {
            }

            return Elimino;
        }

        public Cliente DevolverClientesPorIdentidad(string identidad)
        {
            Cliente cliente = null;
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append("SELECT * FROM cliente WHERE Identidad = @Identidad ");
                using (MySqlConnection _Conexion = new MySqlConnection(cadena))
                {
                    _Conexion.Open();
                    using (MySqlCommand comando = new MySqlCommand(sql.ToString(), _Conexion))
                    {
                        comando.CommandType = CommandType.Text;
                        comando.Parameters.Add("@Identidad", MySqlDbType.VarChar, 25).Value = identidad;
                        MySqlDataReader dr = comando.ExecuteReader();
                        if (dr.Read())
                        {
                            cliente = new Cliente();

                            cliente.Identidad = identidad;
                            cliente.Nombre = dr["Nombre"].ToString();
                            cliente.Telefono = dr["Telefono"].ToString();
                            cliente.Correo = dr["Correo"].ToString();
                            cliente.Direccion = dr["Direccion"].ToString();
                            cliente.FechaNacimiento = Convert.ToDateTime(dr["FechaNacimiento"]);
                            cliente.EstaActivo = Convert.ToBoolean(dr["EstaActivo"]);
                        }
                    }
                }
            }
            catch (System.Exception ex)
            {
            }

            return cliente;
        }

        public DataTable DevolverClientes()
        {
            DataTable dt = new DataTable();
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append("SELECT * FROM cliente ");
                using (MySqlConnection _Conexion = new MySqlConnection(cadena))
                {
                    _Conexion.Open();
                    using (MySqlCommand comando = new MySqlCommand(sql.ToString(), _Conexion))
                    {
                        comando.CommandType = CommandType.Text;
                        MySqlDataReader dr = comando.ExecuteReader();
                        dt.Load(dr);
                    }
                }
            }
            catch (System.Exception ex)
            {
            }

            return dt;
        }


    }
}
