using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using gregslist.Models;

namespace gregslist.FakeDB
{
    public static class Database
    {
        public static List<Car> Cars { get; set; } = new List<Car>()
        {
            new Car("White", "Ranger", "Ford", 2006, 5000),
            new Car("Brown", "Civic", "Honda", 1998, 4200)
        };
    }
}