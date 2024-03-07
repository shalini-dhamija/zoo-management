using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ZooManagement.Migrations
{
    /// <inheritdoc />
    public partial class AddEnclosure : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Enclosures",
                columns: table => new
                {
                    EnclosureId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    NumberOfAnimals = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Enclosures", x => x.EnclosureId);
                });

            migrationBuilder.CreateTable(
                name: "Species",
                columns: table => new
                {
                    SpeciesId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Classification = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Species", x => x.SpeciesId);
                });

            migrationBuilder.CreateTable(
                name: "Animals",
                columns: table => new
                {
                    AnimalId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    SpeciesId = table.Column<int>(type: "integer", nullable: false),
                    EnclosureId = table.Column<int>(type: "integer", nullable: false),
                    Sex = table.Column<int>(type: "integer", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    DateOfAcquisition = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Animals", x => x.AnimalId);
                    table.ForeignKey(
                        name: "FK_Animals_Enclosures_EnclosureId",
                        column: x => x.EnclosureId,
                        principalTable: "Enclosures",
                        principalColumn: "EnclosureId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Animals_Species_SpeciesId",
                        column: x => x.SpeciesId,
                        principalTable: "Species",
                        principalColumn: "SpeciesId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Enclosures",
                columns: new[] { "EnclosureId", "Name", "NumberOfAnimals" },
                values: new object[,]
                {
                    { 1, "Lion’s Enclosure", 10 },
                    { 2, "Aviary ", 50 },
                    { 3, "Reptile House", 40 },
                    { 4, "Giraffe Enclosure", 6 },
                    { 5, "Hippo Enclosure", 10 }
                });

            migrationBuilder.InsertData(
                table: "Species",
                columns: new[] { "SpeciesId", "Classification", "Name" },
                values: new object[,]
                {
                    { 1, 0, "elephant" },
                    { 2, 0, "zebra" },
                    { 3, 1, "snake" },
                    { 4, 0, "giraffe" },
                    { 5, 3, "spider" },
                    { 6, 0, "hippo" },
                    { 7, 2, "parrot" },
                    { 8, 4, "goldfish" }
                });

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "AnimalId", "DateOfAcquisition", "DateOfBirth", "EnclosureId", "Name", "Sex", "SpeciesId" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 3, 7, 11, 37, 45, 57, DateTimeKind.Utc).AddTicks(4499), new DateTime(2024, 3, 7, 11, 37, 45, 57, DateTimeKind.Utc).AddTicks(4565), 1, "Pooh", 0, 1 },
                    { 2, new DateTime(2024, 3, 7, 11, 37, 45, 57, DateTimeKind.Utc).AddTicks(4663), new DateTime(2024, 3, 7, 11, 37, 45, 57, DateTimeKind.Utc).AddTicks(4666), 5, "Piglet", 1, 5 },
                    { 3, new DateTime(2024, 3, 7, 11, 37, 45, 57, DateTimeKind.Utc).AddTicks(4671), new DateTime(2024, 3, 7, 11, 37, 45, 57, DateTimeKind.Utc).AddTicks(4673), 2, "Pooh", 1, 3 },
                    { 4, new DateTime(2024, 3, 7, 11, 37, 45, 57, DateTimeKind.Utc).AddTicks(4677), new DateTime(2024, 3, 7, 11, 37, 45, 57, DateTimeKind.Utc).AddTicks(4679), 5, "Tabatha", 1, 5 },
                    { 5, new DateTime(2024, 3, 7, 11, 37, 45, 57, DateTimeKind.Utc).AddTicks(4683), new DateTime(2024, 3, 7, 11, 37, 45, 57, DateTimeKind.Utc).AddTicks(4685), 5, "Spot", 1, 5 },
                    { 6, new DateTime(2024, 3, 7, 11, 37, 45, 57, DateTimeKind.Utc).AddTicks(4689), new DateTime(2024, 3, 7, 11, 37, 45, 57, DateTimeKind.Utc).AddTicks(4692), 3, "Daffy", 1, 3 },
                    { 7, new DateTime(2024, 3, 7, 11, 37, 45, 57, DateTimeKind.Utc).AddTicks(4696), new DateTime(2024, 3, 7, 11, 37, 45, 57, DateTimeKind.Utc).AddTicks(4698), 2, "Snoopy", 1, 7 },
                    { 8, new DateTime(2024, 3, 7, 11, 37, 45, 57, DateTimeKind.Utc).AddTicks(4702), new DateTime(2024, 3, 7, 11, 37, 45, 57, DateTimeKind.Utc).AddTicks(4705), 2, "Snoopy", 0, 6 },
                    { 9, new DateTime(2024, 3, 7, 11, 37, 45, 57, DateTimeKind.Utc).AddTicks(4708), new DateTime(2024, 3, 7, 11, 37, 45, 57, DateTimeKind.Utc).AddTicks(4711), 1, "Garfield", 1, 5 },
                    { 10, new DateTime(2024, 3, 7, 11, 37, 45, 57, DateTimeKind.Utc).AddTicks(4715), new DateTime(2024, 3, 7, 11, 37, 45, 57, DateTimeKind.Utc).AddTicks(4717), 4, "Kanga", 0, 6 },
                    { 11, new DateTime(2024, 3, 7, 11, 37, 45, 57, DateTimeKind.Utc).AddTicks(4721), new DateTime(2024, 3, 7, 11, 37, 45, 57, DateTimeKind.Utc).AddTicks(4723), 1, "Spot", 1, 1 },
                    { 12, new DateTime(2024, 3, 7, 11, 37, 45, 57, DateTimeKind.Utc).AddTicks(4727), new DateTime(2024, 3, 7, 11, 37, 45, 57, DateTimeKind.Utc).AddTicks(4729), 4, "Peter", 0, 5 },
                    { 13, new DateTime(2024, 3, 7, 11, 37, 45, 57, DateTimeKind.Utc).AddTicks(4733), new DateTime(2024, 3, 7, 11, 37, 45, 57, DateTimeKind.Utc).AddTicks(4736), 4, "Spot", 1, 6 },
                    { 14, new DateTime(2024, 3, 7, 11, 37, 45, 57, DateTimeKind.Utc).AddTicks(4740), new DateTime(2024, 3, 7, 11, 37, 45, 57, DateTimeKind.Utc).AddTicks(4742), 1, "Pooh", 0, 1 },
                    { 15, new DateTime(2024, 3, 7, 11, 37, 45, 57, DateTimeKind.Utc).AddTicks(4746), new DateTime(2024, 3, 7, 11, 37, 45, 57, DateTimeKind.Utc).AddTicks(4748), 1, "Peter", 0, 7 },
                    { 16, new DateTime(2024, 3, 7, 11, 37, 45, 57, DateTimeKind.Utc).AddTicks(4752), new DateTime(2024, 3, 7, 11, 37, 45, 57, DateTimeKind.Utc).AddTicks(4755), 3, "Daffy", 0, 5 },
                    { 17, new DateTime(2024, 3, 7, 11, 37, 45, 57, DateTimeKind.Utc).AddTicks(4758), new DateTime(2024, 3, 7, 11, 37, 45, 57, DateTimeKind.Utc).AddTicks(4761), 1, "Snoopy", 0, 5 },
                    { 18, new DateTime(2024, 3, 7, 11, 37, 45, 57, DateTimeKind.Utc).AddTicks(4765), new DateTime(2024, 3, 7, 11, 37, 45, 57, DateTimeKind.Utc).AddTicks(4767), 5, "Mickey", 0, 2 },
                    { 19, new DateTime(2024, 3, 7, 11, 37, 45, 57, DateTimeKind.Utc).AddTicks(4771), new DateTime(2024, 3, 7, 11, 37, 45, 57, DateTimeKind.Utc).AddTicks(4773), 3, "Piglet", 0, 2 },
                    { 20, new DateTime(2024, 3, 7, 11, 37, 45, 57, DateTimeKind.Utc).AddTicks(4777), new DateTime(2024, 3, 7, 11, 37, 45, 57, DateTimeKind.Utc).AddTicks(4780), 3, "Snoopy", 0, 7 },
                    { 21, new DateTime(2024, 3, 7, 11, 37, 45, 57, DateTimeKind.Utc).AddTicks(4784), new DateTime(2024, 3, 7, 11, 37, 45, 57, DateTimeKind.Utc).AddTicks(4786), 5, "Piglet", 1, 5 },
                    { 22, new DateTime(2024, 3, 7, 11, 37, 45, 57, DateTimeKind.Utc).AddTicks(4790), new DateTime(2024, 3, 7, 11, 37, 45, 57, DateTimeKind.Utc).AddTicks(4792), 2, "Spot", 1, 6 },
                    { 23, new DateTime(2024, 3, 7, 11, 37, 45, 57, DateTimeKind.Utc).AddTicks(4796), new DateTime(2024, 3, 7, 11, 37, 45, 57, DateTimeKind.Utc).AddTicks(4798), 2, "Spot", 1, 3 },
                    { 24, new DateTime(2024, 3, 7, 11, 37, 45, 57, DateTimeKind.Utc).AddTicks(4802), new DateTime(2024, 3, 7, 11, 37, 45, 57, DateTimeKind.Utc).AddTicks(4805), 5, "Snoopy", 0, 5 },
                    { 25, new DateTime(2024, 3, 7, 11, 37, 45, 57, DateTimeKind.Utc).AddTicks(4808), new DateTime(2024, 3, 7, 11, 37, 45, 57, DateTimeKind.Utc).AddTicks(4811), 1, "Kanga", 0, 5 },
                    { 26, new DateTime(2024, 3, 7, 11, 37, 45, 57, DateTimeKind.Utc).AddTicks(4814), new DateTime(2024, 3, 7, 11, 37, 45, 57, DateTimeKind.Utc).AddTicks(4817), 2, "Tabatha", 0, 6 },
                    { 27, new DateTime(2024, 3, 7, 11, 37, 45, 57, DateTimeKind.Utc).AddTicks(4821), new DateTime(2024, 3, 7, 11, 37, 45, 57, DateTimeKind.Utc).AddTicks(4823), 3, "Peter", 0, 4 },
                    { 28, new DateTime(2024, 3, 7, 11, 37, 45, 57, DateTimeKind.Utc).AddTicks(4827), new DateTime(2024, 3, 7, 11, 37, 45, 57, DateTimeKind.Utc).AddTicks(4829), 1, "Kanga", 1, 2 },
                    { 29, new DateTime(2024, 3, 7, 11, 37, 45, 57, DateTimeKind.Utc).AddTicks(4833), new DateTime(2024, 3, 7, 11, 37, 45, 57, DateTimeKind.Utc).AddTicks(4836), 2, "Winston", 1, 5 },
                    { 30, new DateTime(2024, 3, 7, 11, 37, 45, 57, DateTimeKind.Utc).AddTicks(4839), new DateTime(2024, 3, 7, 11, 37, 45, 57, DateTimeKind.Utc).AddTicks(4842), 4, "Mickey", 0, 7 },
                    { 31, new DateTime(2024, 3, 7, 11, 37, 45, 57, DateTimeKind.Utc).AddTicks(4846), new DateTime(2024, 3, 7, 11, 37, 45, 57, DateTimeKind.Utc).AddTicks(4848), 1, "Winston", 1, 3 },
                    { 32, new DateTime(2024, 3, 7, 11, 37, 45, 57, DateTimeKind.Utc).AddTicks(4852), new DateTime(2024, 3, 7, 11, 37, 45, 57, DateTimeKind.Utc).AddTicks(4854), 4, "Snoopy", 0, 7 },
                    { 33, new DateTime(2024, 3, 7, 11, 37, 45, 57, DateTimeKind.Utc).AddTicks(4858), new DateTime(2024, 3, 7, 11, 37, 45, 57, DateTimeKind.Utc).AddTicks(4861), 5, "Peter", 0, 6 },
                    { 34, new DateTime(2024, 3, 7, 11, 37, 45, 57, DateTimeKind.Utc).AddTicks(4864), new DateTime(2024, 3, 7, 11, 37, 45, 57, DateTimeKind.Utc).AddTicks(4867), 5, "Piglet", 1, 1 },
                    { 35, new DateTime(2024, 3, 7, 11, 37, 45, 57, DateTimeKind.Utc).AddTicks(4871), new DateTime(2024, 3, 7, 11, 37, 45, 57, DateTimeKind.Utc).AddTicks(4873), 2, "Spot", 0, 1 },
                    { 36, new DateTime(2024, 3, 7, 11, 37, 45, 57, DateTimeKind.Utc).AddTicks(4877), new DateTime(2024, 3, 7, 11, 37, 45, 57, DateTimeKind.Utc).AddTicks(4879), 3, "Piglet", 0, 2 },
                    { 37, new DateTime(2024, 3, 7, 11, 37, 45, 57, DateTimeKind.Utc).AddTicks(4883), new DateTime(2024, 3, 7, 11, 37, 45, 57, DateTimeKind.Utc).AddTicks(4886), 3, "Garfield", 1, 5 },
                    { 38, new DateTime(2024, 3, 7, 11, 37, 45, 57, DateTimeKind.Utc).AddTicks(4889), new DateTime(2024, 3, 7, 11, 37, 45, 57, DateTimeKind.Utc).AddTicks(4892), 5, "Piglet", 1, 3 },
                    { 39, new DateTime(2024, 3, 7, 11, 37, 45, 57, DateTimeKind.Utc).AddTicks(4896), new DateTime(2024, 3, 7, 11, 37, 45, 57, DateTimeKind.Utc).AddTicks(4898), 4, "Peter", 1, 7 },
                    { 40, new DateTime(2024, 3, 7, 11, 37, 45, 57, DateTimeKind.Utc).AddTicks(4902), new DateTime(2024, 3, 7, 11, 37, 45, 57, DateTimeKind.Utc).AddTicks(4904), 2, "Mickey", 1, 3 },
                    { 41, new DateTime(2024, 3, 7, 11, 37, 45, 57, DateTimeKind.Utc).AddTicks(4908), new DateTime(2024, 3, 7, 11, 37, 45, 57, DateTimeKind.Utc).AddTicks(4910), 3, "Daffy", 1, 4 },
                    { 42, new DateTime(2024, 3, 7, 11, 37, 45, 57, DateTimeKind.Utc).AddTicks(4914), new DateTime(2024, 3, 7, 11, 37, 45, 57, DateTimeKind.Utc).AddTicks(4917), 5, "Mickey", 0, 6 },
                    { 43, new DateTime(2024, 3, 7, 11, 37, 45, 57, DateTimeKind.Utc).AddTicks(4921), new DateTime(2024, 3, 7, 11, 37, 45, 57, DateTimeKind.Utc).AddTicks(4923), 2, "Snoopy", 1, 6 },
                    { 44, new DateTime(2024, 3, 7, 11, 37, 45, 57, DateTimeKind.Utc).AddTicks(4927), new DateTime(2024, 3, 7, 11, 37, 45, 57, DateTimeKind.Utc).AddTicks(4929), 1, "Garfield", 0, 2 },
                    { 45, new DateTime(2024, 3, 7, 11, 37, 45, 57, DateTimeKind.Utc).AddTicks(4933), new DateTime(2024, 3, 7, 11, 37, 45, 57, DateTimeKind.Utc).AddTicks(4935), 2, "Winston", 0, 1 },
                    { 46, new DateTime(2024, 3, 7, 11, 37, 45, 57, DateTimeKind.Utc).AddTicks(4939), new DateTime(2024, 3, 7, 11, 37, 45, 57, DateTimeKind.Utc).AddTicks(4942), 2, "Daffy", 0, 5 },
                    { 47, new DateTime(2024, 3, 7, 11, 37, 45, 57, DateTimeKind.Utc).AddTicks(4946), new DateTime(2024, 3, 7, 11, 37, 45, 57, DateTimeKind.Utc).AddTicks(4948), 5, "Tabatha", 1, 1 },
                    { 48, new DateTime(2024, 3, 7, 11, 37, 45, 57, DateTimeKind.Utc).AddTicks(4952), new DateTime(2024, 3, 7, 11, 37, 45, 57, DateTimeKind.Utc).AddTicks(4955), 1, "Tabatha", 1, 2 },
                    { 49, new DateTime(2024, 3, 7, 11, 37, 45, 57, DateTimeKind.Utc).AddTicks(4958), new DateTime(2024, 3, 7, 11, 37, 45, 57, DateTimeKind.Utc).AddTicks(4961), 4, "Kanga", 1, 7 },
                    { 50, new DateTime(2024, 3, 7, 11, 37, 45, 57, DateTimeKind.Utc).AddTicks(4965), new DateTime(2024, 3, 7, 11, 37, 45, 57, DateTimeKind.Utc).AddTicks(4967), 4, "Daffy", 1, 6 },
                    { 51, new DateTime(2024, 3, 7, 11, 37, 45, 57, DateTimeKind.Utc).AddTicks(4971), new DateTime(2024, 3, 7, 11, 37, 45, 57, DateTimeKind.Utc).AddTicks(4973), 1, "Pooh", 0, 1 },
                    { 52, new DateTime(2024, 3, 7, 11, 37, 45, 57, DateTimeKind.Utc).AddTicks(4977), new DateTime(2024, 3, 7, 11, 37, 45, 57, DateTimeKind.Utc).AddTicks(4980), 2, "Winston", 0, 4 },
                    { 53, new DateTime(2024, 3, 7, 11, 37, 45, 57, DateTimeKind.Utc).AddTicks(4983), new DateTime(2024, 3, 7, 11, 37, 45, 57, DateTimeKind.Utc).AddTicks(4986), 2, "Snoopy", 0, 6 },
                    { 54, new DateTime(2024, 3, 7, 11, 37, 45, 57, DateTimeKind.Utc).AddTicks(4990), new DateTime(2024, 3, 7, 11, 37, 45, 57, DateTimeKind.Utc).AddTicks(4992), 5, "Mickey", 1, 5 },
                    { 55, new DateTime(2024, 3, 7, 11, 37, 45, 57, DateTimeKind.Utc).AddTicks(4996), new DateTime(2024, 3, 7, 11, 37, 45, 57, DateTimeKind.Utc).AddTicks(4998), 3, "Peter", 1, 3 },
                    { 56, new DateTime(2024, 3, 7, 11, 37, 45, 57, DateTimeKind.Utc).AddTicks(5002), new DateTime(2024, 3, 7, 11, 37, 45, 57, DateTimeKind.Utc).AddTicks(5004), 2, "Winston", 1, 3 },
                    { 57, new DateTime(2024, 3, 7, 11, 37, 45, 57, DateTimeKind.Utc).AddTicks(5008), new DateTime(2024, 3, 7, 11, 37, 45, 57, DateTimeKind.Utc).AddTicks(5011), 4, "Pooh", 1, 3 },
                    { 58, new DateTime(2024, 3, 7, 11, 37, 45, 57, DateTimeKind.Utc).AddTicks(5014), new DateTime(2024, 3, 7, 11, 37, 45, 57, DateTimeKind.Utc).AddTicks(5017), 4, "Pooh", 1, 5 },
                    { 59, new DateTime(2024, 3, 7, 11, 37, 45, 57, DateTimeKind.Utc).AddTicks(5021), new DateTime(2024, 3, 7, 11, 37, 45, 57, DateTimeKind.Utc).AddTicks(5023), 5, "Garfield", 0, 3 },
                    { 60, new DateTime(2024, 3, 7, 11, 37, 45, 57, DateTimeKind.Utc).AddTicks(5027), new DateTime(2024, 3, 7, 11, 37, 45, 57, DateTimeKind.Utc).AddTicks(5029), 4, "Daffy", 1, 1 },
                    { 61, new DateTime(2024, 3, 7, 11, 37, 45, 57, DateTimeKind.Utc).AddTicks(5033), new DateTime(2024, 3, 7, 11, 37, 45, 57, DateTimeKind.Utc).AddTicks(5035), 4, "Piglet", 0, 1 },
                    { 62, new DateTime(2024, 3, 7, 11, 37, 45, 57, DateTimeKind.Utc).AddTicks(5039), new DateTime(2024, 3, 7, 11, 37, 45, 57, DateTimeKind.Utc).AddTicks(5041), 3, "Mickey", 1, 7 },
                    { 63, new DateTime(2024, 3, 7, 11, 37, 45, 57, DateTimeKind.Utc).AddTicks(5045), new DateTime(2024, 3, 7, 11, 37, 45, 57, DateTimeKind.Utc).AddTicks(5048), 4, "Pooh", 1, 7 },
                    { 64, new DateTime(2024, 3, 7, 11, 37, 45, 57, DateTimeKind.Utc).AddTicks(5051), new DateTime(2024, 3, 7, 11, 37, 45, 57, DateTimeKind.Utc).AddTicks(5054), 5, "Piglet", 1, 2 },
                    { 65, new DateTime(2024, 3, 7, 11, 37, 45, 57, DateTimeKind.Utc).AddTicks(5058), new DateTime(2024, 3, 7, 11, 37, 45, 57, DateTimeKind.Utc).AddTicks(5060), 2, "Spot", 0, 5 },
                    { 66, new DateTime(2024, 3, 7, 11, 37, 45, 57, DateTimeKind.Utc).AddTicks(5064), new DateTime(2024, 3, 7, 11, 37, 45, 57, DateTimeKind.Utc).AddTicks(5066), 2, "Garfield", 1, 2 },
                    { 67, new DateTime(2024, 3, 7, 11, 37, 45, 57, DateTimeKind.Utc).AddTicks(5070), new DateTime(2024, 3, 7, 11, 37, 45, 57, DateTimeKind.Utc).AddTicks(5072), 3, "Snoopy", 1, 3 },
                    { 68, new DateTime(2024, 3, 7, 11, 37, 45, 57, DateTimeKind.Utc).AddTicks(5076), new DateTime(2024, 3, 7, 11, 37, 45, 57, DateTimeKind.Utc).AddTicks(5079), 4, "Kanga", 1, 2 },
                    { 69, new DateTime(2024, 3, 7, 11, 37, 45, 57, DateTimeKind.Utc).AddTicks(5082), new DateTime(2024, 3, 7, 11, 37, 45, 57, DateTimeKind.Utc).AddTicks(5085), 2, "Daffy", 0, 2 },
                    { 70, new DateTime(2024, 3, 7, 11, 37, 45, 57, DateTimeKind.Utc).AddTicks(5088), new DateTime(2024, 3, 7, 11, 37, 45, 57, DateTimeKind.Utc).AddTicks(5091), 4, "Snoopy", 1, 5 },
                    { 71, new DateTime(2024, 3, 7, 11, 37, 45, 57, DateTimeKind.Utc).AddTicks(5095), new DateTime(2024, 3, 7, 11, 37, 45, 57, DateTimeKind.Utc).AddTicks(5097), 1, "Pooh", 1, 5 },
                    { 72, new DateTime(2024, 3, 7, 11, 37, 45, 57, DateTimeKind.Utc).AddTicks(5101), new DateTime(2024, 3, 7, 11, 37, 45, 57, DateTimeKind.Utc).AddTicks(5103), 2, "Winston", 1, 4 },
                    { 73, new DateTime(2024, 3, 7, 11, 37, 45, 57, DateTimeKind.Utc).AddTicks(5107), new DateTime(2024, 3, 7, 11, 37, 45, 57, DateTimeKind.Utc).AddTicks(5110), 4, "Kanga", 0, 3 },
                    { 74, new DateTime(2024, 3, 7, 11, 37, 45, 57, DateTimeKind.Utc).AddTicks(5113), new DateTime(2024, 3, 7, 11, 37, 45, 57, DateTimeKind.Utc).AddTicks(5116), 4, "Garfield", 0, 6 },
                    { 75, new DateTime(2024, 3, 7, 11, 37, 45, 57, DateTimeKind.Utc).AddTicks(5119), new DateTime(2024, 3, 7, 11, 37, 45, 57, DateTimeKind.Utc).AddTicks(5122), 1, "Spot", 1, 3 },
                    { 76, new DateTime(2024, 3, 7, 11, 37, 45, 57, DateTimeKind.Utc).AddTicks(5126), new DateTime(2024, 3, 7, 11, 37, 45, 57, DateTimeKind.Utc).AddTicks(5128), 3, "Winston", 1, 5 },
                    { 77, new DateTime(2024, 3, 7, 11, 37, 45, 57, DateTimeKind.Utc).AddTicks(5132), new DateTime(2024, 3, 7, 11, 37, 45, 57, DateTimeKind.Utc).AddTicks(5134), 5, "Kanga", 1, 4 },
                    { 78, new DateTime(2024, 3, 7, 11, 37, 45, 57, DateTimeKind.Utc).AddTicks(5138), new DateTime(2024, 3, 7, 11, 37, 45, 57, DateTimeKind.Utc).AddTicks(5140), 4, "Garfield", 1, 3 },
                    { 79, new DateTime(2024, 3, 7, 11, 37, 45, 57, DateTimeKind.Utc).AddTicks(5144), new DateTime(2024, 3, 7, 11, 37, 45, 57, DateTimeKind.Utc).AddTicks(5147), 3, "Winston", 0, 3 },
                    { 80, new DateTime(2024, 3, 7, 11, 37, 45, 57, DateTimeKind.Utc).AddTicks(5150), new DateTime(2024, 3, 7, 11, 37, 45, 57, DateTimeKind.Utc).AddTicks(5153), 1, "Kanga", 1, 2 },
                    { 81, new DateTime(2024, 3, 7, 11, 37, 45, 57, DateTimeKind.Utc).AddTicks(5197), new DateTime(2024, 3, 7, 11, 37, 45, 57, DateTimeKind.Utc).AddTicks(5200), 1, "Snoopy", 0, 7 },
                    { 82, new DateTime(2024, 3, 7, 11, 37, 45, 57, DateTimeKind.Utc).AddTicks(5204), new DateTime(2024, 3, 7, 11, 37, 45, 57, DateTimeKind.Utc).AddTicks(5206), 1, "Pooh", 1, 6 },
                    { 83, new DateTime(2024, 3, 7, 11, 37, 45, 57, DateTimeKind.Utc).AddTicks(5210), new DateTime(2024, 3, 7, 11, 37, 45, 57, DateTimeKind.Utc).AddTicks(5213), 5, "Tabatha", 1, 4 },
                    { 84, new DateTime(2024, 3, 7, 11, 37, 45, 57, DateTimeKind.Utc).AddTicks(5217), new DateTime(2024, 3, 7, 11, 37, 45, 57, DateTimeKind.Utc).AddTicks(5219), 2, "Pooh", 1, 2 },
                    { 85, new DateTime(2024, 3, 7, 11, 37, 45, 57, DateTimeKind.Utc).AddTicks(5223), new DateTime(2024, 3, 7, 11, 37, 45, 57, DateTimeKind.Utc).AddTicks(5225), 5, "Mickey", 1, 6 },
                    { 86, new DateTime(2024, 3, 7, 11, 37, 45, 57, DateTimeKind.Utc).AddTicks(5229), new DateTime(2024, 3, 7, 11, 37, 45, 57, DateTimeKind.Utc).AddTicks(5231), 2, "Daffy", 0, 1 },
                    { 87, new DateTime(2024, 3, 7, 11, 37, 45, 57, DateTimeKind.Utc).AddTicks(5235), new DateTime(2024, 3, 7, 11, 37, 45, 57, DateTimeKind.Utc).AddTicks(5238), 5, "Daffy", 0, 3 },
                    { 88, new DateTime(2024, 3, 7, 11, 37, 45, 57, DateTimeKind.Utc).AddTicks(5242), new DateTime(2024, 3, 7, 11, 37, 45, 57, DateTimeKind.Utc).AddTicks(5244), 4, "Pooh", 1, 6 },
                    { 89, new DateTime(2024, 3, 7, 11, 37, 45, 57, DateTimeKind.Utc).AddTicks(5248), new DateTime(2024, 3, 7, 11, 37, 45, 57, DateTimeKind.Utc).AddTicks(5250), 4, "Garfield", 1, 5 },
                    { 90, new DateTime(2024, 3, 7, 11, 37, 45, 57, DateTimeKind.Utc).AddTicks(5254), new DateTime(2024, 3, 7, 11, 37, 45, 57, DateTimeKind.Utc).AddTicks(5256), 5, "Daffy", 0, 2 },
                    { 91, new DateTime(2024, 3, 7, 11, 37, 45, 57, DateTimeKind.Utc).AddTicks(5260), new DateTime(2024, 3, 7, 11, 37, 45, 57, DateTimeKind.Utc).AddTicks(5263), 1, "Kanga", 1, 7 },
                    { 92, new DateTime(2024, 3, 7, 11, 37, 45, 57, DateTimeKind.Utc).AddTicks(5266), new DateTime(2024, 3, 7, 11, 37, 45, 57, DateTimeKind.Utc).AddTicks(5269), 2, "Snoopy", 1, 6 },
                    { 93, new DateTime(2024, 3, 7, 11, 37, 45, 57, DateTimeKind.Utc).AddTicks(5273), new DateTime(2024, 3, 7, 11, 37, 45, 57, DateTimeKind.Utc).AddTicks(5275), 2, "Piglet", 1, 2 },
                    { 94, new DateTime(2024, 3, 7, 11, 37, 45, 57, DateTimeKind.Utc).AddTicks(5279), new DateTime(2024, 3, 7, 11, 37, 45, 57, DateTimeKind.Utc).AddTicks(5281), 2, "Daffy", 1, 4 },
                    { 95, new DateTime(2024, 3, 7, 11, 37, 45, 57, DateTimeKind.Utc).AddTicks(5285), new DateTime(2024, 3, 7, 11, 37, 45, 57, DateTimeKind.Utc).AddTicks(5288), 1, "Snoopy", 1, 5 },
                    { 96, new DateTime(2024, 3, 7, 11, 37, 45, 57, DateTimeKind.Utc).AddTicks(5291), new DateTime(2024, 3, 7, 11, 37, 45, 57, DateTimeKind.Utc).AddTicks(5294), 4, "Piglet", 0, 1 },
                    { 97, new DateTime(2024, 3, 7, 11, 37, 45, 57, DateTimeKind.Utc).AddTicks(5298), new DateTime(2024, 3, 7, 11, 37, 45, 57, DateTimeKind.Utc).AddTicks(5300), 3, "Piglet", 1, 4 },
                    { 98, new DateTime(2024, 3, 7, 11, 37, 45, 57, DateTimeKind.Utc).AddTicks(5304), new DateTime(2024, 3, 7, 11, 37, 45, 57, DateTimeKind.Utc).AddTicks(5306), 2, "Kanga", 0, 6 },
                    { 99, new DateTime(2024, 3, 7, 11, 37, 45, 57, DateTimeKind.Utc).AddTicks(5310), new DateTime(2024, 3, 7, 11, 37, 45, 57, DateTimeKind.Utc).AddTicks(5312), 1, "Snoopy", 0, 2 },
                    { 100, new DateTime(2024, 3, 7, 11, 37, 45, 57, DateTimeKind.Utc).AddTicks(5316), new DateTime(2024, 3, 7, 11, 37, 45, 57, DateTimeKind.Utc).AddTicks(5319), 4, "Peter", 1, 3 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Animals_EnclosureId",
                table: "Animals",
                column: "EnclosureId");

            migrationBuilder.CreateIndex(
                name: "IX_Animals_SpeciesId",
                table: "Animals",
                column: "SpeciesId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Animals");

            migrationBuilder.DropTable(
                name: "Enclosures");

            migrationBuilder.DropTable(
                name: "Species");
        }
    }
}
