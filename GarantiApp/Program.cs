using Microsoft.AspNetCore.Authentication.JwtBearer;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
        .AddJwtBearer(JwtBearerDefaults.AuthenticationScheme, options =>
        {
            //Token'ý yayýnlayan Auth Server adresi bildiriliyor. Yani yetkiyi daðýtan mekanizmanýn adresi bildirilerek ilgili API ile iliþkilendiriliyor.
            options.Authority = "https://localhost:1500";
            //Auth Server uygulamasýndaki 'Garanti' isimli resource ile bu API iliþkilendiriliyor.
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
