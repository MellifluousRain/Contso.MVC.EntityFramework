namespace Contso.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddInstructorTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Instructors",
                c => new
                    {
                        id = c.Int(nullable: false),
                        HireDate = c.DateTime(nullable: false),
                        Departments_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.People", t => t.id)
                .ForeignKey("dbo.Departments", t => t.Departments_id)
                .Index(t => t.id)
                .Index(t => t.Departments_id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Instructors", "Departments_id", "dbo.Departments");
            DropForeignKey("dbo.Instructors", "id", "dbo.People");
            DropIndex("dbo.Instructors", new[] { "Departments_id" });
            DropIndex("dbo.Instructors", new[] { "id" });
            DropTable("dbo.Instructors");
        }
    }
}
