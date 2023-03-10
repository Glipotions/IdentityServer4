using Microsoft.AspNetCore.Authentication.JwtBearer;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
        .AddJwtBearer(JwtBearerDefaults.AuthenticationScheme, options =>
        {
            //Token'ı yayınlayan Auth Server adresi bildiriliyor. Yani yetkiyi dağıtan mekanizmanın adresi bildirilerek ilgili API ile ilişkilendiriliyor.
            options.Authority = "https://localhost:1500";
            //Auth Server uygulamasındaki 'Garanti' isimli resource ile bu API ilişkilendiriliyor.
            options.Audience = "Garanti";
        });


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
app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
