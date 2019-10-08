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
    public class Entidad_TipoRepository : IEntidad_TipoRepository
    {
        public bool Delete(int? id)
        {
            bool rpta = false;
            try
            {
                var con = new SqlConnection(ConfigurationManager.ConnectionStrings["BD_Financiamiento"].ToString());
                con.Open();
                var cmd = new SqlCommand("delete from Entidad_Tipo where IDEntidad_Tipo ='" + id + "'", con);
                cmd.ExecuteNonQuery();
                rpta = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return rpta;
        }

        public List<Entidad_Tipo> FindAll()
        {
            var Entidad_Tipos = new List<Entidad_Tipo>();

            try
            {
                using (var con = new SqlConnection(ConfigurationManager.ConnectionStrings["BD_Financiamiento"].ToString()))
                {
                    con.Open();
                    var query = new SqlCommand("select IDEntidad_Tipo, NEntidad_Tipo from Entidad_Tipo", con);

                    using (var dr = query.ExecuteReader())
                    {
                        while(dr.Read())
                        {
                            var entidad_tipo = new Entidad_Tipo();
                            entidad_tipo.IDEntidad_Tipo = Convert.ToInt32(dr["IDEntidad_Tipo"]);
                            entidad_tipo.NEntidad_Tipo = (dr["NEntidad_Tipo"]).ToString();
                            Entidad_Tipos.Add(entidad_tipo);
                        }
                    }
                    
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }

            return Entidad_Tipos;
        }

        public Entidad_Tipo FindByID(int? id)
        {
            throw new NotImplementedException();
        }

        public bool Insert(Entidad_Tipo t)
        {
            bool rpta = false;
            try
            {
                using (var con = new SqlConnection(ConfigurationManager.ConnectionStrings["BD_Financiamiento"].ToString()))
                {
                    con.Open();
                    var query = new SqlCommand("insert into Entidad_Tipo values (@NEntidad_Tipo)", con);
                    query.Parameters.AddWithValue("@NEntidad_Tipo", t.NEntidad_Tipo);

                    query.ExecuteNonQuery();
                    rpta = true;
                }
            }
            catch ( Exception ex)
            {

                throw ex;
            }

            return rpta;
        }

        public bool Update(Entidad_Tipo t)
        {
            bool rpta = false;

            try
            {
                using (var con = new SqlConnection(ConfigurationManager.ConnectionStrings["BD_Financiamiento"].ToString()))
                {
                    con.Open();
                    var query = new SqlCommand("update Entidad_Tipo set NEntidad_Tipo=@NEntidad_Tipo where IDEntidad_Tipo='" + t.IDEntidad_Tipo + "'", con);
                    query.Parameters.AddWithValue("@NEntidad_Tipo", t.NEntidad_Tipo);
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
