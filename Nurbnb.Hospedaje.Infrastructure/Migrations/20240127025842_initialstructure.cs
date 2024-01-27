using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Nurbnb.Hospedaje.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class initialstructure : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "checkin",
                columns: table => new
                {
                    checkinId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    operacionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    hora = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    instrucciones = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_checkin", x => x.checkinId);
                });

            migrationBuilder.CreateTable(
                name: "checkout",
                columns: table => new
                {
                    checkoutId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    operacionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    hora = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_checkout", x => x.checkoutId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "checkin");

            migrationBuilder.DropTable(
                name: "checkout");
        }
    }
}
