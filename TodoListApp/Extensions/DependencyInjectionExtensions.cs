using TodoListApp.Repositories;
using TodoListApp.Services;

namespace TodoListApp.Extensions;

public static class DependencyInjectionExtensions
{
    extension(IServiceCollection services)
    {
        public IServiceCollection AddRepositories()
        {
            services.AddScoped<ITodoTaskRepository, TodoTaskRepository>();
        
            return services;
        }

        public IServiceCollection AddServices()
        {
            services.AddScoped<ITodoTaskService, TodoTaskService>();
            
            return services;
        }
    }
}