namespace Workers.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Second : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Workers", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.Workers", "LastName", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Workers", "LastName", c => c.String());
            AlterColumn("dbo.Workers", "Name", c => c.String());
        }
    }
}
