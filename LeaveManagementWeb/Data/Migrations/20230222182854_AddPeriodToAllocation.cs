using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagementWeb.Data.Migrations
{
    public partial class AddPeriodToAllocation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Period",
                table: "LeaveAllocations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "966abaa5 - fc9d - 47c0 - b129 - 5fb8ce7bd950",
                column: "ConcurrencyStamp",
                value: "52a39bee-3ab0-4dab-b56a-697a2af49c70");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fb6e2be8-433a-4aa8-a370-940f8c528e61",
                column: "ConcurrencyStamp",
                value: "5195896b-4b18-4688-99e9-a9791edfcfd5");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9470d59e-dab9-4543-8ea6-9773b55e0512",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1eefef97-6b80-49d2-b8f5-0a73f69e3629", "AQAAAAEAACcQAAAAEKPZjdO0+MLZUzbHvwflJLxGBif93kAdXb0AqWML/tBbBc6/MgYtEQjHmAOTjpUxMA==", "0a294f0c-5512-4bd6-b1df-52cebc9723d9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "966abaa5 - fc9d - 47c0 - b129 - 5fb8ce7bd950",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f7620c42-bf78-4a13-91d0-fb6cf18ca570", "AQAAAAEAACcQAAAAENC500gCJ+hgEgyEz5hBcmD6IwSk+ik9bouTYwTsrrtP7uYgNCftmae5DiwYRtCT4w==", "d73dd69e-4515-46d9-bcc8-7096279fabc9" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Period",
                table: "LeaveAllocations");

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
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f9cf812a-7c82-47f9-9d31-bd219edb6155", "AQAAAAEAACcQAAAAENuLuGCBS+MLBsvaTnyOFZ4ZUiFpbe55LQBFH4P97spMK0cL6hMCHM3o73+vcu4l6g==", "f7ba3a76-4b35-4b1f-bf1b-6a739615925d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "966abaa5 - fc9d - 47c0 - b129 - 5fb8ce7bd950",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1b3d8bdc-acb9-427f-9f35-9cb0bca1eba4", "AQAAAAEAACcQAAAAEA4kURXQvND3AdAXz9Nr/4xZ4dPwj968ILBQB7gYr5G97HFcbatgIfLOSH1R+3SLyQ==", "946000b8-d84e-4841-8240-766ad7362bd7" });
        }
    }
}
