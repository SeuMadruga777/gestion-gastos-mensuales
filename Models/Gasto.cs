using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeGastosMensuales.Models
{
    internal class Gasto
    {
        public int Id { get; set; } // autoincremental
        public string Descripcion { get; set; }
        public string Categoria { get; set; }
        public double Monto { get; set; }
        public DateTime Fecha { get; set; }
        public bool EsFijo { get; set; }
        public bool Pagado { get; set; }
    }
}
