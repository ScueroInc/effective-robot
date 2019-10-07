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
    public class Categoria_GastoRepository : ICategoria_GastoRepository
    {
        public bool Delete(int? id)
        {
            throw new NotImplementedException();
        }

        public List<Categoria_Gasto> FindAll()
        {
            throw new NotImplementedException();
        }

        public Categoria_Gasto FindByID(int? id)
        {
            throw new NotImplementedException();
        }

        public bool Insert(Categoria_Gasto t)
        {
            bool rpta = false;

            try
            {
                using (var con = new SqlConnection(ConfigurationManager.ConnectionStrings["BD_Financiamiento"].ToString()))
                {
                    con.Open();
                    var query = new SqlCommand("insert into Categoria_Gasto values (@NCategoria_Gasto)", con);
                    query.Parameters.AddWithValue("@NCategoria_Gasto", t.NCategoria_Gasto);

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

        public bool Update(Categoria_Gasto t)
        {
            throw new NotImplementedException();
        }
    }
}
