using InventoryAPI.Data;
using InventoryAPI.Services; // ✅ Add this namespace
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// --- Add DbContext ---
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// --- Register custom services here ---
builder.Services.AddScoped<InvoiceService>(); // ✅ Add this line
// If you have more, like:
// builder.Services.AddScoped<ProductService>();
// builder.Services.AddScoped<EmployeeService>();
// builder.Services.AddScoped<PurchaseService>();

// --- Add built-in services ---
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// --- Configure middleware ---
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();
