namespace F1TeamManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TeamPropertiesRequired : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Teams", "Name", c => c.String(nullable: false, maxLength: 50));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Teams", "Name", c => c.String(maxLength: 50));
        }
    }
}
