using System.Text.Json.Serialization;
using myAppC;

var builder = WebApplication.CreateBuilder(args);

// CORS (Cross-Origin Resource Sharing): allow requests from frontend to access API
builder.Services.AddCors(options => 
{
    options.AddDefaultPolicy(policy =>
    {
        policy.WithOrigins("http://localhost:5173"); // domain of React app
    });
});

builder.Services.AddControllers().AddJsonOptions(options => 
{ // ignore recursive injections in relational tables
    options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles; 
});

builder.Services.AddDbContext<GenderContext>();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors(); // Use CORS in the middleware pipeline

app.UseHttpsRedirection();

app.MapControllers();

app.Run();

