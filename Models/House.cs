using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace gregslist.Models
{
    public class House
    {
        public string Id { get; set; }
        [Required]
        public int Levels { get; set; }
        [Required]
        public int Bedrooms { get; set; }
        [Required]
        public int Bathrooms { get; set; }
        [Required]
        public int Footage { get; set; }
        public int Year { get; set; }
        [Required]
        public int Price { get; set; }
        public House(int levels, int bedrooms, int bathrooms, int footage, int year, int price)
        {
            Id = Guid.NewGuid().ToString();
            Levels = levels;
            Bedrooms = bedrooms;
            Bathrooms = bathrooms;
            Footage = footage;
            Year = year;
            Price = price;
        }
    }
}