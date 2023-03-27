using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagementWeb.Data.Migrations
{
    public partial class AddedLeaveRequestTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LeaveRequests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LeaveTypeId = table.Column<int>(type: "int", nullable: false),
                    DateRquested = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RequestComments = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Approved = table.Column<bool>(type: "bit", nullable: true),
                    Cancelled = table.Column<bool>(type: "bit", nullable: false),
                    RequestingEmployeeId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeaveRequests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LeaveRequests_LeaveTypes_LeaveTypeId",
                        column: x => x.LeaveTypeId,
                        principalTable: "LeaveTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_LeaveRequests_LeaveTypeId",
                table: "LeaveRequests",
                column: "LeaveTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LeaveRequests");

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
    }
}
