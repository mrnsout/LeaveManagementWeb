using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagementWeb.Data.Migrations
{
    public partial class AddedDefaultUsersAndRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "966abaa5 - fc9d - 47c0 - b129 - 5fb8ce7bd950", "d4a3898d-2934-44e7-936d-70e5d8c58567", "User", "USER" },
                    { "fb6e2be8-433a-4aa8-a370-940f8c528e61", "9fb3ad71-dd62-467e-865a-ad6324cacf77", "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateJoined", "DateOfBirth", "Email", "EmailConfirmed", "Firstname", "Lastname", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TaxId", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "9470d59e-dab9-4543-8ea6-9773b55e0512", 0, "d2bb0fb7-f3e8-423f-8dc7-3c32e9510d80", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@localhost.com", false, "System", "Admin", false, null, "ADMIN@LOCALHOST.COM", null, "AQAAAAEAACcQAAAAEMZ6LNAXY414XgI2/Bqyo7BeRGPl0iGZGuaKEGDO54Z5D+iYbdlU0trMo7b3Vh+8bw==", null, false, "9f040741-f1b8-4ee1-a3d6-c0e275f8a1e3", null, false, null },
                    { "966abaa5 - fc9d - 47c0 - b129 - 5fb8ce7bd950", 0, "ebb2eebc-c22f-4b8a-a95c-87900ae471eb", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user@localhost.com", false, "System", "User", false, null, "USER@LOCALHOST.COM", null, "AQAAAAEAACcQAAAAEGxL+fbcjXJt0uMj5Q17wp2Ul30DuaFsBJVxEQvuydzedboTc20SRMpdUm98tGfTAA==", null, false, "2fa01d5b-52f5-4789-891e-e33809c96f3d", null, false, null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "fb6e2be8-433a-4aa8-a370-940f8c528e61", "9470d59e-dab9-4543-8ea6-9773b55e0512" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "966abaa5 - fc9d - 47c0 - b129 - 5fb8ce7bd950");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "fb6e2be8-433a-4aa8-a370-940f8c528e61", "9470d59e-dab9-4543-8ea6-9773b55e0512" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "966abaa5 - fc9d - 47c0 - b129 - 5fb8ce7bd950");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fb6e2be8-433a-4aa8-a370-940f8c528e61");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9470d59e-dab9-4543-8ea6-9773b55e0512");
        }
    }
}
