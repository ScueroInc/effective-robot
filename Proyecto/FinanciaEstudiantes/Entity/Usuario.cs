using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Usuario
    {
        [DisplayName("Código de usuario")]
        public int IDUsuario {get; set;}

        [Required(ErrorMessage = "Porfavor, ingrese el nombre del usuario: ")]
        [DisplayName("Nombre de usuario")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Porfavor, ingrese el apellido del usuario: ")]
        [DisplayName("apellido del usuario")]
        public string Apellido { get; set; }

        [Required(ErrorMessage = "Porfavor ingrese el email del usuario: ")]
	[RegularExpressionAttribute(@"[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?", ErrorMessage="Ingrese un email valido")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Porfavor, ingrese un nickname del usuario: ")]
        [DisplayName("nickname del usuario")]
        public string Nickname { get; set; }

        [Required(ErrorMessage = "Porfavor, ingrese el password del usuario: ")]
        [DisplayName("Password del usuario")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Porfavor, ingrese el celular del usuario")]
        [DisplayName("celular")]
        public long Celular { get; set; }

        [DisplayName("TipoCuenta")]
        [Required(ErrorMessage = "Por favor, ingrese un tipo de cuenta: ")]
        public TipoCuenta IDTipoCuenta { get; set; }


    }
}
