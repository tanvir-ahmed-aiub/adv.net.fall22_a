namespace CodeFirstMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCgpaToStudents : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Students", "Cgpa", c => c.Single());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Students", "Cgpa");
        }
    }
}
