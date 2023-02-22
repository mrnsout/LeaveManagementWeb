using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagementWeb.Data.Migrations
{
    public partial class AddedDefaultUsersAndUserNames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "966abaa5 - fc9d - 47c0 - b129 - 5fb8ce7bd950",
                column: "ConcurrencyStamp",
                value: "65f5be9b-25e0-466b-ab3a-ea180aabd775");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fb6e2be8-433a-4aa8-a370-940f8c528e61",
                column: "ConcurrencyStamp",
                value: "003758a1-f259-4292-b34a-4d1bce4a29b3");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9470d59e-dab9-4543-8ea6-9773b55e0512",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "f9cf812a-7c82-47f9-9d31-bd219edb6155", true, "ADMIN@LOCALHOST.COM", "AQAAAAEAACcQAAAAENuLuGCBS+MLBsvaTnyOFZ4ZUiFpbe55LQBFH4P97spMK0cL6hMCHM3o73+vcu4l6g==", "f7ba3a76-4b35-4b1f-bf1b-6a739615925d", "admin@localhost.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "966abaa5 - fc9d - 47c0 - b129 - 5fb8ce7bd950",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "1b3d8bdc-acb9-427f-9f35-9cb0bca1eba4", true, "USER@LOCALHOST.COM", "AQAAAAEAACcQAAAAEA4kURXQvND3AdAXz9Nr/4xZ4dPwj968ILBQB7gYr5G97HFcbatgIfLOSH1R+3SLyQ==", "946000b8-d84e-4841-8240-766ad7362bd7", "user@localhost.com" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "966abaa5 - fc9d - 47c0 - b129 - 5fb8ce7bd950",
                column: "ConcurrencyStamp",
                value: "d4a3898d-2934-44e7-936d-70e5d8c58567");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fb6e2be8-433a-4aa8-a370-940f8c528e61",
                column: "ConcurrencyStamp",
                value: "9fb3ad71-dd62-467e-865a-ad6324cacf77");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9470d59e-dab9-4543-8ea6-9773b55e0512",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "d2bb0fb7-f3e8-423f-8dc7-3c32e9510d80", false, null, "AQAAAAEAACcQAAAAEMZ6LNAXY414XgI2/Bqyo7BeRGPl0iGZGuaKEGDO54Z5D+iYbdlU0trMo7b3Vh+8bw==", "9f040741-f1b8-4ee1-a3d6-c0e275f8a1e3", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "966abaa5 - fc9d - 47c0 - b129 - 5fb8ce7bd950",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "ebb2eebc-c22f-4b8a-a95c-87900ae471eb", false, null, "AQAAAAEAACcQAAAAEGxL+fbcjXJt0uMj5Q17wp2Ul30DuaFsBJVxEQvuydzedboTc20SRMpdUm98tGfTAA==", "2fa01d5b-52f5-4789-891e-e33809c96f3d", null });
        }
    }
}
