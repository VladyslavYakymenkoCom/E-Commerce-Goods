namespace GoodsStore.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Emaileuniquefix : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.Users", "Email", unique: true);
        }
        
        public override void Down()
        {
            DropIndex("dbo.Users", new[] { "Email" });
        }
    }
}
