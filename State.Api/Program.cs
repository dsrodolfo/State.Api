using Microsoft.AspNetCore.Mvc;
using State.Api.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSingleton<StateService>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.UseSwagger();
app.UseSwaggerUI();

app.MapGet("/State/getAll", ([FromServices] StateService stateService) =>
{
    return stateService.GetAllStates();
});

app.MapGet("/State/getAll/{name}", ([FromServices] StateService stateService, string name) =>
{
    string[] states = stateService.GetAllStatesByName(name);
    return states.Length != 0 ? Results.Ok(states) : Results.NotFound();
});

app.Run();