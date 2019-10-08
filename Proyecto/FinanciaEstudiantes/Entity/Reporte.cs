using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Reporte
    {
        [DisplayName("Código de reporte")]
        public int IDReporte { get; set; }

        [Required(ErrorMessage = "Porfavor, ingrese una fecha de reporte: ")]
        [DisplayName("Fecha de reporte")]
        public DateTime FechaReporte { get; set; }

        [Required(ErrorMessage = "Porfavor, ingrese una fecha de inicio del reporte: ")]
        [DisplayName("Fecha de inicio")]
        public DateTime FechaInicio { get; set; }

        [Required(ErrorMessage = "Porfavor, ingrese una fecha de fin del reporte: ")]
        [DisplayName("Fecha de fin")]
        public DateTime FechaTermino { get; set; }

    }
}
