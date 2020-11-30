namespace ExerciseApi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddModelEmployee : DbMigration
    {
        public override void Up() => CreateTable(
                "dbo.Employees",
                c => new
                {
                    EmployeeId = c.Int(nullable: false, identity: true),
                    Name = c.String(),
                    Division = c.String(),
                    DivisionId = c.Int(nullable: false, identity: true)
                })
                .PrimaryKey(t => t.EmployeeId);

        public override void Down()
        {
            DropTable("dbo.Employees");
        }
    }
}
