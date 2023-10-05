using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace estacionamento.Migrations
{
    /// <inheritdoc />
    public partial class funcionalidades_ticket_servico : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_servico_cliente_ClienteCpf",
                table: "servico");

            migrationBuilder.DropForeignKey(
                name: "FK_servico_periodo_PeriodoId",
                table: "servico");

            migrationBuilder.DropForeignKey(
                name: "FK_ticket_servico_PublicServicoId",
                table: "ticket");

            migrationBuilder.DropIndex(
                name: "IX_ticket_PublicServicoId",
                table: "ticket");

            migrationBuilder.DropColumn(
                name: "PublicServicoId",
                table: "ticket");

            migrationBuilder.RenameColumn(
                name: "PeriodoId",
                table: "servico",
                newName: "_PeriodoId");

            migrationBuilder.RenameColumn(
                name: "ClienteCpf",
                table: "servico",
                newName: "_ClienteCpf");

            migrationBuilder.RenameIndex(
                name: "IX_servico_PeriodoId",
                table: "servico",
                newName: "IX_servico__PeriodoId");

            migrationBuilder.RenameIndex(
                name: "IX_servico_ClienteCpf",
                table: "servico",
                newName: "IX_servico__ClienteCpf");

            migrationBuilder.AddColumn<int>(
                name: "TicketId",
                table: "veiculo",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ServicoId",
                table: "ticket",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "VeiculoPlaca",
                table: "ticket",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<double>(
                name: "ValorPagar",
                table: "servico",
                type: "REAL",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "REAL");

            migrationBuilder.AddColumn<int>(
                name: "ServicoId",
                table: "periodo",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TicketId",
                table: "periodo",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_veiculo_TicketId",
                table: "veiculo",
                column: "TicketId");

            migrationBuilder.CreateIndex(
                name: "IX_ticket_ServicoId",
                table: "ticket",
                column: "ServicoId");

            migrationBuilder.CreateIndex(
                name: "IX_ticket_VeiculoPlaca",
                table: "ticket",
                column: "VeiculoPlaca");

            migrationBuilder.CreateIndex(
                name: "IX_periodo_ServicoId",
                table: "periodo",
                column: "ServicoId");

            migrationBuilder.CreateIndex(
                name: "IX_periodo_TicketId",
                table: "periodo",
                column: "TicketId");

            migrationBuilder.AddForeignKey(
                name: "FK_periodo_servico_ServicoId",
                table: "periodo",
                column: "ServicoId",
                principalTable: "servico",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_periodo_ticket_TicketId",
                table: "periodo",
                column: "TicketId",
                principalTable: "ticket",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_servico_cliente__ClienteCpf",
                table: "servico",
                column: "_ClienteCpf",
                principalTable: "cliente",
                principalColumn: "Cpf");

            migrationBuilder.AddForeignKey(
                name: "FK_servico_periodo__PeriodoId",
                table: "servico",
                column: "_PeriodoId",
                principalTable: "periodo",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ticket_servico_ServicoId",
                table: "ticket",
                column: "ServicoId",
                principalTable: "servico",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ticket_veiculo_VeiculoPlaca",
                table: "ticket",
                column: "VeiculoPlaca",
                principalTable: "veiculo",
                principalColumn: "Placa",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_veiculo_ticket_TicketId",
                table: "veiculo",
                column: "TicketId",
                principalTable: "ticket",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_periodo_servico_ServicoId",
                table: "periodo");

            migrationBuilder.DropForeignKey(
                name: "FK_periodo_ticket_TicketId",
                table: "periodo");

            migrationBuilder.DropForeignKey(
                name: "FK_servico_cliente__ClienteCpf",
                table: "servico");

            migrationBuilder.DropForeignKey(
                name: "FK_servico_periodo__PeriodoId",
                table: "servico");

            migrationBuilder.DropForeignKey(
                name: "FK_ticket_servico_ServicoId",
                table: "ticket");

            migrationBuilder.DropForeignKey(
                name: "FK_ticket_veiculo_VeiculoPlaca",
                table: "ticket");

            migrationBuilder.DropForeignKey(
                name: "FK_veiculo_ticket_TicketId",
                table: "veiculo");

            migrationBuilder.DropIndex(
                name: "IX_veiculo_TicketId",
                table: "veiculo");

            migrationBuilder.DropIndex(
                name: "IX_ticket_ServicoId",
                table: "ticket");

            migrationBuilder.DropIndex(
                name: "IX_ticket_VeiculoPlaca",
                table: "ticket");

            migrationBuilder.DropIndex(
                name: "IX_periodo_ServicoId",
                table: "periodo");

            migrationBuilder.DropIndex(
                name: "IX_periodo_TicketId",
                table: "periodo");

            migrationBuilder.DropColumn(
                name: "TicketId",
                table: "veiculo");

            migrationBuilder.DropColumn(
                name: "ServicoId",
                table: "ticket");

            migrationBuilder.DropColumn(
                name: "VeiculoPlaca",
                table: "ticket");

            migrationBuilder.DropColumn(
                name: "ServicoId",
                table: "periodo");

            migrationBuilder.DropColumn(
                name: "TicketId",
                table: "periodo");

            migrationBuilder.RenameColumn(
                name: "_PeriodoId",
                table: "servico",
                newName: "PeriodoId");

            migrationBuilder.RenameColumn(
                name: "_ClienteCpf",
                table: "servico",
                newName: "ClienteCpf");

            migrationBuilder.RenameIndex(
                name: "IX_servico__PeriodoId",
                table: "servico",
                newName: "IX_servico_PeriodoId");

            migrationBuilder.RenameIndex(
                name: "IX_servico__ClienteCpf",
                table: "servico",
                newName: "IX_servico_ClienteCpf");

            migrationBuilder.AddColumn<int>(
                name: "PublicServicoId",
                table: "ticket",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "ValorPagar",
                table: "servico",
                type: "REAL",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(double),
                oldType: "REAL",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ticket_PublicServicoId",
                table: "ticket",
                column: "PublicServicoId");

            migrationBuilder.AddForeignKey(
                name: "FK_servico_cliente_ClienteCpf",
                table: "servico",
                column: "ClienteCpf",
                principalTable: "cliente",
                principalColumn: "Cpf");

            migrationBuilder.AddForeignKey(
                name: "FK_servico_periodo_PeriodoId",
                table: "servico",
                column: "PeriodoId",
                principalTable: "periodo",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ticket_servico_PublicServicoId",
                table: "ticket",
                column: "PublicServicoId",
                principalTable: "servico",
                principalColumn: "Id");
        }
    }
}
