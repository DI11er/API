using API.Models;

namespace API.Interfaces
{
    public interface CarInterface
    {
        IEnumerable<Car> select();
        Car getbyid(int Id);
        void insert (Car car);
        void delete (int Id);
        void update (Car car);
    }
}
