using FA.JustBlog.Core.Models;
using FA.JustBlog.Core.Service.ModelRepository;
using FA.JustBlog.Core.Service.UnitOfWork;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddScoped<IPostRepository, PostRepository>();
builder.Services.AddScoped<ITagRepository, TagRepository>();
builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();

builder.Services.AddDbContext<BlogContext>(options =>
{
    options.UseLazyLoadingProxies().UseSqlServer(builder.Configuration.GetConnectionString("default"));
});

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
//app.MapAreaControllerRoute(
//    name: "PostSort",
//    areaName: "Admin",
//    pattern: "Admin/{controller}/{action}/{sortBy?}",
//    defaults: new { area = "Admin", controller = "Post", action = "Index" }
//    );
app.MapAreaControllerRoute(
    name: "defaultAdmin",
    areaName: "Admin",
    pattern: "Admin/{controller=Post}/{action=Index}/{id?}",
    defaults: new { area = "Admin", controller = "Post", action = "Index" }
    );
//app.MapAreaControllerRoute(
//    name: "PostWithPageAndFilter",
//    areaName: "Admin",
//    pattern: "Admin/{controller=Post}/{action=Index}/{sortBy?}/{page?}",
//    defaults: new { area = "Admin", controller = "Post", action = "Index" }
//    );
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}"
    );
app.MapControllerRoute(
    name: "PostDetail",
    pattern: "{controller}/{year}/{month}/{title}",
    defaults: new { action="PostDetail"}
    );
app.MapControllerRoute(
    name: "PostByCategory",
    pattern: "{controller=Category}/{name}",
    defaults: new { controller = "Category", action = "PostByCategory" }
    );
app.MapControllerRoute(
    name: "PostByTag",
    pattern: "{controller=Tag}/{name}",
    defaults: new { controller = "Tag", action = "PostByTag" } 
    );


app.Run();
