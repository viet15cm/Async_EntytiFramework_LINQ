using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Async_EntytiFramework.Migrations
{
    public partial class init_4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_students_graders_GraderId",
                table: "students");

            migrationBuilder.AlterColumn<Guid>(
                name: "GraderId",
                table: "students",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Birthday",
                table: "students",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddForeignKey(
                name: "FK_students_graders_GraderId",
                table: "students",
                column: "GraderId",
                principalTable: "graders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_students_graders_GraderId",
                table: "students");

            migrationBuilder.AlterColumn<Guid>(
                name: "GraderId",
                table: "students",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Birthday",
                table: "students",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_students_graders_GraderId",
                table: "students",
                column: "GraderId",
                principalTable: "graders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
