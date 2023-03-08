using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using MySql.Data.MySqlClient;
using System.Data;

namespace Datos
{
    public class ProductoDB
    {
        string cadena = "server=localhost; user=root; database=Factura; password=Fersopoles51";

        public bool Insertar(Productos producto)
        {
            bool inserto = false;
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append("INSERT INTO producto VALUES");
                sql.Append(" (@Codigo, @Descripcion, @Existencia, @Precio, @Imagen, @EstaActivo); ");

                using (MySqlConnection _Conexion = new MySqlConnection(cadena))
                {
                    _Conexion.Open();
                    using (MySqlCommand comando = new MySqlCommand(sql.ToString(), _Conexion))
                    {
                        comando.CommandType = CommandType.Text;
                        comando.Parameters.Add("@Codigo", MySqlDbType.VarChar, 80).Value = producto.Codigo;
                        comando.Parameters.Add("@Descripcion", MySqlDbType.VarChar, 200).Value = producto.Descripcion;
                        comando.Parameters.Add("@Existencia", MySqlDbType.Int32).Value = producto.Existencia;
                        comando.Parameters.Add("@Precio", MySqlDbType.Decimal).Value = producto.Precio;
                        comando.Parameters.Add("@Imagen", MySqlDbType.LongBlob).Value = producto.Imagen;
                        comando.Parameters.Add("@EstaActivo", MySqlDbType.Bit).Value = producto.EstaActivo;
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

        public bool Editar(Productos producto)
        {
            bool edito = false;
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" UPDATE producto SET ");
                sql.Append(" Descripcion = @Descripcion, Existencia = @Existencia, Precio = @Precio, Imagen = @Imagen, EstaActivo = @EstaActivo ");
                sql.Append(" WHERE Codigo = @Codigo; ");

                using (MySqlConnection _conexion = new MySqlConnection(cadena))
                {
                    _conexion.Open();
                    using (MySqlCommand comando = new MySqlCommand(sql.ToString(), _conexion))
                    {
                        comando.CommandType = CommandType.Text;
                        comando.Parameters.Add("@Codigo", MySqlDbType.VarChar, 80).Value = producto.Codigo;
                        comando.Parameters.Add("@Descripcion", MySqlDbType.VarChar, 200).Value = producto.Descripcion;
                        comando.Parameters.Add("@Existencia", MySqlDbType.Int32).Value = producto.Existencia;
                        comando.Parameters.Add("@Precio", MySqlDbType.Decimal).Value = producto.Precio;
                        comando.Parameters.Add("@Imagen", MySqlDbType.LongBlob).Value = producto.Imagen;
                        comando.Parameters.Add("@EstaActivo", MySqlDbType.Bit).Value = producto.EstaActivo;
                        comando.ExecuteNonQuery();
                        edito = true;
                    }
                }
            }
            catch (System.Exception ex)
            {
            }
            return edito;
        }

        public bool Eliminar(string codigo)
        {
            bool Elimino = false;
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append("DELETE FROM producto ");
                sql.Append(" WHERE Codigo = @Codigo; ");

                using (MySqlConnection _Conexion = new MySqlConnection(cadena))
                {
                    _Conexion.Open();
                    using (MySqlCommand comando = new MySqlCommand(sql.ToString(), _Conexion))
                    {
                        comando.CommandType = CommandType.Text;
                        comando.Parameters.Add("@Codigo", MySqlDbType.VarChar, 80).Value = codigo;
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

        public DataTable DevolverProductos()
        {
            DataTable dt = new DataTable();
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append("SELECT * FROM producto ");
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

        public byte[] DevolverFoto(string codigo)
        {
            byte[] Imagen = new byte[0];
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append("SELECT Imagen FROM producto WHERE Codigo = @Codigo");
                using (MySqlConnection _Conexion = new MySqlConnection(cadena))
                {
                    _Conexion.Open();
                    using (MySqlCommand comando = new MySqlCommand(sql.ToString(), _Conexion))
                    {
                        comando.CommandType = CommandType.Text;
                        comando.Parameters.Add("@Codigo", MySqlDbType.VarChar, 80).Value = codigo;
                        MySqlDataReader dr = comando.ExecuteReader();
                        if (dr.Read())
                        {
                            Imagen = (byte[])dr["Imagen"];
                        }
                    }
                }
            }
            catch (System.Exception ex)
            {
            }
            return Imagen;

        }

    }
}
