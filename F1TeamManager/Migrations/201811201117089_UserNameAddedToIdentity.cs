namespace F1TeamManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UserNameAddedToIdentity : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Teams", "Name", c => c.String(maxLength: 50));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Teams", "Name", c => c.String(nullable: false, maxLength: 50));
        }
    }
}
