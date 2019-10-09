using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Ingreso : Transaccion
    {
        [DisplayName("Categoria_Ingreso")]
        [Required(ErrorMessage = "Por favor, ingrese un tipo de categoria de ingreso: ")]
        public Categoria_Ingreso IDCategoria_Ingreso { get; set; }
    }
}
