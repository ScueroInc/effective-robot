using System;

namespace PC2.Domain
{
    public class Planta_Vivero
    {
        public int id {get;set;}
        public Vivero vivero {get;set;}
        public Planta planta {get;set;}
        public string fechaRegistro {get;set;}
    }
}