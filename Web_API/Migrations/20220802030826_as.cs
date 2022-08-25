using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Web_API.Migrations
{
    public partial class @as : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Nghanh",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ma = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TenNghanh = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nghanh", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Truong",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ma = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TenTruong = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Truong", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MonHoc",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ma = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TenMon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdNghanh = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MonHoc", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MonHoc_Nghanh_IdNghanh",
                        column: x => x.IdNghanh,
                        principalTable: "Nghanh",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Lop",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ma = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TenLop = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdTruong = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lop", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Lop_Truong_IdTruong",
                        column: x => x.IdTruong,
                        principalTable: "Truong",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Diem",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ma = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SoDiem = table.Column<float>(type: "real", nullable: false),
                    IdMonhoc = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Diem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Diem_MonHoc_IdMonhoc",
                        column: x => x.IdMonhoc,
                        principalTable: "MonHoc",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SinhVien",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaSV = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ho = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TenDem = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ten = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NgaySinh = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PassWord = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdLop = table.Column<int>(type: "int", nullable: false),
                    IdNghanh = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SinhVien", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SinhVien_Lop_IdLop",
                        column: x => x.IdLop,
                        principalTable: "Lop",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SinhVien_Nghanh_IdNghanh",
                        column: x => x.IdNghanh,
                        principalTable: "Nghanh",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Diem_IdMonhoc",
                table: "Diem",
                column: "IdMonhoc");

            migrationBuilder.CreateIndex(
                name: "IX_Lop_IdTruong",
                table: "Lop",
                column: "IdTruong");

            migrationBuilder.CreateIndex(
                name: "IX_MonHoc_IdNghanh",
                table: "MonHoc",
                column: "IdNghanh");

            migrationBuilder.CreateIndex(
                name: "IX_SinhVien_IdLop",
                table: "SinhVien",
                column: "IdLop");

            migrationBuilder.CreateIndex(
                name: "IX_SinhVien_IdNghanh",
                table: "SinhVien",
                column: "IdNghanh");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Diem");

            migrationBuilder.DropTable(
                name: "SinhVien");

            migrationBuilder.DropTable(
                name: "MonHoc");

            migrationBuilder.DropTable(
                name: "Lop");

            migrationBuilder.DropTable(
                name: "Nghanh");

            migrationBuilder.DropTable(
                name: "Truong");
        }
    }
}
