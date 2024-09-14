using Microsoft.EntityFrameworkCore;
using ProyectoNegocio.Infrastructure.Data;
using ProyectoNegocio.Infrastructure.Interfaces;
using ProyectoNegocio.Infrastructure.Repository;
using ProyectoNegocio.Service;
using ProyectoNegocio.Service.Fragancy;
using ProyectoNegocio.Service.Product;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<AppDbContext>(opt=>
{
    opt.UseNpgsql(builder.Configuration.GetConnectionString("PostgresDb"));
});
builder.Services.AddAutoMapper(typeof(MappingProfile));
builder.Services.AddScoped(typeof(IGenericRepository<>), typeof(RepositoryBase<>));

builder.Services.AddScoped<IProductService, ProductService>();
builder.Services.AddScoped<IFragrancyService, FragrancyService>();
builder.Services.AddScoped<IProductTypeService, ProductTypeService>();

builder.Services.AddScoped<ProductRepository>();
builder.Services.AddScoped< FragrancyRepository>();
builder.Services.AddScoped<ProductTypeRepository>();



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
