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
            throw new NotImplementedException();
        }

        public List<Ingreso> FindAll()
        {
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }
    }
}
