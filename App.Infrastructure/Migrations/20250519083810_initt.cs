using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace App.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class initt : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Chaines",
                columns: table => new
                {
                    ChaineId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomChaine = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Thematique = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chaines", x => x.ChaineId);
                });

            migrationBuilder.CreateTable(
                name: "Utilisateurs",
                columns: table => new
                {
                    UtilisateurId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateNaissance = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NomUtilisateur = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Discriminator = table.Column<string>(type: "nvarchar(13)", maxLength: 13, nullable: false),
                    DateExpiration = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PointsFidelite = table.Column<int>(type: "int", nullable: true),
                    PubliciteActive = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Utilisateurs", x => x.UtilisateurId);
                });

            migrationBuilder.CreateTable(
                name: "Programmes",
                columns: table => new
                {
                    ProgrammeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Animateur = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Duree = table.Column<TimeSpan>(type: "time", nullable: false),
                    NomProgramme = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ChaineId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Programmes", x => x.ProgrammeId);
                    table.ForeignKey(
                        name: "FK_Programmes_Chaines_ChaineId",
                        column: x => x.ChaineId,
                        principalTable: "Chaines",
                        principalColumn: "ChaineId");
                });

            migrationBuilder.CreateTable(
                name: "Visionnages",
                columns: table => new
                {
                    DateVisionnage = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ProgrammeKey = table.Column<int>(type: "int", nullable: false),
                    UtilisateurKey = table.Column<int>(type: "int", nullable: false),
                    Favori = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Visionnages", x => new { x.ProgrammeKey, x.UtilisateurKey, x.DateVisionnage });
                    table.ForeignKey(
                        name: "FK_Visionnages_Programmes_ProgrammeKey",
                        column: x => x.ProgrammeKey,
                        principalTable: "Programmes",
                        principalColumn: "ProgrammeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Visionnages_Utilisateurs_UtilisateurKey",
                        column: x => x.UtilisateurKey,
                        principalTable: "Utilisateurs",
                        principalColumn: "UtilisateurId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Programmes_ChaineId",
                table: "Programmes",
                column: "ChaineId");

            migrationBuilder.CreateIndex(
                name: "IX_Visionnages_UtilisateurKey",
                table: "Visionnages",
                column: "UtilisateurKey");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Visionnages");

            migrationBuilder.DropTable(
                name: "Programmes");

            migrationBuilder.DropTable(
                name: "Utilisateurs");

            migrationBuilder.DropTable(
                name: "Chaines");
        }
    }
}
