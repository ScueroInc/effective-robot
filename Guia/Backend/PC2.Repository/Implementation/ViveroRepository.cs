using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using PC2.Domain;
using PC2.Domain.ViewModel;
using PC2.Repository.Context;

namespace PC2.Repository.Implementation
{
    public class ViveroRepository : IViveroRepository
    {
        private ApplicationDbContext context;

        public ViveroRepository(ApplicationDbContext context)
        {
            this.context = context;
        }
        public bool Delete(int id)
        {
            try{
                var entity = context.Viveros.FirstOrDefault(x=>x.id==id);
                context.Viveros.Remove(entity);
                context.SaveChanges();
                return true;
            }
            catch (System.Exception) {
                return false;
            }
        }

        public IEnumerable<Vivero> FindAll()
        {
            var result = new List<Vivero>();
            try {
                result = context.Viveros.ToList();
            }
            catch  (System.Exception) {
                throw;
            }
            return result;
        }


        public IEnumerable<Planta_Vivero>ListarPlantas(string nombre)
        {
            var plantas = new List<Planta_Vivero>();
            plantas = context.Plantas_Viveros
            .Include(pv => pv.planta)
            .Include(pv => pv.vivero)
            .Where(pv => pv.vivero.nombre == nombre)
            .ToList();
             return plantas;
        }

        public Vivero FindById(int id)
        {
            var viveros = new Vivero();
            try {
                viveros =  context.Viveros.FirstOrDefault(x=>x.id==id);
            }
            catch (System.Exception) {
                throw;
            }
            return viveros;  
        }

        public bool Save(Vivero entity)
        {
            Vivero vivero = new Vivero {
                id = entity.id,
                nombre = entity.nombre,
                TsEfectiva=entity.TsEfectiva,
                TsDescontada=entity.TsDescontada,
                Descuento=entity.Descuento,
                CostoInicial=entity.CostoInicial,
                CostoFinal=entity.CostoFinal,
                ValorNeto=entity.ValorNeto,
                ValorRecaudado=entity.ValorRecaudado,
                ValorEntero=entity.ValorEntero,
                TCEA=entity.TCEA
            };
            try {
                context.Viveros.Add(vivero);
                context.SaveChanges();
            }
            catch (System.Exception) {
                return false;
            }
            return true;
        }

        public bool guardar(ViveroViewModel entity)
        {
            Vivero vivero = new Vivero {
                 id = entity.id,
                nombre = entity.nombre,
                TsEfectiva=entity.TsEfectiva,
                TsDescontada=entity.TsDescontada,
                Descuento=entity.Descuento,
                CostoInicial=entity.CostoInicial,
                CostoFinal=entity.CostoFinal,
                ValorNeto=entity.ValorNeto,
                ValorRecaudado=entity.ValorRecaudado,
                ValorEntero=entity.ValorEntero,
                TCEA=entity.TCEA
                
            };
            try {
                context.Viveros.Add(vivero);
                context.SaveChanges();
                var plantaActual = new Planta();
                var viveroActual = vivero;
                
                foreach (var item in entity.plantas) {
                    plantaActual = context.Plantas.FirstOrDefault(x => x.id == item.plantaid);
                    Planta_Vivero pv = new Planta_Vivero {
                        vivero = viveroActual,
                        planta = plantaActual,
                        
                        fechaRegistro = item.fechaRegistro
                        
                    };
                    context.Plantas_Viveros.Add (pv);
                }
                context.SaveChanges();
            }
            catch (System.Exception) {
                return false;
            }
            return true;
        }
        public int dias(string d1,string d2)
        {
            int difdias=0;
            int anio,mes,dia;
            int anio2,mes2,dia2;

            string aux=d1;
            anio=Int32.Parse(aux.Substring(0,3));
            mes=Int32.Parse(aux.Substring(5,6));
            dia=Int32.Parse(aux.Substring(8,9));
            string aux1=d2;
            anio2=Int32.Parse(aux1.Substring(0,3));
            mes2=Int32.Parse(aux1.Substring(5,6));
            dia2=Int32.Parse(aux1.Substring(8,9));

            if(anio!=anio2)
                difdias=(anio2-anio)*360;
            else
                if(mes!=mes2)
                    difdias=difdias+(mes2-mes)*30;
                    else
                    if(dia!=dia2)
                    difdias=difdias+(dia2-dia);

            return difdias;
        }
        public double Calcular_VAN(double pago_adel, double valor_fact, double tea, string fechaemsion, string fechaPago)//fecha descuento = fecha de emision   
        {
            double van=0;
            van=(pago_adel*-1)+valor_fact/Math.Pow(1+tea,(dias(fechaemsion,fechaPago))/360);

            return van;
        }
        public double Calcular_Tir(string vi_nombre)
        {
            double tir=0;
            

            return tir;
        }
        public bool Update(Vivero entity)
        {
            try {
                var viveroOriginal = context.Viveros.Single (
                    x=>x.id == entity.id
                );
                viveroOriginal.id = entity.id;
                viveroOriginal.nombre = entity.nombre;
                viveroOriginal.TsEfectiva = entity.TsEfectiva;
                viveroOriginal.TsDescontada=entity.TsDescontada;
                viveroOriginal.Descuento=entity.Descuento;
                viveroOriginal.CostoFinal=entity.CostoFinal;
                viveroOriginal.CostoInicial=entity.CostoInicial;
                viveroOriginal.ValorEntero=entity.ValorEntero;
                viveroOriginal.ValorNeto=entity.ValorNeto;
                viveroOriginal.ValorRecaudado=entity.ValorRecaudado;
                viveroOriginal.TCEA=entity.TCEA;

                context.Viveros.Update(viveroOriginal);
                context.SaveChanges();
            }
            catch (System.Exception) {
                return false;
            }
            return true;
        }
    }
}