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
            throw new NotImplementedException();
        }

        public List<Frecuencia> FindAll()
        {
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }
    }
}
