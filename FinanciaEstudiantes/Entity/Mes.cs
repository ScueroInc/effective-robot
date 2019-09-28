using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Mes
    {
        [DisplayName("Código de mes")]
        public int IDMes { get; set; }

        [Required(ErrorMessage = "Porfavor, ingrese el nombre del mes: ")]
        [DisplayName("Nombre de mes")]
        public string NMes { get; set; }
    }
}
