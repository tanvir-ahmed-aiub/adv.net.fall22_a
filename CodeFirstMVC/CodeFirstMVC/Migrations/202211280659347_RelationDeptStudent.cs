namespace CodeFirstMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RelationDeptStudent : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Students", "DeptId", c => c.Int());
            CreateIndex("dbo.Students", "DeptId");
            AddForeignKey("dbo.Students", "DeptId", "dbo.Departments", "DeptId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Students", "DeptId", "dbo.Departments");
            DropIndex("dbo.Students", new[] { "DeptId" });
            DropColumn("dbo.Students", "DeptId");
        }
    }
}
