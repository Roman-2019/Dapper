using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DetailRepository:IDetailRepository
    {
        public List<Detail> GetDetails()
        {
            using (IDbConnection db = new SqlConnection(ConstString.connectionString))
            {
                return db.Query<Detail>("SELECT * FROM Details").ToList();
            }
        }

    }
}
