using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Yanvis.Domain.Migrations
{
    /// <inheritdoc />
    public partial class _202412062351 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_JsonRecordes",
                table: "JsonRecordes");

            migrationBuilder.RenameTable(
                name: "JsonRecordes",
                newName: "JsonRecords");

            migrationBuilder.RenameColumn(
                name: "Content",
                table: "JsonRecords",
                newName: "JsonRecordContent");

            migrationBuilder.AddPrimaryKey(
                name: "PK_JsonRecords",
                table: "JsonRecords",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_JsonRecords",
                table: "JsonRecords");

            migrationBuilder.RenameTable(
                name: "JsonRecords",
                newName: "JsonRecordes");

            migrationBuilder.RenameColumn(
                name: "JsonRecordContent",
                table: "JsonRecordes",
                newName: "Content");

            migrationBuilder.AddPrimaryKey(
                name: "PK_JsonRecordes",
                table: "JsonRecordes",
                column: "Id");
        }
    }
}
