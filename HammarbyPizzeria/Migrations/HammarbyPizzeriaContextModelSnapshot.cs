﻿// <auto-generated />
using HammarbyPizzeria.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HammarbyPizzeria.Migrations
{
    [DbContext(typeof(HammarbyPizzeriaContext))]
    partial class HammarbyPizzeriaContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("HammarbyPizzeria.Models.MenuItem", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<int>("category")
                        .HasColumnType("int");

                    b.Property<string>("description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("number")
                        .HasColumnType("int");

                    b.Property<int>("price")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("MenuItems", (string)null);

                    b.HasData(
                        new
                        {
                            id = 1,
                            category = 0,
                            description = "Tomat, ost",
                            name = "Margherita",
                            number = 1,
                            price = 120
                        },
                        new
                        {
                            id = 2,
                            category = 0,
                            description = "Ägg, räkor, champinjoner",
                            name = "Hammarby",
                            number = 2,
                            price = 120
                        },
                        new
                        {
                            id = 3,
                            category = 0,
                            description = "Inbakad med skinka",
                            name = "Calzone",
                            number = 3,
                            price = 120
                        },
                        new
                        {
                            id = 4,
                            category = 0,
                            description = "Skinka, köttfärs",
                            name = "Orientale",
                            number = 4,
                            price = 120
                        },
                        new
                        {
                            id = 5,
                            category = 0,
                            description = "Räkor, musslor",
                            name = "Marinara",
                            number = 5,
                            price = 120
                        },
                        new
                        {
                            id = 6,
                            category = 0,
                            description = "Skinka, räkor",
                            name = "La Bussola",
                            number = 6,
                            price = 120
                        },
                        new
                        {
                            id = 7,
                            category = 0,
                            description = "Skinka, champinjoner",
                            name = "Capricciosa",
                            number = 7,
                            price = 120
                        },
                        new
                        {
                            id = 8,
                            category = 0,
                            description = "Skinka",
                            name = "Vesuvio",
                            number = 8,
                            price = 120
                        },
                        new
                        {
                            id = 9,
                            category = 0,
                            description = "Skinka, tonfisk",
                            name = "Del Opera",
                            number = 9,
                            price = 120
                        },
                        new
                        {
                            id = 10,
                            category = 0,
                            description = "Tonfisk",
                            name = "Pescatore",
                            number = 10,
                            price = 120
                        },
                        new
                        {
                            id = 11,
                            category = 0,
                            description = "Oliver, sardeller",
                            name = "Napolitana",
                            number = 11,
                            price = 120
                        },
                        new
                        {
                            id = 12,
                            category = 0,
                            description = "Salami, lök",
                            name = "Campagnola",
                            number = 12,
                            price = 120
                        },
                        new
                        {
                            id = 13,
                            category = 0,
                            description = "Räkor, ananas",
                            name = "Hawaii",
                            number = 13,
                            price = 120
                        },
                        new
                        {
                            id = 14,
                            category = 0,
                            description = "Champinjoner, paprika, lök, oliver, kronärtskocka",
                            name = "Vegetariana",
                            number = 14,
                            price = 120
                        },
                        new
                        {
                            id = 15,
                            category = 0,
                            description = "Bacon, lök",
                            name = "Maraton",
                            number = 15,
                            price = 120
                        },
                        new
                        {
                            id = 16,
                            category = 0,
                            description = "Champinjoner",
                            name = "Fungi",
                            number = 16,
                            price = 120
                        },
                        new
                        {
                            id = 17,
                            category = 0,
                            description = "Sardeller, kapris, oliver, vitlök",
                            name = "Siciliana",
                            number = 17,
                            price = 120
                        },
                        new
                        {
                            id = 18,
                            category = 0,
                            description = "Ananas, banan, curry",
                            name = "Tropicana",
                            number = 18,
                            price = 120
                        },
                        new
                        {
                            id = 19,
                            category = 0,
                            description = "Salami, paprika, oliver",
                            name = "Pepperone",
                            number = 19,
                            price = 120
                        },
                        new
                        {
                            id = 20,
                            category = 0,
                            description = "Skinka, champinjoner, musslor, kronärtskocka, räkor, oliver",
                            name = "Quattro stagioni",
                            number = 20,
                            price = 130
                        },
                        new
                        {
                            id = 21,
                            category = 0,
                            description = "Skinka, gorgonzolaost",
                            name = "Gorgonzola",
                            number = 21,
                            price = 125
                        },
                        new
                        {
                            id = 22,
                            category = 0,
                            description = "Kyckling, lök, banan, curry",
                            name = "Kycklingpizza",
                            number = 22,
                            price = 130
                        },
                        new
                        {
                            id = 23,
                            category = 0,
                            description = "Oxfilé, lök, bearnaisesås",
                            name = "Rodeo",
                            number = 23,
                            price = 140
                        },
                        new
                        {
                            id = 24,
                            category = 0,
                            description = "Dubbelinbakad med skinka, champinjoner",
                            name = "Tefat",
                            number = 24,
                            price = 160
                        },
                        new
                        {
                            id = 25,
                            category = 0,
                            description = "Inbakad med skinka, champinjoner, räkor",
                            name = "Calzone special",
                            number = 25,
                            price = 130
                        },
                        new
                        {
                            id = 26,
                            category = 0,
                            description = "Skinka, jalapeno, vitlök, tacosås, tacokryddor",
                            name = "Azteka",
                            number = 26,
                            price = 125
                        },
                        new
                        {
                            id = 27,
                            category = 0,
                            description = "Kebab, tomat, peperoni, lök, vitlökssås",
                            name = "Kebabpizza",
                            number = 27,
                            price = 140
                        },
                        new
                        {
                            id = 28,
                            category = 0,
                            description = "Köttfärs, green chili, lök, vitlök, tacosås, tacokryddor",
                            name = "Mexicana",
                            number = 28,
                            price = 135
                        },
                        new
                        {
                            id = 29,
                            category = 0,
                            description = "Oxfilé, champinjoner, jalapeno, lök,vitlök, tacosås, tacokryddor",
                            name = "Acapulco",
                            number = 29,
                            price = 140
                        },
                        new
                        {
                            id = 30,
                            category = 0,
                            description = "Kyckling, ananas, jalapeno, srirachasås, honung",
                            name = "Honungspizza",
                            number = 30,
                            price = 130
                        },
                        new
                        {
                            id = 31,
                            category = 0,
                            description = "Skinka",
                            name = "Barnpizza",
                            number = 31,
                            price = 100
                        },
                        new
                        {
                            id = 32,
                            category = 1,
                            description = "Ruccola, tomat, parmaskinka, parmesan reggiano, mozzarella",
                            name = "Parma",
                            number = 32,
                            price = 145
                        },
                        new
                        {
                            id = 33,
                            category = 1,
                            description = "Färsk vitlök, färsk persilja, räkor, mozzarella",
                            name = "Prezzemolo",
                            number = 33,
                            price = 135
                        },
                        new
                        {
                            id = 34,
                            category = 1,
                            description = "Stark salami, paprika, soltorkade tomater, mozzarella",
                            name = "Cacciatore",
                            number = 34,
                            price = 140
                        },
                        new
                        {
                            id = 35,
                            category = 1,
                            description = "Ruccola, mozzarella, honung, chèvreost, pinjenötter",
                            name = "Al Cabrino",
                            number = 35,
                            price = 140
                        },
                        new
                        {
                            id = 36,
                            category = 1,
                            description = "Mozzarella, gorgonzola, chèvreost, parmesan",
                            name = "Quattro Formaggio",
                            number = 36,
                            price = 140
                        },
                        new
                        {
                            id = 37,
                            category = 2,
                            description = "Oliver, fårost, lök, peperoni",
                            name = "Grekisk sallad",
                            number = 1,
                            price = 120
                        },
                        new
                        {
                            id = 38,
                            category = 2,
                            description = "Majs, skinka, räkor, ost",
                            name = "Smal & Lätt",
                            number = 2,
                            price = 120
                        },
                        new
                        {
                            id = 39,
                            category = 2,
                            description = "Räkor, champinjoner, avokado",
                            name = "Räksallad",
                            number = 3,
                            price = 120
                        },
                        new
                        {
                            id = 40,
                            category = 2,
                            description = "Champinjoner, oliver, paprika, lök, peperoni",
                            name = "Vegetarisk sallad",
                            number = 4,
                            price = 120
                        },
                        new
                        {
                            id = 41,
                            category = 2,
                            description = "Tonfisk, ost, lök",
                            name = "Tonfisksallad",
                            number = 5,
                            price = 120
                        },
                        new
                        {
                            id = 42,
                            category = 2,
                            description = "Räkor, musslor",
                            name = "Skaldjurssallad",
                            number = 6,
                            price = 120
                        },
                        new
                        {
                            id = 43,
                            category = 2,
                            description = "Ost, skinka",
                            name = "Skinksallad",
                            number = 7,
                            price = 120
                        },
                        new
                        {
                            id = 44,
                            category = 2,
                            description = "Skinka, ananas, räkor",
                            name = "Hawaiisallad",
                            number = 8,
                            price = 120
                        },
                        new
                        {
                            id = 45,
                            category = 2,
                            description = "Champinjoner, skinka, räkor",
                            name = "Lillabas",
                            number = 9,
                            price = 120
                        },
                        new
                        {
                            id = 46,
                            category = 2,
                            description = "Kyckling, majs",
                            name = "Kycklingsallad",
                            number = 10,
                            price = 120
                        },
                        new
                        {
                            id = 47,
                            category = 2,
                            description = "Kebab, lök, peperoni",
                            name = "Kebabsallad",
                            number = 11,
                            price = 120
                        },
                        new
                        {
                            id = 48,
                            category = 4,
                            description = "Serveras vardagar från klockan 10-14 (även avhämtning).",
                            name = "Sallad eller valfri pizza 1-19 inklusive dryck",
                            number = 1,
                            price = 120
                        },
                        new
                        {
                            id = 49,
                            category = 3,
                            description = "",
                            name = "Lasagne",
                            number = 1,
                            price = 125
                        },
                        new
                        {
                            id = 50,
                            category = 3,
                            description = "Köttfärsfyllning",
                            name = "Pirog",
                            number = 2,
                            price = 120
                        },
                        new
                        {
                            id = 51,
                            category = 3,
                            description = "",
                            name = "Pizzasallad",
                            number = 3,
                            price = 10
                        },
                        new
                        {
                            id = 52,
                            category = 3,
                            description = "",
                            name = "Vitlökssås",
                            number = 4,
                            price = 15
                        },
                        new
                        {
                            id = 53,
                            category = 3,
                            description = "",
                            name = "Bearnaisesås",
                            number = 5,
                            price = 15
                        },
                        new
                        {
                            id = 54,
                            category = 3,
                            description = "",
                            name = "Läsk",
                            number = 6,
                            price = 20
                        });
                });
#pragma warning restore 612, 618
        }
    }
}