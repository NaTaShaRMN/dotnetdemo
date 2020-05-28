using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace todolist.Migrations
{
    public partial class Fresher : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "employee",
                columns: table => new
                {
                    EmployeeID = table.Column<Guid>(nullable: false, comment: "Khóa chính")
                        .Annotation("MySql:CharSet", "utf8")
                        .Annotation("MySql:Collation", "utf8_general_ci"),
                    EmployeeCode = table.Column<string>(type: "varchar(20)", nullable: true, comment: "Mã h? so")
                        .Annotation("MySql:CharSet", "utf8")
                        .Annotation("MySql:Collation", "utf8_general_ci"),
                    FirstName = table.Column<string>(type: "varchar(100)", nullable: true, comment: "H?")
                        .Annotation("MySql:CharSet", "utf8")
                        .Annotation("MySql:Collation", "utf8_general_ci"),
                    LastName = table.Column<string>(type: "varchar(100)", nullable: true, comment: "Tên")
                        .Annotation("MySql:CharSet", "utf8")
                        .Annotation("MySql:Collation", "utf8_general_ci"),
                    FullName = table.Column<string>(type: "varchar(100)", nullable: false, comment: "H? và tên")
                        .Annotation("MySql:CharSet", "utf8")
                        .Annotation("MySql:Collation", "utf8_general_ci"),
                    DateOfBirth = table.Column<DateTime>(nullable: false, comment: "Ngày sinh")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_employee", x => x.EmployeeID);
                },
                comment: "h? so nhân viên");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeID",
                table: "employee",
                column: "EmployeeID",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "employee");
        }
    }
}
