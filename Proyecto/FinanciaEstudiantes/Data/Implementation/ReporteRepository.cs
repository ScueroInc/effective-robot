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
    public class ReporteRepository : IReporteRepository
    {
        public bool Delete(int? id)
        {
            bool rpta = false;
            try
            {
                var con = new SqlConnection(ConfigurationManager.ConnectionStrings["BD_Financiamiento"].ToString());
                con.Open();
                var cmd = new SqlCommand("delete from Reporte where IDReporte ='" + id + "'", con);
                cmd.ExecuteNonQuery();
                rpta = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return rpta;
        }

        public List<Reporte> FindAll()
        {
            var Reportes = new List<Reporte>();

            try
            {
                using (var con = new SqlConnection(ConfigurationManager.ConnectionStrings["BD_Financiamiento"].ToString()))
                {
                    con.Open();
                    var query = new SqlCommand("select IDReporte as CodigoReporte,FechaReporte,FechaInicio,FechaTermino from Reporte", con);

                    using (var dr = query.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            var reporte = new Reporte();
                            reporte.IDReporte = Convert.ToInt32(dr["IDReporte"]);
                            reporte.FechaReporte = Convert.ToDateTime(dr["FechaReporte"]);
                            reporte.FechaInicio = Convert.ToDateTime(dr["FechaInicio"]);
                            reporte.FechaTermino = Convert.ToDateTime(dr["FechaTermino"]);

                            Reportes.Add(reporte);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return Reportes;
        }

        public Reporte FindByID(int? id)
        {
            throw new NotImplementedException();
        }

        public bool Insert(Reporte t)
        {
            bool rpta = false;

            try
            {
                using (var con = new SqlConnection(ConfigurationManager.ConnectionStrings["BD_Financiamiento"].ToString()))
                {
                    con.Open();

                    var query = new SqlCommand("insert into Reporte values (@FechaReporte,@FechaInicio,@FechaFin)", con);
                    query.Parameters.AddWithValue("@FechaReporte", t.FechaReporte);
                    query.Parameters.AddWithValue("@FechaInicio", t.FechaInicio);
                    query.Parameters.AddWithValue("@FechaFin", t.FechaTermino);

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

        public bool Update(Reporte t)
        {
            bool rpta = false;

            try
            {
                using (var con = new SqlConnection(ConfigurationManager.ConnectionStrings["BD_Financiamiento"].ToString()))
                {
                    con.Open();
                    var query = new SqlCommand("update Reporte set FechaReporte=@FechaReporte,FechaInicio=@FechaInicio,FechaFin=@FechaFin  where IDReporte='" + t.IDReporte + "'", con);
                    query.Parameters.AddWithValue("@FechaReporte", t.FechaReporte);
                    query.Parameters.AddWithValue("@FechaInicio", t.FechaInicio);
                    query.Parameters.AddWithValue("@FechaFin", t.FechaTermino);
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
