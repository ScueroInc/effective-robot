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
    public class DeudaRepository : IDeudaRepository
    {
        public bool Delete(int? id)
        {
            throw new NotImplementedException();
        }

        public List<Deuda> FindAll()
        {
            throw new NotImplementedException();
        }

        public Deuda FindByID(int? id)
        {
            throw new NotImplementedException();
        }

        public bool Insert(Deuda t)
        {
            bool rpta = false;

            try
            {
                using (var con = new SqlConnection(ConfigurationManager.ConnectionStrings["BD_Financiamiento"].ToString()))
                {
                    con.Open();
                    var query = new SqlCommand("insert into Deuda values (@NDeuda,@FechaInicioDeuda,@FechaFinDeuda,@TDescripcion,@Interes,@MontoDeuda,@IDDivisa,@IDCategoria_Deuda,@IDEntidad)", con);

                    query.Parameters.AddWithValue("@NDeuda", t.NDeuda);
                    query.Parameters.AddWithValue("@FechaInicioDeuda", t.FechaInicioDeuda);
                    query.Parameters.AddWithValue("@FechaFinDeuda", t.FechaFinDeuda);
                    query.Parameters.AddWithValue("@TDescripcion", t.TDescripcion);
                    query.Parameters.AddWithValue("@Interes", t.Interes);
                    query.Parameters.AddWithValue("@MontoDeuda", t.MontoDeuda);
                    query.Parameters.AddWithValue("@IDDivisa", t.IDDivisa.IDDivisa);
                    query.Parameters.AddWithValue("@IDCategoria_Deuda", t.IDCategoria_Deuda.IDCategoria_Deuda);
                    query.Parameters.AddWithValue("@IDEntidad", t.IDEntidad.IDEntidad);

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

        public bool Update(Deuda t)
        {
            throw new NotImplementedException();
        }
    }
}
