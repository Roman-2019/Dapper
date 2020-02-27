using BussinesLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentationLayer
{
    public class DetailController:IDetailController
    {
        private readonly IDetailService detailsevices;
        public DetailController() 
        {
            detailsevices = new DetailService();
        }
        public IEnumerable<DetailViewModel> GetDetailViewModel()
        {
            //IDetailService detailsevices = new DetailService();
            var result = from detail in detailsevices.GetDetailModel()
                         select new DetailViewModel()
                         {
                             Id = detail.Id,
                             NameDetail = detail.NameDetail,
                             Number = detail.Number,
                             CarId = detail.CarId
                         };
            return result;
        }
    }
}
