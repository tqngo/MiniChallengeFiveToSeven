using MiniChallengeFiveToSeven.Services;
using MiniChallengeFiveToSeven.Services.MadLib;
using MiniChallengeFiveToSeven.Services.OddOrEven;
using MiniChallengeFiveToSeven.Services.ReverseAlphanumeric;
using MiniChallengeFiveToSeven.Services.ReversedNumber;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IMadLibService, MadLibService>();
builder.Services.AddScoped<IOddOrEvenService, OddOrEvenService>();
builder.Services.AddScoped<IReverseAlphanumericService, ReverseAlphaNumericService>();
builder.Services.AddScoped<IReversedNumberService, ReversedNumberService>();

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
