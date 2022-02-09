using API.Models;

namespace API.Interfaces
{
    public interface LogDepartureInterface
    {
        IEnumerable<LogDeparture> select();
        LogDeparture getbyid(int id);   
        void insert(LogDeparture logDeparture);
        void delete(int Id);
        void update(LogDeparture logDeparture);
    }
}
