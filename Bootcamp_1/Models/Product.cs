namespace Bootcamp_1.Models
{
    public class Product
    {

        public int Id { get; set; }
        public string? ProductName { get; set; }
        public string? Image { get; set; }
        public string? Description { get; set; }
        public int? RoomCount { get; set; }
        public int? GarageCount { get; set; }
        public int? Price { get; set; }

        public bool isActive;
        public bool isHome;


    }
}
