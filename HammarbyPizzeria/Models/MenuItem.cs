namespace HammarbyPizzeria.Models {
    public class MenuItem {
        public int id {
            get; set;
        }
        public int number {
            get; set;
        }
        public string name { get; set; } = string.Empty;
        public int price {
            get; set;
        }
        public string description { get; set; } = string.Empty;
        public menuItemCategory category {
            get; set;
        }

    }

    public enum menuItemCategory {
        pizza,
        mozzarellapizza,
        sallad,
        other,
        lunch
    }
}
