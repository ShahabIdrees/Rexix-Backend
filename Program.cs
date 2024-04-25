// using RexixBackend.Data;
using Microsoft.EntityFrameworkCore;
using RexixBackend.Data;
using RexixBackend.Schema.Mutations;
using RexixBackend.Schema.Queries;
using RexixBackend.Services.Review;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddGraphQLServer().AddQueryType<Query>().AddMutationType<Mutation>();
var connectionString = builder.Configuration.GetConnectionString("AppDbConnectionString");
builder.Services.AddScoped<IReviewRepository, ReviewRepository>();
builder.Services.AddDbContext<AppDbContext>(options => options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)));
var app = builder.Build();


//app.MapGet("/", () => "Hello World!");
app.MapGraphQL();
app.Run();
