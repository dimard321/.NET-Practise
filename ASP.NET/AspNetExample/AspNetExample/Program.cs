
using AspNetExamleDataLayer;
using AspNetExamleDataLayer.Repositories;
using AspNetExampleBusinesLayer.Services;
using AspNetExampleBusinesLayer.Services.Repositories;
using AspNetExampleDomain.Repositories;
using AspNetExampleDomain.Services;
using Microsoft.EntityFrameworkCore;

namespace AspNetExample
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            var connectionString = builder.Configuration.GetConnectionString("DbConnection");

            builder.Services.AddDbContext<EFContext>(opt =>
            {
                opt.UseMySql(connectionString, ServerVersion.Parse("8.1.0-1.el8"));
            });

            builder.Services.AddTransient<IStudentService, StudentService>();
            builder.Services.AddTransient<IStudentRepository, StudentRepository>();
            builder.Services.AddTransient<ICourseService, CourseService>();
            builder.Services.AddTransient<ICourseRepository, CourseRepository>();


            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}