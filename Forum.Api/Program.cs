using Forum.Api;

var builder = WebApplication.CreateBuilder(args);

builder.AddDatabaseContext();
builder.AddControllers();
builder.AddEndpointsApiExplorer();
builder.AddSwagger();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
