using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Categoria_Ingreso
    {
        [DisplayName("Código de categoria de ingreso")]
        public int IDCategoria_Ingreso { get; set; }

        [Required(ErrorMessage = "Porfavor, ingrese el nombre de la categoria de ingreso: ")]
        [DisplayName("Nombre de categoria de ingreso")]
        public string NCategoria_Ingreso { get; set; }
    }
}
