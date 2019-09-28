using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Frecuencia
    {
        [DisplayName("Código de frecuencia")]
        public int IDFrecuencia { get; set; }

        [Required(ErrorMessage = "Porfavor, ingrese el nombre de la frecuencia: ")]
        [DisplayName("Nombre de frecuencia")]
        public string NFrecuencia { get; set; }

        [Required(ErrorMessage = "Porfavor, ingrese una descripcion de la frecuencia: ")]
        [DisplayName("Descripcion")]
        public string TDescripcion { get; set; }
    }
}
