using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Rose_ASP.Migrations
{
    /// <inheritdoc />
    public partial class NoCountry : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CountryDatas_Countries_CountryId",
                table: "CountryDatas");

            migrationBuilder.DropIndex(
                name: "IX_CountryDatas_CountryId",
                table: "CountryDatas");

            migrationBuilder.DropColumn(
                name: "CountryId",
                table: "CountryDatas");

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "CountryDatas",
                type: "uuid",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddColumn<string>(
                name: "CountryName",
                table: "CountryDatas",
                type: "text",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CountryName",
                table: "CountryDatas");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "CountryDatas",
                type: "integer",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uuid")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddColumn<int>(
                name: "CountryId",
                table: "CountryDatas",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_CountryDatas_CountryId",
                table: "CountryDatas",
                column: "CountryId");

            migrationBuilder.AddForeignKey(
                name: "FK_CountryDatas_Countries_CountryId",
                table: "CountryDatas",
                column: "CountryId",
                principalTable: "Countries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
