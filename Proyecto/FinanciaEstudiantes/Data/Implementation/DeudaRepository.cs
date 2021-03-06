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
    public class DeudaRepository : IDeudaRepository
    {
        public bool Delete(int? id)
        {
            bool rpta = false;
            try
            {
                var con = new SqlConnection(ConfigurationManager.ConnectionStrings["BD_Financiamiento"].ToString());
                con.Open();
                var cmd = new SqlCommand("delete from Deuda where IDDeuda ='" + id + "'", con);
                cmd.ExecuteNonQuery();
                rpta = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return rpta;
        }

        public List<Deuda> FindAll()
        {

            var Deudas = new List<Deuda>();
            try
            {

                using (var con = new SqlConnection(ConfigurationManager.ConnectionStrings["BD_Financiamiento"].ToString()))
                {
                    con.Open();
                    var query = new SqlCommand("select d.IDDeuda as CodigoDeuda,d.NDeuda,d.FechaInicioDeuda,d.FechaFinDeuda,d.TDescripcion,d.Interes,d.MontoDeuda," +
                        "di.NDivisa, cd.NCategoria_Deuda, e.NEntidad, u.IDUsuario as CodigoUsuario,u.Nombre,u.Apellidos,u.Email,u.Nickname,u.Celular" +
                        "from Deuda d, Divisa di, Categoria_Deuda cd, Entidad e, Usuario u " +
                        "where d.IDDivisa=di.IDDivisa and d.IDCategoria_Deuda=cd.IDCategoria_Deuda and d.IDEntidad=e.IDEntidad and d.IDUsuario=u.IDUsuario", con);

                    using (var dr = query.ExecuteReader())
                    {
                        while(dr.Read())
                        {
                            var Deudis = new Deuda();

                            Deudis.IDDeuda = Convert.ToInt32(dr["IDDeuda"]);
                            Deudis.NDeuda= dr["NDeuda"].ToString();
                            Deudis.FechaInicioDeuda = Convert.ToDateTime(dr["FechaInicioDeuda"]); //datetime px
                            Deudis.FechaFinDeuda = Convert.ToDateTime(dr["FechaFinDeuda"]);
                            Deudis.TDescripcion = dr["TDescripcion"].ToString();
                            Deudis.Interes = Convert.ToDecimal(dr["Interes"]); // son decimal
                            Deudis.MontoDeuda= Convert.ToDecimal(dr["MontoDeuda"]);

                            var Divisa = new Divisa();
                            Divisa.NDivisa = (dr["NDivisa"]).ToString();//evaluar -> q cosa?

                            var CategoriaDeuda = new Categoria_Deuda();
                            CategoriaDeuda.NCategoria_Deuda = (dr["NCategoria_Deuda"]).ToString();

                            var Entidad = new Entidad();
                            Entidad.NEntidad = (dr["NEntidad"]).ToString();

                            var usuario = new Usuario();
                            usuario.Nombre = (dr["Nombre"]).ToString();
                            usuario.Apellidos = (dr["Apellidos"]).ToString();
                            usuario.Nickname= dr["Nickname"].ToString(); //no estoy seguro -> pues estate seguro xD
                            Deudis.IDCategoria_Deuda = CategoriaDeuda;
                            Deudis.IDDivisa = Divisa;
                            Deudis.IDEntidad = Entidad;

                            //te falto agregarlos a la lista no mames ahi esta el ejemplo en otras entidades
                            Deudas.Add(Deudis);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return Deudas;

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
            bool rpta = false;

            try
            {
                using (var con = new SqlConnection(ConfigurationManager.ConnectionStrings["BD_Financiamiento"].ToString()))
                {
                    con.Open();
                    var query = new SqlCommand("update Deuda set NDeuda=@NDeuda,FechaInicioDeuda=@FechaInicioDeuda,FechaFinDeuda=@FechaFinDeuda,TDescripcion=@TDescripcion,Interes=@Interes,MontoDeuda=@MontoDeuda,IDDivisa=@IDDivisa,IDCategoria_Deuda=@IDCategoria_Deuda,IDEntidad=@IDEntidad where IDDeuda='" + t.IDDeuda + "'", con);
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
    }
}
