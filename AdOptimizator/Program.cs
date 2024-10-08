var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(options =>
    {
        options.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
        options.RoutePrefix = string.Empty;
    });
}

app.UseRouting();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=OptimizeAd}/{action=Index}/{id?}");
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=GetSupportedPlatforms}/{action=Index}/{id?}");

app.Run();
