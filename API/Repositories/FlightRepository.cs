using Microsoft.EntityFrameworkCore;
using API.Context;
using API.Models;
using API.Interfaces;

namespace API.Repositories
{
    public class FlightRepository: FlightInterface
    {
        private MainContext _context;
        public FlightRepository(MainContext context) { _context = context; }

        public IEnumerable<Flight> select()
        {
            return _context.Flight.FromSqlRaw("flight_select");
        }

        public Flight getbyid(int Id)
        {
            Microsoft.Data.SqlClient.SqlParameter[] param = new Microsoft.Data.SqlClient.SqlParameter[1];
            param[0] = new Microsoft.Data.SqlClient.SqlParameter("@Id", Id);
            return _context.Flight.FromSqlRaw("flight_get @Id", param).AsEnumerable().FirstOrDefault();
        }

        public void insert(Flight flight)
        {
            Microsoft.Data.SqlClient.SqlParameter[] param = new Microsoft.Data.SqlClient.SqlParameter[1];
            param[0] = new Microsoft.Data.SqlClient.SqlParameter("@Way", flight.Way);
            _context.Database.ExecuteSqlRaw("flight_insert @Way", param);
        }

        public void delete(int Id)
        {
            _context.Database.ExecuteSqlRaw($"flight_delete {Id}");
        }

        public void update(Flight flight)
        {
            Microsoft.Data.SqlClient.SqlParameter[] param = new Microsoft.Data.SqlClient.SqlParameter[2];
            param[0] = new Microsoft.Data.SqlClient.SqlParameter("@Id", flight.Id);
            param[1] = new Microsoft.Data.SqlClient.SqlParameter("@Way", flight.Way);
            _context.Database.ExecuteSqlRaw("flight_update @Id, @Way", param);
        }

    }
}
