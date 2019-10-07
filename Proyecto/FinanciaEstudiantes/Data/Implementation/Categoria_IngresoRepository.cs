﻿using System;
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
            throw new NotImplementedException();
        }

        public List<Categoria_Ingreso> FindAll()
        {
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }
    }
}
