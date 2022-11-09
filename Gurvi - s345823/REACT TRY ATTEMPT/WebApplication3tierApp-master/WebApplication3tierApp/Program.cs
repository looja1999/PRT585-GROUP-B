using _2DataAccessLayer.Context;
using _4Bootstrap;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var projectDevelopmentCorsOptions = "_projectDevelopmentCorsOptions";
var cnn = builder.Configuration.GetConnectionString("DefaultConnection");
var jwtSettings = builder.Configuration.GetSection("JwtSettings");
// Add services to the container.
builder.Services.AddDbContext<DBEntitiesContext>(options => options.UseSqlServer(cnn, b => b.MigrationsAssembly("2DataAccessLayer")));

#region CUSTOM SERVICES [D-I]

Bootstrap.Initialize(builder.Services, builder.Configuration);

//builder.Services.AddScoped<IDataAccessService, DataAccessService>();
//builder.Services.AddScoped<ICategoryService, CategoryService>();
//services.AddScoped<IApplicant_Service, Applicant_Service>();
//services.AddScoped<IGrade_Service, Grade_Service>();
//services.AddScoped<IApplication_Service, Application_Service>();
//services.AddScoped<IApplicationStatus_Service, ApplicationStatus_Service>();
#endregion


builder.Services.AddCors(options =>
{
    options.AddPolicy(name: projectDevelopmentCorsOptions, policy =>
    {
        policy.AllowAnyHeader().AllowAnyMethod().WithOrigins("http://localhost:3033", "http://localhost:3034", "http://localhost:4173", "http://localhost:4200").AllowCredentials();
    });
});

builder.Services.AddAuthentication(opt =>
{
    opt.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    opt.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
}).AddJwtBearer(options =>
{
    options.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateIssuer = true,
        ValidateAudience = true,
        ValidateLifetime = true,
        ValidateIssuerSigningKey = true,
        ValidIssuer = jwtSettings["validIssuer"],
        ValidAudience = jwtSettings["validAudience"],
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8
            .GetBytes(jwtSettings.GetSection("securityKey").Value))
    };
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
    app.UseCors(projectDevelopmentCorsOptions);
}

app.UseHttpsRedirection();

app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();

app.Run();
