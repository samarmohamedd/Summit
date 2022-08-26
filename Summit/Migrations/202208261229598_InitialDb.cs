namespace Summit.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialDb : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        Empid = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Age = c.Int(nullable: false),
                        Salary = c.Double(nullable: false),
                        City = c.String(),
                        Address = c.String(),
                    })
                .PrimaryKey(t => t.Empid);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Employees");
        }
    }
}
