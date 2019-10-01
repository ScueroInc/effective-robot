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
            throw new NotImplementedException();
        }

        public List<Gasto> FindAll()
        {
            throw new NotImplementedException();
        }

        public Gasto FindByID(int? id)
        {
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }
    }
}
