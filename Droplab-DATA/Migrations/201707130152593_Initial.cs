namespace Droplab_DATA.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.T_OS",
                c => new
                    {
                        ID = c.Long(nullable: false, identity: true),
                        DESCRIPTION = c.String(nullable: false, maxLength: 250, storeType: "nvarchar"),
                        DT_CREATED = c.DateTime(nullable: false, precision: 0),
                        ID_MODIFIED = c.DateTime(nullable: false, precision: 0),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.T_OS");
        }
    }
}
