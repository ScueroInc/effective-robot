using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;

namespace Data.Implementation
{
    public class UsuarioRepository : IUsuarioRepository
    {
        public bool Delete(int? id)
        {
            bool rpta = false;
            try
            {
                var con = new SqlConnection(ConfigurationManager.ConnectionStrings["BD_Financiamiento"].ToString());
                con.Open();
                var cmd = new SqlCommand("delete from Usuario where IDUsuario ='" + id + "'", con);
                cmd.ExecuteNonQuery();
                rpta = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return rpta;
        }

        public List<Usuario> FindAll()
        {
            List<Usuario> Lista_usuarios = new List<Usuario>();

            try
            {
                using (var con = new SqlConnection(ConfigurationManager.ConnectionStrings["BD_Financiamiento"].ToString()))
                {
                    con.Open();
                    var query = new SqlCommand("select u.IDUsuario as CodigoUsuario, u.Nombre, u.Apellidos,u.Email, u.Nickname, u.Password, u.Celular, tc.IDTipoCuenta as CodigoTipoCuenta, tc.NTipoCuenta, tc.MTipoCuenta, tc.TiempoCuenta " +
                        "from Usuario u, TipoCuenta tc where u.IDTipoCuenta=tc.IDTipoCuenta", con);
                    using (var dr = query.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            var TipoCuenta = new TipoCuenta();
                            var usuario = new Usuario();

                            usuario.IDUsuario = Convert.ToInt32(dr["IDUsuario"]);
                            usuario.Nombre = dr["Nombre"].ToString();
                            usuario.Apellidos = dr["Apellidos"].ToString();
                            usuario.Email = dr["Email"].ToString();
                            usuario.Nickname = dr["Nickname"].ToString();
                            usuario.Password = dr["Password"].ToString();
                            usuario.Celular = Convert.ToInt32(dr["Celular"]);

                            TipoCuenta.IDTipoCuenta = Convert.ToInt32(dr["IDTipoCuenta"]);
                            TipoCuenta.NTipoCuenta = dr["NTipoCuenta"].ToString();
                            TipoCuenta.MTipoCuenta = Convert.ToDecimal(dr["MTipoCuenta"]);
                            TipoCuenta.TiempoCuenta = Convert.ToInt32(dr["TiempoCuenta"]);
                            usuario.IDTipoCuenta = TipoCuenta;

                            Lista_usuarios.Add(usuario);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return Lista_usuarios;
        }

        public Usuario FindByID(int? id)
        {
            Usuario usuario_temp = null;
            using (var con = new SqlConnection(ConfigurationManager.ConnectionStrings["BD_Financiamiento"].ToString()))
            {
                con.Open();
                var query = new SqlCommand("select u.IDUsuario, u.Nombre, u.Apellidos,u.Email, u.Nickname, u.Password, u.Celular, u.IDTipoCuenta from Usuario u where u.IDUsuario = '" + id + "'", con);
                using (var dr = query.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        usuario_temp = new Usuario();
                        var TipoCuenta = new TipoCuenta();

                        usuario_temp.IDUsuario = Convert.ToInt32(dr["IDUsuario"]);
                        usuario_temp.Nombre = dr["Nombre"].ToString();
                        usuario_temp.Apellidos = dr["Apellidos"].ToString();
                        usuario_temp.Email = dr["Email"].ToString();
                        usuario_temp.Nickname = dr["Nickname"].ToString();
                        usuario_temp.Password = dr["Password"].ToString();
                        usuario_temp.Celular = Convert.ToInt32(dr["Celular"]);

                        TipoCuenta.IDTipoCuenta = Convert.ToInt32(dr["IDTipoCuenta"]);
                        TipoCuenta.NTipoCuenta = dr["NTipoCuenta"].ToString();
                        TipoCuenta.MTipoCuenta = Convert.ToInt32(dr["MTipoCuenta"]);
                        TipoCuenta.TiempoCuenta = Convert.ToInt32(dr["TiempoCuenta"]);
                        usuario_temp.IDTipoCuenta = TipoCuenta;
                    }
                }
            }
            return usuario_temp;
        }

        public bool Insert(Usuario t)
        {
            bool rpta = false;
            try
            {
                using (var con = new SqlConnection(ConfigurationManager.ConnectionStrings["BD_Financiamiento"].ToString()))
                {
                    con.Open();

                    var query = new SqlCommand("insert into Usuario values (@Nombre, @Apellidos, @Email, @Nickname, @Password, @Celular, @IDTipoCuenta)", con);

                    query.Parameters.AddWithValue("@Nombre", t.Nombre);
                    query.Parameters.AddWithValue("@Apellidos", t.Apellidos);
                    query.Parameters.AddWithValue("@Email", t.Email);
                    query.Parameters.AddWithValue("@Nickname", t.Nickname);
                    query.Parameters.AddWithValue("@Password", t.Password);
                    query.Parameters.AddWithValue("@Celular", t.Celular);
                    query.Parameters.AddWithValue("@IDTipoCuenta", t.IDTipoCuenta.IDTipoCuenta);

                    query.ExecuteNonQuery();

                    rpta = true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return rpta;
        }

        public bool Update(Usuario t)
        {
            bool rpta = false;
            try
            {
                using (var con = new SqlConnection(ConfigurationManager.ConnectionStrings["BD_Financiamiento"].ToString()))
                {
                    con.Open();

                    var query = new SqlCommand("update Usuario set Nombre=@Nombre, Apellidos=@Apellidos, Email=@Email, Nickname=@Nickname, Password=@Password, Celular=@Celular, IDTipoCuenta=@IDTipoCuenta where IDUsuario='" + t.IDUsuario + "'", con);
                    query.Parameters.AddWithValue("@Nombre", t.Nombre);
                    query.Parameters.AddWithValue("@Apellidos", t.Apellidos);
                    query.Parameters.AddWithValue("@Email", t.Email);
                    query.Parameters.AddWithValue("@Nickname", t.Nickname);
                    query.Parameters.AddWithValue("@Password", t.Password);
                    query.Parameters.AddWithValue("@Celular", t.Celular);
                    query.Parameters.AddWithValue("@IDTipoCuenta", t.IDTipoCuenta);

                    query.ExecuteNonQuery();

                    rpta = true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return rpta;
        }
    }
}
