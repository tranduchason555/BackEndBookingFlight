

using DOANMAYBAY2023.Models;
using DOANMAYBAY2023.Services;
using Microsoft.EntityFrameworkCore;
/*using DOANMAYBAY2023.Converters;*/
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors();
    builder.Services.AddControllers();
/*builder.Services.AddControllers().AddJsonOptions(option =>
{
    option.JsonSerializerOptions.Converters.Add(new DateTimeConverter());
});*/
var connectionString = builder.Configuration["ConnectionStrings:DefaultConnection"];
builder.Services.AddDbContext<DatabaseContext>(option => option.UseLazyLoadingProxies()
.UseSqlServer(connectionString));
builder.Services.AddScoped<ThongTinChuyenBayService, ThongTinChuyenBayServiceImpl>();
builder.Services.AddScoped<LienHeService, LienHeServiceImpl>();
builder.Services.AddScoped<SanBayService, SanBayServiceImpl>();
builder.Services.AddScoped<HanhKhachService, HanhKhachServiceImpl>();
builder.Services.AddScoped<VeService, VeServiceImpl>();
builder.Services.AddScoped<AdminUserService, AdminUserServiceImpl>();
var app = builder.Build();
app.UseCors(builder => builder
                .AllowAnyHeader()
                .AllowAnyMethod()
                .SetIsOriginAllowed((host) => true)
                .AllowCredentials()
            );

//app.UseMiddleware<BasicAuthMiddleware>();

app.UseStaticFiles();

app.MapControllers();
app.Run();
