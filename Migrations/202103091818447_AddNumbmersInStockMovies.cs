namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddNumbmersInStockMovies : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "NumbersInStock", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Movies", "NumbersInStock");
        }
    }
}
