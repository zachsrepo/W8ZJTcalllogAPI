using W8ZJTcalllog.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.Options;
using System.Configuration;
using System.Data.Common;
using Pomelo.EntityFrameworkCore.MySql;

using Pomelo.EntityFrameworkCore.MySql.Internal;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
var conn = builder.Configuration.GetConnectionString("calllogDbContext");





builder.Services.AddDbContext<FccAmateurContext>(opts => opts.UseMySql(conn, Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.0.32-mysql")));
builder.Services.AddMvc();




builder.Services.AddCors();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseCors(x => x.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod());



app.UseAuthorization();

app.MapControllers();

app.Run();
