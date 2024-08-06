using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APIAssignment1.Migrations
{
    /// <inheritdoc />
    public partial class CreateWorksOn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "worksOns",
                columns: table => new
                {
                    WorksOnId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    ProjectId = table.Column<int>(type: "int", nullable: false),
                    Job = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    EnterDate = table.Column<DateTime>(type: "Date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_worksOns", x => x.WorksOnId);
                    table.ForeignKey(
                        name: "FK_worksOns_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_worksOns_Projects_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Projects",
                        principalColumn: "ProjectId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_worksOns_EmployeeId",
                table: "worksOns",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_worksOns_ProjectId",
                table: "worksOns",
                column: "ProjectId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "worksOns");
        }
    }
}
