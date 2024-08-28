using System.Text;
using Application;
using Infrastructure;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using Serilog;
using Supabase;
using WebApi.Middleware;

var builder = WebApplication.CreateBuilder(args);
builder.Host.UseSerilog(
    (context, configuration) => configuration.ReadFrom.Configuration(context.Configuration)
);
var url = builder.Configuration["Supabase:ProjectUrl"]!;
var key = builder.Configuration["Authentication:SupabaseApiKey"]!;

var options = new SupabaseOptions { AutoRefreshToken = true, AutoConnectRealtime = true, };

builder.Services.AddSingleton(provider => new Supabase.Client(url, key, options));

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddApplication().AddInfrastructure(builder.Configuration);

builder.Services.AddAuthorization();

var bytes = Encoding.UTF8.GetBytes(builder.Configuration["Authentication:JwtSecret"]!);

builder
    .Services.AddAuthentication(options =>
    {
        options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
        options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
    })
    .AddJwtBearer(options =>
    {
        options.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuerSigningKey = true,
            IssuerSigningKey = new SymmetricSecurityKey(bytes),
            ValidateIssuer = true,
            ValidateAudience = true,
            ValidAudience = builder.Configuration["Auth:ValidAudience"],
            ValidIssuer = builder.Configuration["Auth:ValidIssuer"]
        };
    });

var app = builder.Build();

app.UseMiddleware<ErrorHandlingMiddleware>();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseSerilogRequestLogging();

app.UseHttpsRedirection();

//Global Error Handling Middleware

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
