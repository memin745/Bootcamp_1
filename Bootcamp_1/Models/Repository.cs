namespace Bootcamp_1.Models
{
    public class Repository
    {
        private static readonly List<Product> _products = new();

        static Repository()
        {
            _products = new List<Product> {
                new Product()
                {
                    Id = 1,
                    ProductName="Kayseri de Yazlık Villa",
                    Description="Ali Dağ Eteklerinde yer alan muhteşem manzaralı villa. ",
                    Image="budapest.jpg",
                    GarageCount=1,
                    Price=580000,
                    RoomCount=5,
                    isActive=true,
                    isHome=true,

                },
                 new Product()
                {
                    Id = 2,
                    ProductName="Bu Manzaraya Değer",
                    Description="Ali Dağ Eteklerinde yer alan muhteşem manzaralı villa.",
                    Image="dresden.jpg",
                    GarageCount=2,
                    Price=475000,
                    RoomCount=3,
                    isActive=true,
                    isHome=true,

                },
                  new Product()
                {
                    Id = 3,
                    ProductName="Kayseri Gün Batımı ",
                    Description="Ali Dağ Eteklerinde yer alan muhteşem manzaralı villa.",
                    Image="lviv.jpg",
                    GarageCount=1,
                    Price=980000,
                    RoomCount=8,
                    isActive=true,
                    isHome=true,

                },
                   new Product()
                {
                    Id = 4,
                    ProductName="Kırmızı Köprü",
                    Description="Ali Dağ Eteklerinde yer alan muhteşem manzaralı villa.",
                    Image="lyon.jpg",
                    GarageCount=3,
                    Price=9980000,
                    RoomCount=15,
                    isActive=true,
                    isHome=true,

                }
                 
            };
        }
        public static List<Product> Products
        {
            get
            {
                return _products;
            }
        }
        public static Product? GetById(int? id)
        {
            return _products.FirstOrDefault(c => c.Id == id);
        }
    }
}
