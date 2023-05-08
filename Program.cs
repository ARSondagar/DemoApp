using DemoApp;
using DemoApp.Interface;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddTransient<IDataService, DataService>();
builder.Services.AddControllers();
var app = builder.Build();

app.MapControllers();
app.Run();
