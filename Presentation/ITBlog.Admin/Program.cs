using AutoMapper;
using ITBlog.Business.AuthorServiceFolder;
using ITBlog.Business.AutoMapperFolder;
using ITBlog.Business.PostServiceFolder;
using ITBlog.DataAccess.ContextFolder;
using ITBlog.DataAccess.RepositoryFolder;

var MyAllowSpecificOrigins = "_myAllowSpecificOrigins";

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
MapperConfiguration config = ITBlogProfile.Configuration();


IMapper mapper = config.CreateMapper();
builder.Services.AddCors();
builder.Services.AddTransient<ITBlogContext>();
builder.Services.AddTransient(typeof(IRepository<>), typeof(EfRepository<>));
builder.Services.AddSingleton(mapper);
builder.Services.AddTransient<IPostService, PostService>();
builder.Services.AddTransient<IAuthorService, AuthorService>();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddCors(options =>
{
    // this defines a CORS policy called "default"
    options.AddPolicy("ITBlog", policy =>
    {
        policy.WithOrigins("http://localhost:3000")
            .AllowAnyHeader()
            .AllowAnyMethod();
    });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("ITBlog");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
