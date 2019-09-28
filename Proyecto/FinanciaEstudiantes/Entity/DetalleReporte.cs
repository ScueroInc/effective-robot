using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class DetalleReporte
    {
        [DisplayName("Transaccion")]
        [Required(ErrorMessage = "Por favor, ingrese una transaccion: ")]
        public Transaccion IDTransaccion { get; set; }

        [DisplayName("Reporte")]
        [Required(ErrorMessage = "Por favor, ingrese un reporte: ")]
        public Reporte IDReporte { get; set; }
    }
    
}
