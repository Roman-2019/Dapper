using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BussinesLayer;

namespace PresentationLayer
{
    public class CarController:ICarController
    {
        private readonly ICarService carservices;
        public CarController() 
        {
            carservices = new CarService();
        }
        public IEnumerable<CarViewModel> GetCarViewModel()
        {
            //ICarService carservices = new CarService();
            var result = from car in carservices.GetCarModel()
                         select new CarViewModel()
                         {
                             Id = car.Id,
                             Name = car.Name,
                         };
            return result;
        }
    }
}
