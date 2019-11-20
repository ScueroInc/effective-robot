using System;

namespace PC2.Domain
{
    public class Planta
    {
        public int id {get;set;}
        public int NroFactura {get;set;}
        public int moneda {get;set;}
        public DateTime DiaEmision {get;set;}
        public DateTime DiaPago{get;set;}
        public float TotalFacturado{get;set;}
        public float Retencion{get;set;}

    }
}