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
            bool rpta = false;
            try
            {
                var con = new SqlConnection(ConfigurationManager.ConnectionStrings["BD_Financiamiento"].ToString());
                con.Open();
                var cmd = new SqlCommand("delete from Mes where IDMes ='" + id + "'", con);
                cmd.ExecuteNonQuery();
                rpta = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return rpta;
        }

        public List<Mes> FindAll()
        {
            var Meses = new List<Mes>();

            try
            {
                using (var con = new SqlConnection(ConfigurationManager.ConnectionStrings["BD_Financiamiento"].ToString()))
                {
                    con.Open();
                    var query = new SqlCommand("select IDMes as CodigoMes,NMes from Mes", con);

                    using (var dr = query.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            var mes = new Mes();
                            mes.IDMes = Convert.ToInt32(dr["IDMes"]);
                            mes.NMes = (dr["NMes"]).ToString();


                            Meses.Add(mes);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return Meses;
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
            bool rpta = false;

            try
            {
                using (var con = new SqlConnection(ConfigurationManager.ConnectionStrings["BD_Financiamiento"].ToString()))
                {
                    con.Open();
                    var query = new SqlCommand("update Mes set NMes=@NMes where IDMes='" + t.IDMes + "'", con);
                    query.Parameters.AddWithValue("@NMes", t.NMes);

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
