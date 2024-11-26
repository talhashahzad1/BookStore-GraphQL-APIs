using Bookstore.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Bookstore.Infrastructure
{
    public static class ServiceExtensions
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            // Register the InMemory Database
            services.AddDbContext<BookstoreDbContext>(options =>
                options.UseInMemoryDatabase("BookstoreDb"));

            return services;
        }
    }
}
