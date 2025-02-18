using HexaDemo.Application;
using HexaDemo.Infrastructure;
using HexaDemo.Presentation;
using HexaDemo.Presentation.Middlewares;
using Scalar.AspNetCore;
using Microsoft.AspNetCore.OpenApi;

var builder = WebApplication.CreateBuilder(args);

// Додаємо шари проєкту
builder.Services.AddPresentation();
builder.Services.AddApplication();
builder.Services.AddInfrastructure();
// Якщо хочете нормальні СУБД
//builder.Services.AddInfrastructure(builder.Configuration);

var app = builder.Build();

// Налаштування HTTP-конвеєра
app.UseExceptionHandling();
if (app.Environment.IsDevelopment())
{ 
    // TODO: FIX
    // app.MapOpenApi();
    app.MapScalarApiReference();
}
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();
