using Business.Interfaces;
using Business;
using DAL.Handlers;
using DAL.Interfaces;
using Microsoft.EntityFrameworkCore.Design;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddCors(p => p.AddPolicy("corsapp", builder =>
{
    builder.WithOrigins("http://localhost:3000").AllowAnyMethod().AllowAnyHeader();
}));

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSingleton<IUserHandler, UserHandler>();
builder.Services.AddSingleton<IUserManager, UserManager>();
builder.Services.AddSingleton<IRankedHandler, RankedHandler>();
builder.Services.AddSingleton<IRankedManager, RankedManager>();
builder.Services.AddSingleton<IRoundHandler, RoundHandler>();
builder.Services.AddSingleton<IRoundManager, RoundManager>();
builder.Services.AddMvc().AddJsonOptions(options =>
{
    options.JsonSerializerOptions.PropertyNamingPolicy = null;
    options.JsonSerializerOptions.MaxDepth = 64;
    options.JsonSerializerOptions.IncludeFields = true;
});


var app = builder.Build();

IUserHandler user = app.Services.GetRequiredService<IUserHandler>();
IUserManager userManager = app.Services.GetRequiredService<IUserManager>();
IRankedHandler ranked = app.Services.GetRequiredService<IRankedHandler>();
IRankedManager rankedManager = app.Services.GetRequiredService<IRankedManager>();
IRoundHandler round = app.Services.GetRequiredService<IRoundHandler>();
IRoundManager roundManager = app.Services.GetRequiredService<IRoundManager>();


// Configure the HTTP request pipeline.
// if (app.Environment.IsDevelopment())
// {
app.UseSwagger();
app.UseSwaggerUI();
//}

app.UseHttpsRedirection();

app.UseAuthorization();

app.UseHttpsRedirection();
app.UseCors("corsapp");
app.UseAuthorization();

app.MapControllers();

app.Run();
