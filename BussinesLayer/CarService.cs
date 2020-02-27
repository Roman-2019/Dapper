using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLayer
{
    public class CarService:ICarService
    {
        private readonly ICarRepository carservices;
        public CarService() 
        {
            carservices = new CarRepository();
        }
        public IEnumerable<CarModel> GetCarModel()
        {
            //ICarRepository carservices = new CarRepository();
            var result = from car in carservices.GetCars()
                         select new CarModel()
                         {
                             Id = car.Id,
                             Name = car.Name,
                         };
            return result;
        }

    }
}
