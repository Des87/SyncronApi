using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using System.Data.Entity;
using Microsoft.Identity.Web;
using MongoDB.Driver;
using SyncronApi;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddMicrosoftIdentityWebApi(builder.Configuration.GetSection("AzureAd"));

builder.Services.AddControllers();

//builder.Services.AddDbContext<Localdb>();
//       options => options.UseSqlServer("name=ConnectionStrings:DefaultConnection"));

//builder.Services.AddDbContext<Localdb>();

//var settings = MongoClientSettings.FromConnectionString("mongodb+srv://admin:<Qwert12345>@jobs.r80kd.mongodb.net/ServiceDinamic?retryWrites=true&w=majority");
//var client = new MongoClient(settings);
//var database = client.GetDatabase("test");



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

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
