using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagementWeb.Data.Migrations
{
    public partial class UpdatedRequestComments : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "RequestComments",
                table: "LeaveRequests",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "966abaa5 - fc9d - 47c0 - b129 - 5fb8ce7bd950",
                column: "ConcurrencyStamp",
                value: "b540e895-bcda-42e9-b4a8-332e66cca4ab");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fb6e2be8-433a-4aa8-a370-940f8c528e61",
                column: "ConcurrencyStamp",
                value: "f8aed759-9e91-4e72-9707-b92e6ef45e1c");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9470d59e-dab9-4543-8ea6-9773b55e0512",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e91a3c41-efee-462b-a4c3-24e476f0656a", "AQAAAAEAACcQAAAAEMn5ZU3mSIFEXFerV5tqpoHo74cJ7ifX03by2PjadWOd89MDSPygLUOYLosyWiZOcw==", "bf2e9cb6-8f5b-4ec5-b961-0c5da74dcee6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "966abaa5 - fc9d - 47c0 - b129 - 5fb8ce7bd950",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6a4605d1-79d2-48cf-8eb6-beb449cd0674", "AQAAAAEAACcQAAAAECMLTI6MAlFpLx5cE5uG6ExH0hn+kcMaD8RoKHXiTeZNLCuo3DUaA3B1rSzbms5B9A==", "d3c0b467-fab2-4a33-807f-e2f50305b55d" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "RequestComments",
                table: "LeaveRequests",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "966abaa5 - fc9d - 47c0 - b129 - 5fb8ce7bd950",
                column: "ConcurrencyStamp",
                value: "850ab639-b52f-474f-a48f-a810573d41a6");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fb6e2be8-433a-4aa8-a370-940f8c528e61",
                column: "ConcurrencyStamp",
                value: "0a991dc3-1e1b-4639-b32e-af89f20df1b1");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9470d59e-dab9-4543-8ea6-9773b55e0512",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2db58f03-5902-4627-9d16-42bc8f2b7562", "AQAAAAEAACcQAAAAENxUiCEU6GHYS/7VFSarEhXz2eO2A/hNxE69hKUKvHwOjvLE8wlGowTUToS/G4gWRQ==", "45d9d714-680f-4570-843a-eb4255b9d961" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "966abaa5 - fc9d - 47c0 - b129 - 5fb8ce7bd950",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "560924f5-2cad-4093-8885-7d530584bf78", "AQAAAAEAACcQAAAAEI/8PSHuTUc+SSBFiUB9irE89jWb/oRWIvW6+0b3wSBRzBnLCg0Ql3/kkz8u53ClFA==", "3a6e86ea-858b-4dfd-afaa-3ce12b4627f4" });
        }
    }
}
