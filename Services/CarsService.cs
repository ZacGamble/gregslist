using gregslist.Models;
using gregslist.FakeDB;

namespace gregslist.Services
{
    public class CarsService
    {
        internal List<Car> Get()
        {
            return Database.Cars;
        }

        internal Car Get(string id)
        {
            Car car = Database.Cars.Find(c => c.Id == id);
            if (car == null)
            {
                throw new Exception("Invalid Car ID");
            }
            return car;
        }
        internal Car Create(Car carData)
        {
            Database.Cars.Add(carData);
            return carData;
        }
        internal Car Edit(Car carData)
        {
            Car original = Get(carData.Id);
            original.Color = carData.Color ?? original.Color;
            original.Make = carData.Make ?? original.Make;
            original.Model = carData.Model ?? original.Model;
            original.Year = carData.Year;
            original.Price = carData.Price;
            return original;
        }
        internal void Delete(string id)
        {
            Car found = Get(id);
            Database.Cars.Remove(found);
        }
    }
}