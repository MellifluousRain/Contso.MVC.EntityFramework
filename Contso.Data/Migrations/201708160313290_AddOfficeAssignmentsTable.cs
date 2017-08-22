namespace Contso.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddOfficeAssignmentsTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.OfficeAssignments",
                c => new
                    {
                        Instructorid = c.Int(nullable: false),
                        Location = c.String(),
                        CreatedDate = c.DateTime(nullable: false),
                        CreatedBy = c.String(),
                        UpdatedDate = c.DateTime(nullable: false),
                        UpdatedBy = c.String(),
                    })
                .PrimaryKey(t => t.Instructorid)
                .ForeignKey("dbo.Instructors", t => t.Instructorid)
                .Index(t => t.Instructorid);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.OfficeAssignments", "Instructorid", "dbo.Instructors");
            DropIndex("dbo.OfficeAssignments", new[] { "Instructorid" });
            DropTable("dbo.OfficeAssignments");
        }
    }
}
