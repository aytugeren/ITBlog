using AutoMapper;
using ITBlog.Business.AuthorServiceFolder;
using ITBlog.Business.AutoMapperFolder;
using ITBlog.Business.CategoryServiceFolder;
using ITBlog.Business.CommentServiceFolder;
using ITBlog.Business.FooterServiceFolder;
using ITBlog.Business.PictureServiceFolder;
using ITBlog.Business.PlaceServiceFolder;
using ITBlog.Business.PostServiceFolder;
using ITBlog.Business.SocialMediaFolder;
using ITBlog.Business.SubscriberServiceFolder;
using ITBlog.Business.UserServiceFolder;
using ITBlog.DataAccess.ContextFolder;
using ITBlog.DataAccess.RepositoryFolder;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
MapperConfiguration config = ITBlogProfile.Configuration();

IMapper mapper = config.CreateMapper();

builder.Services.AddSingleton(mapper);
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddTransient<ITBlogContext>();
builder.Services.AddTransient(typeof(IRepository<>), typeof(EfRepository<>));
builder.Services.AddTransient<IUserService, UserService>();

builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
}).AddJwtBearer(o =>
{
    o.TokenValidationParameters = new TokenValidationParameters
    {
        ValidIssuer = builder.Configuration["Jwt:Issuer"],
        ValidAudience = builder.Configuration["Jwt:Audience"],
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["Jwt:Key"])),
        ValidateIssuer = true,
        ValidateAudience = true,
        ValidateLifetime = false,
        ValidateIssuerSigningKey = true
    };
});
builder.Services.AddAuthorization();
// Add configuration from appsettings.json
builder.Configuration.AddJsonFile("appsettings.Development.json", optional: false, reloadOnChange: true)
    .AddEnvironmentVariables();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
