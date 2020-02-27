using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace DAL
{
    public static class ConstString
    {
        public const string connectionString = @"Data Source=.\SQLSERVER;Initial Catalog=CarDetails;Integrated Security=True";
    }

    public class CarRepository:ICarRepository
    {
        public List<Car> GetCars() 
        {
            using (IDbConnection db = new SqlConnection(ConstString.connectionString))
            {
                return db.Query<Car>("SELECT * FROM Cars").ToList();
            }
        }
        public Car GetCar(int id) 
        {
            using (IDbConnection db = new SqlConnection(ConstString.connectionString))
            {
                return db.Query<Car>("SELECT * FROM Cars WHERE Id=@id", new { id}).FirstOrDefault();
            }
        }
    }
}
