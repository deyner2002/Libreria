using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CleanArchitecture.Infrastructure.Migrations
{
    public partial class updateBaseDomain : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Libros",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "Libros",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastModifiedBy",
                table: "Libros",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModifiedDate",
                table: "Libros",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Comentarios",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "Comentarios",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastModifiedBy",
                table: "Comentarios",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModifiedDate",
                table: "Comentarios",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "AutoresLibros",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "AutoresLibros",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastModifiedBy",
                table: "AutoresLibros",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModifiedDate",
                table: "AutoresLibros",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Autores",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "Autores",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastModifiedBy",
                table: "Autores",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModifiedDate",
                table: "Autores",
                type: "datetime2",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Libros");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Libros");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "Libros");

            migrationBuilder.DropColumn(
                name: "LastModifiedDate",
                table: "Libros");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Comentarios");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Comentarios");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "Comentarios");

            migrationBuilder.DropColumn(
                name: "LastModifiedDate",
                table: "Comentarios");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "AutoresLibros");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "AutoresLibros");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "AutoresLibros");

            migrationBuilder.DropColumn(
                name: "LastModifiedDate",
                table: "AutoresLibros");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Autores");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Autores");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "Autores");

            migrationBuilder.DropColumn(
                name: "LastModifiedDate",
                table: "Autores");
        }
    }
}
