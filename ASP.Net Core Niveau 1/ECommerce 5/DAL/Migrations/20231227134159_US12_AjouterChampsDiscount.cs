using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    /// <inheritdoc />
    public partial class US12_AjouterChampsDiscount : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "EstDispo",
                table: "T_Produit",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "EstRemise",
                table: "T_Produit",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "Note",
                table: "T_Produit",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<decimal>(
                name: "RemiseEnDh",
                table: "T_Produit",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EstDispo",
                table: "T_Produit");

            migrationBuilder.DropColumn(
                name: "EstRemise",
                table: "T_Produit");

            migrationBuilder.DropColumn(
                name: "Note",
                table: "T_Produit");

            migrationBuilder.DropColumn(
                name: "RemiseEnDh",
                table: "T_Produit");
        }
    }
}
