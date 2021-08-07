using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace api.Migrations
{
    public partial class oBotFactory001 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Armors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    PenaltyValue = table.Column<int>(type: "integer", nullable: false),
                    PanaltyDescription = table.Column<string>(type: "text", nullable: true),
                    BonusValue = table.Column<int>(type: "integer", nullable: false),
                    BonusDescription = table.Column<string>(type: "text", nullable: true),
                    RegisterDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true),
                    Weight = table.Column<int>(type: "integer", nullable: false),
                    Type = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Armors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Capabilities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    RegisterDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Capabilities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Disadvantages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    RegisterDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Disadvantages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Items",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    EffectValue = table.Column<int>(type: "integer", nullable: false),
                    EffectDescription = table.Column<string>(type: "text", nullable: true),
                    RegisterDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true),
                    Weight = table.Column<int>(type: "integer", nullable: false),
                    Type = table.Column<string>(type: "text", nullable: true),
                    DifficultyValue = table.Column<int>(type: "integer", nullable: false),
                    DifficultyDescription = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Skills",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    RegisterDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Skills", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Username = table.Column<string>(type: "text", nullable: false),
                    RegisterDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Weapons",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Damage = table.Column<int>(type: "integer", nullable: false),
                    RegisterDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true),
                    Weight = table.Column<int>(type: "integer", nullable: false),
                    Type = table.Column<string>(type: "text", nullable: true),
                    DifficultyValue = table.Column<int>(type: "integer", nullable: false),
                    DifficultyDescription = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Weapons", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MSs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    PlayerId = table.Column<int>(type: "integer", nullable: false),
                    CharacterName = table.Column<string>(type: "text", nullable: true),
                    Age = table.Column<int>(type: "integer", nullable: false),
                    Archetype = table.Column<string>(type: "text", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true),
                    WeightCapacity = table.Column<int>(type: "integer", nullable: false),
                    HealthPoints = table.Column<int>(type: "integer", nullable: false),
                    Annotations = table.Column<string>(type: "text", nullable: true),
                    Experience = table.Column<int>(type: "integer", nullable: false),
                    Level = table.Column<int>(type: "integer", nullable: false),
                    PhysicalTestDiceQuantity = table.Column<int>(type: "integer", nullable: false),
                    PhysicalTestDiceFaceQuantity = table.Column<int>(type: "integer", nullable: false),
                    MentalTestDiceQuantity = table.Column<int>(type: "integer", nullable: false),
                    MentalTestDiceFaceQuantity = table.Column<int>(type: "integer", nullable: false),
                    GenericTestDiceLabel = table.Column<string>(type: "text", nullable: true),
                    GenericTestDiceQuantity = table.Column<int>(type: "integer", nullable: false),
                    GenericTestDiceFaceQuantity = table.Column<int>(type: "integer", nullable: false),
                    GenericAdvantageLabel = table.Column<string>(type: "text", nullable: true),
                    RegisterDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MSs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MSs_Users_PlayerId",
                        column: x => x.PlayerId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GenericAdvantages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    MSId = table.Column<int>(type: "integer", nullable: true),
                    RegisterDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GenericAdvantages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GenericAdvantages_MSs_MSId",
                        column: x => x.MSId,
                        principalTable: "MSs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SheetArmors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ArmorId = table.Column<int>(type: "integer", nullable: false),
                    Equipped = table.Column<bool>(type: "boolean", nullable: false),
                    RegisterDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    TestValue = table.Column<int>(type: "integer", nullable: false),
                    MSId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SheetArmors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SheetArmors_Items_ArmorId",
                        column: x => x.ArmorId,
                        principalTable: "Items",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SheetArmors_MSs_MSId",
                        column: x => x.MSId,
                        principalTable: "MSs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SheetCapabilties",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CapabilityId = table.Column<int>(type: "integer", nullable: false),
                    RegisterDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    TestValue = table.Column<int>(type: "integer", nullable: false),
                    MSId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SheetCapabilties", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SheetCapabilties_Capabilities_CapabilityId",
                        column: x => x.CapabilityId,
                        principalTable: "Capabilities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SheetCapabilties_MSs_MSId",
                        column: x => x.MSId,
                        principalTable: "MSs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SheetDisadvantages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    DisadvantageId = table.Column<int>(type: "integer", nullable: false),
                    ModifierValue = table.Column<int>(type: "integer", nullable: true),
                    TestDiceQuantity = table.Column<int>(type: "integer", nullable: true),
                    TestDiceFaceQuantity = table.Column<int>(type: "integer", nullable: true),
                    RegisterDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    TestValue = table.Column<int>(type: "integer", nullable: false),
                    MSId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SheetDisadvantages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SheetDisadvantages_Disadvantages_DisadvantageId",
                        column: x => x.DisadvantageId,
                        principalTable: "Disadvantages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SheetDisadvantages_MSs_MSId",
                        column: x => x.MSId,
                        principalTable: "MSs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SheetItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ItemId = table.Column<int>(type: "integer", nullable: false),
                    Equipped = table.Column<bool>(type: "boolean", nullable: false),
                    RegisterDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    TestValue = table.Column<int>(type: "integer", nullable: false),
                    MSId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SheetItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SheetItems_Items_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Items",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SheetItems_MSs_MSId",
                        column: x => x.MSId,
                        principalTable: "MSs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SheetSkills",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    SkillId = table.Column<int>(type: "integer", nullable: false),
                    RegisterDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    TestValue = table.Column<int>(type: "integer", nullable: false),
                    MSId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SheetSkills", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SheetSkills_MSs_MSId",
                        column: x => x.MSId,
                        principalTable: "MSs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SheetSkills_Skills_SkillId",
                        column: x => x.SkillId,
                        principalTable: "Skills",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SheetWeapons",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    WeaponId = table.Column<int>(type: "integer", nullable: false),
                    Equipped = table.Column<bool>(type: "boolean", nullable: false),
                    RegisterDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    TestValue = table.Column<int>(type: "integer", nullable: false),
                    MSId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SheetWeapons", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SheetWeapons_MSs_MSId",
                        column: x => x.MSId,
                        principalTable: "MSs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SheetWeapons_Weapons_WeaponId",
                        column: x => x.WeaponId,
                        principalTable: "Weapons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SheetGenericAdvantages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    GenericAdvantageId = table.Column<int>(type: "integer", nullable: false),
                    RegisterDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    TestValue = table.Column<int>(type: "integer", nullable: false),
                    MSId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SheetGenericAdvantages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SheetGenericAdvantages_GenericAdvantages_GenericAdvantageId",
                        column: x => x.GenericAdvantageId,
                        principalTable: "GenericAdvantages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SheetGenericAdvantages_MSs_MSId",
                        column: x => x.MSId,
                        principalTable: "MSs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_GenericAdvantages_MSId",
                table: "GenericAdvantages",
                column: "MSId");

            migrationBuilder.CreateIndex(
                name: "IX_MSs_PlayerId",
                table: "MSs",
                column: "PlayerId");

            migrationBuilder.CreateIndex(
                name: "IX_SheetArmors_ArmorId",
                table: "SheetArmors",
                column: "ArmorId");

            migrationBuilder.CreateIndex(
                name: "IX_SheetArmors_MSId",
                table: "SheetArmors",
                column: "MSId");

            migrationBuilder.CreateIndex(
                name: "IX_SheetCapabilties_CapabilityId",
                table: "SheetCapabilties",
                column: "CapabilityId");

            migrationBuilder.CreateIndex(
                name: "IX_SheetCapabilties_MSId",
                table: "SheetCapabilties",
                column: "MSId");

            migrationBuilder.CreateIndex(
                name: "IX_SheetDisadvantages_DisadvantageId",
                table: "SheetDisadvantages",
                column: "DisadvantageId");

            migrationBuilder.CreateIndex(
                name: "IX_SheetDisadvantages_MSId",
                table: "SheetDisadvantages",
                column: "MSId");

            migrationBuilder.CreateIndex(
                name: "IX_SheetGenericAdvantages_GenericAdvantageId",
                table: "SheetGenericAdvantages",
                column: "GenericAdvantageId");

            migrationBuilder.CreateIndex(
                name: "IX_SheetGenericAdvantages_MSId",
                table: "SheetGenericAdvantages",
                column: "MSId");

            migrationBuilder.CreateIndex(
                name: "IX_SheetItems_ItemId",
                table: "SheetItems",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_SheetItems_MSId",
                table: "SheetItems",
                column: "MSId");

            migrationBuilder.CreateIndex(
                name: "IX_SheetSkills_MSId",
                table: "SheetSkills",
                column: "MSId");

            migrationBuilder.CreateIndex(
                name: "IX_SheetSkills_SkillId",
                table: "SheetSkills",
                column: "SkillId");

            migrationBuilder.CreateIndex(
                name: "IX_SheetWeapons_MSId",
                table: "SheetWeapons",
                column: "MSId");

            migrationBuilder.CreateIndex(
                name: "IX_SheetWeapons_WeaponId",
                table: "SheetWeapons",
                column: "WeaponId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Armors");

            migrationBuilder.DropTable(
                name: "SheetArmors");

            migrationBuilder.DropTable(
                name: "SheetCapabilties");

            migrationBuilder.DropTable(
                name: "SheetDisadvantages");

            migrationBuilder.DropTable(
                name: "SheetGenericAdvantages");

            migrationBuilder.DropTable(
                name: "SheetItems");

            migrationBuilder.DropTable(
                name: "SheetSkills");

            migrationBuilder.DropTable(
                name: "SheetWeapons");

            migrationBuilder.DropTable(
                name: "Capabilities");

            migrationBuilder.DropTable(
                name: "Disadvantages");

            migrationBuilder.DropTable(
                name: "GenericAdvantages");

            migrationBuilder.DropTable(
                name: "Items");

            migrationBuilder.DropTable(
                name: "Skills");

            migrationBuilder.DropTable(
                name: "Weapons");

            migrationBuilder.DropTable(
                name: "MSs");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
