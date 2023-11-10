using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace gestimmo_WPF.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Prestataires",
                columns: table => new
                {
                    PrestataireId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    RaisonSociale = table.Column<string>(type: "text", nullable: false),
                    Nom = table.Column<string>(type: "text", nullable: false),
                    Prenom = table.Column<string>(type: "text", nullable: false),
                    Telephone = table.Column<string>(type: "text", nullable: false),
                    Adresse = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prestataires", x => x.PrestataireId);
                });

            migrationBuilder.CreateTable(
                name: "Prets",
                columns: table => new
                {
                    PretId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    TauxInteret = table.Column<double>(type: "double precision", nullable: false),
                    MontantPret = table.Column<double>(type: "double precision", nullable: false),
                    Duree = table.Column<int>(type: "integer", nullable: false),
                    Apport = table.Column<double>(type: "double precision", nullable: false),
                    DateDebut = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prets", x => x.PretId);
                });

            migrationBuilder.CreateTable(
                name: "Biens",
                columns: table => new
                {
                    BienId = table.Column<int>(type: "integer", nullable: false),
                    Valeur = table.Column<double>(type: "double precision", nullable: false),
                    Surface = table.Column<double>(type: "double precision", nullable: false),
                    Adresse = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Biens", x => x.BienId);
                    table.ForeignKey(
                        name: "FK_Biens_Prets_BienId",
                        column: x => x.BienId,
                        principalTable: "Prets",
                        principalColumn: "PretId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Bails",
                columns: table => new
                {
                    ContratId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Loyer = table.Column<double>(type: "double precision", nullable: false),
                    DateDebut = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    DateFin = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    BienId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bails", x => x.ContratId);
                    table.ForeignKey(
                        name: "FK_Bails_Biens_BienId",
                        column: x => x.BienId,
                        principalTable: "Biens",
                        principalColumn: "BienId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Box",
                columns: table => new
                {
                    BienId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Box", x => x.BienId);
                    table.ForeignKey(
                        name: "FK_Box_Biens_BienId",
                        column: x => x.BienId,
                        principalTable: "Biens",
                        principalColumn: "BienId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Habitable",
                columns: table => new
                {
                    BienId = table.Column<int>(type: "integer", nullable: false),
                    HabitableId = table.Column<int>(type: "integer", nullable: false),
                    NbChambre = table.Column<int>(type: "integer", nullable: false),
                    NbPiece = table.Column<int>(type: "integer", nullable: false),
                    Parking = table.Column<bool>(type: "boolean", nullable: false),
                    Cave = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Habitable", x => x.BienId);
                    table.ForeignKey(
                        name: "FK_Habitable_Biens_BienId",
                        column: x => x.BienId,
                        principalTable: "Biens",
                        principalColumn: "BienId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Interventions",
                columns: table => new
                {
                    InterventionId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    MontantTTC = table.Column<double>(type: "double precision", nullable: false),
                    Information = table.Column<string>(type: "text", nullable: false),
                    BienId = table.Column<int>(type: "integer", nullable: false),
                    PrestataireId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Interventions", x => x.InterventionId);
                    table.ForeignKey(
                        name: "FK_Interventions_Biens_BienId",
                        column: x => x.BienId,
                        principalTable: "Biens",
                        principalColumn: "BienId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Interventions_Prestataires_PrestataireId",
                        column: x => x.PrestataireId,
                        principalTable: "Prestataires",
                        principalColumn: "PrestataireId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Locataires",
                columns: table => new
                {
                    LocataireId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Nom = table.Column<string>(type: "text", nullable: false),
                    Prenom = table.Column<string>(type: "text", nullable: false),
                    Profession = table.Column<string>(type: "text", nullable: false),
                    Age = table.Column<int>(type: "integer", nullable: false),
                    BailContratId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locataires", x => x.LocataireId);
                    table.ForeignKey(
                        name: "FK_Locataires_Bails_BailContratId",
                        column: x => x.BailContratId,
                        principalTable: "Bails",
                        principalColumn: "ContratId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Appartement",
                columns: table => new
                {
                    BienId = table.Column<int>(type: "integer", nullable: false),
                    AppartementId = table.Column<int>(type: "integer", nullable: false),
                    Etage = table.Column<int>(type: "integer", nullable: false),
                    Ascenseur = table.Column<bool>(type: "boolean", nullable: false),
                    ChauffageCommun = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Appartement", x => x.BienId);
                    table.ForeignKey(
                        name: "FK_Appartement_Habitable_BienId",
                        column: x => x.BienId,
                        principalTable: "Habitable",
                        principalColumn: "BienId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Maison",
                columns: table => new
                {
                    BienId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Maison", x => x.BienId);
                    table.ForeignKey(
                        name: "FK_Maison_Habitable_BienId",
                        column: x => x.BienId,
                        principalTable: "Habitable",
                        principalColumn: "BienId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Bails_BienId",
                table: "Bails",
                column: "BienId");

            migrationBuilder.CreateIndex(
                name: "IX_Interventions_BienId",
                table: "Interventions",
                column: "BienId");

            migrationBuilder.CreateIndex(
                name: "IX_Interventions_PrestataireId",
                table: "Interventions",
                column: "PrestataireId");

            migrationBuilder.CreateIndex(
                name: "IX_Locataires_BailContratId",
                table: "Locataires",
                column: "BailContratId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Appartement");

            migrationBuilder.DropTable(
                name: "Box");

            migrationBuilder.DropTable(
                name: "Interventions");

            migrationBuilder.DropTable(
                name: "Locataires");

            migrationBuilder.DropTable(
                name: "Maison");

            migrationBuilder.DropTable(
                name: "Prestataires");

            migrationBuilder.DropTable(
                name: "Bails");

            migrationBuilder.DropTable(
                name: "Habitable");

            migrationBuilder.DropTable(
                name: "Biens");

            migrationBuilder.DropTable(
                name: "Prets");
        }
    }
}
