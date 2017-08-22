namespace Contso.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddEnrollmentTableWithoutCourseObject1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Enrollments",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Courseid = c.Int(nullable: false),
                        Studentid = c.Int(nullable: false),
                        Grade = c.Decimal(nullable: false, precision: 18, scale: 2),
                        CreatedDate = c.DateTime(nullable: false),
                        CreatedBy = c.String(),
                        UpdatedDate = c.DateTime(nullable: false),
                        UpdatedBy = c.String(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Students", t => t.Studentid, cascadeDelete: true)
                .Index(t => t.Studentid);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Enrollments", "Studentid", "dbo.Students");
            DropIndex("dbo.Enrollments", new[] { "Studentid" });
            DropTable("dbo.Enrollments");
        }
    }
}
