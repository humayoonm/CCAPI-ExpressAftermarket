using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using CCAPI_ExpressAftermarket.Interface;
using CCAPI_ExpressAftermarket.Repository;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Refit;
using Spark.Configuration;

namespace CCAPI_ExpressAftermarket
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
            services.Configure<AppConfig>(Configuration.GetSection("ApiConfig"));
            services.AddHttpContextAccessor();
            services.AddSingleton(Configuration);

            services.AddControllers()
            .AddJsonOptions(options =>
            {
                options.JsonSerializerOptions.PropertyNamingPolicy = null;
            });

            string User = Configuration["ApiConfig:User"] ;
            string Password = Configuration["ApiConfig:Password"];
            string authHeader =  Convert.ToBase64String(Encoding.ASCII.GetBytes(string.Format("{0}:{1}", User, Password)));
            
            services.AddRefitClient<IExpressAftermarketApi>(new RefitSettings()
            {
                AuthorizationHeaderValueGetter = () => Task.FromResult(authHeader)
            })
            .ConfigureHttpClient(c => c.BaseAddress = new Uri(Configuration["ApiConfig:TestURL"]));

            services.AddTransient<TestData>();

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
