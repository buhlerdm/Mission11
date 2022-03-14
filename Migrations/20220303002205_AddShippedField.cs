using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlineBookstoreProject.Migrations
{
    public partial class AddShippedField : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "PurchaseShipped",
                table: "Purchases",
                nullable: false,
                defaultValue: false);
        }

        
    }
}
