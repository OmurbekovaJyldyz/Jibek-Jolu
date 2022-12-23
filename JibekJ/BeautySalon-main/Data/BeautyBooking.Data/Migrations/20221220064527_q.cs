using Microsoft.EntityFrameworkCore.Migrations;

namespace BeautyBooking.Data.Migrations
{
    public partial class q : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Lat",
                table: "Salons",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Lng",
                table: "Salons",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Lat",
                table: "Salons");

            migrationBuilder.DropColumn(
                name: "Lng",
                table: "Salons");
        }
    }
}
