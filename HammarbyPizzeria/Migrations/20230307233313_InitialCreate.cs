using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HammarbyPizzeria.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MenuItems",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    number = table.Column<int>(type: "int", nullable: false),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    price = table.Column<int>(type: "int", nullable: false),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    category = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MenuItems", x => x.id);
                });

            migrationBuilder.InsertData(
                table: "MenuItems",
                columns: new[] { "id", "category", "description", "name", "number", "price" },
                values: new object[,]
                {
                    { 1, 0, "Tomat, ost", "Margherita", 1, 120 },
                    { 2, 0, "Ägg, räkor, champinjoner", "Hammarby", 2, 120 },
                    { 3, 0, "Inbakad med skinka", "Calzone", 3, 120 },
                    { 4, 0, "Skinka, köttfärs", "Orientale", 4, 120 },
                    { 5, 0, "Räkor, musslor", "Marinara", 5, 120 },
                    { 6, 0, "Skinka, räkor", "La Bussola", 6, 120 },
                    { 7, 0, "Skinka, champinjoner", "Capricciosa", 7, 120 },
                    { 8, 0, "Skinka", "Vesuvio", 8, 120 },
                    { 9, 0, "Skinka, tonfisk", "Del Opera", 9, 120 },
                    { 10, 0, "Tonfisk", "Pescatore", 10, 120 },
                    { 11, 0, "Oliver, sardeller", "Napolitana", 11, 120 },
                    { 12, 0, "Salami, lök", "Campagnola", 12, 120 },
                    { 13, 0, "Räkor, ananas", "Hawaii", 13, 120 },
                    { 14, 0, "Champinjoner, paprika, lök, oliver, kronärtskocka", "Vegetariana", 14, 120 },
                    { 15, 0, "Bacon, lök", "Maraton", 15, 120 },
                    { 16, 0, "Champinjoner", "Fungi", 16, 120 },
                    { 17, 0, "Sardeller, kapris, oliver, vitlök", "Siciliana", 17, 120 },
                    { 18, 0, "Ananas, banan, curry", "Tropicana", 18, 120 },
                    { 19, 0, "Salami, paprika, oliver", "Pepperone", 19, 120 },
                    { 20, 0, "Skinka, champinjoner, musslor, kronärtskocka, räkor, oliver", "Quattro stagioni", 20, 130 },
                    { 21, 0, "Skinka, gorgonzolaost", "Gorgonzola", 21, 125 },
                    { 22, 0, "Kyckling, lök, banan, curry", "Kycklingpizza", 22, 130 },
                    { 23, 0, "Oxfilé, lök, bearnaisesås", "Rodeo", 23, 140 },
                    { 24, 0, "Dubbelinbakad med skinka, champinjoner", "Tefat", 24, 160 },
                    { 25, 0, "Inbakad med skinka, champinjoner, räkor", "Calzone special", 25, 130 },
                    { 26, 0, "Skinka, jalapeno, vitlök, tacosås, tacokryddor", "Azteka", 26, 125 },
                    { 27, 0, "Kebab, tomat, peperoni, lök, vitlökssås", "Kebabpizza", 27, 140 },
                    { 28, 0, "Köttfärs, green chili, lök, vitlök, tacosås, tacokryddor", "Mexicana", 28, 135 },
                    { 29, 0, "Oxfilé, champinjoner, jalapeno, lök,vitlök, tacosås, tacokryddor", "Acapulco", 29, 140 },
                    { 30, 0, "Kyckling, ananas, jalapeno, srirachasås, honung", "Honungspizza", 30, 130 },
                    { 31, 0, "Skinka", "Barnpizza", 31, 100 },
                    { 32, 1, "Ruccola, tomat, parmaskinka, parmesan reggiano, mozzarella", "Parma", 32, 145 },
                    { 33, 1, "Färsk vitlök, färsk persilja, räkor, mozzarella", "Prezzemolo", 33, 135 },
                    { 34, 1, "Stark salami, paprika, soltorkade tomater, mozzarella", "Cacciatore", 34, 140 },
                    { 35, 1, "Ruccola, mozzarella, honung, chèvreost, pinjenötter", "Al Cabrino", 35, 140 },
                    { 36, 1, "Mozzarella, gorgonzola, chèvreost, parmesan", "Quattro Formaggio", 36, 140 },
                    { 37, 2, "Oliver, fårost, lök, peperoni", "Grekisk sallad", 1, 120 },
                    { 38, 2, "Majs, skinka, räkor, ost", "Smal & Lätt", 2, 120 },
                    { 39, 2, "Räkor, champinjoner, avokado", "Räksallad", 3, 120 },
                    { 40, 2, "Champinjoner, oliver, paprika, lök, peperoni", "Vegetarisk sallad", 4, 120 },
                    { 41, 2, "Tonfisk, ost, lök", "Tonfisksallad", 5, 120 },
                    { 42, 2, "Räkor, musslor", "Skaldjurssallad", 6, 120 }
                });

            migrationBuilder.InsertData(
                table: "MenuItems",
                columns: new[] { "id", "category", "description", "name", "number", "price" },
                values: new object[,]
                {
                    { 43, 2, "Ost, skinka", "Skinksallad", 7, 120 },
                    { 44, 2, "Skinka, ananas, räkor", "Hawaiisallad", 8, 120 },
                    { 45, 2, "Champinjoner, skinka, räkor", "Lillabas", 9, 120 },
                    { 46, 2, "Kyckling, majs", "Kycklingsallad", 10, 120 },
                    { 47, 2, "Kebab, lök, peperoni", "Kebabsallad", 11, 120 },
                    { 48, 4, "Serveras vardagar från klockan 10-14 (även avhämtning).", "Sallad eller valfri pizza 1-19 inklusive dryck", 1, 120 },
                    { 49, 3, "", "Lasagne", 1, 125 },
                    { 50, 3, "Köttfärsfyllning", "Pirog", 2, 120 },
                    { 51, 3, "", "Pizzasallad", 3, 10 },
                    { 52, 3, "", "Vitlökssås", 4, 15 },
                    { 53, 3, "", "Bearnaisesås", 5, 15 },
                    { 54, 3, "", "Läsk", 6, 20 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MenuItems");
        }
    }
}
