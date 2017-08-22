namespace Contso.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Junction : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.InstructorCourses",
                c => new
                    {
                        Instructor_id = c.Int(nullable: false),
                        Courses_id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Instructor_id, t.Courses_id })
                .ForeignKey("dbo.Instructors", t => t.Instructor_id, cascadeDelete: true)
                .ForeignKey("dbo.Courses", t => t.Courses_id, cascadeDelete: true)
                .Index(t => t.Instructor_id)
                .Index(t => t.Courses_id);
            
            CreateTable(
                "dbo.RolesPeoples",
                c => new
                    {
                        Roles_id = c.Int(nullable: false),
                        People_id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Roles_id, t.People_id })
                .ForeignKey("dbo.Roles", t => t.Roles_id, cascadeDelete: true)
                .ForeignKey("dbo.People", t => t.People_id, cascadeDelete: true)
                .Index(t => t.Roles_id)
                .Index(t => t.People_id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.RolesPeoples", "People_id", "dbo.People");
            DropForeignKey("dbo.RolesPeoples", "Roles_id", "dbo.Roles");
            DropForeignKey("dbo.InstructorCourses", "Courses_id", "dbo.Courses");
            DropForeignKey("dbo.InstructorCourses", "Instructor_id", "dbo.Instructors");
            DropIndex("dbo.RolesPeoples", new[] { "People_id" });
            DropIndex("dbo.RolesPeoples", new[] { "Roles_id" });
            DropIndex("dbo.InstructorCourses", new[] { "Courses_id" });
            DropIndex("dbo.InstructorCourses", new[] { "Instructor_id" });
            DropTable("dbo.RolesPeoples");
            DropTable("dbo.InstructorCourses");
        }
    }
}
