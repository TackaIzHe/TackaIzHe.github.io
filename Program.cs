var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/52", (context) => {
    context.Response.Cookies.Append("Hello","52");
    return Task.CompletedTask;
});

app.Run();
