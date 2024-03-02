//������ �������� � ���, ��� ���� ����� json-���������, ���������� �� ��������� � ��������� �� ��� �������.

var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

app.UseDefaultFiles();
app.UseStaticFiles();

app.Map("/index", appBuilder =>
{
    appBuilder.Run(async context =>
    {
        context.Response.ContentType = "text/html; charset=utf-8";
        await context.Response.SendFileAsync("wwwroot/index.html");
    }
    );
}
);

app.Map("/duration", appBuilder =>
{
    appBuilder.Run(async context =>
    {
        context.Response.ContentType = "text/html; charset=utf-8";
        await context.Response.SendFileAsync("wwwroot/duration.html");
    }
    );
}
);

app.MapGet("/api/duration", () =>
{
    Console.WriteLine("���������� Duration");

    ReadAndParseJsonFileWithNewtonsoftJson<Duration> readDuration = new("Pages/Duration.json");
    Duration duration = readDuration.UseUserDefinedObjectWithNewtonsoftJson();
    return Results.Json(duration);
}
);

app.Map("/ratings", appBuilder =>
{
    appBuilder.Run(async context =>
    {
        context.Response.ContentType = "text/html; charset=utf-8";
        await context.Response.SendFileAsync("wwwroot/ratings.html");
    }
    );
}
);

app.MapGet("/api/ratings", () =>
{
    Console.WriteLine("���������� Ratings");

    ReadAndParseJsonFileWithNewtonsoftJson<Ratings> readRatings = new("Pages/Ratings.json");
    Ratings ratings = readRatings.UseUserDefinedObjectWithNewtonsoftJson();
    return Results.Json(ratings);
}
);

app.Map("/totalChats", appBuilder =>
{
    appBuilder.Run(async context =>
    {
        context.Response.ContentType = "text/html; charset=utf-8";
        await context.Response.SendFileAsync("wwwroot/totalChats.html");
    }
    );
}
);

app.MapGet("/api/totalChats", () =>
{
    Console.WriteLine("���������� totalChats");

    ReadAndParseJsonFileWithNewtonsoftJson<TotalChats> readTotalChats = new("Pages/Total Chats.json");
    TotalChats totalChats = readTotalChats.UseUserDefinedObjectWithNewtonsoftJson();
    return Results.Json(totalChats);
}
);

app.Map("/tags", appBuilder =>
{
    appBuilder.Run(async context =>
    {
        context.Response.ContentType = "text/html; charset=utf-8";
        await context.Response.SendFileAsync("wwwroot/tags.html");
    }
    );
}
);

app.MapGet("/api/tags", () =>
{
    Console.WriteLine("���������� Tags");

    ReadAndParseJsonFileWithNewtonsoftJson<Tags> readTags = new("Pages/tags.json");
    Tags tags = readTags.UseUserDefinedObjectWithNewtonsoftJson();
    return Results.Json(tags);
}
);

app.Run();
