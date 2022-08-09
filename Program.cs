using Microsoft.EntityFrameworkCore;
using WebApiForBank;

var builder = WebApplication.CreateBuilder(args);
string connection = Resource.StringConnection;
builder.Services.AddDbContext<Context>(options => options.UseSqlServer(connection));


var app = builder.Build();

app.UseDefaultFiles();
app.UseStaticFiles();

app.MapGet("/api/TMA", async (Context db) => await db.TMA.ToListAsync());

app.MapGet("/api/TMA/{id:int}", async (int id, Context db) =>
{
    TableMoneyAccounts? tma = await db.TMA.FirstOrDefaultAsync(u => u.Id == id);
    if (tma == null) return Results.NotFound(new { message = "Счет по этому id не найден" });
    return Results.Json(tma);
});

app.MapGet("/api/TC", async (Context db) => await db.TC.ToListAsync());

app.MapGet("/api/TC/{id:int}", async (int id, Context db) =>
{
    TableCards? tc = await db.TC.FirstOrDefaultAsync(u => u.Id == id);
    if (tc == null) return Results.NotFound(new { message = "Карта по этому id не найдена" });
    return Results.Json(tc);
});

app.MapGet("/api/THO", async (Context db) => await db.THO.ToListAsync());

app.MapGet("/api/THO/{id:int}", async (int id, Context db) =>
{
    TableHisOfOper? tho = await db.THO.FirstOrDefaultAsync(u => u.Id == id);
    if (tho == null) return Results.NotFound(new { message = "История операции по этому id не найдена" });
    return Results.Json(tho);
});

app.MapGet("/api/TF", async (Context db) => await db.TF.ToListAsync());

app.MapGet("/api/TF/{id:int}", async (int id, Context db) =>
{
    TableFavourites? tf = await db.TF.FirstOrDefaultAsync(u => u.Id == id);
    if (tf == null) return Results.NotFound(new { message = "Избранное пользователя по этому id не найден" });
    return Results.Json(tf);
});
app.Run();



