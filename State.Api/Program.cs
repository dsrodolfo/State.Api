using Microsoft.AspNetCore.Mvc;
using State.Api.Interfaces;
using State.Api.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSingleton<IStateService, StateService>();

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
    string[] states = stateService.GetAllStatesByName(name);

    return states.Length != 0 ? Results.Ok(states) : Results.NotFound();
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