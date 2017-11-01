namespace LoginTest5.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPassRegistrationsTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PassRegistrations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserName = c.String(),
                        Name = c.String(),
                        NumberInHouse = c.Int(nullable: false),
                        Address = c.String(),
                        City = c.String(),
                        ZipCode = c.Int(nullable: false),
                        PhoneNumber = c.String(),
                        Email = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.PassRegistrations");
        }
    }
}
