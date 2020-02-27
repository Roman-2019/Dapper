using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data;
using PresentationLayer;

namespace HWManyArchDapper
{
    class Program
    {
        static void Main(string[] args)
        {
            ICarController carsControllers = new CarController();
            IDetailController detailControllers = new DetailController();

            var totalres = from rescar in carsControllers.GetCarViewModel()
                           join resdetail in detailControllers.GetDetailViewModel()
                           on rescar.Id equals resdetail.CarId
                           select new { CarsId = rescar.Id, CarName = rescar.Name, Details = resdetail.NameDetail };


            foreach (var output in totalres)
            {
                Console.WriteLine(output);
            }

            Console.ReadKey();

        }
    }
}
