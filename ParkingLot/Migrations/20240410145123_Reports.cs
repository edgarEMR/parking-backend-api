using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ParkingLot.Migrations
{
    /// <inheritdoc />
    public partial class Reports : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "companyId",
                table: "Vehicles",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "inputDate",
                table: "Vehicles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "inputCount",
                table: "Companies",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "outputCount",
                table: "Companies",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Vehicles_companyId",
                table: "Vehicles",
                column: "companyId");

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicles_Companies_companyId",
                table: "Vehicles",
                column: "companyId",
                principalTable: "Companies",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vehicles_Companies_companyId",
                table: "Vehicles");

            migrationBuilder.DropIndex(
                name: "IX_Vehicles_companyId",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "companyId",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "inputDate",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "inputCount",
                table: "Companies");

            migrationBuilder.DropColumn(
                name: "outputCount",
                table: "Companies");
        }
    }
}
