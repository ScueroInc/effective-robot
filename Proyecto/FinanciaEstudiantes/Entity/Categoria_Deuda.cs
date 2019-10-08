using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Categoria_Deuda
    {
        [DisplayName("Código de categoria de deuda")]
        public int IDCategoria_Deuda { get; set; }

        [Required(ErrorMessage = "Porfavor, ingrese el nombre de la categoria de deuda: ")]
        [DisplayName("Nombre de la categoria deuda")]
        public string NCategoria_Deuda { get; set; }
    }
}
