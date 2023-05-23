using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Training_Management.Migrations
{
    /// <inheritdoc />
    public partial class initals : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Batches_BatchId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_BatchId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "BatchId",
                table: "Users");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BatchId",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Users_BatchId",
                table: "Users",
                column: "BatchId");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Batches_BatchId",
                table: "Users",
                column: "BatchId",
                principalTable: "Batches",
                principalColumn: "BatchId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
