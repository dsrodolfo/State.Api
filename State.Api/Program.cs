using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using State.Api.Interfaces;
using State.Api.Mappings;
using State.Api.Repositories;
using State.Api.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddTransient<IStateService, StateService>();
builder.Services.AddTransient<StateRepository>();

var connectionString = builder.Configuration.GetSection("DbContextSettings")["ConnectionString"];
builder.Services.AddDbContext<StateDbContext>(options => 
    options.UseNpgsql(connectionString));

var mapperConfig = new MapperConfiguration(mc =>
{
    mc.AddProfile(new StateProfile());
});

IMapper mapper = mapperConfig.CreateMapper();
builder.Services.AddSingleton(mapper);
builder.Services.AddMvc();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.UseSwagger();
app.UseSwaggerUI();

app.MapGet("/State/getAll", ([FromServices] IStateService stateService) =>
{
    return stateService.GetAllStates();
});

app.MapGet("/State/getAll/{name}", ([FromServices] IStateService stateService, string name) =>
{
    var states = stateService.GetAllStatesByName(name);

    return states.Count() != 0 ? Results.Ok(states) : Results.NotFound();
});

app.MapGet("/State/flags/download", ([FromServices] IStateService stateService) =>
{
    string zipFileDirectory = stateService.DownloadFlags();

    return !string.IsNullOrWhiteSpace(zipFileDirectory)? 
        Results.File(zipFileDirectory, "application/zip", "brazilian-state-flags.zip") : 
        Results.NotFound();
});

app.Run();

public partial class Program { }