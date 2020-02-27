using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public interface ICarRepository
    {
        List<Car> GetCars();
        Car GetCar(int id);
    }
}
