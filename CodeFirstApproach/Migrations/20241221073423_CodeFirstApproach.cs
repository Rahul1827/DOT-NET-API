using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CodeFirstApproach.Migrations
{
    /// <inheritdoc />
    public partial class CodeFirstApproach : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    studentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Student_Name = table.Column<string>(type: "varchar(100)", nullable: false),
                    age = table.Column<int>(type: "int", nullable: false),
                    Student_Gender = table.Column<string>(type: "varchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.studentId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Students");
        }
    }
}
