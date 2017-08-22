namespace Contso.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPeopleTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.People",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        LastName = c.String(),
                        Firstname = c.String(),
                        MiddleName = c.String(),
                        Age = c.Int(nullable: false),
                        Email = c.String(),
                        Phone = c.String(),
                        AddressLine1 = c.String(),
                        AddressLine2 = c.String(),
                        UnitOrApartmentNumber = c.String(),
                        City = c.String(),
                        State = c.String(),
                        Zipcode = c.String(),
                        CreatedDate = c.DateTime(nullable: false),
                        CreatedBy = c.String(),
                        UpdatedDate = c.DateTime(nullable: false),
                        UpdatedBy = c.String(),
                        Password = c.String(),
                        Salt = c.String(),
                        IsLocked = c.String(),
                        LastLockedDateTime = c.DateTime(nullable: false),
                        FailedAttempts = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.People");
        }
    }
}
