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
    public class EntidadRepository : IEntidadRepository
    {
        public bool Delete(int? id)
        {
            throw new NotImplementedException();
        }

        public List<Entidad> FindAll()
        {
            var Entidades = new List<Entidad>();

            try
            {
                using (var con = new SqlConnection(ConfigurationManager.ConnectionStrings["BD_Financiamiento"].ToString()))
                {
                    con.Open();
                    var query = new SqlCommand("Select e.IDEntidad, e.NEntidad, et.IDEntidad_Tipo, et.NEntidad_Tipo" +
                        "from Entidad e, Entidad_Tipo et where e.IDEntidad_Tipo = et.IDEntidad_Tipo", con);

                    using (var dr = query.ExecuteReader())
                    {
                        while(dr.Read())
                        {
                            var entidad = new Entidad();
                            var entidad_tipo = new Entidad_Tipo();

                            entidad.IDEntidad = Convert.ToInt32(dr["IDEntidad"]);
                            entidad.NEntidad = (dr["NEntidad"]).ToString();
                            entidad_tipo.NEntidad_Tipo = (dr["NEntidad_Tipo"]).ToString();
                            entidad.IDEntidad_Tipo = entidad_tipo;

                            Entidades.Add(entidad);
                            
                        }
                    }
                }
            }
            catch ( Exception ex)
            {

                throw ex;
            }

            return Entidades;
        }

        public Entidad FindByID(int? id)
        {
            throw new NotImplementedException();
        }

        public bool Insert(Entidad t)
        {
            bool rpta = false;

            try
            {
                using (var con = new SqlConnection(ConfigurationManager.ConnectionStrings["BD_Financiamiento"].ToString()))
                {
                    con.Open();
                    var query = new SqlCommand("insert into Entidad values (@NEntidad,@IDEntidad_Tipo)", con);
                    query.Parameters.AddWithValue("@NEntidad", t.NEntidad);
                    query.Parameters.AddWithValue("@IDEntidad_Tipo", t.IDEntidad_Tipo.IDEntidad_Tipo);

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

        public bool Update(Entidad t)
        {
            throw new NotImplementedException();
        }
    }
}
