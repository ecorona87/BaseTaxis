using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BaseTaxisBusinessLayer
{
    public class Asociado : Persona
    {
        public int AsociadoID { get; set; }

        public DateTime FechaCreacion { get; set; }

        public int CreadoUsuarioID { get; set; }

        public bool Activo { get; set; }


    }
}
