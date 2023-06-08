using System.Xml.Linq;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/ping", (ILogger<Program> logger, string? requestId) =>
{
    if (!string.IsNullOrEmpty(requestId))
    {
        logger.LogInformation("ping for request {RequestId}", requestId);
    }
    else
    {
        logger.LogInformation("ping with no requestId");
    }
    Results.Ok();
});

app.Run();
