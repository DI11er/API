using API.Models;

namespace API.Interfaces
{
    public interface DriverInterface
    {
        IEnumerable<Driver> select();
        Driver getbyid(int Id);
        void insert(Driver driver);
        void delete(int Id);
        void update(Driver driver);
    }
}
