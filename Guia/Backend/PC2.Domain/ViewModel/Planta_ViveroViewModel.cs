using System;

namespace PC2.Domain.ViewModel
{
    public class Planta_ViveroViewModel
    {
        public int plantaid {get;set;}
        
        public int NroFactura {get;set;}
        public int moneda {get;set;}
        public string DiaEmision {get;set;}
        public string DiaPago{get;set;}
        public float TotalFacturado{get;set;}
        public float Retencion{get;set;}
        public string fechaRegistro {get;set;}
    }
}