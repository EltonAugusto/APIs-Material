namespace Material.Infra.Migrations
{
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<Material.Infra.Persistencia.MaterialContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

    }
}
