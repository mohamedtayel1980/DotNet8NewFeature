using UsingKeyedServices.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

//builder.Services.AddSingleton<INotificationService, MailNotificationService>();
//builder.Services.AddSingleton<INotificationService, PhoneNotificationService>();
//builder.Services.AddSingleton<INotificationService, PushNotificationService>();

builder.Services.AddKeyedSingleton<INotificationService, MailNotificationService>("mail");
builder.Services.AddKeyedSingleton<INotificationService, PhoneNotificationService>("phone");
builder.Services.AddKeyedSingleton<INotificationService, PushNotificationService>("push");


builder.Services.AddSingleton<IShoppingCartService, ShoppingCartService>(); 

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
