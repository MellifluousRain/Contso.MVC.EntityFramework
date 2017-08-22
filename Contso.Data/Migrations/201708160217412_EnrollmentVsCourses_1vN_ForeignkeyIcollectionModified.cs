namespace Contso.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EnrollmentVsCourses_1vN_ForeignkeyIcollectionModified : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Enrollments", "Courseid", "dbo.Courses");
            DropIndex("dbo.Enrollments", new[] { "Courseid" });
            AddColumn("dbo.Courses", "Enrollments_id", c => c.Int());
            CreateIndex("dbo.Courses", "Enrollments_id");
            AddForeignKey("dbo.Courses", "Enrollments_id", "dbo.Enrollments", "id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Courses", "Enrollments_id", "dbo.Enrollments");
            DropIndex("dbo.Courses", new[] { "Enrollments_id" });
            DropColumn("dbo.Courses", "Enrollments_id");
            CreateIndex("dbo.Enrollments", "Courseid");
            AddForeignKey("dbo.Enrollments", "Courseid", "dbo.Courses", "id", cascadeDelete: true);
        }
    }
}
