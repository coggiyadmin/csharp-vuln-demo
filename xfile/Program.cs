using Demo.Xfile.Services;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddSingleton<UserQuery>();
builder.Services.AddControllers();
var app = builder.Build();
app.MapControllers();
app.Run();
