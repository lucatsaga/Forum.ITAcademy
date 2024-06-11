using Forum.Contracts;
using Forum.Data;
using Forum.Entities;
using Forum.Repository;
using Forum.Service;
using Forum.Service.Implementations;
using Microsoft.EntityFrameworkCore;

namespace Forum.Api
{
    public static class MiddlewareExtensions
    {
        public static void AddDatabaseContext(this WebApplicationBuilder builder) => builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("SQLServerLocalConnection")));
        public static void AddControllers(this WebApplicationBuilder builder) => builder.Services.AddControllers();
        public static void AddEndpointsApiExplorer(this WebApplicationBuilder builder) => builder.Services.AddEndpointsApiExplorer();
        public static void AddSwagger(this WebApplicationBuilder builder)
        {
            builder.Services.AddSwaggerGen();
        }

        public static void AddAutoMapper(this WebApplicationBuilder builder)
        {
            var mapper = MappingInitializer.Initialize();
            builder.Services.AddSingleton(mapper);
        }

        public static void AddApplicationServices(this WebApplicationBuilder builder)
        {
            builder.Services.AddScoped<ICommentService, CommentService>();
            builder.Services.AddScoped<ITopicService, TopicService>();

            builder.Services.AddScoped<IRepository<Comment>, CommentRepository>();
            builder.Services.AddScoped<IRepository<Topic>, TopicRepository>();
        }
    }
}
