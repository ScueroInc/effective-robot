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
            throw new NotImplementedException();
        }

        public List<Reporte> FindAll()
        {
            throw new NotImplementedException();
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
                    query.Parameters.AddWithValue("@FechaFin", t.FechaFin);

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
            throw new NotImplementedException();
        }
    }
}
