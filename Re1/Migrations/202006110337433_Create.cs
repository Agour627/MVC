namespace Re1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        SSN = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Salary = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.SSN);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Employees");
        }
    }
}
