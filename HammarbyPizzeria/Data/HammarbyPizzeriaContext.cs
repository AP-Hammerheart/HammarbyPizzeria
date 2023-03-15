using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using HammarbyPizzeria.Models;

namespace HammarbyPizzeria.Data
{
    public class HammarbyPizzeriaContext : DbContext
    {
        public HammarbyPizzeriaContext (DbContextOptions<HammarbyPizzeriaContext> options)
            : base(options)
        {
        }

        public DbSet<HammarbyPizzeria.Models.MenuItem> MenuItems { get; set; } = default!;

        protected override void OnModelCreating( ModelBuilder modelBuilder ) {
            base.OnModelCreating( modelBuilder );
            modelBuilder.Entity<MenuItem>().ToTable( "MenuItems" );
            modelBuilder.Entity<MenuItem>().HasData(
                new MenuItem { id = 1,  number = 1,  name = "Margherita", price = 120, description = "Tomat, ost", category = menuItemCategory.pizza },
                new MenuItem { id = 2,  number = 2,  name = "Hammarby", price = 120, description = "Ägg, räkor, champinjoner", category = menuItemCategory.pizza },
                new MenuItem { id = 3,  number = 3,  name = "Calzone", price = 120, description = "Inbakad med skinka", category = menuItemCategory.pizza },
                new MenuItem { id = 4,  number = 4,  name = "Orientale", price = 120, description = "Skinka, köttfärs", category = menuItemCategory.pizza },
                new MenuItem { id = 5,  number = 5,  name = "Marinara", price = 120, description = "Räkor, musslor", category = menuItemCategory.pizza },
                new MenuItem { id = 6,  number = 6,  name = "La Bussola", price = 120, description = "Skinka, räkor", category = menuItemCategory.pizza },
                new MenuItem { id = 7,  number = 7,  name = "Capricciosa", price = 120, description = "Skinka, champinjoner", category = menuItemCategory.pizza },
                new MenuItem { id = 8,  number = 8,  name = "Vesuvio", price = 120, description = "Skinka", category = menuItemCategory.pizza },
                new MenuItem { id = 9,  number = 9,  name = "Del Opera", price = 120, description = "Skinka, tonfisk", category = menuItemCategory.pizza },
                new MenuItem { id = 10, number = 10, name = "Pescatore", price = 120, description = "Tonfisk", category = menuItemCategory.pizza },
                new MenuItem { id = 11, number = 11, name = "Napolitana", price = 120, description = "Oliver, sardeller", category = menuItemCategory.pizza },
                new MenuItem { id = 12, number = 12, name = "Campagnola", price = 120, description = "Salami, lök", category = menuItemCategory.pizza },
                new MenuItem { id = 13, number = 13, name = "Hawaii", price = 120, description = "Räkor, ananas", category = menuItemCategory.pizza },
                new MenuItem { id = 14, number = 14, name = "Vegetariana", price = 120, description = "Champinjoner, paprika, lök, oliver, kronärtskocka", category = menuItemCategory.pizza },
                new MenuItem { id = 15, number = 15, name = "Maraton", price = 120, description = "Bacon, lök", category = menuItemCategory.pizza },
                new MenuItem { id = 16, number = 16, name = "Fungi", price = 120, description = "Champinjoner", category = menuItemCategory.pizza },
                new MenuItem { id = 17, number = 17, name = "Siciliana", price = 120, description = "Sardeller, kapris, oliver, vitlök", category = menuItemCategory.pizza },
                new MenuItem { id = 18, number = 18, name = "Tropicana", price = 120, description = "Ananas, banan, curry", category = menuItemCategory.pizza },
                new MenuItem { id = 19, number = 19, name = "Pepperone", price = 120, description = "Salami, paprika, oliver", category = menuItemCategory.pizza },
                new MenuItem { id = 20, number = 20, name = "Quattro stagioni", price = 130, description = "Skinka, champinjoner, musslor, kronärtskocka, räkor, oliver", category = menuItemCategory.pizza },
                new MenuItem { id = 21, number = 21, name = "Gorgonzola", price = 125, description = "Skinka, gorgonzolaost", category = menuItemCategory.pizza },
                new MenuItem { id = 22, number = 22, name = "Kycklingpizza", price = 130, description = "Kyckling, lök, banan, curry", category = menuItemCategory.pizza },
                new MenuItem { id = 23, number = 23, name = "Rodeo", price = 140, description = "Oxfilé, lök, bearnaisesås", category = menuItemCategory.pizza },
                new MenuItem { id = 24, number = 24, name = "Tefat", price = 160, description = "Dubbelinbakad med skinka, champinjoner", category = menuItemCategory.pizza },
                new MenuItem { id = 25, number = 25, name = "Calzone special", price = 130, description = "Inbakad med skinka, champinjoner, räkor", category = menuItemCategory.pizza },
                new MenuItem { id = 26, number = 26, name = "Azteka", price = 125, description = "Skinka, jalapeno, vitlök, tacosås, tacokryddor", category = menuItemCategory.pizza },
                new MenuItem { id = 27, number = 27, name = "Kebabpizza", price = 140, description = "Kebab, tomat, peperoni, lök, vitlökssås", category = menuItemCategory.pizza },
                new MenuItem { id = 28, number = 28, name = "Mexicana", price = 135, description = "Köttfärs, green chili, lök, vitlök, tacosås, tacokryddor", category = menuItemCategory.pizza },
                new MenuItem { id = 29, number = 29, name = "Acapulco", price = 140, description = "Oxfilé, champinjoner, jalapeno, lök,vitlök, tacosås, tacokryddor", category = menuItemCategory.pizza },
                new MenuItem { id = 30, number = 30, name = "Honungspizza", price = 130, description = "Kyckling, ananas, jalapeno, srirachasås, honung", category = menuItemCategory.pizza },
                new MenuItem { id = 31, number = 31, name = "Barnpizza", price = 100, description = "Skinka", category = menuItemCategory.pizza },
                new MenuItem { id = 32, number = 32, name = "Parma", price = 145, description = "Ruccola, tomat, parmaskinka, parmesan reggiano, mozzarella", category = menuItemCategory.mozzarellapizza },
                new MenuItem { id = 33, number = 33, name = "Prezzemolo", price = 135, description = "Färsk vitlök, färsk persilja, räkor, mozzarella", category = menuItemCategory.mozzarellapizza },
                new MenuItem { id = 34, number = 34, name = "Cacciatore", price = 140, description = "Stark salami, paprika, soltorkade tomater, mozzarella", category = menuItemCategory.mozzarellapizza },
                new MenuItem { id = 35, number = 35, name = "Al Cabrino", price = 140, description = "Ruccola, mozzarella, honung, chèvreost, pinjenötter", category = menuItemCategory.mozzarellapizza },
                new MenuItem { id = 36, number = 36, name = "Quattro Formaggio", price = 140, description = "Mozzarella, gorgonzola, chèvreost, parmesan", category = menuItemCategory.mozzarellapizza },
                new MenuItem { id = 37, number = 1,  name = "Grekisk sallad", price = 120, description = "Oliver, fårost, lök, peperoni", category = menuItemCategory.sallad },
                new MenuItem { id = 38, number = 2,  name = "Smal & Lätt", price = 120, description = "Majs, skinka, räkor, ost", category = menuItemCategory.sallad },
                new MenuItem { id = 39, number = 3,  name = "Räksallad", price = 120, description = "Räkor, champinjoner, avokado", category = menuItemCategory.sallad },
                new MenuItem { id = 40, number = 4,  name = "Vegetarisk sallad", price = 120, description = "Champinjoner, oliver, paprika, lök, peperoni", category = menuItemCategory.sallad },
                new MenuItem { id = 41, number = 5,  name = "Tonfisksallad", price = 120, description = "Tonfisk, ost, lök", category = menuItemCategory.sallad },
                new MenuItem { id = 42, number = 6,  name = "Skaldjurssallad", price = 120, description = "Räkor, musslor", category = menuItemCategory.sallad },
                new MenuItem { id = 43, number = 7,  name = "Skinksallad", price = 120, description = "Ost, skinka", category = menuItemCategory.sallad },
                new MenuItem { id = 44, number = 8,  name = "Hawaiisallad", price = 120, description = "Skinka, ananas, räkor", category = menuItemCategory.sallad },
                new MenuItem { id = 45, number = 9,  name = "Lillabas", price = 120, description = "Champinjoner, skinka, räkor", category = menuItemCategory.sallad },
                new MenuItem { id = 46, number = 10, name = "Kycklingsallad", price = 120, description = "Kyckling, majs", category = menuItemCategory.sallad },
                new MenuItem { id = 47, number = 11, name = "Kebabsallad", price = 120, description = "Kebab, lök, peperoni", category = menuItemCategory.sallad },
                new MenuItem { id = 48, number = 1,  name = "Sallad eller valfri pizza 1-19 inklusive dryck", price = 120, description = "Serveras vardagar från klockan 10-14 (även avhämtning).", category = menuItemCategory.lunch },
                new MenuItem { id = 49, number = 1,  name = "Lasagne", price = 125, description = "", category = menuItemCategory.other },
                new MenuItem { id = 50, number = 2,  name = "Pirog", price = 120, description = "Köttfärsfyllning", category = menuItemCategory.other },
                new MenuItem { id = 51, number = 3,  name = "Pizzasallad", price = 10, description = "", category = menuItemCategory.other },
                new MenuItem { id = 52, number = 4,  name = "Vitlökssås", price = 15, description = "", category = menuItemCategory.other },
                new MenuItem { id = 53, number = 5,  name = "Bearnaisesås", price = 15, description = "", category = menuItemCategory.other },
                new MenuItem { id = 54, number = 6,  name = "Läsk", price = 20, description = "", category = menuItemCategory.other }
            );
        }
    }
}
