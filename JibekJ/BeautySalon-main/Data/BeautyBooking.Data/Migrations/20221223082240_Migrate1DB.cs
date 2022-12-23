using Microsoft.EntityFrameworkCore.Migrations;

namespace BeautyBooking.Data.Migrations
{
    public partial class Migrate1DB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Amount",
                table: "Appointments",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Total",
                table: "Appointments",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Amount",
                table: "Appointments");

            migrationBuilder.DropColumn(
                name: "Total",
                table: "Appointments");
        }
    }
}
