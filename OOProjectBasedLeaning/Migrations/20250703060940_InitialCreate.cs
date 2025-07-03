using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OOProjectBasedLeaning.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    WorkTimeSum = table.Column<TimeSpan>(type: "time", nullable: false),
                    WorkTimeIn = table.Column<TimeSpan>(type: "time", nullable: false),
                    WorkTimeOut = table.Column<TimeSpan>(type: "time", nullable: false),
                    WorkTimeRestSum = table.Column<TimeSpan>(type: "time", nullable: true),
                    WorkStatus = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employees");
        }
    }
}
