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
    }
}