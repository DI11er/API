using Microsoft.EntityFrameworkCore;
using API.Context;
using API.Models;
using API.Interfaces;

namespace API.Repositories
{
    public class DriverRepository: DriverInterface
    {
        private MainContext _context;
        public DriverRepository(MainContext context) { _context = context; }

        public IEnumerable<Driver> select()
        {
            return _context.Driver.FromSqlRaw("driver_select");
        }

        public Driver getbyid(int Id)
        {
            Microsoft.Data.SqlClient.SqlParameter[] param = new Microsoft.Data.SqlClient.SqlParameter[1];
            param[0] = new Microsoft.Data.SqlClient.SqlParameter("@Id", Id);
            return _context.Driver.FromSqlRaw("driver_get @id", param).AsEnumerable().FirstOrDefault();
        }

        public void insert(Driver driver)
        {
            Microsoft.Data.SqlClient.SqlParameter[] param = new Microsoft.Data.SqlClient.SqlParameter[3];
            param[0] = new Microsoft.Data.SqlClient.SqlParameter("@Name", driver.Name);
            param[1] = new Microsoft.Data.SqlClient.SqlParameter("@Surname", driver.Surname);
            param[2] = new Microsoft.Data.SqlClient.SqlParameter("@Patronymic", driver.Patronymic);
            _context.Database.ExecuteSqlRaw("driver_insert @Name, @Surname, @Patronymic", param);
        }

        public void delete(int Id)
        {
            _context.Database.ExecuteSqlRaw($"driver_delete {Id}");
        }

        public void update(Driver driver)
        {
            Microsoft.Data.SqlClient.SqlParameter[] param = new Microsoft.Data.SqlClient.SqlParameter[4];
            param[0] = new Microsoft.Data.SqlClient.SqlParameter("@Id", driver.Id);
            param[1] = new Microsoft.Data.SqlClient.SqlParameter("@Name", driver.Name);
            param[2] = new Microsoft.Data.SqlClient.SqlParameter("@Surname", driver.Surname);
            param[3] = new Microsoft.Data.SqlClient.SqlParameter("@Patronymic", driver.Patronymic);
            _context.Database.ExecuteSqlRaw("driver_update @Id, @Name, @Surname, @Patronymic", param);
        }
    }
}
