using System.Text;
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

var options = new SupabaseOptions { AutoRefreshToken = true, AutoConnectRealtime = true };

builder.Services.AddSingleton(provider => new Client(url, key, options));

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Services.AddAuthorization(options =>
{
    options.AddPolicy(
        "AdminPolicy",
        policy => { policy.RequireClaim("user_role", "admin"); }
    );
    options.AddPolicy(
        "ModeratorPolicy",
        policy =>
        {
            policy.RequireAssertion(context =>
                context.User.HasClaim(c =>
                    c.Type == "user_role" && (c.Value == "admin" || c.Value == "moderator")
                )
            );
        }
    );
    options.AddPolicy(
        "UserPolicy",
        policy =>
        {
            policy.RequireAssertion(context =>
                context.User.HasClaim(c =>
                    c.Type == "user_role"
                    && (c.Value == "admin" || c.Value == "moderator" || c.Value == "user")
                )
            );
        }
    );
});


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