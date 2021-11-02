using State.Api.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.UseSwagger();
app.UseSwaggerUI();

app.MapGet("/State/getAll", () => new StateService().GetAllStates());
app.MapGet("/State/getAll/{name}", (string name) => new StateService().GetAllStatesByName(name));

app.Run();