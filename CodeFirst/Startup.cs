using CodeFirst.Models.BusinessModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace CodeFirst
{
    public class Startup
    {
        public IConfiguration Configuration { get; }
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            services.AddDbContext<BookManagementContext>(
                options => options.UseSqlServer(
                    Configuration.GetConnectionString("BookManagementString")));
        }

    }
}
