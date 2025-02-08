using Service;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSingleton<IItemService, ItemService>();
builder.Services.AddSingleton<IUserService, UserService>();

// builder.Services.AddSession(options =>
// {
//     options.IdleTimeout = TimeSpan.FromMinutes(60);  
// });

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

//app.UseSession();
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();