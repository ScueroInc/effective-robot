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
    public class Categoria_IngresoRepository : ICategoria_IngresoRepository
    {
        public bool Delete(int? id)
        {
            bool rpta = false;
            try
            {
                var con = new SqlConnection(ConfigurationManager.ConnectionStrings["BD_Financiamiento"].ToString());
                con.Open();
                var cmd = new SqlCommand("delete from Categoria_Ingreso where IDCategoria_Ingreso ='" + id + "'", con);
                cmd.ExecuteNonQuery();
                rpta = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return rpta;
        }

        public List<Categoria_Ingreso> FindAll()
        {

            var ListCatIngreso = new List<Categoria_Ingreso>();
            try
            {

                using (var con = new SqlConnection(ConfigurationManager.ConnectionStrings["BD_Financiamiento"].ToString()))
                {
                    con.Open();
                    var query = new SqlCommand("Select * from Categoria_Ingreso", con);

                    using (var dr = query.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            var CatIngreso = new Categoria_Ingreso();
                            CatIngreso.IDCategoria_Ingreso=Convert.ToInt32(dr["IDCategoria_Ingreso"]);
                            CatIngreso.NCategoria_Ingreso = dr["NCategoria_Ingreso"].ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return ListCatIngreso;

        }

        public Categoria_Ingreso FindByID(int? id)
        {
            throw new NotImplementedException();
        }

        public bool Insert(Categoria_Ingreso t)
        {
            bool rpta = false;

            try
            {
                using (var con = new SqlConnection(ConfigurationManager.ConnectionStrings["BD_Financiamiento"].ToString()))
                {
                    con.Open();
                    var query = new SqlCommand("insert into Categoria_Ingreso values (@NCategoria_Ingreso)", con);
                    query.Parameters.AddWithValue("@NCategoria_Ingreso", t.NCategoria_Ingreso);

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

        public bool Update(Categoria_Ingreso t)
        {
            bool rpta = false;

            try
            {
                using (var con = new SqlConnection(ConfigurationManager.ConnectionStrings["BD_Financiamiento"].ToString()))
                {
                    con.Open();
                    var query = new SqlCommand("update Categoria_Ingreso set NCategoria_Ingreso=@NCategoria_Ingreso where IDCategoria_Ingreso='" + t.IDCategoria_Ingreso + "'", con);
                    query.Parameters.AddWithValue("@NCategoria_Ingreso", t.NCategoria_Ingreso);

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
