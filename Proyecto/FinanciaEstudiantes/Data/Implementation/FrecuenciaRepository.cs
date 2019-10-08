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
    public class FrecuenciaRepository : IFrecuenciaRepository
    {
        public bool Delete(int? id)
        {
            bool rpta = false;
            try
            {
                var con = new SqlConnection(ConfigurationManager.ConnectionStrings["BD_Financiamiento"].ToString());
                con.Open();
                var cmd = new SqlCommand("delete from Frecuencia where IDFrecuencia ='" + id + "'", con);
                cmd.ExecuteNonQuery();
                rpta = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return rpta;
        }

        public List<Frecuencia> FindAll()
        {
            var Frecuencias = new List<Frecuencia>();

            try
            {
                using (var con = new SqlConnection(ConfigurationManager.ConnectionStrings["BD_Financiamiento"].ToString()))
                {
                    con.Open();
                    var query = new SqlCommand("select IDFrecuencia as CodigoFrecuencia,NFrecuencia,TDescripcion from Frecuencia", con);

                    using (var dr = query.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            var frecuencia = new Frecuencia();
                            frecuencia.IDFrecuencia = Convert.ToInt32(dr["IDFrecuencia"]);
                            frecuencia.NFrecuencia = (dr["NFrecuencia"]).ToString();
                            frecuencia.TDescripcion = (dr["TDescripcion"]).ToString();

                            Frecuencias.Add(frecuencia);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return Frecuencias;
        }

        public Frecuencia FindByID(int? id)
        {
            throw new NotImplementedException();
        }

        public bool Insert(Frecuencia t)
        {
            bool rpta = false;

            try
            {
                using (var con = new SqlConnection(ConfigurationManager.ConnectionStrings["BD_Financiamiento"].ToString()))
                {
                    con.Open();
                    var query = new SqlCommand("insert into Frecuencia values (@NFrecuencia,@TDescripcion)", con);
                    query.Parameters.AddWithValue("@NFrecuencia", t.NFrecuencia);
                    query.Parameters.AddWithValue("@TDescripcion", t.TDescripcion);

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

        public bool Update(Frecuencia t)
        {
            bool rpta = false;

            try
            {
                using (var con = new SqlConnection(ConfigurationManager.ConnectionStrings["BD_Financiamiento"].ToString()))
                {
                    con.Open();
                    var query = new SqlCommand("update Frecuencia set NFrecuencia=@NFrecuencia,TDescripcion=@TDescripcion  where IDFrecuencia='" + t.IDFrecuencia + "'", con);
                    query.Parameters.AddWithValue("@NFrecuencia", t.NFrecuencia);
                    query.Parameters.AddWithValue("@TDescripcion", t.TDescripcion);
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
