namespace CSharpEgitimKampi301.DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateEntities : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "CustomerName", c => c.String());
            AddColumn("dbo.Customers", "CustomerSurname", c => c.String());
            AddColumn("dbo.Customers", "CustomerDistrict", c => c.String());
            AddColumn("dbo.Customers", "CustomerCity", c => c.String());
            DropColumn("dbo.Customers", "CusomerName");
            DropColumn("dbo.Customers", "CusomerSurname");
            DropColumn("dbo.Customers", "CusomerDistrict");
            DropColumn("dbo.Customers", "CusomerCity");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Customers", "CusomerCity", c => c.String());
            AddColumn("dbo.Customers", "CusomerDistrict", c => c.String());
            AddColumn("dbo.Customers", "CusomerSurname", c => c.String());
            AddColumn("dbo.Customers", "CusomerName", c => c.String());
            DropColumn("dbo.Customers", "CustomerCity");
            DropColumn("dbo.Customers", "CustomerDistrict");
            DropColumn("dbo.Customers", "CustomerSurname");
            DropColumn("dbo.Customers", "CustomerName");
        }
    }
}
