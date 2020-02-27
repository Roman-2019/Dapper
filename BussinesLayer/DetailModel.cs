using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLayer
{
    public class DetailModel
    {
        public int Id { get; set; }
        public string NameDetail { get; set; }
        public int Number { get; set; }
        public Nullable<int> CarId { get; set; }
    }
}
