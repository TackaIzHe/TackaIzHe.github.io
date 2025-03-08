var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", (context) => {
    context.Response.Cookies.Append("Hello","52");
    return Task.CompletedTask;
});

app.Run();
