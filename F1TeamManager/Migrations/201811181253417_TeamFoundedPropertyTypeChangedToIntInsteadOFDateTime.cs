namespace F1TeamManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TeamFoundedPropertyTypeChangedToIntInsteadOFDateTime : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Teams", "Founded", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Teams", "Founded", c => c.DateTime(nullable: false));
        }
    }
}
