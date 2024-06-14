using Forum.Api;

var builder = WebApplication.CreateBuilder(args);

builder.AddDatabaseContext();
builder.ConfigureJwtOptions();
builder.AddIdentity();
builder.AddAuthentication();
//builder.AddHttpContextAccssor();
builder.AddControllers();
builder.AddEndpointsApiExplorer();
builder.AddSwagger();
builder.AddAutoMapper();
builder.AddApplicationServices();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();

app.Run();
