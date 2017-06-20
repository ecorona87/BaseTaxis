using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BaseTaxisBusinessLayer
{
    public class Taxi
    {
        public int TaxiID { get; set; }

        public string Identificador { get; set; }

        public string Placas { get; set; }

        public string NumeroSerie { get; set; }

        public int AsociadoID { get; set; }

        public decimal Renta { get; set; }

        public bool Climatizado { get; set; }

        public DateTime FechaVerificacion { get; set; }

        public string Condiciones { get; set; }

        public string NumeroConcesion { get; set; }

        public string Estado { get; set; }

        public DateTime FechaCreacion { get; set; }

        public int CreadoUsuarioID { get; set; }

        public bool Activo { get; set; }

    }
}
