using ClassLib_Shelter.Registers;
using ClassLib_Shelter.Model;
using ClassLib_Shelter.Filters;
using ClassLib_Shelter.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();



// Initialize the DistrictRegister with some sample data
DistrictRegister districts = new DistrictRegister();
ShelterRegister shelters = new ShelterRegister();
UserRegister users = new UserRegister();
BlogPostRegister blogs = new BlogPostRegister();

BookingRegister bookings = new BookingRegister();

#if DEBUG 
TestDataService testData = new TestDataService();
testData.DataDistricts(districts);
testData.DataShelters(shelters);
testData.DataUser(users);
testData.DataBooking(bookings, users, districts);
#endif

builder.Services.AddSingleton<DistrictRegister>(districts);
builder.Services.AddSingleton<ShelterRegister>(shelters);
builder.Services.AddSingleton<UserRegister>(users);
builder.Services.AddSingleton<BlogPostRegister>(blogs);
builder.Services.AddSingleton<BookingRegister>(bookings);


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();



}

app.UseHttpsRedirection();

app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();
app.MapRazorPages()
   .WithStaticAssets();

app.Run();
