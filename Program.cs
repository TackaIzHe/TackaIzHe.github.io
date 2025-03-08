var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", (context) => {
    Console.WriteLine(52);
    context.Response.Cookies.Append("Hello","52");
    return Task.CompletedTask;
});

app.Run();
