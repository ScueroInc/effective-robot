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
    public class DivisaRepository : IDivisaRepository
    {
        public bool Delete(int? id)
        {
            bool rpta = false;
            try
            {
                var con = new SqlConnection(ConfigurationManager.ConnectionStrings["BD_Financiamiento"].ToString());
                con.Open();
                var cmd = new SqlCommand("delete from Divisa where IDDivisa ='" + id + "'", con);
                cmd.ExecuteNonQuery();
                rpta = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return rpta;
        }

        public List<Divisa> FindAll()
        {
            var Divisas = new List<Divisa>();

            try
            {
                using (var con = new SqlConnection(ConfigurationManager.ConnectionStrings["BD_Financiamiento"].ToString()))
                {
                    con.Open();
                    var query = new SqlCommand("select IDDivisa as CodigoDivisa,NDivisa from Divisa", con);

                    using (var dr = query.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            var divisa = new Divisa();
                            divisa.IDDivisa = Convert.ToInt32(dr["IDDivisa"]);
                            divisa.NDivisa = (dr["NDivisa"]).ToString();

                            Divisas.Add(divisa);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return Divisas;
        }

        public Divisa FindByID(int? id)
        {
            throw new NotImplementedException();
        }

        public bool Insert(Divisa t)
        {
            bool rpta = false;

            try
            {
                using (var con = new SqlConnection(ConfigurationManager.ConnectionStrings["BD_Financiamiento"].ToString()))
                {
                    con.Open();
                    var query = new SqlCommand("insert into Divisa values (@NDivisa)", con);
                    query.Parameters.AddWithValue("@NDivisa", t.NDivisa);

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

        public bool Update(Divisa t)
        {
            bool rpta = false;

            try
            {
                using (var con = new SqlConnection(ConfigurationManager.ConnectionStrings["BD_Financiamiento"].ToString()))
                {
                    con.Open();
                    var query = new SqlCommand("update Divisa set NDivisa=@NDivisa where IDDivisa='" + t.IDDivisa + "'", con);
                    query.Parameters.AddWithValue("@NDivisa", t.NDivisa);
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
