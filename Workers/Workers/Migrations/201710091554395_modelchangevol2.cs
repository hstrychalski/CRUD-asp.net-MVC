namespace Workers.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class modelchangevol2 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Workers", "Discriminator");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Workers", "Discriminator", c => c.String(nullable: false, maxLength: 128));
        }
    }
}
