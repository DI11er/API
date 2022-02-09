using API.Models;

namespace API.Interfaces
{
    public interface FlightInterface
    {
        IEnumerable<Flight> select();
        Flight getbyid(int id);
        void insert(Flight flight);
        void delete(int Id);
        void update(Flight flight);
    }
}
