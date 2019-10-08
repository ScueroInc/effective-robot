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
    public class IngresoRepository : IIngresoRepository
    {
        public bool Delete(int? id)
        {
            bool rpta = false;
            try
            {
                var con = new SqlConnection(ConfigurationManager.ConnectionStrings["BD_Financiamiento"].ToString());
                con.Open();
                var cmd = new SqlCommand("delete from Ingreso where IDIngreso ='" + id + "'", con);
                cmd.ExecuteNonQuery();
                rpta = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return rpta;
        }

        public List<Ingreso> FindAll()
        {
            var Ingresos = new List<Ingreso>();
            try
            {
                using (var con = new SqlConnection(ConfigurationManager.ConnectionStrings["BD_Financiamiento"].ToString()))
                {
                    con.Open();
                    var query = new SqlCommand("select i.IDIngreso as CodigoIngreso, t.NTransaccion,t.MontoTransaccion,t.FechaTransaccion" +
                        "ci.IDCategoria_Ingreso as CodigoCategoriaI,ci.NCategoria_Ingreso from Ingreso i, Transaccion t, Categoria_Ingreso ci" +
                        "where i.IDIngreso=t.IDTransaccion and i.IDCategoria_Ingreso=ci.IDCategoria_Ingreso", con);

                    using (var dr = query.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            var transaccion = new Ingreso();
                            var categoria_ingreso = new Categoria_Ingreso();
                            transaccion.IDTransaccion = Convert.ToInt32(dr["IDTransaccion"]);
                            transaccion.NTransaccion = (dr["NTransaccion"]).ToString();
                            transaccion.MontoTransaccion = Convert.ToDecimal(dr["MontoTransaccion"]);
                            transaccion.FechaTransaccion = Convert.ToDateTime(dr["FechaTransaccion"]);

                            categoria_ingreso.IDCategoria_Ingreso = Convert.ToInt32(dr["IDCategoria_Ingreso"]);
                            categoria_ingreso.NCategoria_Ingreso = (dr["NCategoria_Ingreso"]).ToString();
                            transaccion.IDCategoria_Ingreso = categoria_ingreso;

                            Ingresos.Add(transaccion);
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return Ingresos;
        }

        public Ingreso FindByID(int? id)
        {
            throw new NotImplementedException();
        }

        public bool Insert(Ingreso t)
        {
            bool rpta = false;

            try
            {
                using (var con = new SqlConnection(ConfigurationManager.ConnectionStrings["BD_Financiamiento"].ToString()))
                {
                    con.Open();
                    var query = new SqlCommand("insert into Ingreso values (@IDTransaccion,@IDCategoria_Ingreso)", con);
                    query.Parameters.AddWithValue("@IDTransaccion", t.IDTransaccion);
                    query.Parameters.AddWithValue("@IDCategoria_Ingreso", t.IDCategoria_Ingreso.IDCategoria_Ingreso);

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

        public bool Update(Ingreso t)
        {
            bool rpta = false;

            try
            {
                using (var con = new SqlConnection(ConfigurationManager.ConnectionStrings["BD_Financiamiento"].ToString()))
                {
                    con.Open();
                    var query = new SqlCommand("update Ingreso set IDIngreso=@IDTransaccion,IDCategoria_Ingreso=@IDCategoria_Ingreso  where IDIngreso='" + t.IDTransaccion + "'", con);
                    query.Parameters.AddWithValue("@IDTransaccion", t.IDTransaccion);
                    query.Parameters.AddWithValue("@IDCategoria_Ingreso", t.IDCategoria_Ingreso.IDCategoria_Ingreso);
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
