using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookStoreApp.API.Migrations
{
    public partial class SeededDefaultUsersAndRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "74cef360-a7bc-424e-a475-49b24cac7f6b", "4f537d6a-d2e9-41db-8dbf-e556d5aca58f", "Administrator", "ADMINISTRATOR" },
                    { "f22f2c00-c3ab-41ca-ac29-505b32e276f5", "ce0beb4a-a4d6-427a-8344-592e5505a8dd", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "574c96cd-68bd-46e6-92cc-a7650bee86d8", 0, "0659edc1-b274-48a3-8f7a-3a93757ef24e", "admin@bookstore.com", false, "System", "Admin", false, null, "ADMIN@BOOKSTORE.COM", "ADMIN@BOOKSTORE.COM", "AQAAAAEAACcQAAAAELLKNnUSIwdWodKzs1ST8qt0fwiG058wXXIz0tKNoIGDTbZV0nyXmegJRsvrEtv62g==", null, false, "06c2c4e7-7c39-4631-9ba9-c7cdcfded3d0", false, "admin@bookstore.com" },
                    { "a7be9b52-35ed-45b2-932a-a40224fc6222", 0, "6fc164da-8af6-44e2-944d-8eb6452c74ff", "user@bookstore.com", false, "System", "User", false, null, "USER@BOOKSTORE.COM", "USER@BOOKSTORE.COM", "AQAAAAEAACcQAAAAEEhhwo7SYYxgbQf2IABfTj+dOhwLtxM6g0L5Rq3vqP6a29XdKlNQMhBE/DvoCRJJ8Q==", null, false, "0d7cba82-040d-4d45-b145-0a915e1bd6de", false, "user@bookstore.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "74cef360-a7bc-424e-a475-49b24cac7f6b", "574c96cd-68bd-46e6-92cc-a7650bee86d8" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "f22f2c00-c3ab-41ca-ac29-505b32e276f5", "a7be9b52-35ed-45b2-932a-a40224fc6222" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "74cef360-a7bc-424e-a475-49b24cac7f6b", "574c96cd-68bd-46e6-92cc-a7650bee86d8" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "f22f2c00-c3ab-41ca-ac29-505b32e276f5", "a7be9b52-35ed-45b2-932a-a40224fc6222" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "74cef360-a7bc-424e-a475-49b24cac7f6b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f22f2c00-c3ab-41ca-ac29-505b32e276f5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "574c96cd-68bd-46e6-92cc-a7650bee86d8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a7be9b52-35ed-45b2-932a-a40224fc6222");
        }
    }
}
