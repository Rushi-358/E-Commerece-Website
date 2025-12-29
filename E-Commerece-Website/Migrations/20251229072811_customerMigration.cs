using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace E_Commerece_Website.Migrations
{
    /// <inheritdoc />
    public partial class customerMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_tbl_admin",
                table: "tbl_admin");

            migrationBuilder.RenameTable(
                name: "tbl_admin",
                newName: "Admin");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Admin",
                table: "Admin",
                column: "admin_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Admin",
                table: "Admin");

            migrationBuilder.RenameTable(
                name: "Admin",
                newName: "tbl_admin");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tbl_admin",
                table: "tbl_admin",
                column: "admin_id");
        }
    }
}
