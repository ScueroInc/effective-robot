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
    public class DivisaRepository : IDivisaRepository
    {
        public bool Delete(int? id)
        {
            throw new NotImplementedException();
        }

        public List<Divisa> FindAll()
        {
            throw new NotImplementedException();
        }

        public Divisa FindByID(int? id)
        {
            throw new NotImplementedException();
        }

        public bool Insert(Divisa t)
        {
            bool rpta = false;

            try
            {
                using (var con = new SqlConnection(ConfigurationManager.ConnectionStrings["BD_Financiamiento"].ToString()))
                {
                    con.Open();
                    var query = new SqlCommand("insert into Divisa values (@NDivisa)", con);
                    query.Parameters.AddWithValue("@NDivisa", t.NDivisa);

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

        public bool Update(Divisa t)
        {
            throw new NotImplementedException();
        }
    }
}
