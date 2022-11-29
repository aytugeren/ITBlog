using AutoMapper;
using ITBlog.Business.AutoMapperFolder;
using ITBlog.DataAccess.ContextFolder;
using ITBlog.DataAccess.RepositoryFolder;
using ITBlog.Business.CategoryServiceFolder;
using ITBlog.Business.PictureServiceFolder;
using ITBlog.Business.FooterServiceFolder;
using ITBlog.Business.PostServiceFolder;
using ITBlog.Business.AuthorServiceFolder;
using ITBlog.Business.PlaceServiceFolder;
using ITBlog.Business.SubscriberServiceFolder;
using ITBlog.Business.SocialMediaFolder;
using ITBlog.Business.CommentServiceFolder;
using ITBlog.Business.UserServiceFolder;
using Microsoft.AspNetCore.Authentication.Cookies;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

MapperConfiguration config = ITBlogProfile.Configuration();

IMapper mapper = config.CreateMapper();

builder.Services.AddSingleton(mapper);

builder.Services.AddControllers();
builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
        .AddCookie(options =>
        {
            options.LoginPath = "/User/SignUp";
        });
builder.Services.AddTransient<ITBlogContext>();
builder.Services.AddTransient(typeof(IRepository<>), typeof(EfRepository<>));
builder.Services.AddTransient<ICategoryService, CategoryService>();
builder.Services.AddTransient<IPictureService, PictureService>();
builder.Services.AddTransient<IFooterService, FooterService>();
builder.Services.AddTransient<IPostService, PostService>();
builder.Services.AddTransient<IAuthorService, AuthorService>();
builder.Services.AddTransient<IPlaceService, PlaceService>();
builder.Services.AddTransient<ISubscriberService, SubscriberService>();
builder.Services.AddTransient<ISocialMediaService, SocialMediaService>();
builder.Services.AddTransient<ICommentService, CommentService>();
builder.Services.AddTransient<IUserService, UserService>();
builder.Services.AddRazorPages().AddNewtonsoftJson();

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
