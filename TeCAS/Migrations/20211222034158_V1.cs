using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TeCAS.Migrations
{
    public partial class V1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cliente",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NumeroDeIdentificacion = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Clabe = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    UsuarioId = table.Column<int>(type: "int", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Paterno = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Materno = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Rfc = table.Column<string>(type: "nvarchar(13)", maxLength: 13, nullable: false),
                    Usuario = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Contrasenia = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    FechaDeRegistro = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cliente", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CuentaDeAhorro",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClienteId = table.Column<int>(type: "int", nullable: false),
                    NumeroDeCuenta = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SaldoActual = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    FechaDeRegistro = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaDeBaja = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EstaActivo = table.Column<bool>(type: "bit", nullable: false),
                    UsuarioId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CuentaDeAhorro", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CuentaDeAhorroDetalle",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CuentaDeAhorroId = table.Column<int>(type: "int", nullable: false),
                    Monto = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TransaccionId = table.Column<int>(type: "int", nullable: false),
                    FechaDeRegistro = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UsuarioId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CuentaDeAhorroDetalle", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CuentaDeAhorroTransaccion",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CuentaDeAhorroTransaccion", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NumeroDeEmpleado = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Paterno = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Materno = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Rfc = table.Column<string>(type: "nvarchar(13)", maxLength: 13, nullable: false),
                    Usuario = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Contrasenia = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    FechaDeRegistro = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "CuentaDeAhorroTransaccion",
                columns: new[] { "Id", "Descripcion", "Nombre" },
                values: new object[] { 1, null, "Depósito" });

            migrationBuilder.InsertData(
                table: "CuentaDeAhorroTransaccion",
                columns: new[] { "Id", "Descripcion", "Nombre" },
                values: new object[] { 2, null, "Retiro" });

            migrationBuilder.InsertData(
                table: "Usuario",
                columns: new[] { "Id", "Contrasenia", "FechaDeRegistro", "Materno", "Nombre", "NumeroDeEmpleado", "Paterno", "Rfc", "Usuario" },
                values: new object[] { 1, "123456", new DateTime(2021, 12, 21, 21, 41, 58, 164, DateTimeKind.Local).AddTicks(3687), null, "Víctor", "202101", "Martínez", "MABV8412056TA", "vmartinez" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cliente");

            migrationBuilder.DropTable(
                name: "CuentaDeAhorro");

            migrationBuilder.DropTable(
                name: "CuentaDeAhorroDetalle");

            migrationBuilder.DropTable(
                name: "CuentaDeAhorroTransaccion");

            migrationBuilder.DropTable(
                name: "Usuario");
        }
    }
}
