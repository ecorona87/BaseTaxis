using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BaseTaxisBusinessLayer
{
    public class Operador : Persona
    {
        
        public int OperadorID { get; set; }

        [StringLength(6,MinimumLength = 6,ErrorMessage = "El Identificador debe de ser de 6 caracteres")]
        public string Identificador { get; set; }

        public DateTime FechaCreacion { get; set; }

        public int CreadoUsuarioID { get; set; }

        public bool Activo { get; set; }
    }
}
