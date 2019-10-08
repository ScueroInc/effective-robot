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
    public class TipoCuentaRepository : ITipoCuentaRepository
    {
        public bool Delete(int? id)
        {
            bool rpta = false;
            try
            {
                var con = new SqlConnection(ConfigurationManager.ConnectionStrings["BD_Financiamiento"].ToString());
                con.Open();
                var cmd = new SqlCommand("delete from TipoCuenta where IDTipoCuenta ='" + id + "'", con);
                cmd.ExecuteNonQuery();
                rpta = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return rpta;
        }

        public List<TipoCuenta> FindAll()
        {
            var TipoCuentas = new List<TipoCuenta>();
            try
            {
                using (var con = new SqlConnection(ConfigurationManager.ConnectionStrings["BD_Financiamiento"].ToString()))
                {
                    con.Open();
                    var query = new SqlCommand("select IDTipoCuenta as CodigoTipoCuenta,NTipoCuenta,MTipoCuenta,TiempoCuenta from TipoCuenta", con);

                    using (var dr = query.ExecuteReader())
                    {
                        while(dr.Read())
                        {
                            var tipocuenta = new TipoCuenta();
                            tipocuenta.IDTipoCuenta = Convert.ToInt32(dr["IDTipoCuenta"]);
                            tipocuenta.NTipoCuenta = (dr["NTipoCuenta"]).ToString();
                            tipocuenta.MTipoCuenta = Convert.ToDecimal(dr["MTipoCuenta"]);
                            tipocuenta.TiempoCuenta = Convert.ToInt32(dr["TiempoCuenta"]);
                            TipoCuentas.Add(tipocuenta);
                        }
                    }
                }
            }
            catch ( Exception ex)
            {

                throw ex;
            }
            return TipoCuentas;
        }

        public TipoCuenta FindByID(int? id)
        {
            throw new NotImplementedException();
        }

        public bool Insert(TipoCuenta t)
        {
            bool rpta = false;

            try
            {
                using (var con = new SqlConnection(ConfigurationManager.ConnectionStrings["BD_Financiamiento"].ToString()))
                {
                    con.Open();

                    var query = new SqlCommand("insert into TipoCuenta values (@NTipoCuenta,@MTipoCuenta,@TiempoCuenta)", con);

                    query.Parameters.AddWithValue("@NTipoCuenta", t.NTipoCuenta);
                    query.Parameters.AddWithValue("@MTipoCuenta", t.MTipoCuenta);
                    query.Parameters.AddWithValue("@TiempoCuenta", t.TiempoCuenta);

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

        public bool Update(TipoCuenta t)
        {
            bool rpta = false;

            try
            {
                using (var con = new SqlConnection(ConfigurationManager.ConnectionStrings["BD_Financiamiento"].ToString()))
                {
                    con.Open();
                    var query = new SqlCommand("update TipoCuenta set NTipoCuenta=@NTipoCuenta,MTipoCuenta=@MTipoCuenta,TiempoCuenta=@TiempoCuenta  where IDTipoCuenta='" + t.IDTipoCuenta + "'", con);
                    query.Parameters.AddWithValue("@NTipoCuenta", t.NTipoCuenta);
                    query.Parameters.AddWithValue("@MTipoCuenta", t.MTipoCuenta);
                    query.Parameters.AddWithValue("@TiempoCuenta", t.TiempoCuenta);
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
