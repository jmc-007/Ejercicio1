using Ejercicio1API.Controller;
using Ejercicio1API.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
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


app.MapGet("/addition", (decimal no1, decimal no2, decimal no3) =>
{
    var operation = new AdditionService();
    var x = new Ejercicio1Controller(operation);
    return x.Result(no1, no2, no3);

});

app.MapGet("/average", (decimal no1, decimal no2, decimal no3) =>
{
    var operation = new AverageService();
    var x = new Ejercicio1Controller(operation);
    return x.Result(no1, no2, no3);

});

app.MapGet("/multiplication", (decimal no1, decimal no2, decimal no3) =>
{
    var operation = new Multiplication();
    var x = new Ejercicio1Controller(operation);
    return x.Result(no1, no2, no3);

});

app.Run();


