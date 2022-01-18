using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoVisualNomina.Entidades
{
    public class FondosReserva
    {
        public int id { get; set; }
        public int EmpleadoId { get; set; }
        public float Porcentaje { get; set; }
        public float valor { get; set; }
        public ICollection<Empleado> lista { get; set; }
    }
}
