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
    public class TransaccionRepository : ITransaccionRepository
    {
        public bool Delete(int? id)
        {
            throw new NotImplementedException();
        }

        public List<Transaccion> FindAll()
        {
            throw new NotImplementedException();
        }

        public Transaccion FindByID(int? id)
        {
            throw new NotImplementedException();
        }

        public bool Insert(Transaccion t)
        {
            bool rpta = false;

            try
            {
                using (var con = new SqlConnection(ConfigurationManager.ConnectionStrings["BD_Financiamiento"].ToString()))
                {
                    con.Open();

                    var query = new SqlCommand("insert into Transaccion values (@NTransaccion,@MontoTransaccion,@FechaTransaccion,@IDDivisa,@IDMes,@IDUsuario,@IDFrecuencia)", con);
                    query.Parameters.AddWithValue("@NTransaccion", t.NTransaccion);
                    query.Parameters.AddWithValue("@MonotoTransaccion", t.MontoTransaccion);
                    query.Parameters.AddWithValue("@FechaTransaccion", t.FechaTransaccion);
                    query.Parameters.AddWithValue("@IDDivisa", t.IDDivisa.IDDivisa);
                    query.Parameters.AddWithValue("@IDMes", t.IDMes.IDMes);
                    query.Parameters.AddWithValue("@IDUsuario", t.IDUsuario.IDUsuario);
                    query.Parameters.AddWithValue("@IDFrecuencia", t.IDFrecuencia.IDFrecuencia);

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

        public bool Update(Transaccion t)
        {
            throw new NotImplementedException();
        }
    }
}
