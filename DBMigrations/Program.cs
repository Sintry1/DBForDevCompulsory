using DBMigrations;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
builder.Services.AddDbContext<DBContext>();

app.MapGet("/", () => "Hello World!");

app.Run();
