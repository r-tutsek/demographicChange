namespace DemographicChangeData.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Second : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.DemographicChangeEntities");
            AddColumn("dbo.DemographicChangeEntities", "Id", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.DemographicChangeEntities", "Id");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.DemographicChangeEntities");
            DropColumn("dbo.DemographicChangeEntities", "Id");
            AddPrimaryKey("dbo.DemographicChangeEntities", "PopulationCount");
        }
    }
}
