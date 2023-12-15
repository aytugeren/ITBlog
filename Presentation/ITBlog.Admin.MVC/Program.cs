using AutoMapper;
using ITBlog.Business.AuthorServiceFolder;
using ITBlog.Business.AutoMapperFolder;
using ITBlog.Business.CategoryServiceFolder;
using ITBlog.Business.PictureServiceFolder;
using ITBlog.Business.PlaceServiceFolder;
using ITBlog.Business.PostServiceFolder;
using ITBlog.DataAccess.ContextFolder;
using ITBlog.DataAccess.RepositoryFolder;
using Microsoft.AspNetCore.Authentication.Cookies;

var builder = WebApplication.CreateBuilder(args);

MapperConfiguration config = ITBlogProfile.Configuration();

IMapper mapper = config.CreateMapper();

builder.Services.AddSingleton(mapper);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddTransient<ITBlogContext>();
builder.Services.AddTransient(typeof(IRepository<>), typeof(EfRepository<>));
builder.Services.AddTransient<IAuthorService, AuthorService>();
builder.Services.AddTransient<ICategoryService, CategoryService>();
builder.Services.AddTransient<IPlaceService, PlaceService>();
builder.Services.AddTransient<IPictureService, PictureService>();
builder.Services.AddTransient<IPostService, PostService>();


builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
        .AddCookie(options =>
        {
            options.LoginPath = "/Login/Index";
        });

var app = builder.Build();
app.UseAuthentication();
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
