namespace KatlaSport.DataAccess.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class AddCategoryDescription : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.product_categories", name: "Description", newName: "category_description");
            AlterColumn("dbo.product_categories", "category_description", c => c.String(maxLength: 300));
        }

        public override void Down()
        {
            AlterColumn("dbo.product_categories", "category_description", c => c.String());
            RenameColumn(table: "dbo.product_categories", name: "category_description", newName: "Description");
        }
    }
}
