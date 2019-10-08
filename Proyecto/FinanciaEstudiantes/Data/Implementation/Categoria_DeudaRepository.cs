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
    public class Categoria_DeudaRepository : ICategoria_DeudaRepository
    {
        public bool Delete(int? id)
        {
            bool rpta = false;
            try
            {
                var con = new SqlConnection(ConfigurationManager.ConnectionStrings["BD_Financiamiento"].ToString());
                con.Open();
                var cmd = new SqlCommand("delete from Categoria_Deuda where IDCategoria_Deuda ='" + id + "'", con);
                cmd.ExecuteNonQuery();
                rpta = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return rpta;
        }

        public List<Categoria_Deuda> FindAll()
        {
            throw new NotImplementedException();
        }

        public Categoria_Deuda FindByID(int? id)
        {
            throw new NotImplementedException();
        }

        public bool Insert(Categoria_Deuda t)
        {
            bool rpta = false;

            try
            {
                using (var con = new SqlConnection(ConfigurationManager.ConnectionStrings["BD_Financiamiento"].ToString()))
                {
                    con.Open();
                    var query = new SqlCommand("insert into Categoria_Deuda values (@NCategoria_Deuda)", con);
                    query.Parameters.AddWithValue("@NCategoria_Deuda", t.NCategoria_Deuda);

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

        public bool Update(Categoria_Deuda t)
        {
            bool rpta = false;

            try
            {
                using (var con = new SqlConnection(ConfigurationManager.ConnectionStrings["BD_Financiamiento"].ToString()))
                {
                    con.Open();
                    var query = new SqlCommand("update Categoria_Deuda set NCategoria_Deuda=@NCategoria_Deuda where IDCategoria_Deuda='" + t.IDCategoria_Deuda + "'", con);
                    query.Parameters.AddWithValue("@NCategoria_Deuda", t.NCategoria_Deuda);

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
