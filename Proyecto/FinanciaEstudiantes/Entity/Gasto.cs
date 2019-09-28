using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Gasto : Transaccion
    {
        [DisplayName("Categoria_Gasto")]
        [Required(ErrorMessage = "Por favor, ingrese un tipo de categoria gasto: ")]
        public Categoria_Gasto IDCategoria_Gasto { get; set; }
    }
}
