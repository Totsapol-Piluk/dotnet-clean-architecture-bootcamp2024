using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class addidentity2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "28d65a5b-a7db-4850-b380-83591f7d7531", "28d65a5b-a7db-4850-b380-83591f7d7531", "Reader", "READER" },
                    { "9740f16c-24a1-4224-a7be-1bb00b7c6892", "9740f16c-24a1-4224-a7be-1bb00b7c6892", "Writer", "WRITER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "edc267ec-d43c-4e3b-8108-a1a1f819906d", 0, "c8ef6437-a247-491a-a097-f0d446825740", "admin@gmail.com", false, false, null, "ADMIN@GMAIL.COM", "ADMIN@GMAIL.COM", "AQAAAAIAAYagAAAAENoik2ZsS/HOsoSWlsd+a8C5m8Rh6WummS91D8T05q+p9r3M5ZmYt7kdVghILoH5cQ==", null, false, "b81870b8-aa87-48a0-9243-ae8e130eba34", false, "admin@gmail.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "28d65a5b-a7db-4850-b380-83591f7d7531", "edc267ec-d43c-4e3b-8108-a1a1f819906d" },
                    { "9740f16c-24a1-4224-a7be-1bb00b7c6892", "edc267ec-d43c-4e3b-8108-a1a1f819906d" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "28d65a5b-a7db-4850-b380-83591f7d7531", "edc267ec-d43c-4e3b-8108-a1a1f819906d" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "9740f16c-24a1-4224-a7be-1bb00b7c6892", "edc267ec-d43c-4e3b-8108-a1a1f819906d" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "28d65a5b-a7db-4850-b380-83591f7d7531");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9740f16c-24a1-4224-a7be-1bb00b7c6892");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "edc267ec-d43c-4e3b-8108-a1a1f819906d");
        }
    }
}
