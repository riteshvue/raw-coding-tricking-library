var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

// CORS
builder.Services.AddCors(options =>
options.AddPolicy("All", build => build.AllowAnyHeader().AllowAnyOrigin().AllowAnyMethod()));

// Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("All");
app.UseHttpsRedirection();

app.UseRouting();
app.UseAuthorization();

app.MapControllers(); // Correct method for attribute-based routing

app.Run();
