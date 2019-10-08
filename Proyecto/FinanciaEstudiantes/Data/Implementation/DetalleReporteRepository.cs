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
    public class DetalleReporteRepository : IDetalleReporteRepository
    {
        public bool Delete(int? id)
        {
            bool rpta = false;
            try
            {
                var con = new SqlConnection(ConfigurationManager.ConnectionStrings["BD_Financiamiento"].ToString());
                con.Open();
                var cmd = new SqlCommand("delete from DetalleReporte where IDDetalleReporte ='" + id + "'", con);
                cmd.ExecuteNonQuery();
                rpta = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return rpta;
        }

        public List<DetalleReporte> FindAll()
        {
            throw new NotImplementedException();
        }

        public DetalleReporte FindByID(int? id)
        {
            throw new NotImplementedException();
        }

        public bool Insert(DetalleReporte t)
        {
            bool rpta = false;

            try
            {
                using (var con = new SqlConnection(ConfigurationManager.ConnectionStrings["BD_Financiamiento"].ToString()))
                {
                    con.Open();
                    var query = new SqlCommand("inser into DetalleReporte values (@IDTransaccion,@IDReporte)", con);

                    query.Parameters.AddWithValue("@IDTransaccion", t.IDTransaccion.IDTransaccion);
                    query.Parameters.AddWithValue("@IDReporte", t.IDReporte.IDReporte);

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

        public bool Update(DetalleReporte t)
        {
            bool rpta = false;

            try
            {
                using (var con = new SqlConnection(ConfigurationManager.ConnectionStrings["BD_Financiamiento"].ToString()))
                {
                    con.Open();
                    var query = new SqlCommand("update DetalleReporte set IDTransaccion=@IDTransaccion,IDReporte=@IDReporte where IDReporte='" + t.IDReporte + "'", con);
                    query.Parameters.AddWithValue("@IDTransaccion", t.IDTransaccion.IDTransaccion);
                    query.Parameters.AddWithValue("@IDReporte", t.IDReporte.IDReporte);
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
