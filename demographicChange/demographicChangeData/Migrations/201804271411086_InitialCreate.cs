namespace DemographicChangeData.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DemographicChangeEntities",
                c => new
                    {
                        PopulationCount = c.Double(nullable: false),
                        Year = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.PopulationCount);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.DemographicChangeEntities");
        }
    }
}
