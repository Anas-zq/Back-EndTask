using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TaskForSteadyPoint.Migrations
{
    public partial class _2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Accounts",
                table: "Accounts");

            migrationBuilder.RenameTable(
                name: "Accounts",
                newName: "Employees");

            migrationBuilder.RenameIndex(
                name: "IX_Accounts_OfficialID",
                table: "Employees",
                newName: "IX_Employees_OfficialID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Employees",
                table: "Employees",
                column: "ID");

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "ID", "CreationDate", "DateOfBirth", "EmailAddress", "EmployeeName", "OfficialID" },
                values: new object[,]
                {
                    { 1, new DateTime(2021, 2, 9, 17, 25, 53, 8, DateTimeKind.Local).AddTicks(1644), new DateTime(1998, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ahmad@steady", "Ahmad", 1 },
                    { 2, new DateTime(2021, 2, 9, 17, 25, 53, 13, DateTimeKind.Local).AddTicks(3193), new DateTime(1998, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Anas@steady", "Anas", 2 },
                    { 3, new DateTime(2021, 2, 9, 17, 25, 53, 13, DateTimeKind.Local).AddTicks(3372), new DateTime(2001, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ihab@steady", "ihab", 3 },
                    { 4, new DateTime(2021, 2, 9, 17, 25, 53, 13, DateTimeKind.Local).AddTicks(3389), new DateTime(2002, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "majd@steady", "majd", 4 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Employees",
                table: "Employees");

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.RenameTable(
                name: "Employees",
                newName: "Accounts");

            migrationBuilder.RenameIndex(
                name: "IX_Employees_OfficialID",
                table: "Accounts",
                newName: "IX_Accounts_OfficialID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Accounts",
                table: "Accounts",
                column: "ID");
        }
    }
}
