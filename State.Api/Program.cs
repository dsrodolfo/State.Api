using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using State.Application.Interfaces;
using State.Application.Mappings;
using State.Application.Services;
using State.Infrastructure.Context;
using State.Infrastructure.Interfaces;
using State.Infrastructure.Repositories;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddTransient<IStateService, StateService>();
builder.Services.AddTransient<IStateServiceByteTarget, StateServiceByteAdapter>();
builder.Services.AddTransient<IStateServiceXMLTarget, StateServiceXMLAdapter>();
builder.Services.AddTransient<IStateRepository, StateRepository>();

var connectionString = builder.Configuration.GetSection("DbContextSettings")["ConnectionString"];
builder.Services.AddDbContext<IStateDbContext, StateDbContext>(options => options.UseNpgsql(connectionString));

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

app.MapGet("/State/xml/getAll", ([FromServices] IStateServiceXMLTarget stateServiceXML) =>
{
    var xmlFile = stateServiceXML.GetAllStatesAsXML();

    return xmlFile?.OuterXml;
});

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

app.MapGet("/State/csv/download", ([FromServices] IStateServiceByteTarget stateServiceByte) =>
{
    var bytes = stateServiceByte.GetAllStatesAsBytes();

    return Results.File(bytes, "text/csv", "brazilian-states.csv");
});

app.Run();

public partial class Program { }