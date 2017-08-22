namespace Contso.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDepartmentsTable_MissingInstructorInDepartment_1vNForeignkeysModifyNeeded : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Departments",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Budget = c.Decimal(nullable: false, precision: 18, scale: 2),
                        StartDate = c.DateTime(nullable: false),
                        Instructorid = c.Int(nullable: false),
                        RowVersion = c.String(),
                        CreatedDate = c.DateTime(nullable: false),
                        CreatedBy = c.String(),
                        UpdatedDate = c.DateTime(nullable: false),
                        UpdatedBy = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateIndex("dbo.Courses", "Departmentid");
            AddForeignKey("dbo.Courses", "Departmentid", "dbo.Departments", "id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Courses", "Departmentid", "dbo.Departments");
            DropIndex("dbo.Courses", new[] { "Departmentid" });
            DropTable("dbo.Departments");
        }
    }
}
