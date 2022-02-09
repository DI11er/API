using Microsoft.EntityFrameworkCore;
using API.Context;
using API.Models;
using API.Interfaces;

namespace API.Repositories
{
    public class LogDepartureRepository: LogDepartureInterface
    {
        private MainContext _context;
        public LogDepartureRepository(MainContext context) { _context = context; }

        public IEnumerable<LogDeparture> select()
        {
            return _context.LogDeparture.FromSqlRaw("log_departure_select");
        }

        public LogDeparture getbyid(int Id)
        {
            Microsoft.Data.SqlClient.SqlParameter[] param = new Microsoft.Data.SqlClient.SqlParameter[1];
            param[0] = new Microsoft.Data.SqlClient.SqlParameter("@Id", Id);
            return _context.LogDeparture.FromSqlRaw("log_departure_get @Id", param).AsEnumerable().FirstOrDefault();
        }

        public void insert(LogDeparture logDeparture)
        {
            Microsoft.Data.SqlClient.SqlParameter[] param = new Microsoft.Data.SqlClient.SqlParameter[6];
            param[0] = new Microsoft.Data.SqlClient.SqlParameter("@IdCar", logDeparture.IdCar);
            param[1] = new Microsoft.Data.SqlClient.SqlParameter("@IdDriver", logDeparture.IdDriver);
            param[2] = new Microsoft.Data.SqlClient.SqlParameter("@IdFlight", logDeparture.IdFlight);
            param[3] = new Microsoft.Data.SqlClient.SqlParameter("@DepartureTimeDate", logDeparture.DepartureTimeDate);
            param[4] = new Microsoft.Data.SqlClient.SqlParameter("@ProductName", logDeparture.ProductName);
            param[5] = new Microsoft.Data.SqlClient.SqlParameter("@ProductValume", logDeparture.ProductValume);
            _context.Database.ExecuteSqlRaw("log_departure_insert @IdCar, @IdDriver, @IdFlight, @DepartureTimeDate, @ProductName, @ProductValume", param);
        }

        public void delete(int Id)
        {
            _context.Database.ExecuteSqlRaw($"log_departure_delete {Id}");
        }

        public void update(LogDeparture logDeparture)
        {
            Microsoft.Data.SqlClient.SqlParameter[] param = new Microsoft.Data.SqlClient.SqlParameter[7];
            param[0] = new Microsoft.Data.SqlClient.SqlParameter("@Id", logDeparture.Id);
            param[1] = new Microsoft.Data.SqlClient.SqlParameter("@IdCar", logDeparture.IdCar);
            param[2] = new Microsoft.Data.SqlClient.SqlParameter("@IdDriver", logDeparture.IdDriver);
            param[3] = new Microsoft.Data.SqlClient.SqlParameter("@IdFlight", logDeparture.IdFlight);
            param[4] = new Microsoft.Data.SqlClient.SqlParameter("@DepartureTimeDate", logDeparture.DepartureTimeDate);
            param[5] = new Microsoft.Data.SqlClient.SqlParameter("@ProductName", logDeparture.ProductName);
            param[6] = new Microsoft.Data.SqlClient.SqlParameter("@ProductValume", logDeparture.ProductValume);
            _context.Database.ExecuteSqlRaw("log_departure_update @Id, @IdCar, @IdDriver, @IdFlight, @DepartureTimeDate, @ProductName, @ProductValume", param);
        }

    }
}
