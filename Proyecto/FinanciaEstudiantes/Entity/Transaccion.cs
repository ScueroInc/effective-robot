using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Transaccion
    {
        [DisplayName("Código de transaccion")]
        public int IDTransaccion { get; set; }

        [Required(ErrorMessage = "Porfavor, ingrese el nombre de la transaccion: ")]
        [DisplayName("Nombre de transaccion")]
        public string NTransaccion { get; set; }

        [Required(ErrorMessage = "Por favor, ingrese el monto de transaccion: ")]
        [DisplayName("Monto de transaccion")]
        public decimal MontoTransaccion { get; set; }

        [Required(ErrorMessage = "Porfavor, ingrese una fecha de la transaccion: ")]
        [DisplayName("Fecha de transaccion")]
        public DateTime FechaTransaccion { get; set; }

        [DisplayName("Divisa")]
        [Required(ErrorMessage = "Por favor, ingrese una divisa: ")]
        public Divisa IDDivisa { get; set; }

        [DisplayName("Mes")]
        [Required(ErrorMessage = "Por favor, ingrese un mes: ")]
        public Mes IDMes { get; set; }

        [DisplayName("Usuario")]
        [Required(ErrorMessage = "Por favor, ingrese un usuario: ")]
        public Usuario IDUsuario { get; set; }

        [DisplayName("Frecuencia")]
        [Required(ErrorMessage = "Por favor, ingrese la frecuencia: ")]
        public Frecuencia IDFrecuencia { get; set; }
    }
}
