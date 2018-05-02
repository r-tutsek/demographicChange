namespace DemographicChangeData.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initital : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DemographicChangeByEthnicGroupsEntities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PopulationCount = c.Double(nullable: false),
                        Year = c.Int(nullable: false),
                        Ethnicity = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.DemographicChangeByEthnicGroupsEntities");
        }
    }
}
