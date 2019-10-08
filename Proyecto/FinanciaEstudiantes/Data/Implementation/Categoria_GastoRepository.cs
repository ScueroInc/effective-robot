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
            bool rpta = false;
            try
            {
                var con = new SqlConnection(ConfigurationManager.ConnectionStrings["BD_Financiamiento"].ToString());
                con.Open();
                var cmd = new SqlCommand("delete from Categoria_Gasto where IDCategoria_Gasto ='" + id + "'", con);
                cmd.ExecuteNonQuery();
                rpta = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return rpta;
        }

        public List<Categoria_Gasto> FindAll()
        {

            var ListCategoriaGasto = new List<Categoria_Gasto>();
            try
            {

                using (var con = new SqlConnection(ConfigurationManager.ConnectionStrings["BD_Financiamiento"].ToString()))
                {
                    con.Open();
                    var query = new SqlCommand("Select * from Categoria_Gasto", con);

                    using (var dr = query.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            var CatGasto = new Categoria_Gasto();
                           
                            CatGasto.IDCategoria_Gasto= Convert.ToInt32(dr["IDCategoria_Gasto"]);
                            CatGasto.NCategoria_Gasto= dr["NCategoria_Gasto"].ToString();
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return ListCategoriaGasto;
        }

        public Categoria_Gasto FindByID(int? id)//?

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
            bool rpta = false;

            try
            {
                using (var con = new SqlConnection(ConfigurationManager.ConnectionStrings["BD_Financiamiento"].ToString()))
                {
                    con.Open();
                    var query = new SqlCommand("update Categoria_Gasto set NCategoria_Gasto=@NCategoria_Gasto where IDCategoria_Gasto='" + t.IDCategoria_Gasto + "'", con);
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
    }
}
