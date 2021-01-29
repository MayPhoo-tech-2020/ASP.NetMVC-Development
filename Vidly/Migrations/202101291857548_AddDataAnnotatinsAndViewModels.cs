namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDataAnnotatinsAndViewModels : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "CustomerName", c => c.String(nullable: false));
            AddColumn("dbo.Movies", "MovieName", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Movies", "MovieName");
            DropColumn("dbo.Customers", "CustomerName");
        }
    }
}
