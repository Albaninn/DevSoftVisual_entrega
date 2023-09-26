using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace estacionamento.Migrations
{
    /// <inheritdoc />
    public partial class NovasTabelas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_veiculo_Modelo_ModeloId",
                table: "veiculo");

            migrationBuilder.DropTable(
                name: "Modelo");

            migrationBuilder.DropTable(
                name: "Marca");

            migrationBuilder.DropTable(
                name: "Tamanho");

            migrationBuilder.DropPrimaryKey(
                name: "PK_veiculo",
                table: "veiculo");

            migrationBuilder.DropIndex(
                name: "IX_veiculo_ModeloId",
                table: "veiculo");

            migrationBuilder.DropColumn(
                name: "ModeloId",
                table: "veiculo");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "veiculo",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true)
                .Annotation("Sqlite:Autoincrement", true);

            migrationBuilder.AlterColumn<string>(
                name: "Placa",
                table: "veiculo",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AddPrimaryKey(
                name: "PK_veiculo",
                table: "veiculo",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_veiculo",
                table: "veiculo");

            migrationBuilder.AlterColumn<string>(
                name: "Placa",
                table: "veiculo",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "veiculo",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .OldAnnotation("Sqlite:Autoincrement", true);

            migrationBuilder.AddColumn<int>(
                name: "ModeloId",
                table: "veiculo",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_veiculo",
                table: "veiculo",
                column: "Placa");

            migrationBuilder.CreateTable(
                name: "Marca",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Descricao = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Marca", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tamanho",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Descricao = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tamanho", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Modelo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    MarcaId = table.Column<int>(type: "INTEGER", nullable: true),
                    TamanhoId = table.Column<int>(type: "INTEGER", nullable: true),
                    Descricao = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Modelo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Modelo_Marca_MarcaId",
                        column: x => x.MarcaId,
                        principalTable: "Marca",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Modelo_Tamanho_TamanhoId",
                        column: x => x.TamanhoId,
                        principalTable: "Tamanho",
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

            migrationBuilder.CreateIndex(
                name: "IX_Modelo_TamanhoId",
                table: "Modelo",
                column: "TamanhoId");

            migrationBuilder.AddForeignKey(
                name: "FK_veiculo_Modelo_ModeloId",
                table: "veiculo",
                column: "ModeloId",
                principalTable: "Modelo",
                principalColumn: "Id");
        }
    }
}
