using Congress.Library.Books.Core.Interfaces;
using Congress.Library.Books.Core;
using Congress.Library.Books.Infra.Interfaces;
using Congress.Library.Books.Infra;
using Amazon.DynamoDBv2;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddSingleton(sp => sp.GetRequiredService<ILoggerFactory>().CreateLogger("BookServiceLogger"));
builder.Configuration.GetAWSOptions();
builder.Services.AddAWSService<IAmazonDynamoDB>();
builder.Services.AddScoped<IBookService, BookService>();

builder.Services.AddScoped<IBookRepository, BookRepository>();


// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
