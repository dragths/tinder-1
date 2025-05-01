using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace tinder_1.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "public");

            migrationBuilder.CreateTable(
                name: "BadHabitsAttitudes",
                schema: "public",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BadHabitsAttitudes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cities",
                schema: "public",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FilmGenres",
                schema: "public",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FilmGenres", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Genders",
                schema: "public",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Hobbies",
                schema: "public",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hobbies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MusicGenres",
                schema: "public",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MusicGenres", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                schema: "public",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Login = table.Column<string>(type: "text", nullable: false),
                    Password = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserProfiles",
                schema: "public",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserId = table.Column<int>(type: "integer", nullable: false),
                    UserId1 = table.Column<int>(type: "integer", nullable: false),
                    Name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    GenderId = table.Column<int>(type: "integer", nullable: true),
                    GenderId1 = table.Column<int>(type: "integer", nullable: false),
                    BirthDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CityId = table.Column<int>(type: "integer", nullable: true),
                    CityId1 = table.Column<int>(type: "integer", nullable: false),
                    PhotoPath = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: false),
                    HobbyId = table.Column<int>(type: "integer", nullable: true),
                    HobbyId1 = table.Column<int>(type: "integer", nullable: false),
                    MusicGenreId = table.Column<int>(type: "integer", nullable: true),
                    MusicGenreId1 = table.Column<int>(type: "integer", nullable: false),
                    FilmGenreId = table.Column<int>(type: "integer", nullable: true),
                    FilmGenreId1 = table.Column<int>(type: "integer", nullable: false),
                    BadHabitsAttitudeId = table.Column<int>(type: "integer", nullable: true),
                    BadHabitsAttitudeId1 = table.Column<int>(type: "integer", nullable: false),
                    AboutMe = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserProfiles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserProfiles_BadHabitsAttitudes_BadHabitsAttitudeId",
                        column: x => x.BadHabitsAttitudeId,
                        principalSchema: "public",
                        principalTable: "BadHabitsAttitudes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_UserProfiles_BadHabitsAttitudes_BadHabitsAttitudeId1",
                        column: x => x.BadHabitsAttitudeId1,
                        principalSchema: "public",
                        principalTable: "BadHabitsAttitudes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserProfiles_Cities_CityId",
                        column: x => x.CityId,
                        principalSchema: "public",
                        principalTable: "Cities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_UserProfiles_Cities_CityId1",
                        column: x => x.CityId1,
                        principalSchema: "public",
                        principalTable: "Cities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserProfiles_FilmGenres_FilmGenreId",
                        column: x => x.FilmGenreId,
                        principalSchema: "public",
                        principalTable: "FilmGenres",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_UserProfiles_FilmGenres_FilmGenreId1",
                        column: x => x.FilmGenreId1,
                        principalSchema: "public",
                        principalTable: "FilmGenres",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserProfiles_Genders_GenderId",
                        column: x => x.GenderId,
                        principalSchema: "public",
                        principalTable: "Genders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_UserProfiles_Genders_GenderId1",
                        column: x => x.GenderId1,
                        principalSchema: "public",
                        principalTable: "Genders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserProfiles_Hobbies_HobbyId",
                        column: x => x.HobbyId,
                        principalSchema: "public",
                        principalTable: "Hobbies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_UserProfiles_Hobbies_HobbyId1",
                        column: x => x.HobbyId1,
                        principalSchema: "public",
                        principalTable: "Hobbies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserProfiles_MusicGenres_MusicGenreId",
                        column: x => x.MusicGenreId,
                        principalSchema: "public",
                        principalTable: "MusicGenres",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_UserProfiles_MusicGenres_MusicGenreId1",
                        column: x => x.MusicGenreId1,
                        principalSchema: "public",
                        principalTable: "MusicGenres",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserProfiles_Users_UserId",
                        column: x => x.UserId,
                        principalSchema: "public",
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserProfiles_Users_UserId1",
                        column: x => x.UserId1,
                        principalSchema: "public",
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserProfiles_BadHabitsAttitudeId",
                schema: "public",
                table: "UserProfiles",
                column: "BadHabitsAttitudeId");

            migrationBuilder.CreateIndex(
                name: "IX_UserProfiles_BadHabitsAttitudeId1",
                schema: "public",
                table: "UserProfiles",
                column: "BadHabitsAttitudeId1");

            migrationBuilder.CreateIndex(
                name: "IX_UserProfiles_CityId",
                schema: "public",
                table: "UserProfiles",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_UserProfiles_CityId1",
                schema: "public",
                table: "UserProfiles",
                column: "CityId1");

            migrationBuilder.CreateIndex(
                name: "IX_UserProfiles_FilmGenreId",
                schema: "public",
                table: "UserProfiles",
                column: "FilmGenreId");

            migrationBuilder.CreateIndex(
                name: "IX_UserProfiles_FilmGenreId1",
                schema: "public",
                table: "UserProfiles",
                column: "FilmGenreId1");

            migrationBuilder.CreateIndex(
                name: "IX_UserProfiles_GenderId",
                schema: "public",
                table: "UserProfiles",
                column: "GenderId");

            migrationBuilder.CreateIndex(
                name: "IX_UserProfiles_GenderId1",
                schema: "public",
                table: "UserProfiles",
                column: "GenderId1");

            migrationBuilder.CreateIndex(
                name: "IX_UserProfiles_HobbyId",
                schema: "public",
                table: "UserProfiles",
                column: "HobbyId");

            migrationBuilder.CreateIndex(
                name: "IX_UserProfiles_HobbyId1",
                schema: "public",
                table: "UserProfiles",
                column: "HobbyId1");

            migrationBuilder.CreateIndex(
                name: "IX_UserProfiles_MusicGenreId",
                schema: "public",
                table: "UserProfiles",
                column: "MusicGenreId");

            migrationBuilder.CreateIndex(
                name: "IX_UserProfiles_MusicGenreId1",
                schema: "public",
                table: "UserProfiles",
                column: "MusicGenreId1");

            migrationBuilder.CreateIndex(
                name: "IX_UserProfiles_UserId",
                schema: "public",
                table: "UserProfiles",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserProfiles_UserId1",
                schema: "public",
                table: "UserProfiles",
                column: "UserId1");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserProfiles",
                schema: "public");

            migrationBuilder.DropTable(
                name: "BadHabitsAttitudes",
                schema: "public");

            migrationBuilder.DropTable(
                name: "Cities",
                schema: "public");

            migrationBuilder.DropTable(
                name: "FilmGenres",
                schema: "public");

            migrationBuilder.DropTable(
                name: "Genders",
                schema: "public");

            migrationBuilder.DropTable(
                name: "Hobbies",
                schema: "public");

            migrationBuilder.DropTable(
                name: "MusicGenres",
                schema: "public");

            migrationBuilder.DropTable(
                name: "Users",
                schema: "public");
        }
    }
}
