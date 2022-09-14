using Microsoft.EntityFrameworkCore;
using TodoApi.Models;
using Microsoft.Extensions.DependencyInjection;
using ToDoAPI.Data;
using Microsoft.AspNetCore.OData;
using Microsoft.OData.ModelBuilder;



var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<ToDoAPIContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("ToDoAPIContext") ?? throw new InvalidOperationException("Connection string 'ToDoAPIContext' not found.")));
builder.Services.AddControllers().AddOData(options =>
               options.Select().Filter().OrderBy().Expand());
// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddDbContext<TodoContext>(opt =>
    opt.UseInMemoryDatabase("TodoList"));
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new() { Title = "TodoApi", Version = "v1" });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (builder.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
    app.UseSwagger();
    app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "TodoApi v1"));
}
app.UseDefaultFiles();
app.UseStaticFiles();
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();