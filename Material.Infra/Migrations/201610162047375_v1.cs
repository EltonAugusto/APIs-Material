namespace Material.Infra.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Produto",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Nome = c.String(maxLength: 3000, unicode: false),
                        Descricao = c.String(maxLength: 3000, unicode: false),
                        Preco = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Produto");
        }
    }
}
