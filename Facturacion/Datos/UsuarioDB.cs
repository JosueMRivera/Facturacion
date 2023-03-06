using Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Datos
{
    public class UsuarioDB
    {
        string cadena = "server=localhost; user=root; database=Factura; password=Fersopoles51";

        public Usuario Autenticar(Login login)
        {
            Usuario user = null;
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append("SELECT * FROM usuario WHERE CodigoUsuario = @CodigoUsuario AND Password = @Password");

                using (MySqlConnection _Conexion = new MySqlConnection(cadena))
                {
                    _Conexion.Open();
                    using (MySqlCommand comando = new MySqlCommand(sql.ToString(), _Conexion ))
                    {
                        comando.CommandType = CommandType.Text;
                        comando.Parameters.Add("@CodigoUsuario", MySqlDbType.VarChar, 50).Value = login.CodigoUsuario;
                        comando.Parameters.Add("@Password", MySqlDbType.VarChar, 50).Value = login.Contraseña;

                        MySqlDataReader dr = comando.ExecuteReader();
                        if (dr.Read())
                        {
                            user = new Usuario();

                            user.CodigoUsuario = dr["CodigoUsuario"].ToString();
                            user.Nombre = dr["Nombre"].ToString();
                            user.Contraseña = dr["Password"].ToString();
                            user.Correo = dr["Correo"].ToString();
                            user.Rol = dr["Rol"].ToString();
                            user.FechaCreacion = (DateTime)(dr["FechaCreacion"]);
                            user.EstaActivo = Convert.ToBoolean(dr["EstadoActivo"]);
                            if (dr["Foto"].GetType() != typeof(DBNull))
                            {
                                user.Foto = (byte[])(dr["Foto"]);
                            }
                            
                        }

                    }
                }
            }
            catch (System.Exception ex)
            {

            }

            return user;
        }

        public bool Insertar(Usuario user)
        {
            bool inserto = false;
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append("INSERT INTO usuario VALUES");
                sql.Append(" (@CodigoUsuario, @Nombre, @Password, @Correo, @Rol, @Foto, @FechaCreacion, @EstadoActivo); ");

                using (MySqlConnection _Conexion = new MySqlConnection(cadena))
                {
                    _Conexion.Open();
                    using (MySqlCommand comando = new MySqlCommand(sql.ToString(), _Conexion))
                    {
                        comando.CommandType = CommandType.Text;
                        comando.Parameters.Add("@CodigoUsuario", MySqlDbType.VarChar, 50).Value = user.CodigoUsuario;
                        comando.Parameters.Add("@Nombre", MySqlDbType.VarChar, 50).Value = user.Nombre;
                        comando.Parameters.Add("@Password", MySqlDbType.VarChar, 80).Value = user.Contraseña;
                        comando.Parameters.Add("@Correo", MySqlDbType.VarChar, 45).Value = user.Correo;
                        comando.Parameters.Add("@Rol", MySqlDbType.VarChar, 20).Value = user.Rol;
                        comando.Parameters.Add("@Foto", MySqlDbType.LongBlob).Value = user.Foto;
                        comando.Parameters.Add("@FechaCreacion", MySqlDbType.DateTime).Value = user.FechaCreacion;
                        comando.Parameters.Add("@EstadoActivo", MySqlDbType.Bit).Value = user.EstaActivo;
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

        public bool Editar(Usuario user)
        {
            bool Edito = false;
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append("UPDATE usuario SET ");
                sql.Append(" Nombre = @Nombre, Password = @Password, Correo = @Correo, Rol = @Rol, Foto = @Foto, EstadoActivo = @EstadoActivo ");
                sql.Append(" WHERE CodigoUsuario = @CodigoUsuario; ");

                using (MySqlConnection _Conexion = new MySqlConnection(cadena))
                {
                    _Conexion.Open();
                    using (MySqlCommand comando = new MySqlCommand(sql.ToString(), _Conexion))
                    {
                        comando.CommandType = CommandType.Text;
                        comando.Parameters.Add("@CodigoUsuario", MySqlDbType.VarChar, 50).Value = user.CodigoUsuario;
                        comando.Parameters.Add("@Nombre", MySqlDbType.VarChar, 50).Value = user.Nombre;
                        comando.Parameters.Add("@Password", MySqlDbType.VarChar, 80).Value = user.Contraseña;
                        comando.Parameters.Add("@Correo", MySqlDbType.VarChar, 45).Value = user.Correo;
                        comando.Parameters.Add("@Rol", MySqlDbType.VarChar, 20).Value = user.Rol;
                        comando.Parameters.Add("@Foto", MySqlDbType.LongBlob).Value = user.Foto;
                        comando.Parameters.Add("@EstadoActivo", MySqlDbType.Bit).Value = user.EstaActivo;
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

        public bool Eliminar(string codigoUsuario)
        {
            bool Elimino = false;
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append("DELETE FROM usuario ");
                sql.Append(" WHERE CodigoUsuario = @CodigoUsuario; ");

                using (MySqlConnection _Conexion = new MySqlConnection(cadena))
                {
                    _Conexion.Open();
                    using (MySqlCommand comando = new MySqlCommand(sql.ToString(), _Conexion))
                    {
                        comando.CommandType = CommandType.Text;
                        comando.Parameters.Add("@CodigoUsuario", MySqlDbType.VarChar, 50).Value = codigoUsuario;
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

        public DataTable DevolverUsuarios()
        {
            DataTable dt = new DataTable();
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append("SELECT * FROM usuario ");
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

        public byte[] DevolverFoto(string codigoUsuario)
        {
            byte[] foto = new byte[0];
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append("SELECT Foto FROM usuario WHERE CodigoUsuario = @CodigoUsuario");
                using (MySqlConnection _Conexion = new MySqlConnection(cadena))
                {
                    _Conexion.Open();
                    using (MySqlCommand comando = new MySqlCommand(sql.ToString(), _Conexion))
                    {
                        comando.CommandType = CommandType.Text;
                        comando.Parameters.Add("@CodigoUsuario", MySqlDbType.VarChar, 50).Value = codigoUsuario;
                        MySqlDataReader dr = comando.ExecuteReader();
                        if (dr.Read())
                        {
                            foto = (byte[])dr["Foto"];
                        }
                    }
                }
            }
            catch (System.Exception ex)
            {
            }
            return foto;

        }

    }
}
