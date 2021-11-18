using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using Microsoft.OpenApi.Models;
using AutoMapper;
using StudentPortal.Model.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using RabbitMQ.Client;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using Microsoft.AspNetCore.Authentication.JwtBearer;

namespace StudentPortal
{
    public class Startup
    {
        // public ConnectionRMQ GetConn;
        public ConnectionRMQ GetConn= new ConnectionRMQ();
        public IConfiguration Configuration { get; }

        //  private ServiceProvider _Service;
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        
        }
      
        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            IConnection conn =GetConn.CreateConnection("localhost");
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Version = "v1",
                    Title = "ToDo API",
                    Description = "A simple example ASP.NET Core Web API",
                    TermsOfService = new Uri("https://example.com/terms"),
                    Contact = new OpenApiContact
                    {
                        Name = "",
                        Email = string.Empty,
                        Url = new Uri("https://twitter.com/"),
                    },
                    License = new OpenApiLicense
                    {
                        Name = "Use under LICX",
                        Url = new Uri("https://example.com/license"),
                    }
                });
            });
            services.AddControllers().AddNewtonsoftJson(p=> p.SerializerSettings.ReferenceLoopHandling= Newtonsoft.Json.ReferenceLoopHandling.Ignore);
            services.AddSwaggerGen();
            ServiceProvider sc = new ServiceProvider(services);
          
             var mapperConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new AutoMapperProfile());
            });
            IMapper mapper = mapperConfig.CreateMapper();
            services.AddSingleton(mapper);
            services.AddMvc();
         
            services.AddDbContext<StudentDbContext>(item => 
            {
                item.UseNpgsql(Configuration.GetConnectionString("conn"), s=> s.MigrationsAssembly("StudentPortal.Model"));
            });

            services.AddIdentity<IdentityUser, IdentityRole>()
                .AddEntityFrameworkStores<StudentDbContext>();


            #region Add claim    
            //services.AddAuthorization(options =>
            //{
            //    options.AddPolicy("DeleteRolePolicy", policy => policy.RequireClaim("Delete Role"));
            //    });
            #endregion

            #region Add Authentication  
            var signingKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Configuration["Tokens:Secret"]));
            services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            }).AddJwtBearer(options =>
            {
                options.SaveToken = true;
                options.RequireHttpsMetadata = false;
                options.TokenValidationParameters = new TokenValidationParameters()
                {
                    ValidIssuer = Configuration["Tokens:ValidIssuer"],
                    ValidateIssuer = false,
                    ValidAudiences = Configuration["Tokens:ValidAudience"].Split('|'),
                    ValidateAudience = false,
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Configuration["Tokens:Secret"])),
                    ValidateIssuerSigningKey = true,
                    AudienceValidator = (audiences, securityToken, validationParameters) =>
                    {
                        //bool isValid = false;



                        //if (audiences.Count() > 0)
                        // isValid = validationParameters.ValidAudiences.Contains(audiences.ElementAt(0));



                        //return isValid;
                        return true;
                    }
                };
            });
            #endregion
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseSwagger(c =>
       {
           c.SerializeAsV2 = true;
       });
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "API Project");
                c.RoutePrefix = string.Empty;
              
            });
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
          
            app.UseHttpsRedirection();

            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();
            

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
