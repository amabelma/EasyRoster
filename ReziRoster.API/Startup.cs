using ReziRoster.API.Context;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace ReziRoster.API
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();

            // Contexts
            services.AddDbContext<EligiblePlayersContext>(options => options.UseSqlServer(_configuration.GetConnectionString("EligiblePlayersConnectionString")));
            services.AddDbContext<EventContext>          (options => options.UseSqlServer(_configuration.GetConnectionString("EventConnectionString"          )));
            services.AddDbContext<OrganizationContext>   (options => options.UseSqlServer(_configuration.GetConnectionString("OrganizationConnectionString"   )));
            services.AddDbContext<PlayerContext>         (options => options.UseSqlServer(_configuration.GetConnectionString("PlayerConnectionString"         )));
            services.AddDbContext<PlayerGroupingContext> (options => options.UseSqlServer(_configuration.GetConnectionString("PlayerGroupingConnectionString" )));
            services.AddDbContext<PlayerRankingContext>  (options => options.UseSqlServer(_configuration.GetConnectionString("PlayerRankingConnectionString"  )));
            services.AddDbContext<TeamContext>           (options => options.UseSqlServer(_configuration.GetConnectionString("TeamConnectionString"           )));
            services.AddDbContext<TeamRosterContext>     (options => options.UseSqlServer(_configuration.GetConnectionString("TeamRosterConnectionString"     )));
            services.AddDbContext<UserContext>           (options => options.UseSqlServer(_configuration.GetConnectionString("UserConnectionString"           )));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }

        private readonly IConfiguration _configuration;
    }
}
