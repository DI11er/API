using Microsoft.EntityFrameworkCore;
using API.Context;
using API.Interfaces;
using API.Repositories;

namespace API
{
    public class Startup
    {
        public IConfiguration Configuration { get; }
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            string con = "Data Source=DESKTOP-U2HMBPD\\SQLEXPRESS;Initial Catalog=Motor_depot;Integrated Security=True";

            services.AddScoped<CarInterface, CarRepository>();
            services.AddScoped<DriverInterface, DriverRepository>();
            services.AddScoped<FlightInterface, FlightRepository>();
            //services.AddScoped<LogDepartureInterface, LogDepartureRepository>();

            services.AddDbContext<MainContext>(options => options.UseSqlServer(con));

            services.AddControllers(); 
        }
        public void Configure(IApplicationBuilder app)
        {

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers(); 
            });
        }
    }
}
