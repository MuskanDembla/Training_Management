using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Training_Management.Migrations
{
    /// <inheritdoc />
    public partial class initial3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Batches_BatchId",
                table: "Courses");

            migrationBuilder.DropIndex(
                name: "IX_Courses_BatchId",
                table: "Courses");

            migrationBuilder.RenameColumn(
                name: "role",
                table: "Users",
                newName: "Role");

            migrationBuilder.RenameColumn(
                name: "manager",
                table: "Users",
                newName: "Manager");

            migrationBuilder.RenameColumn(
                name: "BatchId",
                table: "Courses",
                newName: "Duration");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Courses",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Courses");

            migrationBuilder.RenameColumn(
                name: "Role",
                table: "Users",
                newName: "role");

            migrationBuilder.RenameColumn(
                name: "Manager",
                table: "Users",
                newName: "manager");

            migrationBuilder.RenameColumn(
                name: "Duration",
                table: "Courses",
                newName: "BatchId");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_BatchId",
                table: "Courses",
                column: "BatchId");

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Batches_BatchId",
                table: "Courses",
                column: "BatchId",
                principalTable: "Batches",
                principalColumn: "BatchId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
