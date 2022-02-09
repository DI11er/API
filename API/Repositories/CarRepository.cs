using Microsoft.EntityFrameworkCore;
using API.Context;
using API.Models;
using API.Interfaces;


namespace API.Repositories
{
    public class CarRepository: CarInterface
    {
        private MainContext _context;
        public CarRepository(MainContext context) { _context = context; }

        public IEnumerable<Car> select()
        {
            return _context.Car.FromSqlRaw("car_select");
        }

        public Car getbyid(int Id)
        {
            Microsoft.Data.SqlClient.SqlParameter[] param = new Microsoft.Data.SqlClient.SqlParameter[1];
            param[0] = new Microsoft.Data.SqlClient.SqlParameter("@Id", Id);
            return _context.Car.FromSqlRaw("car_get @Id", param).AsEnumerable().FirstOrDefault();
        }
        public void insert(Car car)
        {
            Microsoft.Data.SqlClient.SqlParameter[] param = new Microsoft.Data.SqlClient.SqlParameter[2];
            param[0] = new Microsoft.Data.SqlClient.SqlParameter("@Model", car.Model);
            param[1] = new Microsoft.Data.SqlClient.SqlParameter("@MaxWeight", car.MaxWeight);
            _context.Database.ExecuteSqlRaw("car_insert @Model, @MaxWeight", param);
        }

        public void delete(int Id)
        {
            _context.Database.ExecuteSqlRaw($"car_delete {Id}");
        }

        public void update(Car car)
        {
            Microsoft.Data.SqlClient.SqlParameter[] param = new Microsoft.Data.SqlClient.SqlParameter[3];
            param[0] = new Microsoft.Data.SqlClient.SqlParameter("@Id", car.Id);
            param[1] = new Microsoft.Data.SqlClient.SqlParameter("@Model", car.Model);
            param[2] = new Microsoft.Data.SqlClient.SqlParameter("@MaxWeight", car.MaxWeight);
            _context.Database.ExecuteSqlRaw("car_update @Id, @Model, @MaxWeight", param);
        }
    }
}
