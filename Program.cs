using Microsoft.EntityFrameworkCore;
using WebApiForBank;

var builder = WebApplication.CreateBuilder(args);
string connection = Resource.StringConnection;
//builder.Services.AddDbContext<Context>(options => options.UseSqlServer(connection));


var app = builder.Build();

app.UseDefaultFiles();
app.UseStaticFiles();
//cледующий метод дл€ получени€ данных с таблицы счетов в формате string в табличной форме
app.MapGet("/api/TMA", async context =>
{
    context.Response.Headers.ContentLanguage = "ru-RU";
    context.Response.Headers.ContentType = "text/plain; charset=utf-8";
    await context.Response.WriteAsync("“аблица счетов(id; номер счета)" + '\n');
    using (Context db = new Context())
    {
        var info = db.TMA.FromSqlRaw("SELECT * FROM MoneyAccounts").ToList();
        foreach (var rows in info)
            await context.Response.WriteAsync(rows.Id.ToString()+"  "+ rows.Number.ToString() + '\n');
    }
});
//cледующий метод дл€ получени€ данных с таблицы карточек в формате string в табличной форме
app.MapGet("/api/T—", async context =>
{
    context.Response.Headers.ContentLanguage = "ru-RU";
    context.Response.Headers.ContentType = "text/plain; charset=utf-8";
    await context.Response.WriteAsync("“аблица карт(id; id счета, к которому прив€зана карта; номер карты; сумма на карте" + '\n');
    using (Context db = new Context())
    {
        var info = db.TC.FromSqlRaw("SELECT * FROM Cards").ToList();
        foreach (var rows in info)
            await context.Response.WriteAsync(rows.Id.ToString() + "  " + rows.IdMonAcc.ToString() + "  " + rows.Number.ToString() + "  " + rows.Value.ToString() + '\n');
    }
});
//cледующий метод дл€ получени€ данных с таблицы избранных операций пользовател€ в формате string в табличной форме
app.MapGet("/api/TF", async context =>
{
    context.Response.Headers.ContentLanguage = "ru-RU";
    context.Response.Headers.ContentType = "text/plain; charset=utf-8";
    await context.Response.WriteAsync("“аблица избранных операций(id; информаци€; код картинки" + '\n');
    using (Context db = new Context())
    {
        var info = db.TF.FromSqlRaw("SELECT * FROM Favourites").ToList();
        foreach (var rows in info)
            await context.Response.WriteAsync(rows.Id.ToString() + "  " + rows.info.ToString() + "  " + rows.Image.ToString() + '\n');
    }
});
//cледующий метод дл€ получени€ данных с таблицы истории операций пользовател€ в формате string в табличной форме
app.MapGet("/api/THO", async context =>
{
    context.Response.Headers.ContentLanguage = "ru-RU";
    context.Response.Headers.ContentType = "text/plain; charset=utf-8";
    await context.Response.WriteAsync("“аблица с историей операций(id; информаци€; код картинки" + '\n');
    using (Context db = new Context())
    {
        var info = db.THO.FromSqlRaw("SELECT * FROM History_Of_Operations").ToList();
        foreach (var rows in info)
            await context.Response.WriteAsync(rows.Id.ToString() + "  " + rows.info.ToString() + "  " + rows.Image.ToString() + '\n');
    }
});

app.Run();



