using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using MySql.Data.MySqlClient;
using NinjaQuest.Repositories;
using NinjaQuest.Services;

namespace NinjaQuest
{
    public class Startup
    {
        string _connectionString;
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
            _connectionString = Configuration.GetConnectionString("MySql");
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Latest);

            services.AddControllers();
            //registering new service, execute DBContext from line 40
            services.AddTransient<IDbConnection>(x => CreateDBContext());
            //every time we need the ninja repo, it needs a connection
            //when connection to ninja repo terminated, connection to db ends as well  
            services.AddTransient<NinjaRepository>();
            services.AddTransient<NinjasService>();
        }

        //establish connection to MySQL database using connection string
        private IDbConnection CreateDBContext()
            {
                IDbConnection connection = new MySqlConnection(_connectionString);
                connection.Open();
                return connection;
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
    }
}
