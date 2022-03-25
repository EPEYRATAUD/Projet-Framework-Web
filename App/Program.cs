var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.Use(async (context, next) =>
{
    Console.WriteLine("...MW2 ===>");
    await next();
    Console.WriteLine("<=== MW2 ...");
});
app.Use(async (context, next) =>
{
    Console.WriteLine("...MW1 ===>");
    await next();
    Console.WriteLine("<=== MW1 ...");
});




app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();



// app.MapControllerRoute(
//     name: "listRaces",
//     defaults: new { controller = "Races", action = "List" },
//     pattern: "Races"
//     );

// This pattern is already declared by Home route and is the default "case" if none of the patterns above match
// app.MapControllerRoute(
//     name: "default",
//     pattern: "{controller}/{action}/{id?}");

// Cette config dit à ASP.NET : utilise le pattern par défaut controllerName/controllerAction 
// avec un segment optionnel "?" qui sera injecté en tant que paramètre nommé "id" dans l'action
// Si la route ne contient aucune "info" typiquement "/" alors utilise le controller Home et l'action Index
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapControllerRoute(
    name: "myGreatRoute",
    defaults: new { controller = "Races", action = "Create" },
    pattern: "races/createOne"
    );

app.Run();
