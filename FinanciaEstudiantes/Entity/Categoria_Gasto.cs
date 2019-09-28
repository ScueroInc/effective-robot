using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Categoria_Gasto
    {
        [DisplayName("Código de categoria de gasto")]
        public int IDCategoria_Gasto { get; set; }

        [Required(ErrorMessage = "Porfavor, ingrese el nombre de la categoria de gasto: ")]
        [DisplayName("Nombre de categoria de gasto")]
        public string NCategoria_Gasto { get; set; }
    }
}
