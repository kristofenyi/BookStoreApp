using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookStoreApp.API.Migrations
{
    public partial class SeededDefaultUserandRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "15e0b093-78d0-4b46-9501-159bf6681aa7", "81889fe9-df5a-4ac4-b324-f4fcc98ae484", "User", "USER" },
                    { "c7937a54-9d66-434d-ad1a-b8d9b37f9ae6", "1943b07e-d32d-46c7-86fc-49bc96aaed6c", "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "937bf844-4609-4102-81d7-406b954feb9e", 0, "dc1dfb06-59d4-467d-81b5-60f9072a8ebd", "admin@bookstore.com", false, "System", "Admin", false, null, "ADMIN@BOOKSTORE.COM", "ADMIN@BOOKSTORE.COM", "AQAAAAEAACcQAAAAEAe9pRPIz7MlFfIfP5iCYVE8rODr2RmiPxJPo5o5HNCcnxLGFMMzzxH8ZqxRfF/ewQ==", null, false, "6039bb00-4857-46e1-8bd4-e4239f331e0f", false, "admin@bookstore.com" },
                    { "ce691dfa-e670-4183-8c1d-36b522fa371b", 0, "9ee4f054-e01a-4315-83a1-d677aa7244d1", "user@bookstore.com", false, "System", "User", false, null, "USER@BOOKSTORE.COM", "USER@BOOKSTORE.COM", "AQAAAAEAACcQAAAAEF+V2ereEXfpOSIKh1Z/MOfctEkweoTI74O3aTOBU0g1nyby5BQdtDzY2YRdokVAuw==", null, false, "9f6042bb-63fa-4d5a-b3b2-b9e0519a526b", false, "user@bookstore.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "c7937a54-9d66-434d-ad1a-b8d9b37f9ae6", "937bf844-4609-4102-81d7-406b954feb9e" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "15e0b093-78d0-4b46-9501-159bf6681aa7", "ce691dfa-e670-4183-8c1d-36b522fa371b" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "c7937a54-9d66-434d-ad1a-b8d9b37f9ae6", "937bf844-4609-4102-81d7-406b954feb9e" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "15e0b093-78d0-4b46-9501-159bf6681aa7", "ce691dfa-e670-4183-8c1d-36b522fa371b" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "15e0b093-78d0-4b46-9501-159bf6681aa7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c7937a54-9d66-434d-ad1a-b8d9b37f9ae6");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "937bf844-4609-4102-81d7-406b954feb9e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ce691dfa-e670-4183-8c1d-36b522fa371b");
        }
    }
}
