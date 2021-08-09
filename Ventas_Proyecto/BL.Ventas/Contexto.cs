using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Ventas
{
    public class Contexto: DbContext
    {
        public Contexto(): base("TIENDAROPA")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            Database.SetInitializer(new DatosdeInicio()); // Agrega datos de inicio a la base de datos despues de eliminarla
        }

        
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Departamento> Departamentos { get; set; }
        public DbSet<Seccion> Secciones { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Factura> Facturas { get; set; }
        public DbSet<EstadoCivil> EstadosCiv { get; set; }

    }
}
