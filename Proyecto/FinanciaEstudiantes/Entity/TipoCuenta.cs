using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class TipoCuenta
    {
        [DisplayName("Código de tipo de cuenta")]
        public int IDTipoCuenta { get; set; }

        [Required(ErrorMessage = "Porfavor, ingrese el nombre del tipo de cuenta: ")]
        [DisplayName("Nombre de tipo de cuenta")]
        public string NTipoCuenta { get; set; }

        [Required(ErrorMessage = "Por favor, ingrese el monto de tipo de cuenta: ")]
        [DisplayName("tipo de cuenta")]
        public decimal MTipoCuenta { get; set; }

        public int TiempoCuenta { get; set; }
    }
}
