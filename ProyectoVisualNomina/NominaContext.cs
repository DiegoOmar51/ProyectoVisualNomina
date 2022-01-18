using Microsoft.EntityFrameworkCore;
using ProyectoVisualNomina.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoVisualNomina
{
    public class NominaContext:DbContext

    {
        public DbSet<DecimoCuarto> DecimoCuartos{ get; set; }
        public DbSet<DecimoTercero> DecimoTerceros { get; set; }
        public DbSet<FondoReserva> FondosReserva { get; set; }
        public DbSet<HorasExt> HorasExts { get; set; }
        public DbSet<RolPago> RolPagos { get; set; }
        public DbSet<Vacaciones> Vacaciones { get; set; }
    }
}
