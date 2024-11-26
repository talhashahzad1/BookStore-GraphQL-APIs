
using Bookstore.Domain.Entities;
using Bookstore.Infrastructure.Persistence; 

namespace Bookstore.API
{

    namespace Bookstore.API.GraphQL
    {
        public class AQuery
        {
            public IQueryable<Book> getBooks([Service] BookstoreDbContext context) => context.Books;
             
        }
    }


}
