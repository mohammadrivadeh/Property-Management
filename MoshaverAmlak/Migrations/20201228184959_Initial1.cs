using Microsoft.EntityFrameworkCore.Migrations;

namespace MoshaverAmlak.Migrations
{
    public partial class Initial1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Properties",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Seller = table.Column<string>(nullable: true),
                    Area = table.Column<string>(nullable: true),
                    Floor = table.Column<string>(nullable: true),
                    Price = table.Column<string>(nullable: true),
                    SellerMobile = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    PropertyType = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Properties", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SoldedProperties",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Seller = table.Column<string>(nullable: true),
                    Buyer = table.Column<string>(nullable: true),
                    Area = table.Column<string>(nullable: true),
                    Floor = table.Column<string>(nullable: true),
                    Price = table.Column<string>(nullable: true),
                    SellerMobile = table.Column<string>(nullable: true),
                    BuyerMobile = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    PropertyType = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SoldedProperties", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Properties");

            migrationBuilder.DropTable(
                name: "SoldedProperties");
        }
    }
}
