using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace oficinaAPI.Migrations
{
    /// <inheritdoc />
    public partial class Add_Column_Ativo_TipoServico_And_Config_Default_Value : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Ativo",
                table: "TiposServico",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Ativo",
                table: "TiposServico");
        }
    }
}
