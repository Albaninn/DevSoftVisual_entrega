using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace estacionamento.Migrations
{
    /// <inheritdoc />
    public partial class AlteradasKeys : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ClienteCpf",
                table: "veiculo",
                type: "TEXT",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "cliente",
                columns: table => new
                {
                    Cpf = table.Column<string>(type: "TEXT", nullable: false),
                    Id = table.Column<int>(type: "INTEGER", nullable: true),
                    Nome = table.Column<string>(type: "TEXT", nullable: true),
                    Email = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cliente", x => x.Cpf);
                });

            migrationBuilder.CreateIndex(
                name: "IX_veiculo_ClienteCpf",
                table: "veiculo",
                column: "ClienteCpf");

            migrationBuilder.AddForeignKey(
                name: "FK_veiculo_cliente_ClienteCpf",
                table: "veiculo",
                column: "ClienteCpf",
                principalTable: "cliente",
                principalColumn: "Cpf");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_veiculo_cliente_ClienteCpf",
                table: "veiculo");

            migrationBuilder.DropTable(
                name: "cliente");

            migrationBuilder.DropIndex(
                name: "IX_veiculo_ClienteCpf",
                table: "veiculo");

            migrationBuilder.DropColumn(
                name: "ClienteCpf",
                table: "veiculo");
        }
    }
}
