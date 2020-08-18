using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EconomicMappingAPI.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "States",
                columns: table => new
                {
                    StateId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    GDP = table.Column<int>(nullable: false),
                    MainExport = table.Column<string>(nullable: true),
                    MainImport = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_States", x => x.StateId);
                });

            migrationBuilder.InsertData(
                table: "States",
                columns: new[] { "StateId", "GDP", "MainExport", "MainImport", "Name" },
                values: new object[,]
                {
                    { 1, 2, "coffee", "avocodos", "California" },
                    { 28, 67, "Fiscal Disaster", "Books", "Missouri" },
                    { 29, 5, "Grizzlies", "Glaciers", "Montana" },
                    { 30, 6, "Unhealthy cows", "Not Deodorant", "Nebraska" },
                    { 31, 7, "Gambling", "Regrettable Marriages", "Nevada" },
                    { 32, 8, "Peter Griffin", "Adam West", "New Hampshire" },
                    { 33, 9, "Wants to be New York", "New York", "New Jersey" },
                    { 34, 1, "Meth", "Cartel", "New Mexico" },
                    { 35, 2, " the Mafia", "RICO", "New York" },
                    { 36, 3, "Charlotte", "Beer", "North Carolina" },
                    { 37, 4, "Trash", "Flat AF", "North Dakota" },
                    { 38, 5, "What even is a Buckeye?", "Radioactive River Water", "Ohio" },
                    { 39, 6, "Home, HOME ON THE RANGE", "Where the deer and the antelope PLAY", "Oklahoma" },
                    { 40, 7, "Philly Cheese STEAK", "Cheese, Steak, and Philly", "Pennsylvania" },
                    { 41, 8, "Road", "Providence!!!!!!", "Rhode Island" },
                    { 42, 9, "Cotton", "an uncomfortable heritage", "South Carolina" },
                    { 43, 1, "Highway Bandits", "Probably stolen goods", "South Dakota" },
                    { 44, 2, "Country Music", "Run away wives", "Tennessee" },
                    { 45, 3, "Mormons", "Nothing, they already have it", "Utah" },
                    { 46, 4, "BERNIE", "FEEL THE BERN", "Vermont" },
                    { 47, 5, "Land of lovers", "Flowers, wine, and chocolates", "Virginia" },
                    { 48, 6, "Marijuana", "Nothing, Please go away", "Washington" },
                    { 27, 4, "Muddy Water", "Cotton", "Mississippi" },
                    { 26, 74, "OOPE", "the Minnesota Nice", "Minnesota" },
                    { 25, 56, "Eminem", "tolerable weather", "Michigan" },
                    { 24, 89, "CAHS", "Robbery", "Massachusetts" },
                    { 2, 3, "Cowboys", "Capitalism", "Texas" },
                    { 3, 23, "Spring Break", "Freshmen", "Flordia" },
                    { 4, 2, "COWS", "Nothing", "Wisconsin" },
                    { 5, 23542, "Wine", "California", "Oregon" },
                    { 6, 1, "Moonshine", "The bible", "Alabama" },
                    { 7, 4, "Corn", "Moonshine", "Arkansas" },
                    { 8, 0, "Fish", "IG Influencers", "Alaska" },
                    { 9, 2, "Sand", "Heat", "Arizona" },
                    { 10, 434, "Skiing", "Snow", "Colorado" },
                    { 11, 34, "Penguins", "CO2", "Connecticut" },
                    { 49, 7, "Coal", "I've got the black lung, Pa", "West Virginia" },
                    { 12, 3, "Babies", "Elephants", "Delaware" },
                    { 14, 5, "Colonialism", "Colonialism", "Hawaii" },
                    { 15, 678, "rebels", "Rebel flags", "Idaho" },
                    { 16, 456, "Al Capone", "Chicago", "Illinois" },
                    { 17, 45, "Hoosiers", "Corn", "Indiana" },
                    { 18, 56, "Hawkeyes", "Corn", "Iowa" },
                    { 19, 789, "Dustbowl", "Mahomes", "Kansas" },
                    { 20, 892, "Moonshine", "Pickles", "Kentucky" },
                    { 21, 987, "CrawDads", "Oil", "Louisiana" },
                    { 22, 345, "Crabbies", "Tourists", "Maine" },
                    { 23, 45, "Donald Trump", "Corruption", "Maryland" },
                    { 13, 3, "Racism", "Nothing, Leeches", "Georgia" },
                    { 50, 8, "Buffalo", "Popcorn", "Wyoming" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "States");
        }
    }
}
