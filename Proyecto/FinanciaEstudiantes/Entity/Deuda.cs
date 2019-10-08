using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Deuda
    {
        [DisplayName("Código de deuda")]
        public int IDDeuda { get; set; }

        [Required(ErrorMessage = "Porfavor, ingrese el nombre de la deuda: ")]
        [DisplayName("Nombre de deuda")]
        public string NDeuda { get; set; }

        [Required(ErrorMessage = "Porfavor, ingrese una fecha en la que inicio la deuda: ")]
        [DisplayName("Fecha de inicio de deuda")]
        public DateTime FechaInicioDeuda { get; set; }

        [Required(ErrorMessage = "Porfavor, ingrese una fecha en la que termino la deuda: ")]
        [DisplayName("Fecha de fin de deuda")]
        public DateTime FechaFinDeuda { get; set; }

        [Required(ErrorMessage = "Porfavor, ingrese una descripcion de la deuda: ")]
        [DisplayName("Descripcion")]
        public string TDescripcion { get; set; }

        [Required(ErrorMessage = "Por favor, ingrese el interes: ")]
        [DisplayName("Interes")]
        public decimal Interes { get; set; }

        [Required(ErrorMessage = "Por favor, ingrese el monto de la deuda: ")]
        [DisplayName("Monto de deuda")]
        public decimal MontoDeuda { get; set; }

        [DisplayName("Divisa")]
        [Required(ErrorMessage = "Por favor, ingrese una divisa: ")]
        public Divisa IDDivisa { get; set; }

        [DisplayName("Categoria_Deuda")]
        [Required(ErrorMessage = "Por favor, ingrese un tipo de categoria Deuda: ")]
        public Categoria_Deuda IDCategoria_Deuda { get; set; }

        [DisplayName("Entidad")]
        [Required(ErrorMessage = "Por favor, ingrese una entidad: ")]
        public Entidad IDEntidad { get; set; }
    }
}
