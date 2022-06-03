using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace JWTbearerAuthenticationCoreWebAPI.Migrations
{
    public partial class initialize : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SecurityQuestions",
                columns: table => new
                {
                    SqId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Question = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SecurityQuestions", x => x.SqId);
                });

            migrationBuilder.CreateTable(
                name: "UserTypes",
                columns: table => new
                {
                    UserTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserTypeName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserTypes", x => x.UserTypeId);
                });

            migrationBuilder.CreateTable(
                name: "UserDetails",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserTypeId = table.Column<int>(type: "int", nullable: false),
                    FName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    LName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Dob = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SqId = table.Column<int>(type: "int", nullable: false),
                    SqAns = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserDetails", x => x.UserId);
                    table.ForeignKey(
                        name: "FK_UserDetails_SecurityQuestions_SqId",
                        column: x => x.SqId,
                        principalTable: "SecurityQuestions",
                        principalColumn: "SqId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserDetails_UserTypes_UserTypeId",
                        column: x => x.UserTypeId,
                        principalTable: "UserTypes",
                        principalColumn: "UserTypeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "SecurityQuestions",
                columns: new[] { "SqId", "Question" },
                values: new object[,]
                {
                    { 1, "What is your mother's maiden name?" },
                    { 2, "What is the name of your first pet?" },
                    { 3, "What was your first car?" },
                    { 4, "What elementary school did you attend?" },
                    { 5, "What is the name of the town where you were born?" },
                    { 6, "When you were young, what did you want to be when you grew up?" },
                    { 7, "Who was your childhood hero?" },
                    { 8, "Where was your best family vacation as a kid?" }
                });

            migrationBuilder.InsertData(
                table: "UserTypes",
                columns: new[] { "UserTypeId", "UserTypeName" },
                values: new object[,]
                {
                    { 1, "Admin" },
                    { 2, "Customer" },
                    { 3, "Vendor" }
                });

            migrationBuilder.InsertData(
                table: "UserDetails",
                columns: new[] { "UserId", "Dob", "Email", "FName", "Gender", "LName", "Password", "PhoneNumber", "SqAns", "SqId", "UserName", "UserTypeId" },
                values: new object[] { 1, new DateTime(2022, 6, 3, 11, 0, 29, 359, DateTimeKind.Local).AddTicks(9505), "aron.hawkins@aol.com", "Aaron", "Male", "Hawkins", "Arron@123", "5123456789", "Father", 7, "Aaronhawkins", 1 });

            migrationBuilder.CreateIndex(
                name: "IX_UserDetails_SqId",
                table: "UserDetails",
                column: "SqId");

            migrationBuilder.CreateIndex(
                name: "IX_UserDetails_UserTypeId",
                table: "UserDetails",
                column: "UserTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserDetails");

            migrationBuilder.DropTable(
                name: "SecurityQuestions");

            migrationBuilder.DropTable(
                name: "UserTypes");
        }
    }
}
