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
    public class GastoRepository : IGastoRepository
    {
        public bool Delete(int? id)
        {
            bool rpta = false;
            try
            {
                var con = new SqlConnection(ConfigurationManager.ConnectionStrings["BD_Financiamiento"].ToString());
                con.Open();
                var cmd = new SqlCommand("delete from Gasto where IDGasto ='" + id + "'", con);
                cmd.ExecuteNonQuery();
                rpta = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return rpta;
        }

        public List<Gasto> FindAll()
        {
            var Gastos = new List<Gasto>();
            try
            {
                using (var con = new SqlConnection(ConfigurationManager.ConnectionStrings["BD_Financiamiento"].ToString()))
                {
                    con.Open();
                    var query = new SqlCommand("select g.IDGasto as CodigoGasto, t.NTransaccion,t.MontoTransaccion,t.FechaTransaccion" +
                        "cg.IDCategoria_Gasto as CodigoCategoriaG,cg.NCategoria_Gasto from Gasto g, Transaccion t, Categoria_Gasto cg" +
                        "where g.IDGasto=t.IDTransaccion and g.IDCategoria_Gasto=cg.IDCategoria_Gasto", con);

                    using (var dr = query.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            var transaccion = new Gasto();
                            var categoria_gasto = new Categoria_Gasto();
                            transaccion.IDTransaccion = Convert.ToInt32(dr["IDTransaccion"]);
                            transaccion.NTransaccion = (dr["NTransaccion"]).ToString();
                            transaccion.MontoTransaccion = Convert.ToDecimal(dr["MontoTransaccion"]);
                            transaccion.FechaTransaccion = Convert.ToDateTime(dr["FechaTransaccion"]);

                            categoria_gasto.IDCategoria_Gasto = Convert.ToInt32(dr["IDCategoria_Gasto"]);
                            categoria_gasto.NCategoria_Gasto = (dr["NCategoria_Gasto"]).ToString();
                            transaccion.IDCategoria_Gasto = categoria_gasto;

                            Gastos.Add(transaccion);
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return Gastos;
        }

        public Gasto FindByID(int? id)
        {

            Gasto gasto = null;
           
            try
            {
                using (var con = new SqlConnection(ConfigurationManager.ConnectionStrings["BD_Financiamiento"].ToString()))
                {
                    con.Open();
                    var query = new SqlCommand("select g.IDGasto as CodigoGasto, t.NTransaccion,t.MontoTransaccion,t.FechaTransaccion" +
                        "cg.IDCategoria_Gasto as CodigoCategoriaG,cg.NCategoria_Gasto from Gasto g, Transaccion t, Categoria_Gasto cg" +
                        "where g.IDGasto=t.IDTransaccion and g.IDCategoria_Gasto=cg.IDCategoria_Gasto and g.IDGasto='" + id + "'", con);
                    using (var dr = query.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            gasto = new Gasto();
                            var categoria_gasto = new Categoria_Gasto();
                            gasto.IDTransaccion = Convert.ToInt32(dr["IDTransaccion"]);
                            gasto.NTransaccion = (dr["NTransaccion"]).ToString();
                            gasto.MontoTransaccion = Convert.ToDecimal(dr["MontoTransaccion"]);
                            gasto.FechaTransaccion = Convert.ToDateTime(dr["FechaTransaccion"]);

                            categoria_gasto.IDCategoria_Gasto = Convert.ToInt32(dr["IDCategoria_Gasto"]);
                            categoria_gasto.NCategoria_Gasto = (dr["NCategoria_Gasto"]).ToString();
                            gasto.IDCategoria_Gasto = categoria_gasto;


                        }
                    }

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return gasto;

        }

        public bool Insert(Gasto t)
        {
            bool rpta = false;

            try
            {
                using (var con = new SqlConnection(ConfigurationManager.ConnectionStrings["BD_Financiamiento"].ToString()))
                {
                    con.Open();
                    var query = new SqlCommand("insert into Gasto values (@IDTransaccion,@IDCategoria_Gasto)", con);
                    query.Parameters.AddWithValue("@IDTransaccion", t.IDTransaccion);
                    query.Parameters.AddWithValue("@IDCategoria_Gasto", t.IDCategoria_Gasto.IDCategoria_Gasto);

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

        public bool Update(Gasto t)
        {
            bool rpta = false;

            try
            {
                using (var con = new SqlConnection(ConfigurationManager.ConnectionStrings["BD_Financiamiento"].ToString()))
                {
                    con.Open();
                    var query = new SqlCommand("update Gasto set IDGasto=@IDTransaccion,IDCategoria_Gasto=@IDCategoria_Gasto  where IDGasto='" + t.IDTransaccion + "'", con);
                    query.Parameters.AddWithValue("@IDTransaccion", t.IDTransaccion);
                    query.Parameters.AddWithValue("@IDCategoria_Gasto", t.IDCategoria_Gasto.IDCategoria_Gasto);
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
