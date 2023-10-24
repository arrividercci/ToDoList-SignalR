using ToDoList_SignaIR.Hubs;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddSignalR();

builder.Services.AddCors(options =>
{
    options.AddPolicy("CorsPolicy", builder =>
    {
        builder.AllowAnyOrigin()
        .AllowAnyHeader()
        .AllowCredentials()
        .AllowAnyMethod()
        .WithOrigins("http://localhost:3000");
    });
});

var app = builder.Build();

app.UseDeveloperExceptionPage();

app.UseDefaultFiles();

app.UseStaticFiles();

app.UseCors("CorsPolicy");

app.UseRouting();

app.MapHub<ToDoListHub>("/todos");

app.Run();