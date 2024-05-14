using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DRHanannProject.Migrations
{
    public partial class updatepowertable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "value",
                table: "power",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "value",
                table: "power");
        }
    }
}
