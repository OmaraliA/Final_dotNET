using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.SpaServices.ReactDevelopmentServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace final.Models
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        
        public void ConfigureServices(IServiceCollection services)
        {
           services.AddMvc();
          services.AddCors();
        //    services.AddCors(options =>
        //   {
        //     options.AddPolicy("AllowSpecificOrigin",
        //       builder => builder.WithOrigins("http://localhost:3000") .AllowCredentials());
        //    });
         
           var connection = @"Server=ACEP;Database=Customer;Trusted_Connection=True;ConnectRetryCount=0";
           services.AddDbContext<CustomerContext>(options => options.UseSqlServer(connection));

            var connection1 = @"Server=ACEP;Database=Category;Trusted_Connection=True;ConnectRetryCount=0";
           services.AddDbContext<CategoryContext>(options => options.UseSqlServer(connection1));

            var connection2 = @"Server=ACEP;Database=Product;Trusted_Connection=True;ConnectRetryCount=0";
           services.AddDbContext<ProductContext>(options => options.UseSqlServer(connection2));

             var connection3 = @"Server=ACEP;Database=Detail;Trusted_Connection=True;ConnectRetryCount=0";
           services.AddDbContext<DetailContext>(options => options.UseSqlServer(connection3));

             var connection4 = @"Server=ACEP;Database=Master;Trusted_Connection=True;ConnectRetryCount=0";
           services.AddDbContext<MasterContext>(options => options.UseSqlServer(connection4));

            var connection5 = @"Server=ACEP;Database=Report;Trusted_Connection=True;ConnectRetryCount=0";
           services.AddDbContext<ReportContext>(options => options.UseSqlServer(connection5));


            // In production, the React files will be served from this directory
            services.AddSpaStaticFiles(configuration =>
            {
                configuration.RootPath = "ClientApp/build";
            });
            services.AddScoped<IProjectsRepository,CustomerRepository>();
            services.AddScoped<IProjectsManager, CustomerManager>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            
            
           
          // app.UseCors("AllowSpecificOrigin");

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseStaticFiles();
            app.UseSpaStaticFiles();
            app.UseCors(builder => builder.WithOrigins("http://localhost:3000").AllowAnyMethod().AllowAnyHeader().AllowAnyOrigin());
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller}/{action=Index}/{id?}");
            });
          
            app.UseSpa(spa =>
            {
                spa.Options.SourcePath = "ClientApp";

                if (env.IsDevelopment())
                {
                    spa.UseReactDevelopmentServer(npmScript: "start");
                }
            });
        }
    }
}
