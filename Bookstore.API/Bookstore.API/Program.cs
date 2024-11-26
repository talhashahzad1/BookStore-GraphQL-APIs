using Bookstore.API.Bookstore.API.GraphQL;
using Bookstore.API.GraphQL;
using Bookstore.Infrastructure;
using Bookstore.Infrastructure.Persistence;

var builder = WebApplication.CreateBuilder(args);

// Add Infrastructure Services (InMemory Database)
builder.Services.AddInfrastructure();

// Add GraphQL Server
builder.Services.AddGraphQLServer()
    .AddQueryType<AQuery>()
    .AddMutationType<Mutation>();

var app = builder.Build();

// Seed Initial Data
using (var scope = app.Services.CreateScope())
{
    var dbContext = scope.ServiceProvider.GetRequiredService<BookstoreDbContext>();
    SeedData.Initialize(dbContext);
}

// Configure the HTTP request pipeline
app.UseRouting();
app.MapGraphQL();

app.Run();
