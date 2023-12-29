using FA.JustBlog.Core.Models;
using FA.JustBlog.Core.Service.ModelRepository;
using FA.JustBlog.Core.Service.UnitOfWork;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using FA.JustBlog.Core.Models;
using FA.JustBlog.Core.Service.MailService;
using System.Configuration;
using Microsoft.AspNetCore.Identity.UI.Services;
using FA.JustBlog.Core.DataSeed;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddTransient<IPostRepository, PostRepository>();
builder.Services.AddTransient<ITagRepository, TagRepository>();
builder.Services.AddTransient<ICategoryRepository, CategoryRepository>();
builder.Services.AddTransient<IUnitOfWork, UnitOfWork>();



builder.Services.AddRazorPages();

builder.Services.AddDbContext<BlogContext>(options =>
{
    options.UseLazyLoadingProxies().UseSqlServer(builder.Configuration.GetConnectionString("default"));
});


builder.Services.AddIdentity<User, IdentityRole>()
    //.AddRoles<IdentityRole>()
    .AddDefaultUI()
    .AddEntityFrameworkStores<BlogContext>()
    .AddSignInManager<SignInManager<User>>()
    .AddDefaultTokenProviders();

builder.Services.AddOptions();                                        // Kích hoạt Options
var mailsettings = builder.Configuration.GetSection("MailSettings");  // đọc config
builder.Services.Configure<MailSettings>(mailsettings);               // đăng ký để Inject

builder.Services.AddScoped<IEmailSender, SendMailService>();        // Đăng ký dịch vụ Mail


builder.Services.Configure<IdentityOptions>(options =>
{
    // Thiết lập về Password
    options.Password.RequireDigit = false; // Không bắt phải có số
    options.Password.RequireLowercase = false; // Không bắt phải có chữ thường
    options.Password.RequireNonAlphanumeric = false; // Không bắt ký tự đặc biệt
    options.Password.RequireUppercase = false; // Không bắt buộc chữ in
    options.Password.RequiredLength = 3; // Số ký tự tối thiểu của password
    options.Password.RequiredUniqueChars = 1; // Số ký tự riêng biệt

    // Cấu hình Lockout - khóa user
    options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(5); // Khóa 5 phút
    options.Lockout.MaxFailedAccessAttempts = 5; // Thất bại 5 lầ thì khóa
    options.Lockout.AllowedForNewUsers = true;

    // Cấu hình về User.
    options.User.AllowedUserNameCharacters = // các ký tự đặt tên user
        "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-._@+";
    options.User.RequireUniqueEmail = true;  // Email là duy nhất

    // Cấu hình đăng nhập.
    options.SignIn.RequireConfirmedAccount = false;      // Cấu hình xác thực địa chỉ email (email phải tồn tại)
    options.SignIn.RequireConfirmedPhoneNumber = false;     // Xác thực số điện thoại

});

builder.Services.AddAuthorization(options =>
{
    options.AddPolicy("ForCreateSelectUpdate", policy => policy.RequireRole("Admin", "BlogOwner", "Contributor"));
    options.AddPolicy("OnlyBlogOwner", policy => policy.RequireRole("Admin", "BlogOwner"));
});

builder.Services.ConfigureApplicationCookie(options =>
{
    options.LoginPath = "/Login";
    options.AccessDeniedPath = "/AccessDenied";
    options.LogoutPath = "/Logout";
});

builder.Logging.AddConsole();

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

app.UseAuthentication();
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

using (var scope = app.Services.CreateScope())
{
   await SeedRole.CreateRole(scope.ServiceProvider);
}

app.MapRazorPages();
app.Run();
