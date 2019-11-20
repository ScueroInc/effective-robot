using System.Collections.Generic;

namespace PC2.Domain.ViewModel
{
    public class ViveroViewModel
    {
        public int id {get;set;}
        public string nombre {get;set;}
        public float TsEfectiva {get;set;}
        public float TsDescontada {get;set;}
        public float Descuento {get;set;}
        public float CostoInicial {get;set;}
        public float CostoFinal {get;set;}
        public float ValorNeto {get;set;}
        public float ValorRecaudado {get;set;}
        public float ValorEntero {get;set;}
        public float TCEA {get;set;}
        public IEnumerable<Planta_ViveroViewModel> plantas {get;set;}
    }
}