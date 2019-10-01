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
    public class MesRepository : IMesRepository
    {
        public bool Delete(int? id)
        {
            throw new NotImplementedException();
        }

        public List<Mes> FindAll()
        {
            throw new NotImplementedException();
        }

        public Mes FindByID(int? id)
        {
            throw new NotImplementedException();
        }

        public bool Insert(Mes t)
        {
            bool rpta = false;

            try
            {
                using (var con = new SqlConnection(ConfigurationManager.ConnectionStrings["BD_Financiamiento"].ToString()))
                {
                    con.Open();

                    var query = new SqlCommand("insert into Mes values (@NMes)", con);
                    query.Parameters.AddWithValue("@NMes", t.NMes);

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

        public bool Update(Mes t)
        {
            throw new NotImplementedException();
        }
    }
}
