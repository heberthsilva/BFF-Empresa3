using Api;
using Business.Interfaces.Gateways;
using Business.Interfaces.Services;
using Infrastructure.Gateways;
using Microsoft.OpenApi.Models;
using Service;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddScoped<ITermoUsoService, TermoUsoService>();
builder.Services.AddScoped<ITermoUsoGateway, TermoUsoGateway>();
builder.Services.AddScoped<IUserService, UsuarioService>();
builder.Services.AddScoped<IUsersGateway, UsersGateway>();
builder.Services.AddScoped<ISMSService, SMSService>();
builder.Services.AddScoped<IEmailService, EmailService>();
builder.Services.AddScoped<IEmailGateway, EmailGateway>();
builder.Services.AddScoped<ISMSGateway, SMSGateway>();
builder.Services.AddScoped<IMapaGateway, MapaGateway>();
builder.Services.AddScoped<IMapaService, MapaService>();

builder.Services.AddSwaggerGen(c =>
    {
        c.SwaggerDoc("v1", new OpenApiInfo { Title = "APP BFF Empresa3 +", Version = "v1" });
    }
    );

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();
app.UseDeveloperExceptionPage();

app.UseAuthorization();

app.MapControllers();

app.Run();
