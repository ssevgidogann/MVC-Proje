namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class sütünkaldir : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Contacts", "NameSurname");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Contacts", "NameSurname", c => c.String(maxLength: 1000));
        }
    }
}
