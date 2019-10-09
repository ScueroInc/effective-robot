using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Divisa
    {
        [DisplayName("Código de divisa")]
        public int IDDivisa { get; set; }

        [Required(ErrorMessage = "Porfavor, ingrese el nombre de la divisa: ")]
        [DisplayName("Nombre de divisa")]
        public string NDivisa { get; set; }
    }
}
