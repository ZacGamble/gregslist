using System.ComponentModel.DataAnnotations;

namespace gregslist.Models
{
    public class Car
    {

        public string Id { get; set; }
        public string Color { get; set; }
        public string Make { get; set; }
        [RequiredAttribute]
        public string Model { get; set; }
        [RequiredAttribute]
        public int Year { get; set; }
        [RequiredAttribute]
        public int Price { get; set; }

        public Car(string color, string model, string make, int year, int price)
        {
            Id = Guid.NewGuid().ToString();
            Color = color;
            Model = model;
            Make = make;
            Year = year;
            Price = price;
        }
    }
}