namespace Contso.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCoursesTable_MissingJunctionAndDepartmentInCourses : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Courses",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Credits = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Departmentid = c.Int(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        CreatedBy = c.String(),
                        UpdatedDate = c.DateTime(nullable: false),
                        UpdatedBy = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateIndex("dbo.Enrollments", "Courseid");
            AddForeignKey("dbo.Enrollments", "Courseid", "dbo.Courses", "id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Enrollments", "Courseid", "dbo.Courses");
            DropIndex("dbo.Enrollments", new[] { "Courseid" });
            DropTable("dbo.Courses");
        }
    }
}
