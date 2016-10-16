using Material.Dominio.Cadastros.Entidades;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Material.Infra.Persistencia
{
    public class MaterialContext : DbContext
    {
        public MaterialContext()
            :base("materialConnectionsString")
        {
            Database.SetInitializer(new Initializer());
        
        }

        public DbSet<Produto> Produtos { get; set; }

        
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            modelBuilder.Properties()
                .Where(p => p.Name == p.ReflectedType.Name + "Id")
                .Configure(p => p.IsKey());

            modelBuilder.Properties<string>()
                .Configure(p => p.HasColumnType("varchar"));

            modelBuilder.Properties<string>()
                .Configure(p => p.HasMaxLength(3000));
        }
    }
}
