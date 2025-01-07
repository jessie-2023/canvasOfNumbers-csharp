using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace myAppC.Migrations
{
    /// <inheritdoc />
    public partial class IndexTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "population",
                table: "Gaps",
                newName: "Population");

            migrationBuilder.RenameColumn(
                name: "political",
                table: "Gaps",
                newName: "PoliticalGap");

            migrationBuilder.RenameColumn(
                name: "pcgdp",
                table: "Gaps",
                newName: "HealthGap");

            migrationBuilder.RenameColumn(
                name: "health",
                table: "Gaps",
                newName: "GeneralGap");

            migrationBuilder.RenameColumn(
                name: "general",
                table: "Gaps",
                newName: "GDPperCapita");

            migrationBuilder.RenameColumn(
                name: "education",
                table: "Gaps",
                newName: "EducationGap");

            migrationBuilder.RenameColumn(
                name: "economical",
                table: "Gaps",
                newName: "EconomicalGap");

            migrationBuilder.RenameColumn(
                name: "Region",
                table: "Gaps",
                newName: "RegionName");

            migrationBuilder.RenameColumn(
                name: "Country",
                table: "Gaps",
                newName: "CountryName");

            migrationBuilder.AddColumn<int>(
                name: "CountryId",
                table: "Gaps",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "RegionId",
                table: "Gaps",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Regions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Regions", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Albania" },
                    { 2, "United_Arab_Emirates" },
                    { 3, "Argentina" },
                    { 4, "Australia" },
                    { 5, "Austria" },
                    { 6, "Belgium" },
                    { 7, "Burkina_Faso" },
                    { 8, "Bangladesh" },
                    { 9, "Bulgaria" },
                    { 10, "Bahrain" },
                    { 11, "Bolivia_Plurinational_State_of" },
                    { 12, "Brazil" },
                    { 13, "Botswana" },
                    { 14, "Canada" },
                    { 15, "Switzerland" },
                    { 16, "Chile" },
                    { 17, "China" },
                    { 18, "Colombia" },
                    { 19, "Costa_Rica" },
                    { 20, "Cyprus" },
                    { 21, "Czech_Republic" },
                    { 22, "Germany" },
                    { 23, "Denmark" },
                    { 24, "Dominican_Republic" },
                    { 25, "Algeria" },
                    { 26, "Ecuador" },
                    { 27, "Egypt" },
                    { 28, "Spain" },
                    { 29, "Estonia" },
                    { 30, "Ethiopia" },
                    { 31, "Finland" },
                    { 32, "France" },
                    { 33, "United_Kingdom" },
                    { 34, "Georgia" },
                    { 35, "Ghana" },
                    { 36, "Greece" },
                    { 37, "Guatemala" },
                    { 38, "Honduras" },
                    { 39, "Croatia" },
                    { 40, "Hungary" },
                    { 41, "Indonesia" },
                    { 42, "India" },
                    { 43, "Ireland" },
                    { 44, "Iran_Islamic_Republic_of" },
                    { 45, "Iceland" },
                    { 46, "Israel" },
                    { 47, "Italy" },
                    { 48, "Jamaica" },
                    { 49, "Jordan" },
                    { 50, "Japan" },
                    { 51, "Kazakhstan" },
                    { 52, "Kenya" },
                    { 53, "Kyrgyzstan" },
                    { 54, "Cambodia" },
                    { 55, "Republic_of_Korea" },
                    { 56, "Kuwait" },
                    { 57, "Sri_Lanka" },
                    { 58, "Lesotho" },
                    { 59, "Lithuania" },
                    { 60, "Luxembourg" },
                    { 61, "Latvia" },
                    { 62, "Morocco" },
                    { 63, "Republic_of_Moldova" },
                    { 64, "Madagascar" },
                    { 65, "Mexico" },
                    { 66, "North_Macedonia" },
                    { 67, "Mali" },
                    { 68, "Malta" },
                    { 69, "Mongolia" },
                    { 70, "Mauritania" },
                    { 71, "Mauritius" },
                    { 72, "Malawi" },
                    { 73, "Malaysia" },
                    { 74, "Namibia" },
                    { 75, "Nigeria" },
                    { 76, "Nicaragua" },
                    { 77, "Netherlands" },
                    { 78, "Norway" },
                    { 79, "Nepal" },
                    { 80, "New_Zealand" },
                    { 81, "Pakistan" },
                    { 82, "Panama" },
                    { 83, "Peru" },
                    { 84, "Philippines" },
                    { 85, "Poland" },
                    { 86, "Portugal" },
                    { 87, "Paraguay" },
                    { 88, "Romania" },
                    { 89, "Russian_Federation" },
                    { 90, "Saudi_Arabia" },
                    { 91, "Singapore" },
                    { 92, "El_Salvador" },
                    { 93, "Slovakia" },
                    { 94, "Slovenia" },
                    { 95, "Sweden" },
                    { 96, "Chad" },
                    { 97, "Thailand" },
                    { 98, "Turkey" },
                    { 99, "UR_of_Tanzania_Mainland" },
                    { 100, "Uganda" },
                    { 101, "Ukraine" },
                    { 102, "Uruguay" },
                    { 103, "United_States" },
                    { 104, "Yemen" },
                    { 105, "South_Africa" }
                });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 1, 6529.724m, 0.6607m, 0.9553m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 1, 7106.359m, 0.6685m, 0.9553m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 1, 7664.077m, 0.6591m, 0.9553m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 1, 8612.485m, 0.6601m, 0.9553m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 1, 9317.428m, 0.6726m, 0.937m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 1, 10519.37m, 0.6748m, 0.9268m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 1, 10708.14m, 0.6655m, 0.9313m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 1, 11103.5m, 0.6412m, 0.9313m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 1, 10643.21m, 0.6869m, 0.9409m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 1, 11076.2m, 0.701m, 0.947m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 1, 11641.5m, 0.704m, 0.947m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 1, 11671.02m, 0.728m, 0.968m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 1, 12122.8m, 0.734m, 0.963m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 1, 12262.89m, 0.769m, 0.958m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 1, 12527.06m, 0.77m, 0.956m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 2, 109420.1m, 0.5919m, 0.9643m, 2 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 2, 111553.3m, 0.6184m, 0.9612m, 2 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 2, 104784.2m, 0.622m, 0.9612m, 2 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 2, 100533.2m, 0.6198m, 0.9612m, 2 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 2, 74974.7m, 0.6397m, 0.9612m, 2 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 2, 72371.66m, 0.6454m, 0.9612m, 2 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 2, 81184.98m, 0.6392m, 0.9612m, 2 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 2, 85019.97m, 0.6372m, 0.9612m, 2 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 2, 83811.2m, 0.6436m, 0.9612m, 2 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 2, 86651.09m, 0.646m, 0.961m, 2 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 2, 74821.87m, 0.639m, 0.961m, 2 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 2, 71650.97m, 0.649m, 0.965m, 2 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 2, 66363.7m, 0.642m, 0.972m, 2 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 2, 65806.55m, 0.655m, 0.972m, 2 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 2, 66086.5m, 0.716m, 0.963m, 2 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 3, 14111.35m, 0.6829m, 0.9796m, 3 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 3, 15256.43m, 0.6982m, 0.9796m, 3 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 3, 16766.31m, 0.7209m, 0.9796m, 3 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 3, 17917.28m, 0.7211m, 0.9796m, 3 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 3, 16900.37m, 0.7187m, 0.9796m, 3 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 3, 19187.18m, 0.7236m, 0.9796m, 3 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 3, 21356.82m, 0.7212m, 0.9796m, 3 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 3, 21607.75m, 0.7195m, 0.9796m, 3 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 3, 21425.38m, 0.7317m, 0.9796m, 3 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 3, 20631.5m, 0.734m, 0.98m, 3 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 3, 21193.72m, 0.735m, 0.98m, 3 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 3, 20883.35m, 0.732m, 0.98m, 3 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 3, 23269.97m, 0.733m, 0.98m, 3 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 3, 23016.22m, 0.746m, 0.98m, 3 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 3, 21825.37m, 0.752m, 0.977m, 3 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 4, 45487.59m, 0.7163m, 0.9761m, 4 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 4, 45678.39m, 0.7204m, 0.9741m, 4 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 4, 46090.03m, 0.7241m, 0.9741m, 4 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 4, 47621.06m, 0.7282m, 0.9737m, 4 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 4, 46605.03m, 0.7271m, 0.9739m, 4 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 4, 50222.05m, 0.7291m, 0.9739m, 4 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 4, 52135.91m, 0.7294m, 0.9735m, 4 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 4, 51097.54m, 0.739m, 0.9735m, 4 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 4, 52768.36m, 0.7409m, 0.9737m, 4 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 4, 51918.88m, 0.733m, 0.974m, 4 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 4, 48710.41m, 0.721m, 0.974m, 4 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 4, 51495.52m, 0.731m, 0.97m, 4 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 4, 52535.39m, 0.73m, 0.971m, 4 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 4, 54236.22m, 0.731m, 0.971m, 4 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 4, 54147.51m, 0.731m, 0.968m, 4 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 5, 43283.11m, 0.6986m, 0.9796m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 5, 43964.2m, 0.706m, 0.9796m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 5, 45311.58m, 0.7153m, 0.9796m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 5, 46801.71m, 0.7031m, 0.9796m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 5, 44548.97m, 0.7091m, 0.9787m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 5, 45789.8m, 0.7165m, 0.9787m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 5, 47575.45m, 0.7391m, 0.9787m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 5, 48164.99m, 0.7437m, 0.9787m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 5, 47244.61m, 0.7266m, 0.9789m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 5, 49107.26m, 0.733m, 0.98m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 5, 49600.8m, 0.716m, 0.98m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 5, 49846.55m, 0.709m, 0.975m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 5, 51934.16m, 0.718m, 0.974m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 5, 52946.7m, 0.744m, 0.974m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 5, 53322.94m, 0.777m, 0.97m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 6, 40677m, 0.7078m, 0.9796m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 6, 39263.36m, 0.7198m, 0.9789m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 6, 40173.17m, 0.7163m, 0.9789m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 6, 43345.12m, 0.7165m, 0.9789m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 6, 41584.36m, 0.7509m, 0.9787m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 6, 44708.35m, 0.7531m, 0.9787m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 6, 44259.91m, 0.7652m, 0.9787m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 6, 44340.92m, 0.7684m, 0.9787m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 6, 43955.65m, 0.7809m, 0.9789m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 6, 43934.51m, 0.753m, 0.974m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 6, 42865.83m, 0.745m, 0.974m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 6, 43385.71m, 0.739m, 0.976m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 6, 45121.66m, 0.738m, 0.973m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 6, 44176.41m, 0.75m, 0.973m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 6, 44811.18m, 0.789m, 0.968m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 7, 1641.019m, 0.5854m, 0.9733m, 6 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 7, 1654.33m, 0.5912m, 0.9699m, 6 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 7, 1603.836m, 0.6029m, 0.9699m, 6 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 7, 1590.839m, 0.6081m, 0.9699m, 6 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 7, 1540.856m, 0.6162m, 0.9685m, 6 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 7, 1634.257m, 0.6153m, 0.9685m, 6 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 7, 1657.489m, 0.6455m, 0.9685m, 6 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 7, 1750.669m, 0.6513m, 0.9685m, 6 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 7, 1779.309m, 0.65m, 0.9673m, 6 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 7, 1712.542m, 0.651m, 0.967m, 6 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 7, 1716.516m, 0.64m, 0.967m, 6 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 7, 1844.547m, 0.646m, 0.963m, 6 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 7, 1919.395m, 0.629m, 0.963m, 6 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 7, 2054.492m, 0.635m, 0.963m, 6 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 7, 2119.967m, 0.651m, 0.978m, 6 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 8, 1666.571m, 0.627m, 0.9495m, 7 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 8, 1794.082m, 0.6314m, 0.9496m, 7 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 8, 1978.491m, 0.6531m, 0.9496m, 7 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 8, 2193.464m, 0.6526m, 0.95m, 7 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 8, 2353.854m, 0.6702m, 0.9557m, 7 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 8, 2650.906m, 0.6812m, 0.9557m, 7 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 8, 3030.277m, 0.6684m, 0.9557m, 7 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 8, 3114.221m, 0.6848m, 0.9557m, 7 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 8, 3261.228m, 0.6973m, 0.9663m, 7 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 8, 3453.656m, 0.704m, 0.971m, 7 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 8, 3715.143m, 0.698m, 0.971m, 7 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 8, 3834.118m, 0.719m, 0.966m, 7 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 8, 4113.133m, 0.721m, 0.969m, 7 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 8, 4428.572m, 0.726m, 0.969m, 7 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 8, 4658.509m, 0.719m, 0.962m, 7 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 9, 13116.05m, 0.687m, 0.9791m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 9, 13988.7m, 0.7085m, 0.9791m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 9, 15208.19m, 0.7077m, 0.9791m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 9, 16401.84m, 0.7072m, 0.9791m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 9, 15930.91m, 0.6983m, 0.9791m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 9, 16644.15m, 0.6987m, 0.9791m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 9, 16564.12m, 0.7021m, 0.9791m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 9, 17075.21m, 0.7097m, 0.9791m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 9, 16338.44m, 0.7444m, 0.9791m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 9, 16962.13m, 0.722m, 0.979m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 9, 17688.07m, 0.726m, 0.979m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 9, 18658.98m, 0.756m, 0.979m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 9, 19573.59m, 0.756m, 0.979m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 9, 20382.54m, 0.727m, 0.979m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 9, 21338.66m, 0.746m, 0.979m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 10, 38426.36m, 0.5894m, 0.9617m, 2 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 10, 41107.17m, 0.5931m, 0.9612m, 2 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 10, 43333.83m, 0.5927m, 0.9612m, 2 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 10, 55363.66m, 0.6136m, 0.9612m, 2 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 10, 44183.83m, 0.6217m, 0.9612m, 2 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 10, 46539.98m, 0.6232m, 0.9612m, 2 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 10, 47940.3m, 0.6298m, 0.9612m, 2 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 10, 56253.3m, 0.6334m, 0.9612m, 2 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 10, 55299.59m, 0.6261m, 0.9612m, 2 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 10, 53093.76m, 0.644m, 0.961m, 2 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 10, 48496.48m, 0.615m, 0.961m, 2 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 10, 46722.72m, 0.632m, 0.961m, 2 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 10, 49226.92m, 0.627m, 0.958m, 2 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 10, 49265.54m, 0.629m, 0.958m, 2 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 10, 46955.53m, 0.632m, 0.959m, 2 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 11, 3896.771m, 0.6335m, 0.9703m, 3 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 11, 4040.87m, 0.6574m, 0.9668m, 3 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 11, 4219.436m, 0.6667m, 0.9668m, 3 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 11, 4686.541m, 0.6693m, 0.9668m, 3 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 11, 4799.367m, 0.6751m, 0.9719m, 3 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 11, 5248.85m, 0.6862m, 0.9719m, 3 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 11, 5820.064m, 0.7222m, 0.9719m, 3 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 11, 6424.803m, 0.734m, 0.9719m, 3 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 11, 7040.621m, 0.7049m, 0.977m, 3 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 11, 7258.259m, 0.749m, 0.98m, 3 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 11, 7336.596m, 0.746m, 0.98m, 3 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 11, 7606.357m, 0.758m, 0.976m, 3 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 11, 8177.2m, 0.748m, 0.979m, 3 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 11, 8490.053m, 0.734m, 0.979m, 3 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 11, 8584.892m, 0.722m, 0.962m, 3 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 12, 9686.312m, 0.6543m, 0.9796m, 3 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 12, 10455.59m, 0.6637m, 0.9796m, 3 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 12, 11526.62m, 0.6737m, 0.9796m, 3 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 12, 12705.26m, 0.6695m, 0.9796m, 3 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 12, 13056.63m, 0.6655m, 0.9796m, 3 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 12, 15012.04m, 0.6679m, 0.9796m, 3 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 12, 16610.91m, 0.6909m, 0.9796m, 3 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 12, 16416.22m, 0.6949m, 0.9796m, 3 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 12, 16444.7m, 0.6941m, 0.9796m, 3 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 12, 16262.6m, 0.686m, 0.98m, 3 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 12, 15077.21m, 0.687m, 0.98m, 3 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 12, 14218.98m, 0.684m, 0.98m, 3 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 12, 14284.35m, 0.681m, 0.98m, 3 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 12, 14522.78m, 0.691m, 0.98m, 3 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 12, 14593.76m, 0.695m, 0.98m, 3 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 13, 14000.81m, 0.6897m, 0.9561m, 6 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 13, 14299.84m, 0.6797m, 0.9527m, 6 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 13, 14589.17m, 0.6839m, 0.9527m, 6 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 13, 14478.15m, 0.7071m, 0.9527m, 6 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 13, 13194.1m, 0.6876m, 0.9549m, 6 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 13, 14523.96m, 0.6832m, 0.9549m, 6 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 13, 15919.12m, 0.6744m, 0.9549m, 6 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 13, 14731.07m, 0.6752m, 0.9549m, 6 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 13, 14865.09m, 0.7129m, 0.9671m, 6 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 13, 16187.67m, 0.71m, 0.973m, 6 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 13, 15191.3m, 0.715m, 0.973m, 6 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 13, 15639.6m, 0.72m, 0.978m, 6 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 13, 16205.63m, 0.715m, 0.98m, 6 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 13, 16121m, 0.709m, 0.98m, 6 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 13, 16480.37m, 0.716m, 0.98m, 6 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 14, 47065.29m, 0.7165m, 0.9784m, 8 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 14, 46791.16m, 0.7198m, 0.9787m, 8 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 14, 47222.91m, 0.7136m, 0.9783m, 8 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 14, 48602.44m, 0.7196m, 0.9783m, 8 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 14, 43175m, 0.7372m, 0.9784m, 8 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 14, 45639.03m, 0.7407m, 0.9784m, 8 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 14, 47749.69m, 0.7381m, 0.978m, 8 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 203,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 14, 47557.25m, 0.7425m, 0.978m, 8 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 204,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 14, 48808.07m, 0.7464m, 0.9694m, 8 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 205,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 14, 49918.59m, 0.74m, 0.969m, 8 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 206,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 14, 46935.89m, 0.731m, 0.969m, 8 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 207,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 14, 47022.87m, 0.769m, 0.97m, 8 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 208,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 14, 48891.98m, 0.771m, 0.971m, 8 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 209,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 14, 49447.74m, 0.772m, 0.971m, 8 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 210,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 14, 49873.86m, 0.772m, 0.968m, 8 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 211,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 15, 52747.88m, 0.6997m, 0.9792m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 212,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 15, 55947.64m, 0.6924m, 0.9784m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 213,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 15, 61156.29m, 0.736m, 0.9784m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 214,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 15, 64995.76m, 0.7426m, 0.9784m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 215,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 15, 63224.91m, 0.7562m, 0.9738m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 216,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 15, 64719.05m, 0.7627m, 0.9738m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 217,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 15, 70460.73m, 0.7672m, 0.9738m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 218,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 15, 71802.19m, 0.7736m, 0.9733m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 219,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 15, 70773.73m, 0.7798m, 0.9737m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 220,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 15, 71754.95m, 0.785m, 0.974m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 221,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 15, 71446.98m, 0.776m, 0.974m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 222,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 15, 72044.11m, 0.755m, 0.972m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 223,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 15, 73616.46m, 0.755m, 0.97m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 224,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 15, 74605.96m, 0.779m, 0.97m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 225,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 15, 75285.05m, 0.798m, 0.964m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 226,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 16, 14570.69m, 0.6455m, 0.9796m, 3 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 227,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 16, 16854.34m, 0.6482m, 0.9796m, 3 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 228,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 16, 18105.4m, 0.6818m, 0.9796m, 3 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 229,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 16, 17407.37m, 0.6884m, 0.9796m, 3 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 230,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 16, 17554.27m, 0.7013m, 0.9796m, 3 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 231,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 16, 20055.1m, 0.703m, 0.9796m, 3 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 232,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 16, 22020.52m, 0.6676m, 0.9796m, 3 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 233,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 16, 23061.76m, 0.667m, 0.9796m, 3 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 234,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 16, 23621.68m, 0.6975m, 0.9792m, 3 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 235,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 16, 23741.67m, 0.698m, 0.979m, 3 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 236,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 16, 23214.26m, 0.699m, 0.979m, 3 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 237,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 16, 22605.6m, 0.704m, 0.978m, 3 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 238,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 16, 22863.97m, 0.717m, 0.977m, 3 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 239,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 16, 23286.55m, 0.723m, 0.977m, 3 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 240,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 16, 23252.66m, 0.716m, 0.97m, 3 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 241,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 17, 6587.992m, 0.6561m, 0.9355m, 4 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 242,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 17, 7144.18m, 0.6643m, 0.941m, 4 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 243,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 17, 7816.783m, 0.6878m, 0.941m, 4 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 244,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 17, 8281.175m, 0.6907m, 0.9467m, 4 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 245,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 17, 8937.366m, 0.6881m, 0.929m, 4 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 246,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 17, 10115.71m, 0.6866m, 0.9327m, 4 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 247,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 17, 10873.81m, 0.6853m, 0.9344m, 4 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 248,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 17, 11500.83m, 0.6908m, 0.9398m, 4 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 249,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 17, 11898.71m, 0.683m, 0.9404m, 4 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 250,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 17, 12410.41m, 0.682m, 0.919m, 4 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 251,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 17, 12783.38m, 0.676m, 0.919m, 4 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 252,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 17, 13146.85m, 0.674m, 0.918m, 4 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 253,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 17, 13853.31m, 0.673m, 0.915m, 4 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 254,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 17, 13818.54m, 0.676m, 0.926m, 4 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 255,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 17, 14128.21m, 0.682m, 0.935m, 4 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 256,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 18, 8528.432m, 0.7049m, 0.9796m, 3 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 257,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 18, 9215.681m, 0.709m, 0.9796m, 3 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 258,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 18, 10035.87m, 0.6944m, 0.9796m, 3 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 259,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 18, 10896.88m, 0.6939m, 0.9796m, 3 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 260,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 18, 10973.63m, 0.6927m, 0.9791m, 3 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 261,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 18, 11955.35m, 0.6714m, 0.9791m, 3 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 262,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 18, 13225.74m, 0.6901m, 0.9791m, 3 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 263,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 18, 13682.88m, 0.7171m, 0.9791m, 3 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 264,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 18, 13839.55m, 0.7122m, 0.9791m, 3 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 265,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 18, 14080.1m, 0.725m, 0.979m, 3 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 266,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 18, 13795.57m, 0.727m, 0.979m, 3 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 267,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 18, 13564.83m, 0.731m, 0.98m, 3 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 268,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 18, 13425.35m, 0.729m, 0.98m, 3 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 269,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 18, 13780.44m, 0.758m, 0.98m, 3 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 270,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 18, 14055.81m, 0.725m, 0.975m, 3 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 271,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 19, 11869.25m, 0.6936m, 0.9796m, 3 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 272,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 19, 11950.02m, 0.7014m, 0.9796m, 3 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 273,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 19, 12487.12m, 0.7111m, 0.9796m, 3 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 274,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 19, 13050.83m, 0.718m, 0.9796m, 3 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 275,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 19, 13639.48m, 0.7194m, 0.9747m, 3 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 276,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 19, 13723.37m, 0.7266m, 0.9747m, 3 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 277,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 19, 14407.34m, 0.7225m, 0.9747m, 3 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 278,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 19, 15090.66m, 0.7241m, 0.9747m, 3 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 279,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 19, 14708.16m, 0.7165m, 0.9747m, 3 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 280,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 19, 15421.34m, 0.732m, 0.975m, 3 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 281,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 19, 16329.73m, 0.736m, 0.975m, 3 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 282,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 19, 17226.94m, 0.727m, 0.974m, 3 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 283,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 19, 18123.47m, 0.749m, 0.977m, 3 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 284,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 19, 18212.87m, 0.782m, 0.977m, 3 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 285,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 19, 18518.07m, 0.786m, 0.973m, 3 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 286,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 20, 28913.61m, 0.643m, 0.9693m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 287,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 20, 29433.94m, 0.6522m, 0.9657m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 288,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 20, 30861.55m, 0.6694m, 0.9657m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 289,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 20, 32390.08m, 0.6706m, 0.9657m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 290,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 20, 31784.46m, 0.6642m, 0.9701m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 291,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 20, 31838.52m, 0.6567m, 0.9701m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 292,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 20, 30943.8m, 0.6732m, 0.9701m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 293,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 20, 31302.44m, 0.6801m, 0.9701m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 294,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 20, 28134.52m, 0.6741m, 0.9738m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 295,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 20, 26573.7m, 0.671m, 0.974m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 296,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 20, 28213.66m, 0.684m, 0.974m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 297,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 20, 30740.82m, 0.684m, 0.966m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 298,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 20, 31231.65m, 0.684m, 0.967m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 299,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 20, 31195.15m, 0.692m, 0.967m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 300,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 20, 32277.05m, 0.707m, 0.96m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 301,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 21, 27196.85m, 0.6712m, 0.9791m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 302,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 21, 27705.34m, 0.6718m, 0.9791m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 303,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 21, 29988.71m, 0.677m, 0.9791m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 304,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 21, 31357.72m, 0.6789m, 0.9791m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 305,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 21, 29942.91m, 0.685m, 0.9792m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 306,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 21, 30248.04m, 0.6789m, 0.9792m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 307,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 21, 31103.62m, 0.6767m, 0.9788m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 308,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 21, 30926.77m, 0.677m, 0.9788m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 309,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 21, 30528.3m, 0.6737m, 0.9791m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 310,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 21, 31913.36m, 0.687m, 0.979m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 311,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 21, 32727.12m, 0.69m, 0.979m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 312,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 21, 33439.74m, 0.688m, 0.98m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 313,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 21, 35558.49m, 0.693m, 0.98m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 314,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 21, 36702.57m, 0.706m, 0.98m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 315,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 21, 37498.86m, 0.711m, 0.978m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 316,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 22, 41550.17m, 0.7524m, 0.9791m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 317,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 22, 42579.18m, 0.7618m, 0.9783m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 318,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 22, 45080.32m, 0.7394m, 0.9783m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 319,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 22, 46249.3m, 0.7449m, 0.9783m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 320,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 22, 43224.02m, 0.753m, 0.9784m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 321,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 22, 45418.51m, 0.759m, 0.9784m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 322,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 22, 47736.39m, 0.7629m, 0.978m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 323,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 22, 47295.05m, 0.7583m, 0.978m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 324,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 22, 47284.86m, 0.778m, 0.9739m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 325,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 22, 48772.03m, 0.779m, 0.979m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 326,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 22, 48046.2m, 0.766m, 0.979m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 327,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 22, 49236.44m, 0.778m, 0.975m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 328,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 22, 51232.92m, 0.776m, 0.973m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 329,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 22, 51263.23m, 0.787m, 0.973m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 330,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 22, 51167.88m, 0.796m, 0.972m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 331,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 23, 43014.77m, 0.7462m, 0.9723m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 332,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 23, 44565.45m, 0.7519m, 0.9696m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 333,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 23, 45669.44m, 0.7538m, 0.9696m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 334,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 23, 48275.52m, 0.7628m, 0.9696m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 335,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 23, 45988.15m, 0.7719m, 0.9743m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 336,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 23, 48841.48m, 0.7778m, 0.9743m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 337,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 23, 49667.98m, 0.7777m, 0.9739m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 338,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 23, 49081.82m, 0.7779m, 0.9739m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 339,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 23, 47951.3m, 0.8025m, 0.9741m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 340,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 23, 47842.09m, 0.767m, 0.97m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 341,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 23, 47473.49m, 0.754m, 0.97m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 342,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 23, 48909.96m, 0.776m, 0.971m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 343,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 23, 51650.79m, 0.778m, 0.971m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 344,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 23, 51909.02m, 0.782m, 0.971m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 345,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 23, 54006.6m, 0.768m, 0.964m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 346,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 24, 9431.057m, 0.6639m, 0.9796m, 3 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 347,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 24, 10493.74m, 0.6705m, 0.9796m, 3 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 348,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 24, 11405.81m, 0.6744m, 0.9796m, 3 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 349,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 24, 11559.29m, 0.6859m, 0.9796m, 3 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 350,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 24, 12148.6m, 0.6774m, 0.9711m, 3 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 351,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 24, 13095.83m, 0.6682m, 0.9711m, 3 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 352,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 24, 13230.57m, 0.6659m, 0.9711m, 3 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 353,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 24, 13327.3m, 0.6867m, 0.9711m, 3 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 354,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 24, 13387.43m, 0.6906m, 0.9706m, 3 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 355,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 24, 13997.12m, 0.686m, 0.971m, 3 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 356,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 24, 15160.28m, 0.676m, 0.971m, 3 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 357,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 24, 16168.53m, 0.697m, 0.98m, 3 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 358,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 24, 16555.26m, 0.701m, 0.98m, 3 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 359,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 24, 17153.32m, 0.7m, 0.98m, 3 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 360,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 24, 17924.57m, 0.699m, 0.98m, 3 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 361,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 25, 12353.09m, 0.6018m, 0.9712m, 2 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 362,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 25, 13420.85m, 0.6068m, 0.9714m, 2 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 363,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 25, 13688.51m, 0.6111m, 0.9714m, 2 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 364,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 25, 14429.68m, 0.6119m, 0.9714m, 2 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 365,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 25, 13041.87m, 0.6052m, 0.9661m, 2 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 366,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 25, 14804.46m, 0.5991m, 0.9661m, 2 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 367,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 25, 15519.29m, 0.6112m, 0.9661m, 2 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 368,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 25, 14964.62m, 0.5966m, 0.9661m, 2 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 369,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 25, 14274.24m, 0.6182m, 0.9661m, 2 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 370,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 25, 13800.08m, 0.632m, 0.966m, 2 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 371,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 25, 12507.44m, 0.642m, 0.966m, 2 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 372,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 25, 11850.55m, 0.629m, 0.97m, 2 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 373,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 25, 11405.15m, 0.629m, 0.962m, 2 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 374,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 25, 11770.47m, 0.634m, 0.962m, 2 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 375,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 25, 11784.33m, 0.633m, 0.958m, 2 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 376,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 26, 7964.299m, 0.6433m, 0.9796m, 3 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 377,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 26, 8461.051m, 0.6881m, 0.9796m, 3 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 378,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 26, 8833.104m, 0.7091m, 0.9796m, 3 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 379,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 26, 9665.452m, 0.722m, 0.9796m, 3 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 380,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 26, 9227.033m, 0.7072m, 0.9758m, 3 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 381,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 26, 9909.65m, 0.7035m, 0.9758m, 3 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 382,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 26, 10798.28m, 0.7206m, 0.9758m, 3 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 383,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 26, 11379.41m, 0.7389m, 0.9758m, 3 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 384,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 26, 12182.75m, 0.7455m, 0.9796m, 3 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 385,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 26, 12240.8m, 0.738m, 0.98m, 3 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 386,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 26, 11355.71m, 0.726m, 0.98m, 3 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 387,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 26, 11040.56m, 0.724m, 0.977m, 3 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 388,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 26, 11413.87m, 0.729m, 0.978m, 3 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 389,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 26, 11475.64m, 0.729m, 0.978m, 3 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 390,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 26, 11236.89m, 0.739m, 0.968m, 3 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 391,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 27, 6153.4m, 0.5786m, 0.9738m, 2 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 392,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 27, 6531.302m, 0.5809m, 0.9717m, 2 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 393,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 27, 7413.009m, 0.5832m, 0.9717m, 2 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 394,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 27, 8747.321m, 0.5862m, 0.9717m, 2 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 395,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 27, 9276.815m, 0.5899m, 0.9768m, 2 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 396,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 27, 10419.5m, 0.5933m, 0.9768m, 2 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 397,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 27, 11504.5m, 0.5975m, 0.9768m, 2 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 398,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 27, 13117.63m, 0.5935m, 0.9768m, 2 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 399,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 27, 12747.41m, 0.6064m, 0.9765m, 2 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 400,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 27, 12363.98m, 0.599m, 0.971m, 2 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 401,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 27, 12621.44m, 0.614m, 0.971m, 2 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 402,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 27, 12098.34m, 0.608m, 0.971m, 2 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 403,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 27, 12010.29m, 0.614m, 0.974m, 2 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 404,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 27, 12279.16m, 0.629m, 0.974m, 2 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 405,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 27, 12060.78m, 0.639m, 0.968m, 2 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 406,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 28, 32432.04m, 0.7319m, 0.973m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 407,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 28, 34809.9m, 0.7444m, 0.973m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 408,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 28, 36540.93m, 0.7281m, 0.973m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 409,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 28, 36627.07m, 0.7345m, 0.973m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 410,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 28, 34940.63m, 0.7554m, 0.9755m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 411,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 28, 34560.06m, 0.758m, 0.9761m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 412,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 28, 34290.02m, 0.7266m, 0.9791m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 413,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 28, 34073.22m, 0.7266m, 0.973m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 414,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 28, 33544.73m, 0.7325m, 0.9719m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 415,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 28, 33736.81m, 0.742m, 0.972m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 416,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 28, 35767.14m, 0.738m, 0.972m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 417,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 28, 37262.44m, 0.746m, 0.973m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 418,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 28, 38920.23m, 0.746m, 0.972m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 419,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 28, 39601.23m, 0.795m, 0.972m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 420,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 28, 40357.64m, 0.788m, 0.965m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 421,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 29, 20280.02m, 0.6944m, 0.9791m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 422,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 29, 22029.73m, 0.7008m, 0.9791m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 423,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 29, 24726.53m, 0.7076m, 0.9791m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 424,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 29, 25213.69m, 0.7094m, 0.9791m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 425,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 29, 22521.9m, 0.7018m, 0.9773m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 426,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 29, 23838.14m, 0.6983m, 0.9773m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 427,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 29, 26688.29m, 0.6977m, 0.9791m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 428,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 29, 28259.26m, 0.6997m, 0.9791m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 429,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 29, 28582.23m, 0.7017m, 0.9791m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 430,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 29, 29212.15m, 0.749m, 0.98m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 431,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 29, 28499.38m, 0.747m, 0.98m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 432,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 29, 29301.3m, 0.731m, 0.979m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 433,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 29, 30962.01m, 0.734m, 0.979m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 434,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 29, 32260.09m, 0.751m, 0.974m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 435,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 29, 33832.43m, 0.733m, 0.975m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 436,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 30, 806.0986m, 0.5946m, 0.9687m, 6 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 437,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 30, 793.4785m, 0.5991m, 0.9686m, 6 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 438,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 30, 919.3663m, 0.5867m, 0.9686m, 6 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 439,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 30, 978.5058m, 0.5948m, 0.9686m, 6 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 440,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 30, 1006.862m, 0.6019m, 0.9737m, 6 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 441,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 30, 1155.448m, 0.6136m, 0.9737m, 6 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 442,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 30, 1267.238m, 0.62m, 0.9737m, 6 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 443,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 30, 1336.011m, 0.6198m, 0.9737m, 6 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 444,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 30, 1400.865m, 0.6144m, 0.9725m, 6 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 445,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 30, 1666.365m, 0.64m, 0.978m, 6 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 446,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 30, 1758.53m, 0.662m, 0.978m, 6 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 447,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 30, 1970.289m, 0.656m, 0.979m, 6 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 448,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 30, 2025.749m, 0.656m, 0.976m, 6 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 449,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 30, 2266.101m, 0.705m, 0.976m, 6 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 450,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 30, 2720.894m, 0.691m, 0.971m, 6 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 451,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 31, 40521.86m, 0.7958m, 0.9796m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 452,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 31, 41227.84m, 0.8044m, 0.9796m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 453,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 31, 44665.5m, 0.8195m, 0.9796m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 454,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 31, 46188.7m, 0.8252m, 0.9796m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 455,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 31, 42168.53m, 0.826m, 0.9796m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 456,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 31, 43454.75m, 0.8383m, 0.9796m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 457,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 31, 44063.07m, 0.8451m, 0.9796m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 458,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 31, 43460.1m, 0.8421m, 0.9796m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 459,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 31, 41413.79m, 0.8453m, 0.9789m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 460,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 31, 41128.09m, 0.85m, 0.98m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 461,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 31, 41647.56m, 0.845m, 0.98m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 462,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 31, 42564.32m, 0.823m, 0.978m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 463,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 31, 43813.53m, 0.821m, 0.977m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 464,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 31, 44184.53m, 0.832m, 0.977m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 465,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 31, 44914.22m, 0.861m, 0.97m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 466,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 32, 37593.06m, 0.652m, 0.9796m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 467,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 32, 38295.08m, 0.6824m, 0.9796m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 468,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 32, 39844.93m, 0.7341m, 0.9796m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 469,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 32, 39968.11m, 0.7331m, 0.9796m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 470,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 32, 38495.41m, 0.7025m, 0.9796m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 471,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 32, 39887.65m, 0.7018m, 0.9796m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 472,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 32, 40805.74m, 0.6984m, 0.9796m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 473,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 32, 41121.16m, 0.7089m, 0.9796m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 474,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 32, 40516.89m, 0.7588m, 0.9796m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 475,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 32, 40406.05m, 0.761m, 0.98m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 476,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 32, 40985.87m, 0.755m, 0.98m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 477,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 32, 41373.23m, 0.778m, 0.977m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 478,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 32, 42805.2m, 0.779m, 0.974m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 479,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 32, 43178.74m, 0.781m, 0.974m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 480,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 32, 43740.94m, 0.784m, 0.97m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 481,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 33, 39416.8m, 0.7365m, 0.9742m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 482,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 33, 39707.22m, 0.7441m, 0.9745m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 483,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 33, 39238.41m, 0.7366m, 0.9745m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 484,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 33, 40164.89m, 0.7402m, 0.9745m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 485,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 33, 36943.61m, 0.746m, 0.9698m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 486,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 33, 39097m, 0.7462m, 0.9698m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 487,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 33, 39305.18m, 0.7433m, 0.9698m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 488,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 33, 40055.49m, 0.744m, 0.9698m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 489,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 33, 41310.21m, 0.7383m, 0.9699m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 490,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 33, 41270.71m, 0.758m, 0.974m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 491,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 33, 42616.1m, 0.752m, 0.974m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 492,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 33, 42630.47m, 0.77m, 0.971m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 493,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 33, 44080.61m, 0.774m, 0.97m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 494,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 33, 44283.91m, 0.767m, 0.97m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 495,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 33, 44260.21m, 0.775m, 0.966m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 496,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 34, 6091.039m, 0.67m, 0.9227m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 497,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 34, 7031.313m, 0.6665m, 0.9332m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 498,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 34, 7905.733m, 0.6654m, 0.9386m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 499,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 34, 8302.201m, 0.668m, 0.9386m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 500,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 34, 8478.726m, 0.6598m, 0.9441m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 501,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 34, 8909.877m, 0.6624m, 0.948m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 502,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 34, 9715.087m, 0.6691m, 0.9497m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 503,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 34, 10507.79m, 0.675m, 0.9553m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 504,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 34, 10950.74m, 0.6855m, 0.967m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 505,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 34, 11738.04m, 0.687m, 0.967m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 506,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 34, 12690.47m, 0.681m, 0.967m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 507,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 34, 13282.19m, 0.679m, 0.967m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 508,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 34, 14365.12m, 0.677m, 0.967m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 509,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 34, 15134.82m, 0.708m, 0.976m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 510,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 34, 17047.72m, 0.732m, 0.977m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 511,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 35, 3347.134m, 0.6653m, 0.9685m, 6 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 512,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 35, 3353.024m, 0.6725m, 0.9674m, 6 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 513,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 35, 3924.523m, 0.6679m, 0.9674m, 6 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 514,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 35, 4304.252m, 0.6704m, 0.9674m, 6 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 515,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 35, 3999.883m, 0.6782m, 0.9674m, 6 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 516,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 35, 4364.024m, 0.6811m, 0.9674m, 6 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 517,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 35, 4842.414m, 0.6778m, 0.9674m, 6 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 518,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 35, 5338.8m, 0.6811m, 0.9674m, 6 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 519,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 35, 5636.896m, 0.6661m, 0.9669m, 6 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 520,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 35, 5832.561m, 0.704m, 0.973m, 6 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 521,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 35, 5355.151m, 0.705m, 0.973m, 6 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 522,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 35, 5023.095m, 0.695m, 0.968m, 6 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 523,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 35, 5081.288m, 0.688m, 0.968m, 6 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 524,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 35, 5112.7m, 0.673m, 0.968m, 6 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 525,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 35, 5364.133m, 0.666m, 0.978m, 6 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 526,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 36, 29079m, 0.654m, 0.9779m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 527,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 36, 31461.09m, 0.6648m, 0.9785m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 528,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 36, 31665.09m, 0.6727m, 0.9785m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 529,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 36, 32840.14m, 0.6662m, 0.9785m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 530,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 36, 32009.2m, 0.6908m, 0.9712m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 531,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 36, 29787.98m, 0.6916m, 0.9712m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 532,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 36, 27142.98m, 0.6716m, 0.9737m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 533,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 36, 26106.96m, 0.6782m, 0.9737m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 534,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 36, 26238.17m, 0.6784m, 0.9785m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 535,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 36, 26009.54m, 0.685m, 0.979m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 536,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 36, 26324.04m, 0.68m, 0.979m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 537,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 36, 25811.51m, 0.692m, 0.973m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 538,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 36, 26470.04m, 0.696m, 0.971m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 539,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 36, 26595.88m, 0.701m, 0.971m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 540,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 36, 27194.74m, 0.689m, 0.966m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 541,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 37, 6019.282m, 0.6067m, 0.9796m, 3 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 542,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 37, 6234.076m, 0.6144m, 0.9796m, 3 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 543,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 37, 6527.144m, 0.6072m, 0.9796m, 3 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 544,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 37, 6697.604m, 0.6209m, 0.9796m, 3 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 545,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 37, 6729.442m, 0.6238m, 0.9796m, 3 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 546,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 37, 6941.17m, 0.6229m, 0.9796m, 3 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 547,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 37, 7311.401m, 0.626m, 0.9796m, 3 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 548,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 37, 7688.159m, 0.6304m, 0.9796m, 3 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 549,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 37, 7549.211m, 0.6821m, 0.9796m, 3 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 550,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 37, 7533.717m, 0.667m, 0.98m, 3 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 551,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 37, 7737.782m, 0.666m, 0.98m, 3 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 552,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 37, 7599.767m, 0.667m, 0.98m, 3 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 553,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 37, 7507.844m, 0.668m, 0.98m, 3 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 554,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 37, 7611.654m, 0.666m, 0.98m, 3 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 555,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 37, 7769.625m, 0.655m, 0.979m, 3 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 556,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 38, 4056.242m, 0.6483m, 0.9796m, 3 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 557,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 38, 4097.498m, 0.6661m, 0.9796m, 3 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 558,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 38, 4267.151m, 0.696m, 0.9796m, 3 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 559,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 38, 4018.481m, 0.6893m, 0.9796m, 3 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 560,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 38, 3957.789m, 0.6927m, 0.9762m, 3 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 561,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 38, 4111.676m, 0.6945m, 0.9762m, 3 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 562,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 38, 4354.748m, 0.6763m, 0.9762m, 3 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 563,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 38, 4573.584m, 0.6773m, 0.9762m, 3 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 564,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 38, 4343.721m, 0.6935m, 0.976m, 3 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 565,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 38, 4568.989m, 0.688m, 0.976m, 3 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 566,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 38, 4976.306m, 0.69m, 0.976m, 3 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 567,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 38, 5222.445m, 0.711m, 0.974m, 3 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 568,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 38, 5347.055m, 0.706m, 0.977m, 3 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 569,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 38, 5359.716m, 0.722m, 0.977m, 3 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 570,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 38, 5427.544m, 0.716m, 0.964m, 3 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 571,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 39, 18144.97m, 0.7145m, 0.9791m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 572,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 39, 19894.5m, 0.721m, 0.9791m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 573,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 39, 21539.05m, 0.6967m, 0.9791m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 574,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 39, 22902.83m, 0.6944m, 0.9791m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 575,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 39, 21797.88m, 0.6939m, 0.9796m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 576,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 39, 21630.39m, 0.7006m, 0.9796m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 577,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 39, 22422.15m, 0.7053m, 0.9791m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 578,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 39, 22531.12m, 0.7069m, 0.9791m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 579,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 39, 21526.65m, 0.7075m, 0.9791m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 580,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 39, 21467.78m, 0.708m, 0.979m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 581,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 39, 22537.31m, 0.7m, 0.979m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 582,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 39, 23316.35m, 0.711m, 0.98m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 583,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 39, 25347.77m, 0.712m, 0.98m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 584,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 39, 25090.38m, 0.72m, 0.979m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 585,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 39, 25985.32m, 0.733m, 0.978m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 586,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 40, 21178.01m, 0.6698m, 0.9791m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 587,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 40, 21229.65m, 0.6731m, 0.9791m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 588,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 40, 21418.1m, 0.6867m, 0.9791m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 589,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 40, 23243.78m, 0.6879m, 0.9791m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 590,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 40, 22457.1m, 0.672m, 0.9779m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 591,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 40, 23797.95m, 0.6642m, 0.9796m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 592,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 40, 24398.83m, 0.6718m, 0.9791m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 593,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 40, 24162.6m, 0.6742m, 0.9791m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 594,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 40, 24281.65m, 0.6759m, 0.9791m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 595,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 40, 24880.11m, 0.672m, 0.979m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 596,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 40, 25261.47m, 0.669m, 0.979m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 597,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 40, 25349.2m, 0.67m, 0.979m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 598,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 40, 26890.54m, 0.674m, 0.979m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 599,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 40, 27894.91m, 0.677m, 0.98m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 600,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 40, 29215.16m, 0.688m, 0.98m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 601,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 41, 4453.043m, 0.6541m, 0.9687m, 4 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 602,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 41, 4878.546m, 0.655m, 0.9719m, 4 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 603,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 41, 5392.464m, 0.6473m, 0.9719m, 4 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 604,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 41, 6382.458m, 0.658m, 0.9719m, 4 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 605,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 41, 6984.45m, 0.6615m, 0.9663m, 4 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 606,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 41, 8177.723m, 0.6594m, 0.9663m, 4 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 607,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 41, 9776.39m, 0.6591m, 0.9663m, 4 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 608,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 41, 10309.85m, 0.6613m, 0.9663m, 4 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 609,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 41, 10406.54m, 0.6725m, 0.9762m, 4 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 610,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 41, 10459.07m, 0.681m, 0.976m, 4 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 611,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 41, 10248.12m, 0.682m, 0.976m, 4 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 612,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 41, 10316.6m, 0.691m, 0.976m, 4 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 613,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 41, 10641.66m, 0.691m, 0.974m, 4 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 614,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 41, 11248.79m, 0.7m, 0.974m, 4 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 615,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 41, 11596.19m, 0.688m, 0.971m, 4 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 616,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 42, 2974.039m, 0.6011m, 0.9624m, 7 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 617,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 42, 3282.039m, 0.5936m, 0.9315m, 7 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 618,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 42, 3622.766m, 0.606m, 0.9315m, 7 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 619,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 42, 3785.15m, 0.6151m, 0.9315m, 7 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 620,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 42, 3992.099m, 0.6155m, 0.9312m, 7 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 621,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 42, 4555.339m, 0.619m, 0.9312m, 7 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 622,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 42, 4894.314m, 0.6442m, 0.9312m, 7 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 623,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 42, 5231.032m, 0.6551m, 0.9312m, 7 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 624,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 42, 5237.726m, 0.6455m, 0.9366m, 7 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 625,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 42, 5397.838m, 0.664m, 0.942m, 7 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 626,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 42, 5635.252m, 0.683m, 0.942m, 7 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 627,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 42, 5887.352m, 0.669m, 0.942m, 7 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 628,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 42, 6189.438m, 0.665m, 0.94m, 7 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 629,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 42, 6580.557m, 0.668m, 0.944m, 7 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 630,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 42, 6712.484m, 0.625m, 0.937m, 7 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 631,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 43, 55869.77m, 0.7335m, 0.9701m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 632,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 43, 56334.3m, 0.7457m, 0.9727m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 633,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 43, 60179.77m, 0.7518m, 0.9727m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 634,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 43, 56248.86m, 0.7597m, 0.9727m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 635,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 43, 52873.71m, 0.7773m, 0.97m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 636,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 43, 52981.9m, 0.783m, 0.9741m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 637,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 43, 53710.02m, 0.7839m, 0.9737m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 638,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 43, 54409.05m, 0.7823m, 0.9737m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 639,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 43, 54237.27m, 0.785m, 0.9739m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 640,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 43, 58401.34m, 0.807m, 0.979m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 641,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 43, 75982.69m, 0.797m, 0.979m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 642,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 43, 81182.03m, 0.794m, 0.971m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 643,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 43, 86796.97m, 0.796m, 0.97m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 644,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 43, 91627.61m, 0.798m, 0.97m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 645,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 43, 102624.6m, 0.8m, 0.964m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 646,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 44, 14919.16m, 0.5803m, 0.978m, 2 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 647,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 44, 15902.45m, 0.5903m, 0.9776m, 2 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 648,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 44, 17913.55m, 0.6021m, 0.9776m, 2 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 649,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 44, 17712.07m, 0.5839m, 0.9776m, 2 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 650,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 44, 18042.69m, 0.5933m, 0.9714m, 2 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 651,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 44, 19114.09m, 0.5894m, 0.9714m, 2 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 652,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 44, 19991.1m, 0.5927m, 0.9714m, 2 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 653,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 44, 17010.09m, 0.5842m, 0.9714m, 2 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 654,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 44, 16179.26m, 0.5811m, 0.9709m, 2 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 655,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 44, 15577.86m, 0.58m, 0.971m, 2 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 656,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 44, 13496.41m, 0.587m, 0.971m, 2 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 657,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 44, 13909.79m, 0.583m, 0.963m, 2 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 658,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 44, 14039.69m, 0.589m, 0.966m, 2 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 659,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 44, 13188.23m, 0.584m, 0.966m, 2 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 660,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 44, 13239.32m, 0.582m, 0.963m, 2 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 661,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 45, 45600.8m, 0.7813m, 0.9679m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 662,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 45, 43683.77m, 0.7836m, 0.9697m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 663,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 45, 45269.98m, 0.7999m, 0.9697m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 664,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 45, 56658.66m, 0.8276m, 0.9697m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 665,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 45, 47760.32m, 0.8496m, 0.9696m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 666,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 45, 43332.33m, 0.853m, 0.9696m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 667,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 45, 44037.83m, 0.864m, 0.9696m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 668,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 45, 45519.32m, 0.8731m, 0.9696m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 669,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 45, 45032.73m, 0.8594m, 0.9654m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 670,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 45, 45555.75m, 0.881m, 0.97m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 671,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 45, 47402.22m, 0.874m, 0.97m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 672,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 45, 48587.94m, 0.878m, 0.969m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 673,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 45, 49827.54m, 0.858m, 0.968m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 674,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 45, 50327.15m, 0.877m, 0.968m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 675,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 45, 53000.6m, 0.892m, 0.964m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 676,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 46, 31806.46m, 0.6889m, 0.9694m, 2 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 677,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 46, 31467.65m, 0.6965m, 0.9699m, 2 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 678,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 46, 31270.51m, 0.69m, 0.9699m, 2 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 679,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 46, 30684.67m, 0.7019m, 0.9699m, 2 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 680,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 46, 31670.19m, 0.6957m, 0.9697m, 2 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 681,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 46, 32671.2m, 0.6926m, 0.9697m, 2 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 682,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 46, 33653.17m, 0.6989m, 0.9697m, 2 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 683,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 46, 34900.21m, 0.7032m, 0.9697m, 2 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 684,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 46, 36067.95m, 0.7005m, 0.9698m, 2 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 685,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 46, 36219.63m, 0.712m, 0.974m, 2 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 686,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 46, 37270m, 0.719m, 0.974m, 2 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 687,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 46, 39027.33m, 0.721m, 0.971m, 2 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 688,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 46, 38967.32m, 0.722m, 0.971m, 2 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 689,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 46, 38231.65m, 0.718m, 0.971m, 2 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 690,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 46, 38549.37m, 0.724m, 0.964m, 2 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 691,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 47, 36432.05m, 0.6456m, 0.9717m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 692,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 47, 37623.11m, 0.6498m, 0.9719m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 693,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 47, 39271.13m, 0.6788m, 0.9719m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 694,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 47, 40034.05m, 0.6798m, 0.9719m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 695,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 47, 38331.64m, 0.6765m, 0.9697m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 696,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 47, 38644.79m, 0.6796m, 0.9738m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 697,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 47, 39448.75m, 0.6729m, 0.9733m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 698,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 47, 38429.34m, 0.6885m, 0.9733m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 699,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 47, 37334.64m, 0.6973m, 0.9737m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 700,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 47, 36953.3m, 0.726m, 0.974m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 701,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 47, 36988.99m, 0.719m, 0.974m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 702,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 47, 38749.23m, 0.692m, 0.967m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 703,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 47, 40148.95m, 0.706m, 0.969m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 704,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 47, 40540.19m, 0.707m, 0.969m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 705,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 47, 40725.62m, 0.721m, 0.965m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 706,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 48, 6877.951m, 0.7014m, 0.9696m, 3 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 707,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 48, 7090.603m, 0.6925m, 0.9707m, 3 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 708,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 48, 7474.993m, 0.698m, 0.9707m, 3 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 709,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 48, 7396.333m, 0.7013m, 0.9707m, 3 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 710,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 48, 7389.214m, 0.7037m, 0.9796m, 3 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 711,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 48, 7531.876m, 0.7028m, 0.9796m, 3 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 712,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 48, 7647.493m, 0.7035m, 0.9796m, 3 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 713,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 48, 7935.644m, 0.7085m, 0.9796m, 3 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 714,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 48, 8065.223m, 0.7128m, 0.9796m, 3 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 715,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 48, 8037.566m, 0.703m, 0.98m, 3 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 716,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 48, 8087.246m, 0.724m, 0.98m, 3 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 717,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 48, 8090.927m, 0.717m, 0.972m, 3 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 718,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 48, 8204.784m, 0.724m, 0.976m, 3 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 719,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 48, 8418.144m, 0.735m, 0.976m, 3 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 720,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 48, 8432.85m, 0.741m, 0.968m, 3 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 721,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 49, 6392.296m, 0.6109m, 0.9746m, 2 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 722,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 49, 7244.697m, 0.6203m, 0.971m, 2 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 723,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 49, 7955.912m, 0.6275m, 0.971m, 2 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 724,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 49, 9316.941m, 0.6182m, 0.971m, 2 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 725,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 49, 10550.63m, 0.6048m, 0.9706m, 2 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 726,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 49, 10610.39m, 0.6117m, 0.9706m, 2 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 727,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 49, 11669.83m, 0.6103m, 0.9706m, 2 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 728,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 49, 11802.63m, 0.6093m, 0.9706m, 2 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 729,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 49, 11126.12m, 0.5968m, 0.9655m, 2 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 730,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 49, 10659.5m, 0.593m, 0.966m, 2 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 731,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 49, 10453.66m, 0.603m, 0.966m, 2 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 732,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 49, 10084.21m, 0.604m, 0.969m, 2 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 733,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 49, 10576.56m, 0.605m, 0.971m, 2 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 734,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 49, 10840.76m, 0.623m, 0.971m, 2 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 735,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 49, 10784.9m, 0.638m, 0.957m, 2 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 736,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 50, 39816.1m, 0.6447m, 0.9796m, 4 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 737,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 50, 40248.34m, 0.6455m, 0.9791m, 4 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 738,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 50, 41013.32m, 0.6434m, 0.9791m, 4 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 739,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 50, 40295.78m, 0.6445m, 0.9791m, 4 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 740,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 50, 38051.13m, 0.6524m, 0.9796m, 4 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 741,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 50, 39782.06m, 0.6514m, 0.9796m, 4 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 742,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 50, 39154.7m, 0.653m, 0.9791m, 4 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 743,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 50, 39228.25m, 0.6498m, 0.9791m, 4 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 744,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 50, 39659.02m, 0.6584m, 0.9791m, 4 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 745,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 50, 39164.37m, 0.67m, 0.979m, 4 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 746,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 50, 40266.57m, 0.66m, 0.979m, 4 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 747,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 50, 39459.27m, 0.657m, 0.98m, 4 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 748,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 50, 39590.48m, 0.662m, 0.979m, 4 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 749,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 50, 39343.95m, 0.652m, 0.979m, 4 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 750,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 50, 39696.01m, 0.656m, 0.973m, 4 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 751,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 51, 11327.38m, 0.6928m, 0.9791m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 752,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 51, 13785.67m, 0.6983m, 0.9791m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 753,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 51, 16015.73m, 0.6976m, 0.9791m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 754,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 51, 18475.41m, 0.7013m, 0.9791m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 755,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 51, 17390.52m, 0.7055m, 0.9796m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 756,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 51, 20422.24m, 0.701m, 0.9796m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 757,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 51, 24606.45m, 0.7213m, 0.9796m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 758,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 51, 25478.92m, 0.7218m, 0.9796m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 759,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 51, 26628.67m, 0.721m, 0.9796m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 760,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 51, 27302.66m, 0.719m, 0.98m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 761,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 51, 23782.24m, 0.718m, 0.98m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 762,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 51, 23052.45m, 0.713m, 0.979m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 763,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 51, 26069.11m, 0.712m, 0.979m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 764,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 51, 26527.25m, 0.71m, 0.975m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 765,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 51, 28303.06m, 0.71m, 0.975m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 766,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 52, 2093.664m, 0.6486m, 0.9663m, 6 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 767,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 52, 2248.688m, 0.6508m, 0.9681m, 6 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 768,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 52, 2328.823m, 0.6547m, 0.9681m, 6 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 769,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 52, 2348.923m, 0.6512m, 0.9681m, 6 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 770,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 52, 2425.467m, 0.6499m, 0.9677m, 6 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 771,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 52, 2608.45m, 0.6493m, 0.9677m, 6 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 772,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 52, 2757.037m, 0.6768m, 0.9677m, 6 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 773,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 52, 2918.937m, 0.6803m, 0.9677m, 6 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 774,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 52, 3051.254m, 0.7258m, 0.973m, 6 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 775,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 52, 3285.207m, 0.719m, 0.973m, 6 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 776,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 52, 3538.143m, 0.702m, 0.973m, 6 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 777,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 52, 3722.632m, 0.694m, 0.98m, 6 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 778,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 52, 4044.764m, 0.7m, 0.98m, 6 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 779,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 52, 4127.743m, 0.671m, 0.98m, 6 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 780,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 52, 4236.643m, 0.692m, 0.975m, 6 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 781,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 53, 2549.65m, 0.6742m, 0.9796m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 782,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 53, 2921.435m, 0.6653m, 0.9796m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 783,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 53, 3263.315m, 0.7045m, 0.9796m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 784,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 53, 3765.768m, 0.7058m, 0.9796m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 785,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 53, 3704.752m, 0.6973m, 0.9796m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 786,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 53, 3656.897m, 0.7036m, 0.9796m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 787,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 53, 4442.962m, 0.7013m, 0.973m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 788,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 53, 4856.137m, 0.6948m, 0.973m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 789,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 53, 5034.823m, 0.6974m, 0.973m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 790,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 53, 7215.537m, 0.693m, 0.973m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 791,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 53, 4851.943m, 0.687m, 0.973m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 792,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 53, 5239.709m, 0.691m, 0.98m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 793,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 53, 6033.386m, 0.691m, 0.98m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 794,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 53, 6303.208m, 0.689m, 0.98m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 795,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 53, 6133.621m, 0.681m, 0.98m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 796,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 54, 1983.916m, 0.6291m, 0.9796m, 4 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 797,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 54, 2080.934m, 0.6353m, 0.9796m, 4 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 798,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 54, 2307.074m, 0.6469m, 0.9796m, 4 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 799,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 54, 2536.14m, 0.641m, 0.9796m, 4 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 800,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 54, 2369.229m, 0.6482m, 0.9796m, 4 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 801,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 54, 2470.01m, 0.6464m, 0.9796m, 4 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 802,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 54, 2657.025m, 0.6457m, 0.9796m, 4 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 803,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 54, 2878.823m, 0.6509m, 0.9796m, 4 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 804,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 54, 3101.869m, 0.652m, 0.9796m, 4 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 805,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 54, 3171.229m, 0.662m, 0.98m, 4 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 806,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 54, 3480.937m, 0.658m, 0.98m, 4 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 807,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 54, 3681.608m, 0.676m, 0.98m, 4 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 808,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 54, 3950.591m, 0.683m, 0.975m, 4 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 809,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 54, 4266.601m, 0.694m, 0.975m, 4 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 810,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 54, 4498.798m, 0.684m, 0.978m, 4 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 811,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 55, 32082.73m, 0.6157m, 0.967m, 4 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 812,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 55, 33103.82m, 0.6409m, 0.967m, 4 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 813,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 55, 35001.27m, 0.6154m, 0.967m, 4 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 814,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 55, 34991m, 0.6146m, 0.973m, 4 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 815,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 55, 33625.8m, 0.6342m, 0.973m, 4 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 816,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 55, 35921.29m, 0.6281m, 0.9736m, 4 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 817,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 55, 35832.23m, 0.6356m, 0.973m, 4 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 818,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 55, 35769.38m, 0.6351m, 0.973m, 4 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 819,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 55, 34778.69m, 0.6403m, 0.973m, 4 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 820,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 55, 36234.36m, 0.651m, 0.973m, 4 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 821,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 55, 38241.97m, 0.649m, 0.973m, 4 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 822,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 55, 39207.47m, 0.65m, 0.973m, 4 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 823,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 55, 40868.13m, 0.657m, 0.973m, 4 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 824,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 55, 41386.29m, 0.672m, 0.98m, 4 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 825,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 55, 42212.36m, 0.687m, 0.976m, 4 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 826,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 56, 78004.16m, 0.6341m, 0.9611m, 2 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 827,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 56, 91534.94m, 0.6409m, 0.9612m, 2 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 828,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 56, 94025.02m, 0.6358m, 0.9612m, 2 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 829,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 56, 107651.9m, 0.6356m, 0.9612m, 2 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 830,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 56, 73107.03m, 0.6318m, 0.9612m, 2 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 831,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 56, 77892.52m, 0.6322m, 0.9612m, 2 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 832,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 56, 92064.08m, 0.632m, 0.9612m, 2 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 833,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 56, 99070.26m, 0.6292m, 0.9612m, 2 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 834,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 56, 92756.4m, 0.6457m, 0.9567m, 2 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 835,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 56, 81632.15m, 0.646m, 0.957m, 2 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 836,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 56, 54526.52m, 0.624m, 0.957m, 2 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 837,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 56, 52922.18m, 0.628m, 0.969m, 2 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 838,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 56, 56267.12m, 0.63m, 0.961m, 2 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 839,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 56, 64308.78m, 0.65m, 0.961m, 2 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 840,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 56, 62050.25m, 0.621m, 0.968m, 2 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 841,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 57, 5822.986m, 0.7199m, 0.9796m, 7 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 842,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 57, 6427.457m, 0.723m, 0.9796m, 7 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 843,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 57, 7011.885m, 0.7371m, 0.9796m, 7 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 844,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 57, 7533.309m, 0.7402m, 0.9796m, 7 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 845,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 57, 8347.969m, 0.7458m, 0.9796m, 7 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 846,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 57, 9201.482m, 0.7212m, 0.9796m, 7 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 847,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 57, 10293.76m, 0.7122m, 0.9796m, 7 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 848,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 57, 11348.6m, 0.7019m, 0.9796m, 7 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 849,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 57, 11623.36m, 0.6903m, 0.9796m, 7 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 850,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 57, 11731.42m, 0.686m, 0.98m, 7 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 851,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 57, 12043.65m, 0.673m, 0.98m, 7 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 852,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 57, 12555.59m, 0.669m, 0.98m, 7 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 853,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 57, 12731.63m, 0.676m, 0.98m, 7 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 854,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 57, 12985.14m, 0.68m, 0.98m, 7 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 855,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 57, 13288.65m, 0.67m, 0.98m, 7 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 856,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 58, 2769.84m, 0.6807m, 0.9796m, 6 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 857,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 58, 2836.272m, 0.7078m, 0.9796m, 6 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 858,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 58, 2743.656m, 0.732m, 0.9796m, 6 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 859,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 58, 3060.049m, 0.7495m, 0.9796m, 6 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 860,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 58, 2986.464m, 0.7678m, 0.9796m, 6 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 861,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 58, 2690.723m, 0.7666m, 0.9796m, 6 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 862,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 58, 2724.741m, 0.7608m, 0.9796m, 6 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 863,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 58, 2952.813m, 0.753m, 0.9796m, 6 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 864,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 58, 3052.32m, 0.7255m, 0.9758m, 6 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 865,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 58, 3210.278m, 0.706m, 0.98m, 6 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 866,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 58, 3380.096m, 0.706m, 0.98m, 6 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 867,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 58, 3230.121m, 0.695m, 0.979m, 6 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 868,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 58, 3031.721m, 0.693m, 0.98m, 6 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 869,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 58, 2679.655m, 0.695m, 0.98m, 6 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 870,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 58, 2692.582m, 0.698m, 0.98m, 6 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 871,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 59, 17381.62m, 0.7077m, 0.9791m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 872,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 59, 18702.26m, 0.7234m, 0.9791m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 873,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 59, 20552.57m, 0.7222m, 0.9791m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 874,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 59, 22014.5m, 0.7175m, 0.9791m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 875,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 59, 19249.15m, 0.7132m, 0.9796m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 876,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 59, 20969.71m, 0.7131m, 0.9796m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 877,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 59, 23655.88m, 0.7191m, 0.9791m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 878,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 59, 25356.87m, 0.7308m, 0.9791m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 879,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 59, 25687.24m, 0.7208m, 0.9791m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 880,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 59, 26882.31m, 0.74m, 0.979m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 881,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 59, 27150.81m, 0.744m, 0.979m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 882,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 59, 28074.87m, 0.742m, 0.98m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 883,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 59, 29820.47m, 0.749m, 0.98m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 884,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 59, 30908.13m, 0.745m, 0.979m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 885,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 59, 32469.47m, 0.804m, 0.98m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 886,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 60, 66063.32m, 0.6671m, 0.973m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 887,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 60, 64758.96m, 0.6786m, 0.973m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 888,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 60, 68234.08m, 0.6802m, 0.973m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 889,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 60, 66317.97m, 0.6889m, 0.973m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 890,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 60, 60554.35m, 0.7231m, 0.9743m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 891,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 60, 67741.7m, 0.7216m, 0.9743m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 892,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 60, 66743.34m, 0.7439m, 0.9719m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 893,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 60, 68701.95m, 0.741m, 0.9719m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 894,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 60, 65784.47m, 0.7333m, 0.9678m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 895,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 60, 76462.92m, 0.738m, 0.974m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 896,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 60, 82331.53m, 0.734m, 0.974m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 897,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 60, 86461.3m, 0.706m, 0.973m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 898,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 60, 90517.73m, 0.712m, 0.972m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 899,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 60, 88488.66m, 0.725m, 0.972m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 900,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 60, 90353.55m, 0.726m, 0.965m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 901,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 61, 16693.08m, 0.7091m, 0.9796m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 902,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 61, 17869.27m, 0.7333m, 0.9796m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 903,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 61, 19646.79m, 0.7397m, 0.9796m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 904,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 61, 21010.34m, 0.7416m, 0.9796m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 905,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 61, 18482.83m, 0.7429m, 0.9796m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 906,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 61, 19318.54m, 0.7399m, 0.9796m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 907,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 61, 21461.62m, 0.7572m, 0.9796m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 908,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 61, 22545.99m, 0.761m, 0.9796m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 909,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 61, 22670.85m, 0.7691m, 0.9796m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 910,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 61, 23602.23m, 0.752m, 0.98m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 911,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 61, 24705.24m, 0.755m, 0.98m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 912,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 61, 25488.56m, 0.756m, 0.98m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 913,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 61, 27148.93m, 0.758m, 0.98m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 914,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 61, 28472.04m, 0.785m, 0.975m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 915,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 61, 29394.01m, 0.778m, 0.976m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 916,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 62, 4879.168m, 0.5827m, 0.9684m, 2 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 917,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 62, 5233.122m, 0.5676m, 0.9716m, 2 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 918,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 62, 5457.995m, 0.5757m, 0.9716m, 2 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 919,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 62, 6070.718m, 0.5926m, 0.9716m, 2 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 920,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 62, 6547.707m, 0.5767m, 0.9712m, 2 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 921,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 62, 6896.723m, 0.5804m, 0.9712m, 2 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 922,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 62, 7622.664m, 0.5833m, 0.9712m, 2 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 923,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 62, 7690.286m, 0.5845m, 0.9712m, 2 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 924,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 62, 7641.111m, 0.5988m, 0.9663m, 2 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 925,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 62, 7203.03m, 0.593m, 0.971m, 2 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 926,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 62, 7602.775m, 0.597m, 0.971m, 2 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 927,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 62, 7518.682m, 0.598m, 0.965m, 2 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 928,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 62, 7589.683m, 0.607m, 0.963m, 2 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 929,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 62, 7751.01m, 0.605m, 0.963m, 2 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 930,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 62, 7921.973m, 0.612m, 0.961m, 2 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 931,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 63, 3972.147m, 0.7128m, 0.9796m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 932,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 63, 4251.57m, 0.7172m, 0.9791m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 933,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 63, 4307.325m, 0.7244m, 0.9791m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 934,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 63, 4553.273m, 0.7104m, 0.9791m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 935,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 63, 4506.469m, 0.716m, 0.9796m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 936,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 63, 5128.414m, 0.7083m, 0.9796m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 937,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 63, 5893.325m, 0.7101m, 0.9791m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 938,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 63, 6563.183m, 0.7037m, 0.9791m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 939,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 63, 6744.583m, 0.7405m, 0.9791m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 940,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 63, 7268.1m, 0.742m, 0.979m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 941,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 63, 7466.803m, 0.741m, 0.979m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 942,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 63, 8003.229m, 0.74m, 0.98m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 943,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 63, 9091.659m, 0.733m, 0.98m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 944,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 63, 9248.355m, 0.757m, 0.98m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 945,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 63, 9434.983m, 0.768m, 0.98m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 946,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 64, 1391.291m, 0.6385m, 0.9785m, 6 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 947,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 64, 1429.01m, 0.6461m, 0.9796m, 6 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 948,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 64, 1445.643m, 0.6736m, 0.9796m, 6 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 949,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 64, 1583.915m, 0.6732m, 0.9796m, 6 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 950,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 64, 1535.457m, 0.6713m, 0.9732m, 6 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 951,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 64, 1652.296m, 0.6797m, 0.9732m, 6 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 952,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 64, 1758.553m, 0.6982m, 0.9732m, 6 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 953,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 64, 1759.951m, 0.7016m, 0.9732m, 6 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 954,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 64, 1707.955m, 0.7214m, 0.9725m, 6 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 955,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 64, 1648.247m, 0.698m, 0.973m, 6 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 956,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 64, 1643.455m, 0.704m, 0.973m, 6 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 957,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 64, 1676.594m, 0.692m, 0.974m, 6 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 958,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 64, 1631.949m, 0.691m, 0.974m, 6 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 959,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 64, 1544.18m, 0.719m, 0.974m, 6 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 960,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 64, 1539.183m, 0.725m, 0.965m, 6 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 961,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 65, 15635.46m, 0.6462m, 0.9796m, 3 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 962,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 65, 15980.99m, 0.6441m, 0.9796m, 3 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 963,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 65, 16247.15m, 0.6441m, 0.9796m, 3 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 964,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 65, 16458.88m, 0.6503m, 0.9796m, 3 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 965,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 65, 15707.77m, 0.6577m, 0.9796m, 3 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 966,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 65, 16870.5m, 0.6604m, 0.9796m, 3 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 967,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 65, 18197.15m, 0.6712m, 0.9796m, 3 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 968,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 65, 18859.46m, 0.6917m, 0.9796m, 3 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 969,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 65, 18707.51m, 0.69m, 0.9796m, 3 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 970,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 65, 18634.05m, 0.699m, 0.98m, 3 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 971,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 65, 18515.05m, 0.7m, 0.98m, 3 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 972,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 65, 18910.55m, 0.692m, 0.977m, 3 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 973,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 65, 18937.05m, 0.721m, 0.979m, 3 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 974,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 65, 19197.11m, 0.754m, 0.979m, 3 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 975,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 65, 18733.48m, 0.757m, 0.975m, 3 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 976,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 66, 9489.242m, 0.6983m, 0.964m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 977,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 66, 10071m, 0.6967m, 0.9635m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 978,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 66, 10569.15m, 0.6914m, 0.9635m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 979,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 66, 11793.73m, 0.695m, 0.9635m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 980,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 66, 12259.58m, 0.6996m, 0.9551m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 981,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 66, 12664.09m, 0.6966m, 0.9551m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 982,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 66, 12737.08m, 0.6968m, 0.9533m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 983,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 66, 13220.74m, 0.7013m, 0.9533m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 984,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 66, 13207.48m, 0.6943m, 0.9628m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 985,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 66, 13860.25m, 0.701m, 0.967m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 986,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 66, 14443.56m, 0.696m, 0.967m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 987,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 66, 15146.46m, 0.702m, 0.976m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 988,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 66, 15229.51m, 0.707m, 0.976m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 989,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 66, 15235.26m, 0.711m, 0.973m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 990,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 66, 15772.17m, 0.715m, 0.97m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 991,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 67, 1467.41m, 0.5996m, 0.9679m, 6 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 992,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 67, 1612.91m, 0.6019m, 0.9695m, 6 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 993,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 67, 1591.734m, 0.6117m, 0.9695m, 6 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 994,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 67, 1693.268m, 0.586m, 0.9695m, 6 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 995,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 67, 1974.486m, 0.568m, 0.9761m, 6 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 996,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 67, 2017.682m, 0.5752m, 0.9761m, 6 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 997,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 67, 1988.005m, 0.5842m, 0.9761m, 6 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 998,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 67, 1909.706m, 0.5872m, 0.9761m, 6 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 999,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 67, 1942.878m, 0.5779m, 0.9549m, 6 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1000,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 67, 2041.325m, 0.599m, 0.949m, 6 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1001,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 67, 1986.983m, 0.591m, 0.949m, 6 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1002,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 67, 2165.784m, 0.583m, 0.956m, 6 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1003,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 67, 2240.255m, 0.582m, 0.965m, 6 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1004,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 67, 2373.915m, 0.621m, 0.965m, 6 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1005,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 67, 2445.915m, 0.591m, 0.959m, 6 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1006,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 68, 25535.46m, 0.6518m, 0.974m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1007,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 68, 25034.06m, 0.6615m, 0.9739m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1008,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 68, 26243.54m, 0.6634m, 0.9739m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1009,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 68, 26106.98m, 0.6635m, 0.9739m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1010,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 68, 25880.15m, 0.6695m, 0.9741m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1011,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 68, 26925.75m, 0.6658m, 0.9741m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1012,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 68, 28322.52m, 0.6666m, 0.9737m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1013,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 68, 28823.79m, 0.6761m, 0.9737m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1014,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 68, 27854.63m, 0.6707m, 0.9695m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1015,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 68, 28700.57m, 0.668m, 0.97m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1016,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 68, 33764.88m, 0.664m, 0.97m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1017,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 68, 34172.3m, 0.682m, 0.971m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1018,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 68, 35098.14m, 0.686m, 0.969m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1019,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 68, 38628.23m, 0.693m, 0.969m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1020,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 68, 38816.67m, 0.703m, 0.965m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1021,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 69, 5645.035m, 0.6821m, 0.9796m, 4 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1022,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 69, 6548.591m, 0.6731m, 0.9796m, 4 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1023,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 69, 7457.853m, 0.7049m, 0.9796m, 4 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1024,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 69, 7978.933m, 0.7221m, 0.9796m, 4 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1025,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 69, 7459.681m, 0.7194m, 0.9796m, 4 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1026,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 69, 8754.412m, 0.714m, 0.9796m, 4 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1027,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 69, 10884.06m, 0.7111m, 0.9796m, 4 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1028,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 69, 12382.66m, 0.7204m, 0.9796m, 4 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1029,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 69, 11935.65m, 0.7212m, 0.9796m, 4 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1030,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 69, 11393.22m, 0.709m, 0.98m, 4 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1031,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 69, 10782.83m, 0.705m, 0.98m, 4 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1032,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 69, 10375.22m, 0.713m, 0.98m, 4 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1033,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 69, 10475.92m, 0.714m, 0.98m, 4 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1034,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 69, 10773.36m, 0.706m, 0.98m, 4 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1035,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 69, 11898.03m, 0.716m, 0.98m, 4 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1036,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 70, 3665.964m, 0.5835m, 0.9796m, 2 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1037,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 70, 3858.246m, 0.6022m, 0.9796m, 2 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1038,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 70, 3914.3m, 0.6117m, 0.9796m, 2 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1039,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 70, 3847.522m, 0.6103m, 0.9796m, 2 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1040,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 70, 3794.05m, 0.6152m, 0.9796m, 2 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1041,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 70, 4467.319m, 0.6164m, 0.9796m, 2 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1042,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 70, 4534.852m, 0.6129m, 0.9796m, 2 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1043,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 70, 4402.832m, 0.581m, 0.9796m, 2 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1044,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 70, 4762.775m, 0.6029m, 0.973m, 2 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1045,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 70, 4307.102m, 0.613m, 0.973m, 2 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1046,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 70, 4391.667m, 0.624m, 0.973m, 2 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1047,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 70, 4472.916m, 0.614m, 0.97m, 2 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1048,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 70, 4933.899m, 0.607m, 0.97m, 2 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1049,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 70, 4724.198m, 0.614m, 0.97m, 2 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1050,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 70, 4675.658m, 0.606m, 0.957m, 2 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1051,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 71, 15019.13m, 0.6328m, 0.9796m, 6 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1052,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 71, 15765.84m, 0.6487m, 0.9796m, 6 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1053,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 71, 17292.58m, 0.6466m, 0.9796m, 6 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1054,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 71, 17343.59m, 0.6513m, 0.9796m, 6 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1055,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 71, 16712.84m, 0.652m, 0.9796m, 6 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1056,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 71, 17082.18m, 0.6529m, 0.9796m, 6 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1057,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 71, 18947.18m, 0.6547m, 0.9796m, 6 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1058,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 71, 19535.58m, 0.6599m, 0.9796m, 6 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1059,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 71, 19599.98m, 0.6541m, 0.9796m, 6 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1060,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 71, 20021.21m, 0.646m, 0.98m, 6 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1061,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 71, 20126.7m, 0.652m, 0.98m, 6 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1062,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 71, 21833.26m, 0.664m, 0.98m, 6 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1063,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 71, 22257.83m, 0.663m, 0.98m, 6 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1064,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 71, 22643.15m, 0.665m, 0.98m, 6 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1065,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 71, 23426.36m, 0.679m, 0.98m, 6 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1066,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 72, 1200.2m, 0.6437m, 0.96m, 6 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1067,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 72, 1219.031m, 0.648m, 0.9612m, 6 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1068,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 72, 1432.232m, 0.6664m, 0.9612m, 6 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1069,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 72, 1623.439m, 0.6738m, 0.9612m, 6 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1070,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 72, 1197.073m, 0.6824m, 0.9683m, 6 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1071,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 72, 1159.578m, 0.685m, 0.9683m, 6 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1072,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 72, 1192.305m, 0.7166m, 0.9683m, 6 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1073,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 72, 1082.026m, 0.7139m, 0.9683m, 6 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1074,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 72, 1206.249m, 0.7281m, 0.9673m, 6 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1075,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 72, 1081.745m, 0.701m, 0.973m, 6 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1076,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 72, 1124.133m, 0.7m, 0.973m, 6 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1077,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 72, 1084.738m, 0.672m, 0.974m, 6 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1078,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 72, 1147.588m, 0.662m, 0.98m, 6 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1079,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 72, 1135.337m, 0.664m, 0.98m, 6 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1080,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 72, 1161.404m, 0.671m, 0.98m, 6 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1081,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 73, 16881.59m, 0.6509m, 0.9703m, 4 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1082,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 73, 16885.85m, 0.6444m, 0.9695m, 4 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1083,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 73, 18297.71m, 0.6442m, 0.9695m, 4 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1084,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 73, 20173.74m, 0.6467m, 0.9695m, 4 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1085,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 73, 18630.14m, 0.6479m, 0.9736m, 4 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1086,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 73, 19922.18m, 0.6525m, 0.9736m, 4 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1087,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 73, 22257.26m, 0.6539m, 0.973m, 4 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1088,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 73, 23678.43m, 0.6518m, 0.973m, 4 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1089,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 73, 24147.44m, 0.652m, 0.9692m, 4 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1090,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 73, 23985.71m, 0.655m, 0.969m, 4 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1091,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 73, 23253.41m, 0.666m, 0.969m, 4 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1092,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 73, 23423.79m, 0.67m, 0.977m, 4 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1093,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 73, 24156.92m, 0.676m, 0.974m, 4 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1094,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 73, 24922.79m, 0.677m, 0.974m, 4 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1095,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 73, 25733.89m, 0.676m, 0.972m, 4 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1096,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 74, 7328.235m, 0.6864m, 0.9675m, 6 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1097,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 74, 7912.738m, 0.7012m, 0.9683m, 6 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1098,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 74, 8087.252m, 0.7141m, 0.9683m, 6 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1099,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 74, 8806.466m, 0.7167m, 0.9683m, 6 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1100,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 74, 8453.117m, 0.7238m, 0.9671m, 6 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1101,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 74, 8967.695m, 0.7177m, 0.9671m, 6 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1102,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 74, 9604.271m, 0.7121m, 0.9671m, 6 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1103,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 74, 10296.98m, 0.7094m, 0.9671m, 6 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1104,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 74, 9972.656m, 0.7219m, 0.9796m, 6 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1105,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 74, 11196.3m, 0.76m, 0.98m, 6 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1106,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 74, 11037.91m, 0.765m, 0.98m, 6 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1107,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 74, 10504.64m, 0.777m, 0.98m, 6 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1108,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 74, 9918.979m, 0.789m, 0.98m, 6 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1109,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 74, 9470.634m, 0.784m, 0.98m, 6 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1110,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 74, 9349.051m, 0.809m, 0.98m, 6 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1111,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 75, 3456.931m, 0.6104m, 0.9656m, 6 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1112,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 75, 3955.813m, 0.6122m, 0.9686m, 6 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1113,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 75, 4277.035m, 0.6339m, 0.9686m, 6 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1114,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 75, 4315.452m, 0.628m, 0.9682m, 6 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1115,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 75, 4472.347m, 0.6055m, 0.9607m, 6 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1116,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 75, 5036.576m, 0.6011m, 0.9607m, 6 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1117,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 75, 5235.203m, 0.6315m, 0.9607m, 6 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1118,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 75, 5305.041m, 0.6469m, 0.9607m, 6 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1119,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 75, 5543.208m, 0.6391m, 0.9674m, 6 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1120,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 75, 5731.255m, 0.638m, 0.961m, 6 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1121,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 75, 5577.239m, 0.643m, 0.961m, 6 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1122,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 75, 5328.855m, 0.641m, 0.972m, 6 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1123,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 75, 5061.949m, 0.621m, 0.964m, 6 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1124,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 75, 5178.34m, 0.635m, 0.964m, 6 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1125,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 75, 4984.244m, 0.627m, 0.967m, 6 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1126,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 76, 4306.21m, 0.6566m, 0.9785m, 3 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1127,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 76, 4301.042m, 0.6458m, 0.9765m, 3 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1128,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 76, 4450.21m, 0.6747m, 0.9765m, 3 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1129,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 76, 4566.982m, 0.7002m, 0.9765m, 3 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1130,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 76, 4366.499m, 0.7176m, 0.9758m, 3 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1131,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 76, 4465.861m, 0.7245m, 0.9758m, 3 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1132,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 76, 4675.477m, 0.7697m, 0.9758m, 3 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1133,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 76, 4793.441m, 0.7715m, 0.9758m, 3 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1134,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 76, 4839.163m, 0.7894m, 0.9796m, 3 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1135,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 76, 5078.658m, 0.776m, 0.98m, 3 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1136,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 76, 5299.772m, 0.78m, 0.98m, 3 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1137,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 76, 5535.553m, 0.814m, 0.98m, 3 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1138,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 76, 5653.873m, 0.809m, 0.98m, 3 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1139,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 76, 5231.705m, 0.804m, 0.98m, 3 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1140,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 76, 5023.496m, 0.796m, 0.978m, 3 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1141,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 77, 48927.25m, 0.725m, 0.9737m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1142,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 77, 49987.09m, 0.7383m, 0.9743m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1143,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 77, 53241.43m, 0.7399m, 0.9743m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1144,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 77, 55229.3m, 0.749m, 0.9743m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1145,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 77, 50422.8m, 0.7444m, 0.9697m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1146,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 77, 50537.11m, 0.747m, 0.9697m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1147,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 77, 51570.82m, 0.7659m, 0.9697m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1148,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 77, 52639.27m, 0.7608m, 0.9697m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1149,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 77, 54937.63m, 0.773m, 0.9699m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1150,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 77, 52211.96m, 0.776m, 0.97m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1151,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 77, 51646.98m, 0.756m, 0.97m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1152,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 77, 51416.3m, 0.737m, 0.97m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1153,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 77, 54214.22m, 0.747m, 0.968m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1154,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 77, 54900.73m, 0.736m, 0.968m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1155,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 77, 55546.73m, 0.762m, 0.962m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1156,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 78, 76284.13m, 0.7994m, 0.9749m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1157,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 78, 82404.41m, 0.8059m, 0.9787m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1158,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 78, 82927.94m, 0.8239m, 0.9787m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1159,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 78, 93276.15m, 0.8227m, 0.9787m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1160,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 78, 77868.12m, 0.8404m, 0.9697m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1161,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 78, 83526.4m, 0.8404m, 0.9697m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1162,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 78, 90692.06m, 0.8403m, 0.9697m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1163,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 78, 94657.13m, 0.8417m, 0.9697m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1164,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 78, 91538.94m, 0.8374m, 0.9695m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1165,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 78, 84912.77m, 0.85m, 0.974m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1166,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 78, 70774.21m, 0.842m, 0.974m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1167,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 78, 67258.34m, 0.83m, 0.973m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1168,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 78, 69599.84m, 0.835m, 0.972m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1169,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 78, 75246.49m, 0.842m, 0.972m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1170,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 78, 73665.37m, 0.849m, 0.964m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1171,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 79, 1422.84m, 0.5478m, 0.9531m, 7 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1172,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 79, 1481.511m, 0.5575m, 0.9553m, 7 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1173,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 79, 1560.515m, 0.5942m, 0.9553m, 7 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1174,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 79, 1702.96m, 0.6213m, 0.9553m, 7 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1175,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 79, 1915.6m, 0.6084m, 0.9612m, 7 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1176,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 79, 2118.287m, 0.5888m, 0.9612m, 7 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1177,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 79, 2321.936m, 0.6026m, 0.9612m, 7 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1178,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 79, 2554.777m, 0.6053m, 0.9612m, 7 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1179,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 79, 2674.586m, 0.6458m, 0.9717m, 7 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1180,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 79, 2849.182m, 0.658m, 0.972m, 7 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1181,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 79, 2829.879m, 0.661m, 0.972m, 7 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1182,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 79, 2930.818m, 0.664m, 0.969m, 7 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1183,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 79, 3278.167m, 0.671m, 0.966m, 7 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1184,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 79, 3467.023m, 0.68m, 0.966m, 7 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1185,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 79, 3631.058m, 0.683m, 0.965m, 7 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1186,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 80, 31824.05m, 0.7509m, 0.9731m, 4 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1187,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 80, 31891.88m, 0.7649m, 0.9745m, 4 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1188,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 80, 33771.13m, 0.7859m, 0.9745m, 4 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1189,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 80, 33758.56m, 0.788m, 0.9745m, 4 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1190,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 80, 33797.24m, 0.7808m, 0.9697m, 4 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1191,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 80, 34903.34m, 0.781m, 0.9697m, 4 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1192,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 80, 36292.58m, 0.7805m, 0.9697m, 4 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1193,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 80, 36036.32m, 0.7799m, 0.9697m, 4 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1194,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 80, 36690.31m, 0.7772m, 0.9698m, 4 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1195,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 80, 37205.4m, 0.782m, 0.97m, 4 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1196,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 80, 37060.37m, 0.781m, 0.97m, 4 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1197,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 80, 38738.15m, 0.791m, 0.969m, 4 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1198,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 80, 39728.56m, 0.801m, 0.97m, 4 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1199,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 80, 40127.68m, 0.799m, 0.97m, 4 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1200,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 80, 41523.29m, 0.84m, 0.966m, 4 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1201,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 81, 3334.385m, 0.5434m, 0.9506m, 7 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1202,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 81, 3592.01m, 0.5509m, 0.9498m, 7 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1203,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 81, 3776.601m, 0.5549m, 0.9498m, 7 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1204,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 81, 3912.264m, 0.5458m, 0.9498m, 7 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1205,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 81, 4040.903m, 0.5465m, 0.9557m, 7 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1206,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 81, 4204.751m, 0.5583m, 0.9557m, 7 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1207,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 81, 4465.747m, 0.5478m, 0.9557m, 7 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1208,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 81, 4509.281m, 0.5459m, 0.9557m, 7 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1209,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 81, 4434.57m, 0.5522m, 0.9666m, 7 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1210,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 81, 4487.553m, 0.559m, 0.967m, 7 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1211,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 81, 4649.95m, 0.556m, 0.967m, 7 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1212,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 81, 4587.607m, 0.546m, 0.948m, 7 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1213,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 81, 4744.19m, 0.55m, 0.946m, 7 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1214,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 81, 4957.905m, 0.564m, 0.946m, 7 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1215,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 81, 5026.728m, 0.556m, 0.944m, 7 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1216,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 82, 13822.88m, 0.6935m, 0.9791m, 3 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1217,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 82, 14849.12m, 0.6954m, 0.9796m, 3 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1218,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 82, 13687.79m, 0.7095m, 0.9796m, 3 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1219,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 82, 14885.49m, 0.7024m, 0.9796m, 3 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1220,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 82, 15170.79m, 0.7072m, 0.9753m, 3 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1221,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 82, 16331.62m, 0.7042m, 0.9753m, 3 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1222,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 82, 18368.08m, 0.7122m, 0.9753m, 3 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1223,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 82, 20500.15m, 0.7164m, 0.9753m, 3 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1224,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 82, 21934.73m, 0.7195m, 0.9796m, 3 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1225,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 82, 23682.28m, 0.722m, 0.98m, 3 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1226,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 82, 24784.46m, 0.721m, 0.98m, 3 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1227,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 82, 26691.2m, 0.722m, 0.98m, 3 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1228,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 82, 29453.37m, 0.722m, 0.98m, 3 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1229,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 82, 29914.99m, 0.73m, 0.98m, 3 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1230,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 82, 29874.28m, 0.737m, 0.973m, 3 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1231,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 83, 6728.177m, 0.6619m, 0.9761m, 3 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1232,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 83, 7547.554m, 0.6624m, 0.9714m, 3 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1233,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 83, 8302.938m, 0.6959m, 0.9714m, 3 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1234,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 83, 9018.26m, 0.7024m, 0.9714m, 3 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1235,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 83, 8963.415m, 0.6895m, 0.9658m, 3 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1236,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 83, 10113.72m, 0.6796m, 0.9658m, 3 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1237,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 83, 11022.92m, 0.6742m, 0.9658m, 3 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1238,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 83, 11567.56m, 0.6787m, 0.9658m, 3 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1239,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 83, 11750.37m, 0.7198m, 0.9705m, 3 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1240,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 83, 11764.56m, 0.683m, 0.97m, 3 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1241,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 83, 11662.63m, 0.687m, 0.97m, 3 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1242,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 83, 11748.04m, 0.719m, 0.978m, 3 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1243,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 83, 11957.1m, 0.72m, 0.977m, 3 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1244,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 83, 12158.82m, 0.714m, 0.977m, 3 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1245,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 83, 12237.19m, 0.721m, 0.964m, 3 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1246,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 84, 4605.357m, 0.7516m, 0.9796m, 4 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1247,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 84, 4742.436m, 0.7629m, 0.9796m, 4 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1248,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 84, 5020.133m, 0.7568m, 0.9796m, 4 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1249,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 84, 5260.993m, 0.7579m, 0.9796m, 4 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1250,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 84, 5374.736m, 0.7654m, 0.9796m, 4 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1251,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 84, 5814.225m, 0.7685m, 0.9796m, 4 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1252,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 84, 6238.15m, 0.7757m, 0.9796m, 4 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1253,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 84, 6586.336m, 0.7832m, 0.9796m, 4 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1254,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 84, 6724.717m, 0.7814m, 0.9796m, 4 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1255,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 84, 6885.865m, 0.79m, 0.98m, 4 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1256,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 84, 7088.935m, 0.786m, 0.98m, 4 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1257,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 84, 7557.486m, 0.79m, 0.979m, 4 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1258,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 84, 7858.595m, 0.799m, 0.979m, 4 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1259,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 84, 8229.062m, 0.781m, 0.979m, 4 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1260,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 84, 8448.429m, 0.784m, 0.979m, 4 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1261,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 85, 17147.7m, 0.6802m, 0.9791m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1262,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 85, 17788.23m, 0.6756m, 0.9791m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1263,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 85, 19362.68m, 0.6951m, 0.9791m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1264,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 85, 20610.09m, 0.6998m, 0.9791m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1265,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 85, 21332.55m, 0.7037m, 0.9785m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1266,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 85, 23421.29m, 0.7038m, 0.9785m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1267,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 85, 25100.81m, 0.7015m, 0.9791m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1268,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 85, 25643.78m, 0.7031m, 0.9791m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1269,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 85, 25608.48m, 0.7051m, 0.9791m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1270,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 85, 25937.29m, 0.715m, 0.979m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1271,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 85, 27165.37m, 0.727m, 0.979m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1272,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 85, 27770.16m, 0.728m, 0.98m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1273,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 85, 29039.26m, 0.728m, 0.98m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1274,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 85, 30512.47m, 0.736m, 0.98m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1275,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 85, 31975.83m, 0.713m, 0.98m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1276,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 86, 26611.85m, 0.6922m, 0.973m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1277,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 86, 27792.86m, 0.6959m, 0.973m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1278,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 86, 28345.29m, 0.7051m, 0.973m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1279,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 86, 28224.45m, 0.7013m, 0.973m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1280,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 86, 27650.35m, 0.7171m, 0.9742m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1281,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 86, 28839.2m, 0.7144m, 0.9742m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1282,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 86, 28356.38m, 0.7071m, 0.9724m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1283,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 86, 28398.3m, 0.7056m, 0.9724m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1284,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 86, 27636.18m, 0.7243m, 0.9724m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1285,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 86, 27802.42m, 0.731m, 0.973m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1286,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 86, 28644.56m, 0.737m, 0.973m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1287,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 86, 29441.9m, 0.734m, 0.977m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1288,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 86, 30419.06m, 0.732m, 0.978m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1289,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 86, 30909.93m, 0.744m, 0.978m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1290,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 86, 31783.14m, 0.775m, 0.972m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1291,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 87, 7435.308m, 0.6556m, 0.9796m, 3 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1292,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 87, 7810.976m, 0.6659m, 0.9796m, 3 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1293,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 87, 8204.012m, 0.6379m, 0.9796m, 3 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1294,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 87, 8692.27m, 0.6868m, 0.9796m, 3 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1295,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 87, 9208.381m, 0.6804m, 0.9758m, 3 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1296,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 87, 10500.75m, 0.6818m, 0.9758m, 3 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1297,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 87, 11502.9m, 0.6714m, 0.9758m, 3 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1298,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 87, 11277.12m, 0.6724m, 0.9758m, 3 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1299,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 87, 11699.79m, 0.689m, 0.9796m, 3 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1300,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 87, 11973.91m, 0.666m, 0.98m, 3 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1301,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 87, 11728.33m, 0.676m, 0.98m, 3 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1302,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 87, 12008.76m, 0.678m, 0.971m, 3 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1303,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 87, 12348.75m, 0.672m, 0.972m, 3 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1304,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 87, 12378.27m, 0.683m, 0.972m, 3 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1305,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 87, 12320.46m, 0.702m, 0.974m, 3 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1306,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 88, 11935.28m, 0.6797m, 0.9791m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1307,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 88, 13751.02m, 0.6859m, 0.9791m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1308,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 88, 15587.2m, 0.6763m, 0.9791m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1309,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 88, 18334.49m, 0.6805m, 0.9791m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1310,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 88, 17994.57m, 0.6826m, 0.9773m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1311,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 88, 18461.3m, 0.6812m, 0.9791m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1312,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 88, 18554.74m, 0.6859m, 0.9791m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1313,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 88, 19633.23m, 0.6908m, 0.9791m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1314,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 88, 19734.31m, 0.6936m, 0.9791m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1315,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 88, 20319.18m, 0.693m, 0.979m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1316,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 88, 21567.48m, 0.69m, 0.979m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1317,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 88, 22812.9m, 0.708m, 0.98m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1318,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 88, 25416.85m, 0.711m, 0.98m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1319,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 88, 26486.84m, 0.724m, 0.98m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1320,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 88, 27879.91m, 0.7m, 0.98m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1321,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 89, 15075.77m, 0.677m, 0.9791m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1322,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 89, 17682.25m, 0.6866m, 0.9791m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1323,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 89, 20818.78m, 0.6994m, 0.9791m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1324,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 89, 23910.62m, 0.6987m, 0.9791m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1325,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 89, 21302.23m, 0.7036m, 0.9791m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1326,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 89, 24171.71m, 0.7037m, 0.9791m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1327,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 89, 27624.26m, 0.698m, 0.9791m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1328,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 89, 29743.52m, 0.6983m, 0.9791m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1329,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 89, 29414.32m, 0.6927m, 0.9791m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1330,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 89, 28160.73m, 0.694m, 0.979m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1331,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 89, 25280.77m, 0.691m, 0.979m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1332,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 89, 25154.25m, 0.696m, 0.98m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1333,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 89, 26793.07m, 0.701m, 0.98m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1334,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 89, 28348.65m, 0.706m, 0.98m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1335,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 89, 28521.95m, 0.708m, 0.98m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1336,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 90, 32058.37m, 0.5242m, 0.9771m, 2 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1337,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 90, 36559.21m, 0.5647m, 0.9765m, 2 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1338,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 90, 39467.75m, 0.5537m, 0.9765m, 2 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1339,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 90, 48283.33m, 0.5651m, 0.9765m, 2 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1340,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 90, 42583.37m, 0.5713m, 0.9762m, 2 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1341,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 90, 50691.58m, 0.5753m, 0.9762m, 2 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1342,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 90, 62918.65m, 0.5731m, 0.9762m, 2 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1343,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 90, 64971.34m, 0.5879m, 0.9762m, 2 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1344,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 90, 62608.24m, 0.6059m, 0.9707m, 2 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1345,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 90, 61518.81m, 0.605m, 0.966m, 2 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1346,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 90, 53915.44m, 0.583m, 0.966m, 2 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1347,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 90, 49472.06m, 0.584m, 0.965m, 2 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1348,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 90, 48480.62m, 0.59m, 0.963m, 2 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1349,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 90, 51414.06m, 0.599m, 0.963m, 2 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1350,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 90, 51817.2m, 0.603m, 0.964m, 2 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1351,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 91, 62050.06m, 0.655m, 0.9598m, 4 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1352,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 91, 67342.92m, 0.6609m, 0.9575m, 4 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1353,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 91, 71261.2m, 0.6625m, 0.9575m, 4 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1354,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 91, 62577.99m, 0.6664m, 0.9575m, 4 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1355,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 91, 58688.77m, 0.6914m, 0.9677m, 4 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1356,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 91, 71934.34m, 0.6914m, 0.9677m, 4 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1357,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 91, 75876.34m, 0.6989m, 0.9719m, 4 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1358,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 91, 75023.28m, 0.7m, 0.9719m, 4 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1359,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 91, 71872.17m, 0.7046m, 0.9671m, 4 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1360,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 91, 76900.02m, 0.711m, 0.967m, 4 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1361,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 91, 75314.55m, 0.712m, 0.967m, 4 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1362,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 91, 75501.62m, 0.702m, 0.971m, 4 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1363,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 91, 81409.3m, 0.707m, 0.965m, 4 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1364,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 91, 82712.34m, 0.724m, 0.965m, 4 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1365,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 91, 82284.58m, 0.727m, 0.963m, 4 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1366,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 92, 3657.757m, 0.6837m, 0.9796m, 3 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1367,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 92, 4013.656m, 0.6853m, 0.9796m, 3 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1368,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 92, 4417.017m, 0.6875m, 0.9796m, 3 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1369,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 92, 4902.198m, 0.6939m, 0.9796m, 3 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1370,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 92, 5221.484m, 0.6596m, 0.9796m, 3 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1371,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 92, 6048.231m, 0.6567m, 0.9796m, 3 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1372,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 92, 7213.412m, 0.663m, 0.9796m, 3 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1373,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 92, 7370.394m, 0.6609m, 0.9796m, 3 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1374,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 92, 7368.053m, 0.6863m, 0.9796m, 3 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1375,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 92, 7580.331m, 0.706m, 0.98m, 3 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1376,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 92, 7582.489m, 0.702m, 0.98m, 3 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1377,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 92, 7705.801m, 0.705m, 0.98m, 3 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1378,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 92, 7940.231m, 0.69m, 0.98m, 3 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1379,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 92, 7985.878m, 0.706m, 0.98m, 3 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1380,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 92, 8114.139m, 0.738m, 0.98m, 3 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1381,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 93, 20564.69m, 0.6757m, 0.9796m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1382,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 93, 21862.56m, 0.6797m, 0.9796m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1383,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 93, 23640.85m, 0.6824m, 0.9796m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1384,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 93, 26095.7m, 0.6845m, 0.9796m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1385,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 93, 24672.99m, 0.6778m, 0.9796m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1386,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 93, 27130.84m, 0.6797m, 0.9796m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1387,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 93, 27464.63m, 0.6824m, 0.9796m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1388,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 93, 27607.35m, 0.6857m, 0.9796m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1389,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 93, 26557.38m, 0.6806m, 0.973m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1390,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 93, 27569.46m, 0.675m, 0.973m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1391,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 93, 27602.39m, 0.679m, 0.973m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1392,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 93, 26377.49m, 0.694m, 0.98m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1393,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 93, 26443.43m, 0.693m, 0.98m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1394,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 93, 26771.28m, 0.718m, 0.98m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1395,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 93, 27445.88m, 0.712m, 0.98m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1396,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 94, 28235.1m, 0.6745m, 0.973m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1397,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 94, 28196.52m, 0.6842m, 0.973m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1398,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 94, 29117.67m, 0.6937m, 0.973m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1399,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 94, 32088.71m, 0.6982m, 0.973m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1400,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 94, 29334.04m, 0.7047m, 0.9755m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1401,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 94, 29809.01m, 0.7041m, 0.9755m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1402,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 94, 30914.21m, 0.7132m, 0.973m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1403,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 94, 30495.8m, 0.7155m, 0.973m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1404,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 94, 30037.35m, 0.7443m, 0.973m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1405,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 94, 30368.31m, 0.784m, 0.973m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1406,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 94, 29810.64m, 0.786m, 0.973m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1407,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 94, 30486.09m, 0.805m, 0.98m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1408,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 94, 31570.37m, 0.784m, 0.98m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1409,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 94, 33577.43m, 0.743m, 0.98m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1410,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 94, 34059.39m, 0.741m, 0.977m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1411,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 95, 42798.98m, 0.8133m, 0.9731m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1412,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 95, 44381.45m, 0.8146m, 0.9735m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1413,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 95, 47031.04m, 0.8139m, 0.9735m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1414,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 95, 47834.81m, 0.8139m, 0.9735m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1415,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 95, 44304.74m, 0.8024m, 0.9729m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1416,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 95, 46293.63m, 0.8044m, 0.9729m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1417,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 95, 49345.9m, 0.8159m, 0.9735m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1418,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 95, 49102.19m, 0.8129m, 0.9735m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1419,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 95, 48641.37m, 0.8165m, 0.9694m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1420,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 95, 48668.57m, 0.823m, 0.974m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1421,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 95, 50078.8m, 0.815m, 0.974m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1422,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 95, 50458.45m, 0.816m, 0.969m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1423,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 95, 52005.52m, 0.822m, 0.969m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1424,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 95, 51745.15m, 0.82m, 0.969m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1425,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 95, 52405.54m, 0.823m, 0.962m, 5 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1426,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 96, 1561.409m, 0.5247m, 0.9764m, 6 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1427,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 96, 1638.803m, 0.5381m, 0.9765m, 6 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1428,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 96, 1762.715m, 0.529m, 0.9765m, 6 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1429,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 96, 1830.098m, 0.5417m, 0.9765m, 6 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1430,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 96, 1664.373m, 0.533m, 0.9612m, 6 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1431,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 96, 2136.079m, 0.5334m, 0.9612m, 6 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1432,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 96, 2021.119m, 0.5594m, 0.9612m, 6 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1433,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 96, 2115.053m, 0.5588m, 0.9612m, 6 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1434,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 96, 1804.74m, 0.5764m, 0.9683m, 6 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1435,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 96, 1811.604m, 0.58m, 0.968m, 6 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1436,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 96, 1943.008m, 0.587m, 0.968m, 6 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1437,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 96, 1681.578m, 0.575m, 0.974m, 6 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1438,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 96, 1579.493m, 0.58m, 0.971m, 6 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1439,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 96, 1621.184m, 0.596m, 0.971m, 6 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1440,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 96, 1615.371m, 0.593m, 0.97m, 6 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1441,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 97, 10624.79m, 0.6831m, 0.9796m, 4 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1442,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 97, 11140.67m, 0.6815m, 0.9796m, 4 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1443,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 97, 11840.25m, 0.6917m, 0.9796m, 4 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1444,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 97, 12563.51m, 0.6907m, 0.9796m, 4 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1445,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 97, 12312.13m, 0.691m, 0.9796m, 4 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1446,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 97, 13890.49m, 0.6892m, 0.9796m, 4 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1447,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 97, 14621.32m, 0.6893m, 0.9796m, 4 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1448,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 97, 16119.06m, 0.6928m, 0.9796m, 4 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1449,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 97, 16154.33m, 0.7027m, 0.9796m, 4 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1450,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 97, 15644.08m, 0.706m, 0.98m, 4 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1451,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 97, 15572.38m, 0.699m, 0.98m, 4 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1452,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 97, 15812.35m, 0.694m, 0.978m, 4 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1453,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 97, 16662.71m, 0.702m, 0.978m, 4 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1454,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 97, 16925.73m, 0.708m, 0.978m, 4 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1455,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 97, 17113.92m, 0.71m, 0.978m, 4 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1456,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 98, 14303.18m, 0.585m, 0.9691m, 2 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1457,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 98, 16122.13m, 0.5768m, 0.9712m, 2 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1458,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 98, 17352.11m, 0.5853m, 0.9712m, 2 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1459,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 98, 18268.29m, 0.5828m, 0.9712m, 2 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1460,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 98, 17455.14m, 0.5876m, 0.9755m, 2 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1461,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 98, 19772.18m, 0.5954m, 0.9755m, 2 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1462,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 98, 21787.52m, 0.6015m, 0.9755m, 2 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1463,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 98, 22532.17m, 0.6081m, 0.9755m, 2 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1464,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 98, 23660.32m, 0.6183m, 0.9796m, 2 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1465,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 98, 24474.53m, 0.624m, 0.98m, 2 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1466,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 98, 25755.9m, 0.623m, 0.98m, 2 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1467,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 98, 25305.01m, 0.625m, 0.977m, 2 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1468,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 98, 26607.21m, 0.628m, 0.976m, 2 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1469,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 98, 27496.41m, 0.635m, 0.976m, 2 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1470,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 98, 26942.95m, 0.638m, 0.967m, 2 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1471,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 99, 1595.096m, 0.7038m, 0.9668m, 6 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1472,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 99, 1720.569m, 0.6969m, 0.9688m, 6 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1473,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 99, 1836.45m, 0.7068m, 0.9688m, 6 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1474,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 99, 1962.931m, 0.6797m, 0.9688m, 6 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1475,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 99, 2046.939m, 0.6829m, 0.9612m, 6 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1476,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 99, 2284.766m, 0.6904m, 0.9612m, 6 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1477,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 99, 2613.801m, 0.7091m, 0.9612m, 6 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1478,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 99, 2381.831m, 0.6928m, 0.9612m, 6 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1479,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 99, 2403.748m, 0.7182m, 0.9732m, 6 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1480,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 99, 2353.029m, 0.718m, 0.979m, 6 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1481,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 99, 2468.65m, 0.716m, 0.979m, 6 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1482,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 99, 2404.671m, 0.7m, 0.976m, 6 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1483,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 99, 2300.407m, 0.704m, 0.978m, 6 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1484,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 99, 2318.536m, 0.713m, 0.978m, 6 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1485,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 99, 2359.126m, 0.707m, 0.97m, 6 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1486,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 100, 1522.081m, 0.6797m, 0.9756m, 6 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1487,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 100, 1577.928m, 0.6833m, 0.9758m, 6 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1488,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 100, 1631.98m, 0.6981m, 0.9758m, 6 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1489,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 100, 1708.411m, 0.7067m, 0.9758m, 6 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1490,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 100, 1831.743m, 0.7169m, 0.9796m, 6 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1491,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 100, 1946.66m, 0.722m, 0.9796m, 6 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1492,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 100, 2054.758m, 0.7228m, 0.9796m, 6 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1493,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 100, 1923.391m, 0.7086m, 0.9796m, 6 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1494,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 100, 1896.338m, 0.6821m, 0.9674m, 6 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1495,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 100, 1906.311m, 0.708m, 0.98m, 6 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1496,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 100, 1986.517m, 0.704m, 0.98m, 6 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1497,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 100, 1901.543m, 0.721m, 0.973m, 6 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1498,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 100, 1927.275m, 0.724m, 0.98m, 6 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1499,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 100, 1992.46m, 0.717m, 0.98m, 6 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1500,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 100, 2092.148m, 0.717m, 0.98m, 6 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1501,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 101, 7996.326m, 0.6797m, 0.9796m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1502,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 101, 8924.563m, 0.679m, 0.973m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1503,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 101, 10185.05m, 0.6856m, 0.9791m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1504,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 101, 11011.82m, 0.6896m, 0.9791m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1505,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 101, 9262.981m, 0.6869m, 0.9761m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1506,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 101, 9611.318m, 0.6861m, 0.9761m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1507,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 101, 10785.03m, 0.6894m, 0.9791m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1508,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 101, 11529.32m, 0.6935m, 0.973m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1509,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 101, 12003.56m, 0.7056m, 0.973m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1510,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 101, 11589.86m, 0.702m, 0.979m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1511,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 101, 10386.84m, 0.7m, 0.979m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1512,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 101, 10921.27m, 0.705m, 0.978m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1513,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 101, 12087.24m, 0.708m, 0.978m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1514,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 101, 12682.48m, 0.721m, 0.978m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1515,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 101, 13141.3m, 0.714m, 0.978m, 1 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1516,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 102, 11230.33m, 0.6549m, 0.9796m, 3 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1517,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 102, 11861.68m, 0.6608m, 0.9796m, 3 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1518,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 102, 13071.51m, 0.6907m, 0.9796m, 3 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1519,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 102, 14606.57m, 0.6936m, 0.9796m, 3 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1520,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 102, 15476.65m, 0.6897m, 0.9796m, 3 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1521,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 102, 17711.26m, 0.6907m, 0.9796m, 3 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1522,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 102, 19353.12m, 0.6745m, 0.9796m, 3 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1523,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 102, 19713.47m, 0.6803m, 0.9796m, 3 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1524,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 102, 19970.58m, 0.6871m, 0.9796m, 3 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1525,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 102, 20722.07m, 0.679m, 0.98m, 3 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1526,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 102, 20544.32m, 0.681m, 0.98m, 3 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1527,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 102, 20436.45m, 0.71m, 0.98m, 3 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1528,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 102, 20616.57m, 0.715m, 0.98m, 3 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1529,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 102, 20459.23m, 0.737m, 0.98m, 3 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1530,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 102, 20547.13m, 0.702m, 0.98m, 3 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1531,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 103, 53969.44m, 0.7042m, 0.9796m, 8 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1532,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 103, 55033.14m, 0.7002m, 0.9795m, 8 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1533,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 103, 55562.12m, 0.7179m, 0.9795m, 8 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1534,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 103, 54933.81m, 0.7173m, 0.9795m, 8 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1535,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 103, 52871.9m, 0.7411m, 0.9792m, 8 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1536,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 103, 53887.27m, 0.7412m, 0.9792m, 8 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1537,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 103, 54379.98m, 0.7373m, 0.9792m, 8 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1538,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 103, 55352.19m, 0.7392m, 0.9792m, 8 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1539,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 103, 56144.38m, 0.7463m, 0.9747m, 8 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1540,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 103, 57250.78m, 0.74m, 0.975m, 8 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1541,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 103, 58543.48m, 0.722m, 0.975m, 8 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1542,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 103, 59115.25m, 0.718m, 0.973m, 8 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1543,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 103, 60116.57m, 0.72m, 0.976m, 8 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1544,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 103, 61619.13m, 0.724m, 0.976m, 8 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1545,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 103, 62589.78m, 0.763m, 0.97m, 8 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1546,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 104, 3663.243m, 0.4595m, 0.9786m, 2 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1547,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 104, 3750.93m, 0.451m, 0.9796m, 2 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1548,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 104, 3936.798m, 0.4664m, 0.9796m, 2 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1549,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 104, 4218.762m, 0.4609m, 0.9796m, 2 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1550,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 104, 4160.789m, 0.4603m, 0.9727m, 2 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1551,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 104, 4890.136m, 0.4873m, 0.9727m, 2 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1552,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 104, 4237.948m, 0.5054m, 0.9727m, 2 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1553,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 104, 3916.155m, 0.5128m, 0.9727m, 2 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1554,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 104, 3905.088m, 0.5145m, 0.9668m, 2 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1555,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 104, 3737.794m, 0.484m, 0.967m, 2 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1556,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 104, 2532.597m, 0.516m, 0.967m, 2 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1557,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 104, 2022.449m, 0.516m, 0.968m, 2 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1558,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 104, 1428.431m, 0.499m, 0.966m, 2 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1559,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 104, 1755.031m, 0.494m, 0.966m, 2 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1560,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 104, 1776.894m, 0.492m, 0.968m, 2 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1561,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 105, 11680.49m, 0.7125m, 0.9756m, 6 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1562,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 105, 12411.01m, 0.7194m, 0.9754m, 6 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1563,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 105, 12990.01m, 0.7232m, 0.9754m, 6 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1564,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 105, 13101.76m, 0.7709m, 0.9754m, 6 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1565,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 105, 12560.2m, 0.7535m, 0.9677m, 6 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1566,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 105, 12895.28m, 0.7478m, 0.9677m, 6 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1567,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 105, 13399.86m, 0.7496m, 0.9677m, 6 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1568,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 105, 13222.02m, 0.751m, 0.9677m, 6 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1569,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 105, 13104.39m, 0.7527m, 0.9796m, 6 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1570,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 105, 13027.72m, 0.759m, 0.98m, 6 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1571,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 105, 12930.89m, 0.764m, 0.98m, 6 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1572,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 105, 12694.21m, 0.756m, 0.98m, 6 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1573,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 105, 12733.46m, 0.755m, 0.98m, 6 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1574,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 105, 12669.67m, 0.78m, 0.98m, 6 });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1575,
                columns: new[] { "CountryId", "GDPperCapita", "GeneralGap", "HealthGap", "RegionId" },
                values: new object[] { 105, 12534.4m, 0.781m, 0.979m, 6 });

            migrationBuilder.InsertData(
                table: "Regions",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Eastern_Europe_and_Central_Asia" },
                    { 2, "Middle_East_and_North_Africa" },
                    { 3, "Latin_America_and_the_Caribbean" },
                    { 4, "East_Asia_and_the_Pacific" },
                    { 5, "Western_Eurpoe" },
                    { 6, "Sub_Saharan_Africa" },
                    { 7, "South_Asia" },
                    { 8, "North_America" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Countries");

            migrationBuilder.DropTable(
                name: "Regions");

            migrationBuilder.DropColumn(
                name: "CountryId",
                table: "Gaps");

            migrationBuilder.DropColumn(
                name: "RegionId",
                table: "Gaps");

            migrationBuilder.RenameColumn(
                name: "Population",
                table: "Gaps",
                newName: "population");

            migrationBuilder.RenameColumn(
                name: "RegionName",
                table: "Gaps",
                newName: "Region");

            migrationBuilder.RenameColumn(
                name: "PoliticalGap",
                table: "Gaps",
                newName: "political");

            migrationBuilder.RenameColumn(
                name: "HealthGap",
                table: "Gaps",
                newName: "pcgdp");

            migrationBuilder.RenameColumn(
                name: "GeneralGap",
                table: "Gaps",
                newName: "health");

            migrationBuilder.RenameColumn(
                name: "GDPperCapita",
                table: "Gaps",
                newName: "general");

            migrationBuilder.RenameColumn(
                name: "EducationGap",
                table: "Gaps",
                newName: "education");

            migrationBuilder.RenameColumn(
                name: "EconomicalGap",
                table: "Gaps",
                newName: "economical");

            migrationBuilder.RenameColumn(
                name: "CountryName",
                table: "Gaps",
                newName: "Country");

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6607m, 0.9553m, 6529.724m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6685m, 0.9553m, 7106.359m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6591m, 0.9553m, 7664.077m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6601m, 0.9553m, 8612.485m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6726m, 0.937m, 9317.428m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6748m, 0.9268m, 10519.37m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6655m, 0.9313m, 10708.14m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6412m, 0.9313m, 11103.5m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6869m, 0.9409m, 10643.21m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.701m, 0.947m, 11076.2m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.704m, 0.947m, 11641.5m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.728m, 0.968m, 11671.02m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.734m, 0.963m, 12122.8m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.769m, 0.958m, 12262.89m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.77m, 0.956m, 12527.06m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.5919m, 0.9643m, 109420.1m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6184m, 0.9612m, 111553.3m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.622m, 0.9612m, 104784.2m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6198m, 0.9612m, 100533.2m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6397m, 0.9612m, 74974.7m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6454m, 0.9612m, 72371.66m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6392m, 0.9612m, 81184.98m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6372m, 0.9612m, 85019.97m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6436m, 0.9612m, 83811.2m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.646m, 0.961m, 86651.09m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.639m, 0.961m, 74821.87m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.649m, 0.965m, 71650.97m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.642m, 0.972m, 66363.7m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.655m, 0.972m, 65806.55m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.716m, 0.963m, 66086.5m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6829m, 0.9796m, 14111.35m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6982m, 0.9796m, 15256.43m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7209m, 0.9796m, 16766.31m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7211m, 0.9796m, 17917.28m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7187m, 0.9796m, 16900.37m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7236m, 0.9796m, 19187.18m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7212m, 0.9796m, 21356.82m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7195m, 0.9796m, 21607.75m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7317m, 0.9796m, 21425.38m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.734m, 0.98m, 20631.5m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.735m, 0.98m, 21193.72m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.732m, 0.98m, 20883.35m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.733m, 0.98m, 23269.97m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.746m, 0.98m, 23016.22m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.752m, 0.977m, 21825.37m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7163m, 0.9761m, 45487.59m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7204m, 0.9741m, 45678.39m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7241m, 0.9741m, 46090.03m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7282m, 0.9737m, 47621.06m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7271m, 0.9739m, 46605.03m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7291m, 0.9739m, 50222.05m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7294m, 0.9735m, 52135.91m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.739m, 0.9735m, 51097.54m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7409m, 0.9737m, 52768.36m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.733m, 0.974m, 51918.88m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.721m, 0.974m, 48710.41m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.731m, 0.97m, 51495.52m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.73m, 0.971m, 52535.39m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.731m, 0.971m, 54236.22m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.731m, 0.968m, 54147.51m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6986m, 0.9796m, 43283.11m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.706m, 0.9796m, 43964.2m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7153m, 0.9796m, 45311.58m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7031m, 0.9796m, 46801.71m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7091m, 0.9787m, 44548.97m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7165m, 0.9787m, 45789.8m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7391m, 0.9787m, 47575.45m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7437m, 0.9787m, 48164.99m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7266m, 0.9789m, 47244.61m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.733m, 0.98m, 49107.26m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.716m, 0.98m, 49600.8m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.709m, 0.975m, 49846.55m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.718m, 0.974m, 51934.16m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.744m, 0.974m, 52946.7m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.777m, 0.97m, 53322.94m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7078m, 0.9796m, 40677m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7198m, 0.9789m, 39263.36m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7163m, 0.9789m, 40173.17m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7165m, 0.9789m, 43345.12m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7509m, 0.9787m, 41584.36m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7531m, 0.9787m, 44708.35m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7652m, 0.9787m, 44259.91m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7684m, 0.9787m, 44340.92m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7809m, 0.9789m, 43955.65m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.753m, 0.974m, 43934.51m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.745m, 0.974m, 42865.83m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.739m, 0.976m, 43385.71m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.738m, 0.973m, 45121.66m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.75m, 0.973m, 44176.41m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.789m, 0.968m, 44811.18m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.5854m, 0.9733m, 1641.019m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.5912m, 0.9699m, 1654.33m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6029m, 0.9699m, 1603.836m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6081m, 0.9699m, 1590.839m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6162m, 0.9685m, 1540.856m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6153m, 0.9685m, 1634.257m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6455m, 0.9685m, 1657.489m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6513m, 0.9685m, 1750.669m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.65m, 0.9673m, 1779.309m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.651m, 0.967m, 1712.542m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.64m, 0.967m, 1716.516m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.646m, 0.963m, 1844.547m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.629m, 0.963m, 1919.395m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.635m, 0.963m, 2054.492m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.651m, 0.978m, 2119.967m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.627m, 0.9495m, 1666.571m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6314m, 0.9496m, 1794.082m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6531m, 0.9496m, 1978.491m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6526m, 0.95m, 2193.464m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6702m, 0.9557m, 2353.854m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6812m, 0.9557m, 2650.906m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6684m, 0.9557m, 3030.277m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6848m, 0.9557m, 3114.221m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6973m, 0.9663m, 3261.228m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.704m, 0.971m, 3453.656m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.698m, 0.971m, 3715.143m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.719m, 0.966m, 3834.118m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.721m, 0.969m, 4113.133m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.726m, 0.969m, 4428.572m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.719m, 0.962m, 4658.509m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.687m, 0.9791m, 13116.05m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7085m, 0.9791m, 13988.7m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7077m, 0.9791m, 15208.19m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7072m, 0.9791m, 16401.84m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6983m, 0.9791m, 15930.91m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6987m, 0.9791m, 16644.15m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7021m, 0.9791m, 16564.12m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7097m, 0.9791m, 17075.21m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7444m, 0.9791m, 16338.44m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.722m, 0.979m, 16962.13m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.726m, 0.979m, 17688.07m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.756m, 0.979m, 18658.98m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.756m, 0.979m, 19573.59m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.727m, 0.979m, 20382.54m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.746m, 0.979m, 21338.66m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.5894m, 0.9617m, 38426.36m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.5931m, 0.9612m, 41107.17m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.5927m, 0.9612m, 43333.83m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6136m, 0.9612m, 55363.66m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6217m, 0.9612m, 44183.83m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6232m, 0.9612m, 46539.98m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6298m, 0.9612m, 47940.3m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6334m, 0.9612m, 56253.3m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6261m, 0.9612m, 55299.59m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.644m, 0.961m, 53093.76m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.615m, 0.961m, 48496.48m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.632m, 0.961m, 46722.72m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.627m, 0.958m, 49226.92m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.629m, 0.958m, 49265.54m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.632m, 0.959m, 46955.53m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6335m, 0.9703m, 3896.771m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6574m, 0.9668m, 4040.87m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6667m, 0.9668m, 4219.436m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6693m, 0.9668m, 4686.541m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6751m, 0.9719m, 4799.367m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6862m, 0.9719m, 5248.85m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7222m, 0.9719m, 5820.064m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.734m, 0.9719m, 6424.803m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7049m, 0.977m, 7040.621m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.749m, 0.98m, 7258.259m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.746m, 0.98m, 7336.596m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.758m, 0.976m, 7606.357m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.748m, 0.979m, 8177.2m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.734m, 0.979m, 8490.053m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.722m, 0.962m, 8584.892m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6543m, 0.9796m, 9686.312m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6637m, 0.9796m, 10455.59m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6737m, 0.9796m, 11526.62m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6695m, 0.9796m, 12705.26m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6655m, 0.9796m, 13056.63m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6679m, 0.9796m, 15012.04m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6909m, 0.9796m, 16610.91m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6949m, 0.9796m, 16416.22m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6941m, 0.9796m, 16444.7m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.686m, 0.98m, 16262.6m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.687m, 0.98m, 15077.21m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.684m, 0.98m, 14218.98m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.681m, 0.98m, 14284.35m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.691m, 0.98m, 14522.78m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.695m, 0.98m, 14593.76m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6897m, 0.9561m, 14000.81m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6797m, 0.9527m, 14299.84m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6839m, 0.9527m, 14589.17m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7071m, 0.9527m, 14478.15m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6876m, 0.9549m, 13194.1m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6832m, 0.9549m, 14523.96m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6744m, 0.9549m, 15919.12m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6752m, 0.9549m, 14731.07m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7129m, 0.9671m, 14865.09m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.71m, 0.973m, 16187.67m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.715m, 0.973m, 15191.3m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.72m, 0.978m, 15639.6m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.715m, 0.98m, 16205.63m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.709m, 0.98m, 16121m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.716m, 0.98m, 16480.37m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7165m, 0.9784m, 47065.29m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7198m, 0.9787m, 46791.16m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7136m, 0.9783m, 47222.91m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7196m, 0.9783m, 48602.44m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7372m, 0.9784m, 43175m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7407m, 0.9784m, 45639.03m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7381m, 0.978m, 47749.69m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 203,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7425m, 0.978m, 47557.25m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 204,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7464m, 0.9694m, 48808.07m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 205,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.74m, 0.969m, 49918.59m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 206,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.731m, 0.969m, 46935.89m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 207,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.769m, 0.97m, 47022.87m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 208,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.771m, 0.971m, 48891.98m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 209,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.772m, 0.971m, 49447.74m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 210,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.772m, 0.968m, 49873.86m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 211,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6997m, 0.9792m, 52747.88m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 212,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6924m, 0.9784m, 55947.64m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 213,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.736m, 0.9784m, 61156.29m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 214,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7426m, 0.9784m, 64995.76m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 215,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7562m, 0.9738m, 63224.91m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 216,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7627m, 0.9738m, 64719.05m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 217,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7672m, 0.9738m, 70460.73m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 218,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7736m, 0.9733m, 71802.19m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 219,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7798m, 0.9737m, 70773.73m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 220,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.785m, 0.974m, 71754.95m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 221,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.776m, 0.974m, 71446.98m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 222,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.755m, 0.972m, 72044.11m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 223,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.755m, 0.97m, 73616.46m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 224,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.779m, 0.97m, 74605.96m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 225,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.798m, 0.964m, 75285.05m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 226,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6455m, 0.9796m, 14570.69m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 227,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6482m, 0.9796m, 16854.34m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 228,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6818m, 0.9796m, 18105.4m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 229,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6884m, 0.9796m, 17407.37m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 230,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7013m, 0.9796m, 17554.27m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 231,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.703m, 0.9796m, 20055.1m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 232,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6676m, 0.9796m, 22020.52m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 233,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.667m, 0.9796m, 23061.76m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 234,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6975m, 0.9792m, 23621.68m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 235,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.698m, 0.979m, 23741.67m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 236,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.699m, 0.979m, 23214.26m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 237,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.704m, 0.978m, 22605.6m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 238,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.717m, 0.977m, 22863.97m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 239,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.723m, 0.977m, 23286.55m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 240,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.716m, 0.97m, 23252.66m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 241,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6561m, 0.9355m, 6587.992m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 242,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6643m, 0.941m, 7144.18m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 243,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6878m, 0.941m, 7816.783m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 244,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6907m, 0.9467m, 8281.175m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 245,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6881m, 0.929m, 8937.366m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 246,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6866m, 0.9327m, 10115.71m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 247,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6853m, 0.9344m, 10873.81m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 248,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6908m, 0.9398m, 11500.83m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 249,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.683m, 0.9404m, 11898.71m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 250,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.682m, 0.919m, 12410.41m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 251,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.676m, 0.919m, 12783.38m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 252,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.674m, 0.918m, 13146.85m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 253,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.673m, 0.915m, 13853.31m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 254,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.676m, 0.926m, 13818.54m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 255,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.682m, 0.935m, 14128.21m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 256,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7049m, 0.9796m, 8528.432m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 257,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.709m, 0.9796m, 9215.681m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 258,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6944m, 0.9796m, 10035.87m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 259,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6939m, 0.9796m, 10896.88m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 260,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6927m, 0.9791m, 10973.63m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 261,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6714m, 0.9791m, 11955.35m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 262,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6901m, 0.9791m, 13225.74m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 263,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7171m, 0.9791m, 13682.88m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 264,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7122m, 0.9791m, 13839.55m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 265,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.725m, 0.979m, 14080.1m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 266,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.727m, 0.979m, 13795.57m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 267,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.731m, 0.98m, 13564.83m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 268,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.729m, 0.98m, 13425.35m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 269,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.758m, 0.98m, 13780.44m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 270,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.725m, 0.975m, 14055.81m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 271,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6936m, 0.9796m, 11869.25m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 272,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7014m, 0.9796m, 11950.02m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 273,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7111m, 0.9796m, 12487.12m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 274,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.718m, 0.9796m, 13050.83m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 275,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7194m, 0.9747m, 13639.48m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 276,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7266m, 0.9747m, 13723.37m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 277,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7225m, 0.9747m, 14407.34m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 278,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7241m, 0.9747m, 15090.66m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 279,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7165m, 0.9747m, 14708.16m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 280,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.732m, 0.975m, 15421.34m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 281,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.736m, 0.975m, 16329.73m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 282,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.727m, 0.974m, 17226.94m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 283,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.749m, 0.977m, 18123.47m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 284,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.782m, 0.977m, 18212.87m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 285,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.786m, 0.973m, 18518.07m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 286,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.643m, 0.9693m, 28913.61m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 287,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6522m, 0.9657m, 29433.94m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 288,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6694m, 0.9657m, 30861.55m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 289,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6706m, 0.9657m, 32390.08m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 290,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6642m, 0.9701m, 31784.46m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 291,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6567m, 0.9701m, 31838.52m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 292,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6732m, 0.9701m, 30943.8m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 293,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6801m, 0.9701m, 31302.44m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 294,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6741m, 0.9738m, 28134.52m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 295,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.671m, 0.974m, 26573.7m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 296,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.684m, 0.974m, 28213.66m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 297,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.684m, 0.966m, 30740.82m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 298,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.684m, 0.967m, 31231.65m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 299,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.692m, 0.967m, 31195.15m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 300,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.707m, 0.96m, 32277.05m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 301,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6712m, 0.9791m, 27196.85m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 302,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6718m, 0.9791m, 27705.34m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 303,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.677m, 0.9791m, 29988.71m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 304,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6789m, 0.9791m, 31357.72m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 305,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.685m, 0.9792m, 29942.91m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 306,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6789m, 0.9792m, 30248.04m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 307,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6767m, 0.9788m, 31103.62m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 308,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.677m, 0.9788m, 30926.77m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 309,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6737m, 0.9791m, 30528.3m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 310,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.687m, 0.979m, 31913.36m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 311,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.69m, 0.979m, 32727.12m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 312,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.688m, 0.98m, 33439.74m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 313,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.693m, 0.98m, 35558.49m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 314,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.706m, 0.98m, 36702.57m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 315,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.711m, 0.978m, 37498.86m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 316,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7524m, 0.9791m, 41550.17m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 317,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7618m, 0.9783m, 42579.18m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 318,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7394m, 0.9783m, 45080.32m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 319,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7449m, 0.9783m, 46249.3m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 320,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.753m, 0.9784m, 43224.02m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 321,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.759m, 0.9784m, 45418.51m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 322,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7629m, 0.978m, 47736.39m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 323,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7583m, 0.978m, 47295.05m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 324,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.778m, 0.9739m, 47284.86m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 325,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.779m, 0.979m, 48772.03m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 326,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.766m, 0.979m, 48046.2m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 327,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.778m, 0.975m, 49236.44m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 328,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.776m, 0.973m, 51232.92m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 329,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.787m, 0.973m, 51263.23m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 330,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.796m, 0.972m, 51167.88m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 331,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7462m, 0.9723m, 43014.77m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 332,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7519m, 0.9696m, 44565.45m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 333,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7538m, 0.9696m, 45669.44m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 334,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7628m, 0.9696m, 48275.52m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 335,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7719m, 0.9743m, 45988.15m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 336,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7778m, 0.9743m, 48841.48m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 337,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7777m, 0.9739m, 49667.98m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 338,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7779m, 0.9739m, 49081.82m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 339,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.8025m, 0.9741m, 47951.3m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 340,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.767m, 0.97m, 47842.09m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 341,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.754m, 0.97m, 47473.49m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 342,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.776m, 0.971m, 48909.96m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 343,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.778m, 0.971m, 51650.79m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 344,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.782m, 0.971m, 51909.02m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 345,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.768m, 0.964m, 54006.6m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 346,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6639m, 0.9796m, 9431.057m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 347,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6705m, 0.9796m, 10493.74m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 348,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6744m, 0.9796m, 11405.81m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 349,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6859m, 0.9796m, 11559.29m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 350,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6774m, 0.9711m, 12148.6m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 351,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6682m, 0.9711m, 13095.83m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 352,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6659m, 0.9711m, 13230.57m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 353,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6867m, 0.9711m, 13327.3m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 354,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6906m, 0.9706m, 13387.43m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 355,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.686m, 0.971m, 13997.12m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 356,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.676m, 0.971m, 15160.28m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 357,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.697m, 0.98m, 16168.53m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 358,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.701m, 0.98m, 16555.26m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 359,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7m, 0.98m, 17153.32m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 360,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.699m, 0.98m, 17924.57m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 361,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6018m, 0.9712m, 12353.09m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 362,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6068m, 0.9714m, 13420.85m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 363,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6111m, 0.9714m, 13688.51m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 364,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6119m, 0.9714m, 14429.68m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 365,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6052m, 0.9661m, 13041.87m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 366,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.5991m, 0.9661m, 14804.46m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 367,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6112m, 0.9661m, 15519.29m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 368,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.5966m, 0.9661m, 14964.62m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 369,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6182m, 0.9661m, 14274.24m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 370,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.632m, 0.966m, 13800.08m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 371,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.642m, 0.966m, 12507.44m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 372,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.629m, 0.97m, 11850.55m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 373,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.629m, 0.962m, 11405.15m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 374,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.634m, 0.962m, 11770.47m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 375,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.633m, 0.958m, 11784.33m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 376,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6433m, 0.9796m, 7964.299m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 377,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6881m, 0.9796m, 8461.051m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 378,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7091m, 0.9796m, 8833.104m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 379,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.722m, 0.9796m, 9665.452m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 380,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7072m, 0.9758m, 9227.033m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 381,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7035m, 0.9758m, 9909.65m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 382,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7206m, 0.9758m, 10798.28m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 383,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7389m, 0.9758m, 11379.41m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 384,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7455m, 0.9796m, 12182.75m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 385,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.738m, 0.98m, 12240.8m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 386,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.726m, 0.98m, 11355.71m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 387,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.724m, 0.977m, 11040.56m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 388,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.729m, 0.978m, 11413.87m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 389,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.729m, 0.978m, 11475.64m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 390,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.739m, 0.968m, 11236.89m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 391,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.5786m, 0.9738m, 6153.4m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 392,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.5809m, 0.9717m, 6531.302m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 393,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.5832m, 0.9717m, 7413.009m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 394,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.5862m, 0.9717m, 8747.321m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 395,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.5899m, 0.9768m, 9276.815m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 396,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.5933m, 0.9768m, 10419.5m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 397,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.5975m, 0.9768m, 11504.5m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 398,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.5935m, 0.9768m, 13117.63m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 399,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6064m, 0.9765m, 12747.41m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 400,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.599m, 0.971m, 12363.98m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 401,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.614m, 0.971m, 12621.44m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 402,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.608m, 0.971m, 12098.34m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 403,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.614m, 0.974m, 12010.29m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 404,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.629m, 0.974m, 12279.16m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 405,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.639m, 0.968m, 12060.78m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 406,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7319m, 0.973m, 32432.04m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 407,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7444m, 0.973m, 34809.9m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 408,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7281m, 0.973m, 36540.93m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 409,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7345m, 0.973m, 36627.07m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 410,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7554m, 0.9755m, 34940.63m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 411,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.758m, 0.9761m, 34560.06m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 412,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7266m, 0.9791m, 34290.02m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 413,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7266m, 0.973m, 34073.22m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 414,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7325m, 0.9719m, 33544.73m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 415,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.742m, 0.972m, 33736.81m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 416,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.738m, 0.972m, 35767.14m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 417,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.746m, 0.973m, 37262.44m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 418,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.746m, 0.972m, 38920.23m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 419,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.795m, 0.972m, 39601.23m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 420,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.788m, 0.965m, 40357.64m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 421,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6944m, 0.9791m, 20280.02m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 422,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7008m, 0.9791m, 22029.73m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 423,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7076m, 0.9791m, 24726.53m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 424,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7094m, 0.9791m, 25213.69m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 425,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7018m, 0.9773m, 22521.9m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 426,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6983m, 0.9773m, 23838.14m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 427,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6977m, 0.9791m, 26688.29m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 428,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6997m, 0.9791m, 28259.26m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 429,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7017m, 0.9791m, 28582.23m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 430,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.749m, 0.98m, 29212.15m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 431,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.747m, 0.98m, 28499.38m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 432,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.731m, 0.979m, 29301.3m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 433,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.734m, 0.979m, 30962.01m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 434,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.751m, 0.974m, 32260.09m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 435,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.733m, 0.975m, 33832.43m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 436,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.5946m, 0.9687m, 806.0986m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 437,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.5991m, 0.9686m, 793.4785m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 438,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.5867m, 0.9686m, 919.3663m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 439,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.5948m, 0.9686m, 978.5058m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 440,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6019m, 0.9737m, 1006.862m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 441,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6136m, 0.9737m, 1155.448m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 442,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.62m, 0.9737m, 1267.238m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 443,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6198m, 0.9737m, 1336.011m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 444,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6144m, 0.9725m, 1400.865m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 445,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.64m, 0.978m, 1666.365m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 446,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.662m, 0.978m, 1758.53m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 447,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.656m, 0.979m, 1970.289m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 448,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.656m, 0.976m, 2025.749m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 449,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.705m, 0.976m, 2266.101m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 450,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.691m, 0.971m, 2720.894m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 451,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7958m, 0.9796m, 40521.86m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 452,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.8044m, 0.9796m, 41227.84m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 453,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.8195m, 0.9796m, 44665.5m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 454,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.8252m, 0.9796m, 46188.7m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 455,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.826m, 0.9796m, 42168.53m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 456,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.8383m, 0.9796m, 43454.75m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 457,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.8451m, 0.9796m, 44063.07m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 458,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.8421m, 0.9796m, 43460.1m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 459,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.8453m, 0.9789m, 41413.79m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 460,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.85m, 0.98m, 41128.09m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 461,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.845m, 0.98m, 41647.56m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 462,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.823m, 0.978m, 42564.32m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 463,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.821m, 0.977m, 43813.53m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 464,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.832m, 0.977m, 44184.53m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 465,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.861m, 0.97m, 44914.22m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 466,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.652m, 0.9796m, 37593.06m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 467,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6824m, 0.9796m, 38295.08m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 468,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7341m, 0.9796m, 39844.93m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 469,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7331m, 0.9796m, 39968.11m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 470,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7025m, 0.9796m, 38495.41m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 471,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7018m, 0.9796m, 39887.65m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 472,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6984m, 0.9796m, 40805.74m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 473,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7089m, 0.9796m, 41121.16m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 474,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7588m, 0.9796m, 40516.89m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 475,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.761m, 0.98m, 40406.05m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 476,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.755m, 0.98m, 40985.87m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 477,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.778m, 0.977m, 41373.23m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 478,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.779m, 0.974m, 42805.2m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 479,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.781m, 0.974m, 43178.74m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 480,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.784m, 0.97m, 43740.94m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 481,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7365m, 0.9742m, 39416.8m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 482,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7441m, 0.9745m, 39707.22m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 483,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7366m, 0.9745m, 39238.41m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 484,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7402m, 0.9745m, 40164.89m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 485,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.746m, 0.9698m, 36943.61m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 486,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7462m, 0.9698m, 39097m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 487,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7433m, 0.9698m, 39305.18m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 488,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.744m, 0.9698m, 40055.49m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 489,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7383m, 0.9699m, 41310.21m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 490,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.758m, 0.974m, 41270.71m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 491,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.752m, 0.974m, 42616.1m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 492,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.77m, 0.971m, 42630.47m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 493,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.774m, 0.97m, 44080.61m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 494,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.767m, 0.97m, 44283.91m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 495,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.775m, 0.966m, 44260.21m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 496,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.67m, 0.9227m, 6091.039m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 497,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6665m, 0.9332m, 7031.313m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 498,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6654m, 0.9386m, 7905.733m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 499,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.668m, 0.9386m, 8302.201m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 500,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6598m, 0.9441m, 8478.726m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 501,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6624m, 0.948m, 8909.877m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 502,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6691m, 0.9497m, 9715.087m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 503,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.675m, 0.9553m, 10507.79m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 504,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6855m, 0.967m, 10950.74m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 505,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.687m, 0.967m, 11738.04m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 506,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.681m, 0.967m, 12690.47m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 507,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.679m, 0.967m, 13282.19m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 508,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.677m, 0.967m, 14365.12m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 509,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.708m, 0.976m, 15134.82m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 510,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.732m, 0.977m, 17047.72m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 511,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6653m, 0.9685m, 3347.134m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 512,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6725m, 0.9674m, 3353.024m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 513,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6679m, 0.9674m, 3924.523m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 514,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6704m, 0.9674m, 4304.252m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 515,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6782m, 0.9674m, 3999.883m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 516,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6811m, 0.9674m, 4364.024m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 517,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6778m, 0.9674m, 4842.414m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 518,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6811m, 0.9674m, 5338.8m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 519,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6661m, 0.9669m, 5636.896m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 520,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.704m, 0.973m, 5832.561m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 521,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.705m, 0.973m, 5355.151m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 522,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.695m, 0.968m, 5023.095m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 523,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.688m, 0.968m, 5081.288m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 524,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.673m, 0.968m, 5112.7m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 525,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.666m, 0.978m, 5364.133m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 526,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.654m, 0.9779m, 29079m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 527,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6648m, 0.9785m, 31461.09m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 528,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6727m, 0.9785m, 31665.09m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 529,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6662m, 0.9785m, 32840.14m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 530,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6908m, 0.9712m, 32009.2m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 531,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6916m, 0.9712m, 29787.98m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 532,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6716m, 0.9737m, 27142.98m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 533,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6782m, 0.9737m, 26106.96m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 534,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6784m, 0.9785m, 26238.17m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 535,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.685m, 0.979m, 26009.54m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 536,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.68m, 0.979m, 26324.04m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 537,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.692m, 0.973m, 25811.51m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 538,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.696m, 0.971m, 26470.04m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 539,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.701m, 0.971m, 26595.88m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 540,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.689m, 0.966m, 27194.74m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 541,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6067m, 0.9796m, 6019.282m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 542,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6144m, 0.9796m, 6234.076m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 543,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6072m, 0.9796m, 6527.144m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 544,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6209m, 0.9796m, 6697.604m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 545,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6238m, 0.9796m, 6729.442m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 546,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6229m, 0.9796m, 6941.17m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 547,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.626m, 0.9796m, 7311.401m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 548,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6304m, 0.9796m, 7688.159m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 549,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6821m, 0.9796m, 7549.211m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 550,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.667m, 0.98m, 7533.717m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 551,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.666m, 0.98m, 7737.782m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 552,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.667m, 0.98m, 7599.767m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 553,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.668m, 0.98m, 7507.844m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 554,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.666m, 0.98m, 7611.654m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 555,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.655m, 0.979m, 7769.625m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 556,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6483m, 0.9796m, 4056.242m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 557,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6661m, 0.9796m, 4097.498m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 558,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.696m, 0.9796m, 4267.151m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 559,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6893m, 0.9796m, 4018.481m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 560,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6927m, 0.9762m, 3957.789m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 561,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6945m, 0.9762m, 4111.676m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 562,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6763m, 0.9762m, 4354.748m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 563,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6773m, 0.9762m, 4573.584m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 564,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6935m, 0.976m, 4343.721m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 565,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.688m, 0.976m, 4568.989m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 566,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.69m, 0.976m, 4976.306m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 567,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.711m, 0.974m, 5222.445m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 568,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.706m, 0.977m, 5347.055m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 569,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.722m, 0.977m, 5359.716m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 570,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.716m, 0.964m, 5427.544m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 571,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7145m, 0.9791m, 18144.97m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 572,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.721m, 0.9791m, 19894.5m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 573,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6967m, 0.9791m, 21539.05m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 574,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6944m, 0.9791m, 22902.83m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 575,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6939m, 0.9796m, 21797.88m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 576,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7006m, 0.9796m, 21630.39m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 577,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7053m, 0.9791m, 22422.15m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 578,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7069m, 0.9791m, 22531.12m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 579,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7075m, 0.9791m, 21526.65m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 580,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.708m, 0.979m, 21467.78m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 581,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7m, 0.979m, 22537.31m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 582,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.711m, 0.98m, 23316.35m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 583,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.712m, 0.98m, 25347.77m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 584,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.72m, 0.979m, 25090.38m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 585,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.733m, 0.978m, 25985.32m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 586,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6698m, 0.9791m, 21178.01m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 587,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6731m, 0.9791m, 21229.65m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 588,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6867m, 0.9791m, 21418.1m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 589,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6879m, 0.9791m, 23243.78m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 590,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.672m, 0.9779m, 22457.1m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 591,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6642m, 0.9796m, 23797.95m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 592,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6718m, 0.9791m, 24398.83m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 593,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6742m, 0.9791m, 24162.6m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 594,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6759m, 0.9791m, 24281.65m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 595,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.672m, 0.979m, 24880.11m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 596,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.669m, 0.979m, 25261.47m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 597,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.67m, 0.979m, 25349.2m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 598,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.674m, 0.979m, 26890.54m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 599,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.677m, 0.98m, 27894.91m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 600,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.688m, 0.98m, 29215.16m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 601,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6541m, 0.9687m, 4453.043m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 602,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.655m, 0.9719m, 4878.546m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 603,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6473m, 0.9719m, 5392.464m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 604,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.658m, 0.9719m, 6382.458m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 605,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6615m, 0.9663m, 6984.45m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 606,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6594m, 0.9663m, 8177.723m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 607,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6591m, 0.9663m, 9776.39m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 608,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6613m, 0.9663m, 10309.85m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 609,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6725m, 0.9762m, 10406.54m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 610,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.681m, 0.976m, 10459.07m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 611,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.682m, 0.976m, 10248.12m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 612,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.691m, 0.976m, 10316.6m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 613,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.691m, 0.974m, 10641.66m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 614,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7m, 0.974m, 11248.79m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 615,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.688m, 0.971m, 11596.19m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 616,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6011m, 0.9624m, 2974.039m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 617,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.5936m, 0.9315m, 3282.039m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 618,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.606m, 0.9315m, 3622.766m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 619,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6151m, 0.9315m, 3785.15m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 620,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6155m, 0.9312m, 3992.099m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 621,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.619m, 0.9312m, 4555.339m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 622,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6442m, 0.9312m, 4894.314m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 623,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6551m, 0.9312m, 5231.032m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 624,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6455m, 0.9366m, 5237.726m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 625,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.664m, 0.942m, 5397.838m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 626,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.683m, 0.942m, 5635.252m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 627,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.669m, 0.942m, 5887.352m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 628,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.665m, 0.94m, 6189.438m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 629,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.668m, 0.944m, 6580.557m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 630,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.625m, 0.937m, 6712.484m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 631,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7335m, 0.9701m, 55869.77m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 632,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7457m, 0.9727m, 56334.3m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 633,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7518m, 0.9727m, 60179.77m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 634,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7597m, 0.9727m, 56248.86m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 635,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7773m, 0.97m, 52873.71m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 636,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.783m, 0.9741m, 52981.9m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 637,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7839m, 0.9737m, 53710.02m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 638,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7823m, 0.9737m, 54409.05m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 639,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.785m, 0.9739m, 54237.27m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 640,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.807m, 0.979m, 58401.34m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 641,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.797m, 0.979m, 75982.69m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 642,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.794m, 0.971m, 81182.03m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 643,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.796m, 0.97m, 86796.97m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 644,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.798m, 0.97m, 91627.61m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 645,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.8m, 0.964m, 102624.6m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 646,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.5803m, 0.978m, 14919.16m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 647,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.5903m, 0.9776m, 15902.45m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 648,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6021m, 0.9776m, 17913.55m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 649,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.5839m, 0.9776m, 17712.07m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 650,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.5933m, 0.9714m, 18042.69m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 651,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.5894m, 0.9714m, 19114.09m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 652,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.5927m, 0.9714m, 19991.1m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 653,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.5842m, 0.9714m, 17010.09m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 654,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.5811m, 0.9709m, 16179.26m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 655,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.58m, 0.971m, 15577.86m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 656,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.587m, 0.971m, 13496.41m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 657,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.583m, 0.963m, 13909.79m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 658,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.589m, 0.966m, 14039.69m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 659,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.584m, 0.966m, 13188.23m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 660,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.582m, 0.963m, 13239.32m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 661,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7813m, 0.9679m, 45600.8m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 662,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7836m, 0.9697m, 43683.77m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 663,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7999m, 0.9697m, 45269.98m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 664,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.8276m, 0.9697m, 56658.66m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 665,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.8496m, 0.9696m, 47760.32m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 666,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.853m, 0.9696m, 43332.33m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 667,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.864m, 0.9696m, 44037.83m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 668,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.8731m, 0.9696m, 45519.32m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 669,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.8594m, 0.9654m, 45032.73m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 670,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.881m, 0.97m, 45555.75m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 671,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.874m, 0.97m, 47402.22m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 672,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.878m, 0.969m, 48587.94m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 673,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.858m, 0.968m, 49827.54m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 674,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.877m, 0.968m, 50327.15m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 675,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.892m, 0.964m, 53000.6m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 676,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6889m, 0.9694m, 31806.46m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 677,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6965m, 0.9699m, 31467.65m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 678,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.69m, 0.9699m, 31270.51m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 679,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7019m, 0.9699m, 30684.67m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 680,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6957m, 0.9697m, 31670.19m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 681,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6926m, 0.9697m, 32671.2m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 682,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6989m, 0.9697m, 33653.17m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 683,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7032m, 0.9697m, 34900.21m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 684,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7005m, 0.9698m, 36067.95m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 685,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.712m, 0.974m, 36219.63m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 686,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.719m, 0.974m, 37270m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 687,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.721m, 0.971m, 39027.33m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 688,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.722m, 0.971m, 38967.32m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 689,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.718m, 0.971m, 38231.65m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 690,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.724m, 0.964m, 38549.37m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 691,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6456m, 0.9717m, 36432.05m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 692,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6498m, 0.9719m, 37623.11m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 693,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6788m, 0.9719m, 39271.13m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 694,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6798m, 0.9719m, 40034.05m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 695,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6765m, 0.9697m, 38331.64m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 696,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6796m, 0.9738m, 38644.79m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 697,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6729m, 0.9733m, 39448.75m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 698,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6885m, 0.9733m, 38429.34m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 699,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6973m, 0.9737m, 37334.64m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 700,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.726m, 0.974m, 36953.3m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 701,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.719m, 0.974m, 36988.99m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 702,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.692m, 0.967m, 38749.23m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 703,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.706m, 0.969m, 40148.95m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 704,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.707m, 0.969m, 40540.19m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 705,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.721m, 0.965m, 40725.62m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 706,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7014m, 0.9696m, 6877.951m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 707,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6925m, 0.9707m, 7090.603m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 708,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.698m, 0.9707m, 7474.993m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 709,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7013m, 0.9707m, 7396.333m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 710,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7037m, 0.9796m, 7389.214m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 711,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7028m, 0.9796m, 7531.876m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 712,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7035m, 0.9796m, 7647.493m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 713,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7085m, 0.9796m, 7935.644m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 714,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7128m, 0.9796m, 8065.223m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 715,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.703m, 0.98m, 8037.566m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 716,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.724m, 0.98m, 8087.246m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 717,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.717m, 0.972m, 8090.927m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 718,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.724m, 0.976m, 8204.784m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 719,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.735m, 0.976m, 8418.144m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 720,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.741m, 0.968m, 8432.85m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 721,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6109m, 0.9746m, 6392.296m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 722,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6203m, 0.971m, 7244.697m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 723,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6275m, 0.971m, 7955.912m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 724,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6182m, 0.971m, 9316.941m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 725,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6048m, 0.9706m, 10550.63m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 726,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6117m, 0.9706m, 10610.39m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 727,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6103m, 0.9706m, 11669.83m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 728,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6093m, 0.9706m, 11802.63m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 729,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.5968m, 0.9655m, 11126.12m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 730,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.593m, 0.966m, 10659.5m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 731,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.603m, 0.966m, 10453.66m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 732,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.604m, 0.969m, 10084.21m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 733,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.605m, 0.971m, 10576.56m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 734,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.623m, 0.971m, 10840.76m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 735,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.638m, 0.957m, 10784.9m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 736,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6447m, 0.9796m, 39816.1m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 737,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6455m, 0.9791m, 40248.34m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 738,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6434m, 0.9791m, 41013.32m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 739,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6445m, 0.9791m, 40295.78m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 740,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6524m, 0.9796m, 38051.13m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 741,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6514m, 0.9796m, 39782.06m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 742,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.653m, 0.9791m, 39154.7m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 743,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6498m, 0.9791m, 39228.25m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 744,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6584m, 0.9791m, 39659.02m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 745,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.67m, 0.979m, 39164.37m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 746,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.66m, 0.979m, 40266.57m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 747,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.657m, 0.98m, 39459.27m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 748,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.662m, 0.979m, 39590.48m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 749,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.652m, 0.979m, 39343.95m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 750,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.656m, 0.973m, 39696.01m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 751,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6928m, 0.9791m, 11327.38m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 752,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6983m, 0.9791m, 13785.67m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 753,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6976m, 0.9791m, 16015.73m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 754,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7013m, 0.9791m, 18475.41m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 755,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7055m, 0.9796m, 17390.52m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 756,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.701m, 0.9796m, 20422.24m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 757,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7213m, 0.9796m, 24606.45m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 758,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7218m, 0.9796m, 25478.92m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 759,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.721m, 0.9796m, 26628.67m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 760,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.719m, 0.98m, 27302.66m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 761,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.718m, 0.98m, 23782.24m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 762,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.713m, 0.979m, 23052.45m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 763,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.712m, 0.979m, 26069.11m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 764,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.71m, 0.975m, 26527.25m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 765,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.71m, 0.975m, 28303.06m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 766,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6486m, 0.9663m, 2093.664m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 767,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6508m, 0.9681m, 2248.688m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 768,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6547m, 0.9681m, 2328.823m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 769,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6512m, 0.9681m, 2348.923m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 770,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6499m, 0.9677m, 2425.467m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 771,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6493m, 0.9677m, 2608.45m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 772,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6768m, 0.9677m, 2757.037m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 773,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6803m, 0.9677m, 2918.937m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 774,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7258m, 0.973m, 3051.254m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 775,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.719m, 0.973m, 3285.207m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 776,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.702m, 0.973m, 3538.143m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 777,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.694m, 0.98m, 3722.632m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 778,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7m, 0.98m, 4044.764m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 779,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.671m, 0.98m, 4127.743m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 780,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.692m, 0.975m, 4236.643m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 781,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6742m, 0.9796m, 2549.65m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 782,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6653m, 0.9796m, 2921.435m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 783,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7045m, 0.9796m, 3263.315m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 784,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7058m, 0.9796m, 3765.768m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 785,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6973m, 0.9796m, 3704.752m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 786,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7036m, 0.9796m, 3656.897m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 787,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7013m, 0.973m, 4442.962m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 788,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6948m, 0.973m, 4856.137m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 789,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6974m, 0.973m, 5034.823m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 790,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.693m, 0.973m, 7215.537m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 791,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.687m, 0.973m, 4851.943m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 792,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.691m, 0.98m, 5239.709m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 793,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.691m, 0.98m, 6033.386m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 794,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.689m, 0.98m, 6303.208m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 795,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.681m, 0.98m, 6133.621m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 796,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6291m, 0.9796m, 1983.916m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 797,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6353m, 0.9796m, 2080.934m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 798,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6469m, 0.9796m, 2307.074m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 799,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.641m, 0.9796m, 2536.14m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 800,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6482m, 0.9796m, 2369.229m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 801,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6464m, 0.9796m, 2470.01m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 802,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6457m, 0.9796m, 2657.025m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 803,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6509m, 0.9796m, 2878.823m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 804,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.652m, 0.9796m, 3101.869m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 805,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.662m, 0.98m, 3171.229m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 806,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.658m, 0.98m, 3480.937m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 807,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.676m, 0.98m, 3681.608m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 808,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.683m, 0.975m, 3950.591m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 809,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.694m, 0.975m, 4266.601m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 810,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.684m, 0.978m, 4498.798m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 811,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6157m, 0.967m, 32082.73m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 812,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6409m, 0.967m, 33103.82m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 813,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6154m, 0.967m, 35001.27m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 814,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6146m, 0.973m, 34991m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 815,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6342m, 0.973m, 33625.8m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 816,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6281m, 0.9736m, 35921.29m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 817,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6356m, 0.973m, 35832.23m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 818,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6351m, 0.973m, 35769.38m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 819,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6403m, 0.973m, 34778.69m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 820,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.651m, 0.973m, 36234.36m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 821,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.649m, 0.973m, 38241.97m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 822,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.65m, 0.973m, 39207.47m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 823,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.657m, 0.973m, 40868.13m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 824,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.672m, 0.98m, 41386.29m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 825,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.687m, 0.976m, 42212.36m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 826,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6341m, 0.9611m, 78004.16m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 827,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6409m, 0.9612m, 91534.94m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 828,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6358m, 0.9612m, 94025.02m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 829,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6356m, 0.9612m, 107651.9m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 830,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6318m, 0.9612m, 73107.03m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 831,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6322m, 0.9612m, 77892.52m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 832,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.632m, 0.9612m, 92064.08m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 833,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6292m, 0.9612m, 99070.26m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 834,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6457m, 0.9567m, 92756.4m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 835,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.646m, 0.957m, 81632.15m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 836,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.624m, 0.957m, 54526.52m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 837,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.628m, 0.969m, 52922.18m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 838,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.63m, 0.961m, 56267.12m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 839,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.65m, 0.961m, 64308.78m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 840,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.621m, 0.968m, 62050.25m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 841,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7199m, 0.9796m, 5822.986m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 842,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.723m, 0.9796m, 6427.457m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 843,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7371m, 0.9796m, 7011.885m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 844,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7402m, 0.9796m, 7533.309m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 845,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7458m, 0.9796m, 8347.969m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 846,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7212m, 0.9796m, 9201.482m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 847,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7122m, 0.9796m, 10293.76m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 848,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7019m, 0.9796m, 11348.6m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 849,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6903m, 0.9796m, 11623.36m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 850,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.686m, 0.98m, 11731.42m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 851,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.673m, 0.98m, 12043.65m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 852,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.669m, 0.98m, 12555.59m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 853,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.676m, 0.98m, 12731.63m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 854,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.68m, 0.98m, 12985.14m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 855,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.67m, 0.98m, 13288.65m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 856,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6807m, 0.9796m, 2769.84m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 857,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7078m, 0.9796m, 2836.272m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 858,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.732m, 0.9796m, 2743.656m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 859,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7495m, 0.9796m, 3060.049m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 860,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7678m, 0.9796m, 2986.464m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 861,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7666m, 0.9796m, 2690.723m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 862,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7608m, 0.9796m, 2724.741m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 863,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.753m, 0.9796m, 2952.813m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 864,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7255m, 0.9758m, 3052.32m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 865,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.706m, 0.98m, 3210.278m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 866,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.706m, 0.98m, 3380.096m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 867,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.695m, 0.979m, 3230.121m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 868,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.693m, 0.98m, 3031.721m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 869,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.695m, 0.98m, 2679.655m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 870,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.698m, 0.98m, 2692.582m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 871,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7077m, 0.9791m, 17381.62m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 872,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7234m, 0.9791m, 18702.26m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 873,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7222m, 0.9791m, 20552.57m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 874,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7175m, 0.9791m, 22014.5m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 875,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7132m, 0.9796m, 19249.15m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 876,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7131m, 0.9796m, 20969.71m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 877,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7191m, 0.9791m, 23655.88m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 878,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7308m, 0.9791m, 25356.87m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 879,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7208m, 0.9791m, 25687.24m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 880,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.74m, 0.979m, 26882.31m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 881,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.744m, 0.979m, 27150.81m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 882,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.742m, 0.98m, 28074.87m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 883,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.749m, 0.98m, 29820.47m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 884,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.745m, 0.979m, 30908.13m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 885,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.804m, 0.98m, 32469.47m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 886,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6671m, 0.973m, 66063.32m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 887,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6786m, 0.973m, 64758.96m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 888,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6802m, 0.973m, 68234.08m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 889,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6889m, 0.973m, 66317.97m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 890,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7231m, 0.9743m, 60554.35m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 891,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7216m, 0.9743m, 67741.7m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 892,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7439m, 0.9719m, 66743.34m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 893,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.741m, 0.9719m, 68701.95m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 894,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7333m, 0.9678m, 65784.47m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 895,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.738m, 0.974m, 76462.92m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 896,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.734m, 0.974m, 82331.53m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 897,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.706m, 0.973m, 86461.3m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 898,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.712m, 0.972m, 90517.73m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 899,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.725m, 0.972m, 88488.66m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 900,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.726m, 0.965m, 90353.55m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 901,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7091m, 0.9796m, 16693.08m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 902,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7333m, 0.9796m, 17869.27m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 903,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7397m, 0.9796m, 19646.79m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 904,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7416m, 0.9796m, 21010.34m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 905,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7429m, 0.9796m, 18482.83m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 906,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7399m, 0.9796m, 19318.54m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 907,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7572m, 0.9796m, 21461.62m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 908,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.761m, 0.9796m, 22545.99m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 909,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7691m, 0.9796m, 22670.85m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 910,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.752m, 0.98m, 23602.23m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 911,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.755m, 0.98m, 24705.24m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 912,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.756m, 0.98m, 25488.56m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 913,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.758m, 0.98m, 27148.93m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 914,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.785m, 0.975m, 28472.04m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 915,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.778m, 0.976m, 29394.01m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 916,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.5827m, 0.9684m, 4879.168m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 917,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.5676m, 0.9716m, 5233.122m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 918,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.5757m, 0.9716m, 5457.995m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 919,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.5926m, 0.9716m, 6070.718m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 920,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.5767m, 0.9712m, 6547.707m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 921,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.5804m, 0.9712m, 6896.723m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 922,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.5833m, 0.9712m, 7622.664m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 923,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.5845m, 0.9712m, 7690.286m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 924,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.5988m, 0.9663m, 7641.111m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 925,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.593m, 0.971m, 7203.03m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 926,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.597m, 0.971m, 7602.775m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 927,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.598m, 0.965m, 7518.682m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 928,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.607m, 0.963m, 7589.683m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 929,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.605m, 0.963m, 7751.01m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 930,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.612m, 0.961m, 7921.973m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 931,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7128m, 0.9796m, 3972.147m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 932,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7172m, 0.9791m, 4251.57m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 933,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7244m, 0.9791m, 4307.325m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 934,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7104m, 0.9791m, 4553.273m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 935,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.716m, 0.9796m, 4506.469m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 936,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7083m, 0.9796m, 5128.414m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 937,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7101m, 0.9791m, 5893.325m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 938,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7037m, 0.9791m, 6563.183m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 939,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7405m, 0.9791m, 6744.583m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 940,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.742m, 0.979m, 7268.1m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 941,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.741m, 0.979m, 7466.803m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 942,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.74m, 0.98m, 8003.229m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 943,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.733m, 0.98m, 9091.659m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 944,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.757m, 0.98m, 9248.355m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 945,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.768m, 0.98m, 9434.983m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 946,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6385m, 0.9785m, 1391.291m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 947,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6461m, 0.9796m, 1429.01m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 948,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6736m, 0.9796m, 1445.643m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 949,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6732m, 0.9796m, 1583.915m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 950,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6713m, 0.9732m, 1535.457m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 951,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6797m, 0.9732m, 1652.296m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 952,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6982m, 0.9732m, 1758.553m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 953,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7016m, 0.9732m, 1759.951m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 954,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7214m, 0.9725m, 1707.955m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 955,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.698m, 0.973m, 1648.247m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 956,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.704m, 0.973m, 1643.455m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 957,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.692m, 0.974m, 1676.594m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 958,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.691m, 0.974m, 1631.949m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 959,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.719m, 0.974m, 1544.18m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 960,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.725m, 0.965m, 1539.183m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 961,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6462m, 0.9796m, 15635.46m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 962,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6441m, 0.9796m, 15980.99m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 963,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6441m, 0.9796m, 16247.15m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 964,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6503m, 0.9796m, 16458.88m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 965,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6577m, 0.9796m, 15707.77m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 966,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6604m, 0.9796m, 16870.5m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 967,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6712m, 0.9796m, 18197.15m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 968,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6917m, 0.9796m, 18859.46m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 969,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.69m, 0.9796m, 18707.51m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 970,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.699m, 0.98m, 18634.05m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 971,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7m, 0.98m, 18515.05m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 972,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.692m, 0.977m, 18910.55m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 973,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.721m, 0.979m, 18937.05m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 974,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.754m, 0.979m, 19197.11m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 975,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.757m, 0.975m, 18733.48m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 976,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6983m, 0.964m, 9489.242m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 977,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6967m, 0.9635m, 10071m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 978,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6914m, 0.9635m, 10569.15m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 979,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.695m, 0.9635m, 11793.73m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 980,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6996m, 0.9551m, 12259.58m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 981,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6966m, 0.9551m, 12664.09m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 982,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6968m, 0.9533m, 12737.08m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 983,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7013m, 0.9533m, 13220.74m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 984,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6943m, 0.9628m, 13207.48m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 985,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.701m, 0.967m, 13860.25m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 986,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.696m, 0.967m, 14443.56m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 987,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.702m, 0.976m, 15146.46m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 988,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.707m, 0.976m, 15229.51m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 989,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.711m, 0.973m, 15235.26m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 990,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.715m, 0.97m, 15772.17m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 991,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.5996m, 0.9679m, 1467.41m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 992,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6019m, 0.9695m, 1612.91m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 993,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6117m, 0.9695m, 1591.734m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 994,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.586m, 0.9695m, 1693.268m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 995,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.568m, 0.9761m, 1974.486m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 996,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.5752m, 0.9761m, 2017.682m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 997,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.5842m, 0.9761m, 1988.005m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 998,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.5872m, 0.9761m, 1909.706m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 999,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.5779m, 0.9549m, 1942.878m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1000,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.599m, 0.949m, 2041.325m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1001,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.591m, 0.949m, 1986.983m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1002,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.583m, 0.956m, 2165.784m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1003,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.582m, 0.965m, 2240.255m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1004,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.621m, 0.965m, 2373.915m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1005,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.591m, 0.959m, 2445.915m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1006,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6518m, 0.974m, 25535.46m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1007,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6615m, 0.9739m, 25034.06m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1008,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6634m, 0.9739m, 26243.54m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1009,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6635m, 0.9739m, 26106.98m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1010,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6695m, 0.9741m, 25880.15m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1011,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6658m, 0.9741m, 26925.75m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1012,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6666m, 0.9737m, 28322.52m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1013,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6761m, 0.9737m, 28823.79m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1014,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6707m, 0.9695m, 27854.63m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1015,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.668m, 0.97m, 28700.57m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1016,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.664m, 0.97m, 33764.88m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1017,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.682m, 0.971m, 34172.3m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1018,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.686m, 0.969m, 35098.14m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1019,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.693m, 0.969m, 38628.23m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1020,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.703m, 0.965m, 38816.67m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1021,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6821m, 0.9796m, 5645.035m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1022,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6731m, 0.9796m, 6548.591m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1023,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7049m, 0.9796m, 7457.853m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1024,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7221m, 0.9796m, 7978.933m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1025,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7194m, 0.9796m, 7459.681m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1026,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.714m, 0.9796m, 8754.412m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1027,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7111m, 0.9796m, 10884.06m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1028,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7204m, 0.9796m, 12382.66m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1029,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7212m, 0.9796m, 11935.65m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1030,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.709m, 0.98m, 11393.22m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1031,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.705m, 0.98m, 10782.83m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1032,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.713m, 0.98m, 10375.22m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1033,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.714m, 0.98m, 10475.92m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1034,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.706m, 0.98m, 10773.36m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1035,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.716m, 0.98m, 11898.03m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1036,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.5835m, 0.9796m, 3665.964m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1037,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6022m, 0.9796m, 3858.246m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1038,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6117m, 0.9796m, 3914.3m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1039,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6103m, 0.9796m, 3847.522m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1040,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6152m, 0.9796m, 3794.05m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1041,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6164m, 0.9796m, 4467.319m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1042,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6129m, 0.9796m, 4534.852m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1043,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.581m, 0.9796m, 4402.832m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1044,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6029m, 0.973m, 4762.775m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1045,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.613m, 0.973m, 4307.102m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1046,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.624m, 0.973m, 4391.667m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1047,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.614m, 0.97m, 4472.916m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1048,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.607m, 0.97m, 4933.899m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1049,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.614m, 0.97m, 4724.198m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1050,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.606m, 0.957m, 4675.658m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1051,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6328m, 0.9796m, 15019.13m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1052,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6487m, 0.9796m, 15765.84m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1053,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6466m, 0.9796m, 17292.58m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1054,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6513m, 0.9796m, 17343.59m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1055,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.652m, 0.9796m, 16712.84m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1056,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6529m, 0.9796m, 17082.18m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1057,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6547m, 0.9796m, 18947.18m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1058,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6599m, 0.9796m, 19535.58m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1059,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6541m, 0.9796m, 19599.98m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1060,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.646m, 0.98m, 20021.21m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1061,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.652m, 0.98m, 20126.7m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1062,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.664m, 0.98m, 21833.26m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1063,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.663m, 0.98m, 22257.83m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1064,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.665m, 0.98m, 22643.15m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1065,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.679m, 0.98m, 23426.36m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1066,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6437m, 0.96m, 1200.2m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1067,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.648m, 0.9612m, 1219.031m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1068,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6664m, 0.9612m, 1432.232m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1069,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6738m, 0.9612m, 1623.439m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1070,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6824m, 0.9683m, 1197.073m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1071,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.685m, 0.9683m, 1159.578m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1072,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7166m, 0.9683m, 1192.305m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1073,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7139m, 0.9683m, 1082.026m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1074,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7281m, 0.9673m, 1206.249m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1075,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.701m, 0.973m, 1081.745m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1076,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7m, 0.973m, 1124.133m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1077,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.672m, 0.974m, 1084.738m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1078,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.662m, 0.98m, 1147.588m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1079,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.664m, 0.98m, 1135.337m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1080,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.671m, 0.98m, 1161.404m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1081,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6509m, 0.9703m, 16881.59m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1082,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6444m, 0.9695m, 16885.85m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1083,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6442m, 0.9695m, 18297.71m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1084,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6467m, 0.9695m, 20173.74m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1085,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6479m, 0.9736m, 18630.14m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1086,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6525m, 0.9736m, 19922.18m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1087,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6539m, 0.973m, 22257.26m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1088,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6518m, 0.973m, 23678.43m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1089,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.652m, 0.9692m, 24147.44m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1090,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.655m, 0.969m, 23985.71m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1091,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.666m, 0.969m, 23253.41m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1092,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.67m, 0.977m, 23423.79m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1093,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.676m, 0.974m, 24156.92m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1094,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.677m, 0.974m, 24922.79m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1095,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.676m, 0.972m, 25733.89m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1096,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6864m, 0.9675m, 7328.235m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1097,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7012m, 0.9683m, 7912.738m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1098,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7141m, 0.9683m, 8087.252m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1099,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7167m, 0.9683m, 8806.466m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1100,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7238m, 0.9671m, 8453.117m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1101,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7177m, 0.9671m, 8967.695m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1102,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7121m, 0.9671m, 9604.271m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1103,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7094m, 0.9671m, 10296.98m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1104,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7219m, 0.9796m, 9972.656m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1105,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.76m, 0.98m, 11196.3m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1106,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.765m, 0.98m, 11037.91m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1107,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.777m, 0.98m, 10504.64m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1108,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.789m, 0.98m, 9918.979m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1109,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.784m, 0.98m, 9470.634m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1110,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.809m, 0.98m, 9349.051m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1111,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6104m, 0.9656m, 3456.931m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1112,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6122m, 0.9686m, 3955.813m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1113,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6339m, 0.9686m, 4277.035m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1114,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.628m, 0.9682m, 4315.452m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1115,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6055m, 0.9607m, 4472.347m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1116,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6011m, 0.9607m, 5036.576m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1117,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6315m, 0.9607m, 5235.203m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1118,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6469m, 0.9607m, 5305.041m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1119,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6391m, 0.9674m, 5543.208m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1120,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.638m, 0.961m, 5731.255m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1121,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.643m, 0.961m, 5577.239m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1122,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.641m, 0.972m, 5328.855m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1123,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.621m, 0.964m, 5061.949m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1124,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.635m, 0.964m, 5178.34m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1125,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.627m, 0.967m, 4984.244m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1126,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6566m, 0.9785m, 4306.21m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1127,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6458m, 0.9765m, 4301.042m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1128,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6747m, 0.9765m, 4450.21m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1129,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7002m, 0.9765m, 4566.982m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1130,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7176m, 0.9758m, 4366.499m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1131,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7245m, 0.9758m, 4465.861m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1132,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7697m, 0.9758m, 4675.477m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1133,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7715m, 0.9758m, 4793.441m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1134,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7894m, 0.9796m, 4839.163m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1135,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.776m, 0.98m, 5078.658m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1136,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.78m, 0.98m, 5299.772m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1137,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.814m, 0.98m, 5535.553m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1138,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.809m, 0.98m, 5653.873m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1139,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.804m, 0.98m, 5231.705m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1140,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.796m, 0.978m, 5023.496m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1141,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.725m, 0.9737m, 48927.25m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1142,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7383m, 0.9743m, 49987.09m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1143,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7399m, 0.9743m, 53241.43m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1144,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.749m, 0.9743m, 55229.3m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1145,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7444m, 0.9697m, 50422.8m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1146,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.747m, 0.9697m, 50537.11m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1147,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7659m, 0.9697m, 51570.82m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1148,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7608m, 0.9697m, 52639.27m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1149,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.773m, 0.9699m, 54937.63m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1150,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.776m, 0.97m, 52211.96m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1151,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.756m, 0.97m, 51646.98m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1152,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.737m, 0.97m, 51416.3m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1153,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.747m, 0.968m, 54214.22m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1154,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.736m, 0.968m, 54900.73m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1155,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.762m, 0.962m, 55546.73m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1156,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7994m, 0.9749m, 76284.13m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1157,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.8059m, 0.9787m, 82404.41m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1158,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.8239m, 0.9787m, 82927.94m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1159,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.8227m, 0.9787m, 93276.15m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1160,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.8404m, 0.9697m, 77868.12m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1161,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.8404m, 0.9697m, 83526.4m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1162,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.8403m, 0.9697m, 90692.06m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1163,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.8417m, 0.9697m, 94657.13m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1164,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.8374m, 0.9695m, 91538.94m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1165,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.85m, 0.974m, 84912.77m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1166,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.842m, 0.974m, 70774.21m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1167,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.83m, 0.973m, 67258.34m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1168,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.835m, 0.972m, 69599.84m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1169,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.842m, 0.972m, 75246.49m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1170,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.849m, 0.964m, 73665.37m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1171,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.5478m, 0.9531m, 1422.84m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1172,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.5575m, 0.9553m, 1481.511m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1173,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.5942m, 0.9553m, 1560.515m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1174,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6213m, 0.9553m, 1702.96m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1175,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6084m, 0.9612m, 1915.6m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1176,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.5888m, 0.9612m, 2118.287m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1177,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6026m, 0.9612m, 2321.936m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1178,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6053m, 0.9612m, 2554.777m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1179,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6458m, 0.9717m, 2674.586m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1180,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.658m, 0.972m, 2849.182m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1181,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.661m, 0.972m, 2829.879m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1182,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.664m, 0.969m, 2930.818m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1183,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.671m, 0.966m, 3278.167m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1184,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.68m, 0.966m, 3467.023m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1185,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.683m, 0.965m, 3631.058m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1186,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7509m, 0.9731m, 31824.05m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1187,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7649m, 0.9745m, 31891.88m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1188,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7859m, 0.9745m, 33771.13m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1189,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.788m, 0.9745m, 33758.56m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1190,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7808m, 0.9697m, 33797.24m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1191,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.781m, 0.9697m, 34903.34m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1192,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7805m, 0.9697m, 36292.58m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1193,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7799m, 0.9697m, 36036.32m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1194,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7772m, 0.9698m, 36690.31m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1195,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.782m, 0.97m, 37205.4m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1196,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.781m, 0.97m, 37060.37m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1197,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.791m, 0.969m, 38738.15m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1198,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.801m, 0.97m, 39728.56m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1199,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.799m, 0.97m, 40127.68m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1200,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.84m, 0.966m, 41523.29m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1201,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.5434m, 0.9506m, 3334.385m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1202,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.5509m, 0.9498m, 3592.01m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1203,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.5549m, 0.9498m, 3776.601m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1204,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.5458m, 0.9498m, 3912.264m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1205,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.5465m, 0.9557m, 4040.903m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1206,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.5583m, 0.9557m, 4204.751m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1207,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.5478m, 0.9557m, 4465.747m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1208,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.5459m, 0.9557m, 4509.281m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1209,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.5522m, 0.9666m, 4434.57m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1210,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.559m, 0.967m, 4487.553m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1211,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.556m, 0.967m, 4649.95m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1212,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.546m, 0.948m, 4587.607m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1213,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.55m, 0.946m, 4744.19m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1214,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.564m, 0.946m, 4957.905m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1215,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.556m, 0.944m, 5026.728m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1216,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6935m, 0.9791m, 13822.88m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1217,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6954m, 0.9796m, 14849.12m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1218,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7095m, 0.9796m, 13687.79m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1219,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7024m, 0.9796m, 14885.49m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1220,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7072m, 0.9753m, 15170.79m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1221,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7042m, 0.9753m, 16331.62m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1222,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7122m, 0.9753m, 18368.08m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1223,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7164m, 0.9753m, 20500.15m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1224,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7195m, 0.9796m, 21934.73m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1225,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.722m, 0.98m, 23682.28m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1226,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.721m, 0.98m, 24784.46m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1227,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.722m, 0.98m, 26691.2m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1228,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.722m, 0.98m, 29453.37m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1229,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.73m, 0.98m, 29914.99m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1230,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.737m, 0.973m, 29874.28m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1231,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6619m, 0.9761m, 6728.177m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1232,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6624m, 0.9714m, 7547.554m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1233,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6959m, 0.9714m, 8302.938m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1234,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7024m, 0.9714m, 9018.26m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1235,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6895m, 0.9658m, 8963.415m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1236,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6796m, 0.9658m, 10113.72m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1237,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6742m, 0.9658m, 11022.92m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1238,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6787m, 0.9658m, 11567.56m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1239,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7198m, 0.9705m, 11750.37m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1240,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.683m, 0.97m, 11764.56m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1241,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.687m, 0.97m, 11662.63m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1242,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.719m, 0.978m, 11748.04m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1243,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.72m, 0.977m, 11957.1m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1244,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.714m, 0.977m, 12158.82m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1245,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.721m, 0.964m, 12237.19m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1246,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7516m, 0.9796m, 4605.357m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1247,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7629m, 0.9796m, 4742.436m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1248,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7568m, 0.9796m, 5020.133m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1249,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7579m, 0.9796m, 5260.993m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1250,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7654m, 0.9796m, 5374.736m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1251,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7685m, 0.9796m, 5814.225m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1252,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7757m, 0.9796m, 6238.15m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1253,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7832m, 0.9796m, 6586.336m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1254,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7814m, 0.9796m, 6724.717m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1255,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.79m, 0.98m, 6885.865m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1256,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.786m, 0.98m, 7088.935m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1257,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.79m, 0.979m, 7557.486m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1258,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.799m, 0.979m, 7858.595m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1259,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.781m, 0.979m, 8229.062m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1260,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.784m, 0.979m, 8448.429m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1261,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6802m, 0.9791m, 17147.7m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1262,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6756m, 0.9791m, 17788.23m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1263,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6951m, 0.9791m, 19362.68m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1264,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6998m, 0.9791m, 20610.09m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1265,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7037m, 0.9785m, 21332.55m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1266,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7038m, 0.9785m, 23421.29m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1267,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7015m, 0.9791m, 25100.81m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1268,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7031m, 0.9791m, 25643.78m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1269,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7051m, 0.9791m, 25608.48m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1270,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.715m, 0.979m, 25937.29m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1271,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.727m, 0.979m, 27165.37m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1272,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.728m, 0.98m, 27770.16m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1273,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.728m, 0.98m, 29039.26m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1274,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.736m, 0.98m, 30512.47m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1275,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.713m, 0.98m, 31975.83m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1276,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6922m, 0.973m, 26611.85m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1277,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6959m, 0.973m, 27792.86m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1278,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7051m, 0.973m, 28345.29m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1279,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7013m, 0.973m, 28224.45m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1280,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7171m, 0.9742m, 27650.35m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1281,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7144m, 0.9742m, 28839.2m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1282,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7071m, 0.9724m, 28356.38m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1283,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7056m, 0.9724m, 28398.3m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1284,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7243m, 0.9724m, 27636.18m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1285,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.731m, 0.973m, 27802.42m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1286,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.737m, 0.973m, 28644.56m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1287,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.734m, 0.977m, 29441.9m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1288,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.732m, 0.978m, 30419.06m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1289,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.744m, 0.978m, 30909.93m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1290,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.775m, 0.972m, 31783.14m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1291,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6556m, 0.9796m, 7435.308m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1292,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6659m, 0.9796m, 7810.976m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1293,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6379m, 0.9796m, 8204.012m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1294,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6868m, 0.9796m, 8692.27m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1295,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6804m, 0.9758m, 9208.381m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1296,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6818m, 0.9758m, 10500.75m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1297,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6714m, 0.9758m, 11502.9m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1298,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6724m, 0.9758m, 11277.12m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1299,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.689m, 0.9796m, 11699.79m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1300,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.666m, 0.98m, 11973.91m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1301,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.676m, 0.98m, 11728.33m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1302,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.678m, 0.971m, 12008.76m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1303,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.672m, 0.972m, 12348.75m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1304,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.683m, 0.972m, 12378.27m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1305,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.702m, 0.974m, 12320.46m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1306,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6797m, 0.9791m, 11935.28m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1307,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6859m, 0.9791m, 13751.02m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1308,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6763m, 0.9791m, 15587.2m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1309,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6805m, 0.9791m, 18334.49m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1310,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6826m, 0.9773m, 17994.57m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1311,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6812m, 0.9791m, 18461.3m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1312,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6859m, 0.9791m, 18554.74m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1313,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6908m, 0.9791m, 19633.23m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1314,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6936m, 0.9791m, 19734.31m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1315,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.693m, 0.979m, 20319.18m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1316,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.69m, 0.979m, 21567.48m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1317,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.708m, 0.98m, 22812.9m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1318,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.711m, 0.98m, 25416.85m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1319,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.724m, 0.98m, 26486.84m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1320,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7m, 0.98m, 27879.91m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1321,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.677m, 0.9791m, 15075.77m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1322,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6866m, 0.9791m, 17682.25m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1323,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6994m, 0.9791m, 20818.78m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1324,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6987m, 0.9791m, 23910.62m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1325,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7036m, 0.9791m, 21302.23m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1326,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7037m, 0.9791m, 24171.71m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1327,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.698m, 0.9791m, 27624.26m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1328,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6983m, 0.9791m, 29743.52m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1329,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6927m, 0.9791m, 29414.32m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1330,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.694m, 0.979m, 28160.73m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1331,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.691m, 0.979m, 25280.77m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1332,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.696m, 0.98m, 25154.25m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1333,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.701m, 0.98m, 26793.07m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1334,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.706m, 0.98m, 28348.65m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1335,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.708m, 0.98m, 28521.95m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1336,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.5242m, 0.9771m, 32058.37m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1337,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.5647m, 0.9765m, 36559.21m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1338,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.5537m, 0.9765m, 39467.75m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1339,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.5651m, 0.9765m, 48283.33m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1340,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.5713m, 0.9762m, 42583.37m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1341,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.5753m, 0.9762m, 50691.58m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1342,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.5731m, 0.9762m, 62918.65m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1343,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.5879m, 0.9762m, 64971.34m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1344,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6059m, 0.9707m, 62608.24m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1345,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.605m, 0.966m, 61518.81m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1346,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.583m, 0.966m, 53915.44m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1347,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.584m, 0.965m, 49472.06m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1348,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.59m, 0.963m, 48480.62m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1349,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.599m, 0.963m, 51414.06m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1350,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.603m, 0.964m, 51817.2m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1351,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.655m, 0.9598m, 62050.06m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1352,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6609m, 0.9575m, 67342.92m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1353,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6625m, 0.9575m, 71261.2m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1354,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6664m, 0.9575m, 62577.99m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1355,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6914m, 0.9677m, 58688.77m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1356,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6914m, 0.9677m, 71934.34m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1357,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6989m, 0.9719m, 75876.34m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1358,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7m, 0.9719m, 75023.28m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1359,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7046m, 0.9671m, 71872.17m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1360,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.711m, 0.967m, 76900.02m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1361,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.712m, 0.967m, 75314.55m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1362,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.702m, 0.971m, 75501.62m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1363,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.707m, 0.965m, 81409.3m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1364,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.724m, 0.965m, 82712.34m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1365,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.727m, 0.963m, 82284.58m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1366,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6837m, 0.9796m, 3657.757m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1367,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6853m, 0.9796m, 4013.656m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1368,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6875m, 0.9796m, 4417.017m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1369,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6939m, 0.9796m, 4902.198m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1370,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6596m, 0.9796m, 5221.484m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1371,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6567m, 0.9796m, 6048.231m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1372,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.663m, 0.9796m, 7213.412m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1373,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6609m, 0.9796m, 7370.394m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1374,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6863m, 0.9796m, 7368.053m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1375,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.706m, 0.98m, 7580.331m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1376,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.702m, 0.98m, 7582.489m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1377,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.705m, 0.98m, 7705.801m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1378,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.69m, 0.98m, 7940.231m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1379,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.706m, 0.98m, 7985.878m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1380,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.738m, 0.98m, 8114.139m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1381,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6757m, 0.9796m, 20564.69m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1382,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6797m, 0.9796m, 21862.56m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1383,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6824m, 0.9796m, 23640.85m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1384,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6845m, 0.9796m, 26095.7m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1385,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6778m, 0.9796m, 24672.99m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1386,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6797m, 0.9796m, 27130.84m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1387,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6824m, 0.9796m, 27464.63m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1388,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6857m, 0.9796m, 27607.35m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1389,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6806m, 0.973m, 26557.38m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1390,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.675m, 0.973m, 27569.46m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1391,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.679m, 0.973m, 27602.39m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1392,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.694m, 0.98m, 26377.49m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1393,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.693m, 0.98m, 26443.43m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1394,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.718m, 0.98m, 26771.28m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1395,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.712m, 0.98m, 27445.88m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1396,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6745m, 0.973m, 28235.1m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1397,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6842m, 0.973m, 28196.52m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1398,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6937m, 0.973m, 29117.67m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1399,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6982m, 0.973m, 32088.71m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1400,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7047m, 0.9755m, 29334.04m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1401,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7041m, 0.9755m, 29809.01m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1402,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7132m, 0.973m, 30914.21m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1403,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7155m, 0.973m, 30495.8m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1404,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7443m, 0.973m, 30037.35m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1405,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.784m, 0.973m, 30368.31m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1406,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.786m, 0.973m, 29810.64m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1407,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.805m, 0.98m, 30486.09m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1408,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.784m, 0.98m, 31570.37m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1409,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.743m, 0.98m, 33577.43m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1410,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.741m, 0.977m, 34059.39m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1411,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.8133m, 0.9731m, 42798.98m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1412,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.8146m, 0.9735m, 44381.45m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1413,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.8139m, 0.9735m, 47031.04m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1414,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.8139m, 0.9735m, 47834.81m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1415,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.8024m, 0.9729m, 44304.74m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1416,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.8044m, 0.9729m, 46293.63m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1417,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.8159m, 0.9735m, 49345.9m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1418,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.8129m, 0.9735m, 49102.19m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1419,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.8165m, 0.9694m, 48641.37m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1420,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.823m, 0.974m, 48668.57m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1421,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.815m, 0.974m, 50078.8m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1422,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.816m, 0.969m, 50458.45m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1423,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.822m, 0.969m, 52005.52m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1424,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.82m, 0.969m, 51745.15m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1425,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.823m, 0.962m, 52405.54m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1426,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.5247m, 0.9764m, 1561.409m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1427,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.5381m, 0.9765m, 1638.803m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1428,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.529m, 0.9765m, 1762.715m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1429,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.5417m, 0.9765m, 1830.098m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1430,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.533m, 0.9612m, 1664.373m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1431,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.5334m, 0.9612m, 2136.079m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1432,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.5594m, 0.9612m, 2021.119m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1433,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.5588m, 0.9612m, 2115.053m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1434,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.5764m, 0.9683m, 1804.74m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1435,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.58m, 0.968m, 1811.604m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1436,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.587m, 0.968m, 1943.008m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1437,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.575m, 0.974m, 1681.578m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1438,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.58m, 0.971m, 1579.493m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1439,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.596m, 0.971m, 1621.184m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1440,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.593m, 0.97m, 1615.371m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1441,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6831m, 0.9796m, 10624.79m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1442,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6815m, 0.9796m, 11140.67m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1443,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6917m, 0.9796m, 11840.25m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1444,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6907m, 0.9796m, 12563.51m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1445,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.691m, 0.9796m, 12312.13m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1446,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6892m, 0.9796m, 13890.49m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1447,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6893m, 0.9796m, 14621.32m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1448,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6928m, 0.9796m, 16119.06m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1449,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7027m, 0.9796m, 16154.33m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1450,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.706m, 0.98m, 15644.08m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1451,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.699m, 0.98m, 15572.38m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1452,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.694m, 0.978m, 15812.35m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1453,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.702m, 0.978m, 16662.71m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1454,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.708m, 0.978m, 16925.73m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1455,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.71m, 0.978m, 17113.92m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1456,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.585m, 0.9691m, 14303.18m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1457,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.5768m, 0.9712m, 16122.13m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1458,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.5853m, 0.9712m, 17352.11m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1459,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.5828m, 0.9712m, 18268.29m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1460,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.5876m, 0.9755m, 17455.14m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1461,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.5954m, 0.9755m, 19772.18m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1462,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6015m, 0.9755m, 21787.52m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1463,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6081m, 0.9755m, 22532.17m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1464,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6183m, 0.9796m, 23660.32m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1465,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.624m, 0.98m, 24474.53m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1466,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.623m, 0.98m, 25755.9m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1467,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.625m, 0.977m, 25305.01m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1468,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.628m, 0.976m, 26607.21m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1469,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.635m, 0.976m, 27496.41m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1470,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.638m, 0.967m, 26942.95m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1471,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7038m, 0.9668m, 1595.096m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1472,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6969m, 0.9688m, 1720.569m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1473,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7068m, 0.9688m, 1836.45m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1474,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6797m, 0.9688m, 1962.931m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1475,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6829m, 0.9612m, 2046.939m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1476,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6904m, 0.9612m, 2284.766m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1477,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7091m, 0.9612m, 2613.801m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1478,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6928m, 0.9612m, 2381.831m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1479,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7182m, 0.9732m, 2403.748m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1480,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.718m, 0.979m, 2353.029m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1481,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.716m, 0.979m, 2468.65m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1482,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7m, 0.976m, 2404.671m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1483,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.704m, 0.978m, 2300.407m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1484,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.713m, 0.978m, 2318.536m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1485,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.707m, 0.97m, 2359.126m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1486,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6797m, 0.9756m, 1522.081m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1487,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6833m, 0.9758m, 1577.928m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1488,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6981m, 0.9758m, 1631.98m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1489,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7067m, 0.9758m, 1708.411m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1490,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7169m, 0.9796m, 1831.743m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1491,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.722m, 0.9796m, 1946.66m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1492,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7228m, 0.9796m, 2054.758m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1493,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7086m, 0.9796m, 1923.391m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1494,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6821m, 0.9674m, 1896.338m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1495,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.708m, 0.98m, 1906.311m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1496,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.704m, 0.98m, 1986.517m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1497,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.721m, 0.973m, 1901.543m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1498,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.724m, 0.98m, 1927.275m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1499,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.717m, 0.98m, 1992.46m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1500,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.717m, 0.98m, 2092.148m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1501,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6797m, 0.9796m, 7996.326m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1502,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.679m, 0.973m, 8924.563m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1503,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6856m, 0.9791m, 10185.05m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1504,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6896m, 0.9791m, 11011.82m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1505,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6869m, 0.9761m, 9262.981m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1506,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6861m, 0.9761m, 9611.318m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1507,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6894m, 0.9791m, 10785.03m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1508,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6935m, 0.973m, 11529.32m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1509,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7056m, 0.973m, 12003.56m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1510,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.702m, 0.979m, 11589.86m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1511,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7m, 0.979m, 10386.84m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1512,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.705m, 0.978m, 10921.27m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1513,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.708m, 0.978m, 12087.24m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1514,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.721m, 0.978m, 12682.48m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1515,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.714m, 0.978m, 13141.3m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1516,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6549m, 0.9796m, 11230.33m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1517,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6608m, 0.9796m, 11861.68m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1518,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6907m, 0.9796m, 13071.51m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1519,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6936m, 0.9796m, 14606.57m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1520,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6897m, 0.9796m, 15476.65m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1521,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6907m, 0.9796m, 17711.26m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1522,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6745m, 0.9796m, 19353.12m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1523,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6803m, 0.9796m, 19713.47m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1524,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.6871m, 0.9796m, 19970.58m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1525,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.679m, 0.98m, 20722.07m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1526,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.681m, 0.98m, 20544.32m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1527,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.71m, 0.98m, 20436.45m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1528,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.715m, 0.98m, 20616.57m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1529,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.737m, 0.98m, 20459.23m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1530,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.702m, 0.98m, 20547.13m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1531,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7042m, 0.9796m, 53969.44m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1532,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7002m, 0.9795m, 55033.14m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1533,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7179m, 0.9795m, 55562.12m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1534,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7173m, 0.9795m, 54933.81m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1535,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7411m, 0.9792m, 52871.9m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1536,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7412m, 0.9792m, 53887.27m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1537,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7373m, 0.9792m, 54379.98m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1538,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7392m, 0.9792m, 55352.19m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1539,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7463m, 0.9747m, 56144.38m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1540,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.74m, 0.975m, 57250.78m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1541,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.722m, 0.975m, 58543.48m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1542,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.718m, 0.973m, 59115.25m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1543,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.72m, 0.976m, 60116.57m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1544,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.724m, 0.976m, 61619.13m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1545,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.763m, 0.97m, 62589.78m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1546,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.4595m, 0.9786m, 3663.243m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1547,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.451m, 0.9796m, 3750.93m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1548,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.4664m, 0.9796m, 3936.798m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1549,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.4609m, 0.9796m, 4218.762m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1550,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.4603m, 0.9727m, 4160.789m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1551,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.4873m, 0.9727m, 4890.136m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1552,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.5054m, 0.9727m, 4237.948m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1553,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.5128m, 0.9727m, 3916.155m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1554,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.5145m, 0.9668m, 3905.088m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1555,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.484m, 0.967m, 3737.794m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1556,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.516m, 0.967m, 2532.597m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1557,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.516m, 0.968m, 2022.449m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1558,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.499m, 0.966m, 1428.431m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1559,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.494m, 0.966m, 1755.031m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1560,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.492m, 0.968m, 1776.894m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1561,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7125m, 0.9756m, 11680.49m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1562,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7194m, 0.9754m, 12411.01m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1563,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7232m, 0.9754m, 12990.01m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1564,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7709m, 0.9754m, 13101.76m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1565,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7535m, 0.9677m, 12560.2m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1566,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7478m, 0.9677m, 12895.28m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1567,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7496m, 0.9677m, 13399.86m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1568,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.751m, 0.9677m, 13222.02m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1569,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.7527m, 0.9796m, 13104.39m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1570,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.759m, 0.98m, 13027.72m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1571,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.764m, 0.98m, 12930.89m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1572,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.756m, 0.98m, 12694.21m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1573,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.755m, 0.98m, 12733.46m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1574,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.78m, 0.98m, 12669.67m });

            migrationBuilder.UpdateData(
                table: "Gaps",
                keyColumn: "Id",
                keyValue: 1575,
                columns: new[] { "general", "health", "pcgdp" },
                values: new object[] { 0.781m, 0.979m, 12534.4m });
        }
    }
}
