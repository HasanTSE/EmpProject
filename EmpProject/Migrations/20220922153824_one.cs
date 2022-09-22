using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmpProject.Migrations
{
    public partial class one : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EmpInfo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    NameBn = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    FathersName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    FathersNameBn = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    MothersName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    MothersNameBn = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    DOB = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Gender = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    DetectionSpot = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    NidNo = table.Column<int>(type: "int", nullable: true),
                    BirthCertifcateNo = table.Column<int>(type: "int", nullable: true),
                    DrivingLicenseNo = table.Column<int>(type: "int", nullable: true),
                    PassportNo = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    TinNo = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    CarNo = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    PresentDistrict = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    PermanentDistrict = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Resident = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Height = table.Column<decimal>(type: "decimal(18,4)", nullable: true),
                    Weight = table.Column<decimal>(type: "decimal(18,4)", nullable: true),
                    BloodGroup = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Language = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    PersonalContact = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    EmergencyContact = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmpInfo", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmpInfo");
        }
    }
}
