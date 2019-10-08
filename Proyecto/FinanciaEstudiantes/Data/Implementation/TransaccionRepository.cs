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
    public class TransaccionRepository : ITransaccionRepository
    {
        public bool Delete(int? id)
        {
            bool rpta = false;
            try
            {
                var con = new SqlConnection(ConfigurationManager.ConnectionStrings["BD_Financiamiento"].ToString());
                con.Open();
                var cmd = new SqlCommand("delete from Transaccion where IDTransaccion ='" + id + "'", con);
                cmd.ExecuteNonQuery();
                rpta = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return rpta;
        }

        public List<Transaccion> FindAll()
        {
            var Lista_Transacciones = new List<Transaccion>();

            try
            {
                using (var con = new SqlConnection(ConfigurationManager.ConnectionStrings["BD_Financiamiento"].ToString()))
                {
                    con.Open();
                    var query = new SqlCommand("select t.IDTransaccion as CodigoTransaccion,t.NTransaccion,t.MontoTransaccion,t.FechaTransaccion," +
                        "d.IDDivisa as CodigoDivisa,d.NDivisa, m.IDMes as CodigoMes,m.NMes, u.IDUsuario as CodigoUsuario,u.Nombre,u.Apellidos,u.Email,u.Nickname,u.Celular," +
                        "f.IDFrecuencia as CodigoFrecuencia,f.NFrecuencia,f.TDescripcion" +
                        "from Transaccion t, Divisa d, Mes m, Usuario u, Frecuencia f " +
                        "where t.IDDivisa=d.IDDivisa and t.IDMes=m.IDMes and t.IDUsuario=u.IDUsuario and t.IDFrecuencia=f.IDFrecuencia", con);//REVISAR 
                    using (var dr = query.ExecuteReader())
                    {
                        while(dr.Read())
                        {
                            var transaccion = new Transaccion();
                            var divisa = new Divisa();
                            var mes = new Mes();
                            var usuario = new Usuario();
                            var frecuencia = new Frecuencia();

                            transaccion.IDTransaccion = Convert.ToInt32(dr["IDTransaccion"]);
                            transaccion.NTransaccion = (dr["NTransaccion"]).ToString();
                            transaccion.MontoTransaccion = Convert.ToDecimal(dr["MontoTransaccion"]);
                            transaccion.FechaTransaccion = Convert.ToDateTime(dr["FechaTransaccion"]);

                            divisa.IDDivisa = Convert.ToInt32(dr["IDDivisa"]);
                            divisa.NDivisa = (dr["NDivisa"]).ToString();
                            transaccion.IDDivisa = divisa;

                            mes.IDMes = Convert.ToInt32(dr["IDMes"]);
                            mes.NMes = (dr["NMes"]).ToString();
                            transaccion.IDMes = mes;

                            usuario.IDUsuario = Convert.ToInt32(dr["IDUsuario"]);
                            usuario.Nombre = (dr["Nombre"]).ToString();
                            usuario.Apellidos = (dr["Apellidos"]).ToString();
                            usuario.Email = (dr["Email"]).ToString();
                            usuario.Nickname = (dr["Nickname"]).ToString();
                            usuario.Celular = Convert.ToInt32(dr["Celular"]);
                            transaccion.IDUsuario = usuario;

                            frecuencia.IDFrecuencia = Convert.ToInt32(dr["IDFrecuencia"]);
                            frecuencia.NFrecuencia = (dr["NFrecuencia"]).ToString();
                            frecuencia.TDescripcion = (dr["TDescripcion"]).ToString();
                            transaccion.IDFrecuencia = frecuencia;

                            Lista_Transacciones.Add(transaccion);
                            
                        }
                    }
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }

            return Lista_Transacciones;
        }

        public Transaccion FindByID(int? id)
        {
            throw new NotImplementedException();
        }

        public bool Insert(Transaccion t)
        {
            bool rpta = false;

            try
            {
                using (var con = new SqlConnection(ConfigurationManager.ConnectionStrings["BD_Financiamiento"].ToString()))
                {
                    con.Open();

                    var query = new SqlCommand("insert into Transaccion values (@NTransaccion,@MontoTransaccion,@FechaTransaccion,@IDDivisa,@IDMes,@IDUsuario,@IDFrecuencia)", con);
                    query.Parameters.AddWithValue("@NTransaccion", t.NTransaccion);
                    query.Parameters.AddWithValue("@MonotoTransaccion", t.MontoTransaccion);
                    query.Parameters.AddWithValue("@FechaTransaccion", t.FechaTransaccion);
                    query.Parameters.AddWithValue("@IDDivisa", t.IDDivisa.IDDivisa);
                    query.Parameters.AddWithValue("@IDMes", t.IDMes.IDMes);
                    query.Parameters.AddWithValue("@IDUsuario", t.IDUsuario.IDUsuario);
                    query.Parameters.AddWithValue("@IDFrecuencia", t.IDFrecuencia.IDFrecuencia);

                    query.ExecuteNonQuery();
                    rpta = true;
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }

            return rpta;
        }

        public bool Update(Transaccion t)
        {
            bool rpta = false;

            try
            {
                using (var con = new SqlConnection(ConfigurationManager.ConnectionStrings["BD_Financiamiento"].ToString()))
                {
                    con.Open();
                    var query = new SqlCommand("update Transaccion set NTransaccion=@NTransaccion,MontoTransaccion=@MontoTransaccion,FechaTransaccion=@FechaTransaccion,IDDivisa=@IDDivisa,IDMes=@IDMes,IDUsuario=@IDUsuario,IDFrecuencia=@IDFrecuencia  where IDTransaccion='" + t.IDTransaccion + "'", con);
                    query.Parameters.AddWithValue("@Ntransaccion", t.NTransaccion);
                    query.Parameters.AddWithValue("@MontoTransaccion", t.MontoTransaccion);
                    query.Parameters.AddWithValue("@FechaTransaccion", t.FechaTransaccion);
                    query.Parameters.AddWithValue("@IDDivisa", t.IDDivisa.IDDivisa);
                    query.Parameters.AddWithValue("@IDMes", t.IDMes.IDMes);
                    query.Parameters.AddWithValue("@IDUsuario", t.IDUsuario.IDUsuario);
                    query.Parameters.AddWithValue("@IDFrecuencia", t.IDFrecuencia.IDFrecuencia);
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
