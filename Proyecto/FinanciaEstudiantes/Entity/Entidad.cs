using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Entidad
    {
        [DisplayName("Código de entidad")]
        public int IDEntidad { get; set; }

        [Required(ErrorMessage = "Porfavor, ingrese el nombre de la entidad: ")]
        [DisplayName("Nombre de entidad")]
        public string NEntidad { get; set; }

        [DisplayName("Entidad_Tipo")]
        [Required(ErrorMessage = "Por favor, ingrese un tipo de entidad: ")]
        public Entidad_Tipo IDEntidad_Tipo { get; set; }
    }
}
