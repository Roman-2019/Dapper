using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLayer
{
    public class DetailService:IDetailService
    {
        private readonly IDetailRepository detailrepositoriyes;
        public DetailService() 
        {
            detailrepositoriyes = new DetailRepository();
        }
        public IEnumerable<DetailModel> GetDetailModel()
        {
            //IDetailRepository detailrepositoriyes = new DetailRepository();
            var result = from detail in detailrepositoriyes.GetDetails()
                         select new DetailModel()
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
