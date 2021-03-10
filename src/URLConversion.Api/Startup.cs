using Autofac;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Net.Http.Headers;
using Microsoft.OpenApi.Models;

namespace URLConversion.Api
{
    public class Startup
    {
        readonly string AllowClientOrigins = "_clientOrigins";
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddCors(options =>
            {
                options.AddPolicy(AllowClientOrigins,
                    builder =>
                    {
                        builder
                        .WithOrigins(Configuration.GetSection("AllowOrigins").Get<string[]>())
                        .AllowAnyMethod()
                        .WithHeaders(HeaderNames.ContentType, HeaderNames.Authorization)
                        .AllowCredentials();
                    });
            });
            services.AddControllers();
            services.AddSwaggerGen(s =>
            {
                s.SwaggerDoc("v1", new OpenApiInfo
                {
                    Title = "Url Conversion MicroService",
                    Version = "v1"
                });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();
            app.UseRouting();
            app.UseCors();
            app.UseAuthorization();
            app.UseSwagger();
            app.UseSwaggerUI(s =>
           {
               s.SwaggerEndpoint("/swagger/v1/swagger.json", "Url Conversion MicroService v1");
           });

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapPost("/echo",
                context => context.Response.WriteAsync("echo"))
                .RequireCors(AllowClientOrigins);

                endpoints.MapControllers()
                .RequireCors(AllowClientOrigins);
            });
        }
        
        public void ConfigureContainer(ContainerBuilder containerBuilder)
        {
            containerBuilder.RegisterModule(new ApiConfigModule());
        }
    }
}
