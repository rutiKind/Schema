using Dal;
using MongoDB.Driver;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var client = new MongoClient("mongodb+srv://Bravermam:6K2cR9stqRieuCiy@cluster0.wmzpfow.mongodb.net/?retryWrites=true&w=majority&appName=Cluster0");
var database = client.GetDatabase("mydatabase");
var dbContext = new MydbContext
{
    users = database.GetCollection<User>("Users"),
    userTypes = database.GetCollection<userType>("userTypes")

};
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
