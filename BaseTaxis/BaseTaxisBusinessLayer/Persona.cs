using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace BaseTaxisBusinessLayer
{
    public class Persona
    {
        [Required(ErrorMessage = "El Primer Nombre es requerido")]
        [StringLength(50, MinimumLength = 1, ErrorMessage = "El Primer Nombre no debe de exceder los 50 caracteres")]
        public string PrimerNombre { get; set; }

        [StringLength(50, MinimumLength = 1, ErrorMessage = "El Segundo Nombre no debe de exceder los 50 caracteres")]
        public string SegundoNombre { get; set; }

        [Required(ErrorMessage = "El Apellido Paterno es requerido")]
        [StringLength(50, MinimumLength = 1, ErrorMessage = "El Apellido Paterno no debe de exceder los 50 caracteres")]
        public string ApellidoPaterno { get; set; }

        [Required(ErrorMessage = "El Apellido Materno es requerido")]
        [StringLength(50, MinimumLength = 1, ErrorMessage = "El Apellido Materno no debe de exceder los 50 caracteres")]
        public string ApellidoMaterno { get; set; }

        [Required(ErrorMessage = "El Numero de Telefono es requerido")]
        [StringLength(10, MinimumLength = 10,ErrorMessage = "El Numero de Telefono es a 10 digitos")]
        public string Telefono { get; set; }
    }
}
