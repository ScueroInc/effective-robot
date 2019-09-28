using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Entidad_Tipo
    {
        [DisplayName("Codigo Entidad_Tipo")]
        public int IDEntidad_Tipo { get; set; }

        [Required(ErrorMessage = "Porfavor, ingrese el nombre del tipo de entidad: ")]
        [DisplayName("Nombre de tipo de entidad")]
        public string NEntidad_Tipo { get; set; }
    }
}
