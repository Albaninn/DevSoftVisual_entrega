using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace estacionamento.Migrations
{
    /// <inheritdoc />
    public partial class AlteradasTabelas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Bau",
                table: "veiculo",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Caminhonete_NroPortas",
                table: "veiculo",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Combustivel",
                table: "veiculo",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CorExterna",
                table: "veiculo",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "veiculo",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "ModeloId",
                table: "veiculo",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "NroPortas",
                table: "veiculo",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Marca",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    DescricaoMarca = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Marca", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Modelo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    DescricaoModelo = table.Column<string>(type: "TEXT", nullable: true),
                    MarcaId = table.Column<int>(type: "INTEGER", nullable: true),
                    Porte = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Modelo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Modelo_Marca_MarcaId",
                        column: x => x.MarcaId,
                        principalTable: "Marca",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_veiculo_ModeloId",
                table: "veiculo",
                column: "ModeloId");

            migrationBuilder.CreateIndex(
                name: "IX_Modelo_MarcaId",
                table: "Modelo",
                column: "MarcaId");

            migrationBuilder.AddForeignKey(
                name: "FK_veiculo_Modelo_ModeloId",
                table: "veiculo",
                column: "ModeloId",
                principalTable: "Modelo",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_veiculo_Modelo_ModeloId",
                table: "veiculo");

            migrationBuilder.DropTable(
                name: "Modelo");

            migrationBuilder.DropTable(
                name: "Marca");

            migrationBuilder.DropIndex(
                name: "IX_veiculo_ModeloId",
                table: "veiculo");

            migrationBuilder.DropColumn(
                name: "Bau",
                table: "veiculo");

            migrationBuilder.DropColumn(
                name: "Caminhonete_NroPortas",
                table: "veiculo");

            migrationBuilder.DropColumn(
                name: "Combustivel",
                table: "veiculo");

            migrationBuilder.DropColumn(
                name: "CorExterna",
                table: "veiculo");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "veiculo");

            migrationBuilder.DropColumn(
                name: "ModeloId",
                table: "veiculo");

            migrationBuilder.DropColumn(
                name: "NroPortas",
                table: "veiculo");
        }
    }
}
